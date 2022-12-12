﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string user = "root";            
            string pass = "3124";       // kolla rätt lösen

            string connString  = $"SERVER={server}; DATABASE = {database}; UID={user}; PASSWORD={pass};";

            conn = new MySqlConnection(connString);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            insertIntoList();
            refreshList();
        }

        private void BtnGetData_click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            deleteUser();
            refreshList();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            updateUser();
            refreshList();
        }

        private void refreshList()
        {
            // Töm listan
            elever.Clear();

            // skriva sql statment
            string strsql = $"SELECT * FROM elever1";

            // skapa mysql command objekt
            MySqlCommand cmd = new MySqlCommand(strsql, conn);

            // nollställer objekt
            lblID.Text = "ID";
            lblName.Text = "Namn";
            lblAge.Text = "Ålder";

            // öppnar koppling till db igen
            conn.Open();

            // exekvera kommando till db
            MySqlDataReader reader = cmd.ExecuteReader();

            // använder while loop för att läsa varje rad 

            // Spara ner data från databasen till listan elever
            while (reader.Read())
            {
                elever.Add(new Elev(Convert.ToInt32(reader["elever1_id"]), reader["elever1_name"].ToString(), Convert.ToInt32(reader["elever1_age"].ToString())));
            }
            // printar ut listan med id.nr från listan elever. 
            for (int i = 0; i < elever.Count; i++)
            {
                lblID.Text += Environment.NewLine + (i + 1);
                lblName.Text += Environment.NewLine + elever[i].Name;
                lblAge.Text += Environment.NewLine + elever[i].Age;
            }

            // stäng koppling
            conn.Close();
        }

        private void insertIntoList()
        {
            try
            {
                // hämta text från textfält
                string strName = TxtName.Text;
                int intAge = Convert.ToInt32(TxtAge.Text);

                // skriv SQL insert statment
                string strSql = $"INSERT INTO elever1(elever1_name, elever1_age) VALUES ('{strName}', {intAge})";

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
                MessageBox.Show("Wrong input\nName can only contain letters\nAge can only contain numbers");
            }
            finally
            {
                TxtBox.Clear();
                TxtName.Clear();
                TxtAge.Clear();
            }
        }

        private void deleteUser()
        {
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
                MessageBox.Show("Insert correct ID to delete user");
            }
            finally
            {
                TxtBox.Clear();
                TxtName.Clear();
                TxtAge.Clear();
            }
        }

        private void updateUser()
        {
            try
            {
                // hämta text från textfält
                string strId = TxtBox.Text;
                int i = Convert.ToInt32(strId);
                int id = elever[i - 1].Id;
                string strName = TxtName.Text;
                int intAge = Convert.ToInt32(TxtAge.Text);

                // skriv SQL delete statment
                string strSql = $"UPDATE elever1 SET elever1_name = '{strName}', elever1_age = {intAge} WHERE elever1_id = ({id})";

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
                MessageBox.Show("Could not update user\nInsert ID you want to update and new name and age");
            }
            finally
            {
                TxtBox.Clear();
                TxtName.Clear();
                TxtAge.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}