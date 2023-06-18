# Portfolio API

Portfolio API est un projet .NET 6 utilisant une base de données SQL SERVER permettant de récupérer des données.

## Démarrer le projet

### Prérequis
- Installer C# et .NET (https://visualstudio.microsoft.com/fr/downloads/)
- Installer SQL Server (https://www.microsoft.com/fr-fr/sql-server/sql-server-downloads)
- Installer Git (https://git-scm.com/downloads)

### Lancer le projet
Une fois que vous etes dans le répertoire du projet
- Installer les package nécéssaire au projet avec la ```commande dotnet restore```.
- Changer dans le fichier **appsettings.json** la valeur de "DefaultConnection" pour mettre la connexion vers votre base de données.
- Créer la base de données en utilisant la commande ```dotnet ef database update```.
- Dans le dossier **Document/SQL_REQUEST_GLOBAL/** se trouve le fichier **INSERT_SQL_TABLE_DATA**, copier-coller le contenu du fichier votre base de données.
	- Avec Microsoft SQL Management, cliquer sur "Bases de données" > "Portfolio", puis en haut à gauche, sur le bouton "Nouvelle requête", copier-coller le contenu du fichier et cliquer sur "Executer".

Vous pouvez maintenant démarrer le projet
- Si vous utiliser l'IDE Visual Studio, cliquer sur le bouton avec le triangle vert qui pointe vers la droite a coté duquel est écrit "Portfolio_API"
- Autrement, vous pouvez lancer le projet avec ```dotnet run```

Vous pourrez alors accéder au projet à cette URL : https://localhost:7206/swagger/index.html

### Taches
- [x] - UnitOfWork et Repositories
- [x] - EF Core
- [x] - Caching
- [x] - Rate Limit
- [ ] - Deploiement sur un Cloud Provider
- [ ] - MAJ du Front pour utiliser l'API