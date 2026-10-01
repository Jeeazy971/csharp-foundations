int severityScore = 7;
bool equipmentStopped = true;
bool technicianAvailable = true;
bool remoteFixAvailable = false;


if (severityScore >= 8)
{
    Console.WriteLine("Critical incident");
}
else if (severityScore >= 5)
{
    Console.WriteLine("High incident");
}
else
{
    Console.WriteLine("Standard incident");
}

bool interventionIsAuthorized = (severityScore >= 5 || equipmentStopped) && technicianAvailable;

if (interventionIsAuthorized)
{
    Console.WriteLine("Intervention authorized");
}
else
{
    Console.WriteLine("Intervention postponed");
}

if (remoteFixAvailable)
{
    Console.WriteLine("Remote intervention");
}
else
{
    Console.WriteLine("On-site intervention");
}

if (equipmentStopped)
{
    Console.WriteLine("Production stopped");
}

/*
 * 
 * 1. Pourquoi la classification Critical / High / Standard
    utilise-t-elle if / else if / else plutôt que trois if indépendants ? 
        plusieurs if indépendants
        → chaque condition est testée indépendamment
        → plusieurs blocs PEUVENT donc être exécutés

        if / else if / else
        → dès qu'un cas correspond, les suivants sont ignorés
        → un seul classement est choisi

    2. Dans la règle d'autorisation, à quoi servent précisément
       les parenthèses autour de :
       severityScore >= 5 || equipmentStopped ?
        Les parenthèses regroupent :
        severityScore >= 5 || equipmentStopped

        pour que ce groupe forme une seule condition booléenne,
        puis son résultat est combiné avec technicianAvailable grâce à &&.
 * 
 * Mini-diagnostics
    Sans exécuter d’abord, indique en commentaire ce que ce code afficherait et pourquoi :
    int batteryLevel = 92;

    if (batteryLevel >= 50)
    {
        Console.WriteLine("Battery OK");
    }
    else if (batteryLevel >= 90)
    {
        Console.WriteLine("Battery excellent");
    }

    il afficherai "Battery OK" car il atteint jamais la seconde condition, d'ou les plus important au moins importante (niveau chiffre dans cet exemple)
 */
