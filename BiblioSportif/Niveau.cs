namespace BiblioSportif
{
    // Un niveau d'expérience (table Experience)
    public class Niveau
    {
        public int Id { get; set; }
        public string Nom { get; set; }

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
