using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoBirra
{
    public partial class FormRegistrazione : Form
    {
        GestioneDB database;
        public FormRegistrazione()
        {
            InitializeComponent();
            database = new GestioneDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.InsertUtente(textBox1.Text, textBox2.Text);



            FormLogin newform = new FormLogin();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
