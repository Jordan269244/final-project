# Tree

Tree data structers are a specialized data structure that are used to store data in a hierachical manner. It consists of one central node that branches off into structural nodes, and sub-nodes. 

Some real world examples include
- Computer File Systems
- Databases often use trees to index data 
- When playing against a "computer" in a game, the AI most likely uses a decision tree to decide on the next best move


#### <ins>Advantages
- Trees are very efficient for searching and retrieiving data.
- Trees can be as large or small as needed and can change if the data size requires it.
- Trees enforce a strict order that each node goes in. Makes it very easy to add, remove, or modify specific nodes without 
affecting the rest of the tree.
- Trees are very flexible with what they can represent
 
#### <ins>Disadvantages
- Trees require lots of memory especially if they are large trees
- Trees need to remain balanced, if they aren't balanced then search times can be different
- Trees are complicated to implement if you don't understand how they work.
- Not very efficent with other types of operations (eg. sorting or grouping)



## Definitions

- **Node:** Primary component of a tree. Stores data and the links to other nodes
- **Edge:** Also called a branch, this connects two nodes together. A node can have more than one edge
- **Parent:** A Parent is a node that is higher in the "hierarchy" of the tree. It has branches to other nodes
- **Child:** A node that is connected below another node. All nodes, excepts the root node, are child nodes.
- **Root:** The first node in the tree is called the root of the tree
- **Leaf node:** Nodes with no child, also called external nodes
- **Internal node (Non-Leaf Node):** Nodes with at least one child
- **Siblings:** Nodes that have the same parent
- **Cousins:** Nodes that belong on the same level of the tree, with different parents
- **Degree:** The number of children of that node
- **Path:** To reach a specific node, there is a unique sequence of edges to get there. The number of edges in a path is call the length of the path
- **Level of a node:** The number of edges in the path between the root and the node
- **Subtree:** A tree formed by a node and its descendants while in the original tree

## Basic Operations

There are 4 basic operations of Tree Data Structures: `Create`, `Insert`, and `Search`
- **Create:** Creates a tree in the data structure
- **Insert:** Inserts data in the tree
- **Search:** Searches a specific data in the tree to check if it exists or not

To `Create` a new tree you start by giving the total number of nodea and the root node. 

```csharp
int n = 9; // Number of Nodes
int root = 1; // Root Node
List<list<int>> adj = new List<List<int>>();

for (int i = 0; i <= n; i++)
{
    adj.Add(new List<int>());
}
```

Next you `Insert` the rest of the nodes and there connections.

```csharp
adj[1].AddRange(new int[] { 2, 3 });
adj[2].AddRange(new int[] { 4, 5 });
adj[3].AddRange(new int[] { 6, 7 });
adj[5].AddRange(new int[] { 8, 9 });
```


To `Search` for a specific node, you need to use statements that narrow down the options.

```csharp
static void LeafNodes(int Root, List<List<int>> adj)
    {
        for (int i = 0; i < adj.Count; i++)
        {
            if (adj[i].Count == 1 && i != Root)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }
```
This code goes through all the nodes in the tree, checks to see if they have only 1 connection (to the parent) and ensure that it isn't root (sometimes root may only have one child connection). This is how it will identify all the Leaf Nodes in the Code which in this example would be 4,6,7,8,9.




## Types of Tree Structures

**Binary Tree:** Each node has a maximum of 2 children. *This is the example we made above.*

**Ternary Tree:** Each node in the tree has a maximum of 3 children

**N-ary Tree:** Also known as Generic Tree, each node can have multiple children as long as duplicates don't exisit



****DIAGRAM****




## Efficency

The Big O notation of the tree strucutre is O(log n). O(log n) means that the larger the input, but more consistant the time becomes. If you look at the graph below, you will notice that O(log n) starts to flatten off. This means that even if the input size gets bigger, the time it takes to do do the algorithm will remain the same making it a very efficient process.


******GRAPH*********

## Example Problem: Simple Tree

In the example problem below, a simple tree is created. Try to draw what the tree looks like and identify the `Parent Nodes`, `Children Nodes`, and `Leaf Nodes`.

```csharp

    static void Tree(string[] args)
    {
        int n = 7; // Number of nodes
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
        adj[4].AddRange(new int[] { 1, 7 });
        adj[3].Add(1);
        adj[5].Add(2);
        adj[6].Add(2);
        adj[7].Add(4); 
    }

```

Notice the use of Linked Lists in the Tree structure. A path to get from one node to another could be considered a Linked List.



#### **SOLUTION**
This is what the tree looks like:

***PICTURE****


*Parent Nodes:* 1(root), 2, 4\
*Child Nodes:* 2, 3, 4, 5, 6, 7\
*Leaf Nodes:* 3, 5, 6, 7



## Problem to Solve: Create the Tree

For this problem, look at the image below. Using that tree, create a code that correctly identifies all the `Parent Nodes`, `Child Nodes`, `Leaf Nodes`, and the `Degree` of the tree.


*****IMAGE******


Here is the code to create the tree to help get started:
```csharp

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

```
\
\
\
You can check your code with the solution here: [Solution](Tree)

[Back to Welcome Page](0-welcome.md)

