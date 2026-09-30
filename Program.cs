// int importedCount = 125;
// long archivedCount = importedCount;

// Console.WriteLine(importedCount);
// Console.WriteLine(archivedCount);

/*

1. Quel est le type de importedCount ? Il est de type int
2. Quel est le type de archivedCount ? Il est de type long
3. La conversion int → long est-elle implicite ou explicite ? implicite
4. Pourquoi aucun cast n'est nécessaire ici ? Car il a une plus grande plage de valeur par rapport a int donc ça peut fonctionner

*/

// long storedCount = 80L;
// int activeCount = (int)storedCount;

// Console.WriteLine(storedCount);
// Console.WriteLine(activeCount);

/*
5. Quelle conversion est effectuée ? C'est une conversion explicite
6. Pourquoi faut-il écrire (int) ? car on lui dit de convertir la valeur en int même si c'est risqué
7. Est-ce que le fait d'écrire (int) garantit que toute valeur long
   sera toujours représentable correctement en int ? Non. Si la valeur du long dépasse ce qu'un int peut représenter,
il peut y avoir une perte d'information ou un résultat incorrect.
 */
 
// string batchSizeText = "64";

// int batchSize = int.Parse(batchSizeText);

// Console.WriteLine(batchSizeText);
// Console.WriteLine(batchSize);

/*

8. Quelle donnée entre dans int.Parse ? "64"
9. Quel est son type ? string

10. Quelle donnée ressort de int.Parse ? 64
11. Quel est son type ? int

12. Dans quelle variable le résultat est-il stocké ? dans batchSize

13. Après l'appel à Parse, batchSize peut-il être utilisé
    comme une variable int normale ? oui absolument
*/

// int confirmedBatchSize = batchSize;

// Console.WriteLine(confirmedBatchSize);

/*

14. Est-ce que confirmedBatchSize reçoit "64" ou 64 ? 64
15. Pourquoi ? car batchSize est de type int apres conversion donc on copie la valeur de batchSize dans confirmedBatchSize

*/

// string priorityText = "7";

// bool priorityParsed = int.TryParse(priorityText, out int priority);

// Console.WriteLine(priorityParsed);
// Console.WriteLine(priority);

/*

16. Quelle est l'entrée de TryParse ? priorityText

17. Quelles sont les DEUX informations produites ? true et 7

18. Dans quelle variable se trouve le booléen ? priorityParsed

19. Dans quelle variable se trouve la valeur convertie ? priority

20. Quelle valeur prévois-tu pour priorityParsed ? true

21. Quelle valeur prévois-tu pour priority ? 7

*/

// int validatedPriority = priority;

// Console.WriteLine(validatedPriority);

/*

22. Pourquoi peut-on utiliser priority après l'appel à TryParse ? car c'est lui qui a la valeur converti avec out

23. Est-ce que priority est une variable interne cachée dans TryParse ? non 

24. Que signifie ici :
    out int priority = la variable initialisé permet de la reutiliser ailleurs dans le programme et qu'elle n'est pas interne a la méthode Parse
	
*/

// string invalidCode = "ABC";

// bool invalidCodeParsed = int.TryParse(invalidCode, out int numericCode);

// Console.WriteLine(invalidCodeParsed);
// Console.WriteLine(numericCode);

/*

Avant d’exécuter, prédis :
invalidCodeParsed = false
numericCode = 0

Puis réponds :
25. Est-ce que l'échec provoque ici une exception ? Non

26. Peut-on conclure que l'utilisateur avait réellement fourni
    la valeur numérique 0 ? Non, juste c'est vu que la conversion n'est pas possible alors la valeur est de 0

27. Quelle variable faut-il regarder pour savoir si numericCode
    représente réellement une conversion réussie ? invalidCodeParsed
*/


/*

Partie H — Parse ou TryParse ?
Pour chacun des scénarios, choisis Parse ou TryParse et explique pourquoi.
28. Une chaîne interne au programme que tu considères garantie valide. Parse, parce-que je sais que le contenu est sur et valide

29. Une valeur provenant d'une saisie utilisateur. TryParse, car je ne sais ce que j'aurai en entré

30. Une donnée texte provenant d'un fichier dont le contenu
    peut être incorrect. TryParse, car la donnée textuelle ne me garantie pas le contenu sera une valeur numerique

31. Une donnée dont l'échec de conversion est normalement possible
    et doit être traité comme un cas normal. TryParse
	
*/

/*

Partie I — Ton modèle mental final
Complète avec tes mots :
Conversion implicite = C'est d'assigner la valeur a une variable typé ex: 
int number1 = 1;
long numberLong = number1;

Conversion explicite / cast = c'est dire que le type sera converti avec des risque. ex :
long monNum = 148L
int autreNum = (int)monNum;

Parse = méthode qui interprète un texte et retourne directement la valeur convertie.
Si le texte est invalide, une exception peut être déclenchée.
entrée = "7"
sortie = 7
risque = risque d'erreur si ce n'est pas possible

TryParse = méthode qui tente la conversion sans utiliser une exception pour un échec normal.
Elle retourne un booléen et écrit la valeur obtenue dans la variable out.
entrée = la variable avec sont type 
sortie 1 = le resultat booleen si la convesion est reussi ou non
sortie 2 = le valeur converti si reussi ou non

out int value = variable de mon code appelant dans laquelle TryParse écrit le résultat.
Elle reste utilisable après l'appel.

Après un TryParse réussi, la valeur convertie = peut etre reutiliser dans le programme grace à out
Après un TryParse échoué, je dois d'abord regarder = le booléen retourné par TryParse.
*/

int currentItems = 36;

long totalItems = currentItems;

long storedLimit = 72L;

int activeLimit = (int)storedLimit;

string batchSizeText = "128";

int batchSize = int.Parse(batchSizeText);

int confirmedBatchSize = batchSize;

string retryText = "5";

bool retryParsed = int.TryParse(retryText, out int retryCount);

int validatedRetryCount = retryCount;

string invalidTimeoutText = "TIMEOUT";

bool timeoutParsed = int.TryParse(invalidTimeoutText, out int timeout);

Console.WriteLine(currentItems);
Console.WriteLine(totalItems);
Console.WriteLine(storedLimit);
Console.WriteLine(activeLimit);
Console.WriteLine(batchSize);
Console.WriteLine(confirmedBatchSize);
Console.WriteLine(retryParsed);
Console.WriteLine(retryCount);
Console.WriteLine(validatedRetryCount);
Console.WriteLine(timeoutParsed);
Console.WriteLine(timeout);

/*

1. Pourquoi ne faut-il pas considérer timeout = 0 comme une conversion réussie ? TryParse a échoué (timeoutParsed == false) et, pour un int, la variable de sortie vaut alors 0. Ce 0 ne prouve donc pas que l’entrée représentait réellement le nombre zéro.

2. Quelle variable permet de savoir si timeout est réellement exploitable ? timeoutParsed

*/
