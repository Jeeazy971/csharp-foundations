
using System;

namespace FoundationsApp.Exercices.Module01
{
    public class AuditConformite
    {
        private int _nombreNonConformes;

        public string Reference { get; }

        public int NombreDocuments { get; private set; }

        public int NombreNonConformes
        {
            get
            {
                return _nombreNonConformes;
            }
        }

        public bool EstTermine { get; private set; }

        public static int NombreAuditsCrees { get; private set; }

        public AuditConformite(string reference)
        {
            if (!EstReferenceValide(reference))
            {
                throw new ArgumentException("référence obligatoire.");
            }

            Reference = reference.Trim();
            NombreDocuments = 0;
            _nombreNonConformes = 0;
            EstTermine = false;

            NombreAuditsCrees += 1;
        }

        public static bool EstReferenceValide(string reference)
        {
            return !string.IsNullOrWhiteSpace(reference);
        }

        public void VerifierDocument(bool estConforme)
        {
            if (EstTermine)
            {
                throw new InvalidOperationException("Audit terminé.");
            }

            NombreDocuments += 1;

            if (!estConforme)
            {
                _nombreNonConformes += 1;
            }
        }

        public void Terminer()
        {
            if (EstTermine)
            {
                throw new InvalidOperationException(
                    "Audit déjà terminé.");
            }

            EstTermine = true;
        }
    }
}
