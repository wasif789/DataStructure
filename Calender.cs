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
        public static Queue<CalenderUsingWeekObjects<Calendar>> week = new Queue<CalenderUsingWeekObjects<Calendar>>();

        //Get input(Year and Month) from user
        public void GetInput()
        {
            Console.WriteLine("Enter year of Calenter");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month(1-12) of Calenter");
            month = Convert.ToInt32(Console.ReadLine());

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
            List<string> weeks = new List<string>() { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            for (int i = 1; i <= 6; i++)
            {
                //Create object for each day of a week
                CalenderUsingWeekObjects<Calendar> weekDayQueue = new CalenderUsingWeekObjects<Calendar>();
                for (int j = 0; j < 7 && day <= days; j++)
                {
                    CalenderUsingWeekObjects<Calendar> calenderUsingWeekObjects;
                    //If date is empty ,this part is executed
                    if (i == 1 && j < startDate)
                    {
                        calenderUsingWeekObjects = new CalenderUsingWeekObjects<Calendar>(weeks[j], "");
                        weekDayQueue.Append(calenderUsingWeekObjects);
                        continue;
                    }
                    calenderUsingWeekObjects = new CalenderUsingWeekObjects<Calendar>(weeks[j], Convert.ToString(day));
                    //Store value of each weekDay object 
                    weekDayQueue.Append(calenderUsingWeekObjects);
                    day++;
                }
                //Enqueue each week object
                week.Enqueue(weekDayQueue);
            }
            Display();
        }

        //Display all days
        public void Display()
        {
            Header();
            foreach (var i in week)
            {
                i.DisplayWeek();
            }
        }
    }
}
