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
    public partial class FormEliminaProd : Form
    {
        GestioneDB database;
        public FormEliminaProd()
        {
            database = new GestioneDB();
            InitializeComponent();
        }

        private void buttonEliminaProd_Click(object sender, EventArgs e)
        {
            database.DeleteProd(textBoxNomeProd.Text);

            FormGestioneProdotti newform = new FormGestioneProdotti();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }
    }
}
