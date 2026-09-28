const string MuseumName = "Nova Museum";
const int MaxDailyVisitors = 1200;
const char DefaultGate = 'A';
int currentVisitors = 350;
bool gateOpen = true;

Console.WriteLine(MuseumName);
Console.WriteLine(MaxDailyVisitors);
Console.WriteLine(DefaultGate);
Console.WriteLine(currentVisitors);
Console.WriteLine(gateOpen);

currentVisitors = 375;
Console.WriteLine(currentVisitors);

/* 
	1. Nom officiel du musée fixé dans l'application = une constante car il ne changera pas 
	2. Nombre actuel de visiteurs présents = sans const car il peut varier
	3. Nombre maximal de visiteurs autorisés par jour, fixé à 1200 = const car c'est la capacité maximal
	4. Porte actuellement ouverte ou fermée = sans const car il peut etre ouverte ou fermé selon la capacité maximale atteinte ou non
	5. Lettre fixe utilisée comme porte d'entrée par défaut = const car la porte par defaut ne change aps de lettre
	
	La raison de l'erreur dans la compilation est due au fait que const est immuable, donc à la compilation la valeur ne peut pas changer.
*/