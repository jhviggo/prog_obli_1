using System;
using System.Collections.Generic;

namespace Obligave.Opgave6
{
    class ProgramOpgave6
    {
        private static Dictionary<Node<String>, int> distance;
        private static Dictionary<Node<String>, Node<String>> predecessors;
        private static HashSet<Node<String>> unvisitedNodes;

        /// <summary>
        /// Runs the code contained in the package
        /// </summary>
        public static void Run()
        {
            Node<String> start, target;
            MyGraph<String> graph = CreateGraph(out start, out target);
            Dijkstra(graph, start);
            PrintPath(target);
        }

        /// <summary>
        /// Runs the Dijkstra algorithm one a given graph on a starting node
        /// </summary>
        /// <param name="graph">The graph tree</param>
        /// <param name="start">The starting node</param>
        private static void Dijkstra(MyGraph<String> graph, Node<String> start)
        {
            // init node lists
            HashSet<Node<String>> visitedNodes = new HashSet<Node<String>>();
            unvisitedNodes = new HashSet<Node<String>>();

            // init distance and predecessor lists
            distance = new Dictionary<Node<string>, int>();
            predecessors = new Dictionary<Node<string>, Node<string>>();

            // add starting node
            distance.Add(start, 0);
            unvisitedNodes.Add(start);

            while(unvisitedNodes.Count > 0)
            {
                Node<String> node = GetMinimum(unvisitedNodes);
                visitedNodes.Add(node);
                unvisitedNodes.Remove(node);
                FindMinimalDistance(node);
            }
        }

        /// <summary>
        /// Finds and updates the minimal distances to all neighbors
        /// </summary>
        /// <param name="node">The currently visited node to inspect</param>
        private static void FindMinimalDistance(Node<String> node)
        {
            List<Node<String>> neighbors = GetNeighbors(node);
            foreach (Node<String> neighbor in neighbors)
            {
                int distanceToNeighbor = GetShortestNode(node) + GetDistanceBetweenNodes(node, neighbor);

                if (GetShortestNode(neighbor) > distanceToNeighbor)
                {
                    distance[neighbor] = distanceToNeighbor;
                    predecessors[neighbor] = node;
                    unvisitedNodes.Add(neighbor);
                }
        }
        }

        /// <summary>
        /// Returns the immediate distance between two nodes with no jumps
        /// </summary>
        /// <param name="node">The starting node that is being inspected</param>
        /// <param name="target">The target node</param>
        /// <returns>Distance between nodes</returns>
        private static int GetDistanceBetweenNodes(Node<String> node, Node<String> target)
        {
            foreach (Edge<String> edges in node.MyEdges)
            {
                if (edges.To == target)
                {
                    return edges.Weight;
                }
            }
            throw new Exception("damn");
        }

        /// <summary>
        /// Gets all neighbors from a given node
        /// </summary>
        /// <param name="node">The current node</param>
        /// <returns>All neighbors or the given node</returns>
        private static List<Node<String>> GetNeighbors(Node<String> node)
        {
            List<Node<String>> neighbors = new List<Node<String>>();
            
            foreach(Edge<String> edge in node.MyEdges)
            {
                neighbors.Add(edge.To);
            }

            return neighbors;
        }

        /// <summary>
        /// Returns the node with the smallest weight from a Set of nodes
        /// </summary>
        /// <param name="nodes">The Set of nodes</param>
        /// <returns>Node with the cheapest path</returns>
        private static Node<String> GetMinimum(HashSet<Node<String>> nodes)
        {
            Node<String> minimum = null;
            foreach(Node<String> node in nodes)
            {
                if(minimum == null)
                {
                    minimum = node;
                } else if (GetShortestNode(node) < GetShortestNode(minimum)) {
                    minimum = node;
                }
            }
            return minimum;
        }

        /// <summary>
        /// Returns the minimum weigth to a given node or infinite
        /// if no path has been discovered
        /// </summary>
        /// <param name="node">The node</param>
        /// <returns>The nodes smallest path weight</returns>
        private static int GetShortestNode(Node<String> node)
        {
            if (distance.ContainsKey(node))
            {
                return distance[node];
            } else {
                return Int32.MaxValue;
            }
        }

        /// <summary>
        /// Prints the path in the correct order
        /// </summary>
        /// <param name="target">The target node to find</param>
        private static void PrintPath(Node<String> target)
        {
            if (!predecessors.ContainsKey(target))
            {
                return;
            }

            List<Node<String>> path = new List<Node<string>>();
            Node<String> step = target;

            path.Add(target);

            while(predecessors.ContainsKey(step))
            {
                step = predecessors[step];
                path.Add(step);
            }

            path.Reverse();

            for(int i = 0; i < path.Count; i++)
            {
                Console.Write(path[i]);

                if (i < path.Count - 1)
                {
                    Console.Write(" -> ");
                }
            }
        }

        /// <summary>
        /// Creates the graph tree with weighted edges
        /// </summary>
        /// <param name="n3">The starting node</param>
        /// <param name="n7">The target node</param>
        /// <returns>The finished graph tree</returns>
        private static MyGraph<String> CreateGraph(out Node<String> n3, out Node<String> n7)
        {
            MyGraph<String> myGraph = new MyGraph<String>();

            //Adds nodes to our graph
            Node<String> n1 = myGraph.AddNode("OREGON");
            Node<String> n2 = myGraph.AddNode("CALIFORNIA");
            n3 = myGraph.AddNode("IDAHO");
            Node<String> n4 = myGraph.AddNode("UTAH");
            Node<String> n5 = myGraph.AddNode("NEW MEXICO");
            Node<String> n6 = myGraph.AddNode("KANSAS");
            n7 = myGraph.AddNode("SOUTH DAKOTA");
            Node<String> n8 = myGraph.AddNode("NORTH DAKOTA");
            Node<String> n9 = myGraph.AddNode("IOWA");
            Node<String> n10 = myGraph.AddNode("TENNESSEE");
            Node<String> n11 = myGraph.AddNode("NEW YORK");
            Node<String> n12 = myGraph.AddNode("FLORIDA");
            Node<String> n13 = myGraph.AddNode("TEXAS");
 
            //Creates edges between the graphs nodes
            myGraph.AddEdge("OREGON", "CALIFORNIA", 1);
            myGraph.AddEdge("CALIFORNIA", "UTAH", 3);
            myGraph.AddEdge("UTAH", "IDAHO", 3);
            myGraph.AddEdge("UTAH", "NEW MEXICO", 1);
            myGraph.AddEdge("NEW MEXICO", "KANSAS", 10); // 99
            myGraph.AddEdge("NEW MEXICO", "TEXAS", 4);
            myGraph.AddEdge("TEXAS", "TENNESSEE", 6);
            myGraph.AddEdge("TEXAS", "FLORIDA", 11);
            myGraph.AddEdge("TEXAS", "KANSAS", 2);
            myGraph.AddEdge("KANSAS", "SOUTH DAKOTA", 4); // 55
            myGraph.AddEdge("SOUTH DAKOTA", "NORTH DAKOTA", 1);
            myGraph.AddEdge("NORTH DAKOTA", "IOWA", 2);
            myGraph.AddEdge("IOWA", "TENNESSEE", 5);
            myGraph.AddEdge("TENNESSEE", "FLORIDA", 6);
            myGraph.AddEdge("TENNESSEE", "NEW YORK", 7);

            return myGraph;
        }
    }
}
