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
    public partial class FormAggiuntaAtt : Form
    {
        GestioneDB database;
        public FormAggiuntaAtt()
        {
            InitializeComponent();
            database = new GestioneDB();
        }

        private void buttonCreaAtt_Click(object sender, EventArgs e)
        {
            database.InsertAtt(Globals.emailGlobal, textBoxNomeAtt.Text, Convert.ToInt32(this.textBoxCapacita.Text));

            FormGestioneAttrezzatura newform = new FormGestioneAttrezzatura();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }
    }
}
