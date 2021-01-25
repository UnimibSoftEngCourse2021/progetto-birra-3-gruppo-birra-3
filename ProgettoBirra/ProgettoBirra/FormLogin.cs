using System;
using System.Windows.Forms;

namespace ProgettoBirra
{
    public partial class FormLogin : Form
    {
        GestioneDB database;

        
        public FormLogin()
        {
            InitializeComponent();
            database=new GestioneDB();


            database.create_tableListaDellaSpesa();
            
            
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
