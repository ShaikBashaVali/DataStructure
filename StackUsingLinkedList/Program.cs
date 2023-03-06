
using StackUsingLinkedList;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked Lis !");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
        }
    }
}