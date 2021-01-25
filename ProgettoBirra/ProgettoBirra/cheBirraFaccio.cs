using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoBirra
{
   public class cheBirraFaccio
    {

        private int idRicetta;
        private int quantitaMin;


        public cheBirraFaccio(int idRicetta, int quantitaMin)
        {
            this.idRicetta = idRicetta;
            this.quantitaMin = quantitaMin;

        }

        public int getidRicetta()
        {
            return idRicetta;
        }
        public int getquantitaMin()
        {
            return quantitaMin;
        }

        public void setidRicetta(int idRicetta)
        {
            this.idRicetta = idRicetta;
        }

        public void setquantitaMin(int quantitaMin)
        {
            this.quantitaMin = quantitaMin;
        }
    }
}
