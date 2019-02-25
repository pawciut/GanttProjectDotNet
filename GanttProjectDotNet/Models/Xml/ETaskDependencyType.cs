using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanttProjectDotNet.Models.Xml
{
    public enum ETaskDependencyType
    {
        Start_Start = 1,
        Finish_Start = 2,
        Finish_Finish = 3,
        Start_Finish = 4,
    }
}
