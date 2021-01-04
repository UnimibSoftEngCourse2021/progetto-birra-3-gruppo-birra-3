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
    public partial class formGestioneUt : Form
    {
        string email;
        public formGestioneUt(string email)
        {
            InitializeComponent();
            this.email = email;
            textBox2.Text = email;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formGestioneUt_Load(object sender, EventArgs e)
        {

        }
    }
}
