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
    public partial class FormGestioneAttrezzatura : Form
    {
        GestioneDB database;
        public FormGestioneAttrezzatura()
        {
            database = new GestioneDB();
            Globals.listaAttrezzi.Clear();
            database.recuperoAttr();
            InitializeComponent();
            for (int i = 0; i < Globals.listaAttrezzi.Count; i++)
            {

                listBox1.Items.Add(Globals.listaAttrezzi[i].getNome());

            }

        }

        private void buttonAggiungiAtt_Click(object sender, EventArgs e)
        {
            FormAggiuntaAtt newform = new FormAggiuntaAtt();
            this.Close();
            newform.ShowDialog();
        }

        private void buttonModificaAtt_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEliminaAtt_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                string selezionato = listBox1.SelectedItem.ToString();

                this.Close();
                FormModificaAtt newform = new FormModificaAtt(selezionato);
                newform.ShowDialog();
                
            }

        }
    }
}
