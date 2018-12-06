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
            ganttProjectBuilder.Set("testProj", "desc123","MBD VC", "http://mypage.com");
            ganttGraphicAreaBuilder.Set("2018-06-01");
            uiFacadeBuilder.Set(0,656,300);

            //Act
            sut = BuildSut();
            sut.Save(null);

            //Assert


        }
    }
}
