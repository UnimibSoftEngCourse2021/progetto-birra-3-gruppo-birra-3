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
            this.Close();
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

        }

        private void buttonListaDellaSpesa(object sender, EventArgs e)
        {
            FormListaSpesa newform = new FormListaSpesa();
            newform.ShowDialog();
        }

        private void buttonCheBirraFaccio(object sender, EventArgs e)
        {

            Globals.listaRicette.Clear();
            Globals.listaDisponibilitaBirra.Clear();


            database.recuperoRic();


            for (int i = 0; i < Globals.listaRicette.Count; i++)
            {

                //database.recuperoIdRic(Globals.listaRicette[i].getNome());
                Globals.listaProdottiRicettaUtente.Clear();
                Globals.listaProdottiUtente.Clear();
                Globals.n = 999;
                database.cheBirraFaccioOggi(database.recuperoIdRic(Globals.listaRicette[i].getNome()));

            }

            int idRicettamin=0;
            int quantitaricettamin=0;

            for (int j = 0; j < Globals.listaDisponibilitaBirra.Count; j++)
            {
                if (Globals.listaDisponibilitaBirra[j].getquantitaMin() > quantitaricettamin)
                {
                    idRicettamin = Globals.listaDisponibilitaBirra[j].getidRicetta();
                    quantitaricettamin= Globals.listaDisponibilitaBirra[j].getquantitaMin();
                }

            }

            if (quantitaricettamin != 0)
            {
                
                MessageBox.Show("Puoi fare la ricetta  " + database.recuperoNomeRic(idRicettamin) + " fino a " + quantitaricettamin + "  volte, per massimizzare l'uso dei tuoi prodotti");
            }
            else {
                MessageBox.Show("Non puoi fare nessuna ricetta");
            }
        }

        private void buttonGestioneRicette(object sender, EventArgs e)
        {
            FormGestioneRicette newform = new FormGestioneRicette();
            newform.ShowDialog();

            
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
