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
    /// A conformance statement
    /// </summary>
    [FhirResource("Conformance")]
    public partial class Conformance : Resource
    {
        /// <summary>
        /// Operations supported by REST
        /// </summary>
        public enum RestfulOperation
        {
            Read, // Read the current state of the resource
            Vread, // Read the state of a specific version of the resource
            Update, // Update an existing resource by its id (or create it if it is new)
            Delete, // Delete a resource
            HistoryInstance, // Retrieve the update history for a resource instance
            Validate, // Check that the content would be acceptable as an update
            HistoryType, // Get a list of updates to resources of this type
            Create, // Create a new resource with a server assigned id
            Search, // Supports search operations using the parameters described in the profile
        }
        
        /// <summary>
        /// Conversion of RestfulOperationfrom and into string
        /// <summary>
        public static class RestfulOperationHandling
        {
            public static bool TryParse(string value, out RestfulOperation result)
            {
                result = default(RestfulOperation);
                
                if( value=="read")
                    result = RestfulOperation.Read;
                else if( value=="vread")
                    result = RestfulOperation.Vread;
                else if( value=="update")
                    result = RestfulOperation.Update;
                else if( value=="delete")
                    result = RestfulOperation.Delete;
                else if( value=="history-instance")
                    result = RestfulOperation.HistoryInstance;
                else if( value=="validate")
                    result = RestfulOperation.Validate;
                else if( value=="history-type")
                    result = RestfulOperation.HistoryType;
                else if( value=="create")
                    result = RestfulOperation.Create;
                else if( value=="search")
                    result = RestfulOperation.Search;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(RestfulOperation value)
            {
                if( value==RestfulOperation.Read )
                    return "read";
                else if( value==RestfulOperation.Vread )
                    return "vread";
                else if( value==RestfulOperation.Update )
                    return "update";
                else if( value==RestfulOperation.Delete )
                    return "delete";
                else if( value==RestfulOperation.HistoryInstance )
                    return "history-instance";
                else if( value==RestfulOperation.Validate )
                    return "validate";
                else if( value==RestfulOperation.HistoryType )
                    return "history-type";
                else if( value==RestfulOperation.Create )
                    return "create";
                else if( value==RestfulOperation.Search )
                    return "search";
                else
                    throw new ArgumentException("Unrecognized RestfulOperation value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Whether the application produces or consumes documents
        /// </summary>
        public enum DocumentMode
        {
            Producer, // The application produces documents of the specified type
            Consumer, // The application consumes documents of the specified type
        }
        
        /// <summary>
        /// Conversion of DocumentModefrom and into string
        /// <summary>
        public static class DocumentModeHandling
        {
            public static bool TryParse(string value, out DocumentMode result)
            {
                result = default(DocumentMode);
                
                if( value=="producer")
                    result = DocumentMode.Producer;
                else if( value=="consumer")
                    result = DocumentMode.Consumer;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DocumentMode value)
            {
                if( value==DocumentMode.Producer )
                    return "producer";
                else if( value==DocumentMode.Consumer )
                    return "consumer";
                else
                    throw new ArgumentException("Unrecognized DocumentMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The mode of a restful conformance statement
        /// </summary>
        public enum RestfulConformanceMode
        {
            Client, // The application acts as a server for this resource
            Server, // The application acts as a client for this resource
        }
        
        /// <summary>
        /// Conversion of RestfulConformanceModefrom and into string
        /// <summary>
        public static class RestfulConformanceModeHandling
        {
            public static bool TryParse(string value, out RestfulConformanceMode result)
            {
                result = default(RestfulConformanceMode);
                
                if( value=="client")
                    result = RestfulConformanceMode.Client;
                else if( value=="server")
                    result = RestfulConformanceMode.Server;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(RestfulConformanceMode value)
            {
                if( value==RestfulConformanceMode.Client )
                    return "client";
                else if( value==RestfulConformanceMode.Server )
                    return "server";
                else
                    throw new ArgumentException("Unrecognized RestfulConformanceMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// How messages are delivered
        /// </summary>
        public enum MessageTransport
        {
            Http, // The application sends or receives messages using HTTP POST (may be over http or https)
            Ftp, // The application sends or receives messages using File Transfer Protocol
            Mllp, // The application sends or receivers messages using HL7's Minimal Lower Level Protocol
        }
        
        /// <summary>
        /// Conversion of MessageTransportfrom and into string
        /// <summary>
        public static class MessageTransportHandling
        {
            public static bool TryParse(string value, out MessageTransport result)
            {
                result = default(MessageTransport);
                
                if( value=="http")
                    result = MessageTransport.Http;
                else if( value=="ftp")
                    result = MessageTransport.Ftp;
                else if( value=="mllp")
                    result = MessageTransport.Mllp;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(MessageTransport value)
            {
                if( value==MessageTransport.Http )
                    return "http";
                else if( value==MessageTransport.Ftp )
                    return "ftp";
                else if( value==MessageTransport.Mllp )
                    return "mllp";
                else
                    throw new ArgumentException("Unrecognized MessageTransport value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The mode of a message conformance statement
        /// </summary>
        public enum ConformanceEventMode
        {
            Sender, // The application sends requests and receives responses
            Receiver, // The application receives requests and sends responses
        }
        
        /// <summary>
        /// Conversion of ConformanceEventModefrom and into string
        /// <summary>
        public static class ConformanceEventModeHandling
        {
            public static bool TryParse(string value, out ConformanceEventMode result)
            {
                result = default(ConformanceEventMode);
                
                if( value=="sender")
                    result = ConformanceEventMode.Sender;
                else if( value=="receiver")
                    result = ConformanceEventMode.Receiver;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ConformanceEventMode value)
            {
                if( value==ConformanceEventMode.Sender )
                    return "sender";
                else if( value==ConformanceEventMode.Receiver )
                    return "receiver";
                else
                    throw new ArgumentException("Unrecognized ConformanceEventMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Types of security services used with FHIR
        /// </summary>
        public enum RestfulSecurityService
        {
            OAuth, // OAuth (see oauth.net)
            OAuth2, // OAuth version 2 (see oauth.net)
            NTLM, // Microsoft NTLM Authentication
            Basic, // Basic authentication defined in HTTP specification
            Kerberos, // see…
        }
        
        /// <summary>
        /// Conversion of RestfulSecurityServicefrom and into string
        /// <summary>
        public static class RestfulSecurityServiceHandling
        {
            public static bool TryParse(string value, out RestfulSecurityService result)
            {
                result = default(RestfulSecurityService);
                
                if( value=="OAuth")
                    result = RestfulSecurityService.OAuth;
                else if( value=="OAuth2")
                    result = RestfulSecurityService.OAuth2;
                else if( value=="NTLM")
                    result = RestfulSecurityService.NTLM;
                else if( value=="Basic")
                    result = RestfulSecurityService.Basic;
                else if( value=="Kerberos")
                    result = RestfulSecurityService.Kerberos;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(RestfulSecurityService value)
            {
                if( value==RestfulSecurityService.OAuth )
                    return "OAuth";
                else if( value==RestfulSecurityService.OAuth2 )
                    return "OAuth2";
                else if( value==RestfulSecurityService.NTLM )
                    return "NTLM";
                else if( value==RestfulSecurityService.Basic )
                    return "Basic";
                else if( value==RestfulSecurityService.Kerberos )
                    return "Kerberos";
                else
                    throw new ArgumentException("Unrecognized RestfulSecurityService value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceSoftwareComponent")]
        public partial class ConformanceSoftwareComponent : Element
        {
            /// <summary>
            /// Name software is known by
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Version covered by this statement
            /// </summary>
            public FhirString Version { get; set; }
            
            /// <summary>
            /// Date this version released
            /// </summary>
            public FhirDateTime ReleaseDate { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestComponent")]
        public partial class ConformanceRestComponent : Element
        {
            /// <summary>
            /// client | server
            /// </summary>
            public Code<Conformance.RestfulConformanceMode> Mode { get; set; }
            
            /// <summary>
            /// General description of implementation
            /// </summary>
            public FhirString Documentation { get; set; }
            
            /// <summary>
            /// Information about security of implementation
            /// </summary>
            public ConformanceRestSecurityComponent Security { get; set; }
            
            /// <summary>
            /// Resource served on the REST interface
            /// </summary>
            public List<ConformanceRestResourceComponent> Resource { get; set; }
            
            /// <summary>
            /// If batches are supported
            /// </summary>
            public FhirBoolean Batch { get; set; }
            
            /// <summary>
            /// If a system wide history list is supported
            /// </summary>
            public FhirBoolean History { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceMessagingComponent")]
        public partial class ConformanceMessagingComponent : Element
        {
            /// <summary>
            /// Actual endpoint being described
            /// </summary>
            public FhirUri Endpoint { get; set; }
            
            /// <summary>
            /// Messaging interface behavior details
            /// </summary>
            public FhirString Documentation { get; set; }
            
            /// <summary>
            /// Declare support for this event
            /// </summary>
            public List<ConformanceMessagingEventComponent> Event { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceImplementationComponent")]
        public partial class ConformanceImplementationComponent : Element
        {
            /// <summary>
            /// Describes this specific instance
            /// </summary>
            public FhirString Description { get; set; }
            
            /// <summary>
            /// Base URL for the installation
            /// </summary>
            public FhirUri Url { get; set; }
            
            /// <summary>
            /// The software running this instance
            /// </summary>
            public ConformanceSoftwareComponent Software { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestResourceComponent")]
        public partial class ConformanceRestResourceComponent : Element
        {
            /// <summary>
            /// Resource type
            /// </summary>
            public Code Type { get; set; }
            
            /// <summary>
            /// Resource Profiles supported
            /// </summary>
            public FhirUri Profile { get; set; }
            
            /// <summary>
            /// What operations are supported?
            /// </summary>
            public List<ConformanceRestResourceOperationComponent> Operation { get; set; }
            
            /// <summary>
            /// Whether vRead can return past versions
            /// </summary>
            public FhirBoolean ReadHistory { get; set; }
            
            /// <summary>
            /// _include values supported by the server
            /// </summary>
            public List<FhirString> SearchInclude { get; set; }
            
            /// <summary>
            /// Additional search params defined
            /// </summary>
            public List<ConformanceRestResourceSearchParamComponent> SearchParam { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestResourceOperationComponent")]
        public partial class ConformanceRestResourceOperationComponent : Element
        {
            /// <summary>
            /// read | vread | update | etc.
            /// </summary>
            public Code<Conformance.RestfulOperation> Code { get; set; }
            
            /// <summary>
            /// Anything special about operation behavior
            /// </summary>
            public FhirString Documentation { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceProposalComponent")]
        public partial class ConformanceProposalComponent : Element
        {
            /// <summary>
            /// Details of proposal or requirements document
            /// </summary>
            public FhirString Description { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceMessagingEventComponent")]
        public partial class ConformanceMessagingEventComponent : Element
        {
            /// <summary>
            /// Event type
            /// </summary>
            public Code Code { get; set; }
            
            /// <summary>
            /// sender | receiver
            /// </summary>
            public Code<Conformance.ConformanceEventMode> Mode { get; set; }
            
            /// <summary>
            /// http | ftp |MLLP | etc.
            /// </summary>
            public List<Coding> Protocol { get; set; }
            
            /// <summary>
            /// Resource that's focus of message
            /// </summary>
            public Code Focus { get; set; }
            
            /// <summary>
            /// Profile that describes the request
            /// </summary>
            public FhirUri Request { get; set; }
            
            /// <summary>
            /// Profile that describes the response
            /// </summary>
            public FhirUri Response { get; set; }
            
            /// <summary>
            /// Endpoint-specific event documentation
            /// </summary>
            public FhirString Documentation { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestSecurityCertificateComponent")]
        public partial class ConformanceRestSecurityCertificateComponent : Element
        {
            /// <summary>
            /// Mime type for certificate
            /// </summary>
            public Code Type { get; set; }
            
            /// <summary>
            /// Actual certificate
            /// </summary>
            public Base64Binary Blob { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceDocumentComponent")]
        public partial class ConformanceDocumentComponent : Element
        {
            /// <summary>
            /// producer | consumer
            /// </summary>
            public Code<Conformance.DocumentMode> Mode { get; set; }
            
            /// <summary>
            /// Description of document support
            /// </summary>
            public FhirString Documentation { get; set; }
            
            /// <summary>
            /// Constraint on a resource used in the document
            /// </summary>
            public FhirUri Profile { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestSecurityComponent")]
        public partial class ConformanceRestSecurityComponent : Element
        {
            /// <summary>
            /// What type of security services are supported/required
            /// </summary>
            public List<CodeableConcept> Service { get; set; }
            
            /// <summary>
            /// General description of how security works
            /// </summary>
            public FhirString Description { get; set; }
            
            /// <summary>
            /// Certificates associated with security profiles
            /// </summary>
            public List<ConformanceRestSecurityCertificateComponent> Certificate { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformancePublisherComponent")]
        public partial class ConformancePublisherComponent : Element
        {
            /// <summary>
            /// Publishing Organization
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Address of Organization
            /// </summary>
            public Address Address { get; set; }
            
            /// <summary>
            /// Contacts for Organization
            /// </summary>
            public List<Contact> Contact { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConformanceRestResourceSearchParamComponent")]
        public partial class ConformanceRestResourceSearchParamComponent : Element
        {
            /// <summary>
            /// Name of search parameter
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Source of definition
            /// </summary>
            public FhirUri Source { get; set; }
            
            /// <summary>
            /// Type of search parameter
            /// </summary>
            public Code<SearchParamType> Type { get; set; }
            
            /// <summary>
            /// If multiples are allowed, and what it means
            /// </summary>
            public Code<SearchRepeatBehavior> Repeats { get; set; }
            
            /// <summary>
            /// Contents and meaning of search parameter
            /// </summary>
            public FhirString Documentation { get; set; }
            
            /// <summary>
            /// Types of resource (if a resource reference)
            /// </summary>
            public List<Code> Target { get; set; }
            
            /// <summary>
            /// Chained names supported
            /// </summary>
            public List<FhirString> Chain { get; set; }
            
        }
        
        
        /// <summary>
        /// Publication Date
        /// </summary>
        public FhirDateTime Date { get; set; }
        
        /// <summary>
        /// Publisher of the statement
        /// </summary>
        public ConformancePublisherComponent Publisher { get; set; }
        
        /// <summary>
        /// Software that is covered by this conformance statement
        /// </summary>
        public ConformanceSoftwareComponent Software { get; set; }
        
        /// <summary>
        /// If this describes a specific instance
        /// </summary>
        public ConformanceImplementationComponent Implementation { get; set; }
        
        /// <summary>
        /// If profile is for proposal
        /// </summary>
        public ConformanceProposalComponent Proposal { get; set; }
        
        /// <summary>
        /// FHIR Version
        /// </summary>
        public Id Version { get; set; }
        
        /// <summary>
        /// True if application accepts unknown elements
        /// </summary>
        public FhirBoolean AcceptUnknown { get; set; }
        
        /// <summary>
        /// formats supported (xml | json | mime type)
        /// </summary>
        public List<Code> Format { get; set; }
        
        /// <summary>
        /// If the endpoint is a RESTful one
        /// </summary>
        public List<ConformanceRestComponent> Rest { get; set; }
        
        /// <summary>
        /// If messaging is supported
        /// </summary>
        public List<ConformanceMessagingComponent> Messaging { get; set; }
        
        /// <summary>
        /// Document definition
        /// </summary>
        public List<ConformanceDocumentComponent> Document { get; set; }
        
    }
    
}
