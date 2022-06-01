# FulBank
BANK ET CRYPTO

<hr>

## Contexte
FULBANK est une banque nouvelle et moderne qui souhaite s'ouvrir en incluant des services bancaire classique mais aussi de la crypto monnaie.

## Besoin
La banque veut créer pour ses bornes un logiciel permettant de consulter sescomptes de manière classique mais aussi de pouvoir consulter son portefeuille crypto, de pouvoir échanger de la crypto en Euro ou des Euro en crypto en fonction du cours du moment. Pour cela vous devrez trouver une api ou une DLL permettant de récupérer le cours du marché.
Les utilisateurs devront s'authentifier à l'application pour n'importent quelles actions proposées par une banque classique. (virement, achat de crypto, ajoutet récupération de fond, consultation de solde...).
Un pc simulera une borne physique avec une authentification spécifique quisera répertorié sur chaque transaction.

## Travail en groupe

- Vous travaillerez par groupe de 3 personnes maximum.
- Vous devrez utiliser `GIT`
- Vous proposerez une charte graphique, des mockup, un mcd, le use case,un planning, et organiserez votre projet à l'aide de la méthode scrum. Enproposant des points régulier avec votre responsable,  ou vous rendrezcompte de l'avancer des travaux de votre équipe.

## Contrainte Technique
Vous devez réaliser l'application en `C#` ou en `JAVA`.
Vous pouvez stocker les données dans une Base de données déportée de votrechoix.
Vous rédigerez un guide pour développeurs afin qu'ils puissent installerl'application et développer rapidement dessus.

## Charte Graphique
Pour la charte graphique on vous impose d'utiliser les couleurs suivantes:
- Bleu foncé : `#224399`;
- Bleu Clair: `#80c2ec`;
- font-family: 'Open Sans', sans-serif;

<hr>

## Comment l'installer ?

Télécharger le dossier, ouvrir la solution dans un IDE supportant C# et lancer le projet pour regénérer la solution avec tout les packages et l'exécutable.
Dans le fichier Fulbank/bin/debug/fulbank.ini (à créer si il n'existe pas déja), écrire ceci : 

- `[Fulbank]`
- `Id={id de la machine}`
- `Address={adresse de la machine (facultatif)}`

L'environnement de dev contient les versions `5.7.31 de Mysql` et `2.4.46 d'Apache`

Créer une base de données Mysql au nom de 'fulbank' et importer le fichier `fulbankenprod.sql` et rentrer ses coordonnées dans la ligne 22 du fichier `FulBank/FormMain.cs`

Déplacez le dossier templates dans `Fulbank/Debug/bin`

Si vous souhaitez utiliser plusieurs machines et que la base de données est déja installée, seulement changer la ligne de connexion.

Il n'y aura qu'un utilisateur administrateur (à vous d'en créer dans la base de données si vous en voulez plusieurs en créant une entité personne et entrant son id dans la table admin). Et ses identifiants sont : `id = 1` et `mot de passe = 'M0tdeP@sse'`

Afin de créer un utilisateur, il faut se connecter à l'application avec le compte admin et aller dans l'onglet "créer un compte utilisateur", rentrer ses informations et cliquer sur créer, l'id affiché sera celui avec lequel il devra se connecter. 
Esuite lui créer un compte bancaire de la même façon dans l'onglet "créer un compte bancaire" en faisant attention à ce que cet utilisateur n'ai pas déja un compte du même type.





