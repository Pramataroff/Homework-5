namespace Elements_counting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(3);
            list.AddFirst(4);
            list.AddFirst(5);
            list.AddFirst(6);
            list.AddFirst(7);
            list.AddFirst(8);
            list.AddFirst(9);
            list.AddFirst(10);
            Console.WriteLine("==============================================");
            Console.WriteLine(list.Count);//това е лесният начин //Трябва да ми даде този резултат ако използвам свойството count.
            Console.WriteLine("==============================================");
            Counting(list); //трудният начин
        }
        static void Counting(LinkedList<int> list)
        {
            int count = 0;//Правя си променлива с която да преброявам преминаванията ми през цикъла
            foreach (var VARIABLE in list)
            {
                count++;//на всеки елемент ще прибавя по една единица във променливата.
            }
            Console.WriteLine($"The count of the list is: {count}");
        }
    }

}
