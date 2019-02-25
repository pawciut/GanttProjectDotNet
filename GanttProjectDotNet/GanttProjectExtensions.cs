using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GanttProjectDotNet
{
    public static class GanttProjectExtensions
    {
        public static string ToGPDateString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd");
        }

        public static string ToGPIntToBoolString(this int value)
        {
            return value.ToString();
        }

        public static int ToGPBoolToInt(this bool value)
        {
            return value? 1 : 0;
        }

        //public static string ToGPColorString(this  dateTime)
        //{
        //    return dateTime.ToString("yyyy-MM-dd");
        //}
    }
}
