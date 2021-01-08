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
        public FormRicetta(string selezionato)
        {
            InitializeComponent();
            textBoxNome.Text=selezionato;

            for (int i = 0; i < Globals.listaRicette.Count; i++)
            {
                if (Globals.listaRicette[i].getNome() == selezionato)
                {
                    textBoxNome.Text = selezionato;
                    textBoxNote.Text = Globals.listaRicette[i].getNote();
                    textBoxProdotti.Text = Globals.listaRicette[i].getProdotti();
                    textBoxAttrezzi.Text = Globals.listaRicette[i].getAttrezzi();
                    textBoxPreparazione.Text = Globals.listaRicette[i].getPreparazione();
                }

            }
        }

        private void FormRicetta_Load(object sender, EventArgs e)
        {

        }
    }
}
