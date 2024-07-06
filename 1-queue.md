# Queue

Queue is the most basic process by which data can flow. It follows the principle of "First in, First Out" (FIFO) which is often used in our everday lives. While it is hard to visualize with specific program examples, you can often find examples of queue in real life.

- In fast food, whatever food is put in the freezer first is the first to be taken out.
- Cashiers will ehlp the person that enters their lane first, scan all their items, and then move on to the next person.
- A printer will always print the project that was sent first before moving on to the next project
- Web servers often use queue to manage certain request from clents. Their input is added to a queue and processes based on the order they were received.

## Basic Opperations

Queue as 3 basic opperations. Enqueue, Dequeue, and Peek. 


### Enqueue

Enqueue is to add something to the end of the queue.

***Small picture/diagram***

In code, enqueue looks likes this:

```csharp 
class example 
{
    public static void Main()
    {
        //Creating a Queue
        Queue myQueue = new Queue();

        //Using Enqueue to add elements to queue
        myQueue.Enqueue("one");
        Console.Write("Total number of elements in the Queue are: ");
        Console.WriteLine(myQueue.Count);
        myQueue.Enqueue("two");
        Console.Write("Total number of elements in the Queue are: ");
        Console.WriteLine(myQueue.Count);

    }
}
```
##### Output
Total number of elements in Queue are: 1
Total number of elements in Queue are: 2



### Dequeue

Dequeue returns the value of the top of the queue and removes that value from the queue. 

```csharp
class example {
  
    public static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue(3);
        queue.Enqueue(2);
        queue.Enqueue(1);
        queue.Enqueue("Four");
  
        Console.WriteLine("Number of elements in the Queue: {0}",
                                                    queue.Count);
  
        // Retrieveing top element of queue
        Console.WriteLine("Top element of queue is:");
        Console.WriteLine(queue.Dequeue());
  
        // printing the no of queue element 
        // after dequeue operation
        Console.WriteLine("Number of elements in the Queue: {0}",
                                                    queue.Count);
}
```

##### Output
Number of elements in the Queue: 4
Top element of queue is: 3
Number of elements in the Queue: 3



### Peek

Peek is very similar to dequeue. It returns the value of the 1st thing in queue but then doesn't remove that value from the queue.

```csharp
class example {
  
    public static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue(3);
        queue.Enqueue(2);
        queue.Enqueue(1);
        queue.Enqueue("Four");
  
        Console.WriteLine("Number of elements in the Queue: {0}",
                                                    queue.Count);
  
        // Retrieveing top element of queue
        Console.WriteLine("Top element of queue is:");
        Console.WriteLine(queue.Peek());
  
        // printing the no of queue element 
        // after dequeue operation
        Console.WriteLine("Number of elements in the Queue: {0}",
                                                    queue.Count);
    }
}
```

##### Output
Number of elements in the Queue: 4
Top element of queue is: 3
Number of elements in the Queue: 4



## Efficency

Big "O" notation is often used as a notation that describes the behavior of a function. It ma.kes a way to compare the efficiency of different algorithims.

Queue has a Big "O" notation of O(1). This means that no matter how big the input, it will always take a constant amount of time to run. So if we have a queue with several hundered number and another queue with only 10 numbers. Every number will take the same amount of time even if one queue is longer than the other.


*** Diagram or picture ****


## Example : Bank Service Line

In the example below, we will write a simple queue code that will simulate a customer service line at the bank.

Some things to remember:

-After all the customers have been served, the code needs to stop
-After each customer is served, they should no longer be in queue.
-Display a message that says all the customers have been served.


```csharp
class Program
{
    static void Main()
    {
        Queue<string> customerQueue = new Queue<string>();

        // Customers arrive at the bank
        customerQueue.Enqueue("Customer 1");
        customerQueue.Enqueue("Customer 2");
        customerQueue.Enqueue("Customer 3");
        customerQueue.Enqueue("Customer 4");

        Console.WriteLine("Customers in queue:");
        foreach (string customer in customerQueue)
        {
            Console.WriteLine(customer);
        }

        // Serving customers
        Console.WriteLine("\nServing customers:");
        while (customerQueue.Count > 0)
        {
            string servedCustomer = customerQueue.Dequeue();
            Console.WriteLine($"{servedCustomer} has been served.");
        }

        // Check if queue is empty
        if (customerQueue.Count == 0)
        {
            Console.WriteLine("\nAll customers have been served.");
        }
    }
}
```

Notice the use of the `for each` and `while` loops that are in the code. This makes it so every customer gets served and the code doesn't end before everyone has been served.

## Problem to Solve : Call Center Simulation

A call center receives customer calls and processes them in the order they arrive. Each call is represented by a unique identifier (e.g., Call 1, Call 2, etc.). The call center can only handle one call at a time, and it takes a random amount of time between 1 and 5 seconds to process each call.

##### Task

1) Add a few calls to the queue.
2) Simulate processing each call in the order they arrive, where processing each call takes a random amount of time between 1 and 5 seconds.
3) Print a message each time a call starts being processed and when it finishes processing.



An example of what the output would like like is this:

Call 1 is being processed...
Call 1 finished processing in 3 seconds.
Call 2 is being processed...
Call 2 finished processing in 2 seconds.

Remeber you will need to use the `Random` class in order to generate the time to processes each call.


You can check your code with the solution here: [Solution](Queue)




[Back to Welcome Page](0-welcome.md)




