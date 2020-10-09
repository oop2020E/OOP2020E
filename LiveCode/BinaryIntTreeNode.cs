namespace LiveCode
{
    class BinaryIntTreeNode
    {
        public int Value { get; set; }

        public BinaryIntTreeNode(int value)
        {
            Value = value;
        }

        public BinaryIntTreeNode Left { get; set; }
        public BinaryIntTreeNode Right { get; set; }
    }
}