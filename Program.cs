int remainingPackets = 5;
int processedCount = 0;
bool gatewayOnline = true;


while (remainingPackets >= 1 && gatewayOnline)
{
    Console.WriteLine($"Processing packet {processedCount + 1}");

    processedCount++;

    remainingPackets--;

    if (processedCount == 3)
    {
        gatewayOnline = false;
        Console.WriteLine("Gateway offline");
    }
}

Console.WriteLine($"Processed: {processedCount}");
Console.WriteLine($"Remaining: {remainingPackets}");
Console.WriteLine($"Gateway online: {gatewayOnline}");


/*1.Pourquoi while est - il plus naturel ici qu'un for ? Car avec la condition de while c'est plus evident de verifier tant que quelque est vrai

2. Quelles sont les deux conditions qui doivent être vraies
   pour entrer dans une nouvelle itération ?
    remainingPackets >= 1
    ET
    gatewayOnline == true

3. Quand gatewayOnline devient false,
   est-ce que le programme quitte immédiatement le bloc en cours ? Non
   Que se passe-t-il exactement ? Il fini sont traitement puis il reverifie la condition si elle est toujours, vrai et vu que ce n'est plus le cas il ne rentre plus dazns la boucle

4. Quelle différence y a-t-il entre :
   processedCount
   et
   remainingPackets ? processedCount compte le nombre d'iteration et remainingPackets decremente le nombre packets due a la condition while pour verifier s'il est encore vrai

5. Qu'est-ce qui garantit ici que la boucle ne tourne pas indéfiniment ? 
    remainingPackets passe sous 1
    OU
    gatewayOnline devient false
*/

/*
Mini - diagnostic 1 — zéro itération
Ajoute ceci en commentaire :
int remainingFiles = 0;

while (remainingFiles > 0)
{
    Console.WriteLine("Processing file");
    remainingFiles--;
}

Console.WriteLine("Finished");

Sans exécuter, réponds :
1.Combien de fois "Processing file" sera affiché ? 0

2. Est-ce que "Finished" sera affiché ? oui

3. Pourquoi ? Il ne rentre pas dans la boucle donc il passe a la seconde instruction

 */


/*
Mini - diagnostic 2 — repérer une boucle infinie
Toujours en commentaire :
int retries = 1;

while (retries <= 3)
{
    Console.WriteLine(retries);
}

Réponds:
1.Quel est le problème ? retries n'incremente jamais donc la valeur ne change pas pour la condition booleene

2. Pourquoi la condition reste-t-elle vraie ? Parce que la valeur de retries ne change pas

3. Quelle partie manque pour permettre à la boucle
   d'atteindre naturellement sa fin ? retries++
*/
