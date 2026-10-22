using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FoundationsApp.Exercices.Module01
{
    public class Ex10GestionGaranties
    {
        public static void Executer()
        {
            string dateA = "24/10/2026";
            string dateB = "31/02/2026";
            string dateC = "28/12/2026";

            string dossierA = "A";
            string dossierB = "B";
            string dossierC = "C";

            int dureeGarantieA = 30;
            int dureeGarantieB = 15;
            int dureeGarantieC = 10;

            StringBuilder rapport = new StringBuilder();
            rapport.AppendLine("=== RAPPORT DES GARANTIES SAV ===");
            rapport.AppendLine(AnalyserDossier(dossierA, dateA, dureeGarantieA));
            rapport.AppendLine(AnalyserDossier(dossierB, dateB, dureeGarantieB));
            rapport.AppendLine(AnalyserDossier(dossierC, dateC, dureeGarantieC));

            string resultat = rapport.ToString();

            Console.WriteLine(resultat);
        }

        public static string AnalyserDossier(string lettreDuDossier, string dateDebut, int dureeGarantie)
        {
            bool dateOk = DateOnly.TryParseExact(dateDebut, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly date);

            if(!dateOk)
            {
                return $"Dossier {lettreDuDossier} : date invalide";
            }
            else
            {
                date = date.AddDays(dureeGarantie);
                return $"Dossier {lettreDuDossier} : date limite {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}";
            }
            
        }
    }
}
