using System;
using System.Collections.Generic;
using System.Threading;

class Calls
{
    static void Main()
    {
        Queue<string> callQueue = new Queue<string>();

        // Adding calls to the queue
        callQueue.Enqueue("Call 1");
        callQueue.Enqueue("Call 2");
        callQueue.Enqueue("Call 3");

        Random random = new Random();

        Console.WriteLine("Processing calls in the call center:");

        while (callQueue.Count > 0)
        {
            string currentCall = callQueue.Dequeue();
            int processingTime = random.Next(1, 6); // Random time between 1 and 5 seconds

            Console.WriteLine($"{currentCall} is being processed...");
            Thread.Sleep(processingTime * 1000); // Simulate processing time
            Console.WriteLine($"{currentCall} finished processing in {processingTime} seconds.");
        }

        Console.WriteLine("All calls have been processed.");
    }
}


