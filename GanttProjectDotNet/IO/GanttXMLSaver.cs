using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using GanttProjectDotNet.Models;

namespace GanttProjectDotNet.IO
{
    public class GanttXMLSaver : SaverBase
    {
        private GanttProject myProject;
        private GanttGraphicArea area;

        public GanttXMLSaver(GanttProject project, TaskTreeUIFacade taskTree, GanttResourcePanel peop, GanttGraphicArea area)
        {
            this.area = area;
            myProject = project;
        }

        public void Save(Stream stream)
        {
            try
            {

                var doc = new XDocument("project");
                doc.Declaration = new XDeclaration("1.0", "utf-8", null);

                var builder = new StringBuilder();
                var settings = new XmlWriterSettings()
                {
                    Indent = true,
                    Encoding = Encoding.UTF8
                };
                using (var writer = XmlWriter.Create(builder, settings))
                {
                    doc.WriteTo(writer);
                }
                Console.WriteLine(builder.ToString());
                File.AppendAllText(@"D:\Repos\GanttProjectDotNet", builder.ToString(), Encoding.UTF8);


                //AttributesImpl attrs = new AttributesImpl();
                //StreamResult result = new StreamResult(stream);
                //var handler = createHandler(result);
                //handler.AddFirst("project");
                //addAttribute("name", getProject().getProjectName(), attrs);
                //addAttribute("company", getProject().getOrganization(), attrs);
                //addAttribute("webLink", getProject().getWebLink(), attrs);
                //if (area != null)
                //{
                //    addAttribute("view-date", CalendarFactory.createGanttCalendar(area.getStartDate()).toXMLString(), attrs);
                //}
                //if (myUIFacade != null)
                //{
                //    addAttribute("view-index", "" + myUIFacade.getViewIndex(), attrs);
                //    // TODO for GP 2.0: move view configurations into <view> tag (see
                //    // ViewSaver)
                //    addAttribute("gantt-divider-location", "" + myUIFacade.getGanttDividerLocation(), attrs);
                //    addAttribute("resource-divider-location", "" + myUIFacade.getResourceDividerLocation(), attrs);
                //}
                //addAttribute("version", VERSION, attrs);
                //addAttribute("locale", GanttLanguage.getInstance().getLocale().toString(), attrs);
                //startElement("project", attrs, handler);
                ////
                //// See https://bugs.openjdk.java.net/browse/JDK-8133452
                //if (getProject().getDescription() != null)
                //{
                //    String projectDescription = getProject().getDescription().replace("\\r\\n", "\\n");
                //    cdataElement("description", projectDescription, attrs, handler);
                //}

                //saveViews(handler);
                //emptyComment(handler);
                //saveCalendar(handler);
                //saveTasks(handler);
                //saveResources(handler);
                //saveAssignments(handler);
                //saveVacations(handler);
                //saveHistory(handler);
                //saveRoles(handler);
                //endElement("project", handler);
                //handler.endDocument();

                //stream.close();
            }
            catch (Exception e)
            {
                //if (!GPLogger.log(e))
                //{
                //    e.printStackTrace(System.err);
                //}
                //IOException propagatedException = new IOException("Failed to save the project file");
                //propagatedException.initCause(e);
                //throw propagatedException;
            }
        }
    }
}
