﻿using System;
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
    public partial class FormAggiungiProdottiRicetta : Form
    {
        GestioneDB database;
        string nomeRic;
        public FormAggiungiProdottiRicetta(string nomeRic)
        {
            InitializeComponent();
            database = new GestioneDB();
            this.nomeRic = nomeRic;

        }

        

        private void buttonFine_Click(object sender, EventArgs e)
        {
            /*FormMenu newform = new FormMenu();
            this.Hide();
            this.Close();
            newform.ShowDialog();*/
            this.Close();
            this.Dispose();


        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {

            int idRicetta = database.recuperoIdRic(nomeRic);

            database.InsertProdRic(idRicetta, textBox1.Text, Int32.Parse(textBox2.Text));

            textBox1.Text = "";
            textBox2.Text = "";

        }

     
    }
}
