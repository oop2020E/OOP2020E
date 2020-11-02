namespace LiveCode
{
    class UI
    {
        public void ShowMessage()
        {
            
        }
        public void ShowStudentAdded(Student student)
        {
            TreeNode<int> asdf = new TreeNode<int>();
            AddALotOfTens(asdf);

        }

        private static void AddALotOfTens(TreeNode<int> asdf)
        {
            asdf.AddChild(10);
            asdf.AddChild(10);
            asdf.AddChild(10);
            asdf.AddChild(10);
            asdf.AddChild(10);
            asdf.AddChild(10);
            asdf.AddChild(10);
            asdf.AddChild(10);
            asdf.AddChild(10);
        }
    }
}