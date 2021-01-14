using System;
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
        GestioneDB database;
        public FormMenu()
        {
            database = new GestioneDB();
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
            FormGestioneAttrezzatura newform = new FormGestioneAttrezzatura();
            newform.ShowDialog();
        }

        private void buttonPreparaBirra(object sender, EventArgs e)
        {
            //ciao
        }

        private void buttonListaDellaSpesa(object sender, EventArgs e)
        {

        }

        private void buttonCheBirraFaccio(object sender, EventArgs e)
        {

        }

        private void buttonGestioneRicette(object sender, EventArgs e)
        {
            FormGestioneRicette newform = new FormGestioneRicette();
            newform.ShowDialog();
        }

      
    }
}
