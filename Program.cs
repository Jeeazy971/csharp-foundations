int originalCount = 18;
int copiedCount = originalCount;

/*
    1. Copie de valeur

    Ce qui a été copié de originalCount vers copiedCount est la valeur 18,
    car int est un type valeur.

    Modifier ensuite copiedCount ne modifie pas originalCount,
    car les deux variables possèdent désormais leur propre valeur.
*/

copiedCount = 27;

Console.WriteLine(originalCount);
Console.WriteLine(copiedCount);


string originalCode = "MED-41";
string copiedCode = originalCode;

/*
    2. Copie de référence

    Ce qui est copié de originalCode vers copiedCode est la référence,
    et non une copie de l'objet.

    Juste après :

        string copiedCode = originalCode;

    les deux variables peuvent donc référencer le même objet :

        originalCode ──┐
                       ▼
                    "MED-41"
                       ▲
        copiedCode ────┘
*/

Console.WriteLine(originalCode);
Console.WriteLine(copiedCode);


copiedCode = "MED-99";

/*
    3. Réaffectation

    copiedCode = "MED-99";

    est une réaffectation de copiedCode.

    L'objet "MED-41" n'a pas été muté.

    Après cette ligne :

        originalCode ───> "MED-41"

        copiedCode   ───> "MED-99"

    Les deux variables référencent donc maintenant des objets différents.
*/

Console.WriteLine(originalCode);
Console.WriteLine(copiedCode);


/*
    4. Mutation d'un objet partagé

    Situation initiale :

        variableA ───┐
                     ▼
                OBJET PARTAGÉ
                état = "Actif"
                     ▲
        variableB ───┘

    - Il y a 2 variables.
    - Il y a 1 objet partagé.

    Si une opération effectuée via variableB modifie l'état de l'objet
    de "Actif" vers "Suspendu", c'est l'OBJET qui est muté.

    variableB n'est pas réaffectée.
    variableA et variableB référencent toujours le même objet.

    variableA voit donc également l'état "Suspendu", car elle permet
    d'accéder au même objet qui a été modifié.


    5. Définitions

    Copie de valeur =
    copier la valeur contenue dans une variable vers une autre variable.
    Les deux variables possèdent ensuite des valeurs indépendantes.

    Copie de référence =
    copier la référence vers un objet dans une autre variable.
    Les deux variables peuvent alors référencer le même objet.

    Réaffectation =
    donner à une variable une nouvelle valeur ou une nouvelle référence.

    Mutation =
    modifier l'état d'un objet existant sans remplacer cet objet
    par un autre dans la variable.
*/
