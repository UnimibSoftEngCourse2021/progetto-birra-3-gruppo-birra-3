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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonGestioneProdotti(object sender, EventArgs e)
        {
            FormGestioneProdotti newform = new FormGestioneProdotti();
            newform.ShowDialog();
            //this.Close();
        }

        private void buttonGestioneUtente(object sender, EventArgs e)
        {
            FormGestioneUtente newform = new FormGestioneUtente();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void buttonGestioneAttrezzatura(object sender, EventArgs e)
        {

        }

        private void buttonPreparaBirra(object sender, EventArgs e)
        {

        }

        private void buttonListaDellaSpesa(object sender, EventArgs e)
        {

        }

        private void buttonCheBirraFaccio(object sender, EventArgs e)
        {

        }

        private void buttonGestioneRicette(object sender, EventArgs e)
        {
            
        }
    }
}
