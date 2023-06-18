
-- Data : Category_Languages
INSERT INTO Category_Languages VALUES('Front-End');
INSERT INTO Category_Languages VALUES('Back-End');
INSERT INTO Category_Languages VALUES('Database');
INSERT INTO Category_Languages VALUES('Mobile');
INSERT INTO Category_Languages VALUES('Scripting');
INSERT INTO Category_Languages VALUES('Outils');

-- Data : Types_Experiences
INSERT INTO Types_Experiences VALUES ('school');
INSERT INTO Types_Experiences VALUES ('work');

-- Data : Missions
INSERT INTO Missions VALUES ('Faire de la documentation technique / utilisateur.');
INSERT INTO Missions VALUES ('Refonte graphique.');
INSERT INTO Missions VALUES ('Sécurisation / Gestion des erreurs.');
INSERT INTO Missions VALUES ('Ajout de nouvelles fonctionnalités.');
INSERT INTO Missions VALUES ('Optimiser le code précédent.');
INSERT INTO Missions VALUES ('Conception graphique.');
INSERT INTO Missions VALUES ('Mise en place de Docker.');
INSERT INTO Missions VALUES ('Mise en place de l''infrastructure de l''application.');
INSERT INTO Missions VALUES ('Création de scripts de récupération de données.');
INSERT INTO Missions VALUES ('Création d''un script de manipulation de données.');
INSERT INTO Missions VALUES ('Création d''un script d''équivalence a partir de la manipulation des données effectuées.');
INSERT INTO Missions VALUES ('Refonte technique de l''application.');
INSERT INTO Missions VALUES ('Création des fonctionnalités de l''application.');
INSERT INTO Missions VALUES ('Analyse de la marque.');
INSERT INTO Missions VALUES ('Création d''une charte graphique.');
INSERT INTO Missions VALUES ('Création d''un logo.');
INSERT INTO Missions VALUES ('Conception de wireframe.');
INSERT INTO Missions VALUES ('Conception d''une maquette.');
INSERT INTO Missions VALUES ('Programmation Objet.');
INSERT INTO Missions VALUES ('Programmation Web (JavaScript, React, VueJS).');
INSERT INTO Missions VALUES ('Programmation Back-end (.NET, NodeJS, Symfony, Spring Boot, Ruby On Rails).');
INSERT INTO Missions VALUES ('Bases de données SQL et NoSQL (MySQL, MariaDB, MongoDB).');
INSERT INTO Missions VALUES ('Programmation mobile (React Native).');
INSERT INTO Missions VALUES ('Gestion de projet : Méthodes agiles (Scrum, Kanban).');
INSERT INTO Missions VALUES ('Cybersécurité.');
INSERT INTO Missions VALUES ('DevOps : Docker, Docker compose, Pipeline CI/CD.');
INSERT INTO Missions VALUES ('Webdesign - Ergonomie (avec Suite Adobe).');
INSERT INTO Missions VALUES ('Modelisation 3D (OpenInventor).');
INSERT INTO Missions VALUES ('Versionning et travaille collaboratif : Git.');
INSERT INTO Missions VALUES ('Programmation Web (HTML, CSS).');
INSERT INTO Missions VALUES ('Programmation Back-end (PHP, C#, Java).');
INSERT INTO Missions VALUES ('Bases de données SQL (MySQL).');
INSERT INTO Missions VALUES ('Programmation Android (Java).');
INSERT INTO Missions VALUES ('Scripting (Python, Bash).');
INSERT INTO Missions VALUES ('Administration Système : Linux.');
INSERT INTO Missions VALUES ('Virtualisation : VirtualBox.');
INSERT INTO Missions VALUES ('Testing (Unitaire).');
INSERT INTO Missions VALUES ('Reglementation sur le traitement des données (CNIL, RGPD).');
INSERT INTO Missions VALUES ('Création d''un plugin Wordpress.');

-- Data : Periods
INSERT INTO Periods VALUES (2022, 2023);
INSERT INTO Periods VALUES (2020, 2022);
INSERT INTO Periods VALUES (2017, 2020);

