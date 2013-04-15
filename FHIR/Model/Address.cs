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
    /// A postal address
    /// </summary>
    [FhirComposite("Address")]
    public partial class Address : Element
    {
        /// <summary>
        /// The use of an address
        /// </summary>
        public enum AddressUse
        {
            Home, // A communication address at a home
            Work, // An office address. First choice for business related contacts during business hours
            Temp, // A temporary address. The period can provide more detailed information
            Old, // This address is no longer in use (or was never correct, but retained for records)
        }
        
        /// <summary>
        /// Conversion of AddressUsefrom and into string
        /// <summary>
        public static class AddressUseHandling
        {
            public static bool TryParse(string value, out AddressUse result)
            {
                result = default(AddressUse);
                
                if( value=="home")
                    result = AddressUse.Home;
                else if( value=="work")
                    result = AddressUse.Work;
                else if( value=="temp")
                    result = AddressUse.Temp;
                else if( value=="old")
                    result = AddressUse.Old;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(AddressUse value)
            {
                if( value==AddressUse.Home )
                    return "home";
                else if( value==AddressUse.Work )
                    return "work";
                else if( value==AddressUse.Temp )
                    return "temp";
                else if( value==AddressUse.Old )
                    return "old";
                else
                    throw new ArgumentException("Unrecognized AddressUse value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The use of this address
        /// </summary>
        public Code<Address.AddressUse> Use { get; set; }
        
        /// <summary>
        /// Text representation of the address
        /// </summary>
        public FhirString Text { get; set; }
        
        /// <summary>
        /// line of an address
        /// </summary>
        public List<FhirString> Line { get; set; }
        
        /// <summary>
        /// name of city, town etc.
        /// </summary>
        public FhirString City { get; set; }
        
        /// <summary>
        /// sub-unit of country (abreviations ok)
        /// </summary>
        public FhirString State { get; set; }
        
        /// <summary>
        /// post code for area
        /// </summary>
        public FhirString Zip { get; set; }
        
        /// <summary>
        /// country (can be ISO 3166 3 letter code)
        /// </summary>
        public FhirString Country { get; set; }
        
        /// <summary>
        /// Time period when address was/is in use
        /// </summary>
        public Period Period { get; set; }
        
    }
    
}
