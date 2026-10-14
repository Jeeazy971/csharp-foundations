
public class Program
{
    public static void Main(string[] args)
    {
        int employeA = CalculerScore(7);

        int employeB = CalculerScore(
            colisTraites: 9,
            bonus: 6
        );

        AfficherScores(employeA, employeB);
    }

    static int CalculerScore(int colisTraites)
        => colisTraites * 4;

    static int CalculerScore(int colisTraites, int bonus)
    {
        return CalculerScore(colisTraites) + bonus;
    }

    static void AfficherScores(int scoreA, int scoreB)
    {
        Console.WriteLine($"Employé A : {scoreA} points");
        Console.WriteLine($"Employé B : {scoreB} points");
    }
}
