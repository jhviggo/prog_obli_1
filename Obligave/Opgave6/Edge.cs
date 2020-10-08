using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligave.Opgave6
{
    class Edge<T>
    {
        /// <summary>
        /// Region that contains all variables
        /// </summary>
        #region Variables

        private Node<T> from; //Starting point of the edge

        private Node<T> to; //Endpoint of the edge

        private int weight;

        #endregion

        /// <summary>
        /// Region that contains all peoperties
        /// </summary>
        #region Propterties

        public Node<T> To
        {
            get { return to; }
            set { to = value; }
        }

        public Node<T> From
        {
            get { return from; }
            set { from = value; }
        }

        public int Weight{
            get { return weight; }
            set { weight = value; }
        }

        #endregion

        public Edge(Node<T> From, Node<T> To, int Weight)
        {
            from = From;
            to = To;
            weight = Weight;
        }

        public override string ToString()
        {
            return String.Format("{0}-({1})->{2}", from.ToString(), weight, to.ToString());
        }
    }
}
