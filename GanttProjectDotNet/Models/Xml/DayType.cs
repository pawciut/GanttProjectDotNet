using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GanttProjectDotNet.Models.Xml
{
    public class DayType
    {
        /// <summary>
        /// 0 - working, 1 off day(weekend)?
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }
    }
}
