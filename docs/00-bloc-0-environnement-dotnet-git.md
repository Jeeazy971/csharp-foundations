# Bloc 0 — Environnement .NET et Git/GitHub

## Statut

**✅ Validé**

Ce bloc constitue le socle d'outillage de la formation C#/.NET.

L'objectif n'est pas de connaître toutes les options du SDK ou de Git, mais de comprendre ce qui se passe lorsqu'un projet C# est créé, construit, exécuté et versionné.

---

# 1. C#, .NET et l'écosystème

## C#

C# est le **langage de programmation**.

Exemple :

```csharp
int quantity = 5;
Console.WriteLine(quantity);
```

Le fichier source utilise généralement l'extension :

```text
.cs
```

---

## .NET

.NET est la plateforme qui fournit notamment :

- le SDK ;
- le Runtime ;
- le CLR ;
- les bibliothèques standard ;
- les outils de compilation ;
- l'écosystème ASP.NET Core / EF Core.

Il faut éviter de confondre :

```text
C# = langage
.NET = plateforme
```

---

## .NET SDK

Le SDK contient les outils nécessaires au développement.

Il permet notamment de :

- créer un projet ;
- restaurer les dépendances ;
- compiler ;
- exécuter ;
- tester ;
- publier.

Commandes vues :

```powershell
dotnet --info
dotnet --version
dotnet --list-sdks
dotnet --list-runtimes
```

Environnement actuellement utilisé :

```text
.NET SDK 10.0.401
```

---

## .NET Runtime

Le Runtime fournit l'environnement nécessaire à l'exécution d'une application .NET.

Idée importante :

```text
SDK
→ développement + compilation + outils

Runtime
→ exécution
```

Installer uniquement un Runtime ne donne pas tous les outils de développement du SDK.

---

# 2. CLR, BCL, compilation et exécution

## CLR

Le **Common Language Runtime** est le runtime managé de .NET.

Il participe notamment à :

- l'exécution du code ;
- la gestion de la mémoire ;
- le Garbage Collector ;
- la gestion des exceptions ;
- le chargement des assemblies.

---

## BCL

La **Base Class Library** correspond aux bibliothèques de base fournies par .NET.

Exemples rencontrés :

```csharp
Console.WriteLine(...)
int.Parse(...)
int.TryParse(...)
string.Trim()
string.Replace(...)
```

---

## Cycle simplifié d'exécution

Modèle mental :

```text
Code source C#
    ↓
Compilateur C# / Roslyn
    ↓
IL + métadonnées
    ↓
Assembly
    ↓
CLR
    ↓
JIT
    ↓
Code machine
    ↓
Exécution
```

### IL

Le code C# n'est pas simplement transformé directement en code machine lors du build classique.

Le compilateur produit notamment de l'**IL** (Intermediate Language) et des métadonnées.

### JIT

Le **Just-In-Time compiler** transforme au runtime le code nécessaire en code machine adapté à la plateforme.

---

# 3. Structure du projet

Projet actuel :

```text
C:\Workspace-dev\csharp\01-csharp-foundations
```

Éléments principaux :

```text
01-csharp-foundations/
├── Program.cs
├── FoundationsApp.csproj
├── bin/
└── obj/
```

## Program.cs

`Program.cs` contient actuellement le code principal utilisé pendant les exercices.

Le projet utilise les **top-level statements**, ce qui permet d'écrire directement :

```csharp
Console.WriteLine("Hello");
```

sans déclarer immédiatement une classe `Program` et une méthode `Main`.

## .csproj

Le fichier `.csproj` décrit le projet .NET.

Il contient notamment :

- le SDK utilisé ;
- le Target Framework ;
- certaines options de compilation ;
- les dépendances NuGet lorsqu'elles seront ajoutées.

Le projet actuel cible :

```text
net10.0
```

## bin/

`bin/` contient principalement des artefacts issus du build.

Ils ne constituent pas le code source du projet.

## obj/

`obj/` contient des fichiers intermédiaires générés par les outils .NET.

Ils ne doivent normalement pas être versionnés.

---

# 4. Commandes .NET utilisées

## Créer un projet

```powershell
dotnet new console
```

Crée un projet console à partir du template correspondant.

## Restore

```powershell
dotnet restore
```

Restaure les dépendances nécessaires au projet.

## Build

```powershell
dotnet build
```

Le build :

1. analyse le projet ;
2. compile le code ;
3. signale erreurs et warnings ;
4. produit les artefacts nécessaires.

Une erreur de compilation empêche normalement l'obtention d'un build valide.

Un warning permet généralement le build mais indique un problème potentiel ou une amélioration à effectuer.

## Run

```powershell
dotnet run
```

Compile si nécessaire puis exécute l'application.

Nous avons souvent utilisé :

```powershell
dotnet build && dotnet run
```

Sous PowerShell, la seconde commande n'est exécutée que si la première réussit.

## Clean

Commande connue :

```powershell
dotnet clean
```

Elle nettoie les sorties de build du projet.

---

# 5. IDE

## IDE vs .NET

Un IDE n'est pas .NET.

Visual Studio, Rider ou VS Code servent à faciliter le travail :

- édition ;
- navigation ;
- build ;
- exécution ;
- debugging ;
- terminal ;
- Git.

Mais le SDK reste capable de construire le projet depuis la ligne de commande.

## État actuel

La distinction conceptuelle IDE / SDK / CLI est acquise.

La pratique détaillée suivante reste volontairement à consolider au début du Bloc 2 :

