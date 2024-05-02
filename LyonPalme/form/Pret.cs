using CreditSio.DataAccess;
using LyonPalme.classe;
using LyonPalme.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.Globalization;

namespace LyonPalme.form
{
    public partial class Pret : Form
    {
        public Pret()
        {
            InitializeComponent();
        }

        private void lvPrets_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPrets.Items.Clear();
            List<ListPretModel> prets = DBInterface.GetPret();

            if (prets != null)
            {

                foreach (ListPretModel mat in prets)
                {
                    string[] row = { mat.EMP_Id, mat.EMP_Date.ToString(), mat.EMP_DateRetour.ToString(), mat.ADH_Id.ToString(), mat.MAT_Id }; //ToString transforme int en string pr tableau
                    ListViewItem listviewitem = new ListViewItem(row);

                    lvPrets.Items.Add(listviewitem);
                }
            }



            
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ddd1.Items.Clear();
            List<ListAdherentModel> adherents = DBInterface.GetAdherents();

            if (adherents != null)
            {
                foreach (ListAdherentModel adherent in adherents)
                {
                    string[] row = { adherent.ADH_Id.ToString(), adherent.ADH_Nom, adherent.ADH_Prenom, adherent.ADH_Mobile, adherent.ADH_AdresseMail };
                    ListViewItem listItem = new ListViewItem(row);

                    ddd1.Items.Add(listItem);
                }
            }
        }

        private void ddd2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddd2.Items.Clear();
            List<ListMaterielModel> materiels = DBInterface.GetMaterielDisponible();

            if (materiels != null)
            {

                foreach (ListMaterielModel mat in materiels)
                {
                    string[] row = { mat.MAT_Id, mat.MAT_Marque, mat.MAT_Libelle, mat.MAT_Etat, mat.MAT_Pointure.ToString(), mat.MAT_Taille }; //ToString transforme int en string pr tableau
                    ListViewItem listviewitem = new ListViewItem(row);

                    ddd2.Items.Add(listviewitem);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string adhIdText = textBox1.Text;
            int adhId;

            // Tentative de conversion du texte de textBox1.Text en entier
            if (int.TryParse(adhIdText, out adhId))
            {
                string empId = textBox3.Text;
                DateTime empDate = dateTimePicker1.Value.Date;
                DateTime empDateRetour = dateTimePicker2.Value.Date;
                string matId = textBox2.Text;

                // Appel methode pr add l'emprunt
                string message = DBInterface.AddEmprunt(empId, matId, empDate, empDateRetour, adhId);

                // Afficher le message retourné par la méthode
                MessageBox.Show(message);

                // Actualiser la liste des emprunts si nécessaire
                lvPrets.Items.Clear();
                lvPrets_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un identifiant d'adhérent valide.");
            }
            // Actualiser la liste des emprunts si nécessaire
           
        }

        private void button2_Click(object sender, EventArgs e) //retour
        {
            Main mainform = new Main();
            mainform.Show();
            this.Hide(); //cacher la page
        }
    }
}
    