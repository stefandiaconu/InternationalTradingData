﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International_Trading_Data
{
    class BinaryTree<T> where T : IComparable
    {
        protected Node<T> root;
        public BinaryTree()  //creates an empty tree
        {
            root = null;
        }
        public BinaryTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString();
                inOrder(tree.Right, ref buffer);
            }
        }

        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }

        private void preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString();
                preOrder(tree.Left, ref buffer);
                preOrder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString();
            }
        }
    }
}
