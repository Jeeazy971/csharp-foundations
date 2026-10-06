

public class Program
{
    public static void Main(string[] args)
    {
        int availableOperators = 6;
        string rawSeverity = " critical ";
        decimal latencyMs = 182.5m;
        int waitingMinutes = 18;

        Console.WriteLine("Network monitoring started");

        DisplayIncidentReference(1042);
        DisplayIncidentReference("NET-1042");
        bool hasSeverity = TryNormalizeSeverity(rawSeverity, out string normalizedSeverity);
        Console.WriteLine($"Severity parsing: {hasSeverity} - {normalizedSeverity}");
        Console.WriteLine($"Operators before: {availableOperators}");
        bool isAssign = AssignOperator(ref availableOperators);
        Console.WriteLine($"Assignment: {isAssign}");
        Console.WriteLine($"Operators after: {availableOperators}");
        string getStatus = GetEscalationStatus(waitingMinutes);
        string getSecondStatus = GetEscalationStatus(waitingMinutes, 22);
        Console.WriteLine($"Default threshold: {getStatus}");
        Console.WriteLine($"Custom threshold: {getSecondStatus}");
        DisplayLatency(latencyMs);
        Console.WriteLine("Network monitoring completed");



    }
    static string GetEscalationStatus(int numberOfMinutesWaitTimes, int limitWait = 15)
    {
        if (numberOfMinutesWaitTimes > limitWait)
        {
            return "Escalate";
        }
        
        return "Within limit";
    }

    static void DisplayIncidentReference(int reference)
    {
        Console.WriteLine($"Incident #{reference}");
    }

    static void DisplayIncidentReference(string reference)
    {
        Console.WriteLine($"Incident {reference}");
    }


    static bool TryNormalizeSeverity(string value, out string newValue)
    {
        string cleanValue = value.Trim().ToUpper();
        bool containsValue = cleanValue == "NORMAL" ||
                                cleanValue == "WARNING" ||
                                cleanValue == "CRITICAL";

        if (containsValue)
        {
            newValue = cleanValue;
            return true;
        }
        else
        {
            newValue = "UNKNOWN";
            return false;
        }
    }

    static bool AssignOperator(ref int availableOperator)
    {
        if (availableOperator > 0)
        {
            availableOperator--;
            return true;
        }

        return false;
    }

    static void DisplayLatency(in decimal latencyMs)
    {
        Console.WriteLine($"Latency: {latencyMs} ms");
    }
}
