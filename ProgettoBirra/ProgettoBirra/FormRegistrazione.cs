using System;
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

        private void buttonRegistrati(object sender, EventArgs e)
        {
            database.InsertUtente(textBoxEmail.Text, textBoxPassword.Text);



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
