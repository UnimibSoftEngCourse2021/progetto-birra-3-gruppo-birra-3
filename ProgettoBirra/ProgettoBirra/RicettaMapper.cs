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
        string preparazione;

        public RicettaMapper()
        { }

        public RicettaMapper(string nome, string note, string preparazione)
        {
            this.nome = nome;
            this.note = note;
            this.preparazione = preparazione;

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
