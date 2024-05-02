
using System;
using System.Windows.Forms;

namespace LyonPalme.form
{
    public partial class Fconnect : Form
    {
        public Materiel materiel;  //Nageur nageur
        string _login;
        string _password;
        public Fconnect()
        {
            InitializeComponent();
        }

        private void Bconnect_Click(object sender, EventArgs e)
        {
            if (_login == "elyes" && _password == "amor")
            {
                Main mainform = new Main();
                mainform.Show();
                this.Hide(); //cacher la page
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _login = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _password = textBox2.Text;
        }
    }
}
