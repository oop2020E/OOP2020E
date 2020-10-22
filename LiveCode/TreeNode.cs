using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveCode
{



    class TreeNode<TValue> where TValue : IComparable<TValue>
    {
        public List<TValue> Value { get; set; }

        public TreeNode<TValue> Left { get; set; }
        public TreeNode<TValue> Right { get; set; }

        public void AddChild(TValue value)
        {
            // ... 

        }
    }
}