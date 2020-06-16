using System;
using 基本数据结构;

namespace 图遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(8);

            graph.addEdge(0, 1);
            graph.addEdge(0, 3);

            graph.addEdge(1, 2);
            graph.addEdge(1, 4);

            graph.addEdge(3, 4);
            graph.addEdge(2, 5);

            graph.addEdge(4, 5);
            graph.addEdge(4, 6);

            graph.addEdge(5, 7);
            graph.addEdge(6, 7);

            graph.bfs(0, 6);
            Console.WriteLine();
            graph.dfs(0, 6);
            Console.ReadKey();
        }


    }
}
