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
    /// Description of an individual
    /// </summary>
    [FhirComposite("Demographics")]
    public partial class Demographics : Element
    {
        /// <summary>
        /// The gender of a person used for administrative purposes
        /// </summary>
        public enum AdministrativeGender
        {
            F, // Female
            M, // Male
            UN, // Undifferentiated
        }
        
        /// <summary>
        /// Conversion of AdministrativeGenderfrom and into string
        /// <summary>
        public static class AdministrativeGenderHandling
        {
            public static bool TryParse(string value, out AdministrativeGender result)
            {
                result = default(AdministrativeGender);
                
                if( value=="F")
                    result = AdministrativeGender.F;
                else if( value=="M")
                    result = AdministrativeGender.M;
                else if( value=="UN")
                    result = AdministrativeGender.UN;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(AdministrativeGender value)
            {
                if( value==AdministrativeGender.F )
                    return "F";
                else if( value==AdministrativeGender.M )
                    return "M";
                else if( value==AdministrativeGender.UN )
                    return "UN";
                else
                    throw new ArgumentException("Unrecognized AdministrativeGender value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// A value representing the person's method of expression of this language
        /// </summary>
        public enum LanguageAbilityMode
        {
            ESGN, // Expressed signed
            ESP, // Expressed spoken
            EWR, // Expressed written
            RSGN, // Received signed
            RSP, // Received spoken
            RWR, // Received written
        }
        
        /// <summary>
        /// Conversion of LanguageAbilityModefrom and into string
        /// <summary>
        public static class LanguageAbilityModeHandling
        {
            public static bool TryParse(string value, out LanguageAbilityMode result)
            {
                result = default(LanguageAbilityMode);
                
                if( value=="ESGN")
                    result = LanguageAbilityMode.ESGN;
                else if( value=="ESP")
                    result = LanguageAbilityMode.ESP;
                else if( value=="EWR")
                    result = LanguageAbilityMode.EWR;
                else if( value=="RSGN")
                    result = LanguageAbilityMode.RSGN;
                else if( value=="RSP")
                    result = LanguageAbilityMode.RSP;
                else if( value=="RWR")
                    result = LanguageAbilityMode.RWR;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(LanguageAbilityMode value)
            {
                if( value==LanguageAbilityMode.ESGN )
                    return "ESGN";
                else if( value==LanguageAbilityMode.ESP )
                    return "ESP";
                else if( value==LanguageAbilityMode.EWR )
                    return "EWR";
                else if( value==LanguageAbilityMode.RSGN )
                    return "RSGN";
                else if( value==LanguageAbilityMode.RSP )
                    return "RSP";
                else if( value==LanguageAbilityMode.RWR )
                    return "RWR";
                else
                    throw new ArgumentException("Unrecognized LanguageAbilityMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// A code that describes how well the language is spoken
        /// </summary>
        public enum LanguageAbilityProficiency
        {
            E, // Excellent
            F, // Fair
            G, // Good
            P, // Poor
        }
        
        /// <summary>
        /// Conversion of LanguageAbilityProficiencyfrom and into string
        /// <summary>
        public static class LanguageAbilityProficiencyHandling
        {
            public static bool TryParse(string value, out LanguageAbilityProficiency result)
            {
                result = default(LanguageAbilityProficiency);
                
                if( value=="E")
                    result = LanguageAbilityProficiency.E;
                else if( value=="F")
                    result = LanguageAbilityProficiency.F;
                else if( value=="G")
                    result = LanguageAbilityProficiency.G;
                else if( value=="P")
                    result = LanguageAbilityProficiency.P;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(LanguageAbilityProficiency value)
            {
                if( value==LanguageAbilityProficiency.E )
                    return "E";
                else if( value==LanguageAbilityProficiency.F )
                    return "F";
                else if( value==LanguageAbilityProficiency.G )
                    return "G";
                else if( value==LanguageAbilityProficiency.P )
                    return "P";
                else
                    throw new ArgumentException("Unrecognized LanguageAbilityProficiency value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DemographicsLanguageComponent")]
        public partial class DemographicsLanguageComponent : Element
        {
            /// <summary>
            /// Language with optional region
            /// </summary>
            public CodeableConcept Language { get; set; }
            
            /// <summary>
            /// Language method of expression
            /// </summary>
            public CodeableConcept Mode { get; set; }
            
            /// <summary>
            /// Proficiency level of the language
            /// </summary>
            public CodeableConcept ProficiencyLevel { get; set; }
            
            /// <summary>
            /// Language preference indicator
            /// </summary>
            public FhirBoolean Preference { get; set; }
            
        }
        
        
        /// <summary>
        /// An identifier for this individual
        /// </summary>
        public List<Identifier> Identifier { get; set; }
        
        /// <summary>
        /// A name associated with the individual
        /// </summary>
        public List<HumanName> Name { get; set; }
        
        /// <summary>
        /// A contact detail for the individual
        /// </summary>
        public List<Contact> Telecom { get; set; }
        
        /// <summary>
        /// Gender for administrative purposes
        /// </summary>
        public Coding Gender { get; set; }
        
        /// <summary>
        /// The birth date for the individual
        /// </summary>
        public FhirDateTime BirthDate { get; set; }
        
        /// <summary>
        /// Indicates if the individual is deceased or not
        /// </summary>
        public FhirBoolean Deceased { get; set; }
        
        /// <summary>
        /// One or more addresses for the individual
        /// </summary>
        public List<Address> Address { get; set; }
        
        /// <summary>
        /// Image of the person
        /// </summary>
        public List<ResourceReference> Photo { get; set; }
        
        /// <summary>
        /// Marital (civil) status of a person
        /// </summary>
        public CodeableConcept MaritalStatus { get; set; }
        
        /// <summary>
        /// The person's  proficiency level of a language
        /// </summary>
        public List<DemographicsLanguageComponent> Language { get; set; }
        
    }
    
}
