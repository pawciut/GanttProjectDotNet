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

        public GanttProjectBuilder2 AddDayType(int id)
        {
            if (instance.Calendars == null)
                instance.Calendars = new Calendars();
            if (instance.Calendars.DayTypes == null)
                instance.Calendars.DayTypes = new DayTypes();
            instance.Calendars.DayTypes.AddDayType(new DayType() { Id = id });
            return this;
        }

        public GanttProjectBuilder2 AddDefaultWeek()
        {
            if (instance.Calendars == null)
                instance.Calendars = new Calendars();
            if (instance.Calendars.DayTypes == null)
                instance.Calendars.DayTypes = new DayTypes();
            instance.Calendars.DayTypes.DefaultWeek = new DefaultWeek
            {
                Id = 1,
                Name = "default",
                Sun = 1,
                Mon = 0,
                Tue = 0,
                Wed = 0,
                Thu = 0,
                Fri = 0,
                Sat = 1
            };
            instance.Calendars.DayTypes.OnlyShowWeekends = new OnlyShowWeekends { Value = false };

            return this;

        }


    }
}
