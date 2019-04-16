using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International_Trading_Data
{
    class BSTree<T> : BinaryTree<T> where T : IComparable
    {  //root declared as protected in Parent Class – Binary Tree

        public int c = 0;
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public int Height()
        //Return the max level of the tree
        {
            return height(root);
        }

        protected int height(Node<T> tree)
        {
            if (root == null)
                return 0;
            else
            {
                if (tree != null)
                {
                    return 1 + Math.Max(height(tree.Left), height(tree.Right));
                }
                else
                {
                    return 0;
                }
            }
        }

        public int Count()
        //Return the number of nodes in the tree
        {
            return count(root, ref c);
        }

        private int count(Node<T> tree, ref int c)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                count(tree.Left, ref c);
                count(tree.Right, ref c);
                c++;
                return c;
            }
        }


        public Boolean Contains(T item)
        //Return true if the item is contained in the BSTree, false 	  //otherwise.
        {
            return contains(ref root, item);
        }

        private Boolean contains(ref Node<T> tree, T item)
        {
            if (root == null)
            {
                return false;
            }
            else if (tree != null)
            {
                if (item.CompareTo(tree.Data) < 0)
                {
                    return contains(ref tree.Left, item);
                }
                else if (item.CompareTo(tree.Data) > 0)
                {
                    return contains(ref tree.Right, item);
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public void RemoveItem(T item) //covered in lecture 16
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                Console.WriteLine("The tree doesn't have items.");
            }
            if (tree != null)
            {
                if (item.CompareTo(tree.Data) < 0)
                {
                    removeItem(item, ref tree.Left);
                }
                if (item.CompareTo(tree.Data) > 0)
                {
                    removeItem(item, ref tree.Right);
                }
                if (item.CompareTo(tree.Data) == 0)
                {
                    if (tree.Left == null)
                    {
                        tree = tree.Right;
                    }
                    else if (tree.Right == null)
                    {
                        tree = tree.Left;
                    }
                    else
                    {
                        T newRoot = leastItem(tree.Right);
                        tree.Data = newRoot;
                        removeItem(newRoot, ref tree.Right);
                    }
                }
            }
        }

        private T leastItem(Node<T> tree)
        {
            if (tree.Left == null)
                return tree.Data;
            else
                return leastItem(tree.Left);
        }
    }
}
