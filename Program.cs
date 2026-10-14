
public class Program
{
    public static void Main(string[] args)
    {
        int restantes = CalculerPlacesRestantes(40, 9);
        AfficherPlaces(restantes);
    }

    static int CalculerPlacesRestantes(int capacite, int reservees)
    {
        return capacite - reservees;
    }

    static void AfficherPlaces(int nombre)
    {
        Console.WriteLine($"Places restantes : {nombre}");
    }
}
