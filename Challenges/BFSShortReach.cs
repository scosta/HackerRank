using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.DataStructures;
using System.IO;
using HackerRank.Algorithms;

namespace HackerRank.Challenges
{
    public class BFSShortReach
    {
        public void Solve(string[] args) 
        {
            StreamReader file = new StreamReader("C:\\Users\\scosta\\Documents\\Visual Studio 2013\\Projects\\HackerRank\\HackerRank\\TestCases\\BFSShortReach\\TestCase2.txt");

            int t = Convert.ToInt32(file.ReadLine());
            for (int i = 0; i < t; i++) 
            {
                int[] nm = Array.ConvertAll(file.ReadLine().Split(' '), int.Parse);
                int numNodes = nm[0];
                int numEdges = nm[1];
                int[,] edges = new int[numEdges, 2];
                for (int j = 0; j < numEdges; j++) {
                    int[] edge = Array.ConvertAll(file.ReadLine().Split(' '), int.Parse);
                    edges[j,0] = edge[0] - 1;
                    edges[j,1] = edge[1] - 1;
                }
                int start = Convert.ToInt32(file.ReadLine()) - 1;
            
                Graph g = new Graph(numNodes, numEdges, edges, false);
                BFS bfs = new BFS();
                bfs.Search(g, start);

                // print distance from start to each vertex in graph
                string output = string.Empty;
                for (int j = 0; j < numNodes; j++)
                {
                    if (j != start)
                    {
                        output += g.GetShortestDistance(start, j) + " ";
                    }
                }
                Console.WriteLine(output);
            }

            Console.ReadLine();
            file.Close();
        }
    }
}