![Logo LyonPalme](/LyonPalme/img/readme_logo.png)


# Gestion de Matériels - LyonPalme

## Sommaire

- [Description](#description)
- [Technologies Utilisées](#techno)
- [Diagramme d'activité](#activité)
- [Schema de la BDD](#BDD)
- [Prérequis](#prerequis)
- [Installation](#installation)
- [Utilisation](#utilisation)




## Description <a id="description"></a>

L'application "LyonPalme - Gestion de Matériels" a pour objectif la gestion efficace du matériel au sein de l'association LyonPalme, tout en offrant une interface conviviale pour sa visualisation. Elle facilite la création et la consultation des prêts, ainsi que la visualisation des membres inscrits à l'association.

## Technologies Utilisées <a id="techno"></a>

| **Nom** | **Description** |
| ------- | ------------- |
| C# | Langage de programmation orienté objet. |
| MicrosoftSQLServer | Base de données. |
| .Net | Framework .Net `6.0`. |
| Windows | Interface utilisateur avec Windows Forms |
| Git | Contrôle de version. |


## Diagramme d'activité <a id="activité"></a>

![Diagramme d'activité](/LyonPalme/img/activité.png)


## Schema de la BDD <a id="BDD"></a>

![Schema de la BDD](/LyonPalme/img/usecase.png)


## Prérequis <a id="prerequis"></a>
L'application est dépendante d'une base de données. Il faut se connecter au réseau de l'établissement des chassagnes pour pouvoir afficher les données.

## Installation <a id="installation"></a>

Pour installer l'application, suivez les étapes ci-dessous :

1. Clonez le dépôt Git sur votre machine locale.
2. Ouvrez le projet dans votre environnement de développement intégré (IDE) (Visual studio Code par exemple).

Vérifiez la présence du App.config à la racine du projet 
![Logo LyonPalme](/LyonPalme/img/Appconfig.png)

Si il n'y est pas :
3. Créez un nouveau fichier `App.config` dans le répertoire racine du projet.
4. Dans le fichier `App.config`, ajoutez le code nécessaire pour configurer l'accès à la base de données. Voici un exemple de ce à quoi pourrait ressembler votre fichier `App.config` :

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<startup>
		<supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
	</startup>
	<connectionStrings>
			<add name="sqlserver_creditsio" connectionString="Data Source=192.168.100.236; Initial Catalog=elyesamor;User ID=CBElyes; Password=@pp|iKT1ON!" providerName="System.Data.SqlClient"/>
</connectionStrings>
	<runtime>
		<assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
			<dependentAssembly>
				<assemblyIdentity name="System.Runtime.CompilerServices.Unsafe" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
				<bindingRedirect oldVersion="0.0.0.0-6.0.0.0" newVersion="6.0.0.0" />
			</dependentAssembly>
			<dependentAssembly>
				<assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30ad4fe6b2a6aeed" culture="neutral" />
				<bindingRedirect oldVersion="0.0.0.0-13.0.0.0" newVersion="13.0.0.0" />
			</dependentAssembly>
		</assemblyBinding>
	</runtime>
</configuration>
```


5. Sur votre interface cliquez sur "projet" en haut et cliquez sur “Publier LyonPalme”. Cela ouvrira une page. Choisissez l'emplacement (Personnellement je l'ai mis directement sur le bureau) puis cliquez sur “Suivant”. Selectionnez CD-ROM et cliquez sur “Suivant”. laissez sur ne pas vérifier les mises à jours et cliquez sur "Suivant". Puis Terminez. 
Vous avez maintenant l'application .exe. 
6. Assurez-vous d’être bien connecté au réseau de l’établissement ou utilisez un VPN pour vous y connecter !

7. Voici donc l'utilisateur pour se connecter à l'application lorsque vous l'avez executer :

| **Login** | **Mot de passe** |
| ------- | ------------- |
| elyes | amor |



## Utilisation <a id="utilisation"></a>

Pour utiliser l'application, il faut tout d'abord s'y connecter et seul l'administrateur le peut. Lorsqu'il se connecte, il se retrouve sur la page d'accueil où il retrouvera 3 boutons : 
- Voir les prêts, le stock de materiel disponible et ajouter un prêt.
- Recup Matériel pour récupérer les matériel et effacer un prêt.
- Tous les Materiels pour afficher la liste de chaque matériel (en comptant ceux prêtés) et ajouter un nouveau materiel (dont combinaison et monopalme).



