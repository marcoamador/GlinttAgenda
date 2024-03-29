﻿/*
  Copyright (c) 2011-2012, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hl7.Fhir.Model;
using Hl7.Fhir.Support;
using System.Xml;
using System.IO;
using Newtonsoft.Json;

namespace Hl7.Fhir.Parsers
{
    public partial class FhirParser
    {
        public static Resource ParseResourceFromXml(string xml, ErrorList errors)
        {
            var reader = Util.XmlReaderFromString(xml);
            return ParseResource(reader,errors);
        }

        public static Resource ParseResourceFromJson(string json, ErrorList errors)
        {
            var reader = Util.JsonReaderFromString(json);
            return ParseResource(reader, errors);
        }

        public static Element ParseElementFromXml(string xml, ErrorList errors)
        {
            var reader = Util.XmlReaderFromString(xml);
            return ParseElement(reader, errors);
        }

        public static Element ParseElementFromJson(string json, ErrorList errors)
        {
            var reader = Util.JsonReaderFromString(json);
            return ParseElement(reader, errors);
        }

        public static Resource ParseResource(XmlReader reader, ErrorList errors)
        {
            return ParseResource(new XmlFhirReader(reader), errors);
        }

        public static Resource ParseResource(JsonTextReader reader, ErrorList errors)
        {
            return ParseResource(new JsonFhirReader(reader), errors);
        }

        public static Element ParseElement(XmlReader reader, ErrorList errors)
        {
            return ParseElement(new XmlFhirReader(reader), errors);
        }

        public static Element ParseElement(JsonTextReader reader, ErrorList errors)
        {
            return ParseElement(new JsonFhirReader(reader), errors);
        }
    }
}
