using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Schema;
using System.Web.Script.Serialization;

namespace MvcApplication1
{
    public static class Common
    {
        public static void validateXML(String xml, String xsd)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            string x = HttpContext.Current.Server.MapPath(xsd);
            settings.Schemas.Add("http://hl7.org/fhir", x);
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationHandler);
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            XmlReader reader = XmlReader.Create(new StringReader(xml), settings);

            while (reader.Read()) ;
        }

        static void ValidationHandler(object sender, ValidationEventArgs args)
        {
            throw new InvalidXmlException(args.Message);
            //Console.WriteLine("WARNING: xsd validation failed, invalid: " + args.Message);
        }

        public class InvalidXmlException : Exception
        {
            public string error;
            public InvalidXmlException(string p)
            {
                error = p;
            }
            public InvalidXmlException()
            {
            }
        }

		public static string GetDate(DateTime DateTime)
        {
            DateTime UtcDateTime = TimeZoneInfo.ConvertTimeToUtc(DateTime);
            return XmlConvert.ToString(UtcDateTime, XmlDateTimeSerializationMode.Utc);
        }

        public static string ToJSON(this object obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(obj);
        }

        public static string ToJSON(this object obj, int recursionDepth)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.RecursionLimit = recursionDepth;
            return serializer.Serialize(obj);
        }


        public static string addtoxml(string xml, string error)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);
            XmlDocumentFragment frag = xdoc.CreateDocumentFragment();
            frag.InnerXml = "<!--<xsdvalidationerrors>" + error + "</xsdvalidationerrors>-->";
            xdoc.DocumentElement.AppendChild(frag);

            StringWriter sw = new StringWriter();
            XmlWriter xmlw = XmlWriter.Create(sw);
            xdoc.WriteTo(xmlw);
            xmlw.Flush();

            return sw.GetStringBuilder().ToString();
        }
    }
}

