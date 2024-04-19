using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure
{
    public class TreeNode
    {
        public int value;
        public TreeNode right;
        public TreeNode left;

        public TreeNode(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }

    }
}
