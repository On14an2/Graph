public class Graph
{
    private Dictionary<int, List<int>> adjacencyList;

    public Graph()
    {
        adjacencyList = new Dictionary<int, List<int>>();
    }

    public void AddVertex(int vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new List<int>();
        }
    }

    public void AddEdge(int source, int destination)
    {
        if (!adjacencyList.ContainsKey(source))
        {
            adjacencyList[source] = new List<int>();
        }

        if (!adjacencyList.ContainsKey(destination))
        {
            adjacencyList[destination] = new List<int>();
        }

        adjacencyList[source].Add(destination);
        adjacencyList[destination].Add(source);
    }

    public void PrintGraph()
    {
        foreach (var vertex in adjacencyList)
        {
            Console.Write(vertex.Key + ": ");

            foreach (var neighbor in vertex.Value)
            {
                Console.Write(neighbor + " ");
            }

            Console.WriteLine();
        }
    }
}