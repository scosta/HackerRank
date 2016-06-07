using System;
using System.Collections.Generic;
using System.IO;

public class LCA
{
    public static Node GetLCA(Node root, Node p, Node q)
    {
        if (!Covers(root, p) || !Covers(root, q))
        {
            return null;
        }
        return GetLCAInternal(root, p, q);
    }

    private static Node GetLCAInternal(Node root, Node p, Node q)
    {
        if (root == null || root == p || root == q)
        {
            return root;
        }

        // Determine if both nodes are on one side
        bool leftCoversP = Covers(root.Left, p);
        bool leftCoversQ = Covers(root.Left, q);

        if (leftCoversP != leftCoversQ)
        {
            // They are on different sides
            return root;
        }

        return leftCoversP ? GetLCA(root.Left, p, q) : GetLCA(root.Right, p, q);
    }

    static bool Covers(Node root, Node p)
    {
        if (root == null)
        {
            return false;
        }

        if (root == p)
        {
            return true;
        }

        return Covers(root.Left, p) || Covers(root.Right, p);
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}