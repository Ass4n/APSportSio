using System;

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

        // Change le niveau en vérifiant qu'il n'est pas vide
        public void ChangerNiveau(Niveau nouveauNiveau)
        {
            if (nouveauNiveau == null)
            {
                throw new Exception("Le niveau est obligatoire.");
            }
            Niveau = nouveauNiveau;
        }
    }
}
