# C# / .NET Foundations Training

Projet de formation pratique C# / .NET orienté backend.

L'objectif du dépôt est de construire progressivement un socle C# solide, puis d'évoluer vers la POO, les collections, l'écosystème .NET, ASP.NET Core, EF Core, les tests, la sécurité, Docker et la CI/CD.

La formation privilégie :

- la compréhension avant la mémorisation ;
- des exemples professionnels réalistes ;
- des exercices dans un contexte différent de celui du cours ;
- la lecture et le diagnostic de code ;
- l'autonomie d'implémentation ;
- l'utilisation progressive de Git/GitHub ;
- la reconnaissance de patterns de résolution de problèmes ;
- un fil rouge évolutif séparé des exercices pédagogiques.

---

## Environnement actuel

- Windows 11
- PowerShell
- .NET SDK : `10.0.401`
- Projet courant : `FoundationsApp`
- Target Framework : `net10.0`
- Dépôt Git : `csharp-foundations`
- Branche principale : `main`
- Remote : GitHub

---

## Organisation du dépôt

```text
01-csharp-foundations/
├── Program.cs
├── FoundationsApp.csproj
├── README.md
└── docs/
    ├── 00-bloc-0-environnement-dotnet-git.md
    └── 01-bloc-1-typage-variables-expressions.md
```

`Program.cs` reste la zone de travail courante.

Le dossier `docs/` conserve les connaissances validées afin de ne pas dépendre uniquement de l'historique Git pour retrouver une notion déjà étudiée.

Git reste la source de vérité pour suivre l'évolution réelle du code.

---

## Progression

| Phase | Bloc | Statut |
|---|---|---|
| Phase 0 | Environnement .NET et Git/GitHub | ✅ Validé |
| Phase 1 | Bloc 1 — Typage, variables et expressions | ✅ Validé |
| Phase 1 | Bloc 2 — Conditions, boucles et méthodes | ⏳ Prochain |
| Phase 1 | Bloc 3 — Collections et génériques | ⏳ À venir |
| Phase 2 | POO et modélisation | ⏳ À venir |

---

## Documentation

### Bloc 0 — Environnement .NET et Git/GitHub

[Voir le document du Bloc 0](docs/00-bloc-0-environnement-dotnet-git.md)

Contenu principal :

- C# vs .NET ;
- SDK vs Runtime ;
- CLR, BCL, compilation, IL et JIT ;
- structure d'un projet `.NET` ;
- `Program.cs`, `.csproj`, `bin/`, `obj/` ;
- commandes `dotnet` ;
- cycle build / run ;
- Git : working tree, staging, commit, remote ;
- GitHub et `origin` ;
- `status`, `diff`, `add`, `commit`, `log`, `push` ;
- bonnes pratiques de versionnement.

### Bloc 1 — Typage, variables et expressions

[Voir le document du Bloc 1](docs/01-bloc-1-typage-variables-expressions.md)

Contenu principal :

- types primitifs ;
- déclaration, initialisation, affectation et portée ;
- `const` ;
- types valeur / référence ;
- copie, mutation, références partagées ;
- mémoire managée ;
- boxing / unboxing ;
- `var` ;
- `object` / `dynamic` ;
- conversions, `Parse`, `TryParse`, `out` ;
- `null`, `int?`, Nullable Reference Types ;
- `decimal`, `double`, `float` ;
- chaînes et immutabilité ;
- opérateurs ;
- pattern matching de base.

---

## Jalons Git validés

Historique principal du Bloc 1 :

```text
4679fe5 Complete C# foundations block 1 consolidation
e814921 Practice basic pattern matching
143e9be Practice operators
ee4b93a Practice string manipulation
f689611 Practice floating point and decimal types
d5030c5 Practice nullable reference types
e022036 Practice nullable value types
41086dc Practice conversions and parsing
02cdd4e Practice object and dynamic types
e3a5fe3 Practice type inference with var
1bb6414 Practice managed memory model
e36ab97 Practice value and reference copying
599d1ca Practice value and reference types
2ac18a6 Practice constant and mutable variables
9c37309 Practice variable declaration and scope
c38eb1e Update console greeting
666cdf7 Initialize C# foundations project
```

---

## Workflow de travail

Pour chaque notion :

```text
Cours
  ↓
Exemples guidés
  ↓
Questions
  ↓
Exercice dans un autre contexte
  ↓
Build / Run
  ↓
Diagnostic
  ↓
Validation
  ↓
Commit Git cohérent
```

Quand un exercice possède des données initiales, elles sont fournies explicitement avec la sortie attendue.

Les exemples du cours, les exercices, les consolidations et le fil rouge utilisent des contextes différents afin de vérifier le transfert réel des compétences.

---

## Prochaine étape

### Bloc 2 — Conditions, boucles et méthodes

Objectifs :

- prendre des décisions avec `if / else` ;
- gérer plusieurs cas avec `switch` ;
- répéter des traitements avec les boucles ;
- créer et utiliser des méthodes ;
- comprendre paramètres et valeurs de retour ;
- reconnaître des patterns simples de résolution :
  - compteur ;
  - accumulateur ;
  - validation ;
  - filtrage ;
  - transformation ;
  - recherche avec arrêt anticipé ;
  - guard clause ;
  - entrée → traitement → sortie.

Un court passage pratique sur Visual Studio sera réalisé au début du Bloc 2 pour utiliser :

- l'explorateur de projet ;
- le terminal intégré ;
- build / run ;
- breakpoint ;
- exécution pas à pas ;
- inspection des variables.

---

## Fil rouge

Le fil rouge **ResourceFlow** commencera pendant le Bloc 2, une fois suffisamment de conditions, boucles et méthodes acquises.

Il restera séparé des exercices pédagogiques afin d'éviter de mémoriser un seul scénario métier.
