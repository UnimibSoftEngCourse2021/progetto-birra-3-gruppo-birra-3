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
    public partial class FormAggiungiProdottiRicetta : Form
    {
        GestioneDB database;
        string nomeRic;
        string attRic;
        string prepRic;
        string noteRic;

        public FormAggiungiProdottiRicetta(string nomeRic, string attRic, string prepRic, string noteRic)
        {
            InitializeComponent();
            database = new GestioneDB();
            this.nomeRic = nomeRic;
            this.attRic = attRic;
            this.prepRic = prepRic;
            this.noteRic = noteRic;

        }

        

        private void buttonFine_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La ricetta è stata salvata nel ricettario");
            /*FormMenu newform = new FormMenu();
            this.Hide();
            this.Close();
            newform.ShowDialog();*/
            this.Close();
            this.Dispose();


        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            //prima giustamente salvava tante ricette diverse per ogni prodotto aggiunto
            //ho creato un verificaRic (copia incolla di verificaProd)
            //così se la ricetta non esiste la crea, altrimenti non fa nulla nell'if
            if (database.verificaRic(nomeRic) == false){
                database.InsertRic(nomeRic, attRic, prepRic, noteRic);
            }
            int idRicetta = database.recuperoIdRic(nomeRic);

            database.InsertProdRic(idRicetta, textBox1.Text, Int32.Parse(textBox2.Text));

            textBox1.Text = "";
            textBox2.Text = "";

        }

     
    }
}
