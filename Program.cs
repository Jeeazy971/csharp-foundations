string rawDeliveryMode = "  pickup ";
int packageCount = 3;

string cleanDeliveryMode = rawDeliveryMode.ToUpper().Trim();

string? deliveryMessage = null;

switch (cleanDeliveryMode)
{
	case "HOME":
		deliveryMessage = "Home delivery";
		break;

	case "PICKUP":
		deliveryMessage = "Store pickup";
		break;

	case "LOCKER":
		deliveryMessage = "Locker delivery";
		break;

    default:
		deliveryMessage = "Unknown delivery mode";
        break;
}

string? packageType = null;

switch (packageCount)
{
    case 1:
        packageType = "Single package";
        break;

    case 2:
    case 3:
        packageType = "Small shipment";
        break;

    default:
        packageType = "Large shipment";
        break;
}

Console.WriteLine(deliveryMessage);
Console.WriteLine(packageType);

/*
 * 
 * 
 * 
 * Question 1
    Pourquoi le premier problème est-il un bon candidat pour switch plutôt qu’une longue chaîne de if / else if ?
    Oui c'est mieux pour notre premier problème car ça une meilleure lisibilité, de plus on recherche le match exact donc il repond bien à notre besoin.
    Question 2
    Dans :
    case 2:
    case 3:
        ...
        break;

    pourquoi n’avons-nous besoin d’écrire le traitement qu’une seule fois ?
    2 et 3 sont deux valeurs exactes distinctes qui conduisent au même bloc de traitement.
    Question 3
    Quel est le rôle de default ?
    Son rôle est prendre le relais si aucun cas ne correspond au précédentes valeurs verifié.
 *
 *  Mini-diagnostic — à répondre avant d’exécuter
    Ajoute également ta réponse en commentaire :
    string accessLevel = "ADMIN";

    switch (accessLevel)
    {
        case "USER":
            Console.WriteLine("Standard access");
            break;

        case "ADMIN":
            Console.WriteLine("Administrator access");
            break;

        default:
            Console.WriteLine("Unknown access");
            break;
    }

    Qu'est-ce qui sera affiché ? "Administrator access"
    Quels case sont comparés ? case "USER": et case "ADMIN"
    Est-ce que default sera exécuté ? Non, car le second cas ADMIN correspond
 */
