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
        string password;
        GestioneDB database;
        public formGestioneUt(string email, string password)
        {
            InitializeComponent();
            database = new GestioneDB();
            this.email = email;
            this.password = password;
            textBoxEmail.Text = email;
            textBoxPassword.Text = password;

            /*if (checkBoxEmail.IsAccessible) {
                textBoxEmail.Enabled = true;
            }else
                textBoxEmail.Enabled = false;

            if (checkBoxPassword.IsAccessible)
            {
                textBoxPassword.Enabled = true;
            }else
                textBoxPassword.Enabled = false;*/
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked != true)
            {
                textBoxPassword.Enabled = false;
            }
            else
            {
                textBoxPassword.Enabled = true;
            }
        }

        private void checkBoxEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEmail.Checked != true)
            {
                textBoxEmail.Enabled = false;
            }
            else
            {
                textBoxEmail.Enabled = true;
            }
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            database.UpdateUtente(textBoxEmail.Text,textBoxPassword.Text,this.email,this.password);
            MessageBox.Show("la query è stata eseguita");
        }
    }
}
