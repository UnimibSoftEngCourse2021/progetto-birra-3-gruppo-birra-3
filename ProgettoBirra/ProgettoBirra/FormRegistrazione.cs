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
            this.Close();//f
            this.Dispose();
        }
    }
}
