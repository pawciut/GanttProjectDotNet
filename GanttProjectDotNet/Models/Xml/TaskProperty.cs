using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GanttProjectDotNet.Models.Xml
{
    public class TaskProperty
    {
        public TaskProperty()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="valuetype">icon,text,date,int</param>
        public TaskProperty( string id, string name, string type, EValueType valuetype)
        {
            Id = id;
            Name = name;
            Type = type;
            ValueType = valuetype.ToXmlString();
        }

        [XmlAttribute(AttributeName ="id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "valuetype")]
        public string ValueType { get; set; }
    }
}
