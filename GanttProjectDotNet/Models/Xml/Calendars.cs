using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GanttProjectDotNet.Models.Xml
{
    public class Calendars
    {
        [XmlElement(ElementName ="day-types")]
        public DayTypes DayTypes { get; set; }
    }
}
