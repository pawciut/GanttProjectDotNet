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
        public Tasks()
        {
        }

        [XmlAttribute(AttributeName = "empty-milestones")]
        public bool EmptyMilestones { get; set; }

        [XmlArray(ElementName = "taskproperties")]
        [XmlArrayItem(ElementName = "taskproperty")]
        public TaskProperty[] Properties { get; set; }

        /// <summary>
        /// Tasks - Items
        /// </summary>
        [XmlElement(ElementName = "task")]
        public TasksNode[] Items { get; set; }

        public void AddTask(TasksNode node)
        {
            //bez sprawdzania czy taki task juz istnieje
            List<TasksNode> items = null;
            if (Items == null)
                items = new List<TasksNode>();
            else
                items = new List<TasksNode>(Items);
            items.Add(node);
            Items = items.ToArray();
        }
    }
}
