using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graf
{
    internal class Node
    {
        public int index;
        public List<Node> neighbours;

        public Node(int index)
        {
            this.index = index;
            neighbours = new List<Node>();
        }

        public void AddNeighbours(List<Node> neighboursToAdd)
        {
            foreach (Node neighbour in neighboursToAdd)
            {
                //souseda uz mam v listu
                if(neighbours.Contains(neighbour))
                {
                    Console.WriteLine("Neighbour " + neighbour.index + " is already in list.");
                }
                else
                {
                    neighbours.Add(neighbour);
                }
            }
            //neighbours.AddRange(neighboursToAdd);   
        }
        public void PrintNeighbours()
        {
            Console.Write("Node " + index + " has neighbours ");
            foreach(Node neighbour in neighbours)
            {
                Console.Write(neighbour.index + " ");
            }
            Console.WriteLine();
        }
        public Node TraverseNode(int indexToTraverse)
        {
            foreach(Node neighbour in neighbours)
            {
                if (neighbour.index == indexToTraverse)
                {
                    return neighbour;
                }
            }
            return this;
        }

    }
}
