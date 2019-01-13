using System;
using GanttProjectDotNet.IO;
using GanttProjectDotNet.Models.Xml;
using GanttProjecttDotNet.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GanttProjecttDotNet.Tests
{
    [TestClass]
    public class GanttProjectTests
    {
        GanttProjectBuilder2 builder;
        GanttProject sut;

        [TestInitialize]
        public void Init()
        {
            builder = new GanttProjectBuilder2();
        }

        GanttProject BuildSut()
        {
            return builder.Build();
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

            builder.SetHeader(projectName, description, company, website, startDate, 0, 656, 300,"2.8.9", "en_GB");

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
