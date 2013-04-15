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
    /// Simple observations
    /// </summary>
    [FhirResource("Observation")]
    public partial class Observation : Resource
    {
        /// <summary>
        /// Codes that provide reliability information about an observation
        /// </summary>
        public enum ObservationReliability
        {
            Ok, // The result has no reliability concerns
            Ongoing, // An early estimate of value; measurement is still occurring
            Early, // An early estimate of value; processing is still occurring
            Questionable, // The observation value should be treated with care
            Calibrating, // The result has been generated while calibration is occurring
            Error, // The observation could not be completed because of an error
            Unknown, // No observation value was available
        }
        
        /// <summary>
        /// Conversion of ObservationReliabilityfrom and into string
        /// <summary>
        public static class ObservationReliabilityHandling
        {
            public static bool TryParse(string value, out ObservationReliability result)
            {
                result = default(ObservationReliability);
                
                if( value=="ok")
                    result = ObservationReliability.Ok;
                else if( value=="ongoing")
                    result = ObservationReliability.Ongoing;
                else if( value=="early")
                    result = ObservationReliability.Early;
                else if( value=="questionable")
                    result = ObservationReliability.Questionable;
                else if( value=="calibrating")
                    result = ObservationReliability.Calibrating;
                else if( value=="error")
                    result = ObservationReliability.Error;
                else if( value=="unknown")
                    result = ObservationReliability.Unknown;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ObservationReliability value)
            {
                if( value==ObservationReliability.Ok )
                    return "ok";
                else if( value==ObservationReliability.Ongoing )
                    return "ongoing";
                else if( value==ObservationReliability.Early )
                    return "early";
                else if( value==ObservationReliability.Questionable )
                    return "questionable";
                else if( value==ObservationReliability.Calibrating )
                    return "calibrating";
                else if( value==ObservationReliability.Error )
                    return "error";
                else if( value==ObservationReliability.Unknown )
                    return "unknown";
                else
                    throw new ArgumentException("Unrecognized ObservationReliability value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Codes identifying interpretations of observations
        /// </summary>
        public enum ObservationInterpretation
        {
            N, // Normal
            A, // Abnormal
            L, // Low
            H, // High
        }
        
        /// <summary>
        /// Conversion of ObservationInterpretationfrom and into string
        /// <summary>
        public static class ObservationInterpretationHandling
        {
            public static bool TryParse(string value, out ObservationInterpretation result)
            {
                result = default(ObservationInterpretation);
                
                if( value=="N")
                    result = ObservationInterpretation.N;
                else if( value=="A")
                    result = ObservationInterpretation.A;
                else if( value=="L")
                    result = ObservationInterpretation.L;
                else if( value=="H")
                    result = ObservationInterpretation.H;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ObservationInterpretation value)
            {
                if( value==ObservationInterpretation.N )
                    return "N";
                else if( value==ObservationInterpretation.A )
                    return "A";
                else if( value==ObservationInterpretation.L )
                    return "L";
                else if( value==ObservationInterpretation.H )
                    return "H";
                else
                    throw new ArgumentException("Unrecognized ObservationInterpretation value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ObservationComponentComponent")]
        public partial class ObservationComponentComponent : Element
        {
            /// <summary>
            /// Kind of component observation
            /// </summary>
            public CodeableConcept Name { get; set; }
            
            /// <summary>
            /// Actual component result
            /// </summary>
            public Element Value { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ObservationReferenceRangeComponent")]
        public partial class ObservationReferenceRangeComponent : Element
        {
            /// <summary>
            /// The meaning of this range
            /// </summary>
            public CodeableConcept Meaning { get; set; }
            
            /// <summary>
            /// Reference
            /// </summary>
            public Element Range { get; set; }
            
        }
        
        
        /// <summary>
        /// Kind of observation
        /// </summary>
        public CodeableConcept Name { get; set; }
        
        /// <summary>
        /// Actual result
        /// </summary>
        public Element Value { get; set; }
        
        /// <summary>
        /// High, low, normal, etc.
        /// </summary>
        public CodeableConcept Interpretation { get; set; }
        
        /// <summary>
        /// Comments about result
        /// </summary>
        public FhirString Comments { get; set; }
        
        /// <summary>
        /// Relevant time/time-period
        /// </summary>
        public Element Applies { get; set; }
        
        /// <summary>
        /// Date/Time this was made available
        /// </summary>
        public Instant Issued { get; set; }
        
        /// <summary>
        /// Registered|Interim|Final|Amended|Cancelled|Withdrawn
        /// </summary>
        public Code<ObservationStatus> Status { get; set; }
        
        /// <summary>
        /// If quality issues exist (mostly devices)
        /// </summary>
        public Code<Observation.ObservationReliability> Reliability { get; set; }
        
        /// <summary>
        /// Observed body part
        /// </summary>
        public CodeableConcept BodySite { get; set; }
        
        /// <summary>
        /// How it was done
        /// </summary>
        public CodeableConcept Method { get; set; }
        
        /// <summary>
        /// Observation id
        /// </summary>
        public Identifier Identifier { get; set; }
        
        /// <summary>
        /// Who/what this is about
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Who did the observation
        /// </summary>
        public ResourceReference Performer { get; set; }
        
        /// <summary>
        /// Provides guide for interpretation
        /// </summary>
        public List<ObservationReferenceRangeComponent> ReferenceRange { get; set; }
        
        /// <summary>
        /// Component observation
        /// </summary>
        public List<ObservationComponentComponent> Component { get; set; }
        
    }
    
}
