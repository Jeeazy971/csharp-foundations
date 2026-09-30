string rawReference = "  ord_458  ";
string removeSpaceRawReference = rawReference.Trim();
string replaceRawReference = removeSpaceRawReference.Replace("_", "-");
string cleanRawReference = replaceRawReference.ToUpper();

bool isValidPrefix = cleanRawReference.StartsWith("ORD-");
bool containsRawReference = cleanRawReference.Contains("458");

int cleanRawReferenceLength = cleanRawReference.Length;
string message = $"Reference {cleanRawReference} - Valid prefix: {isValidPrefix}";

// string status = "pending";
// status.ToUpper();
// Console.WriteLine(status);

/*

1. Qu'afficherait ce code ? "pending"

2. Pourquoi ToUpper() n'a-t-il pas modifié status ? car la valeur n'a pas été stocké

donnée brute
→ Trim = eneleve les espaces vide au debut et a la fin
→ Replace = change _ en -
→ ToUpper = ToUpper() retourne une nouvelle chaîne car string est immutable. Comme le résultat n’est pas stocké ou réaffecté à status, status reste "pending".
→ vérifications = verifie si le contenu recherché est present ou non StartsWith
→ interpolation = retranscrit le resultat des variables dans le string avec $ et {variable}
*/

Console.WriteLine(cleanRawReference);
Console.WriteLine(isValidPrefix);
Console.WriteLine(containsRawReference);
Console.WriteLine(cleanRawReferenceLength);
Console.WriteLine(message);
