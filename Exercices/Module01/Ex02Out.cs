using System;

public class Ex02Out
{
    public static void Executer()
    {
        bool dossierA = EssayerCalculerMoyenne(14, 18, out int moyenneA);
        bool dossierB = EssayerCalculerMoyenne(12, 24, out int moyenneB);

        Console.WriteLine($"Dossier A : {(dossierA ? $"moyenne {moyenneA}/20" : "notes invalides")}");
        Console.WriteLine($"Dossier B : {(dossierB ? $"moyenne {moyenneB}/20" : "notes invalides")}");
    }

    public static bool EssayerCalculerMoyenne(int note1, int note2, out int moyenne)
	{
		if (note1 >= 0 && note1 <= 20 && note2 >= 0 && note2 <= 20)
		{
			moyenne = (note1 + note2) / 2;
			return true;
		}
		else
		{
            moyenne = 0;
            return false;
        }

		
	}
}
