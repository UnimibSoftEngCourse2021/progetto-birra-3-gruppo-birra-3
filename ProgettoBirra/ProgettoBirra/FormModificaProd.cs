using System;
using System.Windows.Forms;

namespace ProgettoBirra
{
    public partial class FormModificaProd : Form
    {
        GestioneDB database;
        public FormModificaProd(string nome)
        {          

            database = new GestioneDB();
            InitializeComponent();
            textBoxNome.Text = nome;

            for (int i = 0; i < Globals.listaProdotti.Count; i++)
            {
                if (Globals.listaProdotti[i].getNome() == nome)
                {
                    numericUpDown1.Text = Globals.listaProdotti[i].getQuantita();
                }

            }




        }

        private void buttonSalvaModifiche_Click(object sender, EventArgs e)
        {
            database.UpdateProd(textBoxNome.Text, Convert.ToInt32(this.numericUpDown1.Text));
            MessageBox.Show("Il prodotto è stato modificato con successo");
           
            this.Close();
            this.Dispose();

        }

        private void Button_elimina(object sender, EventArgs e)
        {
            database.DeleteProd(textBoxNome.Text);
            MessageBox.Show("Il prodotto è stato rimosso dalla dispensa");
           
            this.Close();
            this.Dispose();

        }

    }
}