-- Data : Projects
INSERT INTO Projects VALUES('Acteon Satelec - DIGIT-ACTEON',
'ACTEON2.png', 'Site web interne de l''entreprise Acteon Satelec.',
'Digit-Acteon est une web application ASP.NET MVC interne à l''entreprise Acteon permettant de réaliser l''ensemble des processus jusqu''alors sur papier maintenant numériquement, l''application à pour but de centraliser un ensemble de processus en une application en assurant l''intégrité des données entre les différents processus.',
'Developpeur Full-Stack');
INSERT INTO Projects VALUES('Mon site portfolio',
'PORTFOLIO3.png', 'Un site réalisé par mes soins afin de me présenter.',
'Mon site portfolio réalisé avec React (Component / Class) et le framework CSS "Tailwind CSS" est un site web ayant pour but de me présenter, moi, mes projets et mes compétences. \r\n\nCe projet a été conteneurisé avec Docker, et deployé sur Microsoft Azure avec Terraform.\r\n👉 Lien du portfolio sur Azure : https://byra-portfolio-example.azurewebsites.net/Portfolio',
'Developpeur Front-End, Ingénieur DevOps');
INSERT INTO Projects VALUES('EMS Proto - Web Scrapping',
'EMSPROTO.png', 'Script de collecte de données des sites Mouser et Digikey.',
'Un ensemble de script réalisé en Python avec la librairie Selenium permettant de récupérer des données en ligne sur les sites de Mouser et Digikey, afin de pouvoir rechercher et faire des comparaisons entre les différentes données collecté.',
'Developpeur de Scripts');
INSERT INTO Projects VALUES('Obbymedia - U me Jobs',
'OBBYMEDIA2.png', 'Application mobile de mise en relation recruteur / demandeur d''emploi.',
'U me Jobs est une application mobile créer en Flutter disponible sur le Play Store et l''App Store mettant en relation des candidats et des professionnels de l''hotellerie restauration en Nouvelle Aquitaine.',
'Developpeur Mobile');
INSERT INTO Projects VALUES('User Application (CRUD App)',
'USERCRUD.png', 'Application CRUD utilisant Docker.',
'User Application (CRUD App) est un site web simpliste permettant de créer, modifier, supprimer et rechercher des utilisateurs, le projet utilise Node.js avec Express, une base de données MongoDB, ainsi que Docker.',
'Developpeur Full-Stack');
INSERT INTO Projects VALUES('KAWAII - Conception de Webdesign',
'KAWAII.png', 'Conception du site du Foodtruck fictif "KAWAII".',
'Ce projet porte sur la conception de l''image de marque de KAWAII, par la création d''un brief client, de la réalisation d''un benchmark, d''une charte graphique, d''un logo, de wireframe et finalement d''une maquette du site web.',
'Webdesigner');
INSERT INTO Projects VALUES('BYRA Marketplace',
'BYRAMARKETPLACE.png', 'Site web presentant une marketplace.',
'BYRA Marketplace est un site web réalisé en React (Functionnal) avec l''API FakeStore et SessionStorage présentant une marketplace, on peut consulter, ajouter, modifier, supprimer ou acheter les articles de son panier.',
'Developpeur Front-End');

-- Data : Langages
INSERT INTO Langages VALUES ('HTML.svg','HTML','false', 1);
INSERT INTO Langages VALUES ('CSS.svg','CSS','false', 1);
INSERT INTO Langages VALUES ('JS.svg','JavaScript','false', 1);
INSERT INTO Langages VALUES ('REACT.svg','React','false', 1);
INSERT INTO Langages VALUES ('JQUERY.png','JQuery','false', 1);
INSERT INTO Langages VALUES ('TAILWIND.svg','Tailwind CSS','false', 1);
INSERT INTO Langages VALUES ('CSHARP.svg','C#','false', 2);
INSERT INTO Langages VALUES ('.NET.svg','.NET','false', 2);
INSERT INTO Langages VALUES ('JAVA.svg','Java','false', 2);
INSERT INTO Langages VALUES ('NODEJS.svg','Node.js','false', 2);
INSERT INTO Langages VALUES ('PHP.svg','PHP','false', 2);
INSERT INTO Langages VALUES ('SYMFONY.png','Symfony','false', 2);
INSERT INTO Langages VALUES ('MYSQL.svg','MySQL','false', 3);
INSERT INTO Langages VALUES ('SQLSERVER.png','SQL Server','true', 3);
INSERT INTO Langages VALUES ('MONGODB.png','MongoDB','false', 3);
INSERT INTO Langages VALUES ('DART.svg','Dart','false', 4);
INSERT INTO Langages VALUES ('FLUTTER.svg','Flutter','false', 4);
INSERT INTO Langages VALUES ('REACT.svg','React Native','false', 4);
INSERT INTO Langages VALUES ('PYTHON.png','Python','false', 5);
INSERT INTO Langages VALUES ('BASH.svg','Bash','false', 5);
INSERT INTO Langages VALUES ('GIT.svg','Git','false', 6);
INSERT INTO Langages VALUES ('LINUX.svg','Linux','false', 6);
INSERT INTO Langages VALUES ('DOCKER.webp','Docker','false', 6);
INSERT INTO Langages VALUES ('TERRAFORM.svg','Terraform','false', 6);
INSERT INTO Langages VALUES ('AZURE.svg','Azure','false', 6);
INSERT INTO Langages VALUES ('GITHUB.svg','Github','false', 6);
INSERT INTO Langages VALUES ('SELENIUM.png','Selenium','false', 6);
INSERT INTO Langages VALUES ('ADOBEXD.svg','Adobe XD','false', 6);
INSERT INTO Langages VALUES ('BOOTSTRAP.svg','Bootstrap','false', 1);
INSERT INTO Langages VALUES ('ADOBEAI.svg','Adobe AI','false', 6);

