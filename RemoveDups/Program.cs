using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDups
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Remove duplicated nodes from a Linked List without temporary Buffer
        /// </summary>
        /// <param name="masterNode"></param>
        private void RemoveDups(Node masterNode)
        {
            Node currentHeadNode = masterNode;
            if (masterNode.Next == null)
            {
                return;
            }
            else
            {
                Node previousNode = currentHeadNode;
                Node currentNodeToTraverse = previousNode.Next;

                while(currentHeadNode != null)
                {
                    while (currentNodeToTraverse!=null)
                    {
                        if (currentHeadNode.Value != currentNodeToTraverse.Value)
                        {
                            previousNode= currentNodeToTraverse;
                            currentNodeToTraverse = currentNodeToTraverse.Next;
                        }
                        else
                        {
                            // We have found the case where the current HeadNode 
                            // equals  the currentNode
                            previousNode.Next = currentNodeToTraverse.Next;
                            currentNodeToTraverse = currentNodeToTraverse.Next;
                        }
                    }

                    // We are done comparing the current parent node and its child nodes
                    // now we can move on to the next node and compare it to its children

                    currentHeadNode = currentHeadNode.Next;

                    if(currentHeadNode.Next != null)
                    {
                        previousNode = currentHeadNode;
                        currentNodeToTraverse= currentHeadNode.Next;
                    }
                }

            }


        }
    }
}
