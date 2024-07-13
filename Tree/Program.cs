
class Tree
{
    // Recursively print the parent of each node
    static void PrintParents(int node, List<List<int>> adj, int parent)
    {
        Console.WriteLine($"{node} -> {(parent == -1 ? "Root" : parent.ToString())}");

        foreach (int child in adj[node])
        {
            if (child != parent) // Avoid going back to the parent
            {
                PrintParents(child, adj, node);
            }
        }
    }

    // Print the children of each node using BFS
    static void PrintChildren(int root, List<List<int>> adj)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(root); // Start BFS from the root
        bool[] visited = new bool[adj.Count];
        visited[root] = true; // Mark the root as visited

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            Console.Write($"{node} -> ");
            foreach (int child in adj[node])
            {
                if (!visited[child])
                {
                    Console.Write($"{child} ");
                    visited[child] = true; // Mark the child as visited
                    queue.Enqueue(child);
                }
            }
            Console.WriteLine(); // New line for the next node's children
        }
    }

    // Print all leaf nodes in the tree
    static void PrintLeafNodes(int root, List<List<int>> adj)
    {
        for (int i = 0; i < adj.Count; i++)
        {
            // A leaf node has exactly one connection and is not the root
            if (i != root && adj[i].Count == 1)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }

    // Calculate and print the degree of the tree (maximum degree of any node)
    static void PrintTreeDegree(List<List<int>> adj)
    {
        int maxDegree = 0;
        for (int i = 1; i < adj.Count; i++)
        {
            maxDegree = Math.Max(maxDegree, adj[i].Count);
        }
        Console.WriteLine($"The degree of the tree is: {maxDegree}");
    }

    static void Main(string[] args)
    {
        int n = 11; // Number of nodes
        int root = 1; // Root node
        List<List<int>> adj = new List<List<int>>();

        // Initialize the adjacency list
        for (int i = 0; i <= n; i++)
        {
            adj.Add(new List<int>());
        }

        // Define the connections (edges) between nodes
        adj[1].AddRange(new int[] { 2, 3, 4 });
        adj[2].AddRange(new int[] { 1, 5, 6 });
        adj[3].AddRange(new int[] { 1, 7 });
        adj[4].AddRange(new int[] { 1, 8 });
        adj[5].Add(2);
        adj[6].AddRange(new int[] { 2, 9 });
        adj[7].Add(3);
        adj[8].AddRange(new int[] { 4, 10, 11 });
        adj[9].Add(6);
        adj[10].Add(8);
        adj[11].Add(8);

        // Print the parent of each node
        Console.WriteLine("Parents of each node:");
        PrintParents(root, adj, -1);

        // Print the children of each node
        Console.WriteLine("Children of each node:");
        PrintChildren(root, adj);

        // Print all leaf nodes in the tree
        Console.WriteLine("Leaf nodes of the tree:");
        PrintLeafNodes(root, adj);

        // Print the degree of the tree
        PrintTreeDegree(adj);
    }
}











