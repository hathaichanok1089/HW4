class TreeNode<T>
{
    private T value;
    private TreeNode<T> next = null;
    private TreeNode<T> child = null;
    private TreeNode<T> parent = null;

    public TreeNode(T value)
    {
        this.SetValue(value);
    }

    public void SetNext(TreeNode<T> next)
    {
        this.next = next;
    }

    public void SetChild(TreeNode<T> child)
    {
        this.child = child;
    }

    public TreeNode<T> Next()
    {
        return this.next;
    }

    public TreeNode<T> Child()
    {
        return this.child;
    }

    public T GetValue()
    {
        return this.value;
    }

    public void SetValue(T value)
    {
        this.value = value;
    }

    public void SetParent(TreeNode<T> parent)
    {
        this.parent = parent;
    }
    public TreeNode<T> Parent()
    {
        return this.parent;
    }
}