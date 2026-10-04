Console.WriteLine("Queue monitoring started");
string importStatus = GetQueueStatus(4, 10);
Console.WriteLine($"ImportQueue: {importStatus}");
string emailStatus = GetQueueStatus(12, 10);
Console.WriteLine($"EmailQueue: {emailStatus}");
string reportStatus = GetQueueStatus(10, 10);
Console.WriteLine($"ReportQueue: {reportStatus}");
Console.WriteLine("Queue monitoring completed");


static string GetQueueStatus(int queuedItems, int maximumItems)
{
    string result;
    if (queuedItems < maximumItems)
    {
        result = "Available";
    }
    else
    {
        result = "Full";
    }

    return result;
}


/*
1.Dans :

   static string GetQueueStatus(int queuedItems, int maximumItems)

   que signifie string placé avant GetQueueStatus ? que la valeur de retour doit être une chaine de caractère

2. Quelle différence y a-t-il entre :

   return "Full";

et

   Console.WriteLine("Full");

Le premier est que la methode retourne un une chaine de caractère pour la reutiliser,
le second c'est la methode qui affiche le resultat 

3.Si tu écris :

   string status = GetQueueStatus(12, 10);
   Que contient status après l'appel ? Il contient le resultat "Full"

4. La variable locale utilisée éventuellement à l'intérieur
   de GetQueueStatus est-elle la même variable que status
   dans le programme principal ? Pourquoi ?
    Non, celle a l'interieur retourne le resutlat de la methode, celle a l'exterieur recupère le resultat de la methode

5. Pourquoi est-il intéressant que GetQueueStatus
   retourne une string au lieu d'afficher directement le statut ?
    Parce que le résultat retourné peut être récupéré puis réutilisé ailleurs par l’appelant : affichage, comparaison, stockage, autre traitement, etc.
*/


/*
Mini - diagnostic — return termine la méthode
Ajoute ceci en commentaire uniquement :
static string GetResult(int value)
{
    if (value >= 5)
    {
        return "High";
    }

    return "Low";
}

Sans l’exécuter, réponds :
1.GetResult(8) retourne quoi ? "High"

2. Après return "High", est-ce que
   return "Low" est exécuté pour cet appel ? Non car il sors de la methode avec return

3. GetResult(2) retourne quoi ? "Low"

4. Pourquoi tous les chemins possibles
   retournent-ils bien une string ? Tous les chemins possibles de la méthode aboutissent à un return qui retourne une string.
*/
