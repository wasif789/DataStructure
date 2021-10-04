using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class BankingCashCounter<T>
    {
        int bankBalance = 2000000;
        public void PeopleInputPanel()
        {
            Console.WriteLine("Enter the number of people in Queue");
            int people = Convert.ToInt32(Console.ReadLine());
            CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();
            for (int i = 1; i <= people; i++)
            {
                customLinkedList.Enqueue(i);
                BankServices();
                customLinkedList.Dequeue();
            }
            if (customLinkedList.IsEmpty() == 0)
            {
                Console.WriteLine("Banking Queue has been Cleared!");
            }
            else
            {
                Console.WriteLine("\nPeople are yet to be given services!");

            }
            Console.WriteLine("\nCurrent Bank Balance is: {0}", bankBalance);
        }

        public void BankServices()
        {
            Console.WriteLine("Enter 1-To withdraw cash\nEnter 2 -To Deposit Cash");
            int choice = Convert.ToInt32(Console.ReadLine());
            int account = 0;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter amount to withdraw");
                    account = Convert.ToInt32(Console.ReadLine());
                    bankBalance -= account;
                    break;
                case 2:
                    Console.WriteLine("Enter amount to Diposit");
                    account = Convert.ToInt32(Console.ReadLine());
                    bankBalance += account;
                    break;
                default:
                    Console.WriteLine("Entered Invalid Option!");
                    break;
            }
        }
    }
}
