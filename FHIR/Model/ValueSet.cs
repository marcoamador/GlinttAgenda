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
    /// Value Set - a set of defined codes that may be bound to a context
    /// </summary>
    [FhirResource("ValueSet")]
    public partial class ValueSet : Resource
    {
        /// <summary>
        /// The way in which the code is selected
        /// </summary>
        public enum CodeSelectionMode
        {
            Code, // Only this code is selected
            Children, // Only the immediate children (codes with a is_a relationship) are selected, but not this code itself
            Descendants, // All descendants of this code are selected, but not this code itself
            All, // This code and any descendants are selected
        }
        
        /// <summary>
        /// Conversion of CodeSelectionModefrom and into string
        /// <summary>
        public static class CodeSelectionModeHandling
        {
            public static bool TryParse(string value, out CodeSelectionMode result)
            {
                result = default(CodeSelectionMode);
                
                if( value=="code")
                    result = CodeSelectionMode.Code;
                else if( value=="children")
                    result = CodeSelectionMode.Children;
                else if( value=="descendants")
                    result = CodeSelectionMode.Descendants;
                else if( value=="all")
                    result = CodeSelectionMode.All;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(CodeSelectionMode value)
            {
                if( value==CodeSelectionMode.Code )
                    return "code";
                else if( value==CodeSelectionMode.Children )
                    return "children";
                else if( value==CodeSelectionMode.Descendants )
                    return "descendants";
                else if( value==CodeSelectionMode.All )
                    return "all";
                else
                    throw new ArgumentException("Unrecognized CodeSelectionMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The lifecycle status of a Value Set
        /// </summary>
        public enum ValueSetStatus
        {
            Draft, // This valueset is still under development
            Testing, // This valueset was authored for testing purposes (or education/evaluation/evangelisation)
            Review, // This valueset is undergoing review to check that it is ready for production use
            Production, // This valueset is ready for use in production systems
            Withdrawn, // This valueset has been withdrawn and should no longer be used
            Superseded, // This valueset has been replaced and a different valueset should be used in its place
        }
        
        /// <summary>
        /// Conversion of ValueSetStatusfrom and into string
        /// <summary>
        public static class ValueSetStatusHandling
        {
            public static bool TryParse(string value, out ValueSetStatus result)
            {
                result = default(ValueSetStatus);
                
                if( value=="draft")
                    result = ValueSetStatus.Draft;
                else if( value=="testing")
                    result = ValueSetStatus.Testing;
                else if( value=="review")
                    result = ValueSetStatus.Review;
                else if( value=="production")
                    result = ValueSetStatus.Production;
                else if( value=="withdrawn")
                    result = ValueSetStatus.Withdrawn;
                else if( value=="superseded")
                    result = ValueSetStatus.Superseded;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ValueSetStatus value)
            {
                if( value==ValueSetStatus.Draft )
                    return "draft";
                else if( value==ValueSetStatus.Testing )
                    return "testing";
                else if( value==ValueSetStatus.Review )
                    return "review";
                else if( value==ValueSetStatus.Production )
                    return "production";
                else if( value==ValueSetStatus.Withdrawn )
                    return "withdrawn";
                else if( value==ValueSetStatus.Superseded )
                    return "superseded";
                else
                    throw new ArgumentException("Unrecognized ValueSetStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The kind of operation to perform as part of a property based filter
        /// </summary>
        public enum FilterOperator
        {
            Equal, // The property value has the concept specified by the value
            IsA, // The property value has a concept that has an is_a relationship with the value
            IsNotA, // The property value has a concept that does not have an is_a relationship with the value
            Regex, // The property value representation matches the regex specified in the value
        }
        
        /// <summary>
        /// Conversion of FilterOperatorfrom and into string
        /// <summary>
        public static class FilterOperatorHandling
        {
            public static bool TryParse(string value, out FilterOperator result)
            {
                result = default(FilterOperator);
                
                if( value=="=")
                    result = FilterOperator.Equal;
                else if( value=="is_a")
                    result = FilterOperator.IsA;
                else if( value=="is_not_a")
                    result = FilterOperator.IsNotA;
                else if( value=="regex")
                    result = FilterOperator.Regex;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(FilterOperator value)
            {
                if( value==FilterOperator.Equal )
                    return "=";
                else if( value==FilterOperator.IsA )
                    return "is_a";
                else if( value==FilterOperator.IsNotA )
                    return "is_not_a";
                else if( value==FilterOperator.Regex )
                    return "regex";
                else
                    throw new ArgumentException("Unrecognized FilterOperator value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConceptSetComponent")]
        public partial class ConceptSetComponent : Element
        {
            /// <summary>
            /// The system the codes come from
            /// </summary>
            public FhirUri System { get; set; }
            
            /// <summary>
            /// Specific version of the code system referred to
            /// </summary>
            public FhirString Version { get; set; }
            
            /// <summary>
            /// code | children | descendants | all
            /// </summary>
            public Code<ValueSet.CodeSelectionMode> Mode { get; set; }
            
            /// <summary>
            /// Code or concept
            /// </summary>
            public List<Code> Code { get; set; }
            
            /// <summary>
            /// Select codes/concepts by their properties
            /// </summary>
            public List<ConceptSetFilterComponent> Filter { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ConceptSetFilterComponent")]
        public partial class ConceptSetFilterComponent : Element
        {
            /// <summary>
            /// A property defined by the code system
            /// </summary>
            public Code Property { get; set; }
            
            /// <summary>
            /// = | is_a | is_not_a | regex
            /// </summary>
            public Code<ValueSet.FilterOperator> Op { get; set; }
            
            /// <summary>
            /// Code from the system, or regex criteria
            /// </summary>
            public Code Value { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("AuthorComponent")]
        public partial class AuthorComponent : Element
        {
            /// <summary>
            /// Name of the recognized author
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// How the author contributed
            /// </summary>
            public FhirString Role { get; set; }
            
            /// <summary>
            /// Contact information of the author
            /// </summary>
            public List<Contact> Telecom { get; set; }
            
        }
        
        
        /// <summary>
        /// Informal name for this value set
        /// </summary>
        public FhirString Name { get; set; }
        
        /// <summary>
        /// (Organization or individual)
        /// </summary>
        public List<AuthorComponent> Author { get; set; }
        
        /// <summary>
        /// Human language description of the value set
        /// </summary>
        public FhirString Description { get; set; }
        
        /// <summary>
        /// draft | testing | production | withdrawn | superseded
        /// </summary>
        public Code<ValueSet.ValueSetStatus> Status { get; set; }
        
        /// <summary>
        /// Date for given status
        /// </summary>
        public FhirDateTime Date { get; set; }
        
        /// <summary>
        /// Logical id to reference this value set
        /// </summary>
        public FhirString Identifier { get; set; }
        
        /// <summary>
        /// Logical id for this version of the value set
        /// </summary>
        public FhirString Version { get; set; }
        
        /// <summary>
        /// Can replace these value sets when profiling
        /// </summary>
        public List<FhirUri> Restricts { get; set; }
        
        /// <summary>
        /// Import the contents of another value set
        /// </summary>
        public List<FhirUri> Import { get; set; }
        
        /// <summary>
        /// Include one or more codes from a code system
        /// </summary>
        public List<ConceptSetComponent> Include { get; set; }
        
        /// <summary>
        /// Explicitly exclude codes
        /// </summary>
        public List<ConceptSetComponent> Exclude { get; set; }
        
    }
    
}
