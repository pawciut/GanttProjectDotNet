﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GanttProjectDotNet.Models.Xml
{
    public class TaskProperty
    {
        [XmlAttribute]
        public string MyProperty { get; set; }
    }
}
