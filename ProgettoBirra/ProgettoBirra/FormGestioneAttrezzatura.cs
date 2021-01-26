using System;
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
            this.Dispose();
            newform.ShowDialog();
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
