

Console.WriteLine("Audit started");
DisplaySeparator();
RunEquipmentCheck();
DisplaySeparator();
Console.WriteLine("Audit completed");

static void DisplaySeparator()
{
    Console.WriteLine("----------");
}

static void RunEquipmentCheck()
{
    for (int check = 1; check <= 3; check++)
    {
        if (check == 1)
        {
            Console.WriteLine($"Check {check}: OK");
        }
        else if (check == 2)
        {
            Console.WriteLine($"Check {check}: Warning");
        }
        else
        {
            Console.WriteLine($"Check {check}: OK");
        }
    }
}

/*
1.Quelle différence y a - t - il entre :

   DisplaySeparator

   et

   DisplaySeparator() ?

    La première et désigne la methode et son nom et la seconde avec les parentheses elle appelle la méthode et execute son corps.

2. Pourquoi le code contenu dans RunEquipmentCheck
   ne s'exécute-t-il pas simplement parce que la méthode existe ? Car il faut l'appeler avec les parentheses, chose que l'on ne fait pas.

3. Que signifie void ici ? que la methode ne retourne aucune valeur, mais elle peut afficher par exemple quelque chose

4. Pourquoi DisplaySeparator est-elle intéressante à réutiliser
   plutôt que d'écrire deux fois Console.WriteLine("----------") ? Car elle est reutilisable et on evite le DRY (Don't repeat Yourself) même si je ne le connait pas par coeur.

5. Dans RunEquipmentCheck, quel est le rôle de la méthode
   par rapport au for et au if qu'elle contient ? 
    RunEquipmentCheck()
    → regroupe et donne un nom au traitement complet

    for
    → répète les 3 contrôles

    if / else
    → décide quel résultat afficher pour chaque contrôle

*/


/*
 * 
Console.WriteLine("A");

Second();

Console.WriteLine("D");

static void Second()
{
    Console.WriteLine("B");
    Third();
}

static void Third()
{
    Console.WriteLine("C");
}
*/


/*
1.Quel sera l'ordre exact d'affichage ? A, B, C, D

2. Quand Third() se termine,
   où reprend l'exécution ? 
    Quand Third() se termine, l'exécution revient dans Second() juste après l'appel Third();
    Comme il n'y a plus rien ensuite dans Second(), Second() se termine à son tour.

3. Quand Second() se termine,
   où reprend l'exécution ? Quand Second() se termine, l'exécution reprend dans le programme principal,
    juste après l'appel Second(), donc sur Console.WriteLine("D").
*/
