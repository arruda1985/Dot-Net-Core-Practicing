using Arruda.LinkedList;
namespace Training;

class Program
{
    static void Main(string[] args)
    {
        var linkedList = new LinkedList();

        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(3);
        linkedList.WriteAll();
    }
}
