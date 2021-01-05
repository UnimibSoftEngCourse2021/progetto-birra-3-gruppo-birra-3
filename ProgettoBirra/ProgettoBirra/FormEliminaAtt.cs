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
    public partial class FormEliminaAtt : Form
    {
        GestioneDB database;
        public FormEliminaAtt()
        {
            InitializeComponent();
            database = new GestioneDB();
        }

        private void buttonEliminaAt_Click(object sender, EventArgs e)
        {
            database.DeleteAtt(textBoxNomeAtt.Text);

            FormGestioneAttrezzatura newform = new FormGestioneAttrezzatura();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }
    }
}
