# Portfolio API

Portfolio API est un projet .NET 6 utilisant une base de donn�es SQL SERVER permettant de r�cup�rer des donn�es.

![API](https://github.com/BastienBYRA/Portfolio-API/blob/master/Document/SHOWCASE_SCREENS/API-SWAGGER.JPG)

## D�marrer le projet

### Pr�requis
- Installer C# et .NET (https://visualstudio.microsoft.com/fr/downloads/)
- Installer SQL Server (https://www.microsoft.com/fr-fr/sql-server/sql-server-downloads)
- Installer Git (https://git-scm.com/downloads)

### Lancer le projet
Une fois que vous etes dans le r�pertoire du projet
- Installer les package n�c�ssaire au projet avec la ```commande dotnet restore```.
- Changer dans le fichier **appsettings.json** la valeur de "DefaultConnection" pour mettre la connexion vers votre base de donn�es.
- Cr�er la base de donn�es en utilisant la commande ```dotnet ef database update```.
- Dans le dossier **Document/SQL_REQUEST_GLOBAL/** se trouve le fichier **INSERT_SQL_TABLE_DATA**, copier-coller le contenu du fichier votre base de donn�es.
	- Avec Microsoft SQL Management, cliquer sur "Bases de donn�es" > "Portfolio", puis en haut � gauche, sur le bouton "Nouvelle requ�te", copier-coller le contenu du fichier et cliquer sur "Executer".

Vous pouvez maintenant d�marrer le projet
- Si vous utiliser l'IDE Visual Studio, cliquer sur le bouton avec le triangle vert qui pointe vers la droite a cot� duquel est �crit "Portfolio_API"
- Autrement, vous pouvez lancer le projet avec ```dotnet run```

Vous pourrez alors acc�der au projet � cette URL : https://localhost:7206/swagger/index.html

### Taches
- [x] - UnitOfWork et Repositories
- [x] - EF Core
- [x] - Caching
- [x] - Rate Limit
- [ ] - Deploiement sur un Cloud Provider
- [ ] - MAJ du Front pour utiliser l'API