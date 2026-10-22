using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FoundationsApp.Exercices.Module01
{
    public class Ex08SupervisionServeurs
    {
        public static void Executer()
        {
            string srvA = " srv-api-01 ; 92 ; 93.5 ";
            string srvB = " srv-cache-02 ; 92 ; 60.0 ";
            string srvC = " srv-db-03 ; 70 ; 97.0 ";
            string srvD = " srv-web-04 ; inconnu ; 70.5 ";
            string srvE = " srv-batch-05 ; 85 ; 98,5 ";
            string srvF = " srv-legacy-06 ; 50 ";
            string srvG = "   ; 30 ; 40.0 ";
            string srvH = " srv-edge-07 ; -5 ; 95.0 ";

            AnalyserReleve("A", srvA);
            AnalyserReleve("B", srvB);
            AnalyserReleve("C", srvC);
            AnalyserReleve("D", srvD);
            AnalyserReleve("E", srvE);
            AnalyserReleve("F", srvF);
            AnalyserReleve("G", srvG);
            AnalyserReleve("H", srvH);
            
        }

        public static void AnalyserReleve(string lettreServeur, string chaineServeurBrute)
        {
            string[] serveurSplit = chaineServeurBrute.Split(";", StringSplitOptions.TrimEntries);

            if (serveurSplit.Length != 3)
            {
                Console.WriteLine($"Serveur {lettreServeur} : format invalide");
            }
            else
            {
                string idServeur = serveurSplit[0];

                if (string.IsNullOrWhiteSpace(idServeur))
                {
                    Console.WriteLine($"Serveur {lettreServeur} : identifiant manquant");
                }
                else
                {
                    string proccesseurString = serveurSplit[1];
                    string pourcentageDisqueString = serveurSplit[2];

                    bool processeurConverti = int.TryParse(proccesseurString, out int processeur);
                    bool pourcentageDisqueConverti = decimal.TryParse(pourcentageDisqueString, 
                                                     NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, 
                                                     out decimal pourcentageDisque);

                    bool conversionReussie = processeurConverti && pourcentageDisqueConverti;

                    if (conversionReussie)
                    {
                        if((processeur >= 0 && processeur <= 100) && (pourcentageDisque >= 0 && pourcentageDisque <= 100))
                        {
                            string interventionPrioritaire = EstEnAlerte(processeur, pourcentageDisque) ? "alerte prioritaire" : "normal";
                            Console.WriteLine($"Serveur {lettreServeur} : {idServeur.ToUpperInvariant()} - {interventionPrioritaire}");
                        }
                        else
                        {
                            Console.WriteLine($"Serveur {lettreServeur} : valeurs hors limites");

                        }
                    }
                    else
                    {
                            Console.WriteLine($"Serveur {lettreServeur} : données numériques invalides");
                    }
                }
            }
        }

        public static bool EstEnAlerte(int processeur, decimal disque)
        {
            return processeur >= 80 && disque >= 90m;
        }
    }
}
