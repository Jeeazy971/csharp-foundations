var parcelCount = 12;
var trackingCode = "PKG-120";
var isExpress = true;
var zone = 'B';
var totalDistance = 450L;

Console.WriteLine(parcelCount);
Console.WriteLine(trackingCode);
Console.WriteLine(isExpress);
Console.WriteLine(zone);
Console.WriteLine(totalDistance);

/*
    Partie A — Inférence de type

    parcelCount = int
    trackingCode = string
    isExpress = bool
    zone = char
    totalDistance = long

    Pourquoi totalDistance n'est-il pas un int ?

    Parce que le suffixe L indique au compilateur que 450L est un littéral de type long.
    Avec var, le compilateur déduit donc que totalDistance est de type long.

    Est-ce que l'utilisation de var rend ces variables dynamiques ?

    Non.

    Pourquoi ?

    Parce que var demande au compilateur de déduire le type à partir de la valeur
    d'initialisation. Une fois le type déduit à la compilation, il reste fixé pendant
    toute la durée de vie de la variable.
*/

parcelCount = 20;
trackingCode = "PKG-121";
isExpress = false;
zone = 'C';
totalDistance = 700L;

Console.WriteLine(parcelCount);
Console.WriteLine(trackingCode);
Console.WriteLine(isExpress);
Console.WriteLine(zone);
Console.WriteLine(totalDistance);

/*
    Partie B — Réaffectation

    Ces réaffectations doivent-elles compiler ?

    Oui.

    Pourquoi ?

    Parce que chaque variable conserve le type précis déduit lors de son initialisation :

    parcelCount = int
    trackingCode = string
    isExpress = bool
    zone = char
    totalDistance = long

    Les nouvelles valeurs sont compatibles avec ces types.
*/

// Expérience volontaire : cette ligne ne compile pas.
// parcelCount = "20";

// Erreur observée :
// error CS0029: Impossible de convertir implicitement le type 'string' en 'int'

/*
    Partie C — Erreur volontaire

    1. Est-ce une erreur de compilation ou une erreur runtime ?

    C'est une erreur de compilation.

    2. Pourquoi le compilateur refuse-t-il "20" alors que parcelCount
       a été déclaré avec var ?

    Parce que parcelCount a été inféré comme un int dès sa déclaration.
    Lui affecter "20" demanderait une conversion de string vers int,
    et cette conversion n'est pas implicite.

    3. Quel est réellement le type de parcelCount ?

    parcelCount est de type int.
*/

/*
    Partie D — var ou type explicite ?

    Comparaison :

        var retryCount = 3;

    et :

        int retryCount = 3;

    1. Est-ce que le type final de retryCount est différent ?

    Non. Dans les deux cas, retryCount est de type int.

    2. Est-ce que var apporte ici un gain de performance ?

    Non. var ne change pas le type réel de la variable et n'apporte pas
    de gain de performance particulier dans ce cas.

    3. Pourquoi pourrait-on préférer var ?

    Pour éviter de répéter un type déjà évident et garder un code lisible.

    4. Pourquoi pourrait-on malgré tout préférer int ?

    Parce que le type est immédiatement visible dans le code, ce qui peut être
    plus explicite selon le contexte ou les conventions de l'équipe.
*/

/*
    Partie E — Fais ton propre diagnostic

    Sans exécuter de code, types inférés :

        var warehouseId = 87;          // int
        var warehouseCode = "WH-87";  // string
        var available = false;         // bool
        var sector = 'D';              // char
        var capacity = 2500L;          // long

    Inférence de type =

    Le compilateur déduit le type d'une variable à partir de sa valeur
    d'initialisation. Ce type est ensuite fixé à la compilation.

    Rappels :

        var ≠ type dynamique
        var ≠ object
        var ≠ absence de type
*/
