namespace LyonPalme.form
{
    partial class MaterielRecup
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
            this.lvPrets = new System.Windows.Forms.ListView();
            this.EMP_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMP_DateRetour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ADH_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAT_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lvPrets.Location = new System.Drawing.Point(41, 53);
            this.lvPrets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvPrets.MultiSelect = false;
            this.lvPrets.Name = "lvPrets";
            this.lvPrets.Size = new System.Drawing.Size(402, 351);
            this.lvPrets.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liste des emprunts";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(595, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Récupérer le matériel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID de l\'emprunt";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "→";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MaterielRecup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvPrets);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MaterielRecup";
            this.Text = "MaterielRecup";
            this.Load += new System.EventHandler(this.lvPrets_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPrets;
        private System.Windows.Forms.ColumnHeader EMP_ID;
        private System.Windows.Forms.ColumnHeader DATE;
        private System.Windows.Forms.ColumnHeader EMP_DateRetour;
        private System.Windows.Forms.ColumnHeader ADH_Id;
        private System.Windows.Forms.ColumnHeader MAT_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}