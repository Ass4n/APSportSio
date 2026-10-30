namespace BiblioSportif
{
    // Un sport proposé par l'association (table Sports)
    public class Sport
    {
        private int id;
        private string nom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public Sport(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        // Permet d'afficher directement l'objet dans une ComboBox
        public override string ToString()
        {
            return Nom;
        }
    }
}
