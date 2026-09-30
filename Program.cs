int currentStock = 18;
int inboundShipment = 7;
int reservedItems = 5;

int availableStock = currentStock + inboundShipment - reservedItems;

int orderDemand = 12;
bool isStockSufficient = availableStock >= orderDemand;

bool warehouseOpen = true;
bool itemBlocked = false;

bool canPrepareOrder = warehouseOpen && isStockSufficient && !itemBlocked;

int totalItems = 23;
int capacityBox = 5;

int boxCompleted = totalItems / capacityBox;
int remainingItems = totalItems % capacityBox;

int counter = 2;
counter += 3;
counter--;


// int division = 10 / 3;
// string code = "10" + "5";

/*

1. Quelle valeur reçoit division et pourquoi ? 1. division reçoit 3, car 10 et 3 sont des int :
   la division entière conserve le quotient entier.

2. Quelle valeur reçoit code et pourquoi ? "105" car il concatene deux chaines de caractères

3. Quelle différence entre :
   =  
   et
   ==
   
   = est une affectation d'une valeur dans une variable
   == est une comparaison entre deux valeurs
   
*/


Console.WriteLine(availableStock);
Console.WriteLine(isStockSufficient);
Console.WriteLine(canPrepareOrder);
Console.WriteLine(boxCompleted);
Console.WriteLine(remainingItems);
Console.WriteLine(counter);
