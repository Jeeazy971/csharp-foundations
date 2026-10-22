# C# / .NET Foundations — Parcours Coding First

Dépôt de formation progressive en **C# 14 / .NET 10**, orientée vers le développement **backend ASP.NET Core**.

**Objectif :** savoir comprendre, concevoir, coder, exécuter, maintenir et tester un programme C#, puis construire une API REST ASP.NET Core avec PostgreSQL, sécurité, tests et conteneurisation. Le parcours privilégie l'autonomie de développement, la compréhension du code et la reconnaissance des bonnes pratiques/patterns plutôt que la mémorisation de syntaxe.

> **État pédagogique au 22 octobre 2026 : 3 leçons validées sur 25 (12 %).** Leçon **1.4** à venir. Ce suivi décrit les acquis vérifiés pendant la formation, et non l'état de publication des commits sur GitHub.

## 1. Environnement

| Élément | Choix |
|---|---|
| Poste | Windows 11, PowerShell, Visual Studio 2026 |
| Langage / plateforme | C# 14, .NET 10 (`net10.0`) |
| SDK relevé dans le dépôt | `10.0.401` |
| Application console actuelle | `FoundationsApp` |
| Dépôt | `csharp-foundations` |
| Branche de travail principale | `main` |
| Cible progressive | ASP.NET Core 10, EF Core 10, PostgreSQL, xUnit, Docker Compose |

Le socle initial (CLI .NET, Git/GitHub, variables, types, opérateurs et structures de contrôle) a fait l'objet d'un apprentissage antérieur. Il reste documenté dans `docs/` lorsqu'un document correspondant existe. **Il ne doit pas être confondu avec les 25 leçons du parcours Coding First actuel.**

## 2. Méthode pédagogique — règle actuelle

Pour chaque leçon :

1. **Problème métier concret** : ce qu'on cherche à résoudre et pourquoi la notion existe.
2. **Compréhension visuelle** : analogie, schéma (interactif lorsque pertinent), flux et relations **avant le code**.
3. **Exemples expliqués** : exemple minimal puis exemple C# professionnel, éventuellement multi-fichiers, détaillé ligne par ligne.
4. **Reconnaissance** : repérer la notion, le pattern ou l'anti-pattern dans une codebase ou un ticket ; comprendre quand l'utiliser, quand l'éviter et les compromis.
5. **Un exercice principal autonome par leçon**, dans un **contexte différent** du cours, avec des données et un résultat attendu explicites.
6. **Auto-évaluation et correction** : comportement, qualité du code, corrections minimales, exemple de référence et bilan.
7. **Consolidation supplémentaire uniquement en cas de besoin réel** ; **une consolidation transversale en fin de chaque module**.

Principes non négociables :

- **Aucune notion surprise** : toute syntaxe ou notion exigée est expliquée auparavant.
- Exemples guidés, exercice, consolidation et projet éventuel utilisent des **contextes distincts**.
- Priorité à l'écriture autonome du code ; l'architecture complexe et le découpage de tickets sont approfondis progressivement, quand ils deviennent pertinents.
- Les erreurs rencontrées sont analysées au fil de l'eau ; les ateliers de débogage dédiés sont reportés après le parcours principal.
- **Un commit Git cohérent par leçon**, pas un commit et une branche à chaque exercice.
- Avant le passage à une nouvelle leçon, un point de compréhension et l'accord de l'apprenant.

Un **principe POO**, un **idiome C#** et un **design pattern nommé** ne sont pas interchangeables : le cours explique leur rôle et évite d'introduire des abstractions sans besoin.

## 3. Roadmap globale — 7 modules, 25 leçons

**Légende :** ✅ validée ; ◐ clôturée sur les acquis pratiqués (compléments reportés) ; ▶ prochaine ; ○ à venir.

