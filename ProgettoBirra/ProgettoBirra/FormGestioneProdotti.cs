using System;
using System.Windows.Forms;

namespace ProgettoBirra
{
    public partial class FormGestioneProdotti : Form
    {
        GestioneDB database;
        public FormGestioneProdotti()
        {
            InitializeComponent();
            database = new GestioneDB();
            Globals.listaProdotti.Clear();
            database.recuperoProdUtente();
            for (int i = 0; i < Globals.listaProdotti.Count; i++)
            {
                listBox1.Items.Add(Globals.listaProdotti[i].getNome());
            }
        }

        private void buttonAggiungi(object sender, EventArgs e)
        {
            FormAggiuntaProd newform = new FormAggiuntaProd();
            this.Close();
            this.Dispose();
            newform.ShowDialog();
        }
     
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selezionato = listBox1.SelectedItem.ToString();
                this.Close();
                this.Dispose();
                FormModificaProd newform = new FormModificaProd(selezionato);
                newform.ShowDialog();
            }
        }
    }
}
