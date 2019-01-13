using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static GanttProjectDotNet.IO.GanttXMLSaver;

namespace GanttProjectDotNet.Models.Xml
{
    [XmlRoot(ElementName = "project")]
    public class GanttProject
    {

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "company")]
        public string Company { get; set; }
        [XmlAttribute(AttributeName = "webLink")]
        public string WebLink { get; set; } = "http://";

        [XmlAttribute(AttributeName = "view-date")]
        public string ViewDate { get; set; }
        [XmlAttribute(AttributeName = "view-index")]
        public int ViewIndex { get; set; } = 0;

        [XmlAttribute(AttributeName = "gantt-divider-location")]
        public int GanttDividerLocation { get; set; } = 650;
        [XmlAttribute(AttributeName = "resource-divider-location")]
        public int ResourceDividerLocation { get; set; } = 300;

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "locale")]
        public string Locale { get; set; } = "en_GB";

        [XmlElement(ElementName = "description")]
        public CData Description { get; set; }

        [XmlElement(ElementName = "calendars")]
        public Calendars Calendars { get; set; }







        public void Save(string path)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

            //Add an empty namespace and empty value
            ns.Add("", "");

            XmlSerializer serializer = new XmlSerializer(typeof(GanttProject));
            var subReq = this;
            var xml = "";

            var stringWriter = new Utf8StringWriter();
            var settings = new XmlWriterSettings()
            {
                Indent = true,
                Encoding = Encoding.UTF8,
            };

            using (var ms = new MemoryStream())
            {
                using (var xw = XmlWriter.Create(ms, settings)) // Remember to stop using XmlTextWriter  
                {
                    serializer = new XmlSerializer(typeof(GanttProject));
                    serializer.Serialize(xw, this, ns);
                    xw.Flush();
                }
                ms.Seek(0, SeekOrigin.Begin);
                using (var sr = new StreamReader(ms, Encoding.UTF8))
                {
                    xml = sr.ReadToEnd();
                }
            }

            Console.WriteLine(xml);
            File.WriteAllText(@"D:\Repos\GanttProjectDotNet\test.gan", xml, Encoding.UTF8);
        }

    }
}