| Module | Leçon | Compétences principales | État |
|---|---|---|---|
| **1. Fondations C# / POO** | **1.1** | Méthodes, paramètres, retours, surcharges, tuples, `out`, nullabilité | ✅ |
| | **1.2** | Chaînes, `Split`, conversions robustes, dates, `StringBuilder` | ◐ |
| | **1.3** | Classes, objets, constructeurs, champs, propriétés, encapsulation, `static`, références, exceptions | ✅ |
| | **1.4** | Relations entre objets, composition, héritage/polymorphisme, interfaces, `record`, DTO et mapping simple | ▶ |
| **2. Collections et traitements** | **2.1** | Tableaux, `List<T>`, `HashSet<T>`, `Dictionary<TKey,TValue>`, `Queue<T>`, génériques | ○ |
| | **2.2** | Lambdas, LINQ, filtrage, tri, projection, agrégations, pagination | ○ |
| | **2.3** | Exceptions approfondies, ressources, `Task`, `async`/`await` | ○ |
| | **2.4** | Mini-projet : analyseur de fichiers CSV | ○ |
| **3. ASP.NET Core Web API** | **3.1** | HTTP/REST, routes, contrôleurs, JSON, OpenAPI | ○ |
| | **3.2** | Services, responsabilités et injection de dépendances | ○ |
| | **3.3** | CRUD, stockage mémoire, Repository si pertinent, durées de vie DI | ○ |
| | **3.4** | CORS, journalisation et logs structurés | ○ |
| **4. Données persistantes** | **4.1** | EF Core, `DbContext`, PostgreSQL, migrations, configuration/secrets | ○ |
| | **4.2** | Relations et persistance asynchrone | ○ |
| | **4.3** | Requêtes efficaces, projections, pagination, `AsNoTracking` | ○ |
| **5. Sécurité backend** | **5.1** | Comptes, validation, hachage des mots de passe, options | ○ |
| | **5.2** | JWT, claims et validation des jetons | ○ |
| | **5.3** | Autorisations, rôles et accès aux ressources | ○ |
| | **5.4** | Refresh tokens et ASP.NET Core Identity | ○ |
| **6. Qualité et tests** | **6.1** | Validation d'API et `ProblemDetails` | ○ |
| | **6.2** | Gestion globale des exceptions et middleware | ○ |
| | **6.3** | Tests automatisés xUnit, AAA et doubles de test | ○ |
| **7. Production** | **7.1** | `BackgroundService`, annulation et traitements différés | ○ |
| | **7.2** | API externes, `HttpClient`, JSON et import/export CSV | ○ |
| | **7.3** | Docker Compose, API + PostgreSQL et livraison locale | ○ |

**À la fin de chaque module :** exercice de consolidation transversal, revue/correction et bilan séparant compréhension conceptuelle, implémentation autonome et lecture/diagnostic.

**Compléments possibles après les 25 leçons :** débogage approfondi, conception/découpage des tickets, CI/CD et déploiement. Ils ne sont **pas** comptabilisés dans les 25 leçons.

## 4. Progression constatée

| Mesure | Situation au 22/10/2026 |
|---|---|
| Parcours global | **3/25 leçons validées ou closes = 12 %** |
| Module 1 | **3/4 leçons = 75 % des leçons** ; consolidation finale non effectuée |
| 1.1 | Validée : 9 exercices réalisés sous l'ancienne cadence |
| 1.2 | Clôturée : 7 exercices réalisés, derniers travaux sur `DateOnly` et `StringBuilder` |
| 1.3 | **Validée** : ticket `DEV-013`, audit de conformité ; compilation et exécution manuelles conformes |
| Prochaine leçon | **1.4 — Relations entre objets, interfaces, `record`, mapping** |

**Leçon 1.3 — vérification pratique :** les deux audits sont créés, les documents et non-conformités correctement comptés, les modifications d'un audit clôturé refusées, les exceptions interceptées et le compteur statique cohérent. `dotnet build` et `dotnet run` ont réussi ; **aucun test automatisé xUnit n'a encore été réalisé**.

**Notions explicitement à consolider :**

