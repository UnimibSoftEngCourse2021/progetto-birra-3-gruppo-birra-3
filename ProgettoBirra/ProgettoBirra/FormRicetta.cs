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

                textBoxProdotti.AppendText(Globals.listaProdotti[i].getNome() + " " + Globals.listaProdotti[i].getQuantita() + "\r\n");
       
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

            FormMenu newform = new FormMenu();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }

        private void textBoxProdotti_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonModificaRic_Click(object sender, EventArgs e)
        {
            database.UpdateRic(textBoxNome.Text, textBoxNote.Text);
            MessageBox.Show("Hai modificato la nota con successo");

            FormMenu newform = new FormMenu();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }
    }
}
