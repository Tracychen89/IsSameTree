using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSameTree
{
    class Program
    {
        public bool IsPartSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return false;
            }

            else if (p != null && q != null)
            {
                if (p.val == q.val)
                {
                    return IsPartSameTree(p.left, q.left) || IsPartSameTree(p.right, q.right);
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }



        }
        static void Main(string[] args)
        {
            TreeNode p = new TreeNode(20);
            p.left = new TreeNode(15);
            p.right = new TreeNode(23);
            TreeNode q = new TreeNode(20);
            q.left = new TreeNode(15);
            q.right = new TreeNode(23);
            q.right.right = new TreeNode(22);
            Solution res = new Solution();
            bool result1 = res.IsSameTree(p, q);
            bool result2 = res.IsPartSameTree();


            Console.WriteLine("These two TreeNode are same : {0}", result1);
            Console.WriteLine("The number of same Node of these two TreeNode: {0}",res.count);
            Console.WriteLine("Part of these two TreeNode are same: {0}", result2);
            
            Console.ReadLine();
        }
    }

    public class TreeNode 
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
    }
    class Solution
    {
        public int count = 0;
       public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            else if (p != null && q != null)
            {
                if (p.val == q.val)
                {
                    count++;

                    return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }


            
        }
        

        public  bool IsPartSameTree()
        {

            if (count > 1)
            {
                return true;
            }

            else
            {
                return false;
            }
            
        }
    }
}
