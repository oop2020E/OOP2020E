using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveCode
{



    class TreeNode<TValue> : ITreeNode<TValue> where TValue : IComparable<TValue>
    {
        public List<TValue> Value { get; set; }

        public TreeNode<TValue> Left { get; set; }
        public TreeNode<TValue> Right { get; set; }

        /// <summary>
        /// Add a child to the tree
        /// </summary>
        /// <param name="value">The child to add</param>
        public void AddChild(TValue value)
        {
            // ... 

        }
    }
}