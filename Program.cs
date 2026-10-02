string eventStream = "SSWESS";

int processedCount = 0;
int successCount = 0;
bool errorFound = false;

foreach (char evnt in eventStream)
{
    Console.WriteLine($"Event: {evnt}");

    processedCount++;

    if (evnt == 'S')
    {
        successCount++;
    }

    if(evnt == 'E')
    {
        errorFound = true;
        Console.WriteLine("Critical error detected");
        break;
    }
}

Console.WriteLine($"Processed: {processedCount}");
Console.WriteLine($"Successes: {successCount}");
Console.WriteLine($"Error found: {errorFound}");


/*
1.Dans :
   foreach (char currentEvent in eventStream)

    quelle différence y a-t - il entre
   currentEvent et eventStream ? currentEvent est la variable interne a la boucle initialisé qui contient chaque caractère. et eventStream la variable externe qui contient le mot en question.

2. Pourquoi n'écrit-on pas currentEvent++ pour passer à l'élément suivant ?

    Parce que dans un foreach, c'est C# qui gère automatiquement le passage à l'élément suivant.
    La variable currentEvent représente seulement l'élément courant, elle ne sert pas à contrôler la progression de la boucle.

3. processedCount est-il nécessaire au fonctionnement
   du foreach lui-même ? À quoi sert-il réellement ici ? 
    Non absolument pas, il mesure sle nombre total d’événements réellement traités avant l’arrêt.

4. Quand break est exécuté sur 'E',
    que deviennent les caractères restants ? elle ne sont pas lue tout simplement, si on voulait les lires également on enlève le break ajouté
*/

/*
 Mini-diagnostic — avant exécution
Ajoute ce code dans un commentaire :
string flags = "ABCA";

foreach (char flag in flags)
{
    if (flag == 'C')
    {
        break;
    }

    Console.WriteLine(flag);
}

Sans l’exécuter d’abord, réponds :
1. Quelles valeurs seront affichées ? A et B

2. Est-ce que C sera affiché ? Non

3. Pourquoi ? Car le break quitte la boucle avant de l'afficher

4. Est-ce que le dernier A sera traité ? Non
*/
