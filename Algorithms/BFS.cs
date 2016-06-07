using HackerRank.DataStructures;
using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank.Algorithms
{
    public class BFS
    {
        public void Search(Graph g, int start)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            g.Vertices[start].Discovered = true;

            while (queue.Count > 0)
            {
                int v = queue.Dequeue();
                ProcessVertexEarly(v);
                g.Vertices[v].Processed = true;
                var adjacentVertices = g.Edges[v];

                foreach (int y in adjacentVertices)
                {
                    Vertex adjacentVertex = g.Vertices[y];
                    
                    if (!adjacentVertex.Processed || g.IsDirected)
                    {
                        ProcessEdge(v, y);
                    }
                    if (!adjacentVertex.Discovered)
                    {
                        queue.Enqueue(y);
                        adjacentVertex.Discovered = true;
                        adjacentVertex.Parent = g.Vertices[v];
                    }
                }

                ProcessVertexLate(v);
            }
        }

        protected virtual void ProcessVertexEarly(int v)
        { }

        protected virtual void ProcessEdge(int x, int y)
        { }

        protected virtual void ProcessVertexLate(int v)
        { }
    }
}