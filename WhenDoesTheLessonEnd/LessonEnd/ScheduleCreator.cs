using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace LessonEndV2Main
{
    class ScheduleCreator
    {
        public static Lesson[] TempLessons = new Lesson[15];
        public static void Create(int Lesson, string name, DateTime TemplessonEnd)
        {
            TempLessons[Lesson] = new Lesson();
            TempLessons[Lesson].LessonEndTime = TemplessonEnd;
            TempLessons[Lesson].LessonName = name;
            TempLessons[Lesson].LessonID = Lesson;
        }
        public static void save()
        {
            string json = JsonConvert.SerializeObject(TempLessons);
            File.WriteAllText(FinderPath.Savepath, json);
            Console.WriteLine("File saved succesfully");
        }

        public static T LoadFile<T>(string path)
        {
            var text = File.ReadAllText(path);
            StringReader reader = new StringReader(text);
            string line = string.Empty;
            Console.WriteLine("Files loaded succesfully");
            return JsonConvert.DeserializeObject<T>(text);
        }
        public static void load ()
        {
            try
            {
                TempLessons = LoadFile<Lesson[]>(FinderPath.Savepath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
