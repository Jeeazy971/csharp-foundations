

public class Program
{
    public static void Main(string[] args)
    {
        int distanceParcourue = CalculerDistance(4, 350);
        Console.WriteLine($"Distance parcourue : {distanceParcourue} mètres");

    }
    
    static int CalculerDistance(int nombreTours, int metresParTour)
    {
        int totalDistance = metresParTour * nombreTours;
        return totalDistance;
    }
    
}
