using System;
using System.Collections.Generic;
using System.Text;

namespace LessonEndV2Main
{
    class Debugger
    {
        public static void TempTester()
        {
            bool tempbool = true;
            DateTime CT = DateTime.Now;
            Console.WriteLine("What is the name of the lesson?");
            string tempname = Console.ReadLine();
            Console.WriteLine("Hour does it end?");
            int TempHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Minute does it end?");
            int TempMinute = int.Parse(Console.ReadLine());
            DateTime Temptime = new DateTime(CT.Year,CT.Month,CT.Day,TempHour,TempMinute,CT.Second);
            Console.WriteLine("Which lesson of the day is it?");
            int LessonId = int.Parse(Console.ReadLine());
            ScheduleCreator.Create(LessonId, tempname, Temptime);

            LessonTimer.LessonSelector();
        }
    }
}