- `DateTimeOffset`/UTC : cours présenté, pratique autonome reportée aux horodatages/logs en **3.4** (avec rappel avant exercice).
- `DateTime` avec horaires : approfondissement au premier cas métier approprié.
- `TimeOnly` : non encore enseigné, à introduire avant son premier usage.
- `Guid` : non encore enseigné, à introduire avant les identifiants d'API/entités.
- Collections : seul l'usage élémentaire de `string[]` avec `Split` a été vu ; apprentissage complet en **2.1**.

Ces points **ne sont pas considérés maîtrisés** du seul fait qu'une leçon est close.

## 5. Organisation du dépôt

```text
01-csharp-foundations/
├── FoundationsApp.csproj
├── Program.cs                         # Point d'entrée : lance l'exercice actif
├── README.md
├── Exercices/
│   └── Module01/
│       ├── Ex04NettoyageChaines.cs
│       ├── ...                        # Exercices 1.1 et 1.2
│       ├── Ex10GestionGaranties.cs
│       ├── AuditConformite.cs         # Classe métier du ticket DEV-013
│       └── Ex11AuditConformite.cs     # Scénario de validation du ticket
└── docs/                              # Documentation historique conservée
    ├── 00-bloc-0-environnement-dotnet-git.md
    └── 01-bloc-1-typage-variables-expressions.md
```

Les fichiers indiqués ci-dessus illustrent l'organisation locale **observée pendant la formation** ; certains peuvent encore être non suivis par Git tant qu'ils ne sont pas ajoutés à un commit.

- **Une seule solution / un seul projet console** pour les fondations ; pas de projet par exercice.
- `Exercices/Module01/` regroupe les travaux du module 1. Un dossier `Module02/` sera créé au passage au module 2.
- Les classes métier sont séparées des classes qui exécutent les scénarios.
- Chaque classe de lancement expose `public static void Executer()` ; `Program.cs` appelle uniquement celle de l'exercice actif.
- En module 3, un projet Web API cohérent pourra être ajouté pour être développé jusqu'au module 7.

### Compiler et exécuter

À la racine du projet :

```powershell
dotnet --version
dotnet build
dotnet run
```

Le résultat de `dotnet run` dépend de la méthode `Executer()` appelée par `Program.cs`. **Changer l'exercice actif ne supprime pas les exercices précédents.**

## 6. Git et documentation

Le dépôt est versionné sur GitHub. Les commandes usuelles :

```powershell
git status
git diff
git add <fichier>
git diff --cached
git commit -m "feat: terminer une lecon"
git push origin main
```

**Cadence adoptée :** un commit groupé par leçon terminée, après vérification des fichiers à enregistrer. Ne pas confondre **validation pédagogique** et **commit déjà créé / poussé**.

Documentation antérieure toujours utile :

- [Environnement .NET et Git/GitHub](docs/00-bloc-0-environnement-dotnet-git.md)
- [Typage, variables et expressions](docs/01-bloc-1-typage-variables-expressions.md)

Jalons Git historiques déjà consignés dans la version précédente du README :

```text
666cdf7 Initialize C# foundations project
4679fe5 Complete C# foundations block 1 consolidation
```

Leçon 1.1 du parcours actuel : commit `fe46d23` précédemment confirmé. **Les commits des leçons 1.2 et 1.3 restent à confirmer dans Git** après leur création et leur envoi.

## 7. Prochaine étape

**Leçon 1.4 :** comprendre visuellement et en code professionnel les relations et responsabilités entre objets, la composition, l'héritage et le polymorphisme lorsque pertinents, les interfaces, les `record`, les DTO et le mapping. Puis réaliser **un exercice principal inédit**, avant la consolidation générale du module 1.

Le fil rouge **ResourceFlow** avait été envisagé dans l'ancienne roadmap, mais son lancement n'est **pas confirmé** dans le parcours actuel. Tout projet fil rouge reste distinct des exercices, avec un périmètre à définir avant son démarrage.
