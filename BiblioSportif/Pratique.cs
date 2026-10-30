
namespace BiblioSportif
{
    // Un sport pratiqué par un sportif, avec le niveau associé (table Pratique)
    public class Pratique
    {
        private Sport sport;
        private Niveau niveau;

        public Sport Sport { get => sport; set => sport = value; }
        public Niveau Niveau { get => niveau; set => niveau = value; }

        public Pratique(Sport sport, Niveau niveau)
        {
            Sport = sport;
            Niveau = niveau;
        }
    }
}
