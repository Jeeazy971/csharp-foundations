using System;
using System.Globalization;

namespace FoundationsApp.Exercices.Module01
{
    public class Ex09DebogageExpeditions
    {
        public static void Executer()
        {
            AnalyserEnvoi("A", "  exp-41 ; 3 ; 12.50  ");
            AnalyserEnvoi("B", " exp-42 ; 7 ; 15.00 ");
            AnalyserEnvoi("C", " exp-43 ; 2 ; 24.00 ");
            AnalyserEnvoi("D", " exp-44 ; inconnu ; 12.00 ");
            AnalyserEnvoi("E", " exp-45 ; 2 ; 9,50 ");
            AnalyserEnvoi("F", " exp-46 ; 3 ; 12.00 ; EXPRESS ");
            AnalyserEnvoi("G", "   ; 2 ; 8.00 ");
            AnalyserEnvoi("H", " exp-48 ; 0 ; 8.00 ");
            AnalyserEnvoi("I", " exp-49 ; 5 ; 20.00 ");
        }

        public static void AnalyserEnvoi(
            string lettre,
            string ligneBrute)
        {
            string[] champs = ligneBrute.Split(';', StringSplitOptions.TrimEntries);

            if (champs.Length != 3)
            {
                Console.WriteLine(
                    $"Expédition {lettre} : format invalide"
                );
            }
            else if (string.IsNullOrWhiteSpace(champs[0]))
            {
                Console.WriteLine(
                    $"Expédition {lettre} : référence manquante"
                );
            }
            else
            {
                bool colisValides = int.TryParse(
                    champs[1],
                    out int nombreColis
                );

                bool poidsValide = decimal.TryParse(
                    champs[2],
                    NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture,
                    out decimal poids
                );

                if (colisValides && poidsValide)
                {
                    if (nombreColis < 1 || poids <= 0m)
                    {
                        Console.WriteLine(
                            $"Expédition {lettre} : valeurs hors limites"
                        );
                    }
                    else
                    {
                        bool standard = EstEnvoiStandard(
                            nombreColis,
                            poids
                        );


                        string statut = standard
                            ? "standard"
                            : "traitement spécial";

                        Console.WriteLine(
                            $"Expédition {lettre} : {champs[0].ToUpperInvariant()} - {statut}"
                        );
                    }
                }
                else
                {
                    Console.WriteLine(
                        $"Expédition {lettre} : données numériques invalides"
                    );
                }
            }
        }

        public static bool EstEnvoiStandard(
            int nombreColis,
            decimal poids)
        {
            return nombreColis <= 5 && poids <= 20m;
        }
    }
}