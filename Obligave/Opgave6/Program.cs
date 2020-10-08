using System;
using System.Collections.Generic;

namespace Obligave.Opgave6
{
    class ProgramOpgave6
    {
        private static Dictionary<Node<String>, int> distance;
        private static Dictionary<Node<String>, Node<String>> predecessors;
        private static HashSet<Node<String>> unvisitedNodes;
        public static void Run()
        {
            Node<String> start, target;
            MyGraph<String> graph = CreateGraph(out start, out target);
            /**
            foreach (Node<String> node in graph.NodeSet) {
                Console.WriteLine(node);
                foreach(Edge<String> edge in node.MyEdges) {
                    Console.WriteLine(edge);
                }
                Console.WriteLine();
            }
            */
            Dijkstra(graph, start);

            PrintPath(target);
        }

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

            Console.WriteLine("Starting with " + start);

            while(unvisitedNodes.Count > 0)
            {
                Node<String> node = GetMinimum(unvisitedNodes);
                visitedNodes.Add(node);
                unvisitedNodes.Remove(node);
                FindMinimalDistance(node);
            }
        }

        private static void FindMinimalDistance(Node<String> node)
        {
            List<Node<String>> neighbors = GetNeighbors(node);
            foreach (Node<String> neighbor in neighbors)
            {
                int distanceToNeighbor = GetShortestNode(node) + GetDistanceBetweenNodes(node, neighbor);

                if (GetShortestNode(neighbor) > distanceToNeighbor) {
                        distance[neighbor] = distanceToNeighbor;
                        predecessors[neighbor] = node;
                        unvisitedNodes.Add(neighbor);
                    }
            }
        }

        private static int GetDistanceBetweenNodes(Node<String> node, Node<String> target)
        {
            foreach (Edge<String> edges in node.MyEdges)
            {
                if (edges.To == target) {
                    return edges.Weight;
                }
            }
            throw new Exception("damn");
        }

        private static List<Node<String>> GetNeighbors(Node<String> node)
        {
            List<Node<String>> neighbors = new List<Node<String>>();
            
            foreach(Edge<String> edge in node.MyEdges)
            {
                neighbors.Add(edge.To);
            }

            return neighbors;
        }

        private static Node<String> GetMinimum(HashSet<Node<String>> nodes)
        {
            Node<String> minimum = null;
            foreach(Node<String> node in nodes)
            {
                if(minimum == null) {
                    minimum = node;
                } else if (GetShortestNode(node) < GetShortestNode(minimum)) {
                    minimum = node;
                }
            }
            return minimum;
        }

        private static int GetShortestNode(Node<String> node)
        {
            if (distance.ContainsKey(node)) {
                return distance[node];
            } else {
                return Int32.MaxValue;
            }
        }

        private static void PrintPath(Node<String> target)
        {
            if (!predecessors.ContainsKey(target)) {
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
            foreach(Node<String> node in path)
            {
                Console.Write(node + " -> ");
            }
        }

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
            myGraph.AddEdge("NEW MEXICO", "KANSAS", 10);
            myGraph.AddEdge("NEW MEXICO", "TEXAS", 4);
            myGraph.AddEdge("TEXAS", "TENNESSEE", 6);
            myGraph.AddEdge("TEXAS", "FLORIDA", 11);
            myGraph.AddEdge("TEXAS", "KANSAS", 2);
            myGraph.AddEdge("KANSAS", "SOUTH DAKOTA", 4);
            myGraph.AddEdge("SOUTH DAKOTA", "NORTH DAKOTA", 1);
            myGraph.AddEdge("NORTH DAKOTA", "IOWA", 2);
            myGraph.AddEdge("IOWA", "TENNESSEE", 5);
            myGraph.AddEdge("TENNESSEE", "FLORIDA", 6);
            myGraph.AddEdge("TENNESSEE", "NEW YORK", 7);

            return myGraph;
        }
    }
}
