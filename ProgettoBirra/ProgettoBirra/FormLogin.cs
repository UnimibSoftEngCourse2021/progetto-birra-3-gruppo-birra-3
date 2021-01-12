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
            
            
        }

        private void bottoneLogin(object sender, EventArgs e)
        {
            //Bottone login 

            bool b = false;
            //database.SelectUtente(textBox1.Text, textBox2.Text);
            b = database.SelectUtente(textBox1.Text, textBox2.Text);
            if (b == true)
            {
                //MessageBox.Show("Benvenuto");
                FormMenu newform = new FormMenu();
                this.Hide();
                newform.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Login errato");


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreaAccount(object sender, EventArgs e)
        { 
            FormRegistrazione newform = new FormRegistrazione();
            this.Hide();
            newform.ShowDialog();
            this.Show();           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
