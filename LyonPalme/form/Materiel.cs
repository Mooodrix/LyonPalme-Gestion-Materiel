using Azure;
using CreditSio.DataAccess;
using LyonPalme.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyonPalme.form
{
    public partial class Materiel : Form
    {
        public Materiel()
        {
            InitializeComponent();

        }

        private void lvClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvClient.Items.Clear();
            List<ListMaterielModel> materiels = DBInterface.GetMateriel();

            if (materiels != null)
            {

                foreach (ListMaterielModel mat in materiels)
                {
                    string[] row = { mat.MAT_Id, mat.MAT_Marque, mat.MAT_Libelle, mat.MAT_Etat, mat.MAT_Pointure.ToString(), mat.MAT_Taille}; //ToString transforme int en string pr tableau
                    ListViewItem listviewitem = new ListViewItem(row);

                    lvClient.Items.Add(listviewitem);
                }
            }
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            
                string matId = this.textBox1.Text;
                string marque = this.textBox2.Text;
                string libelle = this.textBox3.Text;
                string etat = this.textBox4.Text;

                int? pointure = string.IsNullOrEmpty(this.textBox5.Text) ? (int?)null : int.Parse(this.textBox5.Text);

                string taille = textBox6.Text;

                // Appeler la méthode InsertMateriel de DBInterface
                DBInterface.InsertMateriel(matId, marque, libelle, etat, pointure, taille);

                // Afficher un message de succès
                MessageBox.Show("Le matériel a été ajouté avec succès !");

                lvClient.Items.Clear();
                lvClients_SelectedIndexChanged(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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


