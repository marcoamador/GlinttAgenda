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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A record of an event happening in an application
    /// </summary>
    [FhirResource("SecurityEvent")]
    public partial class SecurityEvent : Resource
    {
        /// <summary>
        /// Code representing the functional application role of Participant Object being audited
        /// </summary>
        public enum SecurityEventObjectRole
        {
            N1, // Patient
            N2, // Location
            N3, // Report
            N4, // Resource
            N5, // Master file
            N6, // User
            N7, // List
            N8, // Doctor
            N9, // Subscriber
            N10, // Guarantor
            N11, // Security User Entity
            N12, // Security User Group
            N13, // Security Resource
            N14, // Security Granularity Definition
            N15, // Practitioner
            N16, // Data Destination
            N17, // Data Repository
            N18, // Schedule
            N19, // Customer
            N20, // Job
            N21, // Job Stream
            N22, // Table
            N23, // Routing Criteria
            N24, // Query
        }
        
        /// <summary>
        /// Conversion of SecurityEventObjectRolefrom and into string
        /// <summary>
        public static class SecurityEventObjectRoleHandling
        {
            public static bool TryParse(string value, out SecurityEventObjectRole result)
            {
                result = default(SecurityEventObjectRole);
                
                if( value=="1")
                    result = SecurityEventObjectRole.N1;
                else if( value=="2")
                    result = SecurityEventObjectRole.N2;
                else if( value=="3")
                    result = SecurityEventObjectRole.N3;
                else if( value=="4")
                    result = SecurityEventObjectRole.N4;
                else if( value=="5")
                    result = SecurityEventObjectRole.N5;
                else if( value=="6")
                    result = SecurityEventObjectRole.N6;
                else if( value=="7")
                    result = SecurityEventObjectRole.N7;
                else if( value=="8")
                    result = SecurityEventObjectRole.N8;
                else if( value=="9")
                    result = SecurityEventObjectRole.N9;
                else if( value=="10")
                    result = SecurityEventObjectRole.N10;
                else if( value=="11")
                    result = SecurityEventObjectRole.N11;
                else if( value=="12")
                    result = SecurityEventObjectRole.N12;
                else if( value=="13")
                    result = SecurityEventObjectRole.N13;
                else if( value=="14")
                    result = SecurityEventObjectRole.N14;
                else if( value=="15")
                    result = SecurityEventObjectRole.N15;
                else if( value=="16")
                    result = SecurityEventObjectRole.N16;
                else if( value=="17")
                    result = SecurityEventObjectRole.N17;
                else if( value=="18")
                    result = SecurityEventObjectRole.N18;
                else if( value=="19")
                    result = SecurityEventObjectRole.N19;
                else if( value=="20")
                    result = SecurityEventObjectRole.N20;
                else if( value=="21")
                    result = SecurityEventObjectRole.N21;
                else if( value=="22")
                    result = SecurityEventObjectRole.N22;
                else if( value=="23")
                    result = SecurityEventObjectRole.N23;
                else if( value=="24")
                    result = SecurityEventObjectRole.N24;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventObjectRole value)
            {
                if( value==SecurityEventObjectRole.N1 )
                    return "1";
                else if( value==SecurityEventObjectRole.N2 )
                    return "2";
                else if( value==SecurityEventObjectRole.N3 )
                    return "3";
                else if( value==SecurityEventObjectRole.N4 )
                    return "4";
                else if( value==SecurityEventObjectRole.N5 )
                    return "5";
                else if( value==SecurityEventObjectRole.N6 )
                    return "6";
                else if( value==SecurityEventObjectRole.N7 )
                    return "7";
                else if( value==SecurityEventObjectRole.N8 )
                    return "8";
                else if( value==SecurityEventObjectRole.N9 )
                    return "9";
                else if( value==SecurityEventObjectRole.N10 )
                    return "10";
                else if( value==SecurityEventObjectRole.N11 )
                    return "11";
                else if( value==SecurityEventObjectRole.N12 )
                    return "12";
                else if( value==SecurityEventObjectRole.N13 )
                    return "13";
                else if( value==SecurityEventObjectRole.N14 )
                    return "14";
                else if( value==SecurityEventObjectRole.N15 )
                    return "15";
                else if( value==SecurityEventObjectRole.N16 )
                    return "16";
                else if( value==SecurityEventObjectRole.N17 )
                    return "17";
                else if( value==SecurityEventObjectRole.N18 )
                    return "18";
                else if( value==SecurityEventObjectRole.N19 )
                    return "19";
                else if( value==SecurityEventObjectRole.N20 )
                    return "20";
                else if( value==SecurityEventObjectRole.N21 )
                    return "21";
                else if( value==SecurityEventObjectRole.N22 )
                    return "22";
                else if( value==SecurityEventObjectRole.N23 )
                    return "23";
                else if( value==SecurityEventObjectRole.N24 )
                    return "24";
                else
                    throw new ArgumentException("Unrecognized SecurityEventObjectRole value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Code for the participant object type being audited
        /// </summary>
        public enum SecurityEventObjectType
        {
            N1, // Person
            N2, // System Object
            N3, // Organization
            N4, // Other
        }
        
        /// <summary>
        /// Conversion of SecurityEventObjectTypefrom and into string
        /// <summary>
        public static class SecurityEventObjectTypeHandling
        {
            public static bool TryParse(string value, out SecurityEventObjectType result)
            {
                result = default(SecurityEventObjectType);
                
                if( value=="1")
                    result = SecurityEventObjectType.N1;
                else if( value=="2")
                    result = SecurityEventObjectType.N2;
                else if( value=="3")
                    result = SecurityEventObjectType.N3;
                else if( value=="4")
                    result = SecurityEventObjectType.N4;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventObjectType value)
            {
                if( value==SecurityEventObjectType.N1 )
                    return "1";
                else if( value==SecurityEventObjectType.N2 )
                    return "2";
                else if( value==SecurityEventObjectType.N3 )
                    return "3";
                else if( value==SecurityEventObjectType.N4 )
                    return "4";
                else
                    throw new ArgumentException("Unrecognized SecurityEventObjectType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Identifier for the data life-cycle stage for the participant object
        /// </summary>
        public enum SecurityEventObjectLifecycle
        {
            N1, // Origination / Creation
            N2, // Import / Copy from original
            N3, // Amendment
            N4, // Verification
            N5, // Translation
            N6, // Access / Use
            N7, // De-identification
            N8, // Aggregation, summarization, derivation
            N9, // Report
            N10, // Export / Copy to target
            N11, // Disclosure
            N12, // Receipt of disclosure
            N13, // Archiving
            N14, // Logical deletion
            N15, // Permanent erasure / Physical destruction
        }
        
        /// <summary>
        /// Conversion of SecurityEventObjectLifecyclefrom and into string
        /// <summary>
        public static class SecurityEventObjectLifecycleHandling
        {
            public static bool TryParse(string value, out SecurityEventObjectLifecycle result)
            {
                result = default(SecurityEventObjectLifecycle);
                
                if( value=="1")
                    result = SecurityEventObjectLifecycle.N1;
                else if( value=="2")
                    result = SecurityEventObjectLifecycle.N2;
                else if( value=="3")
                    result = SecurityEventObjectLifecycle.N3;
                else if( value=="4")
                    result = SecurityEventObjectLifecycle.N4;
                else if( value=="5")
                    result = SecurityEventObjectLifecycle.N5;
                else if( value=="6")
                    result = SecurityEventObjectLifecycle.N6;
                else if( value=="7")
                    result = SecurityEventObjectLifecycle.N7;
                else if( value=="8")
                    result = SecurityEventObjectLifecycle.N8;
                else if( value=="9")
                    result = SecurityEventObjectLifecycle.N9;
                else if( value=="10")
                    result = SecurityEventObjectLifecycle.N10;
                else if( value=="11")
                    result = SecurityEventObjectLifecycle.N11;
                else if( value=="12")
                    result = SecurityEventObjectLifecycle.N12;
                else if( value=="13")
                    result = SecurityEventObjectLifecycle.N13;
                else if( value=="14")
                    result = SecurityEventObjectLifecycle.N14;
                else if( value=="15")
                    result = SecurityEventObjectLifecycle.N15;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventObjectLifecycle value)
            {
                if( value==SecurityEventObjectLifecycle.N1 )
                    return "1";
                else if( value==SecurityEventObjectLifecycle.N2 )
                    return "2";
                else if( value==SecurityEventObjectLifecycle.N3 )
                    return "3";
                else if( value==SecurityEventObjectLifecycle.N4 )
                    return "4";
                else if( value==SecurityEventObjectLifecycle.N5 )
                    return "5";
                else if( value==SecurityEventObjectLifecycle.N6 )
                    return "6";
                else if( value==SecurityEventObjectLifecycle.N7 )
                    return "7";
                else if( value==SecurityEventObjectLifecycle.N8 )
                    return "8";
                else if( value==SecurityEventObjectLifecycle.N9 )
                    return "9";
                else if( value==SecurityEventObjectLifecycle.N10 )
                    return "10";
                else if( value==SecurityEventObjectLifecycle.N11 )
                    return "11";
                else if( value==SecurityEventObjectLifecycle.N12 )
                    return "12";
                else if( value==SecurityEventObjectLifecycle.N13 )
                    return "13";
                else if( value==SecurityEventObjectLifecycle.N14 )
                    return "14";
                else if( value==SecurityEventObjectLifecycle.N15 )
                    return "15";
                else
                    throw new ArgumentException("Unrecognized SecurityEventObjectLifecycle value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Describes the identifier that is contained in Participant Object ID
        /// </summary>
        public enum SecurityEventObjectIdType
        {
            N1, // Medical Record Number
            N2, // Patient Number
            N3, // Visit Number
            N4, // Enrollee Number
            N5, // Social Security Number
            N6, // Account Number
            N7, // Guarantor Number
            N8, // Report Name
            N9, // Report Number
            N10, // Search Criteria
            N11, // User Identifier
            N12, // URI
        }
        
        /// <summary>
        /// Conversion of SecurityEventObjectIdTypefrom and into string
        /// <summary>
        public static class SecurityEventObjectIdTypeHandling
        {
            public static bool TryParse(string value, out SecurityEventObjectIdType result)
            {
                result = default(SecurityEventObjectIdType);
                
                if( value=="1")
                    result = SecurityEventObjectIdType.N1;
                else if( value=="2")
                    result = SecurityEventObjectIdType.N2;
                else if( value=="3")
                    result = SecurityEventObjectIdType.N3;
                else if( value=="4")
                    result = SecurityEventObjectIdType.N4;
                else if( value=="5")
                    result = SecurityEventObjectIdType.N5;
                else if( value=="6")
                    result = SecurityEventObjectIdType.N6;
                else if( value=="7")
                    result = SecurityEventObjectIdType.N7;
                else if( value=="8")
                    result = SecurityEventObjectIdType.N8;
                else if( value=="9")
                    result = SecurityEventObjectIdType.N9;
                else if( value=="10")
                    result = SecurityEventObjectIdType.N10;
                else if( value=="11")
                    result = SecurityEventObjectIdType.N11;
                else if( value=="12")
                    result = SecurityEventObjectIdType.N12;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventObjectIdType value)
            {
                if( value==SecurityEventObjectIdType.N1 )
                    return "1";
                else if( value==SecurityEventObjectIdType.N2 )
                    return "2";
                else if( value==SecurityEventObjectIdType.N3 )
                    return "3";
                else if( value==SecurityEventObjectIdType.N4 )
                    return "4";
                else if( value==SecurityEventObjectIdType.N5 )
                    return "5";
                else if( value==SecurityEventObjectIdType.N6 )
                    return "6";
                else if( value==SecurityEventObjectIdType.N7 )
                    return "7";
                else if( value==SecurityEventObjectIdType.N8 )
                    return "8";
                else if( value==SecurityEventObjectIdType.N9 )
                    return "9";
                else if( value==SecurityEventObjectIdType.N10 )
                    return "10";
                else if( value==SecurityEventObjectIdType.N11 )
                    return "11";
                else if( value==SecurityEventObjectIdType.N12 )
                    return "12";
                else
                    throw new ArgumentException("Unrecognized SecurityEventObjectIdType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Indicates whether the event succeeded or failed
        /// </summary>
        public enum SecurityEventEventOutcome
        {
            N0, // Success
            N4, // Minor failure
            N8, // Serious failure
            N12, // Major failure
        }
        
        /// <summary>
        /// Conversion of SecurityEventEventOutcomefrom and into string
        /// <summary>
        public static class SecurityEventEventOutcomeHandling
        {
            public static bool TryParse(string value, out SecurityEventEventOutcome result)
            {
                result = default(SecurityEventEventOutcome);
                
                if( value=="0")
                    result = SecurityEventEventOutcome.N0;
                else if( value=="4")
                    result = SecurityEventEventOutcome.N4;
                else if( value=="8")
                    result = SecurityEventEventOutcome.N8;
                else if( value=="12")
                    result = SecurityEventEventOutcome.N12;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventEventOutcome value)
            {
                if( value==SecurityEventEventOutcome.N0 )
                    return "0";
                else if( value==SecurityEventEventOutcome.N4 )
                    return "4";
                else if( value==SecurityEventEventOutcome.N8 )
                    return "8";
                else if( value==SecurityEventEventOutcome.N12 )
                    return "12";
                else
                    throw new ArgumentException("Unrecognized SecurityEventEventOutcome value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// the type of network access point that originated the audit event
        /// </summary>
        public enum SecurityEventParticipantNetworkType
        {
            Name, // Machine Name, including DNS name
            Ip, // IP Address
            Phone, // Telephone Number
        }
        
        /// <summary>
        /// Conversion of SecurityEventParticipantNetworkTypefrom and into string
        /// <summary>
        public static class SecurityEventParticipantNetworkTypeHandling
        {
            public static bool TryParse(string value, out SecurityEventParticipantNetworkType result)
            {
                result = default(SecurityEventParticipantNetworkType);
                
                if( value=="name")
                    result = SecurityEventParticipantNetworkType.Name;
                else if( value=="ip")
                    result = SecurityEventParticipantNetworkType.Ip;
                else if( value=="phone")
                    result = SecurityEventParticipantNetworkType.Phone;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventParticipantNetworkType value)
            {
                if( value==SecurityEventParticipantNetworkType.Name )
                    return "name";
                else if( value==SecurityEventParticipantNetworkType.Ip )
                    return "ip";
                else if( value==SecurityEventParticipantNetworkType.Phone )
                    return "phone";
                else
                    throw new ArgumentException("Unrecognized SecurityEventParticipantNetworkType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Code specifying the type of source where event originated
        /// </summary>
        public enum SecurityEventSourceType
        {
            N1, // End-user interface
            N2, // Data acquisition device or instrument
            N3, // Web server process tier in a multi-tier system
            N4, // Application server process tier in a multi-tier system
            N5, // Database server process tier in a multi-tier system
            N6, // Security server, e.g., a domain controller
            N7, // ISO level 1-3 network component
            N8, // ISO level 4-6 operating software
            N9, // External source, other or unknown type
        }
        
        /// <summary>
        /// Conversion of SecurityEventSourceTypefrom and into string
        /// <summary>
        public static class SecurityEventSourceTypeHandling
        {
            public static bool TryParse(string value, out SecurityEventSourceType result)
            {
                result = default(SecurityEventSourceType);
                
                if( value=="1")
                    result = SecurityEventSourceType.N1;
                else if( value=="2")
                    result = SecurityEventSourceType.N2;
                else if( value=="3")
                    result = SecurityEventSourceType.N3;
                else if( value=="4")
                    result = SecurityEventSourceType.N4;
                else if( value=="5")
                    result = SecurityEventSourceType.N5;
                else if( value=="6")
                    result = SecurityEventSourceType.N6;
                else if( value=="7")
                    result = SecurityEventSourceType.N7;
                else if( value=="8")
                    result = SecurityEventSourceType.N8;
                else if( value=="9")
                    result = SecurityEventSourceType.N9;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventSourceType value)
            {
                if( value==SecurityEventSourceType.N1 )
                    return "1";
                else if( value==SecurityEventSourceType.N2 )
                    return "2";
                else if( value==SecurityEventSourceType.N3 )
                    return "3";
                else if( value==SecurityEventSourceType.N4 )
                    return "4";
                else if( value==SecurityEventSourceType.N5 )
                    return "5";
                else if( value==SecurityEventSourceType.N6 )
                    return "6";
                else if( value==SecurityEventSourceType.N7 )
                    return "7";
                else if( value==SecurityEventSourceType.N8 )
                    return "8";
                else if( value==SecurityEventSourceType.N9 )
                    return "9";
                else
                    throw new ArgumentException("Unrecognized SecurityEventSourceType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The severity of the audit entry
        /// </summary>
        public enum SecurityEventSeverity
        {
            Emergency, // system is unusable
            Alert, // action must be taken immediately
            Critical, // critical conditions
            Error, // error conditions
            Warning, // warning conditions
            Notice, // normal but significant condition
            Informational, // informational messages
            Debug, // debug-level messages
        }
        
        /// <summary>
        /// Conversion of SecurityEventSeverityfrom and into string
        /// <summary>
        public static class SecurityEventSeverityHandling
        {
            public static bool TryParse(string value, out SecurityEventSeverity result)
            {
                result = default(SecurityEventSeverity);
                
                if( value=="Emergency")
                    result = SecurityEventSeverity.Emergency;
                else if( value=="Alert")
                    result = SecurityEventSeverity.Alert;
                else if( value=="Critical")
                    result = SecurityEventSeverity.Critical;
                else if( value=="Error")
                    result = SecurityEventSeverity.Error;
                else if( value=="Warning")
                    result = SecurityEventSeverity.Warning;
                else if( value=="Notice")
                    result = SecurityEventSeverity.Notice;
                else if( value=="Informational")
                    result = SecurityEventSeverity.Informational;
                else if( value=="Debug")
                    result = SecurityEventSeverity.Debug;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventSeverity value)
            {
                if( value==SecurityEventSeverity.Emergency )
                    return "Emergency";
                else if( value==SecurityEventSeverity.Alert )
                    return "Alert";
                else if( value==SecurityEventSeverity.Critical )
                    return "Critical";
                else if( value==SecurityEventSeverity.Error )
                    return "Error";
                else if( value==SecurityEventSeverity.Warning )
                    return "Warning";
                else if( value==SecurityEventSeverity.Notice )
                    return "Notice";
                else if( value==SecurityEventSeverity.Informational )
                    return "Informational";
                else if( value==SecurityEventSeverity.Debug )
                    return "Debug";
                else
                    throw new ArgumentException("Unrecognized SecurityEventSeverity value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Indicator for type of action performed during the event that generated the audit.
        /// </summary>
        public enum SecurityEventEventAction
        {
            C, // Create
            R, // Read/View/Print/Query
            U, // Update
            D, // Delete
            E, // Execute
        }
        
        /// <summary>
        /// Conversion of SecurityEventEventActionfrom and into string
        /// <summary>
        public static class SecurityEventEventActionHandling
        {
            public static bool TryParse(string value, out SecurityEventEventAction result)
            {
                result = default(SecurityEventEventAction);
                
                if( value=="C")
                    result = SecurityEventEventAction.C;
                else if( value=="R")
                    result = SecurityEventEventAction.R;
                else if( value=="U")
                    result = SecurityEventEventAction.U;
                else if( value=="D")
                    result = SecurityEventEventAction.D;
                else if( value=="E")
                    result = SecurityEventEventAction.E;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(SecurityEventEventAction value)
            {
                if( value==SecurityEventEventAction.C )
                    return "C";
                else if( value==SecurityEventEventAction.R )
                    return "R";
                else if( value==SecurityEventEventAction.U )
                    return "U";
                else if( value==SecurityEventEventAction.D )
                    return "D";
                else if( value==SecurityEventEventAction.E )
                    return "E";
                else
                    throw new ArgumentException("Unrecognized SecurityEventEventAction value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SecurityEventObjectComponent")]
        public partial class SecurityEventObjectComponent : Element
        {
            /// <summary>
            /// Object type being audited
            /// </summary>
            public Code<SecurityEvent.SecurityEventObjectType> Type { get; set; }
            
            /// <summary>
            /// Functional application role of Object
            /// </summary>
            public Code<SecurityEvent.SecurityEventObjectRole> Role { get; set; }
            
            /// <summary>
            /// Life-cycle stage for the object
            /// </summary>
            public Code<SecurityEvent.SecurityEventObjectLifecycle> Lifecycle { get; set; }
            
            /// <summary>
            /// Describes the identifier
            /// </summary>
            public Coding IdType { get; set; }
            
            /// <summary>
            /// Identifies a specific instance of object
            /// </summary>
            public FhirString Id { get; set; }
            
            /// <summary>
            /// Policy-defined sensitivity for the object
            /// </summary>
            public FhirString Sensitivity { get; set; }
            
            /// <summary>
            /// Instance-specific descriptor for Object
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Actual query for object
            /// </summary>
            public Base64Binary Query { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SecurityEventSourceComponent")]
        public partial class SecurityEventSourceComponent : Element
        {
            /// <summary>
            /// Logical source location within the enterprise
            /// </summary>
            public FhirString Site { get; set; }
            
            /// <summary>
            /// The id of source where event originated
            /// </summary>
            public FhirString Id { get; set; }
            
            /// <summary>
            /// The type of source where event originated
            /// </summary>
            public List<Coding> Type { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SecurityEventEventComponent")]
        public partial class SecurityEventEventComponent : Element
        {
            /// <summary>
            /// Identifier for a specific audited event
            /// </summary>
            public Coding Id { get; set; }
            
            /// <summary>
            /// Type of action performed during the event
            /// </summary>
            public Code<SecurityEvent.SecurityEventEventAction> Action { get; set; }
            
            /// <summary>
            /// Time when the event occurred on source
            /// </summary>
            public Instant DateTime { get; set; }
            
            /// <summary>
            /// Whether the event succeeded or failed
            /// </summary>
            public Code<SecurityEvent.SecurityEventEventOutcome> Outcome { get; set; }
            
            /// <summary>
            /// Identifier for the category of event
            /// </summary>
            public List<Coding> Code { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SecurityEventParticipantNetworkComponent")]
        public partial class SecurityEventParticipantNetworkComponent : Element
        {
            /// <summary>
            /// The type of network access point
            /// </summary>
            public Code<SecurityEvent.SecurityEventParticipantNetworkType> Type { get; set; }
            
            /// <summary>
            /// Identifier for the network access point of the user device
            /// </summary>
            public FhirString Id { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SecurityEventParticipantComponent")]
        public partial class SecurityEventParticipantComponent : Element
        {
            /// <summary>
            /// Unique identifier for the user
            /// </summary>
            public FhirString UserId { get; set; }
            
            /// <summary>
            /// User identifier from authentication system
            /// </summary>
            public FhirString OtherUserId { get; set; }
            
            /// <summary>
            /// Human-meaningful name for the user
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Whether user is initiator
            /// </summary>
            public FhirBoolean Requestor { get; set; }
            
            /// <summary>
            /// Role(s) the user plays (from RBAC)
            /// </summary>
            public List<Coding> Role { get; set; }
            
            /// <summary>
            /// Used when the event is about exporting/importing onto media
            /// </summary>
            public CodeableConcept MediaId { get; set; }
            
            /// <summary>
            /// Logical network location for application activity
            /// </summary>
            public SecurityEventParticipantNetworkComponent Network { get; set; }
            
        }
        
        
        /// <summary>
        /// What was done
        /// </summary>
        public SecurityEventEventComponent Event { get; set; }
        
        /// <summary>
        /// A person, a hardware device or software process
        /// </summary>
        public List<SecurityEventParticipantComponent> Participant { get; set; }
        
        /// <summary>
        /// Application systems and processes
        /// </summary>
        public SecurityEventSourceComponent Source { get; set; }
        
        /// <summary>
        /// Specific instances of data or objects that have been accessed
        /// </summary>
        public List<SecurityEventObjectComponent> Object { get; set; }
        
    }
    
}
