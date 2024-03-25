namespace Arruda.LinkedList;

public class LinkedListNode
{
    public int Value { get; set; }
    public LinkedListNode? Next { get; set; }
}

public class LinkedList
{
    public LinkedListNode _linkedListNode { get; set; }

    public void Add(int value)
    {
        var newNode = new LinkedListNode() { Value = value, Next = null };

        if (_linkedListNode == null)
        {
            _linkedListNode = newNode;
        }
        else
        {
            var temp = _linkedListNode;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
    }

    internal void WriteAll()
    {
        var temp = _linkedListNode;

        while (temp.Next != null)
        {
            Console.Write($"Value: {temp.Value} Next => {temp.Next?.Value}  |  ");
            temp = temp.Next;
        }

    }
}
