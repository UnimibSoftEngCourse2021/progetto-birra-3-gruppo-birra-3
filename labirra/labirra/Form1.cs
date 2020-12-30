using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirra
{
    public partial class Form1 : Form
    {
        private gestionedb database;

        public Form1()
        {
            InitializeComponent();
            database = new gestionedb();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            database.create_table();
            MessageBox.Show("fatto");

        }
    }
}
