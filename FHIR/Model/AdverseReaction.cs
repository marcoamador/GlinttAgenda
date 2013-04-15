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
    /// AdverseReaction
    /// </summary>
    [FhirResource("AdverseReaction")]
    public partial class AdverseReaction : Resource
    {
        /// <summary>
        /// The severity of an adverse reaction.
        /// </summary>
        public enum ReactionSeverity
        {
            Severe, // Severe complications arose due to the reaction
            Serious, // Serious inconvience to the subject
            Moderate, // Moderate inconvience to the subject
            Minor, // Minor inconvience to the subject
        }
        
        /// <summary>
        /// Conversion of ReactionSeverityfrom and into string
        /// <summary>
        public static class ReactionSeverityHandling
        {
            public static bool TryParse(string value, out ReactionSeverity result)
            {
                result = default(ReactionSeverity);
                
                if( value=="severe")
                    result = ReactionSeverity.Severe;
                else if( value=="serious")
                    result = ReactionSeverity.Serious;
                else if( value=="moderate")
                    result = ReactionSeverity.Moderate;
                else if( value=="minor")
                    result = ReactionSeverity.Minor;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ReactionSeverity value)
            {
                if( value==ReactionSeverity.Severe )
                    return "severe";
                else if( value==ReactionSeverity.Serious )
                    return "serious";
                else if( value==ReactionSeverity.Moderate )
                    return "moderate";
                else if( value==ReactionSeverity.Minor )
                    return "minor";
                else
                    throw new ArgumentException("Unrecognized ReactionSeverity value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The type of exposure that resulted in an adverse reaction
        /// </summary>
        public enum ExposureType
        {
            Drugadmin, // Drug Administration
            Immuniz, // Immunization
            Coincidental, // In the same area as the substance
        }
        
        /// <summary>
        /// Conversion of ExposureTypefrom and into string
        /// <summary>
        public static class ExposureTypeHandling
        {
            public static bool TryParse(string value, out ExposureType result)
            {
                result = default(ExposureType);
                
                if( value=="drugadmin")
                    result = ExposureType.Drugadmin;
                else if( value=="immuniz")
                    result = ExposureType.Immuniz;
                else if( value=="coincidental")
                    result = ExposureType.Coincidental;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ExposureType value)
            {
                if( value==ExposureType.Drugadmin )
                    return "drugadmin";
                else if( value==ExposureType.Immuniz )
                    return "immuniz";
                else if( value==ExposureType.Coincidental )
                    return "coincidental";
                else
                    throw new ArgumentException("Unrecognized ExposureType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("AdverseReactionSymptomComponent")]
        public partial class AdverseReactionSymptomComponent : Element
        {
            /// <summary>
            /// Indicates the specific sign or symptom that was observed
            /// </summary>
            public CodeableConcept Code { get; set; }
            
            /// <summary>
            /// The severity of the sign or symptom
            /// </summary>
            public Code<AdverseReaction.ReactionSeverity> Severity { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("AdverseReactionExposureComponent")]
        public partial class AdverseReactionExposureComponent : Element
        {
            /// <summary>
            /// When the exposure occurred
            /// </summary>
            public FhirDateTime ExposureDate { get; set; }
            
            /// <summary>
            /// The type of exposure
            /// </summary>
            public Code<AdverseReaction.ExposureType> ExposureType { get; set; }
            
            /// <summary>
            /// Substance that subject was exposed to
            /// </summary>
            public ResourceReference Substance { get; set; }
            
        }
        
        
        /// <summary>
        /// When the reaction occurred
        /// </summary>
        public FhirDateTime ReactionDate { get; set; }
        
        /// <summary>
        /// The subject of the adverse reaction
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Substance presumed to have caused reaction
        /// </summary>
        public ResourceReference Substance { get; set; }
        
        /// <summary>
        /// To say that a reaction to substance did not occur
        /// </summary>
        public FhirBoolean DidNotOccurFlag { get; set; }
        
        /// <summary>
        /// Who recorded the reaction
        /// </summary>
        public ResourceReference Recorder { get; set; }
        
        /// <summary>
        /// The signs and symptoms that were observed as part of the reaction
        /// </summary>
        public List<AdverseReactionSymptomComponent> Symptom { get; set; }
        
        /// <summary>
        /// An exposure to a substance that preceded a reaction occurrence
        /// </summary>
        public List<AdverseReactionExposureComponent> Exposure { get; set; }
        
    }
    
}
