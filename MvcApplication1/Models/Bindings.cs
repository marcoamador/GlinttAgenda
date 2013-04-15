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
    /// Either yes or no, true or false
    /// </summary>
    public enum BooleanYesNo
    {
        Yes, // TRUE
        No, // FALSE
    }
    
    /// <summary>
    /// Conversion of BooleanYesNofrom and into string
    /// <summary>
    public static class BooleanYesNoHandling
    {
        public static bool TryParse(string value, out BooleanYesNo result)
        {
            result = default(BooleanYesNo);
            
            if( value=="yes")
                result = BooleanYesNo.Yes;
            else if( value=="no")
                result = BooleanYesNo.No;
            else
                return false;
            
            return true;
        }
        
        public static string ToString(BooleanYesNo value)
        {
            if( value==BooleanYesNo.Yes )
                return "yes";
            else if( value==BooleanYesNo.No )
                return "no";
            else
                throw new ArgumentException("Unrecognized BooleanYesNo value: " + value.ToString());
        }
    }
    
    /// <summary>
    /// Used to specify why the normally expected content of the data element is missing
    /// </summary>
    public enum DataAbsentReason
    {
        Unknown, // The value is not known
        Asked, // The source human does not know the value
        Temp, // There is reason to expect (from the workflow) that the value may become known
        Notasked, // The workflow didn't lead to this value being known
        Masked, // The information is not available due to security, privacy or related reasons
        Unsupported, // The source system wasn't capable of supporting this element
        Astext, // The content of the data is represented as text
        Error, // Some system or workflow process error means that the information is not available
    }
    
    /// <summary>
    /// Conversion of DataAbsentReasonfrom and into string
    /// <summary>
    public static class DataAbsentReasonHandling
    {
        public static bool TryParse(string value, out DataAbsentReason result)
        {
            result = default(DataAbsentReason);
            
            if( value=="unknown")
                result = DataAbsentReason.Unknown;
            else if( value=="asked")
                result = DataAbsentReason.Asked;
            else if( value=="temp")
                result = DataAbsentReason.Temp;
            else if( value=="notasked")
                result = DataAbsentReason.Notasked;
            else if( value=="masked")
                result = DataAbsentReason.Masked;
            else if( value=="unsupported")
                result = DataAbsentReason.Unsupported;
            else if( value=="astext")
                result = DataAbsentReason.Astext;
            else if( value=="error")
                result = DataAbsentReason.Error;
            else
                return false;
            
            return true;
        }
        
        public static string ToString(DataAbsentReason value)
        {
            if( value==DataAbsentReason.Unknown )
                return "unknown";
            else if( value==DataAbsentReason.Asked )
                return "asked";
            else if( value==DataAbsentReason.Temp )
                return "temp";
            else if( value==DataAbsentReason.Notasked )
                return "notasked";
            else if( value==DataAbsentReason.Masked )
                return "masked";
            else if( value==DataAbsentReason.Unsupported )
                return "unsupported";
            else if( value==DataAbsentReason.Astext )
                return "astext";
            else if( value==DataAbsentReason.Error )
                return "error";
            else
                throw new ArgumentException("Unrecognized DataAbsentReason value: " + value.ToString());
        }
    }
    
    /// <summary>
    /// Codes providing the status of an observation
    /// </summary>
    public enum ObservationStatus
    {
        Registered, // The existence of the observation is registered, but there is no result yet available
        Interim, // This is an initial or interim observation: data may be incomplete or unverified
        Final, // The observation is complete and verified by an authorised person
        Amended, // The observation has been modified subsequent to being Final, and is complete and verified by an authorised person
        Cancelled, // The observation is unavailable because the measurement was not started or not completed (also sometimes called "aborted")
        Withdrawn, // The observation has been withdrawn following previous Final release
    }
    
    /// <summary>
    /// Conversion of ObservationStatusfrom and into string
    /// <summary>
    public static class ObservationStatusHandling
    {
        public static bool TryParse(string value, out ObservationStatus result)
        {
            result = default(ObservationStatus);
            
            if( value=="registered")
                result = ObservationStatus.Registered;
            else if( value=="interim")
                result = ObservationStatus.Interim;
            else if( value=="final")
                result = ObservationStatus.Final;
            else if( value=="amended")
                result = ObservationStatus.Amended;
            else if( value=="cancelled")
                result = ObservationStatus.Cancelled;
            else if( value=="withdrawn")
                result = ObservationStatus.Withdrawn;
            else
                return false;
            
            return true;
        }
        
        public static string ToString(ObservationStatus value)
        {
            if( value==ObservationStatus.Registered )
                return "registered";
            else if( value==ObservationStatus.Interim )
                return "interim";
            else if( value==ObservationStatus.Final )
                return "final";
            else if( value==ObservationStatus.Amended )
                return "amended";
            else if( value==ObservationStatus.Cancelled )
                return "cancelled";
            else if( value==ObservationStatus.Withdrawn )
                return "withdrawn";
            else
                throw new ArgumentException("Unrecognized ObservationStatus value: " + value.ToString());
        }
    }
    
    /// <summary>
    /// Data types allowed to be used for search parameters
    /// </summary>
    public enum SearchParamType
    {
        Integer, // Search parameter must be a simple whole number
        String, // Search parameter is a simple string, like a name part (search usually functions on partial matches)
        Text, // Search parameter is on a long string (i.e. a text filter type search)
        Date, // Search parameter is on a date (and should support -before and -after variants). The date format is the standard XML format, though other formats may be supported
        Token, // Search parameter is on a fixed value string (i.e. search has an exact match)
        Qtoken, // Search parameter is a pair of fixed value strings, namespace and value, separated by a "#". The namespace is usually a uri, such as one of the defined code systems and is optional when searching
    }
    
    /// <summary>
    /// Conversion of SearchParamTypefrom and into string
    /// <summary>
    public static class SearchParamTypeHandling
    {
        public static bool TryParse(string value, out SearchParamType result)
        {
            result = default(SearchParamType);
            
            if( value=="integer")
                result = SearchParamType.Integer;
            else if( value=="string")
                result = SearchParamType.String;
            else if( value=="text")
                result = SearchParamType.Text;
            else if( value=="date")
                result = SearchParamType.Date;
            else if( value=="token")
                result = SearchParamType.Token;
            else if( value=="qtoken")
                result = SearchParamType.Qtoken;
            else
                return false;
            
            return true;
        }
        
        public static string ToString(SearchParamType value)
        {
            if( value==SearchParamType.Integer )
                return "integer";
            else if( value==SearchParamType.String )
                return "string";
            else if( value==SearchParamType.Text )
                return "text";
            else if( value==SearchParamType.Date )
                return "date";
            else if( value==SearchParamType.Token )
                return "token";
            else if( value==SearchParamType.Qtoken )
                return "qtoken";
            else
                throw new ArgumentException("Unrecognized SearchParamType value: " + value.ToString());
        }
    }
    
    /// <summary>
    /// How repeating parameters are handled for the parameter type
    /// </summary>
    public enum SearchRepeatBehavior
    {
        Single, // The search parameter may only occur once
        Union, // When the search parameter occurs more than once, match resources with any of the values
        Intersection, // When the search parameter occurs more than once, match resources with all of the values
    }
    
    /// <summary>
    /// Conversion of SearchRepeatBehaviorfrom and into string
    /// <summary>
    public static class SearchRepeatBehaviorHandling
    {
        public static bool TryParse(string value, out SearchRepeatBehavior result)
        {
            result = default(SearchRepeatBehavior);
            
            if( value=="single")
                result = SearchRepeatBehavior.Single;
            else if( value=="union")
                result = SearchRepeatBehavior.Union;
            else if( value=="intersection")
                result = SearchRepeatBehavior.Intersection;
            else
                return false;
            
            return true;
        }
        
        public static string ToString(SearchRepeatBehavior value)
        {
            if( value==SearchRepeatBehavior.Single )
                return "single";
            else if( value==SearchRepeatBehavior.Union )
                return "union";
            else if( value==SearchRepeatBehavior.Intersection )
                return "intersection";
            else
                throw new ArgumentException("Unrecognized SearchRepeatBehavior value: " + value.ToString());
        }
    }
    
    /// <summary>
    /// List of all supported FHIR Resources
    /// </summary>
    public enum ResourceType
    {
        Resource, // The Resource resource
        CarePlan, // The CarePlan resource
        Category, // The Category resource
        Conformance, // The Conformance resource
        Coverage, // The Coverage resource
        Device, // The Device resource
        DeviceCapabilities, // The DeviceCapabilities resource
        DeviceLog, // The DeviceLog resource
        DeviceObservation, // The DeviceObservation resource
        DiagnosticReport, // The DiagnosticReport resource
        Document, // The Document resource
        DocumentReference, // The DocumentReference resource
        Encounter, // The Encounter resource
        Group, // The Group resource
        ImagingStudy, // The ImagingStudy resource
        Immunization, // The Immunization resource
        IssueReport, // The IssueReport resource
        List, // The List resource
        Location, // The Location resource
        MedicationAdministration, // The MedicationAdministration resource
        Message, // The Message resource
        Observation, // The Observation resource
        Order, // The Order resource
        OrderResponse, // The OrderResponse resource
        Organization, // The Organization resource
        Patient, // The Patient resource
        Picture, // The Picture resource
        Prescription, // The Prescription resource
        Problem, // The Problem resource
        Profile, // The Profile resource
        Provenance, // The Provenance resource
        Provider, // The Provider resource
        Questionnaire, // The Questionnaire resource
        SecurityEvent, // The SecurityEvent resource
        Test, // The Test resource
        ValueSet, // The ValueSet resource
        Product, // The Product resource
        Food, // The Food resource
        Admission, // The Admission resource
        Request, // The Request resource
        Procedure, // The Procedure resource
        Substance, // The Substance resource
        InterestOfCare, // The InterestOfCare resource
        RelatedPerson, // The RelatedPerson resource
        Medication, // The Medication resource
        Specimen, // The Specimen resource
        Appointment, // The Appointment resource
        AdverseReaction, // The AdverseReaction resource
        AnatomicalLocation, // The AnatomicalLocation resource
        Person, // The Person resource
    }
    
    /// <summary>
    /// Conversion of ResourceTypefrom and into string
    /// <summary>
    public static class ResourceTypeHandling
    {
        public static bool TryParse(string value, out ResourceType result)
        {
            result = default(ResourceType);
            
            if( value=="Resource")
                result = ResourceType.Resource;
            else if( value=="CarePlan")
                result = ResourceType.CarePlan;
            else if( value=="Category")
                result = ResourceType.Category;
            else if( value=="Conformance")
                result = ResourceType.Conformance;
            else if( value=="Coverage")
                result = ResourceType.Coverage;
            else if( value=="Device")
                result = ResourceType.Device;
            else if( value=="DeviceCapabilities")
                result = ResourceType.DeviceCapabilities;
            else if( value=="DeviceLog")
                result = ResourceType.DeviceLog;
            else if( value=="DeviceObservation")
                result = ResourceType.DeviceObservation;
            else if( value=="DiagnosticReport")
                result = ResourceType.DiagnosticReport;
            else if( value=="Document")
                result = ResourceType.Document;
            else if( value=="DocumentReference")
                result = ResourceType.DocumentReference;
            else if( value=="Encounter")
                result = ResourceType.Encounter;
            else if( value=="Group")
                result = ResourceType.Group;
            else if( value=="ImagingStudy")
                result = ResourceType.ImagingStudy;
            else if( value=="Immunization")
                result = ResourceType.Immunization;
            else if( value=="IssueReport")
                result = ResourceType.IssueReport;
            else if( value=="List")
                result = ResourceType.List;
            else if( value=="Location")
                result = ResourceType.Location;
            else if( value=="MedicationAdministration")
                result = ResourceType.MedicationAdministration;
            else if( value=="Message")
                result = ResourceType.Message;
            else if( value=="Observation")
                result = ResourceType.Observation;
            else if( value=="Order")
                result = ResourceType.Order;
            else if( value=="OrderResponse")
                result = ResourceType.OrderResponse;
            else if( value=="Organization")
                result = ResourceType.Organization;
            else if( value=="Patient")
                result = ResourceType.Patient;
            else if( value=="Picture")
                result = ResourceType.Picture;
            else if( value=="Prescription")
                result = ResourceType.Prescription;
            else if( value=="Problem")
                result = ResourceType.Problem;
            else if( value=="Profile")
                result = ResourceType.Profile;
            else if( value=="Provenance")
                result = ResourceType.Provenance;
            else if( value=="Provider")
                result = ResourceType.Provider;
            else if( value=="Questionnaire")
                result = ResourceType.Questionnaire;
            else if( value=="SecurityEvent")
                result = ResourceType.SecurityEvent;
            else if( value=="Test")
                result = ResourceType.Test;
            else if( value=="ValueSet")
                result = ResourceType.ValueSet;
            else if( value=="Product")
                result = ResourceType.Product;
            else if( value=="Food")
                result = ResourceType.Food;
            else if( value=="Admission")
                result = ResourceType.Admission;
            else if( value=="Request")
                result = ResourceType.Request;
            else if( value=="Procedure")
                result = ResourceType.Procedure;
            else if( value=="Substance")
                result = ResourceType.Substance;
            else if( value=="InterestOfCare")
                result = ResourceType.InterestOfCare;
            else if( value=="RelatedPerson")
                result = ResourceType.RelatedPerson;
            else if( value=="Medication")
                result = ResourceType.Medication;
            else if( value=="Specimen")
                result = ResourceType.Specimen;
            else if( value=="Appointment")
                result = ResourceType.Appointment;
            else if( value=="AdverseReaction")
                result = ResourceType.AdverseReaction;
            else if( value=="AnatomicalLocation")
                result = ResourceType.AnatomicalLocation;
            else if( value=="Person")
                result = ResourceType.Person;
            else
                return false;
            
            return true;
        }
        
        public static string ToString(ResourceType value)
        {
            if( value==ResourceType.Resource )
                return "Resource";
            else if( value==ResourceType.CarePlan )
                return "CarePlan";
            else if( value==ResourceType.Category )
                return "Category";
            else if( value==ResourceType.Conformance )
                return "Conformance";
            else if( value==ResourceType.Coverage )
                return "Coverage";
            else if( value==ResourceType.Device )
                return "Device";
            else if( value==ResourceType.DeviceCapabilities )
                return "DeviceCapabilities";
            else if( value==ResourceType.DeviceLog )
                return "DeviceLog";
            else if( value==ResourceType.DeviceObservation )
                return "DeviceObservation";
            else if( value==ResourceType.DiagnosticReport )
                return "DiagnosticReport";
            else if( value==ResourceType.Document )
                return "Document";
            else if( value==ResourceType.DocumentReference )
                return "DocumentReference";
            else if( value==ResourceType.Encounter )
                return "Encounter";
            else if( value==ResourceType.Group )
                return "Group";
            else if( value==ResourceType.ImagingStudy )
                return "ImagingStudy";
            else if( value==ResourceType.Immunization )
                return "Immunization";
            else if( value==ResourceType.IssueReport )
                return "IssueReport";
            else if( value==ResourceType.List )
                return "List";
            else if( value==ResourceType.Location )
                return "Location";
            else if( value==ResourceType.MedicationAdministration )
                return "MedicationAdministration";
            else if( value==ResourceType.Message )
                return "Message";
            else if( value==ResourceType.Observation )
                return "Observation";
            else if( value==ResourceType.Order )
                return "Order";
            else if( value==ResourceType.OrderResponse )
                return "OrderResponse";
            else if( value==ResourceType.Organization )
                return "Organization";
            else if( value==ResourceType.Patient )
                return "Patient";
            else if( value==ResourceType.Picture )
                return "Picture";
            else if( value==ResourceType.Prescription )
                return "Prescription";
            else if( value==ResourceType.Problem )
                return "Problem";
            else if( value==ResourceType.Profile )
                return "Profile";
            else if( value==ResourceType.Provenance )
                return "Provenance";
            else if( value==ResourceType.Provider )
                return "Provider";
            else if( value==ResourceType.Questionnaire )
                return "Questionnaire";
            else if( value==ResourceType.SecurityEvent )
                return "SecurityEvent";
            else if( value==ResourceType.Test )
                return "Test";
            else if( value==ResourceType.ValueSet )
                return "ValueSet";
            else if( value==ResourceType.Product )
                return "Product";
            else if( value==ResourceType.Food )
                return "Food";
            else if( value==ResourceType.Admission )
                return "Admission";
            else if( value==ResourceType.Request )
                return "Request";
            else if( value==ResourceType.Procedure )
                return "Procedure";
            else if( value==ResourceType.Substance )
                return "Substance";
            else if( value==ResourceType.InterestOfCare )
                return "InterestOfCare";
            else if( value==ResourceType.RelatedPerson )
                return "RelatedPerson";
            else if( value==ResourceType.Medication )
                return "Medication";
            else if( value==ResourceType.Specimen )
                return "Specimen";
            else if( value==ResourceType.Appointment )
                return "Appointment";
            else if( value==ResourceType.AdverseReaction )
                return "AdverseReaction";
            else if( value==ResourceType.AnatomicalLocation )
                return "AnatomicalLocation";
            else if( value==ResourceType.Person )
                return "Person";
            else
                throw new ArgumentException("Unrecognized ResourceType value: " + value.ToString());
        }
    }
    
}
