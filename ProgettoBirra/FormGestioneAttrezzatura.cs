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
    public partial class FormGestioneAttrezzatura : Form
    {
        public FormGestioneAttrezzatura()
        {
            InitializeComponent();
        }

        private void buttonAggiungiAtt_Click(object sender, EventArgs e)
        {
            FormAggiuntaAtt newform = new FormAggiuntaAtt();
            newform.ShowDialog();
        }

        private void buttonModificaAtt_Click(object sender, EventArgs e)
        {
            FormModificaAtt newform = new FormModificaAtt();
            newform.ShowDialog();
        }

        private void buttonEliminaAtt_Click(object sender, EventArgs e)
        {
            FormEliminaAtt newform = new FormEliminaAtt();
            newform.ShowDialog();
        }
    }
}
