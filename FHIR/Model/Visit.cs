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
    /// An interaction during which services are provided to the patient
    /// </summary>
    [FhirResource("Visit")]
    public partial class Visit : Resource
    {
        /// <summary>
        /// Setting the visit takes place in
        /// </summary>
        public enum VisitSetting
        {
            Inpatient,
            Ambulatory,
            Home,
            Field,
            Emergency,
            Virtual,
            Office,
            Nursing,
        }
        
        /// <summary>
        /// Conversion of VisitSettingfrom and into string
        /// <summary>
        public static class VisitSettingHandling
        {
            public static bool TryParse(string value, out VisitSetting result)
            {
                result = default(VisitSetting);
                
                if( value=="inpatient")
                    result = VisitSetting.Inpatient;
                else if( value=="ambulatory")
                    result = VisitSetting.Ambulatory;
                else if( value=="home")
                    result = VisitSetting.Home;
                else if( value=="field")
                    result = VisitSetting.Field;
                else if( value=="emergency")
                    result = VisitSetting.Emergency;
                else if( value=="virtual")
                    result = VisitSetting.Virtual;
                else if( value=="office")
                    result = VisitSetting.Office;
                else if( value=="nursing")
                    result = VisitSetting.Nursing;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(VisitSetting value)
            {
                if( value==VisitSetting.Inpatient )
                    return "inpatient";
                else if( value==VisitSetting.Ambulatory )
                    return "ambulatory";
                else if( value==VisitSetting.Home )
                    return "home";
                else if( value==VisitSetting.Field )
                    return "field";
                else if( value==VisitSetting.Emergency )
                    return "emergency";
                else if( value==VisitSetting.Virtual )
                    return "virtual";
                else if( value==VisitSetting.Office )
                    return "office";
                else if( value==VisitSetting.Nursing )
                    return "nursing";
                else
                    throw new ArgumentException("Unrecognized VisitSetting value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Current state of the visit
        /// </summary>
        public enum VisitState
        {
            Current, // The patient is present, service is being delivered
            Aborted, // The visit was aborted after its start
            Completed, // The visit has finished
        }
        
        /// <summary>
        /// Conversion of VisitStatefrom and into string
        /// <summary>
        public static class VisitStateHandling
        {
            public static bool TryParse(string value, out VisitState result)
            {
                result = default(VisitState);
                
                if( value=="current")
                    result = VisitState.Current;
                else if( value=="aborted")
                    result = VisitState.Aborted;
                else if( value=="completed")
                    result = VisitState.Completed;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(VisitState value)
            {
                if( value==VisitState.Current )
                    return "current";
                else if( value==VisitState.Aborted )
                    return "aborted";
                else if( value==VisitState.Completed )
                    return "completed";
                else
                    throw new ArgumentException("Unrecognized VisitState value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("VisitDischargeComponent")]
        public partial class VisitDischargeComponent : Element
        {
            /// <summary>
            /// Practitioner responsible for the patient during the discharge
            /// </summary>
            public ResourceReference Discharger { get; set; }
            
            /// <summary>
            /// Contact person to inform about the discharge
            /// </summary>
            public ResourceReference Contact { get; set; }
            
            /// <summary>
            /// Location the patient is discharged to
            /// </summary>
            public ResourceReference Destination { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("VisitLocationComponent")]
        public partial class VisitLocationComponent : Element
        {
            /// <summary>
            /// The location the visit takes place
            /// </summary>
            public ResourceReference Location { get; set; }
            
            /// <summary>
            /// Name of the bed the patient stays in
            /// </summary>
            public Element Bed { get; set; }
            
            /// <summary>
            /// Time period during which the patient was present at the location
            /// </summary>
            public FhirDateTime Period { get; set; }
            
            /// <summary>
            /// Practitioner responsible for the patient during his stay at this location
            /// </summary>
            public ResourceReference Responsible { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("VisitAdmissionComponent")]
        public partial class VisitAdmissionComponent : Element
        {
            /// <summary>
            /// The practitioner responsible for admission
            /// </summary>
            public ResourceReference Admitter { get; set; }
            
            /// <summary>
            /// The location the patient came from before admission
            /// </summary>
            public ResourceReference Origin { get; set; }
            
        }
        
        
        /// <summary>
        /// Identifier(s) by which this visit is known
        /// </summary>
        public List<Identifier> Identifier { get; set; }
        
        /// <summary>
        /// E.g. active, aborted, finished
        /// </summary>
        public CodeableConcept State { get; set; }
        
        /// <summary>
        /// Kind of environment the visit takes place in
        /// </summary>
        public CodeableConcept Setting { get; set; }
        
        /// <summary>
        /// The patient present at the visit
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// The main practitioner responsible for providing the service
        /// </summary>
        public ResourceReference Responsible { get; set; }
        
        /// <summary>
        /// The appointment that scheduled this visit
        /// </summary>
        public ResourceReference Fulfills { get; set; }
        
        /// <summary>
        /// Period during which the visit lasted
        /// </summary>
        public Period Period { get; set; }
        
        /// <summary>
        /// Quantity of time the visit lasted
        /// </summary>
        public Duration Length { get; set; }
        
        /// <summary>
        /// Emergency contact during the visit
        /// </summary>
        public ResourceReference Contact { get; set; }
        
        /// <summary>
        /// Details about an admission to a clinic
        /// </summary>
        public VisitAdmissionComponent Admission { get; set; }
        
        /// <summary>
        /// Reason the visit takes place
        /// </summary>
        public ResourceReference Indication { get; set; }
        
        /// <summary>
        /// List of locations the patient has been at
        /// </summary>
        public List<VisitLocationComponent> Location { get; set; }
        
        /// <summary>
        /// Details about a discharge from a clinic
        /// </summary>
        public VisitDischargeComponent Discharge { get; set; }
        
    }
    
}
