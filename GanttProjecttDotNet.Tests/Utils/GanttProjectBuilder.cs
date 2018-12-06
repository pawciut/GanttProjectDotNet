using GanttProjectDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanttProjecttDotNet.Tests.Utils
{
    public class GanttProjectBuilder : BaseBuilder<GanttProject>
    {
        public GanttProjectBuilder Set(string projectName, string description, string organization, string myWebLink)
        {
            instance.ProjectName = projectName;
            instance.Description = description;
            instance.Organization = organization;
            instance.MyWebLink = myWebLink;
            return this;
        }
    }
}
