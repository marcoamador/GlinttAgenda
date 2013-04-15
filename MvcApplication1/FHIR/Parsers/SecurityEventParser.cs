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
    /// Parser for SecurityEvent instances
    /// </summary>
    internal static partial class SecurityEventParser
    {
        /// <summary>
        /// Parse SecurityEvent
        /// </summary>
        public static SecurityEvent ParseSecurityEvent(IFhirReader reader, ErrorList errors, SecurityEvent existingInstance = null )
        {
            SecurityEvent result = existingInstance != null ? existingInstance : new SecurityEvent();
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
                    
                    // Parse element event
                    else if( ParserUtils.IsAtFhirElement(reader, "event") )
                        result.Event = SecurityEventParser.ParseSecurityEventEventComponent(reader, errors);
                    
                    // Parse element participant
                    else if( ParserUtils.IsAtFhirElement(reader, "participant") )
                    {
                        result.Participant = new List<SecurityEvent.SecurityEventParticipantComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "participant") )
                            result.Participant.Add(SecurityEventParser.ParseSecurityEventParticipantComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element source
                    else if( ParserUtils.IsAtFhirElement(reader, "source") )
                        result.Source = SecurityEventParser.ParseSecurityEventSourceComponent(reader, errors);
                    
                    // Parse element object
                    else if( ParserUtils.IsAtFhirElement(reader, "object") )
                    {
                        result.Object = new List<SecurityEvent.SecurityEventObjectComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "object") )
                            result.Object.Add(SecurityEventParser.ParseSecurityEventObjectComponent(reader, errors));
                        
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
        /// Parse SecurityEventObjectComponent
        /// </summary>
        public static SecurityEvent.SecurityEventObjectComponent ParseSecurityEventObjectComponent(IFhirReader reader, ErrorList errors, SecurityEvent.SecurityEventObjectComponent existingInstance = null )
        {
            SecurityEvent.SecurityEventObjectComponent result = existingInstance != null ? existingInstance : new SecurityEvent.SecurityEventObjectComponent();
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
                        result.Type = CodeParser.ParseCode<SecurityEvent.SecurityEventObjectType>(reader, errors);
                    
                    // Parse element role
                    else if( ParserUtils.IsAtFhirElement(reader, "role") )
                        result.Role = CodeParser.ParseCode<SecurityEvent.SecurityEventObjectRole>(reader, errors);
                    
                    // Parse element lifecycle
                    else if( ParserUtils.IsAtFhirElement(reader, "lifecycle") )
                        result.Lifecycle = CodeParser.ParseCode<SecurityEvent.SecurityEventObjectLifecycle>(reader, errors);
                    
                    // Parse element idType
                    else if( ParserUtils.IsAtFhirElement(reader, "idType") )
                        result.IdType = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                        result.Id = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element sensitivity
                    else if( ParserUtils.IsAtFhirElement(reader, "sensitivity") )
                        result.Sensitivity = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element query
                    else if( ParserUtils.IsAtFhirElement(reader, "query") )
                        result.Query = Base64BinaryParser.ParseBase64Binary(reader, errors);
                    
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
        /// Parse SecurityEventSourceComponent
        /// </summary>
        public static SecurityEvent.SecurityEventSourceComponent ParseSecurityEventSourceComponent(IFhirReader reader, ErrorList errors, SecurityEvent.SecurityEventSourceComponent existingInstance = null )
        {
            SecurityEvent.SecurityEventSourceComponent result = existingInstance != null ? existingInstance : new SecurityEvent.SecurityEventSourceComponent();
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
                    
                    // Parse element site
                    else if( ParserUtils.IsAtFhirElement(reader, "site") )
                        result.Site = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                        result.Id = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                    {
                        result.Type = new List<Coding>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "type") )
                            result.Type.Add(CodingParser.ParseCoding(reader, errors));
                        
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
        /// Parse SecurityEventEventComponent
        /// </summary>
        public static SecurityEvent.SecurityEventEventComponent ParseSecurityEventEventComponent(IFhirReader reader, ErrorList errors, SecurityEvent.SecurityEventEventComponent existingInstance = null )
        {
            SecurityEvent.SecurityEventEventComponent result = existingInstance != null ? existingInstance : new SecurityEvent.SecurityEventEventComponent();
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
                        result.Id = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element action
                    else if( ParserUtils.IsAtFhirElement(reader, "action") )
                        result.Action = CodeParser.ParseCode<SecurityEvent.SecurityEventEventAction>(reader, errors);
                    
                    // Parse element dateTime
                    else if( ParserUtils.IsAtFhirElement(reader, "dateTime") )
                        result.DateTime = InstantParser.ParseInstant(reader, errors);
                    
                    // Parse element outcome
                    else if( ParserUtils.IsAtFhirElement(reader, "outcome") )
                        result.Outcome = CodeParser.ParseCode<SecurityEvent.SecurityEventEventOutcome>(reader, errors);
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                    {
                        result.Code = new List<Coding>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "code") )
                            result.Code.Add(CodingParser.ParseCoding(reader, errors));
                        
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
        /// Parse SecurityEventParticipantNetworkComponent
        /// </summary>
        public static SecurityEvent.SecurityEventParticipantNetworkComponent ParseSecurityEventParticipantNetworkComponent(IFhirReader reader, ErrorList errors, SecurityEvent.SecurityEventParticipantNetworkComponent existingInstance = null )
        {
            SecurityEvent.SecurityEventParticipantNetworkComponent result = existingInstance != null ? existingInstance : new SecurityEvent.SecurityEventParticipantNetworkComponent();
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
                        result.Type = CodeParser.ParseCode<SecurityEvent.SecurityEventParticipantNetworkType>(reader, errors);
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                        result.Id = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse SecurityEventParticipantComponent
        /// </summary>
        public static SecurityEvent.SecurityEventParticipantComponent ParseSecurityEventParticipantComponent(IFhirReader reader, ErrorList errors, SecurityEvent.SecurityEventParticipantComponent existingInstance = null )
        {
            SecurityEvent.SecurityEventParticipantComponent result = existingInstance != null ? existingInstance : new SecurityEvent.SecurityEventParticipantComponent();
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
                    
                    // Parse element userId
                    else if( ParserUtils.IsAtFhirElement(reader, "userId") )
                        result.UserId = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element otherUserId
                    else if( ParserUtils.IsAtFhirElement(reader, "otherUserId") )
                        result.OtherUserId = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element requestor
                    else if( ParserUtils.IsAtFhirElement(reader, "requestor") )
                        result.Requestor = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element role
                    else if( ParserUtils.IsAtFhirElement(reader, "role") )
                    {
                        result.Role = new List<Coding>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "role") )
                            result.Role.Add(CodingParser.ParseCoding(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element mediaId
                    else if( ParserUtils.IsAtFhirElement(reader, "mediaId") )
                        result.MediaId = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element network
                    else if( ParserUtils.IsAtFhirElement(reader, "network") )
                        result.Network = SecurityEventParser.ParseSecurityEventParticipantNetworkComponent(reader, errors);
                    
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
