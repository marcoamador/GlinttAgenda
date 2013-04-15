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

namespace Hl7.Fhir.Model
{
    /*
    * A class with methods to retrieve informationa about the
    * FHIR definitions based on which this assembly was generated.
    */
    public static partial class ModelInfo
    {
        public static List<string> SupportedResources = 
            new List<string>
            {
                "Resource",
                "AdverseReaction",
                "AllergyIntolerance",
                "CarePlan",
                "Category",
                "Conformance",
                "Coverage",
                "Device",
                "DeviceCapabilities",
                "DeviceLog",
                "DeviceObservation",
                "DiagnosticReport",
                "Document",
                "DocumentReference",
                "FamilyHistory",
                "Group",
                "ImagingStudy",
                "Immunization",
                "ImmunizationProfile",
                "IssueReport",
                "List",
                "Location",
                "MedicationAdministration",
                "Message",
                "Observation",
                "Order",
                "OrderResponse",
                "Organization",
                "Patient",
                "Picture",
                "Practitioner",
                "Prescription",
                "Problem",
                "Procedure",
                "Profile",
                "Provenance",
                "Questionnaire",
                "SecurityEvent",
                "Specimen",
                "Substance",
                "Test",
                "ValueSet",
                "Visit",
                "Medication",
                "Appointment",
                "Product",
                "Food",
                "Request",
                "Admission",
                "AnatomicalLocation",
                "Person",
                "InterestOfCare",
                "RelatedPerson",
            };
        
        public static string Version
        {
            get { return "0.08"; }
        }
        
        public static Dictionary<string,Type> FhirTypeToCsType =
            new Dictionary<string,Type>()
            {
                { "Address", typeof(Address) },
                { "Age", typeof(Age) },
                { "Attachment", typeof(Attachment) },
                { "Choice", typeof(Choice) },
                { "CodeableConcept", typeof(CodeableConcept) },
                { "Coding", typeof(Coding) },
                { "Contact", typeof(Contact) },
                { "Count", typeof(Count) },
                { "Demographics", typeof(Demographics) },
                { "Distance", typeof(Distance) },
                { "Duration", typeof(Duration) },
                { "Element", typeof(Element) },
                { "Extension", typeof(Extension) },
                { "HumanName", typeof(HumanName) },
                { "Identifier", typeof(Identifier) },
                { "Money", typeof(Money) },
                { "Narrative", typeof(Narrative) },
                { "Period", typeof(Period) },
                { "Quantity", typeof(Quantity) },
                { "Range", typeof(Range) },
                { "Ratio", typeof(Ratio) },
                { "ResourceReference", typeof(ResourceReference) },
                { "Schedule", typeof(Schedule) },
                { "base64Binary", typeof(Base64Binary) },
                { "boolean", typeof(FhirBoolean) },
                { "code", typeof(Code) },
                { "date", typeof(Date) },
                { "dateTime", typeof(FhirDateTime) },
                { "decimal", typeof(FhirDecimal) },
                { "id", typeof(Id) },
                { "idref", typeof(IdRef) },
                { "instant", typeof(Instant) },
                { "integer", typeof(Integer) },
                { "oid", typeof(Oid) },
                { "string", typeof(FhirString) },
                { "uri", typeof(FhirUri) },
                { "uuid", typeof(Uuid) },
                { "xhtml", typeof(XHtml) },
                { "Resource", typeof(Resource) },
                { "AdverseReaction", typeof(AdverseReaction) },
                { "AllergyIntolerance", typeof(AllergyIntolerance) },
                { "CarePlan", typeof(CarePlan) },
                { "Category", typeof(Category) },
                { "Conformance", typeof(Conformance) },
                { "Coverage", typeof(Coverage) },
                { "Device", typeof(Device) },
                { "DeviceCapabilities", typeof(DeviceCapabilities) },
                { "DeviceLog", typeof(DeviceLog) },
                { "DeviceObservation", typeof(DeviceObservation) },
                { "DiagnosticReport", typeof(DiagnosticReport) },
                { "Document", typeof(Document) },
                { "DocumentReference", typeof(DocumentReference) },
                { "FamilyHistory", typeof(FamilyHistory) },
                { "Group", typeof(Group) },
                { "ImagingStudy", typeof(ImagingStudy) },
                { "Immunization", typeof(Immunization) },
                { "ImmunizationProfile", typeof(ImmunizationProfile) },
                { "IssueReport", typeof(IssueReport) },
                { "List", typeof(List) },
                { "Location", typeof(Location) },
                { "MedicationAdministration", typeof(MedicationAdministration) },
                { "Message", typeof(Message) },
                { "Observation", typeof(Observation) },
                { "Order", typeof(Order) },
                { "OrderResponse", typeof(OrderResponse) },
                { "Organization", typeof(Organization) },
                { "Patient", typeof(Patient) },
                { "Picture", typeof(Picture) },
                { "Practitioner", typeof(Practitioner) },
                { "Prescription", typeof(Prescription) },
                { "Problem", typeof(Problem) },
                { "Procedure", typeof(Procedure) },
                { "Profile", typeof(Profile) },
                { "Provenance", typeof(Provenance) },
                { "Questionnaire", typeof(Questionnaire) },
                { "SecurityEvent", typeof(SecurityEvent) },
                { "Specimen", typeof(Specimen) },
                { "Substance", typeof(Substance) },
                { "Test", typeof(Test) },
                { "ValueSet", typeof(ValueSet) },
                { "Visit", typeof(Visit) },
                { "Medication", typeof(Medication) },
                { "Appointment", typeof(Appointment) },
                { "Product", typeof(Product) },
                { "Food", typeof(Food) },
                { "Request", typeof(Request) },
                { "Admission", typeof(Admission) },
                { "AnatomicalLocation", typeof(AnatomicalLocation) },
                { "Person", typeof(Person) },
                { "InterestOfCare", typeof(InterestOfCare) },
                { "RelatedPerson", typeof(RelatedPerson) },
            };
        
