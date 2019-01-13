using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GanttProjectDotNet.Models.Xml
{
    public class DayTypes
    {
        [XmlElement(ElementName ="day-type")]
        public DayType[] Items { get; set; }

        [XmlElement(ElementName ="default-week")]
        public DefaultWeek DefaultWeek { get; set; }

        [XmlElement(ElementName = "only-show-weekends")]
        public OnlyShowWeekends OnlyShowWeekends { get; set; }

        [XmlElement(ElementName ="overriden-day-types")]
        public string OverridenDayTypes { get; set; }
        [XmlElement(ElementName = "days")]
        public string Days { get; set; }



        public void AddDayType(DayType item)
        {
            var list = Items == null? new List<DayType>() : new List<DayType>(Items);
            list.Add(item);
            Items = list.ToArray();
        }
    }
}
