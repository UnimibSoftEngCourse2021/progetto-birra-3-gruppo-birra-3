using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoBirra
{

    public class ProdottoMapper
    {
        private string nome;
        private string quantita;


        public ProdottoMapper()
        { }

        public ProdottoMapper(string nome, string quantita)
        {
            this.nome = nome;
            this.quantita = quantita;

        }

        public string getNome()
        {
            return nome;
        }

        public string getQuantita()
        {
            return quantita;
        }


        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setQuantita(string quantita)
        {
            this.quantita = quantita;
        }
    }
}
