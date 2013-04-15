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
// Generated on Tue, Apr 9, 2013 08:39+1000 for FHIR v0.08
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A human readable formatted text, including images
    /// </summary>
    [FhirComposite("Narrative")]
    public partial class Narrative : Element
    {
        /// <summary>
        /// The status of a resource narrative
        /// </summary>
        public enum NarrativeStatus
        {
            Generated, // The contents of the narrative are entirely generated from the structured data in the resource.
            Extensions, // The contents of the narrative are entirely generated from the structured data in the resource and some of the content is generated from extensions
            Additional, // The contents of the narrative contain additional information not found in the structured data
            Empty, // the contents of the narrative are some equivalent of "No human readable text provided for this resource"
        }
        
        /// <summary>
        /// Conversion of NarrativeStatusfrom and into string
        /// <summary>
        public static class NarrativeStatusHandling
        {
            public static bool TryParse(string value, out NarrativeStatus result)
            {
                result = default(NarrativeStatus);
                
                if( value=="generated")
                    result = NarrativeStatus.Generated;
                else if( value=="extensions")
                    result = NarrativeStatus.Extensions;
                else if( value=="additional")
                    result = NarrativeStatus.Additional;
                else if( value=="empty")
                    result = NarrativeStatus.Empty;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(NarrativeStatus value)
            {
                if( value==NarrativeStatus.Generated )
                    return "generated";
                else if( value==NarrativeStatus.Extensions )
                    return "extensions";
                else if( value==NarrativeStatus.Additional )
                    return "additional";
                else if( value==NarrativeStatus.Empty )
                    return "empty";
                else
                    throw new ArgumentException("Unrecognized NarrativeStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Which is the source in a Narrative <-> Data mapping
        /// </summary>
        public enum NarrativeMapSource
        {
            Text, // The text is the original data
            Data, // The data is the original data
        }
        
        /// <summary>
        /// Conversion of NarrativeMapSourcefrom and into string
        /// <summary>
        public static class NarrativeMapSourceHandling
        {
            public static bool TryParse(string value, out NarrativeMapSource result)
            {
                result = default(NarrativeMapSource);
                
                if( value=="text")
                    result = NarrativeMapSource.Text;
                else if( value=="data")
                    result = NarrativeMapSource.Data;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(NarrativeMapSource value)
            {
                if( value==NarrativeMapSource.Text )
                    return "text";
                else if( value==NarrativeMapSource.Data )
                    return "data";
                else
                    throw new ArgumentException("Unrecognized NarrativeMapSource value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("NarrativeBlobComponent")]
        public partial class NarrativeBlobComponent : Element
        {
            /// <summary>
            /// Mime type of binary attachment
            /// </summary>
            public Code MimeType { get; set; }
            
            /// <summary>
            /// base64 data for attachment
            /// </summary>
            public Base64Binary Content { get; set; }
            
        }
        
        
        /// <summary>
        /// generated | extensions | additional
        /// </summary>
        public Code<Narrative.NarrativeStatus> Status { get; set; }
        
        /// <summary>
        /// Limited xhtml content
        /// </summary>
        public XHtml Div { get; set; }
        
        /// <summary>
        /// Binary content referenced in xhtml
        /// </summary>
        public List<NarrativeBlobComponent> Blob { get; set; }
        
    }
    
}
