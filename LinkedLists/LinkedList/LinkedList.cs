
namespace Arruda.LinkedList;

public class LinkedListNodes
{
    public int Value { get; set; }
    public LinkedListNodes? Next { get; set; }
}

public class LinkedList
{
    public List<LinkedListNodes> LinkedListCol { get; set; }

    public LinkedList()
    {
        LinkedListCol = [];
    }

    public void Add(int value)
    {
        var newNode =
            new LinkedListNodes() { Value = value, Next = null };

        if (LinkedListCol.Count == 0)
        {
            LinkedListCol.Add(newNode);
        }
        else
        {
            var temp = LinkedListCol.Last();

            temp.Next = newNode;
        }
    }

    internal void WriteAll()
    {
        foreach (var node in LinkedListCol)
        {
            Console.Write($"Value: {node.Value} Next=> {node.Next?.Value}  |  ");
        }
    }
}
