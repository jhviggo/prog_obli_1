using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligave.Opgave6
{
    class Node<T>
    {
        /// <summary>
        /// Region that contains all variables
        /// </summary>
        #region Variables

        private T data;

        private List<Edge<T>> myEdges = new List<Edge<T>>(); //Holds all the nodes edges

        #endregion

        /// <summary>
        /// Region that contains peoperties
        /// </summary>
        #region Properties

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public List<Edge<T>> MyEdges
        {
            get { return myEdges; }
            set { myEdges = value; }
        }

        #endregion

        /// <summary>
        /// The Node's constructor
        /// </summary>
        /// <param name="Data">The data to be stored in the node</param>
        public Node(T Data)
        {
            this.data = Data;
        }

        /// <summary>
        /// Adds an edge to the node
        /// </summary>
        /// <param name="Other">The node at the edge's endpoint</param>
        public void AddEdge(Node<T> Other, int weight)
        {
            myEdges.Add(new Edge<T>(this, Other, weight));
        }

        /// <summary>
        /// Converts value to string
        /// </summary>
        /// <returns>Returns the value as a string</returns>
        public override string ToString()
        {
            return data.ToString();
        }

    }
}
