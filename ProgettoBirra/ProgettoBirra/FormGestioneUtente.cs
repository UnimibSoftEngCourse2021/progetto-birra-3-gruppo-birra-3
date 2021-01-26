using System;
using System.Windows.Forms;

namespace ProgettoBirra
{
    public partial class FormGestioneUtente : Form
    {
        GestioneDB database;

        public FormGestioneUtente()
        {
            InitializeComponent();
            database = new GestioneDB();
            textBoxEmail.Text = Globals.emailGlobal;
            textBoxPassword.Text = Globals.passwordGlobal;
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxPassword.Checked)
            {
                textBoxPassword.Enabled = false;
            }
            else
            {
                textBoxPassword.Enabled = true;
            }
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                database.UpdateUtente(textBoxPassword.Text);
                MessageBox.Show("Password aggiornata");
                this.Close();
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
    }
}
