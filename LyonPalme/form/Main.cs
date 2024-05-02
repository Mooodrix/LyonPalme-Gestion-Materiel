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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //materiel

            Materiel materielform = new Materiel();
            materielform.Show();
            this.Hide(); //cacher la page
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

            //pret
            Pret pretform = new Pret();
            pretform.Show();
            this.Hide(); //cacher la page
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaterielRecup pretform = new MaterielRecup();
            pretform.Show();
            this.Hide(); //cacher la page
        }
    }
}
