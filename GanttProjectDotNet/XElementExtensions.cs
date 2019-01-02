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
        public static XAttribute AddAttribute(this XElement element, string attribute, object value, bool cdata = false)
        {
            XAttribute attr = null;
            if (element.HasAttributes
                && (attr = element.Attributes().FirstOrDefault(at => at.Name.LocalName == attribute)) != null)
                attr.SetValue(cdata ? new XCData((string)value) : value);
            else
            {
                attr = new XAttribute(attribute, cdata ? new XCData((string)value) : value);
                element.Add(attr);
            }
            return attr;
        }

        public static string GetAttribute(this XElement element, string attributeName)
        {
            return element.Attribute(attributeName).Value;
        }
        public static int GetAttributeINT(this XElement element, string attributeName)
        {
            return int.Parse(element.GetAttribute(attributeName));
        }

        public static XElement AddElement(this XElement element, string name, object value, bool cdata = false)
        {
            var newElement = new XElement(name, cdata ? new XCData((string)value) : value);
            element.Add(newElement);
            return newElement;
        }

        public static string GetElementValue(this XElement element, string elementName, bool cdata = false)
        {
            if(cdata)
            {
                XNode valueNode;
                if ((valueNode = element.Nodes().FirstOrDefault(n => n.NodeType == System.Xml.XmlNodeType.CDATA)) != null)
                {
                    return (valueNode as XCData).Value;
                }
                else;
                {
                    throw new Exception("CDATA not found");
                }
            }
            return element.Element(elementName).Value;
        }

    }
}
