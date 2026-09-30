string referenceOrder = "ORD-204";
string? deliveryNote = null;
// string anotherString = "";
deliveryNote = "Leave at reception";
string? anotherDeliveryNote = deliveryNote;

Console.WriteLine(referenceOrder);
Console.WriteLine(deliveryNote);
Console.WriteLine(anotherDeliveryNote);

// string customerName = null;
// string? optionalMessage = null;
// Console.WriteLine(optionalMessage.Length);

/*

1. Pourquoi customerName = null pose-t-il problème alors que le code peut quand même compiler ? Parce qu'il est censé avoir une chaine de manière obligatoire, sauf que ce n'est pos le cas là.

2. Pourquoi optionalMessage.Length est-il dangereux ? Car au runtime il y a une absence de valeur donc il y a echouer et générer une erreur

3. Quelle différence métier fais-tu entre :
   null
   et
   ""
   
   null = absence de valeur 
   "" = valeur existante mais aucun caractères présent dans la string
*/
