namespace FirstWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.BtnGetData = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(352, 305);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(219, 68);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Spara i Databas";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ålder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Namn";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(637, 179);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(207, 31);
            this.TxtName.TabIndex = 4;
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(637, 252);
            this.TxtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(207, 31);
            this.TxtAge.TabIndex = 5;
            // 
            // BtnGetData
            // 
            this.BtnGetData.Location = new System.Drawing.Point(352, 375);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(219, 68);
            this.BtnGetData.TabIndex = 0;
            this.BtnGetData.Text = "Hämta Data";
            this.BtnGetData.UseVisualStyleBackColor = true;
            this.BtnGetData.Click += new System.EventHandler(this.BtnGetData_click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(350, 451);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 44);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(558, 451);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(113, 44);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Ålder";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(423, 451);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 44);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Namn";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(552, 305);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(219, 68);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Radera";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(552, 375);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(219, 68);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "Uppdatera";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(637, 106);
            this.TxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(207, 31);
            this.TxtBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // TxtTitle
            // 
            this.TxtTitle.AutoSize = true;
            this.TxtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitle.Location = new System.Drawing.Point(581, 25);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(268, 63);
            this.TxtTitle.TabIndex = 7;
            this.TxtTitle.Text = "Klasslista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Betyg";
            // 
            // TxtGrade
            // 
            this.TxtGrade.Location = new System.Drawing.Point(478, 255);
            this.TxtGrade.Name = "TxtGrade";
            this.TxtGrade.Size = new System.Drawing.Size(156, 26);
            this.TxtGrade.TabIndex = 9;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(672, 451);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(92, 32);
            this.lblGrade.TabIndex = 10;
            this.lblGrade.Text = "Betyg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 779);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.TxtGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGetData);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtGrade;
        private System.Windows.Forms.Label lblGrade;
    }
}

