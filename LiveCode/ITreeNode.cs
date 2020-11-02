using System;
using System.Collections.Generic;

namespace LiveCode
{
    interface ITreeNode<TValue> where TValue : IComparable<TValue>
    {
        TreeNode<TValue> Left { get; set; }
        TreeNode<TValue> Right { get; set; }
        List<TValue> Value { get; set; }

        void AddChild(TValue value);
    }
}