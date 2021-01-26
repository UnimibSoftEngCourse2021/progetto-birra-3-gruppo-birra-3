using System;
using System.Windows.Forms;

namespace ProgettoBirra
{
    public partial class FormListaSpesa : Form
    {
        GestioneDB database;
        public FormListaSpesa()
        {
            InitializeComponent();
            database = new GestioneDB();
            Globals.listaSpesa.Clear();
            database.recuperoListaSpesa();
            for (int i = 0; i < Globals.listaSpesa.Count; i++)
            {
                textBoxListaSpesa.AppendText(Globals.listaSpesa[i].getnomeProd() + "  quantità  " + Globals.listaSpesa[i].getQuantita()+"\r\n");
            }
        }

        private void buttonSpesa_Click(object sender, EventArgs e)
        {
            database.DeleteSpesa();
            this.Close();
        }
    }
}
