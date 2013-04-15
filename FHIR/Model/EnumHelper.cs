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
    public static class EnumHelper
    {
        public static bool TryParseEnum(string value, Type enumType, out object result)
        {
            if(enumType == typeof(BooleanYesNo))
            {
                BooleanYesNo res;
                bool success = BooleanYesNoHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(DataAbsentReason))
            {
                DataAbsentReason res;
                bool success = DataAbsentReasonHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(ObservationStatus))
            {
                ObservationStatus res;
                bool success = ObservationStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(SearchParamType))
            {
                SearchParamType res;
                bool success = SearchParamTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(SearchRepeatBehavior))
            {
                SearchRepeatBehavior res;
                bool success = SearchRepeatBehaviorHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(ResourceType))
            {
                ResourceType res;
                bool success = ResourceTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Address.AddressUse))
            {
                Address.AddressUse res;
                bool success = Address.AddressUseHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Contact.ContactSystem))
            {
                Contact.ContactSystem res;
                bool success = Contact.ContactSystemHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Contact.ContactUse))
            {
                Contact.ContactUse res;
                bool success = Contact.ContactUseHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Demographics.AdministrativeGender))
            {
                Demographics.AdministrativeGender res;
                bool success = Demographics.AdministrativeGenderHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Demographics.LanguageAbilityMode))
            {
                Demographics.LanguageAbilityMode res;
                bool success = Demographics.LanguageAbilityModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Demographics.LanguageAbilityProficiency))
            {
                Demographics.LanguageAbilityProficiency res;
                bool success = Demographics.LanguageAbilityProficiencyHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(HumanName.NameUse))
            {
                HumanName.NameUse res;
                bool success = HumanName.NameUseHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Identifier.IdentifierUse))
            {
                Identifier.IdentifierUse res;
                bool success = Identifier.IdentifierUseHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Narrative.NarrativeStatus))
            {
                Narrative.NarrativeStatus res;
                bool success = Narrative.NarrativeStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Narrative.NarrativeMapSource))
            {
                Narrative.NarrativeMapSource res;
                bool success = Narrative.NarrativeMapSourceHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Quantity.QuantityCompararator))
            {
                Quantity.QuantityCompararator res;
                bool success = Quantity.QuantityCompararatorHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Schedule.UnitsOfTime))
            {
                Schedule.UnitsOfTime res;
                bool success = Schedule.UnitsOfTimeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Schedule.EventTiming))
            {
                Schedule.EventTiming res;
                bool success = Schedule.EventTimingHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(AdverseReaction.ReactionSeverity))
            {
                AdverseReaction.ReactionSeverity res;
                bool success = AdverseReaction.ReactionSeverityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(AdverseReaction.ExposureType))
            {
                AdverseReaction.ExposureType res;
                bool success = AdverseReaction.ExposureTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(AllergyIntolerance.SensitivityStatus))
            {
                AllergyIntolerance.SensitivityStatus res;
                bool success = AllergyIntolerance.SensitivityStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(AllergyIntolerance.Criticality))
            {
                AllergyIntolerance.Criticality res;
                bool success = AllergyIntolerance.CriticalityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(AllergyIntolerance.SensitivityType))
            {
                AllergyIntolerance.SensitivityType res;
                bool success = AllergyIntolerance.SensitivityTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(CarePlan.CarePlanStatus))
            {
                CarePlan.CarePlanStatus res;
                bool success = CarePlan.CarePlanStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(CarePlan.CarePlanActivityCategory))
            {
                CarePlan.CarePlanActivityCategory res;
                bool success = CarePlan.CarePlanActivityCategoryHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(CarePlan.CarePlanGoalStatus))
            {
                CarePlan.CarePlanGoalStatus res;
                bool success = CarePlan.CarePlanGoalStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(CarePlan.CarePlanActivityStatus))
            {
                CarePlan.CarePlanActivityStatus res;
                bool success = CarePlan.CarePlanActivityStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Conformance.RestfulOperation))
            {
                Conformance.RestfulOperation res;
                bool success = Conformance.RestfulOperationHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Conformance.DocumentMode))
            {
                Conformance.DocumentMode res;
                bool success = Conformance.DocumentModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Conformance.RestfulConformanceMode))
            {
                Conformance.RestfulConformanceMode res;
                bool success = Conformance.RestfulConformanceModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Conformance.MessageTransport))
            {
                Conformance.MessageTransport res;
                bool success = Conformance.MessageTransportHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Conformance.ConformanceEventMode))
            {
                Conformance.ConformanceEventMode res;
                bool success = Conformance.ConformanceEventModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Conformance.RestfulSecurityService))
            {
                Conformance.RestfulSecurityService res;
                bool success = Conformance.RestfulSecurityServiceHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(DeviceCapabilities.DeviceDataType))
            {
                DeviceCapabilities.DeviceDataType res;
                bool success = DeviceCapabilities.DeviceDataTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(DeviceLog.DeviceValueFlag))
            {
                DeviceLog.DeviceValueFlag res;
                bool success = DeviceLog.DeviceValueFlagHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Document.DocumentAttestationMode))
            {
                Document.DocumentAttestationMode res;
                bool success = Document.DocumentAttestationModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(DocumentReference.DocumentReferenceStatus))
            {
                DocumentReference.DocumentReferenceStatus res;
                bool success = DocumentReference.DocumentReferenceStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(FamilyHistory.FamilialRelationship))
            {
                FamilyHistory.FamilialRelationship res;
                bool success = FamilyHistory.FamilialRelationshipHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Group.GroupType))
            {
                Group.GroupType res;
                bool success = Group.GroupTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(ImagingStudy.ImageModality))
            {
                ImagingStudy.ImageModality res;
                bool success = ImagingStudy.ImageModalityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(IssueReport.IssueSeverity))
            {
                IssueReport.IssueSeverity res;
                bool success = IssueReport.IssueSeverityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(List.ListMode))
            {
                List.ListMode res;
                bool success = List.ListModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(MedicationAdministration.MedicationAdministrationStatus))
            {
                MedicationAdministration.MedicationAdministrationStatus res;
                bool success = MedicationAdministration.MedicationAdministrationStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Message.ResponseCode))
            {
                Message.ResponseCode res;
                bool success = Message.ResponseCodeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Observation.ObservationReliability))
            {
                Observation.ObservationReliability res;
                bool success = Observation.ObservationReliabilityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Observation.ObservationInterpretation))
            {
                Observation.ObservationInterpretation res;
                bool success = Observation.ObservationInterpretationHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(OrderResponse.OrderOutcomeCode))
            {
                OrderResponse.OrderOutcomeCode res;
                bool success = OrderResponse.OrderOutcomeCodeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Organization.RecordStatus))
            {
                Organization.RecordStatus res;
                bool success = Organization.RecordStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Picture.ImageModality3))
            {
                Picture.ImageModality3 res;
                bool success = Picture.ImageModality3Handling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Prescription.PrescriptionStatus))
            {
                Prescription.PrescriptionStatus res;
                bool success = Prescription.PrescriptionStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Problem.ProblemRelationshipType))
            {
                Problem.ProblemRelationshipType res;
                bool success = Problem.ProblemRelationshipTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Procedure.ProcedureRelationshipType))
            {
                Procedure.ProcedureRelationshipType res;
                bool success = Procedure.ProcedureRelationshipTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Profile.BindingType))
            {
                Profile.BindingType res;
                bool success = Profile.BindingTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Profile.BindingConformance))
            {
                Profile.BindingConformance res;
                bool success = Profile.BindingConformanceHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Profile.ConstraintSeverity))
            {
                Profile.ConstraintSeverity res;
                bool success = Profile.ConstraintSeverityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Profile.ResourceProfileStatus))
            {
                Profile.ResourceProfileStatus res;
                bool success = Profile.ResourceProfileStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Profile.ExtensionContext))
            {
                Profile.ExtensionContext res;
                bool success = Profile.ExtensionContextHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Provenance.ProvenanceParticipantType))
            {
                Provenance.ProvenanceParticipantType res;
                bool success = Provenance.ProvenanceParticipantTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Provenance.ProvenanceParticipantRole))
            {
                Provenance.ProvenanceParticipantRole res;
                bool success = Provenance.ProvenanceParticipantRoleHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(SecurityEvent.SecurityEventObjectRole))
            {
                SecurityEvent.SecurityEventObjectRole res;
                bool success = SecurityEvent.SecurityEventObjectRoleHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(SecurityEvent.SecurityEventObjectType))
            {
                SecurityEvent.SecurityEventObjectType res;
                bool success = SecurityEvent.SecurityEventObjectTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(SecurityEvent.SecurityEventObjectLifecycle))
            {
                SecurityEvent.SecurityEventObjectLifecycle res;
                bool success = SecurityEvent.SecurityEventObjectLifecycleHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(SecurityEvent.SecurityEventObjectIdType))
            {
                SecurityEvent.SecurityEventObjectIdType res;
                bool success = SecurityEvent.SecurityEventObjectIdTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(SecurityEvent.SecurityEventEventOutcome))
            {
                SecurityEvent.SecurityEventEventOutcome res;
                bool success = SecurityEvent.SecurityEventEventOutcomeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(SecurityEvent.SecurityEventParticipantNetworkType))
            {
                SecurityEvent.SecurityEventParticipantNetworkType res;
                bool success = SecurityEvent.SecurityEventParticipantNetworkTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(SecurityEvent.SecurityEventSourceType))
            {
                SecurityEvent.SecurityEventSourceType res;
                bool success = SecurityEvent.SecurityEventSourceTypeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(SecurityEvent.SecurityEventSeverity))
            {
                SecurityEvent.SecurityEventSeverity res;
                bool success = SecurityEvent.SecurityEventSeverityHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(SecurityEvent.SecurityEventEventAction))
            {
                SecurityEvent.SecurityEventEventAction res;
                bool success = SecurityEvent.SecurityEventEventActionHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(ValueSet.CodeSelectionMode))
            {
                ValueSet.CodeSelectionMode res;
                bool success = ValueSet.CodeSelectionModeHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(ValueSet.ValueSetStatus))
            {
                ValueSet.ValueSetStatus res;
                bool success = ValueSet.ValueSetStatusHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(ValueSet.FilterOperator))
            {
                ValueSet.FilterOperator res;
                bool success = ValueSet.FilterOperatorHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Visit.VisitSetting))
            {
                Visit.VisitSetting res;
                bool success = Visit.VisitSettingHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else if(enumType == typeof(Visit.VisitState))
            {
                Visit.VisitState res;
                bool success = Visit.VisitStateHandling.TryParse(value, out res);
                result = res;
                return success;
            }
            else
            {
                result = null;
                return false;
            }
            
        }
        
        public static string EnumToString(object value, Type enumType)
        {
            if(enumType == typeof(BooleanYesNo))
                return BooleanYesNoHandling.ToString((BooleanYesNo)value);
            else if(enumType == typeof(DataAbsentReason))
                return DataAbsentReasonHandling.ToString((DataAbsentReason)value);
            else if(enumType == typeof(ObservationStatus))
                return ObservationStatusHandling.ToString((ObservationStatus)value);
            else if(enumType == typeof(SearchParamType))
                return SearchParamTypeHandling.ToString((SearchParamType)value);
            else if(enumType == typeof(SearchRepeatBehavior))
                return SearchRepeatBehaviorHandling.ToString((SearchRepeatBehavior)value);
            else if(enumType == typeof(ResourceType))
                return ResourceTypeHandling.ToString((ResourceType)value);
            else if(enumType == typeof(Address.AddressUse))
                return Address.AddressUseHandling.ToString((Address.AddressUse)value);
            else if(enumType == typeof(Contact.ContactSystem))
                return Contact.ContactSystemHandling.ToString((Contact.ContactSystem)value);
            else if(enumType == typeof(Contact.ContactUse))
                return Contact.ContactUseHandling.ToString((Contact.ContactUse)value);
            else if(enumType == typeof(Demographics.AdministrativeGender))
                return Demographics.AdministrativeGenderHandling.ToString((Demographics.AdministrativeGender)value);
            else if(enumType == typeof(Demographics.LanguageAbilityMode))
                return Demographics.LanguageAbilityModeHandling.ToString((Demographics.LanguageAbilityMode)value);
            else if(enumType == typeof(Demographics.LanguageAbilityProficiency))
                return Demographics.LanguageAbilityProficiencyHandling.ToString((Demographics.LanguageAbilityProficiency)value);
            else if(enumType == typeof(HumanName.NameUse))
                return HumanName.NameUseHandling.ToString((HumanName.NameUse)value);
            else if(enumType == typeof(Identifier.IdentifierUse))
                return Identifier.IdentifierUseHandling.ToString((Identifier.IdentifierUse)value);
            else if(enumType == typeof(Narrative.NarrativeStatus))
                return Narrative.NarrativeStatusHandling.ToString((Narrative.NarrativeStatus)value);
            else if(enumType == typeof(Narrative.NarrativeMapSource))
                return Narrative.NarrativeMapSourceHandling.ToString((Narrative.NarrativeMapSource)value);
            else if(enumType == typeof(Quantity.QuantityCompararator))
                return Quantity.QuantityCompararatorHandling.ToString((Quantity.QuantityCompararator)value);
            else if(enumType == typeof(Schedule.UnitsOfTime))
                return Schedule.UnitsOfTimeHandling.ToString((Schedule.UnitsOfTime)value);
            else if(enumType == typeof(Schedule.EventTiming))
                return Schedule.EventTimingHandling.ToString((Schedule.EventTiming)value);
            else if(enumType == typeof(AdverseReaction.ReactionSeverity))
                return AdverseReaction.ReactionSeverityHandling.ToString((AdverseReaction.ReactionSeverity)value);
            else if(enumType == typeof(AdverseReaction.ExposureType))
                return AdverseReaction.ExposureTypeHandling.ToString((AdverseReaction.ExposureType)value);
            else if(enumType == typeof(AllergyIntolerance.SensitivityStatus))
                return AllergyIntolerance.SensitivityStatusHandling.ToString((AllergyIntolerance.SensitivityStatus)value);
            else if(enumType == typeof(AllergyIntolerance.Criticality))
                return AllergyIntolerance.CriticalityHandling.ToString((AllergyIntolerance.Criticality)value);
            else if(enumType == typeof(AllergyIntolerance.SensitivityType))
                return AllergyIntolerance.SensitivityTypeHandling.ToString((AllergyIntolerance.SensitivityType)value);
            else if(enumType == typeof(CarePlan.CarePlanStatus))
                return CarePlan.CarePlanStatusHandling.ToString((CarePlan.CarePlanStatus)value);
            else if(enumType == typeof(CarePlan.CarePlanActivityCategory))
                return CarePlan.CarePlanActivityCategoryHandling.ToString((CarePlan.CarePlanActivityCategory)value);
            else if(enumType == typeof(CarePlan.CarePlanGoalStatus))
                return CarePlan.CarePlanGoalStatusHandling.ToString((CarePlan.CarePlanGoalStatus)value);
            else if(enumType == typeof(CarePlan.CarePlanActivityStatus))
                return CarePlan.CarePlanActivityStatusHandling.ToString((CarePlan.CarePlanActivityStatus)value);
            else if(enumType == typeof(Conformance.RestfulOperation))
                return Conformance.RestfulOperationHandling.ToString((Conformance.RestfulOperation)value);
            else if(enumType == typeof(Conformance.DocumentMode))
                return Conformance.DocumentModeHandling.ToString((Conformance.DocumentMode)value);
            else if(enumType == typeof(Conformance.RestfulConformanceMode))
                return Conformance.RestfulConformanceModeHandling.ToString((Conformance.RestfulConformanceMode)value);
            else if(enumType == typeof(Conformance.MessageTransport))
                return Conformance.MessageTransportHandling.ToString((Conformance.MessageTransport)value);
            else if(enumType == typeof(Conformance.ConformanceEventMode))
                return Conformance.ConformanceEventModeHandling.ToString((Conformance.ConformanceEventMode)value);
            else if(enumType == typeof(Conformance.RestfulSecurityService))
                return Conformance.RestfulSecurityServiceHandling.ToString((Conformance.RestfulSecurityService)value);
            else if(enumType == typeof(DeviceCapabilities.DeviceDataType))
                return DeviceCapabilities.DeviceDataTypeHandling.ToString((DeviceCapabilities.DeviceDataType)value);
            else if(enumType == typeof(DeviceLog.DeviceValueFlag))
                return DeviceLog.DeviceValueFlagHandling.ToString((DeviceLog.DeviceValueFlag)value);
            else if(enumType == typeof(Document.DocumentAttestationMode))
                return Document.DocumentAttestationModeHandling.ToString((Document.DocumentAttestationMode)value);
            else if(enumType == typeof(DocumentReference.DocumentReferenceStatus))
                return DocumentReference.DocumentReferenceStatusHandling.ToString((DocumentReference.DocumentReferenceStatus)value);
            else if(enumType == typeof(FamilyHistory.FamilialRelationship))
                return FamilyHistory.FamilialRelationshipHandling.ToString((FamilyHistory.FamilialRelationship)value);
            else if(enumType == typeof(Group.GroupType))
                return Group.GroupTypeHandling.ToString((Group.GroupType)value);
            else if(enumType == typeof(ImagingStudy.ImageModality))
                return ImagingStudy.ImageModalityHandling.ToString((ImagingStudy.ImageModality)value);
            else if(enumType == typeof(IssueReport.IssueSeverity))
                return IssueReport.IssueSeverityHandling.ToString((IssueReport.IssueSeverity)value);
            else if(enumType == typeof(List.ListMode))
                return List.ListModeHandling.ToString((List.ListMode)value);
            else if(enumType == typeof(MedicationAdministration.MedicationAdministrationStatus))
                return MedicationAdministration.MedicationAdministrationStatusHandling.ToString((MedicationAdministration.MedicationAdministrationStatus)value);
            else if(enumType == typeof(Message.ResponseCode))
                return Message.ResponseCodeHandling.ToString((Message.ResponseCode)value);
            else if(enumType == typeof(Observation.ObservationReliability))
                return Observation.ObservationReliabilityHandling.ToString((Observation.ObservationReliability)value);
            else if(enumType == typeof(Observation.ObservationInterpretation))
                return Observation.ObservationInterpretationHandling.ToString((Observation.ObservationInterpretation)value);
            else if(enumType == typeof(OrderResponse.OrderOutcomeCode))
                return OrderResponse.OrderOutcomeCodeHandling.ToString((OrderResponse.OrderOutcomeCode)value);
            else if(enumType == typeof(Organization.RecordStatus))
                return Organization.RecordStatusHandling.ToString((Organization.RecordStatus)value);
            else if(enumType == typeof(Picture.ImageModality3))
                return Picture.ImageModality3Handling.ToString((Picture.ImageModality3)value);
            else if(enumType == typeof(Prescription.PrescriptionStatus))
                return Prescription.PrescriptionStatusHandling.ToString((Prescription.PrescriptionStatus)value);
            else if(enumType == typeof(Problem.ProblemRelationshipType))
                return Problem.ProblemRelationshipTypeHandling.ToString((Problem.ProblemRelationshipType)value);
            else if(enumType == typeof(Procedure.ProcedureRelationshipType))
                return Procedure.ProcedureRelationshipTypeHandling.ToString((Procedure.ProcedureRelationshipType)value);
            else if(enumType == typeof(Profile.BindingType))
                return Profile.BindingTypeHandling.ToString((Profile.BindingType)value);
            else if(enumType == typeof(Profile.BindingConformance))
                return Profile.BindingConformanceHandling.ToString((Profile.BindingConformance)value);
            else if(enumType == typeof(Profile.ConstraintSeverity))
                return Profile.ConstraintSeverityHandling.ToString((Profile.ConstraintSeverity)value);
            else if(enumType == typeof(Profile.ResourceProfileStatus))
                return Profile.ResourceProfileStatusHandling.ToString((Profile.ResourceProfileStatus)value);
            else if(enumType == typeof(Profile.ExtensionContext))
                return Profile.ExtensionContextHandling.ToString((Profile.ExtensionContext)value);
            else if(enumType == typeof(Provenance.ProvenanceParticipantType))
                return Provenance.ProvenanceParticipantTypeHandling.ToString((Provenance.ProvenanceParticipantType)value);
            else if(enumType == typeof(Provenance.ProvenanceParticipantRole))
                return Provenance.ProvenanceParticipantRoleHandling.ToString((Provenance.ProvenanceParticipantRole)value);
            else if(enumType == typeof(SecurityEvent.SecurityEventObjectRole))
                return SecurityEvent.SecurityEventObjectRoleHandling.ToString((SecurityEvent.SecurityEventObjectRole)value);
            else if(enumType == typeof(SecurityEvent.SecurityEventObjectType))
                return SecurityEvent.SecurityEventObjectTypeHandling.ToString((SecurityEvent.SecurityEventObjectType)value);
            else if(enumType == typeof(SecurityEvent.SecurityEventObjectLifecycle))
                return SecurityEvent.SecurityEventObjectLifecycleHandling.ToString((SecurityEvent.SecurityEventObjectLifecycle)value);
            else if(enumType == typeof(SecurityEvent.SecurityEventObjectIdType))
                return SecurityEvent.SecurityEventObjectIdTypeHandling.ToString((SecurityEvent.SecurityEventObjectIdType)value);
            else if(enumType == typeof(SecurityEvent.SecurityEventEventOutcome))
                return SecurityEvent.SecurityEventEventOutcomeHandling.ToString((SecurityEvent.SecurityEventEventOutcome)value);
            else if(enumType == typeof(SecurityEvent.SecurityEventParticipantNetworkType))
                return SecurityEvent.SecurityEventParticipantNetworkTypeHandling.ToString((SecurityEvent.SecurityEventParticipantNetworkType)value);
            else if(enumType == typeof(SecurityEvent.SecurityEventSourceType))
                return SecurityEvent.SecurityEventSourceTypeHandling.ToString((SecurityEvent.SecurityEventSourceType)value);
            else if(enumType == typeof(SecurityEvent.SecurityEventSeverity))
                return SecurityEvent.SecurityEventSeverityHandling.ToString((SecurityEvent.SecurityEventSeverity)value);
            else if(enumType == typeof(SecurityEvent.SecurityEventEventAction))
                return SecurityEvent.SecurityEventEventActionHandling.ToString((SecurityEvent.SecurityEventEventAction)value);
            else if(enumType == typeof(ValueSet.CodeSelectionMode))
                return ValueSet.CodeSelectionModeHandling.ToString((ValueSet.CodeSelectionMode)value);
            else if(enumType == typeof(ValueSet.ValueSetStatus))
                return ValueSet.ValueSetStatusHandling.ToString((ValueSet.ValueSetStatus)value);
            else if(enumType == typeof(ValueSet.FilterOperator))
                return ValueSet.FilterOperatorHandling.ToString((ValueSet.FilterOperator)value);
            else if(enumType == typeof(Visit.VisitSetting))
                return Visit.VisitSettingHandling.ToString((Visit.VisitSetting)value);
            else if(enumType == typeof(Visit.VisitState))
                return Visit.VisitStateHandling.ToString((Visit.VisitState)value);
            else
                throw new ArgumentException("Unrecognized enumeration " + enumType.Name);
            
        }
    }
}
