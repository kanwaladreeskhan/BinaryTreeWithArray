using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeWithArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree=new BinaryTree();
            tree.Setroot("A");
            tree.Setleft("B",0);
            tree.Setright("C",0);
            tree.Setleft("D",1);
            tree.Setright("E",2);
            tree.Setleft("F",6);
            tree.Setright("G", 6);
            tree.print();
            Console.WriteLine("InOrder Traversal:");
            tree.InOrder(0);
            Console.WriteLine();
            Console.WriteLine("PreOrder Traversal:");
            tree.PreOrder(0);
            Console.WriteLine();
            Console.WriteLine("PostOrder Traversal:");
            tree.PostOrder(0);
            Console.WriteLine();
            tree.Search("D");
        }
    }
}
