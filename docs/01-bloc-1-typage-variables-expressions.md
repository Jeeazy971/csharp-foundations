# Bloc 1 — Typage, variables et expressions

## Statut

**✅ Validé**

Commit de consolidation :

```text
4679fe5 Complete C# foundations block 1 consolidation
```

Objectif du bloc :

> savoir représenter correctement les données d'un programme C#, comprendre leur type, leurs conversions, leurs valeurs nulles, leur comportement mémoire au niveau utile et les manipuler avec des expressions simples.

---

# 1. Types primitifs et types courants

Un type décrit notamment :

- la nature de la donnée ;
- les valeurs possibles ;
- les opérations disponibles.

Exemples :

```csharp
int quantity = 10;
long population = 8_000_000_000L;
bool isActive = true;
char grade = 'A';
string orderCode = "ORD-42";
decimal price = 19.99m;
double temperature = 21.7;
float scale = 1.25f;
```

## Choisir le type selon le sens métier

Une donnée composée uniquement de chiffres n'est pas automatiquement un nombre à calculer.

Exemples souvent mieux représentés par une `string` :

```text
numéro de téléphone
code postal
identifiant métier
référence de commande
```

Question à se poser :

> Est-ce que cette donnée sert réellement à faire des opérations numériques ?

---

# 2. Déclaration, initialisation et affectation

## Déclaration

```csharp
int quantity;
```

La variable existe dans le code, mais une variable locale non initialisée ne peut pas être lue.

## Initialisation

```csharp
int quantity = 5;
```

La variable reçoit sa première valeur.

## Affectation

```csharp
quantity = 8;
```

La variable existait déjà et reçoit une nouvelle valeur.

## Typage statique

```csharp
int quantity = 5;
```

`quantity` reste une variable de type `int`.

On ne peut pas ensuite lui affecter directement une `string`.

---

# 3. Portée

Les accolades définissent notamment des blocs de portée.

```csharp
{
    int localValue = 10;
}
```

`localValue` n'est plus accessible depuis le code extérieur au bloc.

Important :

> La portée décrit surtout où un identifiant est accessible dans le code. Elle ne doit pas être confondue avec une règle simpliste sur l'emplacement physique en mémoire.

---

# 4. const

Une constante doit être initialisée et ne peut pas être réaffectée.

```csharp
const string ValidPrefix = "ORD-";
```

Convention courante :

```text
PascalCase
```

Utilité :

- éviter les valeurs magiques ;
- donner du sens à une valeur fixe ;
- éviter une modification accidentelle.

---

# 5. Types valeur et types référence

## Type valeur

Une variable d'un type valeur contient directement sa valeur logique.

```csharp
int first = 10;
int second = first;

second = 20;
```

Résultat conceptuel :

```text
first  = 10
second = 20
```

L'affectation a copié la valeur.

## Type référence

Une variable d'un type référence contient une référence permettant d'accéder à un objet.

Modèle mental :

```text
variable
   ↓
référence
   ↓
objet
```

Affecter une référence à une autre variable ne clone pas automatiquement l'objet.

## string est un type référence

```csharp
string first = "ORD-42";
string second = first;
```

Les deux variables peuvent initialement désigner la même chaîne.

Mais `string` est immutable : les opérations de transformation produisent une nouvelle chaîne.

---

# 6. Copie, mutation et réaffectation

Trois notions à distinguer.

## Copie d'une valeur

```csharp
int a = 10;
int b = a;
```

`b` reçoit une copie indépendante de la valeur.

## Copie d'une référence

Pour un objet mutable :

```text
variable A ─┐
            ├──> objet
variable B ─┘
```

Modifier l'objet via une référence peut être visible via l'autre référence.

## Réaffectation

Réaffecter une variable de référence change la référence stockée dans cette variable.

Cela ne modifie pas automatiquement l'autre variable.

---

# 7. Mémoire managée

## Règle importante

Ne jamais définir :

```text
type valeur = stack
type référence = heap
```

Cette formule est trop simpliste et techniquement fausse comme définition.

## Stack

La stack sert principalement à modéliser l'exécution des appels :

```text
appel méthode A
    ↓
appel méthode B
    ↓
retour B
    ↓
retour A
```

On parle notamment de stack frames.

Le JIT peut effectuer des optimisations et utiliser des registres ou d'autres stratégies de stockage.

