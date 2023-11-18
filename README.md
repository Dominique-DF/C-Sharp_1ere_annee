# C-Sharp_1re_annee

Correction des exercices de première année en C#

## Exercice 01
Écrire un programme qui demande l’année de naissance de l’utilisateur, l’année actuelle et qui affiche si la personne a atteint la majorité (dans l’année).
Modifier le programme pour qu’il affiche (dans le cas où la personne est mineure) en quelle année elle atteindra la majorité.

## Exercice 02
On demande à l’utilisateur de saisir une note comprise entre 0 et 20. Vérifier que la note saisie est valide, le cas échéant effectuer à nouveau la saisie de la note.

## Exercice 03
Une année est dite bissextile si elle est divisible par 4, les années multiples de 100 ne le sont pas sauf si elles sont multiples de 400.
Écrire un programme qui indique si une année saisie par l’utilisateur est bissextile ou non.

## Exerice 04
Écrire un programme qui à partir d’une heure de départ (l’utilisateur saisit indépendamment les heures et minutes) et d’une durée (en heures et minutes également) affiche l’heure d’arrivée.
Dans un premier temps validez votre programme avec des cas simples puis vérifiez également qu’il peut fonctionner pour des arrivées le lendemain (on limite le temps de trajet à 24 heures).

## Exercice 05
Reprendre la demande précédente mais cette fois on saisit l’heure de départ et celle d’arrivée et on calcule le temps de trajet.

## Exercice 06
Écrire un programme qui affiche la table de multiplication d’un chiffre saisi par l’utilisateur.

## Exercice 07
Écrire un programme qui calcule la somme des nombres entiers compris entre deux nombres saisis par l’utilisateur.

## Exercice 08
Écrire un programme qui calcule le produit des nombres entiers compris entre deux nombres saisis par l’utilisateur.

## Exercice 09
Écrire un programme qui fait saisir successivement dix nombres à l’utilisateur. A l’issue de la saisie, le programme affiche le nombre le plus grand.

## Exercice 10
Reprendre l’exercice précédent mais cette fois on ne fixe pas de limite de saisie, l’utilisateur saisira « FIN » pour stopper la saisie.

## Exercice 11
Écrire un programme qui demande à l’utilisateur un prix (valeur avec deux décimales, par exemple 12,25 euros), un montant donné (par exemple 15 euros) et qui affiche le rendu de monnaie (en optimisant le nombre de pièces ou billets rendus). Dans notre exemple cela donnerait 1 pièce de 2 euros, 1 pièce de 50 cents, 1 pièce de 20 cents et 1 pièce de 5 cents.

## Exercice 12
Écrire un programme qui détermine aléatoirement un nombre entier entre 1 et 100. L’utilisateur a ensuite plusieurs tentatives pour trouver le nombre (le programme affichera si la proposition est plus ou moins grande que le nombre).
Le programme affichera ensuite le nombre d’essais pour trouver le nombre.
Enfin on limitera le nombre d’essais à 10.

## Exercice 13
Écrire un programme qui valide un numéro de carte bancaire saisi par l’utilisateur.
Prenons un exemple :
Un numéro de carte est composé de 16 chiffres : 1234 1234 1234 1234
Notons les ABAB ABAB ABAB ABAB.
Les chiffres en « position » A sont doublés, si le nombre obtenu dépasse 9 on le remplace par la somme des chiffres le composant (par exemple 13 devient 4).
On fait la somme de ces dernières valeurs et des chiffres en « position » B.
Si la somme est un multiple de 10, le numéro est valide.
