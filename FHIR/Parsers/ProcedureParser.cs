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
    /// Parser for Procedure instances
    /// </summary>
    internal static partial class ProcedureParser
    {
        /// <summary>
        /// Parse Procedure
        /// </summary>
        public static Procedure ParseProcedure(IFhirReader reader, ErrorList errors, Procedure existingInstance = null )
        {
            Procedure result = existingInstance != null ? existingInstance : new Procedure();
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
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = ProcedureParser.ParseProcedureDescriptionComponent(reader, errors);
                    
                    // Parse element indication
                    else if( ParserUtils.IsAtFhirElement(reader, "indication") )
                        result.Indication = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element performer
                    else if( ParserUtils.IsAtFhirElement(reader, "performer") )
                    {
                        result.Performer = new List<Procedure.ProcedurePerformerComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "performer") )
                            result.Performer.Add(ProcedureParser.ParseProcedurePerformerComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element date
                    else if( ParserUtils.IsAtFhirElement(reader, "date") )
                        result.Date = PeriodParser.ParsePeriod(reader, errors);
                    
                    // Parse element visit
                    else if( ParserUtils.IsAtFhirElement(reader, "visit") )
                        result.Visit = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element outcome
                    else if( ParserUtils.IsAtFhirElement(reader, "outcome") )
                        result.Outcome = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element report
                    else if( ParserUtils.IsAtFhirElement(reader, "report") )
                    {
                        result.Report = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "report") )
                            result.Report.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element complication
                    else if( ParserUtils.IsAtFhirElement(reader, "complication") )
                        result.Complication = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element followUp
                    else if( ParserUtils.IsAtFhirElement(reader, "followUp") )
                        result.FollowUp = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element relatedItem
                    else if( ParserUtils.IsAtFhirElement(reader, "relatedItem") )
                    {
                        result.RelatedItem = new List<Procedure.ProcedureRelatedItemComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "relatedItem") )
                            result.RelatedItem.Add(ProcedureParser.ParseProcedureRelatedItemComponent(reader, errors));
                        
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
        /// Parse ProcedureRelatedItemComponent
        /// </summary>
        public static Procedure.ProcedureRelatedItemComponent ParseProcedureRelatedItemComponent(IFhirReader reader, ErrorList errors, Procedure.ProcedureRelatedItemComponent existingInstance = null )
        {
            Procedure.ProcedureRelatedItemComponent result = existingInstance != null ? existingInstance : new Procedure.ProcedureRelatedItemComponent();
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
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeParser.ParseCode<Procedure.ProcedureRelationshipType>(reader, errors);
                    
                    // Parse element target
                    else if( ParserUtils.IsAtFhirElement(reader, "target") )
                        result.Target = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
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
        /// Parse ProcedureDescriptionComponent
        /// </summary>
        public static Procedure.ProcedureDescriptionComponent ParseProcedureDescriptionComponent(IFhirReader reader, ErrorList errors, Procedure.ProcedureDescriptionComponent existingInstance = null )
        {
            Procedure.ProcedureDescriptionComponent result = existingInstance != null ? existingInstance : new Procedure.ProcedureDescriptionComponent();
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
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element notes
                    else if( ParserUtils.IsAtFhirElement(reader, "notes") )
                        result.Notes = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element bodySite
                    else if( ParserUtils.IsAtFhirElement(reader, "bodySite") )
                    {
                        result.BodySite = new List<CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "bodySite") )
                            result.BodySite.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
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
        /// Parse ProcedurePerformerComponent
        /// </summary>
        public static Procedure.ProcedurePerformerComponent ParseProcedurePerformerComponent(IFhirReader reader, ErrorList errors, Procedure.ProcedurePerformerComponent existingInstance = null )
        {
            Procedure.ProcedurePerformerComponent result = existingInstance != null ? existingInstance : new Procedure.ProcedurePerformerComponent();
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
                    
                    // Parse element person
                    else if( ParserUtils.IsAtFhirElement(reader, "person") )
                        result.Person = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element role
                    else if( ParserUtils.IsAtFhirElement(reader, "role") )
                        result.Role = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
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