## Managed Heap

Le managed heap est une zone utilisée pour les objets managés.

Le Garbage Collector gère leur cycle de vie.

## Reachability

Un objet devient éligible à la collecte lorsqu'il n'est plus atteignable depuis les racines pertinentes du programme.

Éligible ne signifie pas :

```text
supprimé immédiatement
```

Le GC choisit quand effectuer une collecte.

## Cycles

.NET ne repose pas simplement sur un compteur de références.

Deux objets qui ne sont plus atteignables peuvent être collectés même s'ils se référencent mutuellement.

---

# 8. Boxing et unboxing

## Boxing

Le boxing se produit lorsqu'un type valeur doit être représenté comme `object` ou comme une interface compatible.

```csharp
int number = 25;
object boxed = number;
```

Conceptuellement :

```text
int
↓ boxing
object contenant une représentation du int
```

La valeur est copiée dans la représentation boxée.

## Unboxing

```csharp
int result = (int)boxed;
```

L'unboxing récupère le type valeur contenu dans l'objet boxé.

Important :

> l'unboxing attend le type réellement boxé.

Unboxing et conversion numérique sont deux opérations différentes.

---

# 9. var et inférence de type

```csharp
var quantity = 10;
```

Le compilateur déduit :

```text
quantity : int
```

`var` ne signifie pas :

```text
pas de type
```

et ne rend pas C# dynamiquement typé.

## var ≠ dynamic

```csharp
var quantity = 10;
```

Le type est connu à la compilation.

```csharp
dynamic value = 10;
```

Certaines vérifications liées aux opérations sont repoussées au runtime.

## Bonne pratique

Utiliser `var` lorsque le type reste évident :

```csharp
var message = $"Order {orderCode}";
```

Éviter de l'utiliser si cela rend le code difficile à lire.

---

# 10. object et dynamic

## object

`object` peut référencer des valeurs de types différents.

```csharp
object value = 150;
```

Le type déclaré de la variable est `object`.

La valeur `150` est un `int` boxé.

## dynamic

```csharp
dynamic value = 150;
```

`dynamic` permet de repousser certaines opérations de résolution de type au runtime.

Risques :

- erreurs découvertes plus tard ;
- moins de sécurité à la compilation ;
- code plus difficile à maintenir si utilisé sans besoin réel.

Règle :

> préférer un type précis lorsque le domaine est connu.

---

# 11. Conversions numériques

## Conversion implicite

Une conversion sûre vers une plage plus grande peut être implicite.

```csharp
int small = 100;
long large = small;
```

## Conversion explicite

```csharp
long large = 120L;
int smaller = (int)large;
```

Le cast indique explicitement que l'on accepte le risque de conversion.

## Risque de perte d'information

`long` peut représenter une plage plus grande que `int`.

Donc :

```text
long → int
```

peut perdre de l'information.

En contexte non vérifié, une valeur hors plage peut produire un résultat incorrect plutôt qu'une exception automatique.

Le mot-clé `checked` sera vu plus tard.

---

# 12. Parse

`Parse` convertit une représentation textuelle valide vers un type.

```csharp
string text = "42";
int quantity = int.Parse(text);
```

Flux :

```text
"42"
 ↓ Parse
42
```

Si l'entrée est invalide, `Parse` peut lever une exception.

On l'utilise lorsque la donnée est supposée valide ou lorsqu'une exception est réellement le comportement voulu.

---

# 13. TryParse

`TryParse` sert lorsque l'entrée peut être invalide.

```csharp
string text = "42";

bool success = int.TryParse(text, out int quantity);
```

Deux résultats sont produits :

```text
bool success
+
int quantity
```

## Cas valide

```text
text = "42"

success  = true
quantity = 42
```

## Cas invalide

```text
text = "ABC"

success  = false
quantity = 0
```

Le `0` obtenu en cas d'échec ne doit pas être interprété comme une vraie donnée métier.

Il faut tenir compte du booléen.

## out

Dans :

```csharp
int.TryParse(text, out int quantity);
```

`quantity` est créé dans le scope appelant et reçoit la valeur produite par la méthode.

Le Bloc 2 approfondira `out` dans les méthodes.

---

# 14. null

`null` signifie absence de valeur/référence.

Il ne signifie pas :

```text
0
false
""
" "
```

Ces valeurs sont différentes.

---

# 15. Nullable value types

