using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;

/*
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

//
// Generated on Mon, Apr 15, 2013 13:14+1000 for FHIR v0.08
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Name of a human
    /// </summary>
    [FhirComposite("HumanName")]
    public partial class HumanName : Element
    {
        /// <summary>
        /// The use of a human name
        /// </summary>
        public enum NameUse
        {
            Usual, // Known as/conventional/the one you normally use
            Official, // The formal name as registered in an official (government) registry, but which name might not be commonly used. May be called "legal name".
            Temp, // A temporary name. A name valid time can provide more detailed information. This may also be used for temporary names assigned at birth or in emergency situations.
            Nickname, // A name that is used to address the person in an informal manner, but is not part of their formal or usual name
            Anonymous, // Anonymous assigned name, alias, or pseudonym (used to protect a person's identity for privacy reasons)
            Old, // This name is no longer in use (or was never correct, but retained for records)
            Maiden, // A name used prior to marriage. Marriage naming customs vary greatly around the world. This name use is for use by applications that collect and store "maiden" names. Though the concept of maiden name is often gender specific, the use of this term is not gender specific. The use of this term does not imply any particular history for a person's name, nor should the maiden name be determined algorithmically.
        }
        
        /// <summary>
        /// Conversion of NameUsefrom and into string
        /// <summary>
        public static class NameUseHandling
        {
            public static bool TryParse(string value, out NameUse result)
            {
                result = default(NameUse);
                
                if( value=="usual")
                    result = NameUse.Usual;
                else if( value=="official")
                    result = NameUse.Official;
                else if( value=="temp")
                    result = NameUse.Temp;
                else if( value=="nickname")
                    result = NameUse.Nickname;
                else if( value=="anonymous")
                    result = NameUse.Anonymous;
                else if( value=="old")
                    result = NameUse.Old;
                else if( value=="maiden")
                    result = NameUse.Maiden;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(NameUse value)
            {
                if( value==NameUse.Usual )
                    return "usual";
                else if( value==NameUse.Official )
                    return "official";
                else if( value==NameUse.Temp )
                    return "temp";
                else if( value==NameUse.Nickname )
                    return "nickname";
                else if( value==NameUse.Anonymous )
                    return "anonymous";
                else if( value==NameUse.Old )
                    return "old";
                else if( value==NameUse.Maiden )
                    return "maiden";
                else
                    throw new ArgumentException("Unrecognized NameUse value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The use of this name
        /// </summary>
        public Code<HumanName.NameUse> Use { get; set; }
        
        /// <summary>
        /// Text representation of the full name
        /// </summary>
        public FhirString Text { get; set; }
        
        /// <summary>
        /// family name (called 'Surname')
        /// </summary>
        public List<FhirString> Family { get; set; }
        
        /// <summary>
        /// given names (not always 'first'). Includes middle names
        /// </summary>
        public List<FhirString> Given { get; set; }
        
        /// <summary>
        /// parts that come before the name
        /// </summary>
        public List<FhirString> Prefix { get; set; }
        
        /// <summary>
        /// parts that come after the name
        /// </summary>
        public List<FhirString> Suffix { get; set; }
        
        /// <summary>
        /// Time period when name was/is in use
        /// </summary>
        public Period Period { get; set; }
        
    }
    
}
