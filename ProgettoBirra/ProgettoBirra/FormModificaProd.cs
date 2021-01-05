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
    public partial class FormModificaProd : Form
    {
        GestioneDB database;
        public FormModificaProd()
        {
            database = new GestioneDB();
            InitializeComponent();
        }

        private void buttonSalvaModifiche_Click(object sender, EventArgs e)
        {
            database.UpdateProd(textBoxNome.Text, Convert.ToInt32(this.textBoxNuovaQT.Text));

            FormLogin newform = new FormLogin();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }
    }
}
