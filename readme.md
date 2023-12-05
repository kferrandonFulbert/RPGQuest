# TP D�veloppement d'une application RPGQuest en C# avec acc�s � la base de donn�es MariaDB

## Objectif du TP
Cr�er une application en C# pour RPGQuest qui interagit avec une base de donn�es MariaDB. L'application devra permettre de r�cup�rer et manipuler des donn�es du jeu.

## Pr�requis
1. Connaissances de base en C#.
2. Un environnement de d�veloppement C# install� (par exemple, Visual Studio).
3. Un serveur de base de donn�es MariaDB ou MySql op�rationnel.
4. Le script SQL de la base de donn�es "TP8 - RPGQuest.sql".

## �tapes

### 1. Mise en place du projet C#
- Clonez le d�p�t GitHub du projet RPGQuest : [https://github.com/kferrandonFulbert/RPGQuest](https://github.com/kferrandonFulbert/RPGQuest).
- Prenez en consid�ration le code existant qui se connecte � la base de donn�es et alimente la ComboBox "Arme". Les �tudiants sont encourag�s � s'inspirer de cette impl�mentation pour alimenter les ComboBox "Armure" et "Classe".

### 2. Alimentation des ComboBox "Armure" et "Classe"
- Inspirez-vous du code existant pour la ComboBox "Arme" et adaptez-le pour les ComboBox "Armure" et "Classe".
- Assurez-vous que les ComboBox sont correctement aliment�es � partir de la base de donn�es.

### 3. Dispatcher les 20 points dans la Force, la Magie et la D�fense
- Ajoutez une interface utilisateur permettant � l'utilisateur de r�partir 20 points entre les caract�ristiques Force, Magie et D�fense.
- Impl�mentez le code n�cessaire pour g�rer cette r�partition tout en s'assurant que la somme des points n'exc�de pas 20.

### 4. Ajout du nom du personnage et insertion en base de donn�es
- Ajoutez un champ dans l'interface utilisateur permettant � l'utilisateur de saisir le nom du personnage.
- Impl�mentez le code n�cessaire pour ajouter un nouveau personnage en base de donn�es avec toutes les donn�es n�cessaires � sa cr�ation, y compris le nom, les points r�partis et les choix d'arme, armure et classe.

### 5. Test de l'application
- Testez l'application en ajoutant un nouveau personnage avec diff�rents choix d'arme, armure et classe, tout en v�rifiant que les points sont correctement r�partis.
- Assurez-vous que les donn�es sont correctement stock�es dans la base de donn�es.

### 6. Documentation
- Mettez � jour la documentation pour inclure les nouvelles fonctionnalit�s ajout�es, en fournissant des explications sur le code et les choix de conception.

### 7. Personnalisation du Programme avec des Images
- Ajouter une touche personnelle � l'application en int�grant des images.
  - Ajouter des images pour repr�senter diff�rentes classes, armes ou personnages.
  - Int�grez ces images dans l'interface utilisateur pour rendre l'exp�rience plus visuelle et attrayante.
