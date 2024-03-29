﻿/*
  Copyright (c) 2011-2012, HL7, Inc
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

namespace Hl7.Fhir.Model
{
    public partial class Instant
    {
        public static Instant FromLocalDateTime(int year, int month, int day,
                            int hour, int min, int sec)
        {
            return new Instant( new DateTimeOffset(year, month, day, hour, min, sec,
                            DateTimeOffset.Now.Offset) );
        }


        public static Instant FromDateTimeUtc(int year, int month, int day,
                                            int hour, int min, int sec)
        {
            return new Instant(new DateTimeOffset(year, month, day, hour, min, sec,
                                   TimeSpan.Zero));
        }


        public static Instant Now()
        {
            return new Instant(DateTimeOffset.Now);
        }

        public const string PATTERN = @"yyyy-MM-dd'T'HH:mm:ssK";

        public static bool TryParse(string value, out Instant result)
        {
            DateTimeOffset dt;

            if (value == null)
            {
                result = new Instant(null);
                return true;
            }
            else if( DateTimeOffset.TryParseExact(value, PATTERN,
                null, System.Globalization.DateTimeStyles.AssumeUniversal, out dt) )
            {
                result = new Instant(dt);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }


        public static Instant Parse(string value)
        {
            Instant result = null;

            if (TryParse(value, out result))
                return result;
            else
                throw new FhirFormatException("Instant is not in expected format");
        }

        public override string ToString()
        {
            if (Contents.HasValue)
            {
                return Contents.Value.ToString(PATTERN);
            }
            else
                return null;
        }
    }
}
