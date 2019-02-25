using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanttProjectDotNet.Models.Xml
{
    //TODO:przeniesc do GanttProjectExtensions
    public static class EnumUtils
    {
        public static string ToXmlString(this EValueType vt)
        {
            switch (vt)
            {
                case EValueType.Date:
                    return "date";
                case EValueType.Icon:
                    return "icon";
                case EValueType.Int:
                    return "int";
                case EValueType.Text:
                    return "text";
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }
        public static string ToXmlString(this ETaskDependencyHardness hardness)
        {
            switch (hardness)
            {
                case ETaskDependencyHardness.Strong:
                    return "Strong";
                case ETaskDependencyHardness.Rubber:
                    return "Rubber";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }


        public static string ToXmlString(this ETaskDependencyType type)
        {
            return ((int)type).ToString();
        }
    }
}
