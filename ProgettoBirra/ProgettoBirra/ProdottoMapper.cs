namespace ProgettoBirra
{

    public class ProdottoMapper
    {
        private string nome;
        private string quantita;

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
       
    }
}
