﻿namespace ProgettoBirra
{
   public class CheBirraFaccio
    {

        private int idRicetta;
        private int quantitaMin;

        public CheBirraFaccio(int idRicetta, int quantitaMin)
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
        /*
        public void setidRicetta(int idRicetta)
        {
            this.idRicetta = idRicetta;
        }

        public void setquantitaMin(int quantitaMin)
        {
            this.quantitaMin = quantitaMin;
        }
        */
    }
}
