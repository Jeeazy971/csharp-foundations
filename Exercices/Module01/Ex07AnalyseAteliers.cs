using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FoundationsApp.Exercices.Module01
{
    public class Ex07AnalyseAteliers
    {
        public static void Executer()
        {
            string atelierA = "  atelier-peinture | 8 | 12.50 ";
            string atelierB = " atelier-musique | 0 | 0.00 ";
            string atelierC = " atelier-danse | 3 | 12,50 ";
            string atelierD = " atelier-photo | 5 ";
            string atelierE = "  | 4 | 9.50 ";

            AnalyserLigne("A", atelierA);
            AnalyserLigne("B", atelierB);
            AnalyserLigne("C", atelierC);
            AnalyserLigne("D", atelierD);
            AnalyserLigne("E", atelierE);
        }

        public static void AnalyserLigne(string nomDuDossier, string ligneBrute)
        {
            string[] atelier = ligneBrute.Split("|", StringSplitOptions.TrimEntries);

            if(atelier.Length != 3)
            {
                Console.WriteLine($"Atelier {nomDuDossier} : format invalide");
            }
            else if (string.IsNullOrWhiteSpace(atelier[0]))
            {
                Console.WriteLine($"Atelier {nomDuDossier} : identifiant manquant");
            }
            else
            {
                bool placesConverti = int.TryParse(atelier[1], out int places);
                bool tarifsConverti = decimal.TryParse(atelier[2], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal tarifs);

                if(placesConverti && tarifsConverti)
                {
                    string reservable = (places >= 1 && tarifs <= 15.00m) ? "réservable" : "non réservable";
                    string titreAtelier = atelier[0];
                    Console.WriteLine($"Atelier {nomDuDossier} : {titreAtelier.ToUpperInvariant()} - {reservable}");
                }
                else
                {
                    Console.WriteLine($"Atelier {nomDuDossier} : données numériques invalides");
                }
            }
        }

    }
}
