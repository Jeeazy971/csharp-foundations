var eventId = 120;
object eventData = 120;
dynamic externalData = 120;

Console.WriteLine(eventId);
Console.WriteLine(eventData);
Console.WriteLine(externalData);

/*

1. Quel est le type réel de eventId après l'inférence ? il est de type int

2. Quel est le type déclaré de eventData ? c'est de type object

3. Quel mécanisme se produit avec :
   object eventData = 120;
   sachant que int est un type valeur ? la variable prend le type object et le type int de la valeur est boxé

4. Quelle est la particularité de externalData par rapport
   aux vérifications du compilateur ? c'est que certianes verification a la compilation sont reporté et qu'il sont verifié durant le runtime 

*/

eventData = "EVT-120";
externalData = "EXT-120";

Console.WriteLine(eventData);
Console.WriteLine(externalData);

eventData = true;
externalData = true;

Console.WriteLine(eventData);
Console.WriteLine(externalData);

/*

5. Est-ce que eventData a changé de type déclaré ? non mais la valeur de type oui
6. Est-ce que externalData peut recevoir ces différentes valeurs ?
	Oui. Une variable dynamic peut recevoir des valeurs de différents types.
	Sa particularité est surtout que certaines vérifications liées aux opérations
	sont reportées au runtime.
7. Pourquoi var eventId ne fonctionne-t-il pas de la même manière ? Car l'inférence du type se fait à la compilation

*/


/*

Partie C — Boxing
Observe :

*/

// object firstPayload = 25;
// object secondPayload = "EVT-25";


/*
Réponds sans modifier le code :
8. Sur quelle ligne y a-t-il du boxing ? firstPayload
9. Pourquoi ? car le type est une valeur int 
10. Pourquoi l'autre ligne ne nécessite-t-elle pas de boxing ?
	Parce que string est un type référence. La référence vers l'objet string
	peut être affectée à une variable object sans boxing.
*/

/*

Partie D — Comparaison mentale
Pour chacune des lignes suivantes, indique ce que tu dois penser immédiatement :
*/

// var first = 50;
// object second = 50;
// dynamic third = 50;

/*
Complète :
first :
type déclaré/réel = int
boxing = non
vérification principale = compilation

second :
type déclaré = object
contenu initial = int
boxing = oui
vérification principale = compilation

third :
particularité = certaines verifications reporté au runtime
certaines vérifications = runtime

*/

/*

Partie E — Cas professionnel
Une donnée métier représente toujours un nombre de places disponibles.
Tu as trois possibilités :
*/

// int availableSeats = 40;
// object availableSeats = 40;
// dynamic availableSeats = 40;

/*
Réponds :
11. Laquelle choisirais-tu normalement dans du code métier ? je choisirai int
12. Pourquoi object serait-il trop général ? car je pourrait perdre la precision de ce qui est contenue
13. Pourquoi dynamic serait-il risqué sans besoin réel ? Car le garde de fou de la compilation est perdue et le risque d'erreur durant le runtime se verrai tardivement
*/

/*

Partie F — Ton résumé
Complète avec tes propres mots :
var =
le compilateur déduit le type à partir de la valeur d'initialisation.
Ce type est ensuite fixé.

object =
la variable est déclarée de type object et peut recevoir des valeurs
de différents types. Un type valeur comme int est boxé lorsqu'il est
stocké dans object, alors qu'un type référence comme string ne l'est pas.

dynamic =
la variable est déclarée dynamic. Elle peut recevoir des valeurs de
différents types et certaines vérifications liées aux opérations sont
reportées au runtime, ce qui peut faire apparaître certaines erreurs
plus tardivement.

Je préfère un type précis quand =
je connais le type attendu par mon domaine.

J'utilise dynamic seulement quand =
le besoin est réellement dynamique et le justifie.

object avec un int = boxing
object avec un string = non boxing

*/