Un type valeur classique :

```csharp
int quantity = 5;
```

ne peut pas normalement contenir `null`.

Pour permettre l'absence :

```csharp
int? quantity = null;
```

`int?` est un raccourci de :

```csharp
Nullable<int>
```

## HasValue

```csharp
bool exists = quantity.HasValue;
```

Retourne un booléen indiquant si une valeur existe.

## GetValueOrDefault

```csharp
int result = quantity.GetValueOrDefault();
```

Retourne :

- la valeur lorsqu'elle existe ;
- la valeur par défaut du type sinon.

Pour `int`, la valeur par défaut est `0`.

Attention :

> `0` ne veut pas forcément dire que la donnée métier était réellement zéro.

## Value

```csharp
int result = quantity.Value;
```

Récupère la valeur.

Mais si le nullable vaut `null`, `.Value` lève une `InvalidOperationException`.

À ne pas utiliser aveuglément.

---

# 16. Nullable Reference Types

Avec les Nullable Reference Types activés :

```csharp
string customerName = "Alice";
```

annonce que la référence est censée être non nulle.

```csharp
string? optionalMessage = null;
```

annonce que `null` est autorisé.

## Différence fondamentale avec int?

```text
int?
→ Nullable<int>
→ mécanisme réel pour un type valeur nullable

string?
→ annotation de nullabilité d'un type référence
→ participe à l'analyse statique du compilateur
```

`string` et `string?` ne correspondent pas à deux classes runtime différentes.

## Warning plutôt qu'interdiction runtime

Avec les NRT actifs :

```csharp
string name = null;
```

peut générer un warning du compilateur.

Le système de nullabilité aide à détecter les risques avant l'exécution.

---

# 17. decimal, double et float

## decimal

```csharp
decimal price = 19.99m;
```

Adapté notamment aux calculs décimaux financiers.

Suffixe :

```text
m
```

## double

```csharp
double temperature = 21.7;
```

Type flottant binaire généraliste.

Souvent adapté aux :

- mesures ;
- calculs scientifiques ;
- valeurs approximatives.

Un littéral décimal comme :

```csharp
21.7
```

est un `double` par défaut.

## float

```csharp
float scale = 1.25f;
```

Type flottant 32 bits.

Suffixe :

```text
f
```

À utiliser lorsqu'un besoin concret justifie cette représentation, par exemple certaines APIs ou domaines graphiques.

## Ne pas retenir

```text
decimal = toujours meilleur
```

Les trois types ont des objectifs différents.

---

# 18. Strings

Une `string` est une séquence de caractères et un type référence immutable.

## Concaténation

```csharp
string message = "Order " + orderCode;
```

## Interpolation

```csharp
string message = $"Order {orderCode}";
```

Souvent plus lisible lorsque plusieurs valeurs sont intégrées.

## Immutabilité

```csharp
string status = "pending";
status.ToUpper();
```

`status` reste :

```text
pending
```

car le résultat produit par `ToUpper()` n'a pas été utilisé.

Il faut :

```csharp
status = status.ToUpper();
```

---

# 19. Méthodes string vues

## Length

```csharp
int length = text.Length;
```

Retourne le nombre de caractères.

## Trim

```csharp
string cleaned = text.Trim();
```

Supprime les espaces extérieurs et retourne une nouvelle string.

## Replace

```csharp
string normalized = text.Replace("_", "-");
```

Retourne une nouvelle string.

## ToUpper / ToLower

```csharp
string upper = text.ToUpper();
string lower = text.ToLower();
```

## Contains

```csharp
bool contains = text.Contains("ORD");
```

## StartsWith

```csharp
bool validPrefix = text.StartsWith("ORD-");
```

## EndsWith

```csharp
bool validSuffix = text.EndsWith("-FR");
```

## IndexOf

```csharp
int index = text.IndexOf("-");
```

Retourne l'index de la première occurrence ou :

```text
-1
```

si elle n'existe pas.

Les index commencent à zéro.

## Split / Join

Ils ont été présentés au niveau de reconnaissance.

```text
Split
→ séparer une string en plusieurs éléments

Join
→ assembler plusieurs éléments en une string
```

La manipulation complète des tableaux n'était pas encore exigée.

---

# 20. Opérateurs arithmétiques

```text
+ addition
- soustraction
* multiplication
/ division
% reste
```

