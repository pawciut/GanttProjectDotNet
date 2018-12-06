using GanttProjectDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanttProjecttDotNet.Tests.Utils
{
    public class GanttGraphicAreaBuilder : BaseBuilder<GanttGraphicArea>
    {
        public GanttGraphicAreaBuilder Set(string startDate)
        {
            instance.StartDate = startDate;
            return this;
        }
    }
}
