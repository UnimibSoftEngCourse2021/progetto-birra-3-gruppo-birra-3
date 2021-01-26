using System;
using System.Windows.Forms;

namespace ProgettoBirra
{
    public partial class FormAggiungiRic : Form
    {
        public FormAggiungiRic()
        {
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
    }
}
