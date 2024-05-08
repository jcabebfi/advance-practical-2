using System;
using System.Threading;

public class NumberProcessor
{
    public void ProcessNumber(int number)
    {
        // Simulate a time-consuming operation by sleeping for a random time between 1 to 5 seconds
        Random random = new Random();
        int sleepTime = random.Next(1, 6) * 1000; // Convert seconds to milliseconds
        Console.WriteLine($"Processing number {number}. Sleeping for {sleepTime / 1000} seconds.");
        Thread.Sleep(sleepTime);
    }



    public static void Main()
    {
        NumberProcessor processor = new NumberProcessor();
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        foreach (int num in numbers)
        {
            Thread thread = new Thread(() => processor.ProcessNumber(num));
            thread.Start();
        }
    }
}

