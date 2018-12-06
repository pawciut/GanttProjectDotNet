using GanttProjectDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanttProjecttDotNet.Tests.Utils
{
    public class UIFacadeBuilder : BaseBuilder<UIFacade>
    {
        public UIFacadeBuilder Set(int viewIndex, int ganttDividerLocation, int resourceDividerLocation)
        {
            instance.ViewIndex = viewIndex;
            instance.GanttDividerLocation = ganttDividerLocation;
            instance.ResourceDividerLocation = resourceDividerLocation;
            return this;
        }
    }
}
