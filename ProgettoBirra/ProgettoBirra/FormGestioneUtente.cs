using System;
using System.Windows.Forms;

namespace ProgettoBirra
{
    public partial class FormGestioneUtente : Form
    {
        string email;
        string password;
        GestioneDB database;
        


        public FormGestioneUtente()
        {
            InitializeComponent();
            database = new GestioneDB();
            textBoxEmail.Text = Globals.emailGlobal;
            textBoxPassword.Text = Globals.passwordGlobal;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void formGestioneUt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked != true)
            {
                textBoxPassword.Enabled = false;
            }
            else
            {
                textBoxPassword.Enabled = true;
            }
        }

        private void checkBoxEmail_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {


            if (checkBoxPassword.Checked)
            {
                database.UpdateUtente(textBoxPassword.Text);
                MessageBox.Show("Password aggiornato");
            }
           
        }

        private void buttonEliminaUtente_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {

                database.DeleteProdRicettaUtente();
                database.DeleteRicetteUtente();
                database.DeleteAttrezziUtente();
                database.DeleteProdUtente();
                database.DeleteUtente();
                MessageBox.Show("Utente Eliminato");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Conferma Eliminazione utente");
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
