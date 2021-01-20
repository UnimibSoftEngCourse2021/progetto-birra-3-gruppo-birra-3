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
    public partial class FormRicetta : Form
    {
        GestioneDB database;
        public FormRicetta(string selezionato)
        {
            InitializeComponent();
            Globals.listaProdotti.Clear();
            textBoxNome.Text=selezionato;
            database = new GestioneDB();
            
            for (int i = 0; i < Globals.listaRicette.Count; i++)
            {
                if (Globals.listaRicette[i].getNome() == selezionato)
                {
                    textBoxNome.Text = selezionato;
                    textBoxNote.Text = Globals.listaRicette[i].getNote();
                    textBoxAttrezzi.Text = Globals.listaRicette[i].getAttrezzi();
                    textBoxPreparazione.Text = Globals.listaRicette[i].getPreparazione();
                    database.recuperoProd(Globals.listaRicette[i].getidRicetta());
                }

            }

            for (int i = 0; i < Globals.listaProdotti.Count; i++) {

                textBoxProdotti.AppendText(Globals.listaProdotti[i].getNome() + " Con quanitità --> " + Globals.listaProdotti[i].getQuantita() + "\r\n");
       
            }

        }

        private void FormRicetta_Load(object sender, EventArgs e)
        {

        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            int idRic = database.recuperoIdRic(textBoxNome.Text);

            database.DeleteProdRic(idRic);
            database.DeleteRic(textBoxNome.Text);
            MessageBox.Show("La ricetta è stata eliminata dal ricettario");

            /*FormMenu newform = new FormMenu();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();*/
            this.Close();
        }

        private void textBoxProdotti_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonModificaRic_Click(object sender, EventArgs e)
        {
            database.UpdateRic(textBoxNome.Text, textBoxNote.Text);
            MessageBox.Show("La nota è stata modificata con successo");

            /*FormMenu newform = new FormMenu();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();*/
            this.Close();
        }

        private void buttonPrepara(object sender, EventArgs e)
        {
            bool fatta = true;

            for (int i = 0; i < Globals.listaProdotti.Count; i++)
            {
                if (database.verificaProd(Globals.listaProdotti[i].getNome()) == false)
                {
                    MessageBox.Show("Impossibile preparare ricetta, non hai i prodotti necessari");
                    fatta = false;
                    break;
                }

                int numero = Convert.ToInt32(Globals.listaProdotti[i].getQuantita());
                numero = numero  * Convert.ToInt32(this.numericUpDown1.Text);

                if (database.verificaQuantitaProd(Globals.listaProdotti[i].getNome(), numero) > 0 )
                {
                    MessageBox.Show("Non hai abbastanza quantita di "+ Globals.listaProdotti[i].getNome());
                    fatta = false;
                    break;
                }

            }

            if(fatta==true)
            {
                MessageBox.Show("Hai fatto la ricetta");
            }
            







        }
    }
}
