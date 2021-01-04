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
    public partial class FormMenu : Form
    {
        string email, password;
       
        public FormMenu(string email)
        {
            InitializeComponent();
            this.email = email;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3();
            newform.ShowDialog();
            //this.Close();
        }

        private void buttonGestioneUtente(object sender, EventArgs e)
        {
            formGestioneUt newform = new formGestioneUt(email);
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
