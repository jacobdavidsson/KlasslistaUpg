using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FirstWindowsForms
{
    public partial class Form1 : Form
    {

        MySqlConnection conn;
        
        // Lyft ut listan så den blir global och kan nås överallt
        List<Elev> elever = new List<Elev>();


        public Form1()
        {
            InitializeComponent();

            string server = "localhost";
            string database = "elever";
            //kolla rätt användarnamn och lösenord
            string user = "root";            
            string pass = "EmmaWindows";       // kolla rätt lösen

            string connString  = $"SERVER={server}; DATABASE = {database}; UID={user}; PASSWORD={pass};";

            conn = new MySqlConnection(connString);
        }

        //Knapp som sparar ny användare och hämtar ny lista
        private void BtnSave_Click(object sender, EventArgs e)
        {
            insertIntoList();
            refreshList();
        }

        //Hämtar lista
        private void BtnGetData_click(object sender, EventArgs e)
        {
            refreshList();
        }

        //Tar bort användare och uppdaterar lista
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            deleteUser();
            refreshList();
        }

        //Uppdaterar användare och lista
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            updateUser();
            refreshList();
        }

        //Hämtar data från databas och visar i en lista
        private void refreshList()
        {  
            // Töm listan
            elever.Clear();

            // skriva sql statment
            string strsql = $"SELECT * FROM elev_view2;"; // hämta från view istället

            // skapa mysql command objekt
            MySqlCommand cmd = new MySqlCommand(strsql, conn);

            // nollställer objekt
            lblID.Text = "ID";
            lblName.Text = "Namn";
            lblAge.Text = "Ålder";
            lblGrade.Text = "Årskurs";

            // öppnar koppling till db
            conn.Open();    

            // exekvera kommando till db
            MySqlDataReader reader = cmd.ExecuteReader();

            // Spara ner data från databasen till listan elever
            while (reader.Read())
            {
                elever.Add(new Elev(
                    Convert.ToInt32(reader["elever1_id"]),
                    reader["elever1_name"].ToString(),
                    Convert.ToInt32(reader["elever1_age"].ToString()), 
                    Convert.ToInt32(reader["Primaryschool_grade"].ToString())));
            }
            // printar ut listan med id.nr från listan elever. 
            for (int i = 0; i < elever.Count; i++)
            {
                lblID.Text += Environment.NewLine + (i + 1);
                lblName.Text += Environment.NewLine + elever[i].Name;
                lblAge.Text += Environment.NewLine + elever[i].Age;
                lblGrade.Text += Environment.NewLine + elever[i].Grade;
            }

            // stäng koppling
            conn.Close();

 


        }

        //Lägger till data till databas
        private void insertIntoList()
        {  
            //try catch för att programmet inte ska krascha
            try
            {
                // hämta text från textfält
                string strName = TxtName.Text;
                int intAge = Convert.ToInt32(TxtAge.Text);
                int intGrade = Convert.ToInt32(TxtGrade.Text);

                if (intGrade > 3 || intGrade < 1)
                {
                    intGrade = 1;
                    MessageBox.Show("Årskurs sattes till 1\nUppdatera till 1-3");

                }

                // skriv SQL insert statment
                string strSql = $"INSERT INTO elever1(elever1_name, elever1_age, Primaryschool_Primaryschool_id) VALUES ('{strName}', {intAge}, {intGrade})";

                // skapa en mysqlcommand objekt
                MySqlCommand cmd = new MySqlCommand(strSql, conn);

                // öppna koppling till DB
                conn.Open();

                // skicka iväg SQL command till db
                cmd.ExecuteReader();

                // stänga koppling till db
                conn.Close();

                // bekräftelse till användare "insert completed" 
                MessageBox.Show("Data insert completed"); // pop-up box
            }
            catch (Exception e)
            {
                //Felmeddelande
                MessageBox.Show("Wrong input\nName can only contain letters\nAge can only contain numbers");
            }
            finally
            {
                //Rensar bort all input från textfält vid knapptryck
                TxtBox.Clear();
                TxtName.Clear();
                TxtAge.Clear();
                TxtGrade.Clear();
            }
        }

    
        private void deleteUser()
        {
            //try catch för att programmet inte ska krascha
            try
            {
                // hämta text från textfält
                string strId = TxtBox.Text;

                // convert input.id till int, hämtar ut index i listan elever och sparar ner till int id 
                int i = Convert.ToInt32(strId);
                int id = elever[i - 1].Id;
                // raderar databas id
                string strSql = $"DELETE FROM elever1 WHERE elever1_id = ({id})";

                // skapa en mysqlcommand objekt
                MySqlCommand cmd = new MySqlCommand(strSql, conn);

                // öppna koppling till DB
                conn.Open();

                // skicka iväg SQL command till db
                cmd.ExecuteReader();

                // stänga koppling till db
                conn.Close();

                // bekräftelse till användare "deleted user" 
                MessageBox.Show("Deleted user"); // pop-up box
            }
            catch (Exception e)
            {
                //felmeddelande
                MessageBox.Show("Insert correct ID to delete user");
            }
            finally
            {
                //rensar textfält
                TxtBox.Clear();
                TxtName.Clear();
                TxtAge.Clear();
                TxtGrade.Clear();
            }
        }

        //Uppdaterar användare i databas
        private void updateUser()
        {
            //try catch för att programmet inte ska krascha
            try
            {
                // hämta text från textfält
                string strId = TxtBox.Text;
                int i = Convert.ToInt32(strId);
                int id = elever[i - 1].Id;
                string strName = TxtName.Text;
                int intAge = Convert.ToInt32(TxtAge.Text);
                int intGrade = Convert.ToInt32(TxtGrade.Text);

                if (intGrade > 3 || intGrade < 1)
                {
                    intGrade = 1;
                    MessageBox.Show("Årskurs sattes till 1\nUppdatera till 1-3");

                }

                // skriv SQL delete statment
                string strSql = $"UPDATE elever1 SET elever1_name = '{strName}', elever1_age = {intAge}, Primaryschool_Primaryschool_id = {intGrade} WHERE elever1_id = ({id})";

                // skapa en mysqlcommand objekt
                MySqlCommand cmd = new MySqlCommand(strSql, conn);

                // öppna koppling till DB
                conn.Open();

                // skicka iväg SQL command till db
                cmd.ExecuteReader();

                // stänga koppling till db
                conn.Close();

                // bekräftelse till användare "deleted user" 
                MessageBox.Show("Updated user"); // pop-up box
            }
            catch (Exception e)
            {
                //felmeddelande
                MessageBox.Show("Could not update user\nInsert ID you want to update and new name and age");
            }
            finally
            {
                //rensat textfält
                TxtBox.Clear();
                TxtName.Clear();
                TxtAge.Clear();
                TxtGrade.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
