using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GanttProjectDotNet.Models.Xml
{
    public class Tasks
    {
        [XmlAttribute(AttributeName ="empty-milestones")]
        public bool EmptyMilestones { get; set; }

        [XmlArray(ElementName ="taskproperties")]
        public TaskProperty[] Properties { get; set; }
    }
}
