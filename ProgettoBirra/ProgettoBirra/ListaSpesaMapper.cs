namespace ProgettoBirra
{
    public class ListaSpesaMapper
    {
        private string nomeProd;
        private string quantita;
        public ListaSpesaMapper(string nomeProd, string quantita)
        {
            this.nomeProd = nomeProd;
            this.quantita = quantita;
        }
        public string getnomeProd()
        {
            return nomeProd;
        }
        public string getQuantita()
        {
            return quantita;
        }
        /*
        public void setnomeProd(string nomeProd)
        {
            this.nomeProd = nomeProd;
        }
        public void setQuantita(string quantita)
        {
            this.quantita = quantita;
        }
        */
    }
}
