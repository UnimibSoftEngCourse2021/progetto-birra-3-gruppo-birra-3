using System;
using System.Windows.Forms;

namespace ProgettoBirra
{
    public partial class FormAggiuntaProd : Form
    {
        GestioneDB database;
        public FormAggiuntaProd()
        {
            InitializeComponent();
            database = new GestioneDB();
        }

        private void buttonSalvaProd(object sender, EventArgs e)
        {
            database.InsertProd(Globals.emailGlobal, textBoxNomeProd.Text, Convert.ToInt32(this.textBoxQuantita.Text));
            this.Close();
            this.Dispose();
        }
    }
}
