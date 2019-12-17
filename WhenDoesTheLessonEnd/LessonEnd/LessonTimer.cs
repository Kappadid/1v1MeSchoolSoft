using System;
using System.Collections.Generic;
using System.Text;

namespace LessonEndV2Main
{
    class LessonTimer
    {
        public static int CurrentLesson = 1;
        public static void endsin()
        {
            DateTime CT = DateTime.Now;
            DateTime tempdate = new DateTime(CT.Year, CT.Month, CT.Day, CT.Hour, CT.Minute, CT.Second);
            tempdate.AddHours(1);
            if(ScheduleCreator.TempLessons[LessonTimer.CurrentLesson].LessonEndTime < tempdate)
            {
                Console.WriteLine("The lesson has already ended");
            }
            else
            {
                Console.WriteLine(ScheduleCreator.TempLessons[LessonTimer.CurrentLesson].LessonName + " ends in " + (ScheduleCreator.TempLessons[LessonTimer.CurrentLesson].LessonEndTime - TC.now()));
            }
        }
        public static void LessonSelectorDebugg()
        {
            Console.WriteLine("Which lesson would you like to select?");
            CurrentLesson = int.Parse(Console.ReadLine());
        }
        public static void LessonSelector()
        {
            DateTime CT = DateTime.Now;
            CT.AddHours(1);
            foreach (Lesson jeff in ScheduleCreator.TempLessons)
            {
                if(ScheduleCreator.TempLessons[CurrentLesson].LessonEndTime < CT)
                {
                    CurrentLesson = CurrentLesson++;
                }
            }
        }
    }
}
