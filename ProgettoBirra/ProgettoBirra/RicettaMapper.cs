namespace ProgettoBirra
{
    public class RicettaMapper
    {
        string nome;
        string note;
        string idRicetta;
        string preparazione;
        string attrezzi;

        public RicettaMapper(string nome, string note, string preparazione, string idRicetta, string attrezzi)
        {
            this.nome = nome;
            this.note = note;
            this.preparazione = preparazione;
            this.idRicetta = idRicetta;
            this.attrezzi = attrezzi;
        }
        public string getAttrezzi()
        {
            return attrezzi;
        }
        public string getidRicetta()
        {
            return idRicetta;
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
        
    }
}
