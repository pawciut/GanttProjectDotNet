using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanttProjectDotNet.Models.Xml
{
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
    }
}
