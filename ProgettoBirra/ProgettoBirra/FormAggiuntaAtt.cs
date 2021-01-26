using System;
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
            database.InsertAtt(textBoxNomeAtt.Text, Convert.ToInt32(this.textBoxCapacita.Text));
            this.Close();
            this.Dispose();
        }
    }
}
