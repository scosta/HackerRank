using HackerRank.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public class DFS
    {
        public void Search(Graph g, int v)
        {
            g.Vertices[v].Discovered = true;

            ProcessVertexEarly(v);

            var childVertices = g.Edges[v];
            foreach (int y in childVertices)
            {
                Vertex childVertex = g.Vertices[y];

                if (!childVertex.Discovered)
                {
                    childVertex.Parent = g.Vertices[v];
                    ProcessEdge(v, y);
                    Search(g, y);
                }
                else if (!childVertex.Processed || g.IsDirected)
                {
                    ProcessEdge(v, y);
                }
            }

            ProcessVertexLate(v);

            g.Vertices[v].Processed = true;
        }

        protected virtual void ProcessVertexEarly(int v)
        { }

        protected virtual void ProcessEdge(int x, int y)
        { }

        protected virtual void ProcessVertexLate(int v)
        { }
    }
}
