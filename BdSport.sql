CREATE DATABASE IF NOT EXISTS BdSport;
USE BdSport;

CREATE TABLE IF NOT EXISTS Sportif (
	id int auto_increment,
    nom varchar(25),
    prenom varchar(25),
    dateNais date,
    rue varchar(25),
    CP varchar(25),
    ville varchar(25),
    nivExperience varchar(25),
    nomSport varchar(25),
    PRIMARY KEY (id)
    
    ) ENGINE=InnoDB;
    
CREATE TABLE IF NOT EXISTS Sports (
	id int auto_increment,
    nom varchar(25),
    PRIMARY KEY	(id)
    )ENGINE=InnoDB;
    
CREATE TABLE IF NOT EXISTS Experience(
	id int auto_increment,
    nom varchar(25),
    PRIMARY KEY (id)
    )ENGINE=InnoDB;
    
CREATE TABLE IF NOT EXISTS Pratique(
		id_sportif int,
        id_sports int,
        id_experience int,
        PRIMARY KEY(id_sportif,id_sports),
        FOREIGN KEY (id_sportif) REFERENCES Sportif(id),
        FOREIGN KEY (id_sports) REFERENCES  Sports(id),
        FOREIGN KEY  (id_experience)REFERENCES Experience(id)
        )ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Utilisateur(
		id int  AUTO_INCREMENT,
        login varchar (50) NOT NULL UNIQUE,
        mdp varchar (64) NOT NULL,
        PRIMARY KEY (id)
        )Engine= InnoDB
    