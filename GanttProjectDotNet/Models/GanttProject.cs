using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GanttProjectDotNet.Models
{
    public class GanttProject
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string Organization { get; set; }
        public string MyWebLink { get; set; }

        public WeekendCalendar MyCalendar { get; set; }
    }
}