## Division entière

```csharp
int result = 10 / 3;
```

Résultat :

```text
3
```

car les deux opérandes sont des `int`.

## Modulo

```csharp
int remainder = 10 % 3;
```

Résultat :

```text
1
```

`%` donne le reste de la division entière.

---

# 21. Patterns de calcul simples à reconnaître

## Total

Énoncé :

```text
prix unitaire × quantité
```

Pattern :

```text
total = prixUnitaire * quantité
```

## Groupes complets

Énoncé :

```text
Combien de boîtes complètes de 5 éléments peut-on faire avec 23 éléments ?
```

Pattern :

```csharp
int completedBoxes = 23 / 5;
```

Résultat :

```text
4
```

## Reste

Énoncé :

```text
Combien d'éléments restent après avoir rempli les boîtes ?
```

Pattern :

```csharp
int remaining = 23 % 5;
```

Résultat :

```text
3
```

## Comparaison avec seuil

Énoncé :

```text
Le stock est-il suffisant pour la demande ?
```

Pattern :

```csharp
bool sufficient = availableStock >= demand;
```

---

# 22. Comparaisons

```text
== égal
!= différent
>  supérieur
<  inférieur
>= supérieur ou égal
<= inférieur ou égal
```

Résultat :

```text
bool
```

## = vs ==

```csharp
quantity = 5;
```

`=` affecte une valeur.

```csharp
quantity == 5
```

`==` compare.

---

# 23. Opérateurs logiques

```text
&& ET
|| OU
!  NON
```

Exemple :

```csharp
bool canPrepare =
    warehouseOpen &&
    stockAvailable &&
    !itemBlocked;
```

---

# 24. Affectations combinées

```csharp
counter += 3;
counter -= 2;
counter *= 4;
counter /= 2;
```

## Incrément / décrément

```csharp
counter++;
counter--;
```

La différence détaillée entre pré-incrémentation et post-incrémentation a été volontairement reportée.

---

# 25. Priorité des opérateurs

Comme en mathématiques :

```text
* et /
avant
+ et -
```

Utiliser des parenthèses lorsque cela améliore la lisibilité.

---

# 26. Type et opérateur

L'opérateur dépend du type.

```csharp
10 + 5
```

donne :

```text
15
```

Alors que :

```csharp
"10" + "5"
```

donne :

```text
"105"
```

---

# 27. Pattern matching de base

Forme générale :

```csharp
value is pattern
```

Le résultat est souvent un `bool`.

## Test de type

```csharp
object genericData = 150;

bool isInteger = genericData is int;
bool isString = genericData is string;
```

Résultat :

```text
True
False
```

Le test ne lève pas une exception simplement parce que le type ne correspond pas.

## Null pattern

```csharp
string? deliveryNote = null;

bool isNull = deliveryNote is null;
bool isNotNull = deliveryNote is not null;
```

## Relational patterns

```csharp
int quantity = 8;

bool positive = quantity is > 0;
bool large = quantity is >= 10;
```

## Type pattern avec capture

Syntaxe vue en reconnaissance :

```csharp
payload is string text
```

Cela permet de :

1. tester le type ;
2. obtenir une variable typée lorsque le pattern correspond.

L'utilisation complète dans un flux `if` est reportée au Bloc 2.

---

# 28. Warnings utiles rencontrés

Avec :

```csharp
int genericData = 150;

bool isInteger = genericData is int;
bool isString = genericData is string;
```

le compilateur peut prévenir :

```text
expression toujours vraie
expression jamais vraie
```

Pourquoi ?

Parce que le type statique est déjà `int`.

Pour un vrai test de type générique :

```csharp
object genericData = 150;
```

est plus pertinent.

---

# 29. Pipeline de transformation de données

Pattern rencontré plusieurs fois :

```text
entrée brute
↓
normalisation
↓
conversion
↓
validation
↓
calcul
↓
sortie
```

Exemple consolidé :

```text
"  ord_742  "
↓ Trim
"ord_742"
↓ Replace
"ord-742"
↓ ToUpper
"ORD-742"
```

---

# 30. Consolidation finale réalisée

Scénario :

```text
référence brute   : "  ord_742  "
quantité texte    : "6"
priorité externe  : "HIGH"
prix unitaire     : 14.95
stock actuel      : 20
réservé           : 3
note de livraison : absente
payload générique : 150
```

