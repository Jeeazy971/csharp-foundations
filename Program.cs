
public class Program
{
    public static void Main(string[] args)
    {
        int standard = CalculerDuree(3);
        int avecControle = CalculerDuree(4, 5);

        Console.WriteLine($"Standard : {standard} minutes");
        Console.WriteLine($"Avec contrôle : {avecControle} minutes");
    }

    static int CalculerDuree(int nombreDossiers)
        => nombreDossiers * 7;

    static int CalculerDuree(int nombreDossiers, int minutesControle)
        => CalculerDuree(nombreDossiers) + minutesControle;
}
