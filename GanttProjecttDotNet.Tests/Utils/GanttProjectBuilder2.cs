using GanttProjectDotNet.Models.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanttProjecttDotNet.Tests.Utils
{
    public class GanttProjectBuilder2 : BaseBuilder<GanttProject>
    {
        public GanttProjectBuilder2 SetHeader(
            string projectName, string description, string organization,
            string myWebLink, string startDate, int viewIndex,
            int ganttDividerLocation, int resourceDividerLocation,
            string version, string locale)
        {
            instance.Name = projectName;
            instance.Description = description;
            instance.Company = organization;
            instance.WebLink = myWebLink;

            instance.ViewDate = startDate;
            instance.ViewIndex = viewIndex;
            instance.GanttDividerLocation = ganttDividerLocation;
            instance.ResourceDividerLocation = resourceDividerLocation;

            instance.Version = version;
            instance.Locale = locale;
            return this;
        }
    }
}
