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
    /// Parser for Message instances
    /// </summary>
    internal static partial class MessageParser
    {
        /// <summary>
        /// Parse Message
        /// </summary>
        public static Message ParseMessage(IFhirReader reader, ErrorList errors, Message existingInstance = null )
        {
            Message result = existingInstance != null ? existingInstance : new Message();
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
                        result.Id = IdParser.ParseId(reader, errors);
                    
                    // Parse element instant
                    else if( ParserUtils.IsAtFhirElement(reader, "instant") )
                        result.Instant = InstantParser.ParseInstant(reader, errors);
                    
                    // Parse element event
                    else if( ParserUtils.IsAtFhirElement(reader, "event") )
                        result.Event = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element response
                    else if( ParserUtils.IsAtFhirElement(reader, "response") )
                        result.Response = MessageParser.ParseMessageResponseComponent(reader, errors);
                    
                    // Parse element source
                    else if( ParserUtils.IsAtFhirElement(reader, "source") )
                        result.Source = MessageParser.ParseMessageSourceComponent(reader, errors);
                    
                    // Parse element destination
                    else if( ParserUtils.IsAtFhirElement(reader, "destination") )
                        result.Destination = MessageParser.ParseMessageDestinationComponent(reader, errors);
                    
                    // Parse element enterer
                    else if( ParserUtils.IsAtFhirElement(reader, "enterer") )
                        result.Enterer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element author
                    else if( ParserUtils.IsAtFhirElement(reader, "author") )
                        result.Author = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element receiver
                    else if( ParserUtils.IsAtFhirElement(reader, "receiver") )
                        result.Receiver = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element responsible
                    else if( ParserUtils.IsAtFhirElement(reader, "responsible") )
                        result.Responsible = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element effective
                    else if( ParserUtils.IsAtFhirElement(reader, "effective") )
                        result.Effective = PeriodParser.ParsePeriod(reader, errors);
                    
                    // Parse element reason
                    else if( ParserUtils.IsAtFhirElement(reader, "reason") )
                        result.Reason = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element data
                    else if( ParserUtils.IsAtFhirElement(reader, "data") )
                    {
                        result.Data = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "data") )
                            result.Data.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
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
        /// Parse MessageDestinationComponent
        /// </summary>
        public static Message.MessageDestinationComponent ParseMessageDestinationComponent(IFhirReader reader, ErrorList errors, Message.MessageDestinationComponent existingInstance = null )
        {
            Message.MessageDestinationComponent result = existingInstance != null ? existingInstance : new Message.MessageDestinationComponent();
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
                    
                    // Parse element target
                    else if( ParserUtils.IsAtFhirElement(reader, "target") )
                        result.Target = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element endpoint
                    else if( ParserUtils.IsAtFhirElement(reader, "endpoint") )
                        result.Endpoint = FhirUriParser.ParseFhirUri(reader, errors);
                    
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
        /// Parse MessageSourceComponent
        /// </summary>
        public static Message.MessageSourceComponent ParseMessageSourceComponent(IFhirReader reader, ErrorList errors, Message.MessageSourceComponent existingInstance = null )
        {
            Message.MessageSourceComponent result = existingInstance != null ? existingInstance : new Message.MessageSourceComponent();
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
                    
                    // Parse element software
                    else if( ParserUtils.IsAtFhirElement(reader, "software") )
                        result.Software = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element version
                    else if( ParserUtils.IsAtFhirElement(reader, "version") )
                        result.Version = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element contact
                    else if( ParserUtils.IsAtFhirElement(reader, "contact") )
                        result.Contact = ContactParser.ParseContact(reader, errors);
                    
                    // Parse element endpoint
                    else if( ParserUtils.IsAtFhirElement(reader, "endpoint") )
                        result.Endpoint = FhirUriParser.ParseFhirUri(reader, errors);
                    
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
        /// Parse MessageResponseComponent
        /// </summary>
        public static Message.MessageResponseComponent ParseMessageResponseComponent(IFhirReader reader, ErrorList errors, Message.MessageResponseComponent existingInstance = null )
        {
            Message.MessageResponseComponent result = existingInstance != null ? existingInstance : new Message.MessageResponseComponent();
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
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                        result.Id = IdParser.ParseId(reader, errors);
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeParser.ParseCode<Message.ResponseCode>(reader, errors);
                    
                    // Parse element details
                    else if( ParserUtils.IsAtFhirElement(reader, "details") )
                        result.Details = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
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
