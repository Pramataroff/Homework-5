namespace inserting_element_after_node
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddFirst(5);
            numbers.AddFirst(4);
            numbers.AddFirst(2);
            numbers.AddFirst(1);

            LinkedListNode<int> node = numbers.Find(2);
            if (node != null)
            {
                numbers.AddAfter(node, 3);
            }

            Print(numbers);
        }

        static void Print(LinkedList<int> numbers)
        {
            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}
