# TP Développement d'une application RPGQuest en C# avec accès à la base de données MariaDB

## Objectif du TP
Créer une application en C# pour RPGQuest qui interagit avec une base de données MariaDB. L'application devra permettre de récupérer et manipuler des données du jeu.

## Prérequis
1. Connaissances de base en C#.
2. Un environnement de développement C# installé (par exemple, Visual Studio).
3. Un serveur de base de données MariaDB ou MySql opérationnel.
4. Le script SQL de la base de données "TP8 - RPGQuest.sql".

## Étapes

### 1. Mise en place du projet C#
- Clonez le dépôt GitHub du projet RPGQuest : [https://github.com/kferrandonFulbert/RPGQuest](https://github.com/kferrandonFulbert/RPGQuest).
- Prenez en considération le code existant qui se connecte à la base de données et alimente la ComboBox "Arme". Les étudiants sont encouragés à s'inspirer de cette implémentation pour alimenter les ComboBox "Armure" et "Classe".

### 2. Alimentation des ComboBox "Armure" et "Classe"
- Inspirez-vous du code existant pour la ComboBox "Arme" et adaptez-le pour les ComboBox "Armure" et "Classe".
- Assurez-vous que les ComboBox sont correctement alimentées à partir de la base de données.

### 3. Dispatcher les 20 points dans la Force, la Magie et la Défense
- Ajoutez une interface utilisateur permettant à l'utilisateur de répartir 20 points entre les caractéristiques Force, Magie et Défense.
- Implémentez le code nécessaire pour gérer cette répartition tout en s'assurant que la somme des points n'excède pas 20.

### 4. Ajout du nom du personnage et insertion en base de données
- Ajoutez un champ dans l'interface utilisateur permettant à l'utilisateur de saisir le nom du personnage.
- Implémentez le code nécessaire pour ajouter un nouveau personnage en base de données avec toutes les données nécessaires à sa création, y compris le nom, les points répartis et les choix d'arme, armure et classe.

### 5. Test de l'application
- Testez l'application en ajoutant un nouveau personnage avec différents choix d'arme, armure et classe, tout en vérifiant que les points sont correctement répartis.
- Assurez-vous que les données sont correctement stockées dans la base de données.

### 6. Documentation
- Mettez à jour la documentation pour inclure les nouvelles fonctionnalités ajoutées, en fournissant des explications sur le code et les choix de conception.

### 7. Personnalisation du Programme avec des Images
- Ajouter une touche personnelle à l'application en intégrant des images.
  - Ajouter des images pour représenter différentes classes, armes ou personnages.
  - Intégrez ces images dans l'interface utilisateur pour rendre l'expérience plus visuelle et attrayante.
