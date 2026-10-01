object genericData = 150;

bool isInteger = genericData is int;
bool isString = genericData is string;

string? deliveryRemainder = null;

bool isNull = deliveryRemainder is null;
bool isNotNull = deliveryRemainder is not null;

int quantity = 8;

bool isGreaterTo0 = quantity is > 0;
bool isGreaterOrEqualTo10 = quantity is >= 10;

// object code = "ORD-42";
// bool isNumber = code is int;

/*

1. Quelle valeur recevrait isNumber ? False

2. Est-ce que ce test provoquerait une exception si code
   contient une string ? Pourquoi ? Non je ne pense pas, car il teste si la valeur correspond au type attendue, donc on regarde ce que la valeur contient
   
*/


Console.WriteLine(isInteger);
Console.WriteLine(isString);
Console.WriteLine(isNull);
Console.WriteLine(isNotNull);
Console.WriteLine(isGreaterTo0);
Console.WriteLine(isGreaterOrEqualTo10);
