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
// Generated on Thu, Apr 11, 2013 13:03+1000 for FHIR v0.08
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Research study
    /// </summary>
    [FhirResource("Study")]
    public partial class Study : Resource
    {
        /// <summary>
        /// The type of information about a drug therapy expected to be gleaned from a study.
        /// </summary>
        public enum StudyTrialType
        {
            Safety,
            Efficacy,
            BioEquivalence,
            BioAvailability,
            Pharmacokinetics,
            Pharmacodynamics,
        }
        
        /// <summary>
        /// Conversion of StudyTrialTypefrom and into string
        /// <summary>
        public static class StudyTrialTypeHandling
        {
            public static bool TryParse(string value, out StudyTrialType result)
            {
                result = default(StudyTrialType);
                
                if( value=="safety")
                    result = StudyTrialType.Safety;
                else if( value=="efficacy")
                    result = StudyTrialType.Efficacy;
                else if( value=="bio-equivalence")
                    result = StudyTrialType.BioEquivalence;
                else if( value=="bio-availability")
                    result = StudyTrialType.BioAvailability;
                else if( value=="pharmacokinetics")
                    result = StudyTrialType.Pharmacokinetics;
                else if( value=="pharmacodynamics")
                    result = StudyTrialType.Pharmacodynamics;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyTrialType value)
            {
                if( value==StudyTrialType.Safety )
                    return "safety";
                else if( value==StudyTrialType.Efficacy )
                    return "efficacy";
                else if( value==StudyTrialType.BioEquivalence )
                    return "bio-equivalence";
                else if( value==StudyTrialType.BioAvailability )
                    return "bio-availability";
                else if( value==StudyTrialType.Pharmacokinetics )
                    return "pharmacokinetics";
                else if( value==StudyTrialType.Pharmacodynamics )
                    return "pharmacodynamics";
                else
                    throw new ArgumentException("Unrecognized StudyTrialType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The broad type of activity to be performed
        /// </summary>
        public enum StudyActivityCategory
        {
            Diet, // Plan for the patient to consume food of a specified nature
            Drug, // Plan for the patient to consume/receive a drug, vaccine or other product
            Encounter, // Plan to meet or communicate with the patient (in-patient, out-patient, phone call, etc.)
            Observation, // Plan to capture information about a patient (vitals, labs, diagnostic images, etc.)
            Procedure, // Plan to modify the patient in some way (surgery, physio-therapy, education, counselling, etc.)
            Supply, // Plan to provide something to the patient (medication, medical supply, etc.)
            Other, // Some other form of action
        }
        
        /// <summary>
        /// Conversion of StudyActivityCategoryfrom and into string
        /// <summary>
        public static class StudyActivityCategoryHandling
        {
            public static bool TryParse(string value, out StudyActivityCategory result)
            {
                result = default(StudyActivityCategory);
                
                if( value=="diet")
                    result = StudyActivityCategory.Diet;
                else if( value=="drug")
                    result = StudyActivityCategory.Drug;
                else if( value=="encounter")
                    result = StudyActivityCategory.Encounter;
                else if( value=="observation")
                    result = StudyActivityCategory.Observation;
                else if( value=="procedure")
                    result = StudyActivityCategory.Procedure;
                else if( value=="supply")
                    result = StudyActivityCategory.Supply;
                else if( value=="other")
                    result = StudyActivityCategory.Other;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyActivityCategory value)
            {
                if( value==StudyActivityCategory.Diet )
                    return "diet";
                else if( value==StudyActivityCategory.Drug )
                    return "drug";
                else if( value==StudyActivityCategory.Encounter )
                    return "encounter";
                else if( value==StudyActivityCategory.Observation )
                    return "observation";
                else if( value==StudyActivityCategory.Procedure )
                    return "procedure";
                else if( value==StudyActivityCategory.Supply )
                    return "supply";
                else if( value==StudyActivityCategory.Other )
                    return "other";
                else
                    throw new ArgumentException("Unrecognized StudyActivityCategory value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Indicates whether the study observes or directs behavior of subjects
        /// </summary>
        public enum StudyType
        {
            Interventional,
            Observational,
            ExpandedAccess,
        }
        
        /// <summary>
        /// Conversion of StudyTypefrom and into string
        /// <summary>
        public static class StudyTypeHandling
        {
            public static bool TryParse(string value, out StudyType result)
            {
                result = default(StudyType);
                
                if( value=="interventional")
                    result = StudyType.Interventional;
                else if( value=="observational")
                    result = StudyType.Observational;
                else if( value=="expanded access")
                    result = StudyType.ExpandedAccess;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyType value)
            {
                if( value==StudyType.Interventional )
                    return "interventional";
                else if( value==StudyType.Observational )
                    return "observational";
                else if( value==StudyType.ExpandedAccess )
                    return "expanded access";
                else
                    throw new ArgumentException("Unrecognized StudyType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The type of health condition learning outcome intended to be gained from the study
        /// </summary>
        public enum StudyPurpose
        {
            Treatment,
            Prevention,
            Mitigation,
            Diagnosis,
            Cure,
            Screening,
            QualityOfLife,
        }
        
        /// <summary>
        /// Conversion of StudyPurposefrom and into string
        /// <summary>
        public static class StudyPurposeHandling
        {
            public static bool TryParse(string value, out StudyPurpose result)
            {
                result = default(StudyPurpose);
                
                if( value=="treatment")
                    result = StudyPurpose.Treatment;
                else if( value=="prevention")
                    result = StudyPurpose.Prevention;
                else if( value=="mitigation")
                    result = StudyPurpose.Mitigation;
                else if( value=="diagnosis")
                    result = StudyPurpose.Diagnosis;
                else if( value=="cure")
                    result = StudyPurpose.Cure;
                else if( value=="screening")
                    result = StudyPurpose.Screening;
                else if( value=="quality of life")
                    result = StudyPurpose.QualityOfLife;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyPurpose value)
            {
                if( value==StudyPurpose.Treatment )
                    return "treatment";
                else if( value==StudyPurpose.Prevention )
                    return "prevention";
                else if( value==StudyPurpose.Mitigation )
                    return "mitigation";
                else if( value==StudyPurpose.Diagnosis )
                    return "diagnosis";
                else if( value==StudyPurpose.Cure )
                    return "cure";
                else if( value==StudyPurpose.Screening )
                    return "screening";
                else if( value==StudyPurpose.QualityOfLife )
                    return "quality of life";
                else
                    throw new ArgumentException("Unrecognized StudyPurpose value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The stage of investigation associated with a drug trial
        /// </summary>
        public enum StudyPhase
        {
            I,
            II,
            III,
            IV,
        }
        
        /// <summary>
        /// Conversion of StudyPhasefrom and into string
        /// <summary>
        public static class StudyPhaseHandling
        {
            public static bool TryParse(string value, out StudyPhase result)
            {
                result = default(StudyPhase);
                
                if( value=="I")
                    result = StudyPhase.I;
                else if( value=="II")
                    result = StudyPhase.II;
                else if( value=="III")
                    result = StudyPhase.III;
                else if( value=="IV")
                    result = StudyPhase.IV;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyPhase value)
            {
                if( value==StudyPhase.I )
                    return "I";
                else if( value==StudyPhase.II )
                    return "II";
                else if( value==StudyPhase.III )
                    return "III";
                else if( value==StudyPhase.IV )
                    return "IV";
                else
                    throw new ArgumentException("Unrecognized StudyPhase value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The general design pattern for the study in terms of how interventions are experienced by the study subjects
        /// </summary>
        public enum StudyInterventionModel
        {
            CrossOver,
            Factorial,
            Parallel,
            SingleGroup,
        }
        
        /// <summary>
        /// Conversion of StudyInterventionModelfrom and into string
        /// <summary>
        public static class StudyInterventionModelHandling
        {
            public static bool TryParse(string value, out StudyInterventionModel result)
            {
                result = default(StudyInterventionModel);
                
                if( value=="cross-over")
                    result = StudyInterventionModel.CrossOver;
                else if( value=="factorial")
                    result = StudyInterventionModel.Factorial;
                else if( value=="parallel")
                    result = StudyInterventionModel.Parallel;
                else if( value=="single group")
                    result = StudyInterventionModel.SingleGroup;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyInterventionModel value)
            {
                if( value==StudyInterventionModel.CrossOver )
                    return "cross-over";
                else if( value==StudyInterventionModel.Factorial )
                    return "factorial";
                else if( value==StudyInterventionModel.Parallel )
                    return "parallel";
                else if( value==StudyInterventionModel.SingleGroup )
                    return "single group";
                else
                    throw new ArgumentException("Unrecognized StudyInterventionModel value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The type of control therapy used for comparison in the study
        /// </summary>
        public enum StudyControlType
        {
            Placebo,
            Active,
            Historical,
            Uncontrolled,
            DoseComparison,
        }
        
        /// <summary>
        /// Conversion of StudyControlTypefrom and into string
        /// <summary>
        public static class StudyControlTypeHandling
        {
            public static bool TryParse(string value, out StudyControlType result)
            {
                result = default(StudyControlType);
                
                if( value=="placebo")
                    result = StudyControlType.Placebo;
                else if( value=="active")
                    result = StudyControlType.Active;
                else if( value=="historical")
                    result = StudyControlType.Historical;
                else if( value=="uncontrolled")
                    result = StudyControlType.Uncontrolled;
                else if( value=="dose comparison")
                    result = StudyControlType.DoseComparison;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyControlType value)
            {
                if( value==StudyControlType.Placebo )
                    return "placebo";
                else if( value==StudyControlType.Active )
                    return "active";
                else if( value==StudyControlType.Historical )
                    return "historical";
                else if( value==StudyControlType.Uncontrolled )
                    return "uncontrolled";
                else if( value==StudyControlType.DoseComparison )
                    return "dose comparison";
                else
                    throw new ArgumentException("Unrecognized StudyControlType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The general category of intervention performed by the study
        /// </summary>
        public enum StudyInterventionType
        {
            DietarySupplement,
            BehavioralTherapy,
            Biologic,
            Device,
            Drug,
            Genetic,
            Other,
            Procedure,
            Radiation,
        }
        
        /// <summary>
        /// Conversion of StudyInterventionTypefrom and into string
        /// <summary>
        public static class StudyInterventionTypeHandling
        {
            public static bool TryParse(string value, out StudyInterventionType result)
            {
                result = default(StudyInterventionType);
                
                if( value=="dietary supplement")
                    result = StudyInterventionType.DietarySupplement;
                else if( value=="behavioral therapy")
                    result = StudyInterventionType.BehavioralTherapy;
                else if( value=="biologic")
                    result = StudyInterventionType.Biologic;
                else if( value=="device")
                    result = StudyInterventionType.Device;
                else if( value=="drug")
                    result = StudyInterventionType.Drug;
                else if( value=="genetic")
                    result = StudyInterventionType.Genetic;
                else if( value=="other")
                    result = StudyInterventionType.Other;
                else if( value=="procedure")
                    result = StudyInterventionType.Procedure;
                else if( value=="radiation")
                    result = StudyInterventionType.Radiation;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyInterventionType value)
            {
                if( value==StudyInterventionType.DietarySupplement )
                    return "dietary supplement";
                else if( value==StudyInterventionType.BehavioralTherapy )
                    return "behavioral therapy";
                else if( value==StudyInterventionType.Biologic )
                    return "biologic";
                else if( value==StudyInterventionType.Device )
                    return "device";
                else if( value==StudyInterventionType.Drug )
                    return "drug";
                else if( value==StudyInterventionType.Genetic )
                    return "genetic";
                else if( value==StudyInterventionType.Other )
                    return "other";
                else if( value==StudyInterventionType.Procedure )
                    return "procedure";
                else if( value==StudyInterventionType.Radiation )
                    return "radiation";
                else
                    throw new ArgumentException("Unrecognized StudyInterventionType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Additional information available to support the study
        /// </summary>
        public enum StudyResourceType
        {
            AnnotatedCRF,
            SupplementalDoc,
        }
        
        /// <summary>
        /// Conversion of StudyResourceTypefrom and into string
        /// <summary>
        public static class StudyResourceTypeHandling
        {
            public static bool TryParse(string value, out StudyResourceType result)
            {
                result = default(StudyResourceType);
                
                if( value=="annotatedCRF")
                    result = StudyResourceType.AnnotatedCRF;
                else if( value=="supplementalDoc")
                    result = StudyResourceType.SupplementalDoc;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyResourceType value)
            {
                if( value==StudyResourceType.AnnotatedCRF )
                    return "annotatedCRF";
                else if( value==StudyResourceType.SupplementalDoc )
                    return "supplementalDoc";
                else
                    throw new ArgumentException("Unrecognized StudyResourceType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The approach to blinding taken by the study
        /// </summary>
        public enum StudyBlindingScheme
        {
            OpenLabel,
            DoubleBlind,
            SingleBlind,
        }
        
        /// <summary>
        /// Conversion of StudyBlindingSchemefrom and into string
        /// <summary>
        public static class StudyBlindingSchemeHandling
        {
            public static bool TryParse(string value, out StudyBlindingScheme result)
            {
                result = default(StudyBlindingScheme);
                
                if( value=="open label")
                    result = StudyBlindingScheme.OpenLabel;
                else if( value=="double blind")
                    result = StudyBlindingScheme.DoubleBlind;
                else if( value=="single blind")
                    result = StudyBlindingScheme.SingleBlind;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(StudyBlindingScheme value)
            {
                if( value==StudyBlindingScheme.OpenLabel )
                    return "open label";
                else if( value==StudyBlindingScheme.DoubleBlind )
                    return "double blind";
                else if( value==StudyBlindingScheme.SingleBlind )
                    return "single blind";
                else
                    throw new ArgumentException("Unrecognized StudyBlindingScheme value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyTimepointPreconditionConditionComponent")]
        public partial class StudyTimepointPreconditionConditionComponent : Element
        {
            /// <summary>
            /// Observation / test / assertion
            /// </summary>
            public CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Value needed to satisfy condition
            /// </summary>
            public Element Value { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyResourceComponent")]
        public partial class StudyResourceComponent : Element
        {
            /// <summary>
            /// annotatedCRF | supplementalDoc
            /// </summary>
            public Code<Study.StudyResourceType> Type { get; set; }
            
            /// <summary>
            /// Related document or artifact
            /// </summary>
            public Attachment Content { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyEpochComponent")]
        public partial class StudyEpochComponent : Element
        {
            /// <summary>
            /// Label for epoch
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Description of epoch
            /// </summary>
            public FhirString Description { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyTimepointActivityComponent")]
        public partial class StudyTimepointActivityComponent : Element
        {
            /// <summary>
            /// What can be done instead?
            /// </summary>
            public List<IdRef> Alternative { get; set; }
            
            /// <summary>
            /// Activities that are part of this activity
            /// </summary>
            public List<StudyTimepointActivityComponentComponent> Component { get; set; }
            
            /// <summary>
            /// What happens next
            /// </summary>
            public List<IdRef> Following { get; set; }
            
            /// <summary>
            /// Pause before start
            /// </summary>
            public Duration Wait { get; set; }
            
            /// <summary>
            /// encounter | procedure | observation | +
            /// </summary>
            public Code<Study.StudyActivityCategory> Category { get; set; }
            
            /// <summary>
            /// Detail type of activity
            /// </summary>
            public CodeableConcept Code { get; set; }
            
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
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyTimepointPreconditionComponent")]
        public partial class StudyTimepointPreconditionComponent : Element
        {
            /// <summary>
            /// Description of condition
            /// </summary>
            public FhirString Description { get; set; }
            
            /// <summary>
            /// Condition evaluated
            /// </summary>
            public StudyTimepointPreconditionConditionComponent Condition { get; set; }
            
            /// <summary>
            /// And conditions
            /// </summary>
            public List<StudyTimepointPreconditionComponent> Intersection { get; set; }
            
            /// <summary>
            /// Or conditions
            /// </summary>
            public List<StudyTimepointPreconditionComponent> Union { get; set; }
            
            /// <summary>
            /// Not conditions
            /// </summary>
            public List<StudyTimepointPreconditionComponent> Exclude { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyAuthorSystemComponent")]
        public partial class StudyAuthorSystemComponent : Element
        {
            /// <summary>
            /// Name of software
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Version of software
            /// </summary>
            public FhirString Version { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyDataCutoffComponent")]
        public partial class StudyDataCutoffComponent : Element
        {
            /// <summary>
            /// Description of when data collection ended
            /// </summary>
            public FhirString Description { get; set; }
            
            /// <summary>
            /// Last date of study data
            /// </summary>
            public Date Date { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyTimepointActivityComponentComponent")]
        public partial class StudyTimepointActivityComponentComponent : Element
        {
            /// <summary>
            /// Order of occurrence
            /// </summary>
            public Integer Sequence { get; set; }
            
            /// <summary>
            /// Component activity
            /// </summary>
            public IdRef Activity { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyArmComponent")]
        public partial class StudyArmComponent : Element
        {
            /// <summary>
            /// Label for arm
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Description of arm
            /// </summary>
            public FhirString Description { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("StudyTimepointComponent")]
        public partial class StudyTimepointComponent : Element
        {
            /// <summary>
            /// Label for timepoint
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Human description of activity
            /// </summary>
            public FhirString Description { get; set; }
            
            /// <summary>
            /// Rules prior to execution
            /// </summary>
            public StudyTimepointPreconditionComponent Precondition { get; set; }
            
            /// <summary>
            /// Rules prior to completion
            /// </summary>
            public StudyTimepointPreconditionComponent Exit { get; set; }
            
            /// <summary>
            /// Part of what arm?
            /// </summary>
            public IdRef Arm { get; set; }
            
            /// <summary>
            /// Part of what epoch?
            /// </summary>
            public IdRef Epoch { get; set; }
            
            /// <summary>
            /// Order of occurrence within arm
            /// </summary>
            public Integer ArmSequence { get; set; }
            
            /// <summary>
            /// First activity within timepoint
            /// </summary>
            public List<IdRef> FirstActivity { get; set; }
            
            /// <summary>
            /// Activities that occur within timepoint
            /// </summary>
            public List<StudyTimepointActivityComponent> Activity { get; set; }
            
        }
        
        
        /// <summary>
        /// Date last changed
        /// </summary>
        public FhirDateTime LastModified { get; set; }
        
        /// <summary>
        /// Version number
        /// </summary>
        public FhirString VersionId { get; set; }
        
        /// <summary>
        /// What software produced?
        /// </summary>
        public StudyAuthorSystemComponent AuthorSystem { get; set; }
        
        /// <summary>
        /// Id for study
        /// </summary>
        public List<Identifier> Identifier { get; set; }
        
        /// <summary>
        /// Name of study
        /// </summary>
        public FhirString Title { get; set; }
        
        /// <summary>
        /// Description of study
        /// </summary>
        public FhirString Description { get; set; }
        
        /// <summary>
        /// What will study accomplish?
        /// </summary>
        public List<FhirString> Objective { get; set; }
        
        /// <summary>
        /// How will we know if it's accomplished?
        /// </summary>
        public List<FhirString> OutcomeMeasure { get; set; }
        
        /// <summary>
        /// Who's responsible?
        /// </summary>
        public FhirString Sponsor { get; set; }
        
        /// <summary>
        /// Intended # of subjects
        /// </summary>
        public Integer PlannedParticipants { get; set; }
        
        /// <summary>
        /// Eligibility criteria
        /// </summary>
        public List<ResourceReference> Group { get; set; }
        
        /// <summary>
        /// What will be studied?
        /// </summary>
        public List<ResourceReference> Focus { get; set; }
        
        /// <summary>
        /// Path through study
        /// </summary>
        public List<StudyArmComponent> Arm { get; set; }
        
        /// <summary>
        /// Major period in study
        /// </summary>
        public List<StudyEpochComponent> Epoch { get; set; }
        
        /// <summary>
        /// What's done during study?
        /// </summary>
        public List<StudyTimepointComponent> Timepoint { get; set; }
        
        /// <summary>
        /// Extra material related to study
        /// </summary>
        public List<StudyResourceComponent> Resource { get; set; }
        
        /// <summary>
        /// How long must disease be stable?
        /// </summary>
        public Duration StableDiseaseMinimumDuration { get; set; }
        
        /// <summary>
        /// How long is considered confirmed response?
        /// </summary>
        public Duration ConfirmedResponseDuration { get; set; }
        
        /// <summary>
        /// When will study begin
        /// </summary>
        public Date Start { get; set; }
        
        /// <summary>
        /// When will study end
        /// </summary>
        public Date End { get; set; }
        
        /// <summary>
        /// How long it will run
        /// </summary>
        public Duration Duration { get; set; }
        
        /// <summary>
        /// treatment | prevention | mitigation | diagnosis | cure | screening | quality of life
        /// </summary>
        public Code<Study.StudyPurpose> Purpose { get; set; }
        
        /// <summary>
        /// I | II | III | IV
        /// </summary>
        public Code<Study.StudyPhase> Phase { get; set; }
        
        /// <summary>
        /// interventional | observational | expanded access
        /// </summary>
        public Code<Study.StudyType> Type { get; set; }
        
        /// <summary>
        /// safety | efficacy | bio-equivalence | bio-availability | pharmacokinetics | pharmacodynamics
        /// </summary>
        public Code<Study.StudyTrialType> TrialType { get; set; }
        
        /// <summary>
        /// Are study participants randomly assigned?
        /// </summary>
        public FhirBoolean IsRandomized { get; set; }
        
        /// <summary>
        /// open label | double blind | single blind
        /// </summary>
        public Code<Study.StudyBlindingScheme> BlindingScheme { get; set; }
        
        /// <summary>
        /// placebo | active | historical | uncontrolled | dose comparison
        /// </summary>
        public Code<Study.StudyControlType> ControlType { get; set; }
        
        /// <summary>
        /// cross-over | factorial | parallel | single group
        /// </summary>
        public Code<Study.StudyInterventionModel> InterventionModel { get; set; }
        
        /// <summary>
        /// dietary supplement | behavioral therapy | biologic | device | drug | genetic | other | procedure | radiation
        /// </summary>
        public Code<Study.StudyInterventionType> InterventionType { get; set; }
        
        /// <summary>
        /// Can study add onto existing therapy?
        /// </summary>
        public FhirBoolean IsAddOn { get; set; }
        
        /// <summary>
        /// Will design change during study?
        /// </summary>
        public FhirBoolean IsAdaptive { get; set; }
        
        /// <summary>
        /// How many arms planned?
        /// </summary>
        public Integer Arms { get; set; }
        
        /// <summary>
        /// What percent of subjects receive therapy?
        /// </summary>
        public Ratio RandomizationQuotient { get; set; }
        
        /// <summary>
        /// Health condition treated in study
        /// </summary>
        public CodeableConcept Indication { get; set; }
        
        /// <summary>
        /// Base treatment added on to
        /// </summary>
        public List<CodeableConcept> CurrentTreatment { get; set; }
        
        /// <summary>
        /// Treatment compared against
        /// </summary>
        public CodeableConcept ComparativeTreatment { get; set; }
        
        /// <summary>
        /// Treatment being investigated
        /// </summary>
        public CodeableConcept Treatment { get; set; }
        
        /// <summary>
        /// Category of drug studied
        /// </summary>
        public CodeableConcept PharmacologicalClass { get; set; }
        
        /// <summary>
        /// How drug is introduced to body
        /// </summary>
        public CodeableConcept Route { get; set; }
        
        /// <summary>
        /// Quantity per administration
        /// </summary>
        public Quantity Dose { get; set; }
        
        /// <summary>
        /// How often dose given
        /// </summary>
        public Quantity DoseFrequency { get; set; }
        
        /// <summary>
        /// Criteria for when study should terminate
        /// </summary>
        public FhirString StopRules { get; set; }
        
        /// <summary>
        /// Number of actual subjects
        /// </summary>
        public Integer Participants { get; set; }
        
        /// <summary>
        /// When data collection ended
        /// </summary>
        public StudyDataCutoffComponent DataCutoff { get; set; }
        
        /// <summary>
        /// Countries where study performed
        /// </summary>
        public List<Code> Country { get; set; }
        
    }
    
}
