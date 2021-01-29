using System;
using System.Windows.Forms;

namespace ProgettoBirra
{
    public partial class FormModificaAtt : Form
    {
        GestioneDB database;
        public FormModificaAtt(string selezionato)
        {
            database = new GestioneDB();
            InitializeComponent();
            textBoxNomeAtt.Text=selezionato;
            for (int i = 0; i < Globals.listaAttrezzi.Count; i++)
            {
                if (Globals.listaAttrezzi[i].getNome() == selezionato)
                {
                    numericUpDown1.Text = Globals.listaAttrezzi[i].getCapacita();
                }
            }
        }

        private void buttonSalvaModifiche_Click(object sender, EventArgs e)
        {
            database.UpdateAtt(textBoxNomeAtt.Text, Convert.ToInt32(this.numericUpDown1.Text));
            MessageBox.Show("L'attrezzo è stato modificato con successo");
            this.Close();
            this.Dispose();
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            database.DeleteAtt(textBoxNomeAtt.Text);
            MessageBox.Show("L'attrezzo è stato rimosso dal magazzino");
            this.Close();
            this.Dispose();
        }
    }
}
