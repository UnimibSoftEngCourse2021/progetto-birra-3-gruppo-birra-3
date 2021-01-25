using System;
using System.Windows.Forms;

namespace ProgettoBirra
{
    public partial class FormAggiungiRic : Form
    {
        GestioneDB database;
        public FormAggiungiRic()
        {
            database = new GestioneDB();
            InitializeComponent();
        }

        private void buttonAggiungiBirra_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string attrezzi = textBoxAttrezzi.Text;
            string preparazione = textBoxPreparazione.Text;
            string note = textBoxNote.Text;
            FormAggiungiProdottiRicetta newform = new FormAggiungiProdottiRicetta(nome, attrezzi, preparazione, note);
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
