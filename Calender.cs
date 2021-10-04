using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Calendar
    {
        //Static variables
        public static int month;
        public static int year;
        static string[] months = { "January", "Feburary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public void GetInput()
        {
            Console.WriteLine("Enter year of Calenter");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month(1-12) of Calenter");
            month = Convert.ToInt32(Console.ReadLine());
            Header();
            CalenderFill();
        }

        //Print header of Calendar
        public void Header()
        {
            Console.WriteLine("\n        Calendar " + month + " " + year);
            Console.WriteLine("\n" + months[month - 1] + " " + year);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
        }

        public static int DayFromDate(int d, int m, int y)
        {
            //Given formula: Gregorian calendar
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            return d0;
        }
        //Prints content of Calendar
        public void CalenderFill()
        {
            int day = 1;
            int startDate = DayFromDate(1, month, year);
            int days = DateTime.DaysInMonth(year, month);
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 0; j < 7 && day <= days; j++)
                {
                    if (i == 1 && j < startDate)
                    {
                        Console.Write("    ");
                        continue;
                    }
                    Console.Write(day);
                    if (day >= 10)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                    day++;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
