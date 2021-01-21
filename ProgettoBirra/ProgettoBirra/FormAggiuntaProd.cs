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
    public partial class FormAggiuntaProd : Form
    {
        GestioneDB database;
        public FormAggiuntaProd()
        {
            InitializeComponent();
            database = new GestioneDB();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvaProd(object sender, EventArgs e)
        {



            database.InsertProd(Globals.emailGlobal, textBoxNomeProd.Text, Convert.ToInt32(this.textBoxQuantita.Text));



            this.Close();
            this.Dispose();

        }
    }
}