-- Data : Experiences
INSERT INTO Experiences VALUES ('Apprentissage à IUT de Bordeaux Licence Pro DAWIN, Bac +3 - 1 an', 
'Pendant cette année de licence pro, j''ai pu renforcer mes connaissances concernant le développement de solution informatique (Programmation, Bases de données, Cybersécurité, Agilité...) ainsi qu''apprendre de nouveau concept et langage.',
'https://www.iut.u-bordeaux.fr/general/wp-content/uploads/2017/03/iut_Bordeaux_RVB-01-e1488459784711.jpg', 1, 1);
INSERT INTO Experiences VALUES ('Alternance chez Acteon Satelec - 1 an', 
'Pendant cette année d''alternance, j''ai travaillé sur le site web interne DigitActeon, un site web ayant pour but d''assurer la centralisation et digitalisation des données, assurer l''intégrité des données entres les différents ateliers interne, assurer le respect des normes qualité et réglementation en vigueur.',
'https://sserenity-dentaire.com/wp-content/uploads/2018/09/acteon-satelec-sopro-logiciel-dentaire.jpg', 2, 1);
INSERT INTO Experiences VALUES ('Apprentissage au Lycée Gustave Eiffel BTS SIO SLAM, Bac +2 - 2 ans', 
'Pendant ces deux années de BTS, j''ai pu apprendre la programmation web, objet, mobile, la cybersécurité, l''agilité, l''administration Linux, la manipulation de SGDB / Base de données et ce qui l''entoure (TLDR : CNIL, RGPD).',
'https://file.diplomeo-static.com/file/00/00/01/48/14869.svg', 1, 2);
INSERT INTO Experiences VALUES ('Stage chez Obbymedia - 8 semaines (2ème année de BTS)', 
'Pendant mon stage, j''ai effectué la refonte technique complète de l''application pré-existante ''U me Jobs'', mon objectif était de refaire l''application déja existante Angular / Ionic en Flutter.',
'https://www.obbymedia.fr/wp-content/uploads/2022/05/Logo-ObbyMedia-RVB-fc.png', 2, 2);
INSERT INTO Experiences VALUES ('Stage chez EMS Proto - 6 semaines (1ère année de BTS)', 
'Pendant mon stage, j''ai réalisé des scripts de Webscrapping afin de récupérer des données sur les sites de Digikey et Mouser, ainsi qu''un script de manipulation des données et d''équivalence.',
'https://www.unitec.fr/wp-content/uploads/2018/07/emsproto_logo.png', 2, 2);

