using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoBirra
{
    public class RicettaMapper
    {
        string nome;
        string note;
        string idRicetta;
        string preparazione;
        string prodotti;
        string attrezzi;

        public RicettaMapper()
        { }

        public RicettaMapper(string nome, string note, string preparazione, string idRicetta, string prodotti, string attrezzi)
        {
            this.nome = nome;
            this.note = note;
            this.preparazione = preparazione;
            this.idRicetta = idRicetta;
            this.prodotti = prodotti;
            this.attrezzi = attrezzi;

        }

        public string getAttrezzi()
        {
            return attrezzi;
        }

        public void setAttrezzi(string attrezzi)
        {
            this.attrezzi = attrezzi;
        }
        public string getProdotti()
        {
            return prodotti;
        }

        public void setProdotti(string prodotti)
        {
            this.prodotti = prodotti;
        }
        public string getidRicetta()
        {
            return idRicetta;
        }

        public void setidRicetta(string idRicetta)
        {
            this.idRicetta = idRicetta;
        }

        public string getNome()
        {
            return nome;
        }

        public string getNote()
        {
            return note;
        }

        public string getPreparazione()
        {
            return preparazione;
        }


        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setNote(string note)
        {
            this.note = note;
        }

        public void setPreparazione(string preparazione)
        {
            this.preparazione = preparazione;
        }
    }
}
