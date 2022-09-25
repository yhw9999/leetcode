public class MyCircularQueue {
  int[] data;
    int startIndex = 0;
    int inputCount = 0;

    public MyCircularQueue(int k)
    {
        data = new int[k];
    }

    public bool EnQueue(int value)
    {
        if (inputCount >= data.Length)
        {
            return false;
        }

        data[(startIndex + inputCount) % data.Length] = value;
        inputCount++;

        return true;
    }

    public bool DeQueue()
    {
        if (inputCount < 1)
        {
            return false;
        }

        inputCount--;

        startIndex = ++startIndex % data.Length;

        return true;
    }

    public int Front()
    {
        if (inputCount < 1)
        {
            return -1;
        }

        return data[startIndex];
    }

    public int Rear()
    {
        if (inputCount < 1)
        {
            return -1;
        }

        return data[(startIndex + inputCount - 1) % data.Length];
    }

    public bool IsEmpty()
    {
        return inputCount == 0;
    }

    public bool IsFull()
    {
        return inputCount == data.Length;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */