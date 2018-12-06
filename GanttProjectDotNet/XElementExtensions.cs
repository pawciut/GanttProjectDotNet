using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GanttProjectDotNet
{
    public static class XElementExtensions
    {
        public static XAttribute AddAttribute(this XElement element, string attribute, object value, bool cdata= false)
        {
            var attr = new XAttribute("name", cdata? new XCData((string)value) : value);
            element.Add(attr);
            return attr;
        }

        public static XElement AddElement(this XElement element, string name, object value, bool cdata = false)
        {
            var newElement = new XElement("name", cdata ? new XCData((string)value) : value);
            element.Add(newElement);
            return newElement;
        }
    }
}
