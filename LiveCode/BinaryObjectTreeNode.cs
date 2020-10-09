namespace LiveCode
{
    /// <summary>
    /// Uden generics
    /// Med generics
    /// Generiske metoder
    /// Constraints
    /// Varians?
    /// </summary>



    class BinaryObjectTreeNode
    {
        public BinaryObjectTreeNode(object v)
        {
            Value = v;
        }

        public object Value { get; set; }
        public BinaryObjectTreeNode Left { get; set; }
        public BinaryObjectTreeNode Right { get; internal set; }
    }
}