- ouvrir le projet dans Visual Studio ;
- explorateur de projet ;
- terminal intégré ;
- breakpoint ;
- exécution pas à pas ;
- inspection des variables ;
- call stack.

---

# 6. Git — modèle mental

Git est un système de gestion de versions.

Il faut distinguer Git d'une forge :

```text
Git
→ outil de versionnement

GitHub
→ plateforme distante hébergeant des dépôts Git
```

## Les principaux états

Modèle mental :

```text
Working tree
    ↓ git add
Staging area
    ↓ git commit
Local repository
    ↓ git push
Remote repository
```

## Working tree

Le working tree correspond aux fichiers tels qu'ils existent actuellement dans le dossier de travail.

Exemple :

```powershell
git status
```

permet notamment de savoir si un fichier est :

- non suivi ;
- modifié ;
- staged ;
- propre.

## Staging area

La staging area contient les modifications sélectionnées pour le prochain commit.

Commande :

```powershell
git add Program.cs
```

## Commit

Un commit enregistre une évolution cohérente dans l'historique local.

Exemple :

```powershell
git commit -m "Practice operators"
```

Un commit n'est pas automatiquement envoyé sur GitHub.

## Remote

Le remote représente un dépôt distant.

Le remote principal utilisé est nommé :

```text
origin
```

`origin` est une convention de nommage, pas un mot magique imposé par Git.

## Push

```powershell
git push
```

envoie les nouveaux commits vers le dépôt distant correspondant.

---

# 7. Commandes Git pratiquées

## État

```powershell
git status
```

Permet de vérifier l'état du working tree et du staging.

## Diff non staged

```powershell
git diff
```

Dans notre workflow courant, il sert principalement à relire les modifications non staged.

## Diff staged

```powershell
git diff --staged
```

Affiche les modifications qui seront incluses dans le prochain commit.

C'est une vérification importante avant le commit.

## Ajouter un fichier

```powershell
git add Program.cs
```

ou, si l'on sait exactement ce que l'on fait :

```powershell
git add .
```

Bonne pratique adoptée : préférer cibler le fichier lorsque cela améliore le contrôle.

## Commit

```powershell
git commit -m "Message clair"
```

Le message doit décrire l'intention de l'évolution.

## Historique

```powershell
git log --oneline
```

Permet de lire rapidement l'historique.

## Push

```powershell
git push
```

Synchronise les nouveaux commits avec le remote.

---

# 8. GitHub et upstream

Le dépôt possède un remote GitHub.

La branche actuelle :

```text
main
```

est reliée à :

```text
origin/main
```

Lorsque Git affiche :

```text
Your branch is up to date with 'origin/main'
```

cela signifie que la branche locale et sa branche distante suivie sont synchronisées.

---

# 9. Workflow adopté

Avant un commit :

```powershell
dotnet build
dotnet run
git status
git diff
```

Puis :

```powershell
git add <fichier>
git diff --staged
git commit -m "..."
git push
git status
```

Ce workflow permet de vérifier :

1. que le code compile ;
2. que le résultat est correct ;
3. que les modifications sont comprises ;
4. que seules les bonnes modifications sont staged ;
5. que le dépôt est propre après le push.

---

# 10. Bonnes pratiques acquises

## Un commit = une évolution cohérente

Éviter les commits qui mélangent plusieurs sujets sans rapport.

## Inspecter avant de committer

Toujours comprendre ce qui sera enregistré :

```powershell
git status
git diff
git diff --staged
```

## Ne pas versionner les artefacts générés

Par exemple :

```text
bin/
obj/
```

Ils sont normalement ignorés via `.gitignore`.

## Ne jamais committer de secret

Exemples :

- mot de passe ;
- token ;
- clé API ;
- chaîne de connexion sensible.

## Commit ≠ Push

```text
commit
→ historique local

push
→ envoi vers le remote
```

---

# 11. Pièges rencontrés / à reconnaître

## Ancien binaire après échec de compilation

Dans certains environnements, il est possible d'avoir l'impression qu'un ancien résultat s'exécute alors que le nouveau code n'a pas compilé.

Réflexe :

```powershell
dotnet build
```

avant d'interpréter le résultat.

## Warning ≠ Error

Un warning doit être lu.

Exemple rencontré plus tard dans le Bloc 1 :

```text
variable assignée mais jamais utilisée
```

Le build peut réussir, mais le warning indique une zone à corriger.

---

# 12. Ce qu'il faut savoir expliquer

À la fin du Bloc 0 :

- C# n'est pas .NET ;
- SDK et Runtime ont des rôles différents ;
- le CLR exécute le code managé ;
- un build produit notamment de l'IL et des métadonnées ;
- le JIT intervient lors de l'exécution classique ;
- `.csproj` décrit le projet ;
- `bin/` et `obj/` sont générés ;
- `dotnet build` et `dotnet run` sont différents ;
- un IDE automatise des opérations mais ne remplace pas le SDK ;
- Git et GitHub ne sont pas la même chose ;
- working tree, staging, commit et remote sont distincts ;
- `git diff` et `git diff --staged` ne montrent pas le même état ;
- commit et push ne sont pas synonymes.

---

# 13. Statut final

```text
Compréhension environnement .NET : ✅
CLI .NET                       : ✅
Structure projet               : ✅
Git local                      : ✅
GitHub / remote                : ✅
Workflow commit                : ✅
IDE conceptuel                 : ✅
IDE pratique / debugger        : 🟠 à consolider au début du Bloc 2
```

Le Bloc 0 est considéré comme validé : le point IDE pratique est volontairement réutilisé et consolidé dans la suite de la formation.
