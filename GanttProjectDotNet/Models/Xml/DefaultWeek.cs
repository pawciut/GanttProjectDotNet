using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GanttProjectDotNet.Models.Xml
{
    public class DefaultWeek
    {
        [XmlAttribute(AttributeName ="default-week")]
        public int Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "sun")]
        public int Sun { get; set; }
        [XmlAttribute(AttributeName = "mon")]
        public int Mon { get; set; }
        [XmlAttribute(AttributeName = "tue")]
        public int Tue { get; set; }
        [XmlAttribute(AttributeName = "wed")]
        public int Wed { get; set; }
        [XmlAttribute(AttributeName = "thu")]
        public int Thu { get; set; }
        [XmlAttribute(AttributeName = "fri")]
        public int Fri { get; set; }
        [XmlAttribute(AttributeName = "sat")]
        public int Sat { get; set; }
    }
}
