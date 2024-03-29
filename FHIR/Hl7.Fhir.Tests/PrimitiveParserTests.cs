﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Fhir.Model;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Newtonsoft.Json;
using Hl7.Fhir.Parsers;
using Hl7.Fhir.Support;


namespace Hl7.Fhir.Tests
{
    [TestClass]
    public class PrimitiveParserTests
    {
        [TestMethod]
        public void TestBasicTypePatterns()
        {
            Id result;

            bool succ = Id.TryParse("az23", out result);
            Assert.IsTrue(succ);

            succ = Id.TryParse("!notgood!", out result);
            Assert.IsFalse(succ);

            succ = Id.TryParse("NotGood", out result);
            Assert.IsFalse(succ);

            succ = Id.TryParse("1234567890123456789012345678901234567", out result);
            Assert.IsFalse(succ);
        }

        [TestMethod]
        public void TestContinueOnEmptyElements()
        {
            string xmlString = "<x xmlns='http://hl7.org/fhir'><someElem value='true' id='3141' /><someElem2 /></x>";
            XmlReader xr = fromString(xmlString); xr.Read();
            XmlFhirReader xfr = new XmlFhirReader(xr);
            xfr.MoveToContent();

            verifyContinueOnEmptyElements(xfr);

            string jsonString = @"{ ""x"" : 
                                        { ""someElem"" : { ""value"" : ""true"", ""_id"" : ""3141"" },
                                          ""someElem2"" : {} } }";
            JsonTextReader jr = new JsonTextReader(new StringReader(jsonString));
            JsonFhirReader jfr = new JsonFhirReader(jr);
            jfr.MoveToContent();
            verifyContinueOnEmptyElements(jfr);
        }

        private XmlReader fromString(string s)
        {
            var settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            settings.IgnoreWhitespace = true;

            XmlReader r = XmlReader.Create(new StringReader(s), settings);

            return r;
        }

        private static void verifyContinueOnEmptyElements(IFhirReader xfr)
        {
            Assert.AreEqual("x", xfr.CurrentElementName);
            xfr.EnterElement();

            Assert.IsTrue(xfr.IsAtFhirElement());
            Assert.AreEqual("someElem", xfr.CurrentElementName);
            xfr.EnterElement();
            Assert.IsTrue(xfr.HasMoreElements());
            xfr.SkipSubElementsFor("someElem");
            xfr.LeaveElement();

            Assert.IsTrue(xfr.IsAtFhirElement());
            Assert.AreEqual("someElem2", xfr.CurrentElementName);
            xfr.EnterElement();
            Assert.IsFalse(xfr.HasMoreElements());
            xfr.LeaveElement();

            xfr.LeaveElement();
        }

        [TestMethod]
        public void TestParsePrimitive()
        {
            string xmlString = "<someBoolean xmlns='http://hl7.org/fhir' value='true' id='3141' />";
            ErrorList errors = new ErrorList();
            FhirBoolean result = (FhirBoolean)FhirParser.ParseElementFromXml(xmlString, errors);
            Assert.IsTrue(errors.Count == 0, errors.ToString());
            Assert.AreEqual(true, result.Contents);
            Assert.AreEqual("3141", result.InternalId.ToString());

            string jsonString = "{\"someBoolean\": { \"value\" : \"true\", \"_id\" : \"3141\" } }";
            errors.Clear();
            result = (FhirBoolean)FhirParser.ParseElementFromJson(jsonString, errors);
            Assert.IsTrue(errors.Count == 0, errors.ToString());
            Assert.AreEqual(true, result.Contents);
            Assert.AreEqual("3141", result.InternalId.ToString());
        }


        [TestMethod]
        public void TestParsePrimitiveWithIllegalAttribute()
        {
            string xmlString = "<someBoolean xmlns='http://hl7.org/fhir' value='true' unknownattr='yes' />";
            ErrorList errors = new ErrorList();
            FhirBoolean result = (FhirBoolean)FhirParser.ParseElementFromXml(xmlString, errors);
            Assert.IsTrue(errors.Count == 1);
            Assert.IsTrue(errors[0].Message.Contains("unknownattr"));

            string jsonString = "{\"someBoolean\": { \"value\" : \"true\", \"unknownattr\" : \"yes\" } }";
            errors.Clear();
            result = (FhirBoolean)FhirParser.ParseElementFromJson(jsonString, errors);
            Assert.IsTrue(errors.Count == 1);
            Assert.IsTrue(errors[0].Message.Contains("unknownattr"));
        }


        [TestMethod]
        public void TestParseEmptyPrimitive()
        {
            string xmlString = "<someBoolean xmlns='http://hl7.org/fhir' id='4' />";
            ErrorList errors = new ErrorList();
            FhirBoolean result = (FhirBoolean)FhirParser.ParseElementFromXml(xmlString, errors);
            Assert.IsTrue(errors.Count() == 0, errors.ToString());
            Assert.IsNotNull(result);
            Assert.IsNull(result.Contents);
            Assert.AreEqual("4", result.InternalId.ToString());

            xmlString = "<someBoolean xmlns='http://hl7.org/fhir' id='4' value='' />";
            errors.Clear();
            result = (FhirBoolean)FhirParser.ParseElementFromXml(xmlString, errors);

            Assert.IsTrue(errors.Count() == 0, errors.ToString());
            Assert.IsNotNull(result);
            Assert.IsNull(result.Contents);
            Assert.AreEqual("4", result.InternalId.ToString());

            string jsonString = "{ \"someBoolean\" : { \"_id\" : \"4\" } }";
            errors.Clear();
            result = (FhirBoolean)FhirParser.ParseElementFromJson(jsonString, errors);
            Assert.IsTrue(errors.Count() == 0, errors.ToString());
            Assert.IsNotNull(result);
            Assert.IsNull(result.Contents);
            Assert.AreEqual("4", result.InternalId.ToString());

            jsonString = "{ \"someBoolean\" : { \"_id\" : \"4\", \"value\" : \"\" } }";
            errors.Clear();
            result = (FhirBoolean)FhirParser.ParseElementFromJson(jsonString, errors);
            Assert.IsTrue(errors.Count() == 0, errors.ToString());
            Assert.IsNotNull(result);
            Assert.IsNull(result.Contents);
            Assert.AreEqual("4", result.InternalId.ToString());
        }


        [TestMethod]
        public void TestParseExtendedPrimitive()
        {
            string xmlString =
                @"<birthDate xmlns='http://hl7.org/fhir' value='1972-11-30'>
                    <extension>
                       <url value='http://hl7.org/fhir/profile/@iso-21090#nullFlavor' />
                       <valueCode value='UNK' />
                    </extension>
                  </birthDate>";

            ErrorList errors = new ErrorList();
            Date result = (Date)FhirParser.ParseElementFromXml(xmlString, errors);
            Assert.AreEqual(0, errors.Count, errors.ToString());
            verifyParseExtendedPrimitive(result);

            string jsonString = @"{ ""birthDate"" : 
                                { 
                                    ""value"" : ""1972-11-30"",
                                    ""extension"" : [
                                    {
                                        ""url"" : { ""value"" : ""http://hl7.org/fhir/profile/@iso-21090#nullFlavor"" },
                                        ""valueCode"" : { ""value"" : ""UNK"" }
                                    } ]
                                }
                            }";

            errors.Clear();
            result = (Date)FhirParser.ParseElementFromJson(jsonString, errors);
            Assert.AreEqual(0, errors.Count);
            verifyParseExtendedPrimitive(result);
        }


        private static void verifyParseExtendedPrimitive(Date result)
        {
            Assert.AreEqual("1972-11-30", result.Contents);
            Assert.AreEqual(1, result.Extension.Count);
            Assert.AreEqual("http://hl7.org/fhir/profile/@iso-21090#nullFlavor", result.Extension[0].Url.ToString());
            Assert.IsTrue(result.Extension[0].Value is Code);
            Assert.AreEqual("UNK", ((Code)result.Extension[0].Value).Contents);
        }


        [TestMethod]
        public void TestParseExtendedPrimitiveWithOtherElements()
        {
            string xmlString =
                @"<birthDate xmlns='http://hl7.org/fhir' value='1972-11-30'>
                    <crap />
                    <extension>
                       <url value='http://hl7.org/fhir/profile/@iso-21090#nullFlavor' />
                       <valueCode value='UNK' />
                    </extension>
                  </birthDate>";

            ErrorList errors = new ErrorList();
            Date result = (Date)FhirParser.ParseElementFromXml(xmlString, errors);
            Assert.AreNotEqual(0, errors.Count);
            Assert.IsTrue(errors.ToString().Contains("crap"));

            xmlString =
                @"<birthDate xmlns='http://hl7.org/fhir' value='1972-11-30'>
                    <crap xmlns=""http://furore.com"" />
                    <extension>
                       <url value='http://hl7.org/fhir/profile/@iso-21090#nullFlavor' />
                       <valueCode value='UNK' />
                    </extension>
                  </birthDate>";

            errors.Clear();
            result = (Date)FhirParser.ParseElementFromXml(xmlString, errors);
            Assert.AreNotEqual(0, errors.Count);
            Assert.IsTrue(errors.ToString().Contains("crap"));


            string jsonString = @"{ ""birthDate"" : 
                                { 
                                    ""value"" : ""1972-11-30"",
                                    ""crap"" : {},
                                    ""extension"" : [
                                    {
                                        ""url"" : { ""value"" : ""http://hl7.org/fhir/profile/@iso-21090#nullFlavor"" },
                                        ""valueCode"" : { ""value"" : ""UNK"" }
                                    } ]
                                }
                            }";

            errors.Clear();
            result = (Date)FhirParser.ParseElementFromJson(jsonString, errors);
            Assert.AreNotEqual(0, errors.Count);
            Assert.IsTrue(errors.ToString().Contains("crap"));
        }
    }
}