using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text;
using MySql.Data.MySqlClient;

namespace ProgettoBirra
{
    public partial class FormLogin : Form
    {
        GestioneDB database;
        public FormLogin()
        {
            InitializeComponent();
            database=new GestioneDB();
            database.create_table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text.Equals("user") && textBox2.Text.Equals("password"))
            {
                Form2 newform = new Form2();
                newform.ShowDialog();
                //this.Hide();
            }
            else {
                MessageBox.Show("login errato, riprovare.");
                textBox1.Text = "";
                textBox2.Text = "";
            }*/


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            FormRegistrazione newform = new FormRegistrazione();
            this.Hide();
            newform.ShowDialog();
            this.Show();           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool b = false;
            //database.SelectUtente(textBox1.Text, textBox2.Text);
            b = database.SelectUtente(textBox1.Text, textBox2.Text);
            if (b == true)
            {
                MessageBox.Show("ha funzionato");
            }
            else
                MessageBox.Show("non ha funzionato");
        }
    }
}
