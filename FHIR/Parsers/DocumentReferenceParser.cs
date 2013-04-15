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
    /// Parser for DocumentReference instances
    /// </summary>
    internal static partial class DocumentReferenceParser
    {
        /// <summary>
        /// Parse DocumentReference
        /// </summary>
        public static DocumentReference ParseDocumentReference(IFhirReader reader, ErrorList errors, DocumentReference existingInstance = null )
        {
            DocumentReference result = existingInstance != null ? existingInstance : new DocumentReference();
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
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                        result.Id = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element identifier
                    else if( ParserUtils.IsAtFhirElement(reader, "identifier") )
                    {
                        result.Identifier = new List<Identifier>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                            result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element category
                    else if( ParserUtils.IsAtFhirElement(reader, "category") )
                    {
                        result.Category = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "category") )
                            result.Category.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element author
                    else if( ParserUtils.IsAtFhirElement(reader, "author") )
                    {
                        result.Author = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "author") )
                            result.Author.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element custodian
                    else if( ParserUtils.IsAtFhirElement(reader, "custodian") )
                        result.Custodian = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element authenticator
                    else if( ParserUtils.IsAtFhirElement(reader, "authenticator") )
                        result.Authenticator = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element created
                    else if( ParserUtils.IsAtFhirElement(reader, "created") )
                        result.Created = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element indexed
                    else if( ParserUtils.IsAtFhirElement(reader, "indexed") )
                        result.Indexed = InstantParser.ParseInstant(reader, errors);
                    
                    // Parse element status
                    else if( ParserUtils.IsAtFhirElement(reader, "status") )
                        result.Status = CodeParser.ParseCode<DocumentReference.DocumentReferenceStatus>(reader, errors);
                    
                    // Parse element docStatus
                    else if( ParserUtils.IsAtFhirElement(reader, "docStatus") )
                        result.DocStatus = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element supercedes
                    else if( ParserUtils.IsAtFhirElement(reader, "supercedes") )
                        result.Supercedes = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element confidentiality
                    else if( ParserUtils.IsAtFhirElement(reader, "confidentiality") )
                        result.Confidentiality = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element primaryLanguage
                    else if( ParserUtils.IsAtFhirElement(reader, "primaryLanguage") )
                        result.PrimaryLanguage = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element format
                    else if( ParserUtils.IsAtFhirElement(reader, "format") )
                        result.Format = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element size
                    else if( ParserUtils.IsAtFhirElement(reader, "size") )
                        result.Size = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element hash
                    else if( ParserUtils.IsAtFhirElement(reader, "hash") )
                        result.Hash = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element location
                    else if( ParserUtils.IsAtFhirElement(reader, "location") )
                        result.Location = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element service
                    else if( ParserUtils.IsAtFhirElement(reader, "service") )
                        result.Service = DocumentReferenceParser.ParseDocumentReferenceServiceComponent(reader, errors);
                    
                    // Parse element context
                    else if( ParserUtils.IsAtFhirElement(reader, "context") )
                        result.Context = DocumentReferenceParser.ParseDocumentReferenceContextComponent(reader, errors);
                    
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
        /// Parse DocumentReferenceContextComponent
        /// </summary>
        public static DocumentReference.DocumentReferenceContextComponent ParseDocumentReferenceContextComponent(IFhirReader reader, ErrorList errors, DocumentReference.DocumentReferenceContextComponent existingInstance = null )
        {
            DocumentReference.DocumentReferenceContextComponent result = existingInstance != null ? existingInstance : new DocumentReference.DocumentReferenceContextComponent();
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
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                    {
                        result.Code = new List<CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "code") )
                            result.Code.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element period
                    else if( ParserUtils.IsAtFhirElement(reader, "period") )
                        result.Period = PeriodParser.ParsePeriod(reader, errors);
                    
                    // Parse element facilityType
                    else if( ParserUtils.IsAtFhirElement(reader, "facilityType") )
                        result.FacilityType = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
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
        /// Parse DocumentReferenceServiceParameterComponent
        /// </summary>
        public static DocumentReference.DocumentReferenceServiceParameterComponent ParseDocumentReferenceServiceParameterComponent(IFhirReader reader, ErrorList errors, DocumentReference.DocumentReferenceServiceParameterComponent existingInstance = null )
        {
            DocumentReference.DocumentReferenceServiceParameterComponent result = existingInstance != null ? existingInstance : new DocumentReference.DocumentReferenceServiceParameterComponent();
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
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element value
                    else if( ParserUtils.IsAtFhirElement(reader, "value") )
                        result.Value = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse DocumentReferenceServiceComponent
        /// </summary>
        public static DocumentReference.DocumentReferenceServiceComponent ParseDocumentReferenceServiceComponent(IFhirReader reader, ErrorList errors, DocumentReference.DocumentReferenceServiceComponent existingInstance = null )
        {
            DocumentReference.DocumentReferenceServiceComponent result = existingInstance != null ? existingInstance : new DocumentReference.DocumentReferenceServiceComponent();
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
                    
                    // Parse element parameter
                    else if( ParserUtils.IsAtFhirElement(reader, "parameter") )
                    {
                        result.Parameter = new List<DocumentReference.DocumentReferenceServiceParameterComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "parameter") )
                            result.Parameter.Add(DocumentReferenceParser.ParseDocumentReferenceServiceParameterComponent(reader, errors));
                        
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
        
    }
}
