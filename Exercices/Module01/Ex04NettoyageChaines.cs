using System;

namespace FoundationsApp.Exercices.Module01
{
    public class Ex04NettoyageChaines
    {
        public static void Executer()
        {
            string codeReference = "PASS-VIP";

            string badgeA = "  pass.vip  ";
            string badgeB = "   ";
            string badgeC = " Pass.Basic ";

            // --- BADGE A ---
            if (string.IsNullOrWhiteSpace(badgeA))
            {
                Console.WriteLine("Badge A : code manquant");
            }
            else
            {
                string propreA = NettoyerCode(badgeA);
                string statutA = EstBadgeAutorise(propreA, codeReference) ? "autorisé" : "non autorisé";
                Console.WriteLine($"Badge A : {propreA.ToUpperInvariant()} - {statutA}");
            }

            // --- BADGE B ---
            if (string.IsNullOrWhiteSpace(badgeB))
            {
                Console.WriteLine("Badge B : code manquant");
            }
            else
            {
                string propreB = NettoyerCode(badgeB);
                string statutB = EstBadgeAutorise(propreB, codeReference) ? "autorisé" : "non autorisé";
                Console.WriteLine($"Badge B : {propreB.ToUpperInvariant()} - {statutB}");
            }

            // --- BADGE C ---
            if (string.IsNullOrWhiteSpace(badgeC))
            {
                Console.WriteLine("Badge C : code manquant");
            }
            else
            {
                string propreC = NettoyerCode(badgeC);
                string statutC = EstBadgeAutorise(propreC, codeReference) ? "autorisé" : "non autorisé";
                Console.WriteLine($"Badge C : {propreC.ToUpperInvariant()} - {statutC}");
            }
        }

        public static string NettoyerCode(string code)
        {
            return code.Trim().Replace(".", "-");
        }

        public static bool EstBadgeAutorise(string nettoyageCode, string referenceCode)
        {
            return string.Equals(nettoyageCode, referenceCode, StringComparison.OrdinalIgnoreCase);
        }
    }
}