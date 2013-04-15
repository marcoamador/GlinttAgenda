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

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Starting point for serializing resources
    */
    public static partial class FhirSerializer
    {
        internal static void SerializeResource(Resource value, IFhirWriter writer)
        {
            if(value.GetType() == typeof(AdverseReaction))
                AdverseReactionSerializer.SerializeAdverseReaction((AdverseReaction)value, writer);
            else if(value.GetType() == typeof(AllergyIntolerance))
                AllergyIntoleranceSerializer.SerializeAllergyIntolerance((AllergyIntolerance)value, writer);
            else if(value.GetType() == typeof(CarePlan))
                CarePlanSerializer.SerializeCarePlan((CarePlan)value, writer);
            else if(value.GetType() == typeof(Category))
                CategorySerializer.SerializeCategory((Category)value, writer);
            else if(value.GetType() == typeof(Conformance))
                ConformanceSerializer.SerializeConformance((Conformance)value, writer);
            else if(value.GetType() == typeof(Coverage))
                CoverageSerializer.SerializeCoverage((Coverage)value, writer);
            else if(value.GetType() == typeof(Device))
                DeviceSerializer.SerializeDevice((Device)value, writer);
            else if(value.GetType() == typeof(DeviceCapabilities))
                DeviceCapabilitiesSerializer.SerializeDeviceCapabilities((DeviceCapabilities)value, writer);
            else if(value.GetType() == typeof(DeviceLog))
                DeviceLogSerializer.SerializeDeviceLog((DeviceLog)value, writer);
            else if(value.GetType() == typeof(DeviceObservation))
                DeviceObservationSerializer.SerializeDeviceObservation((DeviceObservation)value, writer);
            else if(value.GetType() == typeof(DiagnosticReport))
                DiagnosticReportSerializer.SerializeDiagnosticReport((DiagnosticReport)value, writer);
            else if(value.GetType() == typeof(Document))
                DocumentSerializer.SerializeDocument((Document)value, writer);
            else if(value.GetType() == typeof(DocumentReference))
                DocumentReferenceSerializer.SerializeDocumentReference((DocumentReference)value, writer);
            else if(value.GetType() == typeof(FamilyHistory))
                FamilyHistorySerializer.SerializeFamilyHistory((FamilyHistory)value, writer);
            else if(value.GetType() == typeof(Group))
                GroupSerializer.SerializeGroup((Group)value, writer);
            else if(value.GetType() == typeof(ImagingStudy))
                ImagingStudySerializer.SerializeImagingStudy((ImagingStudy)value, writer);
            else if(value.GetType() == typeof(Immunization))
                ImmunizationSerializer.SerializeImmunization((Immunization)value, writer);
            else if(value.GetType() == typeof(ImmunizationProfile))
                ImmunizationProfileSerializer.SerializeImmunizationProfile((ImmunizationProfile)value, writer);
            else if(value.GetType() == typeof(IssueReport))
                IssueReportSerializer.SerializeIssueReport((IssueReport)value, writer);
            else if(value.GetType() == typeof(List))
                ListSerializer.SerializeList((List)value, writer);
            else if(value.GetType() == typeof(Location))
                LocationSerializer.SerializeLocation((Location)value, writer);
            else if(value.GetType() == typeof(MedicationAdministration))
                MedicationAdministrationSerializer.SerializeMedicationAdministration((MedicationAdministration)value, writer);
            else if(value.GetType() == typeof(Message))
                MessageSerializer.SerializeMessage((Message)value, writer);
            else if(value.GetType() == typeof(Observation))
                ObservationSerializer.SerializeObservation((Observation)value, writer);
            else if(value.GetType() == typeof(Order))
                OrderSerializer.SerializeOrder((Order)value, writer);
            else if(value.GetType() == typeof(OrderResponse))
                OrderResponseSerializer.SerializeOrderResponse((OrderResponse)value, writer);
            else if(value.GetType() == typeof(Organization))
                OrganizationSerializer.SerializeOrganization((Organization)value, writer);
            else if(value.GetType() == typeof(Patient))
                PatientSerializer.SerializePatient((Patient)value, writer);
            else if(value.GetType() == typeof(Picture))
                PictureSerializer.SerializePicture((Picture)value, writer);
            else if(value.GetType() == typeof(Practitioner))
                PractitionerSerializer.SerializePractitioner((Practitioner)value, writer);
            else if(value.GetType() == typeof(Prescription))
                PrescriptionSerializer.SerializePrescription((Prescription)value, writer);
            else if(value.GetType() == typeof(Problem))
                ProblemSerializer.SerializeProblem((Problem)value, writer);
            else if(value.GetType() == typeof(Procedure))
                ProcedureSerializer.SerializeProcedure((Procedure)value, writer);
            else if(value.GetType() == typeof(Profile))
                ProfileSerializer.SerializeProfile((Profile)value, writer);
            else if(value.GetType() == typeof(Provenance))
                ProvenanceSerializer.SerializeProvenance((Provenance)value, writer);
            else if(value.GetType() == typeof(Questionnaire))
                QuestionnaireSerializer.SerializeQuestionnaire((Questionnaire)value, writer);
            else if(value.GetType() == typeof(SecurityEvent))
                SecurityEventSerializer.SerializeSecurityEvent((SecurityEvent)value, writer);
            else if(value.GetType() == typeof(Specimen))
                SpecimenSerializer.SerializeSpecimen((Specimen)value, writer);
            else if(value.GetType() == typeof(Substance))
                SubstanceSerializer.SerializeSubstance((Substance)value, writer);
            else if(value.GetType() == typeof(Test))
                TestSerializer.SerializeTest((Test)value, writer);
            else if(value.GetType() == typeof(ValueSet))
                ValueSetSerializer.SerializeValueSet((ValueSet)value, writer);
            else if(value.GetType() == typeof(Visit))
                VisitSerializer.SerializeVisit((Visit)value, writer);
            else if(value.GetType() == typeof(Medication))
                MedicationSerializer.SerializeMedication((Medication)value, writer);
            else if(value.GetType() == typeof(Appointment))
                AppointmentSerializer.SerializeAppointment((Appointment)value, writer);
            else if(value.GetType() == typeof(Product))
                ProductSerializer.SerializeProduct((Product)value, writer);
            else if(value.GetType() == typeof(Food))
                FoodSerializer.SerializeFood((Food)value, writer);
            else if(value.GetType() == typeof(Request))
                RequestSerializer.SerializeRequest((Request)value, writer);
            else if(value.GetType() == typeof(Admission))
                AdmissionSerializer.SerializeAdmission((Admission)value, writer);
            else if(value.GetType() == typeof(AnatomicalLocation))
                AnatomicalLocationSerializer.SerializeAnatomicalLocation((AnatomicalLocation)value, writer);
            else if(value.GetType() == typeof(Person))
                PersonSerializer.SerializePerson((Person)value, writer);
            else if(value.GetType() == typeof(InterestOfCare))
                InterestOfCareSerializer.SerializeInterestOfCare((InterestOfCare)value, writer);
            else if(value.GetType() == typeof(RelatedPerson))
                RelatedPersonSerializer.SerializeRelatedPerson((RelatedPerson)value, writer);
            else
                throw new Exception("Encountered unknown type " + value.GetType().Name);
        }
        
        
        internal static void SerializeElement(Element value, IFhirWriter writer)
        {
            if(value.GetType() == typeof(Address))
                AddressSerializer.SerializeAddress((Address)value, writer);
            else if(value.GetType() == typeof(Attachment))
                AttachmentSerializer.SerializeAttachment((Attachment)value, writer);
            else if(value.GetType() == typeof(Choice))
                ChoiceSerializer.SerializeChoice((Choice)value, writer);
            else if(value.GetType() == typeof(CodeableConcept))
                CodeableConceptSerializer.SerializeCodeableConcept((CodeableConcept)value, writer);
            else if(value.GetType() == typeof(Coding))
                CodingSerializer.SerializeCoding((Coding)value, writer);
            else if(value.GetType() == typeof(Contact))
                ContactSerializer.SerializeContact((Contact)value, writer);
            else if(value.GetType() == typeof(Demographics))
                DemographicsSerializer.SerializeDemographics((Demographics)value, writer);
            else if(value.GetType() == typeof(Extension))
                ExtensionSerializer.SerializeExtension((Extension)value, writer);
            else if(value.GetType() == typeof(HumanName))
                HumanNameSerializer.SerializeHumanName((HumanName)value, writer);
            else if(value.GetType() == typeof(Identifier))
                IdentifierSerializer.SerializeIdentifier((Identifier)value, writer);
            else if(value.GetType() == typeof(Narrative))
                NarrativeSerializer.SerializeNarrative((Narrative)value, writer);
            else if(value.GetType() == typeof(Period))
                PeriodSerializer.SerializePeriod((Period)value, writer);
            else if(value.GetType() == typeof(Quantity))
                QuantitySerializer.SerializeQuantity((Quantity)value, writer);
            else if(value.GetType() == typeof(Range))
                RangeSerializer.SerializeRange((Range)value, writer);
            else if(value.GetType() == typeof(Ratio))
                RatioSerializer.SerializeRatio((Ratio)value, writer);
            else if(value.GetType() == typeof(ResourceReference))
                ResourceReferenceSerializer.SerializeResourceReference((ResourceReference)value, writer);
            else if(value.GetType() == typeof(Schedule))
                ScheduleSerializer.SerializeSchedule((Schedule)value, writer);
            else if(value.GetType() == typeof(Base64Binary))
                Base64BinarySerializer.SerializeBase64Binary((Base64Binary)value, writer);
            else if(value.GetType() == typeof(FhirBoolean))
                FhirBooleanSerializer.SerializeFhirBoolean((FhirBoolean)value, writer);
            else if(value.GetType() == typeof(Code))
                CodeSerializer.SerializeCode((Code)value, writer);
            else if(value.GetType() == typeof(Date))
                DateSerializer.SerializeDate((Date)value, writer);
            else if(value.GetType() == typeof(FhirDateTime))
                FhirDateTimeSerializer.SerializeFhirDateTime((FhirDateTime)value, writer);
            else if(value.GetType() == typeof(FhirDecimal))
                FhirDecimalSerializer.SerializeFhirDecimal((FhirDecimal)value, writer);
            else if(value.GetType() == typeof(Id))
                IdSerializer.SerializeId((Id)value, writer);
            else if(value.GetType() == typeof(IdRef))
                IdRefSerializer.SerializeIdRef((IdRef)value, writer);
            else if(value.GetType() == typeof(Instant))
                InstantSerializer.SerializeInstant((Instant)value, writer);
            else if(value.GetType() == typeof(Integer))
                IntegerSerializer.SerializeInteger((Integer)value, writer);
            else if(value.GetType() == typeof(Oid))
                OidSerializer.SerializeOid((Oid)value, writer);
            else if(value.GetType() == typeof(FhirString))
                FhirStringSerializer.SerializeFhirString((FhirString)value, writer);
            else if(value.GetType() == typeof(FhirUri))
                FhirUriSerializer.SerializeFhirUri((FhirUri)value, writer);
            else if(value.GetType() == typeof(Uuid))
                UuidSerializer.SerializeUuid((Uuid)value, writer);
            else if(value.GetType() == typeof(XHtml))
                XHtmlSerializer.SerializeXHtml((XHtml)value, writer);
            else if(value.GetType() == typeof(Age))
                QuantitySerializer.SerializeQuantity((Age)value, writer);
            else if(value.GetType() == typeof(Count))
                QuantitySerializer.SerializeQuantity((Count)value, writer);
            else if(value.GetType() == typeof(Distance))
                QuantitySerializer.SerializeQuantity((Distance)value, writer);
            else if(value.GetType() == typeof(Duration))
                QuantitySerializer.SerializeQuantity((Duration)value, writer);
            else if(value.GetType() == typeof(Money))
                QuantitySerializer.SerializeQuantity((Money)value, writer);
            else
                throw new Exception("Encountered unknown type " + value.GetType().Name);
        }
        
    }
}
