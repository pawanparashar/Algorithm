using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node left, right;

        }

        public Node root;
        static void Main(string[] args)
        {
            
        }

        public void InsertintoBST(int data)
        {
            Node Newnode = new Node();
            Newnode.data = data;

            if(root == null)
            {
                Newnode.left = null;
                Newnode.right = null;
                root = new Node();

            }
            else
            {


            }

        }


    }
}
