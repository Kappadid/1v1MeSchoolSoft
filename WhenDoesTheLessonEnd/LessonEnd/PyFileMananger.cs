using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace LessonEndV2Main
{
    class PyFileMananger
    {
        static void PyCreate ()
        {
            
        }
        public static string read(string path)
        {
            StreamReader reader = new StreamReader(path);
            string temp = reader.ReadToEnd();
            return temp;
        }
    }
}
