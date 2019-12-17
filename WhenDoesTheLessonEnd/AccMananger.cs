using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LessonEndV2Main
{
    class AccMananger
    {
        public static bool verified = false;
        public static bool login()
        {
            string Username1, Password1;
            Username1 = PyFileMananger.read(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LessonEndSchedules", "username.txt"));
            Password1 = PyFileMananger.read(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LessonEndSchedules", "passworld.txt"));
            Console.WriteLine("Username");
            bool username = false, password = false;
            while (username == false)
            {
                if (Username1 != Console.ReadLine())
                {
                    Console.Write("you entered the wrong username");
                }
                else
                {
                    username = true;
                }
            }
            while (password == false)
            {
                if (Console.ReadLine() != Password1)
                {
                    Console.WriteLine("you entered the wrong password");
                }
                else
                {
                    Console.WriteLine("Welcome to the launcher");
                    password = true;
                }
            }
            return verified = true;
        }
    }
}
