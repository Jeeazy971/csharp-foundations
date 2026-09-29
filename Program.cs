int pendingRequests = 14;
int copiedRequests = pendingRequests;

copiedRequests = 21;

Console.WriteLine(pendingRequests);
Console.WriteLine(copiedRequests);

string primaryCode = "SUP-14";
string secondaryCode = primaryCode;

Console.WriteLine(primaryCode);
Console.WriteLine(secondaryCode);

secondaryCode = "SUP-21";

Console.WriteLine(primaryCode);
Console.WriteLine(secondaryCode);

/*
    Partie B — Mémoire et sémantique

    1. Qu’est-ce qui est copié ?

    La valeur contenue dans pendingRequests est copiée dans copiedRequests,
    car int est un type valeur.

    2. Pourquoi serait-il incorrect de conclure simplement :

       int = stack

    Parce que "type valeur" décrit la sémantique du type et non un emplacement
    mémoire obligatoire.

    Une valeur de type int peut notamment être stockée directement dans un objet
    situé dans le managed heap. Son emplacement dépend donc du contexte et des
    choix du runtime/JIT.


    Pour :

        string primaryCode = "SUP-14";
        string secondaryCode = primaryCode;

    3. Qu’est-ce qui est copié ?

    La référence contenue dans primaryCode est copiée dans secondaryCode.
    L’objet "SUP-14" n’est pas cloné.

    4. Combien de variables avons-nous juste après l’affectation ?

    Deux variables :
    - primaryCode
    - secondaryCode

    5. Combien d’objets "SUP-14" sont nécessaires pour expliquer le comportement ?

    Un seul objet suffit conceptuellement :

        primaryCode ────┐
                        ▼
                     "SUP-14"
                        ▲
        secondaryCode ──┘

    6. Pourquoi "string = heap" est-il trop imprécis ?

    Parce qu’il faut distinguer la variable, la référence qu’elle contient
    et l’objet référencé.

        variable
           │
           │ contient
           ▼
        référence
           │
           │ permet d’accéder à
           ▼
        objet

    Ici :
    - primaryCode est une variable ;
    - elle contient une référence ;
    - cette référence permet d’accéder à l’objet string "SUP-14".

    Dire simplement "string = heap" mélange donc la sémantique du type
    avec son stockage mémoire.
*/

/*
    Partie C — Schéma mémoire conceptuel

    Juste après :

        string secondaryCode = primaryCode;

    CONTEXTE D'EXÉCUTION                 MANAGED HEAP

    primaryCode
         │
         └──────────────────────────────► "SUP-14"
                                            ▲
                                            │
    secondaryCode ──────────────────────────┘


    Après :

        secondaryCode = "SUP-21";

    CONTEXTE D'EXÉCUTION                 MANAGED HEAP

    primaryCode ─────────────────────────► "SUP-14"

    secondaryCode ───────────────────────► "SUP-21"


    Il s’agit d’une réaffectation de secondaryCode :
    la variable reçoit une nouvelle référence.

    L’objet "SUP-14" n’a pas été modifié.
*/

/*
    Partie D — Garbage Collector

    Premier scénario :

        GC ROOT
           │
           ▼
        Objet A
           │
           ▼
        Objet B


        Objet X

    7. Quels objets sont accessibles depuis la root ?

    Objet A et Objet B.

    8. Quel objet est potentiellement éligible à la collecte ?

    Objet X, car aucune chaîne de références partant d’une GC Root
    ne permet de l’atteindre.

    9. Est-il forcément collecté immédiatement ?

    Non.

    Lorsqu’un objet devient inaccessible, il devient éligible à la collecte,
    mais le Garbage Collector ne s’exécute pas après chaque objet devenu
    inaccessible.

    Le runtime choisit quand effectuer une collecte.


    Deuxième scénario :

        GC ROOT
           │
           ▼
        Objet A
           │
           ▼
        Objet B
           │
           ▼
        Objet X

    10. Objet X est-il toujours éligible à la collecte ?

    Non.

    Objet X est maintenant accessible indirectement depuis la GC Root :

        GC ROOT → Objet A → Objet B → Objet X

    Tant que cette chaîne existe, le GC doit considérer Objet X comme vivant.
*/

/*
    Partie E — Cas subtil

        GC ROOT
           │
           ▼
        Objet A


        Objet X ─────► Objet Y
           ▲             │
           └─────────────┘

    11. Le GC peut-il considérer X et Y comme inaccessibles ?

    Oui.

    12. Pourquoi le fait qu’ils se référencent entre eux ne suffit-il pas
        à les maintenir vivants ?

    Parce que le GC ne vérifie pas simplement si un objet possède une référence.

    Il vérifie si l’objet peut être atteint directement ou indirectement
    depuis une GC Root.

    Ici, aucune chaîne de références ne relie une GC Root à X ou Y.
    Les deux objets sont donc inaccessibles et peuvent devenir éligibles
    à la collecte.
*/

/*
    Partie F — Définitions

    Stack =
    pile d’exécution utilisée notamment pour suivre les appels en cours
    et leurs contextes d’exécution. Elle ne définit pas ce qu’est un type valeur.

    Managed Heap =
    zone de mémoire gérée par .NET dans laquelle sont notamment stockés
    les objets managés.

    Garbage Collector =
    mécanisme du runtime .NET qui identifie les objets managés encore accessibles
    et peut récupérer la mémoire de ceux devenus inaccessibles.

    Objet accessible =
    objet qui peut être atteint directement ou indirectement depuis une GC Root.

    Objet éligible à la collecte =
    objet qui n’est plus accessible depuis aucune GC Root et dont la mémoire
    pourra être récupérée lors d’une future collecte.


    Rappel principal :

        type valeur / type référence
                    ≠
              stack / heap

    "Valeur / référence" décrit principalement la sémantique des types.

    "Stack / heap" concerne la manière dont les données sont stockées
    et utilisées pendant l’exécution.
*/
