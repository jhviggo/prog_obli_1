using System;
using System.Collections.Generic;
using System.Text;

namespace Obligave.Opgave6
{
    class ProgramOpgave6
    {
        public static void Run()
        {

        }
        private static void Pathbuilder()
        {
            int minimum = int.MaxValue;
            int min
        }
        private static void SearchMaybe()
        {

        }
        private static void CreateGraph(ref MyGraph<string> myGraph, out Node<String> n3, out Node<String> n7)
        {
            //Adds nodes to our graph
            Node<String> n1 = myGraph.AddNode("Aarhus");
            Node<String> n2 = myGraph.AddNode("Viby");
            n3 = myGraph.AddNode("Risskov");
            Node<String> n4 = myGraph.AddNode("Tilst");
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
            myGraph.AddEdge("Aarhus", "Viby");
            myGraph.AddEdge("CALIFORNIA", "Tilst");
            myGraph.AddEdge("Tilst", "Risskov");
            myGraph.AddEdge("Tilst", "NEW MEXICO");
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
        }
    }
}
