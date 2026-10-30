# Sport'SIO – Gestion de sportifs

![C#](https://img.shields.io/badge/C%23-Windows%20Forms-512BD4)
![MySQL](https://img.shields.io/badge/MySQL-BdSport-4479A1)
![BTS SIO](https://img.shields.io/badge/BTS%20SIO-AP%20SportSio%20%E2%80%93%20Mission%20C-lightgrey)

Application de bureau en **C# (Windows Forms)** permettant de consulter et de gérer les sportifs d'une association, les sports qu'ils pratiquent et leur niveau d'expérience. Les données sont stockées dans une base **MySQL** (`BdSport`) et accessibles via **ADO.NET**.

Projet réalisé dans le cadre du BTS SIO (AP SportSio, Mission C).

## Fonctionnalités

- **Connexion sécurisée** par login et mot de passe (mot de passe haché en SHA-256 par MySQL)
- **Création de compte** (login unique, mot de passe de 6 caractères minimum, confirmation)
- **Changement de mot de passe** (l'ancien mot de passe est exigé)
- **Consultation** de la liste des sportifs, avec recherche par ville, niveau d'expérience ou sport
- **Gestion des sportifs** : ajout, modification, suppression, avec contrôle de la saisie
- **Gestion des sports pratiqués** : ajout d'un sport avec son niveau, modification du niveau, retrait d'un sport (un même sport ne peut pas être ajouté deux fois)

## Architecture

La solution est organisée en trois projets :

| Projet | Rôle |
|---|---|
| `APProjetSport` | Interface Windows Forms : `Program`, `FormConnexion`, `FormConnexionCompte`, `AGestion`, `FormChangementMdp` |
| `BiblioSportif` | Classes métier : `Sportif`, `Sport`, `Niveau`, `Pratique` |
| `GestionSportif` | Accès aux données : `ConnexionManager`, `GSportif`, `GUtilisateur` |

![Architecture de la solution](docs/architecture.png)

## Base de données

La base `BdSport` contient cinq tables. La table `Pratique` associe un sportif à un sport et à un niveau ; sa clé primaire `(idSportif, idSport)` interdit les doublons.

![Schéma de la base de données](docs/base-de-donnees.png)

| Table | Contenu |
|---|---|
| `Sportif` | Identité, date de naissance et adresse |
| `Sports` | Sports proposés (Football, Tennis, Judo, Natation, Basketball, Rugby, Course) |
| `Experience` | Niveaux : Débutant, Confirmé, Avancé, Professionnel |
| `Pratique` | Sport et niveau d'un sportif |
| `Utilisateur` | Comptes de connexion (login unique, mot de passe haché) |

## Installation

### Prérequis

- Visual Studio (projet C# Windows Forms)
- MySQL
- Package NuGet `MySql.Data`

### Mise en place

1. Cloner le dépôt :
   ```bash
   git clone https://github.com/<votre-compte>/<nom-du-depot>.git
   ```
2. Créer la base en exécutant les scripts SQL, dans cet ordre :
   - `BdSport.sql` (création de la base et des tables)
   - `JeuDeDonnees.sql` (jeu de données, **à exécuter une seule fois**)
   - `Utilisateur.sql` (compte de démonstration)
3. Renseigner la chaîne de connexion dans le fichier `App.config` (clé `cnxBdSport`) :
   ```xml
   <connectionStrings>
     <add name="cnxBdSport"
          connectionString="Server=localhost;Database=BdSport;Uid=VOTRE_UTILISATEUR;Pwd=VOTRE_MOT_DE_PASSE;"
          providerName="MySql.Data.MySqlClient" />
   </connectionStrings>
   ```
4. Ouvrir la solution dans Visual Studio, restaurer les packages NuGet, puis lancer l'application.

### Compte de démonstration

Le script `Utilisateur.sql` crée le compte `admin` (mot de passe `admin123`). Il est destiné à la démonstration : pensez à le changer depuis l'application.

## Aperçu du code

Les mots de passe ne sont jamais stockés en clair et toutes les requêtes sont paramétrées :

```csharp
MySqlCommand cmd = new MySqlCommand(
    "SELECT COUNT(*) FROM Utilisateur " +
    "WHERE login = @login AND mdp = SHA2(@mdp, 256)", cnx);
cmd.Parameters.AddWithValue("@login", login);
cmd.Parameters.AddWithValue("@mdp", mdp);
return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
```

## Captures d'écran

<!--
Ajouter vos captures dans le dossier docs/ puis décommenter :

![Connexion](docs/capture-connexion.png)
![Consultation](docs/capture-consultation.png)
![Gestion des sportifs](docs/capture-gestion.png)
-->

## Technologies

C# · Windows Forms · ADO.NET · MySQL · Programmation orientée objet
