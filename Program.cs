

public class Program
{
    public static void Main(string[] args)
    {
        int sousTotal = CalculerSousTotal(3, 12);
        int total = CalculerTotal(sousTotal, 5);
        AfficherCommande(sousTotal, total);

    }
    
    static int CalculerSousTotal(int quantite, int prixUnitaire)
    {
        return quantite * prixUnitaire;
    }

    static int CalculerTotal(int sousTotal, int livraison)
    {
        return sousTotal + livraison;
    }


    static void AfficherCommande(int sousTotal, int total)
    {
        Console.WriteLine($"Sous-total : {sousTotal} €");
        Console.WriteLine($"Total avec livraison : {total} €");
    }

}
