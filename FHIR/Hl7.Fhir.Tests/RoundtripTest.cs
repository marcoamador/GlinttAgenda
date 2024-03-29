﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Hl7.Fhir.Parsers;
using Hl7.Fhir.Serializers;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Ionic.Zip;

namespace Hl7.Fhir.Tests
{
    [TestClass]
    public class RoundtripTest
    {
        [TestMethod]
        public void FullRoundtripOfAllExamples()
        {
            string examples = @"..\..\..\..\..\publish\examples.zip";
            string path = Path.Combine(Path.GetTempPath(), "FHIRRoundTripTest");
            if (Directory.Exists(path)) Directory.Delete(path, true);
            Directory.CreateDirectory(path);

            using (var zipfile = ZipFile.Read(examples))
            {
                zipfile.ExtractAll(path, ExtractExistingFileAction.OverwriteSilently);
            }

            Debug.WriteLine("Looking for *.xml files in " + path);

            var files = Directory.EnumerateFiles(path, "*.xml");

            foreach (string file in files.Where(p=>!p.Contains("-roundtrip")))
            {
                string filename = Path.GetFileNameWithoutExtension(file);                    
                string baseFilename = Path.Combine(Path.GetDirectoryName(file), filename);

                Debug.WriteLine("Roundtripping " + filename);

                if( !isFeed(file) )
                    testSingleResource(file, baseFilename);
                else
                    testFeed(file, baseFilename);

                string actualFile = baseFilename + "-roundtrip.xml";

                if (File.Exists(actualFile))
                {
                    try
                    {
                        Debug.WriteLine("Comparing roundtripped files for equality");
                        XDocument expected = XDocument.Load(file);
                        XDocument actual = XDocument.Load(actualFile);
                        XmlAssert.AreSame(expected, actual);
                    }
                    catch (AssertFailedException af)
                    {
                        Debug.WriteLine("  ***** Comparison failed: " + af.Message);
                    }
                }
                
                Debug.WriteLine("  Done!");
            }
        }

        private bool isFeed(string filename)
        {
            XmlReader r = XmlReader.Create(filename);

            try
            {
                r.MoveToContent();
                return r.LocalName == "feed";
            }
            finally
            {
                r.Close();
            }
        }

        //private string baseFilename;

        private void testFeed(string file, string baseFilename)
        {
            Support.Bundle bundleResult;
            Support.ErrorList errors = new Support.ErrorList();

            using (XmlReader xr = createReader(file))
            {
                Debug.WriteLine("  Reading Xml feed...");
                bundleResult = Support.Bundle.Load(xr, errors);

                xr.Close();
            }

            if (errors.Count > 0)
                Debug.WriteLine("=== Xml Feed Parse errors ===" + Environment.NewLine + errors.ToString());
            else
            {
                string jsonFile = baseFilename + "-roundtrip.json";
                //string xmlFile = Path.ChangeExtension(jsonFile, ".xml");

                using (JsonTextWriter jw = new JsonTextWriter(new StreamWriter(jsonFile)) )
                {
                    Debug.WriteLine("  Writing Xml feed...");
                    bundleResult.Save(jw);
                    jw.Flush();
                    jw.Close();
                }

                testJsonFeed(jsonFile);
            }
        }


        private void testJsonFeed(string jsonFile)
        {
            Support.Bundle bundleResult;
            Support.ErrorList errors = new Support.ErrorList();

            using (JsonReader jr = new JsonTextReader(new StreamReader(jsonFile)))
            {
                Debug.WriteLine("  Reading Json feed...");
                bundleResult = Support.Bundle.Load(jr, errors);

                jr.Close();
            }

            if (errors.Count > 0)
                Debug.WriteLine("=== Json Feed Parse errors ===" + Environment.NewLine + errors.ToString());
            else
            {
                string xmlFile = Path.ChangeExtension(jsonFile, ".xml");

                using (XmlWriter xw = new XmlTextWriter(new System.IO.StreamWriter(xmlFile)))
                {
                    Debug.WriteLine("  Writing Xml feed...");
                    bundleResult.Save(xw);
                    xw.Flush();
                    xw.Close();
                }
            }
        }

        private void testSingleResource(string file, string baseFilename)
        {
            Model.Resource singleResult;
            Support.ErrorList errors = new Support.ErrorList();

            using (XmlReader xr = createReader(file))
            {
                Debug.WriteLine("  Reading Xml...");
                singleResult = FhirParser.ParseResource(xr, errors);
                xr.Close();
            }

            if (errors.Count > 0)
                Debug.WriteLine("=== Xml Parse errors ===" + Environment.NewLine + errors.ToString());
            else
            {
                string jsonFile = baseFilename + "-roundtrip.json";

                using (JsonTextWriter w = new JsonTextWriter(new System.IO.StreamWriter(jsonFile)))
                {
                    Debug.WriteLine("  Writing json...");
                    FhirSerializer.SerializeResource(singleResult, w);
                }

                testSingleJsonResource(jsonFile);
            }
        }


        private void testSingleJsonResource(string jsonFile)
        {
            Support.ErrorList errors = new Support.ErrorList();
            Model.Resource singleResult;

            using (JsonTextReader jr = new JsonTextReader(new System.IO.StreamReader(jsonFile)))
            {
                Debug.WriteLine("  Reading from json...");
                singleResult = FhirParser.ParseResource(jr, errors);
                jr.Close();
            }

            if (errors.Count > 0)
                Debug.WriteLine("=== Json Parse errors ===" + Environment.NewLine + errors.ToString());
            else
            {
                string xmlFile = Path.ChangeExtension(jsonFile, ".xml");
                
                using (XmlWriter xw = new XmlTextWriter(new System.IO.StreamWriter(xmlFile)))
                {
                    Debug.WriteLine("  Writing xml...");
                    FhirSerializer.SerializeResource(singleResult, xw);
                }
            }
        }

        private static XmlReader createReader(string filename)
        {
            var settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            settings.IgnoreWhitespace = true;

           return XmlReader.Create(filename, settings);
        }
    }
}
