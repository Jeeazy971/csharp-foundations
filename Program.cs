string rawExportFormat = "  csv ";
int priorityCode = 2;

string cleanExportFormat = rawExportFormat.Trim().ToUpper();

string fileExtension = cleanExportFormat switch
{
   "CSV" => ".csv",
   "JSON" => ".json",
   "XML"  => ".xml",
   _ => ".txt"
};

int retentionDays = priorityCode switch
{
    1 => 7,
    2 => 30,
    3 => 90,
    _ => 1
};


Console.WriteLine(fileExtension);
Console.WriteLine(retentionDays);

//Questions en commentaire
//Réponds avec tes propres mots :
//1.Pourquoi n'avons-nous pas besoin d'initialiser fileExtension à null
//   avant le switch expression ? Car dans switch expression, la variable obtient dejà la valeur du switch

//2. Que signifie => dans une branche du switch expression ? obtenir, ou deviens

//3. Quel est le rôle de _ ? il est comme default dans le switch classique

//4. Quelle différence principale vois-tu entre :
//   switch classique 
//   et
//   switch expression ? 
// switch classique
/*
 * → choisit des instructions / actions à exécuter

   switch expression
   → choisit une valeur à produire
*/

//Mini-diagnostic — prédiction avant exécution
//Ajoute ce code dans un commentaire, ne l’exécute pas avant d’avoir répondu :
//string deviceType = "TABLET";

//string interfaceMode = deviceType switch
//{
//    "DESKTOP" => "Wide",
//    "MOBILE" => "Compact",
//    _ => "Standard"
//};

//Console.WriteLine(interfaceMode);

//Indique:
//Qu'est-ce qui sera affiché ? Standard
//Pourquoi? Car aucuns cas ne correspondais
//Quelle branche produit finalement la valeur ? La branche _ => "Standard" produit finalement la valeur.
