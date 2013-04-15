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
    /// Family History
    /// </summary>
    [FhirResource("FamilyHistory")]
    public partial class FamilyHistory : Resource
    {
        /// <summary>
        /// The nature of the relationship between the patient and the person with the condition
        /// </summary>
        public enum FamilialRelationship
        {
            Mother, // Mother
            Father, // Father
            Sister, // Sister
            Brother, // Brother
            MatUncle, // Maternal Uncle
            MatAunt, // Maternal Aunt
            MatGFather, // Maternal GrandFather
            MatGMother, // Maternal GrandMother
            PatUncle, // Paternal Uncle
            PatAunt, // Paternal Aunt
            PatGFather, // Paternal GrandFather
            PatGMother, // Paternal GrandMother
        }
        
        /// <summary>
        /// Conversion of FamilialRelationshipfrom and into string
        /// <summary>
        public static class FamilialRelationshipHandling
        {
            public static bool TryParse(string value, out FamilialRelationship result)
            {
                result = default(FamilialRelationship);
                
                if( value=="mother")
                    result = FamilialRelationship.Mother;
                else if( value=="father")
                    result = FamilialRelationship.Father;
                else if( value=="sister")
                    result = FamilialRelationship.Sister;
                else if( value=="brother")
                    result = FamilialRelationship.Brother;
                else if( value=="matUncle")
                    result = FamilialRelationship.MatUncle;
                else if( value=="matAunt")
                    result = FamilialRelationship.MatAunt;
                else if( value=="matGFather")
                    result = FamilialRelationship.MatGFather;
                else if( value=="matGMother")
                    result = FamilialRelationship.MatGMother;
                else if( value=="patUncle")
                    result = FamilialRelationship.PatUncle;
                else if( value=="patAunt")
                    result = FamilialRelationship.PatAunt;
                else if( value=="patGFather")
                    result = FamilialRelationship.PatGFather;
                else if( value=="patGMother")
                    result = FamilialRelationship.PatGMother;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(FamilialRelationship value)
            {
                if( value==FamilialRelationship.Mother )
                    return "mother";
                else if( value==FamilialRelationship.Father )
                    return "father";
                else if( value==FamilialRelationship.Sister )
                    return "sister";
                else if( value==FamilialRelationship.Brother )
                    return "brother";
                else if( value==FamilialRelationship.MatUncle )
                    return "matUncle";
                else if( value==FamilialRelationship.MatAunt )
                    return "matAunt";
                else if( value==FamilialRelationship.MatGFather )
                    return "matGFather";
                else if( value==FamilialRelationship.MatGMother )
                    return "matGMother";
                else if( value==FamilialRelationship.PatUncle )
                    return "patUncle";
                else if( value==FamilialRelationship.PatAunt )
                    return "patAunt";
                else if( value==FamilialRelationship.PatGFather )
                    return "patGFather";
                else if( value==FamilialRelationship.PatGMother )
                    return "patGMother";
                else
                    throw new ArgumentException("Unrecognized FamilialRelationship value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("FamilyHistoryRelationConditionComponent")]
        public partial class FamilyHistoryRelationConditionComponent : Element
        {
            /// <summary>
            /// The condition
            /// </summary>
            public CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Did the person die of this condition
            /// </summary>
            public FhirBoolean Fatal { get; set; }
            
            /// <summary>
            /// How old the person was when the condition manifested
            /// </summary>
            public Element Onset { get; set; }
            
            /// <summary>
            /// General notes
            /// </summary>
            public FhirString Note { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("FamilyHistoryRelationComponent")]
        public partial class FamilyHistoryRelationComponent : Element
        {
            /// <summary>
            /// The family member who had the condition
            /// </summary>
            public ResourceReference RelatedPerson { get; set; }
            
            /// <summary>
            /// Relationship to the subject
            /// </summary>
            public Code<FamilyHistory.FamilialRelationship> Relationship { get; set; }
            
            /// <summary>
            /// Is the person deceased
            /// </summary>
            public Element Deceased { get; set; }
            
            /// <summary>
            /// General note about the related person
            /// </summary>
            public FhirString Note { get; set; }
            
            /// <summary>
            /// The Condition that the related person had
            /// </summary>
            public List<FamilyHistoryRelationConditionComponent> Condition { get; set; }
            
        }
        
        
        /// <summary>
        /// Subject of this history
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// The relation
        /// </summary>
        public List<FamilyHistoryRelationComponent> Relation { get; set; }
        
    }
    
}
