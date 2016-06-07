using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures
{
    public class BinaryTreeNode
    {
        public int Data { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public bool Insert(int val)
        {
            if (val < this.Data)
            {
                if (this.Left == null)
                {
                    this.Left = new BinaryTreeNode() 
                    { 
                        Data = val
                    };
                    return true;
                }
                else
                {
                    return this.Insert(val);
                }
            }
            else
            {
                if (this.Right == null)
                {
                    this.Right = new BinaryTreeNode()
                    {
                        Data = val
                    };
                    return true;
                }
                else
                {
                    return this.Insert(val);
                }
            }
        }

        public bool Remove(int val, BinaryTreeNode parent)
        {
            if (this.Data > val)
            {
                if (this.Left != null)
                {
                    return this.Left.Remove(val, this);
                }
                else
                {
                    return false;
                }
            }
            else if (this.Data < val)
            {
                if (this.Right != null)
                {
                    return this.Right.Remove(val, this);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (this.Left != null && this.Right != null)
                {
                    this.Data = this.Right.MinValue();
                    this.Right.Remove(this.Data, parent);
                }
                else if (parent.Left == this)
                {
                    parent.Left = (this.Left != null) ? this.Left : this.Right;
                }
                else if (parent.Right == this)
                {
                    parent.Right = (this.Left != null) ? this.Left : this.Right;
                }
                return true;
            }
        }

        public int MinValue()
        {
            if (this.Left == null)
            {
                return this.Data;
            }
            else
            {
                return this.Left.MinValue();
            }
        }
    }

    public class BinaryTree
    {
        public BinaryTreeNode Root { get; set; }

        public bool Insert(int val)
        {
            if (this.Root == null)
            {
                this.Root = new BinaryTreeNode()
                {
                    Data = val
                };
                return true;
            }
            else
            {
                return this.Root.Insert(val);
            }
        }

        public bool Remove(int val)
        {
            if (this.Root == null)
            {
                return false;
            }
            else
            {
                return this.Root.Remove(val, null);
            }
        }
    }
}
