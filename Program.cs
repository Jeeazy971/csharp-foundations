decimal subscriptionPrice = 89.95m;
double serverRoomTemperature = 21.7;
float renderScale = 1.25f;

Console.WriteLine(subscriptionPrice);
Console.WriteLine(serverRoomTemperature);
Console.WriteLine(renderScale);

// decimal invoiceTotal = 49.90;
// float opacity = 0.75;

/*

1. Pourquoi la première ligne pose-t-elle problème ? car elle est compris comme si c'etait un double
   Quelle écriture utiliserais-tu ? decimal invoiceTotal = 49.90m;

2. Pourquoi la deuxième ligne pose-t-elle problème ? Car elle est correpond à une valeur de type double 
   Quelle écriture utiliserais-tu ? float opacity = 0.75f;

3. Pour chacun de tes trois choix principaux,
   explique en quelques mots pourquoi tu as choisi ce type.
   
decimal = adapté aux calculs décimaux, notamment argent / finance
double  = choix général pour mesures, calculs mathématiques/scientifiques
float   = surtout quand une API, un format ou un contexte impose/préfère du 32 bits
   
 */
 