
using System;

namespace FoundationsApp.Exercices.Module01
{
    public class Ex05QualificationTickets
    {
        public static void Executer()
        {
            string objetReference = "PANNE GENERALE";
            string serviceReference = "TECHNIQUE";

            string objetA = "  panne_generale  ";
            string serviceA = " Technique ";

            string objetB = " PANNE_GENERALE ";
            string serviceB = " Commercial ";

            string objetC = "    ";
            string serviceC = " Technique ";

            string objetD = " incident_reseau ";
            string serviceD = " technique ";

            // Ticket A
            if (string.IsNullOrWhiteSpace(objetA))
            {
                Console.WriteLine("Ticket A : objet manquant");
            }
            else
            {
                string objetNettoye = NettoyerObjet(objetA);
                string serviceNettoye = serviceA.Trim();

                bool critique = EstTicketCritique(
                    objetNettoye, serviceNettoye,
                    objetReference, serviceReference
                );

                string statut = critique ? "critique" : "non critique";

                Console.WriteLine(
                    $"Ticket A : {objetNettoye.ToUpperInvariant()} / {serviceNettoye.ToUpperInvariant()} - {statut}"
                );
            }

            // Ticket B
            if (string.IsNullOrWhiteSpace(objetB))
            {
                Console.WriteLine("Ticket B : objet manquant");
            }
            else
            {
                string objetNettoye = NettoyerObjet(objetB);
                string serviceNettoye = serviceB.Trim();

                bool critique = EstTicketCritique(
                    objetNettoye, serviceNettoye,
                    objetReference, serviceReference
                );

                string statut = critique ? "critique" : "non critique";

                Console.WriteLine(
                    $"Ticket B : {objetNettoye.ToUpperInvariant()} / {serviceNettoye.ToUpperInvariant()} - {statut}"
                );
            }

            // Ticket C
            if (string.IsNullOrWhiteSpace(objetC))
            {
                Console.WriteLine("Ticket C : objet manquant");
            }
            else
            {
                string objetNettoye = NettoyerObjet(objetC);
                string serviceNettoye = serviceC.Trim();

                bool critique = EstTicketCritique(
                    objetNettoye, serviceNettoye,
                    objetReference, serviceReference
                );

                string statut = critique ? "critique" : "non critique";

                Console.WriteLine(
                    $"Ticket C : {objetNettoye.ToUpperInvariant()} / {serviceNettoye.ToUpperInvariant()} - {statut}"
                );
            }

            // Ticket D
            if (string.IsNullOrWhiteSpace(objetD))
            {
                Console.WriteLine("Ticket D : objet manquant");
            }
            else
            {
                string objetNettoye = NettoyerObjet(objetD);
                string serviceNettoye = serviceD.Trim();

                bool critique = EstTicketCritique(
                    objetNettoye, serviceNettoye,
                    objetReference, serviceReference
                );

                string statut = critique ? "critique" : "non critique";

                Console.WriteLine(
                    $"Ticket D : {objetNettoye.ToUpperInvariant()} / {serviceNettoye.ToUpperInvariant()} - {statut}"
                );
            }
        }

        public static string NettoyerObjet(string objet)
        {
            return objet.Trim().Replace("_", " ");
        }

        public static bool EstTicketCritique(
            string objetNettoye,
            string serviceNettoye,
            string objetReference,
            string serviceReference)
        {
            bool objetValide = string.Equals(
                objetNettoye,
                objetReference,
                StringComparison.OrdinalIgnoreCase
            );

            bool serviceValide = string.Equals(
                serviceNettoye,
                serviceReference,
                StringComparison.OrdinalIgnoreCase
            );

            return objetValide && serviceValide;
        }
    }
}
