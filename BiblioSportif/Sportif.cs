using System;
using System.Collections.Generic;

namespace BiblioSportif
{
    public class Sportif
    {
        private int id;
        private string nom;
        private string prenom;
        private DateTime dateNais;
        private string rue;
        private string ville;
        private string codePostal;
        private List<Pratique> pratiques;

        // Le sport et le niveau ne sont plus dans le sportif :
        // ils sont dans la liste de ses pratiques (un sportif peut en avoir plusieurs)
        public Sportif(int id, string nom, string prenom, DateTime dateNais, string rue, string ville, string codePostal)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNais = dateNais;
            this.rue = rue;
            this.ville = ville;
            this.codePostal = codePostal;
            this.pratiques = new List<Pratique>();
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNais { get => dateNais; set => dateNais = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Ville { get => ville; set => ville = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public List<Pratique> Pratiques { get => pratiques; set => pratiques = value; }

        // Règle de gestion : vrai si le sportif pratique déjà ce sport
        public bool PratiqueSport(int idSport)
        {
            for (int i = 0; i < pratiques.Count; i++)
            {
                if (pratiques[i].Sport.Id == idSport)
                {
                    return true;
                }
            }
            return false;
        }

        // Texte résumé : "Natation (Avancé), Tennis (Confirmé)"
        public string ResumeSports()
        {
            string resume = "";
            for (int i = 0; i < pratiques.Count; i++)
            {
                if (i > 0)
                {
                    resume += ", ";
                }
                resume += pratiques[i].Sport.Nom + " (" + pratiques[i].Niveau.Nom + ")";
            }
            return resume;
        }
    }
}
