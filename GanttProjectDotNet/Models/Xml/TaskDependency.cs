using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GanttProjectDotNet.Models.Xml
{
    public class TaskDependency
    {
        public TaskDependency()
        {
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="id">successor id</param>
       /// <param name="type"></param>
       /// <param name="delay"></param>
       /// <param name="linkHardness"></param>
        public TaskDependency(string id, ETaskDependencyType type, int delay, ETaskDependencyHardness linkHardness)
        {
            this.Id = id;
            this.Type = EnumUtils.ToXmlString(type);
            this.Delay = delay;
            this.LinkHardness = EnumUtils.ToXmlString(linkHardness);
        }

        [XmlAttribute(AttributeName ="id")]
        public string Id { get; set; }
        

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        

        [XmlAttribute(AttributeName = "difference")]
        public int Delay { get; set; }
        
        [XmlAttribute(AttributeName = "hardness")]
        public string LinkHardness { get; set; } 
    }
}
