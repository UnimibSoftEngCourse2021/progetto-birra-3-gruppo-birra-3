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
        GestioneDB database;
        public FormGestioneRicette()
        {
            InitializeComponent();
            database = new GestioneDB();

            Globals.listaRicette.Clear();

            database.recuperoRic();


            for (int i=0; i< Globals.listaRicette.Count; i++)
            {
                
                listBox1.Items.Add(Globals.listaRicette[i].getNome());
                
            }
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            FormAggiungiRic newform = new FormAggiungiRic();
            newform.ShowDialog();
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (listBox1.SelectedItem != null)
            {
                string selezionato = listBox1.SelectedItem.ToString();
            

                FormRicetta newform = new FormRicetta(selezionato);
            newform.ShowDialog();
            }

        }
    }
}
