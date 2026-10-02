int processedCount = 0;
int totalScore = 0;

for (int checkpoint = 1; checkpoint <= 6; checkpoint++)
{
    Console.WriteLine($"Checkpoint {checkpoint}");

    processedCount++;

    totalScore += checkpoint * 2;

    if (checkpoint == 4)
    {
        Console.WriteLine("Critical deviation");
        break;
    }
}

Console.WriteLine($"Processed: {processedCount}");
Console.WriteLine($"Total score: {totalScore}");


/*
1.Pourquoi utilise - t - on checkpoint <= 6
   et non checkpoint < 6 ? car si on ne met pas <= ce sera false car on veut savoir si 6 <= 6 et non 6 strcitement < a 6

2. Quelle différence y a-t-il entre checkpoint
   et processedCount ? checkpoint controle la boucle, proccessedCount incremente le nombre de fois que le processus tourne

3. Pourquoi totalScore est-il appelé un accumulateur ? Car il accumule comme le nom dit la valeur ajouté

4. Quand checkpoint vaut 4, que fait précisément break ? il s'arrete et sort de la boucle
   Est-ce que le programme entier s'arrête ? Non juste la boucle concerné
*/

/*
 * Mini-diagnostic — avant exécution
Ajoute également ceci en commentaire :
for (int number = 2; number <= 8; number += 2)
{
    Console.WriteLine(number);
}

Sans l’exécuter d’abord, réponds :
1.Quelles valeurs seront affichées ? 2 4 6 8

2. Combien d'itérations seront exécutées ? 4

3. Quelle est :
   -l'initialisation ? int number = 2
   - la condition ? number <= 8
   -l'évolution ? number += 2

4.Après avoir affiché la dernière valeur,
   quelle sera la valeur suivante de number
   avant que la condition devienne false ? 10 <= 8 = false donc elle n'est pas affiché
*/
