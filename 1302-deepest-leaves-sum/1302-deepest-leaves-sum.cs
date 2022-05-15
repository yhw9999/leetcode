/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int DeepestLeavesSum(TreeNode root) {
        var dictionary = new Dictionary<int, List<int>>();
        
        AddValues(root, dictionary, 0);
        
        return dictionary.Last().Value.Sum();
    }
    
    private void AddValues(TreeNode node, Dictionary<int, List<int>> dict, int currentIndex){
        
        if(node == null){
            return;    
        }
        
        if(!dict.TryGetValue(currentIndex, out var list)){
            dict.Add(currentIndex, new List<int>());
        }
        
        dict[currentIndex].Add(node.val);
        
        AddValues(node.left, dict, currentIndex + 1);
        AddValues(node.right, dict, currentIndex + 1);
    }
}