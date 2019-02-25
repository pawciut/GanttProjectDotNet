using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GanttProjectDotNet.Models.Xml
{
    public class TasksNode
    {
        public TasksNode()
        {
        }

        public TasksNode(string id, string name, bool isMeeting, DateTime start,
            bool isEarliestBeginEnabled, DateTime earliestBegin, int duration, bool isComplete,
            bool isExpanded, string color, string webLink)
        {
            this.Id = id;
            this.Name = name;
            this.IsMeeting = isMeeting;
            this.Start = start.ToGPDateString();
            this.EarliestBeginEnabled = isEarliestBeginEnabled.ToGPBoolToInt();
            this.EarliestBegin = earliestBegin.ToGPDateString();
            this.Duration = duration;
            this.Complete = isComplete.ToGPBoolToInt();
            this.Expand = isExpanded;
            this.Color = color;
            this.WebLink = webLink;
        }

        [XmlAttribute(AttributeName ="id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "meeting")]
        public bool IsMeeting { get; set; }

        /// <summary>
        /// start date
        /// </summary>
        [XmlAttribute(AttributeName = "start")]
        public string Start { get; set; }

        /// <summary>
        /// flag is earliest begin on ex:0
        /// </summary>
        [XmlAttribute(AttributeName = "thirdDate-constraint")]
        public int EarliestBeginEnabled { get; set; }

        /// <summary>
        /// earliest begin date ex:2018-06-14
        /// </summary>
        [XmlAttribute(AttributeName = "thirdDate")]
        public string EarliestBegin { get; set; }

        /// <summary>
        /// days?
        /// </summary>
        [XmlAttribute(AttributeName = "duration")]
        public int Duration { get; set; }
        /// <summary>
        /// 0 or 1?
        /// </summary>
        [XmlAttribute(AttributeName = "complete")]
        public int Complete { get; set; }
        /// <summary>
        /// for grouping tasks?
        /// </summary>
        [XmlAttribute(AttributeName = "expand")]
        public bool Expand { get; set; }

        /// <summary>
        /// ex: #ffcc33
        /// </summary>
        [XmlAttribute(AttributeName = "color")]
        public string Color { get; set; }

        [XmlAttribute(AttributeName = "webLink")]
        public string WebLink { get; set; }

        [XmlElement(ElementName = "task")]
        public TasksNode[] Subtasks { get; set; }


        public void AddTask(TasksNode node)
        {
            //bez sprawdzania czy taki task juz istnieje
            List<TasksNode> items = null;
            if (Subtasks == null)
                items = new List<TasksNode>();
            else
                items = new List<TasksNode>(Subtasks);
            items.Add(node);
            Subtasks = items.ToArray();
        }
    }
}
