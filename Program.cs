string rawReference = "  ord_742  ";
string quantityText = "6";
string externalPriority = "HIGH";

decimal unitPrice = 14.95m;

int currentStock = 20;
int reservedItems = 3;

object genericPayload = 150;

string rawTrim = rawReference.Trim();
string rawReplace = rawTrim.Replace("_", "-");
string rawReferenceClean = rawReplace.ToUpper();
const string ValidPrefix = "ORD-";
bool isExist = rawReferenceClean.StartsWith(ValidPrefix);

int quantityConvert = int.Parse(quantityText);

bool externalPriorityConvert = int.TryParse(externalPriority, out int result);

decimal totalAmount = unitPrice * quantityConvert;

int stockAvailable = currentStock - reservedItems;

bool isStockAvailable = stockAvailable >= quantityConvert;

string? deliveryNotes = null;

bool isNotAvailable = deliveryNotes is null;

bool isInt = genericPayload is int;
bool isString = genericPayload is string;

var message = $"Order {rawReferenceClean} - Quantity: {quantityConvert} - Available: {isStockAvailable}";



/*

// long largeValue = 120L;
// int smallerValue = (int)largeValue;

// object boxedValue = 25;

// string firstReference = "ORD-742";
// string secondReference = firstReference;
// secondReference = secondReference.Replace("742", "900");


1. Pourquoi le passage de long vers int nécessite-t-il un cast ? long peut représenter une plage de valeurs plus grande que int. La conversion long -> int peut donc perdre de l'information, 
	ce qui explique qu'un cast explicite soit nécessaire. Si la valeur dépasse la plage de int, le résultat peut être incorrect en contexte non vérifié.
   Quel risque général existe ? Le risque c'est que le nombre soit trop gros pour que la conversion se fasse.

2. Que se passe-t-il avec :
   object boxedValue = 25;
   sachant que int est un type valeur ? boxedValue est de type object et la valeur contenue est de type int donc il y a un boxing.

3. Après Replace, pourquoi :
   firstReference  = "ORD-742"
   secondReference = "ORD-900"
   ? Car secondReference ne reference plus le même objet de (firstReference), donc c'est une nouvelle reference qui se fait avec replace.  

4. Quelle différence fondamentale entre :
   int?
   et
   string?
   
   int est de type valeur avec la possibilité d'etre null alors que string est de type reference mais avec la possibilité d'etre null
*/



Console.WriteLine(rawReferenceClean);
Console.WriteLine(isExist);
Console.WriteLine(quantityConvert);
Console.WriteLine(externalPriorityConvert);
Console.WriteLine(result);
Console.WriteLine(totalAmount);
Console.WriteLine(stockAvailable);
Console.WriteLine(isStockAvailable);
Console.WriteLine(isNotAvailable);
Console.WriteLine(isInt);
Console.WriteLine(isString);
Console.WriteLine(message);
