namespace ProgettoBirra
{

    public class AttrezzoMapper
    {
        private string nome;
        private string capacita;

        public AttrezzoMapper(string nome, string capacita)
        {
            this.nome = nome;
            this.capacita = capacita;
        }
        public string getNome()
        {
            return nome;
        }
        public string getCapacita()
        {
            return capacita;
        }
        
    }
}
