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

        public GanttProjectBuilder2 AddDefaultTaskProperties()
        {
            if (instance.Tasks == null)
            {
                instance.Tasks = new Tasks();
                instance.Tasks.EmptyMilestones = true;
            }

            List<TaskProperty> propeties = null;
            if (instance.Tasks.Properties == null)
                propeties = new List<TaskProperty>();
            else
                propeties = new List<TaskProperty>(instance.Tasks.Properties);

            propeties.Add(new TaskProperty("tpd0", "type", "default", EValueType.Icon));
            propeties.Add(new TaskProperty("tpd1", "priority", "default", EValueType.Icon));
            propeties.Add(new TaskProperty("tpd2", "info", "default", EValueType.Icon));
            propeties.Add(new TaskProperty("tpd3", "name", "default", EValueType.Text));
            propeties.Add(new TaskProperty("tpd4", "begindate", "default", EValueType.Date));
            propeties.Add(new TaskProperty("tpd5", "enddate", "default", EValueType.Date));
            propeties.Add(new TaskProperty("tpd6", "duration", "default", EValueType.Int));
            propeties.Add(new TaskProperty("tpd7", "completion", "default", EValueType.Int));
            propeties.Add(new TaskProperty("tpd8", "coordinator", "default", EValueType.Text));
            propeties.Add(new TaskProperty("tpd9", "predecessorsr", "default", EValueType.Text));
            propeties.Add(new TaskProperty("tpc0", "MyId", "custom", EValueType.Text));

            instance.Tasks.Properties = propeties.ToArray();
            return this;

        }

        public GanttProjectBuilder2 AddTestTasks()
        {
            for (int i = 1; i <= 10; ++i)
            {
                var task = new TasksNode(i.ToString(),$"test task{i}",false, DateTime.Now.AddDays(i),false, DateTime.Now, 1+i%3,false,false, "#ffcc33",String.Empty);
                if (i == 2)
                {
                    task.Expand = true;
                    for (int j = 11; j <= 13; ++j)
                    {
                        task.AddTask(new TasksNode(j.ToString(), $"test Subtask{j}", false, DateTime.Now.AddDays(i), true, DateTime.Now.AddDays(20), 1 + i % 3, false, false, "#8cb6ce", "http://www.touchegolfschool.com/images/"+(j-10)+".jpg"));
                    }
                    var st3 = task.Subtasks[2];
                    task.Subtasks[1].AddSuccessor(st3.Id, ETaskDependencyType.Finish_Finish,0, ETaskDependencyHardness.Strong);
                }
                instance.Tasks.AddTask(task);
            }
            return this;
        }
    }
}
