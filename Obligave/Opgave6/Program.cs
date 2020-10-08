using System;
using System.Collections.Generic;
using System.Text;

namespace Obligave.Opgave6
{
    class ProgramOpgave6
    {
        public static void Run()
        {
            Node<String> start, target;
            MyGraph<String> graph = CreateGraph(out start, out target);
            Dijkstra(graph, start, target);
        }

        private static void Dijkstra(MyGraph<String> graph, Node<String> start, Node<String> target)
        {
            // init node lists
            HashSet<Node<String>> visitedNodes = new HashSet<Node<String>>();
            HashSet<Node<String>> unvisitedNodes = new HashSet<Node<String>>();

            // init distance and predecessor lists
            Dictionary<Node<String>, int> distance = new Dictionary<Node<string>, int>();
            Dictionary<Node<String>, Node<String>> predecessors = new Dictionary<Node<string>, Node<string>>();

            // add starting node
            distance.Add(start, 0);
            unvisitedNodes.Add(start);

            while(unvisitedNodes.Count > 0)
            {
                Node<String> node = GetMinimum(unvisitedNodes);
            }
        }

        private static Node<String> GetMinimum(HashSet<Node<String>> nodes)
        {
            
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
            myGraph.AddEdge("OREGON", "CALIFORNIA");
            myGraph.AddEdge("CALIFORNIA", "UTAH");
            myGraph.AddEdge("UTAH", "IDAHO");
            myGraph.AddEdge("UTAH", "NEW MEXICO");
            myGraph.AddEdge("NEW MEXICO", "KANSAS");
            myGraph.AddEdge("NEW MEXICO", "TEXAS");
            myGraph.AddEdge("TEXAS", "TENNESSEE");
            myGraph.AddEdge("TEXAS", "FLORIDA");
            myGraph.AddEdge("TEXAS", "KANSAS");
            myGraph.AddEdge("KANSAS", "SOUTH DAKOTA");
            myGraph.AddEdge("SOUTH DAKOTA", "NORTH DAKOTA");
            myGraph.AddEdge("NORTH DAKOTA", "IOWA");
            myGraph.AddEdge("IOWA", "TENNESSEE");
            myGraph.AddEdge("TENNESSEE", "FLORIDA");
            myGraph.AddEdge("TENNESSEE", "NEW YORK");

            return myGraph;
        }
    }
}
