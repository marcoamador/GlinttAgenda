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
    /// Administration of medication to a patient
    /// </summary>
    [FhirResource("MedicationAdministration")]
    public partial class MedicationAdministration : Resource
    {
        /// <summary>
        /// A set of codes indicating the current status of a MedicationAdministration
        /// </summary>
        public enum MedicationAdministrationStatus
        {
            Active, // The administration of the medication has started and is currently in progress.
            Paused, // The administration of the medication has started but is currently stopped with a firm intention of restarting.
            Completed, // The administration of the medication has finished
            Nullified, // The administration of the medication was recorded in error and the record should now be disregarded.
        }
        
        /// <summary>
        /// Conversion of MedicationAdministrationStatusfrom and into string
        /// <summary>
        public static class MedicationAdministrationStatusHandling
        {
            public static bool TryParse(string value, out MedicationAdministrationStatus result)
            {
                result = default(MedicationAdministrationStatus);
                
                if( value=="active")
                    result = MedicationAdministrationStatus.Active;
                else if( value=="paused")
                    result = MedicationAdministrationStatus.Paused;
                else if( value=="completed")
                    result = MedicationAdministrationStatus.Completed;
                else if( value=="nullified")
                    result = MedicationAdministrationStatus.Nullified;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(MedicationAdministrationStatus value)
            {
                if( value==MedicationAdministrationStatus.Active )
                    return "active";
                else if( value==MedicationAdministrationStatus.Paused )
                    return "paused";
                else if( value==MedicationAdministrationStatus.Completed )
                    return "completed";
                else if( value==MedicationAdministrationStatus.Nullified )
                    return "nullified";
                else
                    throw new ArgumentException("Unrecognized MedicationAdministrationStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Administration event status
        /// </summary>
        public Code<MedicationAdministration.MedicationAdministrationStatus> AdministrationEventStatus { get; set; }
        
        /// <summary>
        /// Is event negated
        /// </summary>
        public FhirBoolean IsNegated { get; set; }
        
        /// <summary>
        /// Reason event is negated
        /// </summary>
        public List<CodeableConcept> NegatedReason { get; set; }
        
        /// <summary>
        /// Effective time
        /// </summary>
        public Period EffectiveTime { get; set; }
        
        /// <summary>
        /// Administration method
        /// </summary>
        public CodeableConcept Method { get; set; }
        
        /// <summary>
        /// Approach site
        /// </summary>
        public CodeableConcept ApproachSite { get; set; }
        
        /// <summary>
        /// Route of administration
        /// </summary>
        public CodeableConcept Route { get; set; }
        
        /// <summary>
        /// Administered dose
        /// </summary>
        public Quantity AdministeredDose { get; set; }
        
        /// <summary>
        /// Dose rate
        /// </summary>
        public Quantity DoseRate { get; set; }
        
        /// <summary>
        /// External Identifier
        /// </summary>
        public List<Identifier> Id { get; set; }
        
        /// <summary>
        /// Prescription
        /// </summary>
        public ResourceReference Prescription { get; set; }
        
        /// <summary>
        /// Patient
        /// </summary>
        public ResourceReference Patient { get; set; }
        
        /// <summary>
        /// Medication
        /// </summary>
        public List<CodeableConcept> Medication { get; set; }
        
        /// <summary>
        /// Encounter
        /// </summary>
        public Identifier Encounter { get; set; }
        
        /// <summary>
        /// Administration device
        /// </summary>
        public List<ResourceReference> AdministrationDevice { get; set; }
        
    }
    
}
