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
using Newtonsoft.Json;

namespace Hl7.Fhir.Serializers
{
    public class JsonFhirWriter : IFhirWriter
    {
        private JsonWriter jw;
        
        public JsonFhirWriter(JsonWriter jwriter)
        {
            jw = jwriter;
        }

        public void WriteStartRootObject(string name)
        {
            jw.WriteStartObject();
            jw.WritePropertyName(name);
        }

        public void WriteEndRootObject()
        {
            jw.WriteEndObject();
        }

        public void WriteStartElement(string name)
        {
            jw.WritePropertyName(name);
        }

        public void WriteEndElement()
        {
            // Nothing
        }

        public void WriteStartComplexContent()
        {
            jw.WriteStartObject();
        }

        public void WriteEndComplexContent()
        {
            jw.WriteEndObject();
        }

        public void WritePrimitiveContents(string value)
        {
            WriteStartElement(Parsers.JsonFhirReader.VALUEATTR);
            jw.WriteValue(value);
        }

        public void WriteXhtmlContents(string xhtml)
        {
            // In Json, the serialization of Xhtml is the same as other elements
            WriteStartElement(Parsers.JsonFhirReader.XHTMLELEM);
            jw.WriteValue(xhtml);
        }

        public void WriteRefIdContents(string id)
        {
            jw.WritePropertyName(Parsers.JsonFhirReader.IDATTR);
            jw.WriteValue(id);
        }

        public void WriteStartArrayElement(string name)
        {
            jw.WritePropertyName(name);
            jw.WriteStartArray();
        }

        public void WriteStartArrayMember(string name)
        {
            // Nothing
        }

        public void WriteEndArrayMember()
        {
            // Nothing
        }

        public void WriteEndArrayElement()
        {
            jw.WriteEndArray();
        }


        void IDisposable.Dispose()
        {
            ((IDisposable)jw).Dispose();
        }

    }
}
