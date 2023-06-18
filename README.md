# Portfolio API

Portfolio API est un projet .NET 6 utilisant une base de données SQL SERVER permettant de récupérer des données.

![API](https://github.com/BastienBYRA/Portfolio-API/blob/master/Document/SHOWCASE_SCREENS/API-SWAGGER.JPG)

## Démarrer le projet

### Prérequis
- Installez C# et .NET (https://visualstudio.microsoft.com/fr/downloads/)
- Installez SQL Server (https://www.microsoft.com/fr-fr/sql-server/sql-server-downloads)
- Installez Git (https://git-scm.com/downloads)

### Lancer le projet
Une fois que vous êtes dans le répertoire du projet :
- Installez les packages nécessaires au projet en utilisant la commande ```dotnet restore```.
- Modifiez la valeur de la clé "DefaultConnection" dans le fichier **appsettings.json** pour qu'elle corresponde à la connexion de votre base de données.
- Créez la base de données en utilisant la commande ```dotnet ef database update```.
- Dans le dossier **Document/SQL_REQUEST_GLOBAL/**, vous trouverez le fichier INSERT_SQL_TABLE_DATA. Copiez-collez le contenu de ce fichier dans votre base de données.
	- Avec Microsoft SQL Management, cliquez sur "Bases de données" > "Portfolio", puis en haut à gauche, cliquez sur le bouton "Nouvelle requête". Collez ensuite le contenu du fichier et cliquez sur "Exécuter".

Vous pouvez maintenant démarrer le projet
- Si vous utilisez l'IDE Visual Studio, cliquez sur le bouton en forme de triangle vert à côté de l'inscription "Portfolio_API".
- Sinon, vous pouvez lancer le projet en utilisant la commande ```dotnet run```.

Vous pourrez ensuite accéder au projet via l'URL suivante : https://localhost:7206/swagger/index.html

### Taches
- [x] - UnitOfWork et Repositories
- [x] - EF Core
- [x] - Caching
- [x] - Rate Limit
- [ ] - Conteneuriser le projet avec Docker
- [ ] - Deploiement sur un Cloud Provider
- [ ] - MAJ du Front pour utiliser l'API
