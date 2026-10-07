

public class Program
{
    public static void Main(string[] args)
    {
       int requestCount = 6;
       int slowLimit = 20;
       int criticalLimit = 30;

        AnalyzeRequests(requestCount, slowLimit, criticalLimit);

    }

    static int GetProcessingTime(int numberAsk)
    {
        int getTime = numberAsk switch
        {
            1 => 12,
            2 => 18,
            3 => 9,
            4 => 31,
            5 => 22,
            6 => 14,
            _ => 0
        };

        return getTime;
    }

    static bool IsValidRequestCount(int requestCount)
    {
        if (requestCount > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static int CountSlowRequests(int requestCount, int slowLimit)
    {
        int count = 0;

        for (int i = 1; i <= requestCount; i++)
        {
            if (GetProcessingTime(i) > slowLimit)
            {
                count++;
            }
        }

        return count;
    }

    static int CalculateTotalProcessingTime(int requestCount)
    {
        int totalTime = 0;

        for (int i = 1; i <= requestCount; i++)
        {
            int processingTime = GetProcessingTime(i);
            totalTime += processingTime;
        }

        return totalTime;
    }

    static int FindFirstCriticalRequest(int requestCount, int criticalLimit)
    {
        for (int i = 1; i <= requestCount; i++)
        {
            int askTime = GetProcessingTime(i);

            if (askTime > criticalLimit)
            {
                return i;
            }
        }

        return 0;
    }

    static void AnalyzeRequests(int requestCount, int slowLimit, int criticalLimit)
    {
        if (!IsValidRequestCount(requestCount))
        {
            Console.WriteLine("Invalid request count");
            return;
        }

        Console.WriteLine("Processing audit started");
        int countSlowRequests = CountSlowRequests(requestCount, slowLimit);
        Console.WriteLine($"Requests analyzed: {requestCount}");
        Console.WriteLine($"Slow requests: {countSlowRequests}");
        int calculateTotalProcessing = CalculateTotalProcessingTime(requestCount);
        Console.WriteLine($"Total processing time: {calculateTotalProcessing} s");
        int findFirstCritical = FindFirstCriticalRequest(requestCount, criticalLimit);
        Console.WriteLine($"First critical request: #{findFirstCritical}");
        Console.WriteLine("Processing audit completed");
        
    }
}
