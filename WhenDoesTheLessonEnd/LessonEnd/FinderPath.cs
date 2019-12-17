using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LessonEndV2Main
{
    class FinderPath
    {
        public static string Savepath = "";
        public static void pathshift()
        {
            string dayofweek = "";
            Console.WriteLine("What day do you want it to be \n1\tMonday\n2\tTuesday\n3\tWednesday\n4\tThursday\n\tFriday");
            switch(Console.ReadLine())
            {
                case "1":
                    dayofweek = "Monday";
                    break;
                case "2":
                    dayofweek = "Tuesday";
                    break;
                case "3":
                    dayofweek = "Wednesday";
                    break;
                case "4":
                    dayofweek = "Thursday";
                    break;
                case "5":
                    dayofweek = "friday";
                    break;
            }
            Savepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LessonEndSchedules", dayofweek);
        }
        public static void NormalPath()
        {
            DateTime temp = DateTime.Now;
            Savepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LessonEndSchedules", temp.DayOfWeek.ToString());
        }
    }
}
