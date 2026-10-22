using System;

namespace FoundationsApp.Exercices.Module01
{
    public class Ex11AuditConformite
    {
        public static void Executer()
        {
            // 1. Création des deux audits
            AuditConformite auditA = new AuditConformite("  AUD-401  ");
            AuditConformite auditB = new AuditConformite("AUD-402");

            // 2. Enregistrement des premiers documents
            auditA.VerifierDocument(true);  // Document 1 : Conforme
            auditA.VerifierDocument(false); // Document 2 : Non conforme

            auditB.VerifierDocument(true);  // Document 1 : Conforme

            // 3. Deuxième variable référençant le même objet (Audit A) pour le 3e document
            AuditConformite memeAuditA = auditA;
            memeAuditA.VerifierDocument(false); // Document 3 : Non conforme

            // 4. Clôture uniquement de l'audit A
            auditA.Terminer();

            // 5. Affichage du rapport des audits
            Console.WriteLine("=== RAPPORT DES AUDITS QUALIVIS ===");
            AfficherLigneAudit(auditA);
            AfficherLigneAudit(auditB);
            Console.WriteLine();

            // 6. Test de la méthode statique avec une référence vide
            bool refVideValide = AuditConformite.EstReferenceValide("   ");
            Console.WriteLine($"Test référence vide : {refVideValide}");

            // 7. Scénario d'erreur 1 : enregistrer un document après la clôture
            try
            {
                auditA.VerifierDocument(true);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ajout refusé : {ex.Message}");
            }

            // 8. Scénario d'erreur 2 : créer un audit avec une référence vide
            try
            {
                AuditConformite auditInvalide = new AuditConformite("   ");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Création refusée : {ex.Message}");
            }

            Console.WriteLine();

            // 9. Affichage du compteur statique
            Console.WriteLine($"Nombre total d'audits créés : {AuditConformite.NombreAuditsCrees}");
        }

        private static void AfficherLigneAudit(AuditConformite audit)
        {
            string motDocument = audit.NombreDocuments > 1 ? "documents" : "document";
            string motNonConforme = audit.NombreNonConformes > 1 ? "non conformes" : "non conforme";

            Console.WriteLine(
                $"Audit {audit.Reference} : {audit.NombreDocuments} {motDocument}, {audit.NombreNonConformes} {motNonConforme}, terminé : {audit.EstTermine}"
            );
        }
    }
}