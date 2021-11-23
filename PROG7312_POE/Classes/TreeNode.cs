using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Classes
{
    //----------------------------------------------------------------------------------
    public class TreeNode
    {
        //----------------------------------------------------------------------------------
        /// <summary>
        /// Constructor for the tree node
        /// </summary>
        /// <param name="value"></param>
        public TreeNode(DeweyDecimal value)
        {
            Value = value;
            Children = new List<TreeNode>();
        }

        //----------------------------------------------------------------------------------
        //gets and sets, including the value and children of the node
        //the value of each node is a dewey decimal class, which includes a call number and a description
        public DeweyDecimal Value { get; }
        public List<TreeNode> Children { get; }
    }
}
//--------------------------------------end of file------------------------------------------