-- Data : ExperienceMission
INSERT INTO ExperienceMission VALUES (1, 19);
INSERT INTO ExperienceMission VALUES (1, 20);
INSERT INTO ExperienceMission VALUES (1, 21);
INSERT INTO ExperienceMission VALUES (1, 22);
INSERT INTO ExperienceMission VALUES (1, 23);
INSERT INTO ExperienceMission VALUES (1, 24);
INSERT INTO ExperienceMission VALUES (1, 25);
INSERT INTO ExperienceMission VALUES (1, 26);
INSERT INTO ExperienceMission VALUES (1, 27);
INSERT INTO ExperienceMission VALUES (1, 28);
INSERT INTO ExperienceMission VALUES (1, 29);
INSERT INTO ExperienceMission VALUES (2, 1);
INSERT INTO ExperienceMission VALUES (2, 2);
INSERT INTO ExperienceMission VALUES (2, 3);
INSERT INTO ExperienceMission VALUES (2, 4);
INSERT INTO ExperienceMission VALUES (2, 5);
INSERT INTO ExperienceMission VALUES (3, 19);
INSERT INTO ExperienceMission VALUES (3, 30);
INSERT INTO ExperienceMission VALUES (3, 31);
INSERT INTO ExperienceMission VALUES (3, 32);
INSERT INTO ExperienceMission VALUES (3, 33);
INSERT INTO ExperienceMission VALUES (3, 34);
INSERT INTO ExperienceMission VALUES (3, 35);
INSERT INTO ExperienceMission VALUES (3, 36);
INSERT INTO ExperienceMission VALUES (3, 37);
INSERT INTO ExperienceMission VALUES (3, 38);
INSERT INTO ExperienceMission VALUES (4, 9);
INSERT INTO ExperienceMission VALUES (4, 10);
INSERT INTO ExperienceMission VALUES (4, 11);
INSERT INTO ExperienceMission VALUES (4, 5);
INSERT INTO ExperienceMission VALUES (3, 12);

-- Data : MissionProject
INSERT INTO MissionProject VALUES (1, 1);
INSERT INTO MissionProject VALUES (2, 1);
INSERT INTO MissionProject VALUES (3, 1);
INSERT INTO MissionProject VALUES (4, 1);
INSERT INTO MissionProject VALUES (5, 1);
INSERT INTO MissionProject VALUES (6, 2);
INSERT INTO MissionProject VALUES (7, 2);
INSERT INTO MissionProject VALUES (8, 2);
INSERT INTO MissionProject VALUES (9, 3);
INSERT INTO MissionProject VALUES (10, 3);
INSERT INTO MissionProject VALUES (11, 3);
INSERT INTO MissionProject VALUES (12, 4);
INSERT INTO MissionProject VALUES (5, 4);
INSERT INTO MissionProject VALUES (13, 5);
INSERT INTO MissionProject VALUES (7, 5);
INSERT INTO MissionProject VALUES (6, 5);
INSERT INTO MissionProject VALUES (14, 6);
INSERT INTO MissionProject VALUES (15, 6);
INSERT INTO MissionProject VALUES (16, 6);
INSERT INTO MissionProject VALUES (17, 6);
INSERT INTO MissionProject VALUES (18, 6);
INSERT INTO MissionProject VALUES (6, 7);
INSERT INTO MissionProject VALUES (13, 7);

-- Data : LangageProject
INSERT INTO LangageProject VALUES (7, 1);
INSERT INTO LangageProject VALUES (8, 1);
INSERT INTO LangageProject VALUES (1, 1);
INSERT INTO LangageProject VALUES (2, 1);
INSERT INTO LangageProject VALUES (3, 1);
INSERT INTO LangageProject VALUES (29, 1);
INSERT INTO LangageProject VALUES (14, 1);
INSERT INTO LangageProject VALUES (21, 1);
INSERT INTO LangageProject VALUES (4, 2);
INSERT INTO LangageProject VALUES (6, 2);
INSERT INTO LangageProject VALUES (7, 2);
INSERT INTO LangageProject VALUES (8, 2);
INSERT INTO LangageProject VALUES (21, 2);
INSERT INTO LangageProject VALUES (23, 2);
INSERT INTO LangageProject VALUES (24, 2);
INSERT INTO LangageProject VALUES (25, 2);
INSERT INTO LangageProject VALUES (19, 3);
INSERT INTO LangageProject VALUES (27, 3);
INSERT INTO LangageProject VALUES (16, 4);
INSERT INTO LangageProject VALUES (17, 4);
INSERT INTO LangageProject VALUES (21, 4);
INSERT INTO LangageProject VALUES (10, 5);
INSERT INTO LangageProject VALUES (15, 5);
INSERT INTO LangageProject VALUES (23, 5);
INSERT INTO LangageProject VALUES (21, 5);
INSERT INTO LangageProject VALUES (28, 6);
INSERT INTO LangageProject VALUES (30, 6);
INSERT INTO LangageProject VALUES (4, 7);
INSERT INTO LangageProject VALUES (21, 7);