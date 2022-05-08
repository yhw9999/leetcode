public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0)
        {
            return;
        }

        var left = new Queue<int>();
        var right = new Queue<int>(nums2);

        for (int i = 0; i < m; i++)
        {
            left.Enqueue(nums1[i]);
        }

        var index = 0;

        while (left.Count > 0 && right.Count > 0)
        {
            var leftValue = left.Peek();
            var rightValue = right.Peek();

            if (leftValue > rightValue)
            {
                nums1[index++] = right.Dequeue();
            }
            else
            {
                nums1[index++] = left.Dequeue();
            }
        }

        if (left.Count == 0)
        {
            while (right.TryDequeue(out var value))
            {
                nums1[index++] = value;
            }
        }

        if (right.Count == 0)
        {
            while (left.TryDequeue(out var value))
            {
                nums1[index++] = value;
            }
        }
    }
}