Le programme final a combiné :

- `string` ;
- `decimal` ;
- `int` ;
- `object` ;
- `const` ;
- `Trim` ;
- `Replace` ;
- `ToUpper` ;
- `StartsWith` ;
- `Parse` ;
- `TryParse` ;
- `out` ;
- opérateurs arithmétiques ;
- comparaison ;
- nullable reference type ;
- pattern matching ;
- `var` ;
- interpolation.

Sortie validée :

```text
ORD-742
True
6
False
0
89,70
17
True
True
True
False
Order ORD-742 - Quantity: 6 - Available: True
```

Selon la culture système, `89.70` est également possible.

---

# 31. Modèles mentaux à conserver

## Variable, référence et objet

```text
VARIABLE
   ↓ contient
RÉFÉRENCE
   ↓ permet d'accéder à
OBJET
```

## TryParse

```text
texte
 ↓
TryParse
 ├── bool succès
 └── valeur via out
```

Toujours tenir compte des deux résultats.

## Nullable

```text
int?
→ Nullable<int>

string?
→ référence string annotée nullable
```

## String immutable

```text
ancienne string
     ↓ Replace / Trim / ToUpper
nouvelle string
```

La méthode ne modifie pas l'objet string existant.

---

# 32. Pièges importants

- `var` n'est pas `dynamic`.
- `object` n'est pas synonyme de `dynamic`.
- `string` est un type référence.
- `string` est immutable.
- `null`, `0`, `false`, `""` et `" "` sont différents.
- `Parse` peut lever une exception.
- `TryParse` renvoie un booléen à utiliser.
- un échec de `TryParse` donnant `0` ne signifie pas que l'entrée valait réellement zéro.
- un cast numérique explicite peut perdre de l'information.
- boxing ≠ conversion numérique.
- type valeur ≠ toujours stocké sur la stack.
- type référence ≠ définition « toujours sur le heap ».
- affecter une référence ne clone pas automatiquement l'objet.
- `.Value` sur un nullable sans valeur peut lever une exception.
- appeler une méthode de string sans utiliser son résultat peut ne produire aucun effet visible.
- `/` sur deux `int` réalise une division entière.
- `%` donne le reste.
- `=` affecte ; `==` compare.
- `is` permet de tester un pattern sans faire un cast risqué.

---

# 33. Notions volontairement reportées

Non exigées à ce stade :

- `if / else` ;
- `switch` ;
- boucles ;
- méthodes utilisateur ;
- collections ;
- manipulation avancée des tableaux ;
- `checked` ;
- `CultureInfo` ;
- formatage numérique avancé ;
- `StringBuilder` ;
- Regex ;
- comparaisons de chaînes avancées ;
- LINQ ;
- POO complète.

Elles arrivent dans les blocs suivants.

---

# 34. Niveau validé

```text
Conceptuel           : ≈ 8/10
Implémentation       : ≈ 8/10
Lecture / diagnostic : ≈ 7.5–8/10
```

Points particulièrement solides :

- typage ;
- choix de représentation ;
- nullabilité ;
- conversions courantes ;
- chaînes ;
- opérateurs ;
- pattern matching de base ;
- workflow Git.

Points à continuer de renforcer :

- précision du vocabulaire technique ;
- risques des conversions numériques ;
- automatisme `/` vs `%` ;
- reconnaissance progressive des patterns de calcul ;
- autonomie sur des problèmes plus ouverts.

---

# 35. Prochaine étape

## Bloc 2 — Conditions, boucles et méthodes

Le changement principal sera :

```text
Bloc 1
→ Comment représenter correctement mes données ?

Bloc 2
→ Comment faire travailler mon programme avec ces données ?
```

Seront notamment travaillés :

- `if / else` ;
- `switch` ;
- expressions `switch` ;
- `for` ;
- `foreach` ;
- `while` ;
- méthodes ;
- paramètres ;
- valeurs de retour ;
- portée ;
- paramètres optionnels ;
- surcharge ;
- `ref`, `out`, `in` au niveau utile ;
- compteur ;
- accumulateur ;
- validation ;
- filtrage ;
- transformation ;
- recherche avec arrêt anticipé ;
- guard clauses ;
- entrée → traitement → sortie.

Le fil rouge **ResourceFlow** commencera dans ce bloc après acquisition suffisante des conditions, boucles et méthodes.
