using TreeNode = BinaryTree.TreeNode<int>;

namespace Solution;

public static class Solution
{
    public static IList<int> PreorderTraversal(TreeNode root) {
        var list = new List<int>();
        
        var stack = new Stack<TreeNode?>();
        var current = root;
        
        if (current is not null)
        {
            stack.Push(current);
        }
        
        while (stack.Count > 0) {
            current = stack.Pop();
            if (current is null) continue;

            list.Add(current.val);
            stack.Push(current.right);
            stack.Push(current.left);
        }
        
        return list;
    }
}
