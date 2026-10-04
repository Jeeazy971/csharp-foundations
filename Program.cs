Console.WriteLine("Batch review started");

ProcessBatch("Batch-A", 120, 8, 10);
ProcessBatch("Batch-B", 95, 12, 10);
ProcessBatch("Batch-C", 70, 10, 10);

Console.WriteLine("Batch review completed");



static int CalculateAcceptedLines(int receivedLines, int rejectedLines)
{
    return receivedLines - rejectedLines;
}


static string GetBatchStatus(int rejectedLines, int rejectionLimit)
{
    if (rejectedLines <= rejectionLimit)
    {
        return "Valid";
    }
    else
    {
        return "Review required";
    }
}

static void DisplayResult(string batchName, int acceptedLines, string validated)
{
    Console.WriteLine($"{batchName} - Accepted: {acceptedLines} - Status: {validated}");
}

static void ProcessBatch(
    string batchName,
    int receivedLines,
    int rejectedLines,
    int rejectionLimit)
{
    int acceptedLines = CalculateAcceptedLines(receivedLines, rejectedLines);

    string status = GetBatchStatus(rejectedLines, rejectionLimit);

    DisplayResult(batchName, acceptedLines, status);
}
