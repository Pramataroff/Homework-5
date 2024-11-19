using System.Collections.Generic;

namespace containing_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> names = new LinkedList<string>();
            names.AddFirst("John");
            names.AddFirst("Milen");
            names.AddFirst("Bratan");
            names.AddFirst("Ivaaan");
            names.AddFirst("Dragan");
            names.AddFirst("Pesho");
            names.AddFirst("Gosho");
            int count = 0;
            Console.WriteLine("true/false");
            foreach (var item in names)
            {
                count++;
                Console.WriteLine($"does name number: {count} contains John: {item.Contains("John")}");
            }
        }
    }
}

/*
 Обяснявам кода:
създавам си линкедлист 
след това си добавям имена
създавам си променлива за брой на текущ елемент
с цикъл си принтирам дали името се съдържа в листа,
като съм си предефинирал листа и ще покаже,
че на последно място е името джон.
 */
