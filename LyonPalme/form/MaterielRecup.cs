using CreditSio.DataAccess;
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

namespace LyonPalme.form
{
    public partial class MaterielRecup : Form
    {
        public MaterielRecup()
        {
            InitializeComponent();
        }

        private void lvPrets_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPrets.Items.Clear(); // empeche le bug actualisation de rajout données dans la table
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                // Récupérez l'ID de l'emprunt depuis le textBox
                string empruntID = textBox1.Text.Trim();

                // Appelez la méthode de DBInterface pour supprimer l'emprunt
                DBInterface.DeleteEmprunt(empruntID);

                // Affichez un message de succès
                MessageBox.Show("L'emprunt a été supprimé avec succès !");

                // Actualisez votre ListView ou tout autre élément d'interface utilisateur si nécessaire
                // Par exemple, vous pouvez appeler la méthode pour charger à nouveau la liste des emprunts
                lvPrets.Items.Clear();
                lvPrets_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Veuillez saisir l'ID de l'emprunt à supprimer.");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //retour
        {
            Main mainform = new Main();
            mainform.Show();
            this.Hide(); //cacher la page
        }
    }
}
