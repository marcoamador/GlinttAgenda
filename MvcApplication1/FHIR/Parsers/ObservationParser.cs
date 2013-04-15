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

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Observation instances
    /// </summary>
    internal static partial class ObservationParser
    {
        /// <summary>
        /// Parse Observation
        /// </summary>
        public static Observation ParseObservation(IFhirReader reader, ErrorList errors, Observation existingInstance = null )
        {
            Observation result = existingInstance != null ? existingInstance : new Observation();
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
                    
                    // Parse element language
                    else if( ParserUtils.IsAtFhirElement(reader, "language") )
                        result.Language = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element text
                    else if( ParserUtils.IsAtFhirElement(reader, "text") )
                        result.Text = NarrativeParser.ParseNarrative(reader, errors);
                    
                    // Parse element contained
                    else if( ParserUtils.IsAtFhirElement(reader, "contained") )
                    {
                        result.Contained = new List<Resource>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "contained") )
                            result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element value
                    else if( ParserUtils.IsAtFhirElement(reader, "value", true) )
                        result.Value = FhirParser.ParseElement(reader, errors);
                    
                    // Parse element interpretation
                    else if( ParserUtils.IsAtFhirElement(reader, "interpretation") )
                        result.Interpretation = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element comments
                    else if( ParserUtils.IsAtFhirElement(reader, "comments") )
                        result.Comments = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element obtained
                    else if( ParserUtils.IsAtFhirElement(reader, "obtained", true) )
                        result.Obtained = FhirParser.ParseElement(reader, errors);
                    
                    // Parse element issued
                    else if( ParserUtils.IsAtFhirElement(reader, "issued") )
                        result.Issued = InstantParser.ParseInstant(reader, errors);
                    
                    // Parse element status
                    else if( ParserUtils.IsAtFhirElement(reader, "status") )
                        result.Status = CodeParser.ParseCode<ObservationStatus>(reader, errors);
                    
                    // Parse element reliability
                    else if( ParserUtils.IsAtFhirElement(reader, "reliability") )
                        result.Reliability = CodeParser.ParseCode<Observation.ObservationReliability>(reader, errors);
                    
                    // Parse element bodySite
                    else if( ParserUtils.IsAtFhirElement(reader, "bodySite") )
                        result.BodySite = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element method
                    else if( ParserUtils.IsAtFhirElement(reader, "method") )
                        result.Method = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element identifier
                    else if( ParserUtils.IsAtFhirElement(reader, "identifier") )
                        result.Identifier = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element performer
                    else if( ParserUtils.IsAtFhirElement(reader, "performer") )
                        result.Performer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element referenceRange
                    else if( ParserUtils.IsAtFhirElement(reader, "referenceRange") )
                    {
                        result.ReferenceRange = new List<Observation.ObservationReferenceRangeComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "referenceRange") )
                            result.ReferenceRange.Add(ObservationParser.ParseObservationReferenceRangeComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element component
                    else if( ParserUtils.IsAtFhirElement(reader, "component") )
                    {
                        result.Component = new List<Observation.ObservationComponentComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "component") )
                            result.Component.Add(ObservationParser.ParseObservationComponentComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
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
        
        /// <summary>
        /// Parse ObservationComponentComponent
        /// </summary>
        public static Observation.ObservationComponentComponent ParseObservationComponentComponent(IFhirReader reader, ErrorList errors, Observation.ObservationComponentComponent existingInstance = null )
        {
            Observation.ObservationComponentComponent result = existingInstance != null ? existingInstance : new Observation.ObservationComponentComponent();
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
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element value
                    else if( ParserUtils.IsAtFhirElement(reader, "value", true) )
                        result.Value = FhirParser.ParseElement(reader, errors);
                    
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
        
        /// <summary>
        /// Parse ObservationReferenceRangeComponent
        /// </summary>
        public static Observation.ObservationReferenceRangeComponent ParseObservationReferenceRangeComponent(IFhirReader reader, ErrorList errors, Observation.ObservationReferenceRangeComponent existingInstance = null )
        {
            Observation.ObservationReferenceRangeComponent result = existingInstance != null ? existingInstance : new Observation.ObservationReferenceRangeComponent();
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
                    
                    // Parse element meaning
                    else if( ParserUtils.IsAtFhirElement(reader, "meaning") )
                        result.Meaning = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element range
                    else if( ParserUtils.IsAtFhirElement(reader, "range", true) )
                        result.Range = FhirParser.ParseElement(reader, errors);
                    
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
