using GanttProjectDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GanttProjectDotNet.IO
{
    /// <summary>
    /// ganttproject\src\net\sourceforge\ganttproject\io\GanttXMLOpen.java
    /// </summary>
    public class GantXMLOpen
    {
        public GanttProject myProject;
        private GanttGraphicArea area;
        private UIFacade myFacadeUI;

        string VERSION = "2.8.9";
        string LANGUAGE = "en_GB";

        public void Load()
        {
            var filename = @"D:\Repos\GanttProjectDotNet\test.gan";
            var doc = XDocument.Load(filename);
            myProject = new GanttProject();
            area = new GanttGraphicArea();
            myFacadeUI = new UIFacade();

            myProject.ProjectName = doc.Root.GetAttribute(Constants.NameAttribute);
            myProject.Organization = doc.Root.GetAttribute(Constants.OrganizationAttribute);
            myProject.MyWebLink = doc.Root.GetAttribute(Constants.MyWebLinkAttribute);

            area.StartDate = doc.Root.GetAttribute(Constants.AreaStartDateAttribute);
            
            if(doc.Root.Attribute(Constants.MyFacadeUIViewIndexAttribute) != null)
                myFacadeUI.ViewIndex = doc.Root.GetAttributeINT(Constants.MyFacadeUIViewIndexAttribute);
            if (doc.Root.Attribute(Constants.MyFacadeUIGanttDividerLocationAttribute) != null)
                myFacadeUI.GanttDividerLocation = doc.Root.GetAttributeINT(Constants.MyFacadeUIGanttDividerLocationAttribute);
            if (doc.Root.Attribute(Constants.MyFacadeUIResourceDividerLocationAttribute) != null)
                myFacadeUI.ResourceDividerLocation = doc.Root.GetAttributeINT(Constants.MyFacadeUIResourceDividerLocationAttribute);

            VERSION = doc.Root.GetAttribute(Constants.VERSIONAttribute);
            LANGUAGE = doc.Root.GetAttribute(Constants.LANGUAGEAttribute);

            ////// See https://bugs.openjdk.java.net/browse/JDK-8133452
            //if (!String.IsNullOrEmpty(myProject.Description))
            //    root.AddElement("description", myProject.Description, true);

            myProject.Description = doc.Root.Element(Constants.DescriptionElement).GetElementValue(Constants.DescriptionElement, true);

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


        //    public void startElement(String namespaceURI, String sName, String qName, Attributes attrs)
        //    {
        //        clearCdata();
        //        String eName = sName; // element name
        //        if ("".equals(eName))
        //        {
        //            eName = qName; // not namespace aware
        //        }
        //        setTagStarted(myTags.contains(eName));
        //        hasCdata = "description".equals(eName) || "notes".equals(eName);
        //        if (eName.equals("tasks"))
        //        {
        //            myTaskManager.setZeroMilestones(null);
        //        }
        //        if (attrs != null)
        //        {
        //            for (int i = 0; i < attrs.getLength(); i++)
        //            {
        //                String aName = attrs.getLocalName(i); // Attr name
        //                if ("".equals(aName))
        //                {
        //                    aName = attrs.getQName(i);
        //                    // The project part
        //                }
        //                if (eName.equals("project"))
        //                {
        //                    if (aName.equals("name"))
        //                    {
        //                        myProjectInfo.setName(attrs.getValue(i));
        //                    }
        //                    else if (aName.equals("company"))
        //                    {
        //                        myProjectInfo.setOrganization(attrs.getValue(i));
        //                    }
        //                    else if (aName.equals("webLink"))
        //                    {
        //                        myProjectInfo.setWebLink(attrs.getValue(i));
        //                    }
        //                    // TODO: 1.12 repair scrolling to the saved date
        //                    else if (aName.equals("view-date"))
        //                    {
        //                        myUIFacade.getScrollingManager().scrollTo(GanttCalendar.parseXMLDate(attrs.getValue(i)).getTime());
        //                    }
        //                    else if (aName.equals("view-index"))
        //                    {
        //                        viewIndex = new Integer(attrs.getValue(i)).hashCode();
        //                    }
        //                    else if (aName.equals("gantt-divider-location"))
        //                    {
        //                        ganttDividerLocation = new Integer(attrs.getValue(i)).intValue();
        //                    }
        //                    else if (aName.equals("resource-divider-location"))
        //                    {
        //                        resourceDividerLocation = new Integer(attrs.getValue(i)).intValue();
        //                    }
        //                }
        //                else if (eName.equals("tasks"))
        //                {
        //                    if ("empty-milestones".equals(aName))
        //                    {
        //                        myTaskManager.setZeroMilestones(Boolean.parseBoolean(attrs.getValue(i)));
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    @Override
        //public void endElement(String namespaceURI, String sName, String qName)
        //    {
        //        if (!myTags.contains(qName))
        //        {
        //            return;
        //        }
        //        if ("description".equals(qName))
        //        {
        //            myProjectInfo.setDescription(getCdata());
        //        }
        //        else if ("notes".equals(qName))
        //        {
        //            Task currentTask = getContext().peekTask();
        //            currentTask.setNotes(getCdata());
        //        }
        //        hasCdata = false;
        //        setTagStarted(false);
        //    }

    }
}
