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
    /// Healthcare plan for patient
    /// </summary>
    [FhirResource("CarePlan")]
    public partial class CarePlan : Resource
    {
        /// <summary>
        /// Indicates whether the plan is currently being acted upon, represents future intentions or is now just historical record.
        /// </summary>
        public enum CarePlanStatus
        {
            Planned, // The plan is in development or awaiting use but is not yet intended to be acted upon.
            Active, // The plan is intended to be followed and used as part of patient care
            Ended, // The plan is no longer in use and is not expected to be followed or used in patient care
        }
        
        /// <summary>
        /// Conversion of CarePlanStatusfrom and into string
        /// <summary>
        public static class CarePlanStatusHandling
        {
            public static bool TryParse(string value, out CarePlanStatus result)
            {
                result = default(CarePlanStatus);
                
                if( value=="planned")
                    result = CarePlanStatus.Planned;
                else if( value=="active")
                    result = CarePlanStatus.Active;
                else if( value=="ended")
                    result = CarePlanStatus.Ended;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(CarePlanStatus value)
            {
                if( value==CarePlanStatus.Planned )
                    return "planned";
                else if( value==CarePlanStatus.Active )
                    return "active";
                else if( value==CarePlanStatus.Ended )
                    return "ended";
                else
                    throw new ArgumentException("Unrecognized CarePlanStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// High-level categorization of the type of activity in a care plan.
        /// </summary>
        public enum CarePlanActivityCategory
        {
            Diet, // Plan for the patient to consume food of a specified nature
            Drug, // Plan for the patient to consume/receive a drug, vaccine or other product
            Visit, // Plan to meet or communicate with the patient (in-patient, out-patient, phone call, etc.)
            Observation, // Plan to capture information about a patient (vitals, labs, diagnostic images, etc.)
            Procedure, // Plan to modify the patient in some way (surgery, physio-therapy, education, counselling, etc.)
            Supply, // Plan to provide something to the patient (medication, medical supply, etc.)
            Other, // Some other form of action
        }
        
        /// <summary>
        /// Conversion of CarePlanActivityCategoryfrom and into string
        /// <summary>
        public static class CarePlanActivityCategoryHandling
        {
            public static bool TryParse(string value, out CarePlanActivityCategory result)
            {
                result = default(CarePlanActivityCategory);
                
                if( value=="diet")
                    result = CarePlanActivityCategory.Diet;
                else if( value=="drug")
                    result = CarePlanActivityCategory.Drug;
                else if( value=="visit")
                    result = CarePlanActivityCategory.Visit;
                else if( value=="observation")
                    result = CarePlanActivityCategory.Observation;
                else if( value=="procedure")
                    result = CarePlanActivityCategory.Procedure;
                else if( value=="supply")
                    result = CarePlanActivityCategory.Supply;
                else if( value=="other")
                    result = CarePlanActivityCategory.Other;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(CarePlanActivityCategory value)
            {
                if( value==CarePlanActivityCategory.Diet )
                    return "diet";
                else if( value==CarePlanActivityCategory.Drug )
                    return "drug";
                else if( value==CarePlanActivityCategory.Visit )
                    return "visit";
                else if( value==CarePlanActivityCategory.Observation )
                    return "observation";
                else if( value==CarePlanActivityCategory.Procedure )
                    return "procedure";
                else if( value==CarePlanActivityCategory.Supply )
                    return "supply";
                else if( value==CarePlanActivityCategory.Other )
                    return "other";
                else
                    throw new ArgumentException("Unrecognized CarePlanActivityCategory value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Indicates whether the goal has been met and is still being targeted
        /// </summary>
        public enum CarePlanGoalStatus
        {
            InProgress, // The goal is being sought but has not yet been reached.  (Also applies if goal was reached in the past but there has been regression and goal is being sought again)
            Achieved, // The goal has been met and no further action is needed
            Sustaining, // The goal has been met, but ongoing activity is needed to sustain the goal objective
            Abandoned, // The goal is no longer being sought
        }
        
        /// <summary>
        /// Conversion of CarePlanGoalStatusfrom and into string
        /// <summary>
        public static class CarePlanGoalStatusHandling
        {
            public static bool TryParse(string value, out CarePlanGoalStatus result)
            {
                result = default(CarePlanGoalStatus);
                
                if( value=="in progress")
                    result = CarePlanGoalStatus.InProgress;
                else if( value=="achieved")
                    result = CarePlanGoalStatus.Achieved;
                else if( value=="sustaining")
                    result = CarePlanGoalStatus.Sustaining;
                else if( value=="abandoned")
                    result = CarePlanGoalStatus.Abandoned;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(CarePlanGoalStatus value)
            {
                if( value==CarePlanGoalStatus.InProgress )
                    return "in progress";
                else if( value==CarePlanGoalStatus.Achieved )
                    return "achieved";
                else if( value==CarePlanGoalStatus.Sustaining )
                    return "sustaining";
                else if( value==CarePlanGoalStatus.Abandoned )
                    return "abandoned";
                else
                    throw new ArgumentException("Unrecognized CarePlanGoalStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Indicates where the activity is at in its overall life cycle
        /// </summary>
        public enum CarePlanActivityStatus
        {
            NotStarted, // Activity is planned but no action has yet been taken
            Scheduled, // Appointment or other booking has occurred but activity has not yet begun
            Ongoing, // Activity has been started but is not yet complete
            OnHold, // Activity was started but has temporarily ceased with an expectation of resumption at a future time.
            Completed, // The activities have been completed (more or less) as planned
            Discontinued, // The activities have been ended prior to completion (perhaps even before they were started)
        }
        
        /// <summary>
        /// Conversion of CarePlanActivityStatusfrom and into string
        /// <summary>
        public static class CarePlanActivityStatusHandling
        {
            public static bool TryParse(string value, out CarePlanActivityStatus result)
            {
                result = default(CarePlanActivityStatus);
                
                if( value=="not started")
                    result = CarePlanActivityStatus.NotStarted;
                else if( value=="scheduled")
                    result = CarePlanActivityStatus.Scheduled;
                else if( value=="ongoing")
                    result = CarePlanActivityStatus.Ongoing;
                else if( value=="on hold")
                    result = CarePlanActivityStatus.OnHold;
                else if( value=="completed")
                    result = CarePlanActivityStatus.Completed;
                else if( value=="discontinued")
                    result = CarePlanActivityStatus.Discontinued;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(CarePlanActivityStatus value)
            {
                if( value==CarePlanActivityStatus.NotStarted )
                    return "not started";
                else if( value==CarePlanActivityStatus.Scheduled )
                    return "scheduled";
                else if( value==CarePlanActivityStatus.Ongoing )
                    return "ongoing";
                else if( value==CarePlanActivityStatus.OnHold )
                    return "on hold";
                else if( value==CarePlanActivityStatus.Completed )
                    return "completed";
                else if( value==CarePlanActivityStatus.Discontinued )
                    return "discontinued";
                else
                    throw new ArgumentException("Unrecognized CarePlanActivityStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("CarePlanGoalComponent")]
        public partial class CarePlanGoalComponent : Element
        {
            /// <summary>
            /// What's the desired outcome?
            /// </summary>
            public FhirString Description { get; set; }
            
            /// <summary>
            /// in progress|achieved|sustaining | abandoned
            /// </summary>
            public Code<CarePlan.CarePlanGoalStatus> Status { get; set; }
            
            /// <summary>
            /// Comments about the goal
            /// </summary>
            public FhirString Notes { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("CarePlanParticipantComponent")]
        public partial class CarePlanParticipantComponent : Element
        {
            /// <summary>
            /// Type of involvement
            /// </summary>
            public CodeableConcept Role { get; set; }
            
            /// <summary>
            /// Who is involved
            /// </summary>
            public ResourceReference Member { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("CarePlanActivityComponent")]
        public partial class CarePlanActivityComponent : Element
        {
            /// <summary>
            /// visit | procedure | observation | +
            /// </summary>
            public Code<CarePlan.CarePlanActivityCategory> Category { get; set; }
            
            /// <summary>
            /// Detail type of activity
            /// </summary>
            public CodeableConcept Code { get; set; }
            
            /// <summary>
            /// not started | ongoing | suspended | completed | abandoned
            /// </summary>
            public Code<CarePlan.CarePlanActivityStatus> Status { get; set; }
            
            /// <summary>
            /// Do NOT do
            /// </summary>
            public FhirBoolean Prohibited { get; set; }
            
            /// <summary>
            /// When activity is to occur
            /// </summary>
            public Element Timing { get; set; }
            
            /// <summary>
            /// Where it should happen
            /// </summary>
            public ResourceReference Location { get; set; }
            
            /// <summary>
            /// Who's responsible?
            /// </summary>
            public List<ResourceReference> Performer { get; set; }
            
            /// <summary>
            /// What's administered/supplied
            /// </summary>
            public ResourceReference Product { get; set; }
            
            /// <summary>
            /// How much consumed/day?
            /// </summary>
            public Quantity DailyAmount { get; set; }
            
            /// <summary>
            /// How much is administered/supplied/consumed
            /// </summary>
            public Quantity Quantity { get; set; }
            
            /// <summary>
            /// Extra info on activity occurrence
            /// </summary>
            public FhirString Details { get; set; }
            
            /// <summary>
            /// Appointments, orders, etc.
            /// </summary>
            public List<ResourceReference> ActionTaken { get; set; }
            
            /// <summary>
            /// Comments about the activity
            /// </summary>
            public FhirString Notes { get; set; }
            
        }
        
        
        /// <summary>
        /// ID for plan
        /// </summary>
        public Identifier Identifier { get; set; }
        
        /// <summary>
        /// Who care plan is for
        /// </summary>
        public ResourceReference Patient { get; set; }
        
        /// <summary>
        /// planned | active | ended
        /// </summary>
        public Code<CarePlan.CarePlanStatus> Status { get; set; }
        
        /// <summary>
        /// Time period plan covers
        /// </summary>
        public Period Period { get; set; }
        
        /// <summary>
        /// When last updated
        /// </summary>
        public FhirDateTime Modified { get; set; }
        
        /// <summary>
        /// Health issues plan addresses
        /// </summary>
        public List<ResourceReference> Concern { get; set; }
        
        /// <summary>
        /// Who's involved in plan?
        /// </summary>
        public List<CarePlanParticipantComponent> Participant { get; set; }
        
        /// <summary>
        /// Desired outcome of plan
        /// </summary>
        public List<CarePlanGoalComponent> Goal { get; set; }
        
        /// <summary>
        /// Action to occur as part of plan
        /// </summary>
        public List<CarePlanActivityComponent> Activity { get; set; }
        
        /// <summary>
        /// Comments about the plan
        /// </summary>
        public FhirString Notes { get; set; }
        
    }
    
}
