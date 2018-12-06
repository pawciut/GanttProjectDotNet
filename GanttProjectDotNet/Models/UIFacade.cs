using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanttProjectDotNet.Models
{
    public class UIFacade
    {
        public int ViewIndex { get; set; }
        public int GanttDividerLocation { get; set; }
        public int ResourceDividerLocation { get; set; }
        //    // TODO for GP 2.0: move view configurations into <view> tag (see
        //    // ViewSaver)
    }
}
