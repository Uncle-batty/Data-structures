using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutres
{
    internal class BinaryTree
    {
        private treenode head;
        private treenode currentright;
        private treenode currentleft;
        public BinaryTree(int val)
        {
            head = new treenode(val);
        }
    }
    internal class treenode
    {
        public int value;
        public treenode left;
        public treenode right;
        public treenode(int val) { value = val; }

        public void add(int val)
        {
            if (val <= value)
            {
                if (left == null)
                {
                    left = new treenode(val);
                }
                else
                {
                    left.add(val);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new treenode(val);
                }
                else
                {
                    {
                        right.add(val);
                    }
                }
            }
        }

        public bool containes(int val) 
        { 
            if (val == value) { return true; }
            if (val <= value)
            {
                if (left != null)
                {
                    return false;
                }
                else
                {
                    left.containes(val);
                }
            }
            else
            {
                if (right != null)
                {
                    return false;
                }
                else
                {
                    right.containes(val);
                }
            }
            return false;
        }
    }
}

