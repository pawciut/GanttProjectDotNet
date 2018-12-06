using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GanttProjectDotNet.IO
{
    public class SaverBase
    {
        protected XDocument createHandler()
        {
            var doc = new XDocument();
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

            //TODO:
            return doc;
        }




        //------------------------------

  //      protected TransformerHandler createHandler(Result result) throws TransformerConfigurationException
  //      {
  //          SAXTransformerFactory factory = (SAXTransformerFactory) SAXTransformerFactory.newInstance();
  //          TransformerHandler handler = factory.newTransformerHandler();
  //          Transformer serializer = handler.getTransformer();
  //          serializer.setOutputProperty(OutputKeys.ENCODING, "UTF-8");
  //          serializer.setOutputProperty(OutputKeys.INDENT, "yes");
  //          serializer.setOutputProperty(OutputKeys.METHOD, "xml");
  //          serializer.setOutputProperty("{http://xml.apache.org/xslt}indent-amount", "4");
  //          handler.setResult(result);
  //          return handler;
  //      }

  //  protected void startElement(String name, TransformerHandler handler) throws SAXException
  //  {
  //      startElement(name, ourEmptyAttributes, handler);
  //  }

  //  protected void startElement(String name, AttributesImpl attrs, TransformerHandler handler) throws SAXException
  //  {
  //      handler.startElement("", name, name, attrs);
  //      attrs.clear();
  //  }

  //  protected void endElement(String name, TransformerHandler handler) throws SAXException
  //  {
  //      handler.endElement("", name, name);
  //  }

  //  protected void addAttribute(String name, String value, AttributesImpl attrs)
  //  {
  //      if (value != null)
  //      {
  //          attrs.addAttribute("", name, name, "CDATA", value);
  //      }
  //  }

  //  protected void addAttribute(String name, int value, AttributesImpl attrs)
  //  {
  //      addAttribute(name, String.valueOf(value), attrs);
  //  }

  //  protected void addAttribute(String name, Boolean value, AttributesImpl attrs)
  //  {
  //      addAttribute(name, value.toString(), attrs);
  //  }

  //  protected void emptyElement(String name, AttributesImpl attrs, TransformerHandler handler) throws SAXException
  //  {
  //      startElement(name, attrs, handler);
  //      endElement(name, handler);
  //      attrs.clear();
  //  }

  //  protected void cdataElement(String name, String cdata, AttributesImpl attrs, TransformerHandler handler)
  //    throws SAXException
  //  {
  //  if (cdata == null) {
  //          return;
  //      }
  //      startElement(name, attrs, handler);
  //      handler.startCDATA();
  //      handler.characters(cdata.toCharArray(), 0, cdata.length());
  //      handler.endCDATA();
  //      endElement(name, handler);
  //  }

  //  protected void emptyComment(TransformerHandler handler) throws SAXException
  //  {
  //      handler.comment(new char[] { ' ' }, 0, 1);

  //}

  //private static AttributesImpl ourEmptyAttributes = new AttributesImpl();


    }
}
