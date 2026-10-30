USE BdSport;

-- À exécuter UNE SEULE FOIS (sinon les lignes seront en double)
INSERT INTO Sportif (nom, prenom, dateNais, rue, CP, ville, nivExperience, nomSport) VALUES
('DUPONT',  'Emma',   '2001-04-12', '12 rue des Lilas',     '63000', 'Clermont-Ferrand', 'Avancé',        'Natation'),
('DAVOLIO', 'Jeanne', '1999-09-23', '5 avenue de la Gare',  '63100', 'Clermont-Ferrand', 'Avancé',        'Tennis'),
('MARTIN',  'Julien', '2003-01-30', '8 rue Pasteur',        '63200', 'Riom',             'Confirmé',      'Football'),
('LEROY',   'Camille','1995-06-17', '21 boulevard Gergovia','63000', 'Clermont-Ferrand', 'Professionnel', 'Rugby'),
('BERNARD', 'Lucas',  '2005-11-02', '3 impasse des Pins',   '63400', 'Chamalières',      'Débutant',      'Judo'),
('PETIT',   'Sarah',  '1998-03-08', '17 rue Victor Hugo',   '63500', 'Issoire',          'Confirmé',      'Basketball'),
('ROBERT',  'Hugo',   '2002-12-25', '9 rue du Stade',       '63200', 'Riom',             'Débutant',      'Course'),
('MOREAU',  'Chloé',  '2000-07-14', '40 avenue Charras',    '63000', 'Clermont-Ferrand', 'Professionnel', 'Natation');

-- Tables de référence (utiles pour le niveau 4)
INSERT INTO Sports (nom) VALUES ('Football'), ('Tennis'), ('Judo'), ('Natation'), ('Basketball'), ('Rugby'), ('Course');
INSERT INTO Experience (nom) VALUES ('Débutant'), ('Confirmé'), ('Avancé'), ('Professionnel');
