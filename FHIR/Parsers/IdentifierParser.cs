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

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Identifier instances
    /// </summary>
    internal static partial class IdentifierParser
    {
        /// <summary>
        /// Parse Identifier
        /// </summary>
        public static Identifier ParseIdentifier(IFhirReader reader, ErrorList errors, Identifier existingInstance = null )
        {
            Identifier result = existingInstance != null ? existingInstance : new Identifier();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element use
                    else if( ParserUtils.IsAtFhirElement(reader, "use") )
                        result.Use = CodeParser.ParseCode<Identifier.IdentifierUse>(reader, errors);
                    
                    // Parse element label
                    else if( ParserUtils.IsAtFhirElement(reader, "label") )
                        result.Label = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element system
                    else if( ParserUtils.IsAtFhirElement(reader, "system") )
                        result.System = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                        result.Id = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element period
                    else if( ParserUtils.IsAtFhirElement(reader, "period") )
                        result.Period = PeriodParser.ParsePeriod(reader, errors);
                    
                    // Parse element assigner
                    else if( ParserUtils.IsAtFhirElement(reader, "assigner") )
                        result.Assigner = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
    }
}
