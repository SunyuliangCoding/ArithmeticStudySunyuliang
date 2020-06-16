/**************************************************************************      
项    目:        基本数据结构
作    者:        SYL syl
创建时间:        2018/12/3 10:59:55
Copyright (c)    北京迪威特科技有限公司

描    述：
***************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace 基本数据结构
{
    public class Graph
    {
        private int v;
        //示例中用LinkedList 但是后面要用索引访问，索性用List
        private List<int>[] adj;

        public Graph(int v)
        {
            this.v = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void addEdge(int s, int t)
        {
            adj[s].Add(t);
            adj[t].Add(s);
        }
        public void bfs(int s, int t)
        {
            if (s == t)
            {
                return;
            }
            bool[] vistited = new bool[v];
            vistited[s] = true;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(s);

            int[] prev = new int[v];
            for (int i = 0; i < prev.Length; i++)
            {
                prev[i] = -1;
            }
            while (queue.Count != 0)
            {
                int w = queue.Dequeue();
                for (int j = 0; j < adj[w].Count; j++)
                {
                    int q = adj[w][j];
                    if (!vistited[q])
                    {
                        prev[q] = w;
                    }
                    if (q == t)
                    {
                        print(prev, s, t);
                        return;
                    }
                    vistited[q] = true;
                    queue.Enqueue(q);
                }
            }
        }

        private void print(int[] prev, int s, int t)
        {
            if (prev[t] != -1 && t != s)
            {
                print(prev, s, prev[t]);
            }
            Console.Write(t + " ");
        }

        private bool found = false;
        public void dfs(int s, int t)
        {
            found = false;
            bool[] visited = new bool[v];
            int[] prev = new int[v];
            for (int i = 0; i < v; i++)
            {
                prev[i] = -1;
            }
            recurDfs(s, t, visited, prev);
            print(prev, s, t);
        }

        private void recurDfs(int w, int t, bool[] visited, int[] prev)
        {
            if (found == true)
            {
                return;
            }
            visited[w] = true;
            if (w == t)
            {
                found = true;
                return;
            }
            for (int i = 0; i < adj[w].Count; i++)
            {
                int q = adj[w][i];
                if (!visited[q])
                {
                    prev[q] = w;
                    recurDfs(q, t, visited, prev);
                }
            }
        }
    }
}
