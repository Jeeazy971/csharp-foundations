public class Ex01Tuples
{
    public static void Executer()
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
        return (
            nombrePieces * grammesParPiece,
            nombrePieces * minutesParPiece
        );
    }
}