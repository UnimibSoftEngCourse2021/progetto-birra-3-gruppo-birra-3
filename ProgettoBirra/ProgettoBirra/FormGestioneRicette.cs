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
    public partial class FormGestioneRicette : Form
    {
        public FormGestioneRicette()
        {
            InitializeComponent();
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            FormAggiungiRic newform = new FormAggiungiRic();
            newform.ShowDialog();
        }
    }
}
