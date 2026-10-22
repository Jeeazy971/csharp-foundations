
using System;

namespace FoundationsApp.Exercices.Module01
{
    public class Ex06DebogageEtiquettes
    {
        public static void Executer()
        {
            string reference = "FRAGILE-VERRE";

            ControlerColis("A", "  fragile.verre  ", reference);
            ControlerColis("B", "fragile_papier", reference);
            ControlerColis("C", "   ", reference);
            ControlerColis("D", " FRAGILE.VERRE ", reference);
        }

        public static void ControlerColis(
            string nom,
            string etiquette,
            string reference)
        {
            if (string.IsNullOrWhiteSpace(etiquette))
            {
                Console.WriteLine(
                    $"Colis {nom} : étiquette manquante"
                );
            }
            else
            {
                string nettoyee = NormaliserEtiquette(etiquette);
                
                bool conforme = string.Equals(
                    nettoyee,
                    reference,
                    StringComparison.OrdinalIgnoreCase
                );

                string statut = conforme
                    ? "conforme"
                    : "non conforme";

                Console.WriteLine(
                    $"Colis {nom} : {nettoyee} - {statut}"
                );
            }
        }

        public static string NormaliserEtiquette(string etiquette)
        {
            return etiquette.Trim()
                            .Replace(".", "-")
                            .Replace("_", "-")
                            .ToUpperInvariant();
        }
    }
}
