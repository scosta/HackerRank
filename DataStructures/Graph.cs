using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures
{
    public class Graph
    {
        public Vertex[] Vertices { get; private set; }
        public List<int>[] Edges { get; private set; }
        public bool IsDirected { get; private set; }

        public Graph(int numNodes, int numEdges, int[,] edges, bool isDirected)
        {
            Vertices = new Vertex[numNodes];
            Edges = new List<int>[numNodes];
            IsDirected = isDirected;
            Initialize();
            BuildEdges(numEdges, edges);
        }

        public void Initialize()
        {
            for (int i = 0; i < Vertices.Length; i++)
            {
                Vertices[i] = new Vertex()
                {
                    ID = i,
                    Discovered = false,
                    Processed = false,
                    Parent = null
                };
            }

            for (int i = 0; i < Edges.Length; i++)
            {
                Edges[i] = new List<int>();
            }
        }

        private void BuildEdges(int numEdges, int[,] edges)
        {
            for (int i = 0; i < numEdges; i++)
            {
                Edges[edges[i, 0]].Add(edges[i, 1]);
                if (!this.IsDirected)
                {
                    Edges[edges[i, 1]].Add(edges[i, 0]);
                }
            }
        }

        public int GetShortestDistance(int start, int end)
        {
            if (start == end)
            {
                return 0;
            }

            int distance = 0;
            bool startFound = false;

            var v = this.Vertices[end];
            while (v.Parent != null)
            {
                distance++;
                if (v.Parent.ID == start)
                {
                    startFound = true;
                    break;
                }
                else
                {
                    v = v.Parent;
                }
            }

            return startFound ? distance * 6 : -1;
        }
    }
}
