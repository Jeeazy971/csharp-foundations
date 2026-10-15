
public class Program
{
    public static void Main(string[] args)
    {
        int nombrePieces = 6;
        int grammesParPiece = 14;
        int minutesParPiece = 9;

        var production = CalculerProduction(
            nombrePieces,
            grammesParPiece,
            minutesParPiece
        );

        Console.WriteLine($"Production : {nombrePieces} pièces");
        Console.WriteLine($"Matériau nécessaire : {production.grammesTotaux} grammes");
        Console.WriteLine($"Temps total d'impression : {production.minutesTotales} minutes");
    }

    static (int grammesTotaux, int minutesTotales) CalculerProduction(
        int nombrePieces,
        int grammesParPiece,
        int minutesParPiece)
    {
        int grammesTotaux = nombrePieces * grammesParPiece;
        int minutesTotales = nombrePieces * minutesParPiece;

        return (grammesTotaux, minutesTotales);
    }
}
