﻿namespace BinaryTreeLibrary
{
    class TreeNode
    {
        // Automatic property LeftNode
        public TreeNode LeftNode { get; set; }

        // Automatic property Data
        public int Data { get; private set; }

        // Automatic property RightNode 
        public TreeNode RightNode { get; set; }

        // Initialize Data and make this a leaf node
        public TreeNode(int nodeData)
        {
            Data = nodeData;
        }

        // Insert TreeNode into Tree that contains nodes;
        // ignore duplicate values
        public void Insert(int insertValue)
        {
            
            if (insertValue < Data) // Insert in left subtree
            {
                // Insert new TreeNode
                if (LeftNode == null)
                {
                    LeftNode = new TreeNode(insertValue);
                }
                else  // Continue traversing left subtree
                {
                    LeftNode.Insert(insertValue);
                }
            }
            else if (insertValue > Data) // Insert right subtree
            {
                // Insert new TreeNode
                if (RightNode == null)
                {
                    RightNode = new TreeNode(insertValue);
                }
                else // Continue traversing right subtree
                {
                    RightNode.Insert(insertValue);
                }
            }
        }
    }

    // Class Tree declaration
    public class Tree
    {
        private TreeNode root;

        // Insert a new node in the binary search tree.
        // If the root node is null, create the root node here.
        // Otherwise, call the insert method of class TreeNode
        public void InsertNode(int insertValue)
        {
            if (root == null)
            {
                root = new TreeNode(insertValue);
            }
            else
            {
                root.Insert(insertValue);
            }
        }

        // Begin preorder traversal
        public void PreorderTraversal()
        {
            PreorderHelper(root);
        }

        // Recursive method to perform preorder traversal
        private void PreorderHelper(TreeNode node)
        {
            if (node != null)
            {
                // Output node Data
                Console.Write($"{node.Data} ");

                // Traverse left subtree
                PreorderHelper(node.LeftNode);

                // Traverse right subtree
                PreorderHelper(node.RightNode);
            }
        }

        // Begin inorder traversal
        public void InorderTraversal()
        {
            InorderHelper(root);
        }

        // Recursive method to perform inorder traversal

        private void InorderHelper(TreeNode node)
        {
            if (node != null)
            {
                // Traverse left subtree
                InorderHelper(node.LeftNode);

                // Output node Data
                Console.Write($"{node.Data} ");

                // Traverse right subtree
                InorderHelper(node.RightNode);
            }
        }
    }
}