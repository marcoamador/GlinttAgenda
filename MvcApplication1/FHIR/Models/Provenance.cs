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
    /// Who, What, When for another resource
    /// </summary>
    [FhirResource("Provenance")]
    public partial class Provenance : Resource
    {
        /// <summary>
        /// The type of a provenance participant
        /// </summary>
        public enum ProvenanceParticipantType
        {
            Resource, // The participant is a resource itself. The id is a reference to the resource
            Person, // The participant is a person acting on their on behalf or on behalf of the patient rather than as an provider for an organization.  I.e. "not a healthcare provider"
            Provider, // The participant is a provider
            Organization, // The participant is an organization
            Software, // The participant is a software application
            Record, // The participant is a logical record. The record itself participated in the activity
            Document, // The participant is a document
        }
        
        /// <summary>
        /// Conversion of ProvenanceParticipantTypefrom and into string
        /// <summary>
        public static class ProvenanceParticipantTypeHandling
        {
            public static bool TryParse(string value, out ProvenanceParticipantType result)
            {
                result = default(ProvenanceParticipantType);
                
                if( value=="resource")
                    result = ProvenanceParticipantType.Resource;
                else if( value=="person")
                    result = ProvenanceParticipantType.Person;
                else if( value=="provider")
                    result = ProvenanceParticipantType.Provider;
                else if( value=="organization")
                    result = ProvenanceParticipantType.Organization;
                else if( value=="software")
                    result = ProvenanceParticipantType.Software;
                else if( value=="record")
                    result = ProvenanceParticipantType.Record;
                else if( value=="document")
                    result = ProvenanceParticipantType.Document;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ProvenanceParticipantType value)
            {
                if( value==ProvenanceParticipantType.Resource )
                    return "resource";
                else if( value==ProvenanceParticipantType.Person )
                    return "person";
                else if( value==ProvenanceParticipantType.Provider )
                    return "provider";
                else if( value==ProvenanceParticipantType.Organization )
                    return "organization";
                else if( value==ProvenanceParticipantType.Software )
                    return "software";
                else if( value==ProvenanceParticipantType.Record )
                    return "record";
                else if( value==ProvenanceParticipantType.Document )
                    return "document";
                else
                    throw new ArgumentException("Unrecognized ProvenanceParticipantType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The role that a provenance participant played
        /// </summary>
        public enum ProvenanceParticipantRole
        {
            Enterer, // A person entering the data into the originating system
            Performer, // A person, animal, organization or device that who actually and principally carries out the activity
            Author, // A party that originates the resource and therefore has responsibility for the information given in the resource and ownership of this resource
            Verifier, // A person who verifies the correctness and appropriateness of activity
            Attestor, // A verifier who attests to the accuracy of the resource
            Informant, // A person who reported information that contributed to the resource
            Source, // An information source from which the portions of the resource are derived
            Cc, // A party, who may or should receive or who has recieved a copy of the resource or subsequent or derivative information of that resource
            Application, // An application with a user interface that interacts with a person
            Daemon, // A background process that transfers information from one place or form to another
        }
        
        /// <summary>
        /// Conversion of ProvenanceParticipantRolefrom and into string
        /// <summary>
        public static class ProvenanceParticipantRoleHandling
        {
            public static bool TryParse(string value, out ProvenanceParticipantRole result)
            {
                result = default(ProvenanceParticipantRole);
                
                if( value=="enterer")
                    result = ProvenanceParticipantRole.Enterer;
                else if( value=="performer")
                    result = ProvenanceParticipantRole.Performer;
                else if( value=="author")
                    result = ProvenanceParticipantRole.Author;
                else if( value=="verifier")
                    result = ProvenanceParticipantRole.Verifier;
                else if( value=="attestor")
                    result = ProvenanceParticipantRole.Attestor;
                else if( value=="informant")
                    result = ProvenanceParticipantRole.Informant;
                else if( value=="source")
                    result = ProvenanceParticipantRole.Source;
                else if( value=="cc")
                    result = ProvenanceParticipantRole.Cc;
                else if( value=="application")
                    result = ProvenanceParticipantRole.Application;
                else if( value=="daemon")
                    result = ProvenanceParticipantRole.Daemon;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ProvenanceParticipantRole value)
            {
                if( value==ProvenanceParticipantRole.Enterer )
                    return "enterer";
                else if( value==ProvenanceParticipantRole.Performer )
                    return "performer";
                else if( value==ProvenanceParticipantRole.Author )
                    return "author";
                else if( value==ProvenanceParticipantRole.Verifier )
                    return "verifier";
                else if( value==ProvenanceParticipantRole.Attestor )
                    return "attestor";
                else if( value==ProvenanceParticipantRole.Informant )
                    return "informant";
                else if( value==ProvenanceParticipantRole.Source )
                    return "source";
                else if( value==ProvenanceParticipantRole.Cc )
                    return "cc";
                else if( value==ProvenanceParticipantRole.Application )
                    return "application";
                else if( value==ProvenanceParticipantRole.Daemon )
                    return "daemon";
                else
                    throw new ArgumentException("Unrecognized ProvenanceParticipantRole value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProvenanceActivityComponent")]
        public partial class ProvenanceActivityComponent : Element
        {
            /// <summary>
            /// When the activity occurred
            /// </summary>
            public Period Period { get; set; }
            
            /// <summary>
            /// When the activity was recorded / updated
            /// </summary>
            public Instant Recorded { get; set; }
            
            /// <summary>
            /// Reason the activity is occurring
            /// </summary>
            public CodeableConcept Reason { get; set; }
            
            /// <summary>
            /// Where the activity occurred, if relevant
            /// </summary>
            public ProvenanceActivityLocationComponent Location { get; set; }
            
            /// <summary>
            /// Policy or plan the activity was defined by
            /// </summary>
            public FhirUri Policy { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProvenancePartyComponent")]
        public partial class ProvenancePartyComponent : Element
        {
            /// <summary>
            /// author | overseer | enterer | attester | source | cc: +
            /// </summary>
            public Coding Role { get; set; }
            
            /// <summary>
            /// Resource | Person | Application | Record | Document +
            /// </summary>
            public Coding Type { get; set; }
            
            /// <summary>
            /// Identity of participant (urn or url)
            /// </summary>
            public FhirUri Id { get; set; }
            
            /// <summary>
            /// Human description of participant
            /// </summary>
            public FhirString Description { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProvenanceActivityLocationComponent")]
        public partial class ProvenanceActivityLocationComponent : Element
        {
            /// <summary>
            /// Type of location (Classification)
            /// </summary>
            public CodeableConcept Type { get; set; }
            
            /// <summary>
            /// An identifier for the location
            /// </summary>
            public Identifier Id { get; set; }
            
            /// <summary>
            /// Human description of location
            /// </summary>
            public FhirString Description { get; set; }
            
            /// <summary>
            /// Geospatial coordinates of the location. What format?
            /// </summary>
            public FhirString Coords { get; set; }
            
        }
        
        
        /// <summary>
        /// Target resource (usually version specific)
        /// </summary>
        public ResourceReference Target { get; set; }
        
        /// <summary>
        /// Activity that created resource
        /// </summary>
        public ProvenanceActivityComponent Activity { get; set; }
        
        /// <summary>
        /// Person, organization, records, etc. involved in creating resource
        /// </summary>
        public List<ProvenancePartyComponent> Party { get; set; }
        
        /// <summary>
        /// Digital Signature of resource
        /// </summary>
        public FhirString Signature { get; set; }
        
    }
    
}
