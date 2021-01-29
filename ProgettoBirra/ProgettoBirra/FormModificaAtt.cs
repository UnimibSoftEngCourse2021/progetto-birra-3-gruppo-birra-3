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
    public partial class FormModificaAtt : Form
    {
        GestioneDB database;
        public FormModificaAtt(string selezionato)
        {
            database = new GestioneDB();
            InitializeComponent();
            textBoxNomeAtt.Text=selezionato;

            for (int i = 0; i < Globals.listaAttrezzi.Count; i++)
            {
                if (Globals.listaAttrezzi[i].getNome() == selezionato)
                {
                    numericUpDown1.Text = Globals.listaAttrezzi[i].getCapacita();
                }

            }
        }

        private void buttonSalvaModifiche_Click(object sender, EventArgs e)
        {
            database.UpdateAtt(textBoxNomeAtt.Text, Convert.ToInt32(this.numericUpDown1.Text));
            MessageBox.Show("L'attrezzo è stato modificato con successo");
            /*FormGestioneAttrezzatura newform = new FormGestioneAttrezzatura();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();*/
            this.Close();
            this.Dispose();
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            database.DeleteAtt(textBoxNomeAtt.Text);
            MessageBox.Show("L'attrezzo è stato rimosso dal magazzino");
            /*FormGestioneAttrezzatura newform = new FormGestioneAttrezzatura();
            this.Hide();
            this.Close();
            newform.ShowDialog();
            this.Show();*/
            this.Close();
            this.Dispose();
        }

        private void FormModificaAtt_Load(object sender, EventArgs e)
        {

        }
    }
}
