using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeWithArray
{
    internal class BinaryTree
    {
        static int root = 0;
        static string[] str = new string[15];
        public void Setroot(string key)
        {
            str[0] = key;
        }
        public void Setleft(string key, int root)
        {
            int t = (2 * root) + 1;
            if (str[root] == null)
            {
                Console.WriteLine("Could not set child at {0} as no parent is found!");
            }
            else
            {
                str[t] = key;
            }
        }
        public void Setright(string key, int root)
        {
            int t = (2 * root) + 2;
            if (str[root] == null)
            {
                Console.WriteLine("Could not set child at {0} as no parent is found!");
            }
            else
            {
                str[t] = key;
            }
        }
        public void print()
        {
            Console.WriteLine("Array Representation of binary tree is:");
            for (int i = 0; i < 15; i++)
            {
                if (str[i] == null)
                {
                    Console.Write("-"+" ");
                }
                else
                {
                    Console.Write(str[i]+" ");
                }
                            }
            Console.WriteLine();
        }
        public void InOrder(int index)
        {
         
            if (index>=15||str[index]==null)
            {
                return;
            }
            else
            {
                InOrder(2 * index + 1);
                Console.Write(str[index]+" ");
                InOrder(2 * index + 2);
            }
        }
        public void PreOrder(int index)
        {
         
            if (index >= 15 || str[index] == null)
            {
                return;
            }
            else
            {
                Console.Write(str[index] + " ");
                PreOrder(2 * index + 1);
                 PreOrder(2 * index + 2);
            }
        }
        public void PostOrder(int index)
        {
            
            if (index >= 15 || str[index] == null)
            {
                return;
            }
            else
            {
                PostOrder(2 * index + 1);
                PostOrder(2 * index + 2);
                Console.Write(str[index] + " ");
            }
        }
        public void Search(string key)
        {
            bool found=false;
           for(int i=0; i<str.Length; i++)
           {
                if (str[i] == key)
                {
                    Console.WriteLine("{0} is at index {1}.", str[i], i);
                    found = true;
                }
                   
           }
            if (!found)
            {
                Console.WriteLine("Element not found in tree!");
            }
        }
    }
}
