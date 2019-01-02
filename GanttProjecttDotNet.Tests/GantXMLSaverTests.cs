using System;
using GanttProjectDotNet.IO;
using GanttProjecttDotNet.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GanttProjecttDotNet.Tests
{
    [TestClass]
    public class GantXMLSaverTests
    {
        GanttXMLSaver sut;
        GanttProjectBuilder ganttProjectBuilder = new GanttProjectBuilder();
        UIFacadeBuilder uiFacadeBuilder = new UIFacadeBuilder();
        GanttGraphicAreaBuilder ganttGraphicAreaBuilder = new GanttGraphicAreaBuilder();

        GanttXMLSaver BuildSut()
        {
            return new GanttXMLSaver(ganttProjectBuilder.Build(), null, null, ganttGraphicAreaBuilder.Build(), uiFacadeBuilder.Build());
        }

        [TestMethod]    
        public void ShouldSaveProject()
        {
            //Arrange
            string projectName = "testProj";
            string description = "desc123";
            string company = "MBD VC";
            string website = "http://mypage.com";
            string startDate = "2018-06-01";

            ganttProjectBuilder.Set(projectName, description , company, website);
            ganttGraphicAreaBuilder.Set(startDate);
            uiFacadeBuilder.Set(0,656,300);

            //Act
            sut = BuildSut();
            sut.Save(null);

            GantXMLOpen open = new GantXMLOpen();
            open.Load();

            //Assert
            Assert.AreEqual(projectName, open.myProject.ProjectName);
            Assert.AreEqual(description, open.myProject.Description);
            Assert.AreEqual(company, open.myProject.Organization);
            Assert.AreEqual(website, open.myProject.MyWebLink);


        }
    }
}
