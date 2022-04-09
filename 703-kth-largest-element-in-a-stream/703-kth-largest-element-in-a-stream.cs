public class KthLargest
{
    PriorityQueue<int, int> pq;
    int queueSize;

    public KthLargest(int k, int[] nums)
    {
        pq = new PriorityQueue<int, int>(k);
        queueSize = k;

        for (int i = 0; i < nums.Length; i++)
        {
            Add(nums[i]);
        }
    }

    public int Add(int val)
    {
        if (pq.Count < queueSize)
        {
            pq.Enqueue(val, val);
        }
        else if(pq.Peek() < val)
        {
            pq.Dequeue();
            pq.Enqueue(val, val);
        }

        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */