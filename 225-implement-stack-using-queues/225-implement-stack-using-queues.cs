public class MyStack
{
    Queue<int> leftQueue = new Queue<int>();
    Queue<int> rightQueue = new Queue<int>();

    public MyStack()
    {

    }

    public void Push(int x)
    {
        rightQueue.Enqueue(x);
    } 

    public int Pop()
    {
        Spin(leftQueue, rightQueue, 1);

        var value = rightQueue.Dequeue();

        Spin(rightQueue, leftQueue, 0);

        return value;
    }

    public int Top()
    {
        Spin(leftQueue, rightQueue, 1);

        var top = rightQueue.Peek();

        Spin(leftQueue, rightQueue, 0);
        Spin(rightQueue, leftQueue, 0);

        return top;
    }

    private void Spin(Queue<int> op1 , Queue<int> op2, int remainCount)
    {
        while (op2.Count > remainCount)
        {
            op1.Enqueue(op2.Dequeue());
        }
    }

    public bool Empty()
    {
        return rightQueue.Count == 0 ? true : false;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */