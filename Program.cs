
public class Program
{
    public static void Main(string[] args)
    {
        int commandeA = CalculerPieces(4, 6);
        int commandeB = CalculerPieces(
                        reserve: 5,
                        nombreKits: 3,
                        piecesParKit: 8
                    );

        AfficherCommandes(commandeA: commandeA, commandeB: commandeB);
    }

    static int CalculerPieces(int nombreKits, 
        int piecesParKit, 
        int reserve = 0)
    {
        return nombreKits * piecesParKit + reserve;
    }


    static void AfficherCommandes(int commandeA, int commandeB)
    {
        Console.WriteLine($"Commande A : {commandeA} pièces");
        Console.WriteLine($"Commande B : {commandeB} pièces");
    }
}
