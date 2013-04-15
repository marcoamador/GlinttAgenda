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
    /// A measured or measurable amount
    /// </summary>
    [FhirComposite("Quantity")]
    public partial class Quantity : Element
    {
        /// <summary>
        /// how the Quantity should be understood and represented
        /// </summary>
        public enum QuantityCompararator
        {
            LessThan, // The actual value is less than the given value
            LessOrEqual, // The actual value is less than or equal to the given value
            GreaterOrEqual, // The actual value is greater than or equal to the given value
            GreaterThan, // The actual value is greater than the given value
        }
        
        /// <summary>
        /// Conversion of QuantityCompararatorfrom and into string
        /// <summary>
        public static class QuantityCompararatorHandling
        {
            public static bool TryParse(string value, out QuantityCompararator result)
            {
                result = default(QuantityCompararator);
                
                if( value=="<")
                    result = QuantityCompararator.LessThan;
                else if( value=="<=")
                    result = QuantityCompararator.LessOrEqual;
                else if( value==">=")
                    result = QuantityCompararator.GreaterOrEqual;
                else if( value==">")
                    result = QuantityCompararator.GreaterThan;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(QuantityCompararator value)
            {
                if( value==QuantityCompararator.LessThan )
                    return "<";
                else if( value==QuantityCompararator.LessOrEqual )
                    return "<=";
                else if( value==QuantityCompararator.GreaterOrEqual )
                    return ">=";
                else if( value==QuantityCompararator.GreaterThan )
                    return ">";
                else
                    throw new ArgumentException("Unrecognized QuantityCompararator value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Numerical value (with implicit precision)
        /// </summary>
        public FhirDecimal Value { get; set; }
        
        /// <summary>
        /// Relationship of stated value to actual value
        /// </summary>
        public Code<Quantity.QuantityCompararator> Comparator { get; set; }
        
        /// <summary>
        /// Unit representation
        /// </summary>
        public FhirString Units { get; set; }
        
        /// <summary>
        /// System that defines coded unit form
        /// </summary>
        public FhirUri System { get; set; }
        
        /// <summary>
        /// Coded form of the unit
        /// </summary>
        public Code Code { get; set; }
        
    }
    
}
