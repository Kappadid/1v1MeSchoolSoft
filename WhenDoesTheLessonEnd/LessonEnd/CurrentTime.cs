using System;
using System.Collections.Generic;
using System.Text;

namespace LessonEndV2Main
{
    class TC
    {
        public static DateTime now()
        {
            DateTime TC = DateTime.Now;
            DateTime temp = new DateTime(TC.Year, TC.Month, TC.Day, TC.Hour, TC.Minute, TC.Second);
            return temp;
        }
    }
}
