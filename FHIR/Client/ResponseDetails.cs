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


using Hl7.Fhir.Support;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Hl7.Fhir.Client
{
    public class ResponseDetails
    {
        public HttpStatusCode Result { get; set; }
        public string ContentType { get; set; }
        public Encoding CharacterEncoding { get; set; }

        public string ContentLocation { get; set; }
        public string Location { get; set; }
        public string LastModified { get; set; }

        public byte[] Body { get; set; }

        public HttpWebResponse Reponse { get; set; }

        public string BodyAsString()
        {
            if (Body == null) return null;

            Encoding enc = CharacterEncoding;

            // If no encoding is specified, default to utf8
            if (enc == null) enc = Encoding.UTF8;

            return (new StreamReader(new MemoryStream(Body), enc, true)).ReadToEnd();
        }


        public const string CONTENTLOCATION = "Content-Location";
        public const string LOCATION = "Location";
        public const string LASTMODIFIED = "Last-Modified";


        public static ResponseDetails FromHttpWebResponse(HttpWebResponse response)
        {
            
            return new ResponseDetails
                {
                    Result = response.StatusCode,
                    ContentType = getContentType(response),
                    CharacterEncoding = getContentEncoding(response),
                    ContentLocation = response.Headers[CONTENTLOCATION],
                    Location = response.Headers[LOCATION],
                    LastModified = response.Headers[LASTMODIFIED],
                    Body = readBody(response),
                    Reponse = response
                };
        }

        private static byte[] readBody(HttpWebResponse response)
        {
            return Util.ReadAllFromStream(response.GetResponseStream(),
                (int)response.ContentLength);
        }

        private static string getContentType(HttpWebResponse response)
        {
            if (!String.IsNullOrEmpty(response.ContentType))
            {
#if !NETFX_CORE
                return new System.Net.Mime.ContentType(response.ContentType).MediaType;
#else
                return System.Net.Http.Headers.MediaTypeHeaderValue.Parse(response.ContentType).MediaType;               
#endif
            }
            else
                return null;
        }

        private static Encoding getContentEncoding(HttpWebResponse response)
        {
            Encoding result = null;

            //Stripped off, there will always be a content type according 
            //to our specs and CharacterSet is not supported under WinRT
            // First try .NET's idea of the CharacterSet
            // if (!String.IsNullOrEmpty(response.CharacterSet))
            //     result = Encoding.GetEncoding(response.CharacterSet);

            // Then look at charset parameter on Content-Type header.
            // This possibly overrides the CharacterSet header
            if (!String.IsNullOrEmpty(response.ContentType))
            {
#if !NETFX_CORE
                var charset = new System.Net.Mime.ContentType(response.ContentType).CharSet;
#else
                var charset = System.Net.Http.Headers.MediaTypeHeaderValue.Parse(response.ContentType).CharSet;
#endif           
                if(!String.IsNullOrEmpty(charset))
                    result = Encoding.GetEncoding(charset);
            }
            return result;
        }
    }
}
