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
            newform.ShowDialog();
            //this.Close();
        }

    

     
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selezionato = listBox1.SelectedItem.ToString();

                this.Close();
                FormModificaProd newform = new FormModificaProd(selezionato);
                newform.ShowDialog();

            }
        }
    }
}
