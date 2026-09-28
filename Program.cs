int parcelCount = 145;
bool centerOpen = true;
char sectorLetter = 'D';
string centerCode = "CTR-08";
long totalProcessed = 5000000000L;

const string ApplicationName = "ParcelTrack";
const int MaxDailyParcels = 2500;

Console.WriteLine(parcelCount);
Console.WriteLine(centerOpen);
Console.WriteLine(sectorLetter);
Console.WriteLine(centerCode);
Console.WriteLine(totalProcessed);
Console.WriteLine(ApplicationName);
Console.WriteLine(MaxDailyParcels);

/*
type C# :
type valeur ou type référence :

parcelCount = int / valeur
centerOpen = bool / valeur
sectorLetter = char / valeur
centerCode = string / référence
totalProcessed = long / valeur
ApplicationName = string / référence
MaxDailyParcels = int / valeur

Pourquoi centerCode, qui contient "CTR-08", est-il un type référence ? Car c'est un string et un string fait référence a un objet
Pourquoi parcelCount est-il un type valeur ? car c'est un int 
Est-ce que const string ApplicationName devient un type valeur parce qu’il utilise const ? non car le type string est toujours référence a un objet
Est-ce que const int MaxDailyParcels cesse d’être un type valeur parce qu’il est constant ? non comme la précédente question c'est toujours pareil


Pourquoi on évite pour l’instant de dire
type valeur = stack
type référence = heap ?

parce que selon le contexte ce n'est pas totalement vrai, d'où le fait que l'on ne dis pas concretement ça
*/