using System;
using System.IO;

namespace LessonEndV2Main
{
    class Program
    {
        static void Main(string[] args)
        {
            AccMananger.login();
            
            FinderPath.NormalPath();
            ScheduleCreator.load();
            LessonTimer.LessonSelector();
            LessonTimer.endsin();
            if (Console.ReadLine() == "d")
            {
                bool tempbool = false;
                Console.WriteLine("Welcome to debug. Here are some options\n1\tCreate new lesson\n2\tLoad in a different day\n3\tSave");
                while (tempbool == false)
                {
                    switch(Console.ReadLine())
                    {
                        case "1":
                            Debugger.TempTester();
                            break;
                        case "2":
                            FinderPath.pathshift();
                            break;
                        case "3":
                            ScheduleCreator.save();
                            break;
                        case "stop":
                            tempbool = true;
                            break;
                    }
                }
            }
                    
        }
    }
}
