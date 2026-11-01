namespace BiblioSportif
{
    // Un niveau d'expérience (table Experience)
    public class Niveau
    {
        private int id;
        private string nom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public Niveau(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
