namespace LyonPalme.form
{
    partial class Pret
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
        //en bas il y a la mise en forme des tableaux
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvPrets = new System.Windows.Forms.ListView();
            this.EMP_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMP_DateRetour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ADH_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAT_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAdherents = new System.Windows.Forms.ListView();
            this.ddd1 = new System.Windows.Forms.ListView();
            this.textBoxId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxMobile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddd2 = new System.Windows.Forms.ListView();
            this.MAT_Id2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAT_Marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAT_Libelle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAT_Etat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MON_Pointure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COM_Taille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvPrets
            // 
            this.lvPrets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EMP_ID,
            this.DATE,
            this.EMP_DateRetour,
            this.ADH_Id,
            this.MAT_Id});
            this.lvPrets.GridLines = true;
            this.lvPrets.HideSelection = false;
            this.lvPrets.Location = new System.Drawing.Point(3, 31);
            this.lvPrets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvPrets.MultiSelect = false;
            this.lvPrets.Name = "lvPrets";
            this.lvPrets.Size = new System.Drawing.Size(402, 351);
            this.lvPrets.TabIndex = 2;
            this.lvPrets.UseCompatibleStateImageBehavior = false;
            this.lvPrets.View = System.Windows.Forms.View.Details;
            this.lvPrets.SelectedIndexChanged += new System.EventHandler(this.lvPrets_SelectedIndexChanged);
            // 
            // EMP_ID
            // 
            this.EMP_ID.Text = "EMP ID";
            // 
            // DATE
            // 
            this.DATE.Text = "DATE";
            this.DATE.Width = 80;
            // 
            // EMP_DateRetour
            // 
            this.EMP_DateRetour.Text = "date retour";
            this.EMP_DateRetour.Width = 127;
            // 
            // ADH_Id
            // 
            this.ADH_Id.Text = "ADH ID";
            this.ADH_Id.Width = 52;
            // 
            // MAT_Id
            // 
            this.MAT_Id.Text = "Materiel ID";
            this.MAT_Id.Width = 156;
            // 
            // lvAdherents
            // 
            this.lvAdherents.GridLines = true;
            this.lvAdherents.HideSelection = false;
            this.lvAdherents.Location = new System.Drawing.Point(646, 37);
            this.lvAdherents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAdherents.MultiSelect = false;
            this.lvAdherents.Name = "lvAdherents";
            this.lvAdherents.Size = new System.Drawing.Size(569, 287);
            this.lvAdherents.TabIndex = 3;
            this.lvAdherents.UseCompatibleStateImageBehavior = false;
            this.lvAdherents.View = System.Windows.Forms.View.Details;
            // 
            // ddd1
            // 
            this.ddd1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.textBoxId,
            this.textBoxNom,
            this.textBoxPrenom,
            this.textBoxMobile,
            this.textBoxEmail});
            this.ddd1.GridLines = true;
            this.ddd1.HideSelection = false;
            this.ddd1.Location = new System.Drawing.Point(420, 31);
            this.ddd1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddd1.MultiSelect = false;
            this.ddd1.Name = "ddd1";
            this.ddd1.Size = new System.Drawing.Size(492, 351);
            this.ddd1.TabIndex = 3;
            this.ddd1.UseCompatibleStateImageBehavior = false;
            this.ddd1.View = System.Windows.Forms.View.Details;
            this.ddd1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // textBoxId
            // 
            this.textBoxId.Text = "ID ADH";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Text = "Nom";
            this.textBoxNom.Width = 87;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Text = "Prenom";
            this.textBoxPrenom.Width = 93;
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Text = "Mobile";
            this.textBoxMobile.Width = 112;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Text = "email";
            this.textBoxEmail.Width = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liste des emprunts";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // ddd2
            // 
            this.ddd2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MAT_Id2,
            this.MAT_Marque,
            this.MAT_Libelle,
            this.MAT_Etat,
            this.MON_Pointure,
            this.COM_Taille});
            this.ddd2.GridLines = true;
            this.ddd2.HideSelection = false;
            this.ddd2.Location = new System.Drawing.Point(928, 31);
            this.ddd2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddd2.MultiSelect = false;
            this.ddd2.Name = "ddd2";
            this.ddd2.Size = new System.Drawing.Size(492, 351);
            this.ddd2.TabIndex = 5;
            this.ddd2.UseCompatibleStateImageBehavior = false;
            this.ddd2.View = System.Windows.Forms.View.Details;
            this.ddd2.SelectedIndexChanged += new System.EventHandler(this.ddd2_SelectedIndexChanged);
            // 
            // MAT_Id2
            // 
            this.MAT_Id2.Text = "MAT Id";
            // 
            // MAT_Marque
            // 
            this.MAT_Marque.Text = "Marque";
            this.MAT_Marque.Width = 87;
            // 
            // MAT_Libelle
            // 
            this.MAT_Libelle.Text = "Libellé";
            this.MAT_Libelle.Width = 112;
            // 
            // MAT_Etat
            // 
            this.MAT_Etat.Text = "Etat";
            // 
            // MON_Pointure
            // 
            this.MON_Pointure.Text = "Pointure";
            // 
            // COM_Taille
            // 
            this.COM_Taille.Text = "Taille";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adherents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1094, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tous les Materiels disponible (Stock)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 440);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(464, 438);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(674, 438);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(928, 438);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ajoutez un emprunt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Adherent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID Materiel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(734, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date de Début";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(972, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Date de Retour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(907, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "à";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 441);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 19;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "ID emprunt";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1409, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "→";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1522, 639);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddd2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddd1);
            this.Controls.Add(this.lvPrets);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pret";
            this.Text = "Pret";
            this.Load += new System.EventHandler(this.lvPrets_SelectedIndexChanged);
            this.Load += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            this.Load += new System.EventHandler(this.ddd2_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
            /*this.Load += new System.EventHandler(this.lvPrets_SelectedIndexChanged);
            this.Load += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            this.Load += new System.EventHandler(this.ddd2_SelectedIndexChanged);*/

        private System.Windows.Forms.ListView lvPrets;
        private System.Windows.Forms.ListView lvAdherents;
        private System.Windows.Forms.ColumnHeader EMP_ID;
        private System.Windows.Forms.ColumnHeader DATE;
        private System.Windows.Forms.ColumnHeader EMP_DateRetour;
        private System.Windows.Forms.ColumnHeader ADH_Id;
        private System.Windows.Forms.ColumnHeader MAT_Id;
        private System.Windows.Forms.ListView ddd1;
        private System.Windows.Forms.ColumnHeader textBoxId;
        private System.Windows.Forms.ColumnHeader textBoxNom;
        private System.Windows.Forms.ColumnHeader textBoxPrenom;
        private System.Windows.Forms.ColumnHeader textBoxMobile;
        private System.Windows.Forms.ColumnHeader textBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ddd2;
        private System.Windows.Forms.ColumnHeader MAT_Id2;
        private System.Windows.Forms.ColumnHeader MAT_Marque;
        private System.Windows.Forms.ColumnHeader MAT_Libelle;
        private System.Windows.Forms.ColumnHeader MAT_Etat;
        private System.Windows.Forms.ColumnHeader MON_Pointure;
        private System.Windows.Forms.ColumnHeader COM_Taille;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}