Console.WriteLine("Monitoring started");
CheckWorker("Worker-A", 3, 5);
CheckWorker("Worker-B", 7, 5);
CheckWorker("Worker-C", 4, 4);
Console.WriteLine("Monitoring completed");

static void CheckWorker(string workerName, int queuedJobs, int warningThreshold)
{
    string alertLevel;
    if (queuedJobs >= warningThreshold)
    {
        alertLevel = "Warning";
    }
    else
    {
        alertLevel = "Normal";

    }

    Console.WriteLine($"{workerName}: {alertLevel} - {queuedJobs} queued jobs");
}


/*1.Dans :

   static void CheckWorker(
       string workerName,
       int queuedJobs,
       int warningThreshold)

   quels sont les paramètres ? Les parametres sont workerName, queuedJobs et warningThreshold

2. Dans un appel utilisant :
   Worker - A, 3 et 5

   quels sont les arguments ? Les arguments sont : Worker - A, 3 et 5 

3. Pourquoi CheckWorker peut-elle être utilisée
   pour Worker-A, Worker-B et Worker-C sans modifier son code ? CheckWorker() contient une logique commune, 
    tandis que les trois paramètres lui permettent de recevoir des données différentes à chaque appel.

4. Quel paramètre contrôle la décision du if
   en combinaison avec queuedJobs ? warningThreshold

5. Pourquoi serait-il moins intéressant d'écrire :

   static void CheckWorkerA()
   static void CheckWorkerB()
   static void CheckWorkerC()

   dans ce cas ?
    Car on fait de la repetition pour la même chose, donc on evite le DRY,
    alors une methode avec la reutilisation de la même sythaxe et en rajoutant des paramètre est plus interessant
    
 */


/*

Mini - diagnostic — copie d’un int
Ajoute ceci en commentaire seulement :
int originalCount = 2;

IncreaseCount(originalCount);

Console.WriteLine(originalCount);

static void IncreaseCount(int count)
{
    count++;
    Console.WriteLine(count);
}

Sans l’exécuter, réponds :
1.Quelle valeur est affichée dans IncreaseCount ? 3

2. Quelle valeur est ensuite affichée par
   Console.WriteLine(originalCount) ? 2

3. Pourquoi la modification de count
   ne modifie-t-elle pas originalCount ? 
   Car la modification originalCount reste à 2 parce que sa valeur est copiée dans le paramètre count. 
    Modifier count modifie cette copie, pas la variable originalCount.
*/
