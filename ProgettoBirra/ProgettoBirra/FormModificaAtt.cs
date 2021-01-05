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
    public partial class FormModificaAtt : Form
    {
        GestioneDB database;
        public FormModificaAtt()
        {
            database = new GestioneDB();
            InitializeComponent();
        }

        private void buttonSalvaModifiche_Click(object sender, EventArgs e)
        {
            database.UpdateAtt(textBoxNomeAtt.Text, Convert.ToInt32(this.textBoxNuovaCP.Text));

            FormGestioneAttrezzatura newform = new FormGestioneAttrezzatura();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }
    }
}
