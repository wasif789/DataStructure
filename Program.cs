using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Datastructure Programs!");
            Console.WriteLine("Enter 1-For Unordered List");
            Console.WriteLine("Enter 2-For Ordered List");

            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    UnorderedList<string> unorderedList = new UnorderedList<string>();
                    unorderedList.GetInput();
                    break;
                case 2:
                    OrderedList<int> orderedList = new OrderedList<int>();
                    orderedList.GetInput();
                    break;
            }    
        }
    }
}
