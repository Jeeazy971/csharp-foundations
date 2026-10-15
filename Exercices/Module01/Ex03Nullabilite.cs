
public class Ex03Nullabilite
{
    public static void Executer()
    {
        int? temperatureA = 0;
        int? temperatureB = null;
        string? codeCapteur = null;

        AfficherTemperature("A", temperatureA);
        AfficherTemperature("B", temperatureB);

        int? longueurCode = codeCapteur?.Length;

        Console.WriteLine(
            $"Longueur du code : {longueurCode?.ToString() ?? "absente"}");
    }

    static void AfficherTemperature(string nom, int? temperature)
    {
        if (temperature is null)
        {
            Console.WriteLine($"Capteur {nom} : mesure absente");
        }
        else
        {
            Console.WriteLine($"Capteur {nom} : {temperature} °C");
        }
    }
}
