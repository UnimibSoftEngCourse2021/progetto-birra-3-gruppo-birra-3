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
    public partial class FormGestioneProdotti : Form
    {
        public FormGestioneProdotti()
        {
            InitializeComponent();

        }

        private void buttonAggiungi(object sender, EventArgs e)
        {
            FormAggiuntaProd newform = new FormAggiuntaProd();
            newform.ShowDialog();
            //this.Close();
        }

        private void buttonModifica(object sender, EventArgs e)
        {
            FormModificaProd newform = new FormModificaProd();
            newform.ShowDialog();

        }
    }
}
