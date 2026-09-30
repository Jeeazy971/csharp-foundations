int? estimatedDelay = 4;
int? unknownDelay = null;

bool hasValueExist = estimatedDelay.HasValue;
int getEstimatedDelay = estimatedDelay.GetValueOrDefault();
int estimatedDelayValue = estimatedDelay.Value;

Console.WriteLine(hasValueExist);
Console.WriteLine(getEstimatedDelay);
Console.WriteLine(estimatedDelayValue);

bool hasUnknownDelayExist = unknownDelay.HasValue;
int getUnknownDelay = unknownDelay.GetValueOrDefault();

Console.WriteLine(hasUnknownDelayExist);
Console.WriteLine(getUnknownDelay);

// int dangerousValue = unknownDelay.Value;

/*
1. Est-ce que cette ligne compilerait si elle était décommentée ? oui

2. Que se passerait-il à l'exécution et pourquoi ? une erreur runtime seriviendrai car unknownDelay est null (absence de valeur).

3. Pourquoi le 0 obtenu avec GetValueOrDefault()
   ne signifie-t-il pas forcément "zéro jour de retard" ? GetValueOrDefault() retourne la valeur par défaut de int, donc 0, lorsque le nullable contient null. Ce 0 ne signifie pas qu'il y avait réellement zéro jour de retard : la donnée métier était absente.
*/