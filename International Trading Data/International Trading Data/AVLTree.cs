using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International_Trading_Data
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            //see lecture notes for help
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
            tree.BalanceFactor = height(tree.Left) - height(tree.Right);
            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }
            if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }
        }

        public new void RemoveItem(T item) //covered in lecture 16
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                Console.WriteLine("The tree doesn't have items.");
            }
            else if (tree != null)
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
            if (tree != null)
            {
                tree.BalanceFactor = height(tree.Left) - height(tree.Right);
                if (tree.BalanceFactor <= -2)
                {
                    rotateLeft(ref tree);
                }
                if (tree.BalanceFactor >= 2)
                {
                    rotateRight(ref tree);
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

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right != null)
            {
                if (tree.Right.BalanceFactor > 0)
                {
                    rotateRight(ref tree.Right);
                }
                Node<T> oldRoot = tree;
                Node<T> newRoot = oldRoot.Right;
                oldRoot.Right = newRoot.Left;
                newRoot.Left = oldRoot;
                tree = newRoot;
            }

        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left != null)
            {
                if (tree.Left.BalanceFactor < 0)
                {
                    rotateLeft(ref tree.Left);
                }
                Node<T> oldRoot = tree;
                Node<T> newRoot = oldRoot.Left;
                oldRoot.Left = newRoot.Right;
                newRoot.Right = oldRoot;
                tree = newRoot;
            }
        }

        public IEnumerable<T> GetEnumerator()
        {
            return getEnumerator(root);
        }

        private IEnumerable<T> getEnumerator(Node<T> tree)
        {
            var stack = new Stack<Node<T>>();
            if (tree!=null)
            {
                stack.Push(tree);
            }
            while(stack.Count>0)
            {
                for (var current = stack.Pop(); current!=null; current = current.Left)
                {
                    yield return current.Data;
                    if (current.Right != null)
                        stack.Push(current.Right);
                }
            }
        }


    }
}
