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
    /// <summary>
    /// ganttproject\src\net\sourceforge\ganttproject\io\GanttXMLSaver.java
    /// </summary>
    public class GanttXMLSaver : SaverBase
    {
        private GanttProject myProject;
        private GanttGraphicArea area;
        private UIFacade myFacadeUI;

        const string VERSION = "2.8.9";
        const string LANGUAGE = "en_GB";



        public GanttXMLSaver(GanttProject project, TaskTreeUIFacade taskTree, GanttResourcePanel peop, GanttGraphicArea area, UIFacade uIFacade)
        {
            this.area = area;
            myProject = project;
        }

        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding { get { return Encoding.UTF8; } }
        }

        public void Save(Stream stream)
        {
            try
            {

                var doc = new XDocument();
                doc.Declaration = new XDeclaration("1.0", "utf-8", null);
                var root = new XElement(Constants.ProjectElement);
                doc.Add(root);

                root.AddAttribute(Constants.NameAttribute, myProject.ProjectName);
                root.AddAttribute(Constants.OrganizationAttribute, myProject.Organization);
                root.AddAttribute(Constants.MyWebLinkAttribute, myProject.MyWebLink);
                if (area != null)
                    root.AddAttribute(Constants.AreaStartDateAttribute, area.StartDate);
                if (myFacadeUI != null)
                {
                    root.AddAttribute(Constants.MyFacadeUIViewIndexAttribute, myFacadeUI.ViewIndex);
                    root.AddAttribute(Constants.MyFacadeUIGanttDividerLocationAttribute, myFacadeUI.GanttDividerLocation);
                    root.AddAttribute(Constants.MyFacadeUIResourceDividerLocationAttribute, myFacadeUI.ResourceDividerLocation);
                }
                root.AddAttribute(Constants.VERSIONAttribute, VERSION);
                root.AddAttribute(Constants.LANGUAGEAttribute, LANGUAGE);

                //// See https://bugs.openjdk.java.net/browse/JDK-8133452
                if (!String.IsNullOrEmpty(myProject.Description))
                    root.AddElement(Constants.DescriptionElement, myProject.Description, true);

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


                var stringWriter = new Utf8StringWriter();
                var settings = new XmlWriterSettings()
                {
                    Indent = true,
                    Encoding = Encoding.UTF8,
                };
                using (var writer = XmlWriter.Create(stringWriter, settings))
                {
                    doc.WriteTo(writer);
                }
                Console.WriteLine(stringWriter.ToString());
                File.WriteAllText(@"D:\Repos\GanttProjectDotNet\test.gan", stringWriter.ToString(), Encoding.UTF8);
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
