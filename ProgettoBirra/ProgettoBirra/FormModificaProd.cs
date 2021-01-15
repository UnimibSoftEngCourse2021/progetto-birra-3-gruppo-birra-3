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

            FormGestioneProdotti newform = new FormGestioneProdotti();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }

        private void Button_elimina(object sender, EventArgs e)
        {
            database.DeleteProd(textBoxNome.Text);

            FormGestioneProdotti newform = new FormGestioneProdotti();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }

        private void FormModificaProd_Load(object sender, EventArgs e)
        {

        }
    }
}
