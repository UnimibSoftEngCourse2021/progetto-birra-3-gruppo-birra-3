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
    public partial class FormEliminaRic : Form
    {
        GestioneDB database;
        public FormEliminaRic()
        {
            database = new GestioneDB();
            InitializeComponent();
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            database.DeleteRic(textBoxNomeRic.Text);

            FormGestioneRicette newform = new FormGestioneRicette();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }
    }
}
