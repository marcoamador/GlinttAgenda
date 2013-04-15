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
    /// A message that contains resources
    /// </summary>
    [FhirResource("Message")]
    public partial class Message : Resource
    {
        /// <summary>
        /// The kind of response to a message
        /// </summary>
        public enum ResponseCode
        {
            Ok, // The message was accepted and processed without error
            Error, // Some internal unexpected error occurred - wait and try again. Note - this is usually used for things like database unavailable, which may be expected to resolve, though human intervention may be required
            Rejection, // The message was rejected because of some content in it. There is no point in re-sending without change. The response narrative must describe what the issue is.
            Rules, // The message was rejected because of some event-specific business rules, and it may be possible to modify the request and re-submit (as a different request). The response must include an Issue report that describes what problem is
            Undeliverable, // A middleware agent was unable to deliver the message to its intended destination
        }
        
        /// <summary>
        /// Conversion of ResponseCodefrom and into string
        /// <summary>
        public static class ResponseCodeHandling
        {
            public static bool TryParse(string value, out ResponseCode result)
            {
                result = default(ResponseCode);
                
                if( value=="ok")
                    result = ResponseCode.Ok;
                else if( value=="error")
                    result = ResponseCode.Error;
                else if( value=="rejection")
                    result = ResponseCode.Rejection;
                else if( value=="rules")
                    result = ResponseCode.Rules;
                else if( value=="undeliverable")
                    result = ResponseCode.Undeliverable;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ResponseCode value)
            {
                if( value==ResponseCode.Ok )
                    return "ok";
                else if( value==ResponseCode.Error )
                    return "error";
                else if( value==ResponseCode.Rejection )
                    return "rejection";
                else if( value==ResponseCode.Rules )
                    return "rules";
                else if( value==ResponseCode.Undeliverable )
                    return "undeliverable";
                else
                    throw new ArgumentException("Unrecognized ResponseCode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MessageDestinationComponent")]
        public partial class MessageDestinationComponent : Element
        {
            /// <summary>
            /// Name of system
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Particular delivery destination within the destination
            /// </summary>
            public ResourceReference Target { get; set; }
            
            /// <summary>
            /// Actual destination address or id
            /// </summary>
            public FhirUri Endpoint { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MessageSourceComponent")]
        public partial class MessageSourceComponent : Element
        {
            /// <summary>
            /// Name of system
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Name of software running the system
            /// </summary>
            public FhirString Software { get; set; }
            
            /// <summary>
            /// Version of software running
            /// </summary>
            public FhirString Version { get; set; }
            
            /// <summary>
            /// Human contact for problems
            /// </summary>
            public Contact Contact { get; set; }
            
            /// <summary>
            /// Actual message source address or id
            /// </summary>
            public FhirUri Endpoint { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("MessageResponseComponent")]
        public partial class MessageResponseComponent : Element
        {
            /// <summary>
            /// Id of original message
            /// </summary>
            public Id Id { get; set; }
            
            /// <summary>
            /// Type of response to the message
            /// </summary>
            public Code<Message.ResponseCode> Code { get; set; }
            
            /// <summary>
            /// Specific list of hints/warnings/errors
            /// </summary>
            public ResourceReference Details { get; set; }
            
        }
        
        
        /// <summary>
        /// Id of this message
        /// </summary>
        public Id Id { get; set; }
        
        /// <summary>
        /// Instant the message was sent
        /// </summary>
        public Instant Instant { get; set; }
        
        /// <summary>
        /// Code for the event his message represents
        /// </summary>
        public Code Event { get; set; }
        
        /// <summary>
        /// If this is a reply to prior message
        /// </summary>
        public MessageResponseComponent Response { get; set; }
        
        /// <summary>
        /// Message Source Application
        /// </summary>
        public MessageSourceComponent Source { get; set; }
        
        /// <summary>
        /// Message Destination Application
        /// </summary>
        public MessageDestinationComponent Destination { get; set; }
        
        /// <summary>
        /// The source of the data entry
        /// </summary>
        public ResourceReference Enterer { get; set; }
        
        /// <summary>
        /// The source of the decision
        /// </summary>
        public ResourceReference Author { get; set; }
        
        /// <summary>
        /// Intended "real-world" recipient for the data
        /// </summary>
        public ResourceReference Receiver { get; set; }
        
        /// <summary>
        /// Final responsibility for event
        /// </summary>
        public ResourceReference Responsible { get; set; }
        
        /// <summary>
        /// Time of effect
        /// </summary>
        public Period Effective { get; set; }
        
        /// <summary>
        /// Cause of event
        /// </summary>
        public CodeableConcept Reason { get; set; }
        
        /// <summary>
        /// The actual content of the message
        /// </summary>
        public List<ResourceReference> Data { get; set; }
        
    }
    
}
