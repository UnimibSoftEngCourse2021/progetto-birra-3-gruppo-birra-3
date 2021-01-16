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
    public partial class FormAggiungiRic : Form
    {
        GestioneDB database;
        public FormAggiungiRic()
        {
            database = new GestioneDB();
            InitializeComponent();
        }

        private void buttonAggiungiBirra_Click(object sender, EventArgs e)
        {
            //database.InsertRic(textBoxNome.Text, textBoxAttrezzi.Text, textBoxPreparazione.Text, textBoxNote.Text);
            string nome = textBoxNome.Text;
            string attrezzi = textBoxAttrezzi.Text;
            string preparazione = textBoxPreparazione.Text;
            string note = textBoxNote.Text;
            FormAggiungiProdottiRicetta newform = new FormAggiungiProdottiRicetta(nome, attrezzi, preparazione, note);
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();
        }
    }
}
