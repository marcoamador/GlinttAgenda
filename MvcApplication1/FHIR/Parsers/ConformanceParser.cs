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
    /// Parser for Conformance instances
    /// </summary>
    internal static partial class ConformanceParser
    {
        /// <summary>
        /// Parse Conformance
        /// </summary>
        public static Conformance ParseConformance(IFhirReader reader, ErrorList errors, Conformance existingInstance = null )
        {
            Conformance result = existingInstance != null ? existingInstance : new Conformance();
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
                    
                    // Parse element date
                    else if( ParserUtils.IsAtFhirElement(reader, "date") )
                        result.Date = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element publisher
                    else if( ParserUtils.IsAtFhirElement(reader, "publisher") )
                        result.Publisher = ConformanceParser.ParseConformancePublisherComponent(reader, errors);
                    
                    // Parse element software
                    else if( ParserUtils.IsAtFhirElement(reader, "software") )
                        result.Software = ConformanceParser.ParseConformanceSoftwareComponent(reader, errors);
                    
                    // Parse element implementation
                    else if( ParserUtils.IsAtFhirElement(reader, "implementation") )
                        result.Implementation = ConformanceParser.ParseConformanceImplementationComponent(reader, errors);
                    
                    // Parse element proposal
                    else if( ParserUtils.IsAtFhirElement(reader, "proposal") )
                        result.Proposal = ConformanceParser.ParseConformanceProposalComponent(reader, errors);
                    
                    // Parse element version
                    else if( ParserUtils.IsAtFhirElement(reader, "version") )
                        result.Version = IdParser.ParseId(reader, errors);
                    
                    // Parse element acceptUnknown
                    else if( ParserUtils.IsAtFhirElement(reader, "acceptUnknown") )
                        result.AcceptUnknown = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element format
                    else if( ParserUtils.IsAtFhirElement(reader, "format") )
                    {
                        result.Format = new List<Code>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "format") )
                            result.Format.Add(CodeParser.ParseCode(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element rest
                    else if( ParserUtils.IsAtFhirElement(reader, "rest") )
                    {
                        result.Rest = new List<Conformance.ConformanceRestComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "rest") )
                            result.Rest.Add(ConformanceParser.ParseConformanceRestComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element messaging
                    else if( ParserUtils.IsAtFhirElement(reader, "messaging") )
                    {
                        result.Messaging = new List<Conformance.ConformanceMessagingComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "messaging") )
                            result.Messaging.Add(ConformanceParser.ParseConformanceMessagingComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element document
                    else if( ParserUtils.IsAtFhirElement(reader, "document") )
                    {
                        result.Document = new List<Conformance.ConformanceDocumentComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "document") )
                            result.Document.Add(ConformanceParser.ParseConformanceDocumentComponent(reader, errors));
                        
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
        /// Parse ConformanceSoftwareComponent
        /// </summary>
        public static Conformance.ConformanceSoftwareComponent ParseConformanceSoftwareComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceSoftwareComponent existingInstance = null )
        {
            Conformance.ConformanceSoftwareComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceSoftwareComponent();
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
                    
                    // Parse element version
                    else if( ParserUtils.IsAtFhirElement(reader, "version") )
                        result.Version = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element releaseDate
                    else if( ParserUtils.IsAtFhirElement(reader, "releaseDate") )
                        result.ReleaseDate = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
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
        /// Parse ConformanceRestComponent
        /// </summary>
        public static Conformance.ConformanceRestComponent ParseConformanceRestComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceRestComponent existingInstance = null )
        {
            Conformance.ConformanceRestComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceRestComponent();
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
                    
                    // Parse element mode
                    else if( ParserUtils.IsAtFhirElement(reader, "mode") )
                        result.Mode = CodeParser.ParseCode<Conformance.RestfulConformanceMode>(reader, errors);
                    
                    // Parse element documentation
                    else if( ParserUtils.IsAtFhirElement(reader, "documentation") )
                        result.Documentation = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element security
                    else if( ParserUtils.IsAtFhirElement(reader, "security") )
                        result.Security = ConformanceParser.ParseConformanceRestSecurityComponent(reader, errors);
                    
                    // Parse element resource
                    else if( ParserUtils.IsAtFhirElement(reader, "resource") )
                    {
                        result.Resource = new List<Conformance.ConformanceRestResourceComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "resource") )
                            result.Resource.Add(ConformanceParser.ParseConformanceRestResourceComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element batch
                    else if( ParserUtils.IsAtFhirElement(reader, "batch") )
                        result.Batch = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element history
                    else if( ParserUtils.IsAtFhirElement(reader, "history") )
                        result.History = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
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
        /// Parse ConformanceMessagingComponent
        /// </summary>
        public static Conformance.ConformanceMessagingComponent ParseConformanceMessagingComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceMessagingComponent existingInstance = null )
        {
            Conformance.ConformanceMessagingComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceMessagingComponent();
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
                    
                    // Parse element endpoint
                    else if( ParserUtils.IsAtFhirElement(reader, "endpoint") )
                        result.Endpoint = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element documentation
                    else if( ParserUtils.IsAtFhirElement(reader, "documentation") )
                        result.Documentation = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element event
                    else if( ParserUtils.IsAtFhirElement(reader, "event") )
                    {
                        result.Event = new List<Conformance.ConformanceMessagingEventComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "event") )
                            result.Event.Add(ConformanceParser.ParseConformanceMessagingEventComponent(reader, errors));
                        
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
        /// Parse ConformanceImplementationComponent
        /// </summary>
        public static Conformance.ConformanceImplementationComponent ParseConformanceImplementationComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceImplementationComponent existingInstance = null )
        {
            Conformance.ConformanceImplementationComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceImplementationComponent();
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
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element url
                    else if( ParserUtils.IsAtFhirElement(reader, "url") )
                        result.Url = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element software
                    else if( ParserUtils.IsAtFhirElement(reader, "software") )
                        result.Software = ConformanceParser.ParseConformanceSoftwareComponent(reader, errors);
                    
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
        /// Parse ConformanceRestResourceComponent
        /// </summary>
        public static Conformance.ConformanceRestResourceComponent ParseConformanceRestResourceComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceRestResourceComponent existingInstance = null )
        {
            Conformance.ConformanceRestResourceComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceRestResourceComponent();
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
                        result.Type = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element profile
                    else if( ParserUtils.IsAtFhirElement(reader, "profile") )
                        result.Profile = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element operation
                    else if( ParserUtils.IsAtFhirElement(reader, "operation") )
                    {
                        result.Operation = new List<Conformance.ConformanceRestResourceOperationComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "operation") )
                            result.Operation.Add(ConformanceParser.ParseConformanceRestResourceOperationComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element readHistory
                    else if( ParserUtils.IsAtFhirElement(reader, "readHistory") )
                        result.ReadHistory = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element searchInclude
                    else if( ParserUtils.IsAtFhirElement(reader, "searchInclude") )
                    {
                        result.SearchInclude = new List<FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "searchInclude") )
                            result.SearchInclude.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element searchParam
                    else if( ParserUtils.IsAtFhirElement(reader, "searchParam") )
                    {
                        result.SearchParam = new List<Conformance.ConformanceRestResourceSearchParamComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "searchParam") )
                            result.SearchParam.Add(ConformanceParser.ParseConformanceRestResourceSearchParamComponent(reader, errors));
                        
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
        /// Parse ConformanceRestResourceOperationComponent
        /// </summary>
        public static Conformance.ConformanceRestResourceOperationComponent ParseConformanceRestResourceOperationComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceRestResourceOperationComponent existingInstance = null )
        {
            Conformance.ConformanceRestResourceOperationComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceRestResourceOperationComponent();
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
                        result.Code = CodeParser.ParseCode<Conformance.RestfulOperation>(reader, errors);
                    
                    // Parse element documentation
                    else if( ParserUtils.IsAtFhirElement(reader, "documentation") )
                        result.Documentation = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ConformanceProposalComponent
        /// </summary>
        public static Conformance.ConformanceProposalComponent ParseConformanceProposalComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceProposalComponent existingInstance = null )
        {
            Conformance.ConformanceProposalComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceProposalComponent();
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
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ConformanceMessagingEventComponent
        /// </summary>
        public static Conformance.ConformanceMessagingEventComponent ParseConformanceMessagingEventComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceMessagingEventComponent existingInstance = null )
        {
            Conformance.ConformanceMessagingEventComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceMessagingEventComponent();
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
                        result.Code = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element mode
                    else if( ParserUtils.IsAtFhirElement(reader, "mode") )
                        result.Mode = CodeParser.ParseCode<Conformance.ConformanceEventMode>(reader, errors);
                    
                    // Parse element protocol
                    else if( ParserUtils.IsAtFhirElement(reader, "protocol") )
                    {
                        result.Protocol = new List<Coding>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "protocol") )
                            result.Protocol.Add(CodingParser.ParseCoding(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element focus
                    else if( ParserUtils.IsAtFhirElement(reader, "focus") )
                        result.Focus = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element request
                    else if( ParserUtils.IsAtFhirElement(reader, "request") )
                        result.Request = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element response
                    else if( ParserUtils.IsAtFhirElement(reader, "response") )
                        result.Response = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element documentation
                    else if( ParserUtils.IsAtFhirElement(reader, "documentation") )
                        result.Documentation = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ConformanceRestSecurityCertificateComponent
        /// </summary>
        public static Conformance.ConformanceRestSecurityCertificateComponent ParseConformanceRestSecurityCertificateComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceRestSecurityCertificateComponent existingInstance = null )
        {
            Conformance.ConformanceRestSecurityCertificateComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceRestSecurityCertificateComponent();
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
                        result.Type = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element blob
                    else if( ParserUtils.IsAtFhirElement(reader, "blob") )
                        result.Blob = Base64BinaryParser.ParseBase64Binary(reader, errors);
                    
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
        /// Parse ConformanceDocumentComponent
        /// </summary>
        public static Conformance.ConformanceDocumentComponent ParseConformanceDocumentComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceDocumentComponent existingInstance = null )
        {
            Conformance.ConformanceDocumentComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceDocumentComponent();
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
                    
                    // Parse element mode
                    else if( ParserUtils.IsAtFhirElement(reader, "mode") )
                        result.Mode = CodeParser.ParseCode<Conformance.DocumentMode>(reader, errors);
                    
                    // Parse element documentation
                    else if( ParserUtils.IsAtFhirElement(reader, "documentation") )
                        result.Documentation = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element profile
                    else if( ParserUtils.IsAtFhirElement(reader, "profile") )
                        result.Profile = FhirUriParser.ParseFhirUri(reader, errors);
                    
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
        /// Parse ConformanceRestSecurityComponent
        /// </summary>
        public static Conformance.ConformanceRestSecurityComponent ParseConformanceRestSecurityComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceRestSecurityComponent existingInstance = null )
        {
            Conformance.ConformanceRestSecurityComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceRestSecurityComponent();
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
                    
                    // Parse element service
                    else if( ParserUtils.IsAtFhirElement(reader, "service") )
                    {
                        result.Service = new List<CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "service") )
                            result.Service.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element certificate
                    else if( ParserUtils.IsAtFhirElement(reader, "certificate") )
                    {
                        result.Certificate = new List<Conformance.ConformanceRestSecurityCertificateComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "certificate") )
                            result.Certificate.Add(ConformanceParser.ParseConformanceRestSecurityCertificateComponent(reader, errors));
                        
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
        /// Parse ConformancePublisherComponent
        /// </summary>
        public static Conformance.ConformancePublisherComponent ParseConformancePublisherComponent(IFhirReader reader, ErrorList errors, Conformance.ConformancePublisherComponent existingInstance = null )
        {
            Conformance.ConformancePublisherComponent result = existingInstance != null ? existingInstance : new Conformance.ConformancePublisherComponent();
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
                    
                    // Parse element address
                    else if( ParserUtils.IsAtFhirElement(reader, "address") )
                        result.Address = AddressParser.ParseAddress(reader, errors);
                    
                    // Parse element contact
                    else if( ParserUtils.IsAtFhirElement(reader, "contact") )
                    {
                        result.Contact = new List<Contact>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "contact") )
                            result.Contact.Add(ContactParser.ParseContact(reader, errors));
                        
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
        /// Parse ConformanceRestResourceSearchParamComponent
        /// </summary>
        public static Conformance.ConformanceRestResourceSearchParamComponent ParseConformanceRestResourceSearchParamComponent(IFhirReader reader, ErrorList errors, Conformance.ConformanceRestResourceSearchParamComponent existingInstance = null )
        {
            Conformance.ConformanceRestResourceSearchParamComponent result = existingInstance != null ? existingInstance : new Conformance.ConformanceRestResourceSearchParamComponent();
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
                    
                    // Parse element source
                    else if( ParserUtils.IsAtFhirElement(reader, "source") )
                        result.Source = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeParser.ParseCode<SearchParamType>(reader, errors);
                    
                    // Parse element repeats
                    else if( ParserUtils.IsAtFhirElement(reader, "repeats") )
                        result.Repeats = CodeParser.ParseCode<SearchRepeatBehavior>(reader, errors);
                    
                    // Parse element documentation
                    else if( ParserUtils.IsAtFhirElement(reader, "documentation") )
                        result.Documentation = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element target
                    else if( ParserUtils.IsAtFhirElement(reader, "target") )
                    {
                        result.Target = new List<Code>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "target") )
                            result.Target.Add(CodeParser.ParseCode(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element chain
                    else if( ParserUtils.IsAtFhirElement(reader, "chain") )
                    {
                        result.Chain = new List<FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "chain") )
                            result.Chain.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
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
