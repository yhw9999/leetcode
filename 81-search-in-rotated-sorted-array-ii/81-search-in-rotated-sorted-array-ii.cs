public class Solution {
    public bool Search(int[] nums, int target) {
		return nums.ToHashSet().Contains(target);
    }
}