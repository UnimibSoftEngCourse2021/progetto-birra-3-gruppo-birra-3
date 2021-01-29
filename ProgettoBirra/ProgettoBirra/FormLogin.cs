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
            b = database.SelectUtente(textBox1.Text, textBox2.Text);
            if (b)
            {
                FormMenu newform = new FormMenu();
                this.Hide();
                newform.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
                this.Show();
            }
            else
                MessageBox.Show("Login errato");
        }

        private void buttonCreaAccount(object sender, EventArgs e)
        { 
            FormRegistrazione newform = new FormRegistrazione();
            newform.ShowDialog();
        }
    }
}