        public static Dictionary<Type,string> FhirCsTypeToString =
            new Dictionary<Type,string>()
            {
                { typeof(Address), "Address" },
                { typeof(Age), "Age" },
                { typeof(Attachment), "Attachment" },
                { typeof(Choice), "Choice" },
                { typeof(CodeableConcept), "CodeableConcept" },
                { typeof(Coding), "Coding" },
                { typeof(Contact), "Contact" },
                { typeof(Count), "Count" },
                { typeof(Demographics), "Demographics" },
                { typeof(Distance), "Distance" },
                { typeof(Duration), "Duration" },
                { typeof(Element), "Element" },
                { typeof(Extension), "Extension" },
                { typeof(HumanName), "HumanName" },
                { typeof(Identifier), "Identifier" },
                { typeof(Money), "Money" },
                { typeof(Narrative), "Narrative" },
                { typeof(Period), "Period" },
                { typeof(Quantity), "Quantity" },
                { typeof(Range), "Range" },
                { typeof(Ratio), "Ratio" },
                { typeof(ResourceReference), "ResourceReference" },
                { typeof(Schedule), "Schedule" },
                { typeof(Base64Binary), "base64Binary" },
                { typeof(FhirBoolean), "boolean" },
                { typeof(Code), "code" },
                { typeof(Date), "date" },
                { typeof(FhirDateTime), "dateTime" },
                { typeof(FhirDecimal), "decimal" },
                { typeof(Id), "id" },
                { typeof(IdRef), "idref" },
                { typeof(Instant), "instant" },
                { typeof(Integer), "integer" },
                { typeof(Oid), "oid" },
                { typeof(FhirString), "string" },
                { typeof(FhirUri), "uri" },
                { typeof(Uuid), "uuid" },
                { typeof(XHtml), "xhtml" },
                { typeof(Resource), "Resource" },
                { typeof(AdverseReaction), "AdverseReaction" },
                { typeof(AllergyIntolerance), "AllergyIntolerance" },
                { typeof(CarePlan), "CarePlan" },
                { typeof(Category), "Category" },
                { typeof(Conformance), "Conformance" },
                { typeof(Coverage), "Coverage" },
                { typeof(Device), "Device" },
                { typeof(DeviceCapabilities), "DeviceCapabilities" },
                { typeof(DeviceLog), "DeviceLog" },
                { typeof(DeviceObservation), "DeviceObservation" },
                { typeof(DiagnosticReport), "DiagnosticReport" },
                { typeof(Document), "Document" },
                { typeof(DocumentReference), "DocumentReference" },
                { typeof(FamilyHistory), "FamilyHistory" },
                { typeof(Group), "Group" },
                { typeof(ImagingStudy), "ImagingStudy" },
                { typeof(Immunization), "Immunization" },
                { typeof(ImmunizationProfile), "ImmunizationProfile" },
                { typeof(IssueReport), "IssueReport" },
                { typeof(List), "List" },
                { typeof(Location), "Location" },
                { typeof(MedicationAdministration), "MedicationAdministration" },
                { typeof(Message), "Message" },
                { typeof(Observation), "Observation" },
                { typeof(Order), "Order" },
                { typeof(OrderResponse), "OrderResponse" },
                { typeof(Organization), "Organization" },
                { typeof(Patient), "Patient" },
                { typeof(Picture), "Picture" },
                { typeof(Practitioner), "Practitioner" },
                { typeof(Prescription), "Prescription" },
                { typeof(Problem), "Problem" },
                { typeof(Procedure), "Procedure" },
                { typeof(Profile), "Profile" },
                { typeof(Provenance), "Provenance" },
                { typeof(Questionnaire), "Questionnaire" },
                { typeof(SecurityEvent), "SecurityEvent" },
                { typeof(Specimen), "Specimen" },
                { typeof(Substance), "Substance" },
                { typeof(Test), "Test" },
                { typeof(ValueSet), "ValueSet" },
                { typeof(Visit), "Visit" },
                { typeof(Medication), "Medication" },
                { typeof(Appointment), "Appointment" },
                { typeof(Product), "Product" },
                { typeof(Food), "Food" },
                { typeof(Request), "Request" },
                { typeof(Admission), "Admission" },
                { typeof(AnatomicalLocation), "AnatomicalLocation" },
                { typeof(Person), "Person" },
                { typeof(InterestOfCare), "InterestOfCare" },
                { typeof(RelatedPerson), "RelatedPerson" },
            };
    }
}
