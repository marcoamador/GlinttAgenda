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
    /// Group of multiple entities
    /// </summary>
    [FhirResource("Group")]
    public partial class Group : Resource
    {
        /// <summary>
        /// Types of resources that are part of group
        /// </summary>
        public enum GroupType
        {
            Person, // Group contains Person resources
            Animal, // Group contains Animal resources
            Device, // Group contains Device resources
            Medication, // Group contains Medication resources
            Food, // Group contains Food resources
        }
        
        /// <summary>
        /// Conversion of GroupTypefrom and into string
        /// <summary>
        public static class GroupTypeHandling
        {
            public static bool TryParse(string value, out GroupType result)
            {
                result = default(GroupType);
                
                if( value=="person")
                    result = GroupType.Person;
                else if( value=="animal")
                    result = GroupType.Animal;
                else if( value=="device")
                    result = GroupType.Device;
                else if( value=="medication")
                    result = GroupType.Medication;
                else if( value=="food")
                    result = GroupType.Food;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(GroupType value)
            {
                if( value==GroupType.Person )
                    return "person";
                else if( value==GroupType.Animal )
                    return "animal";
                else if( value==GroupType.Device )
                    return "device";
                else if( value==GroupType.Medication )
                    return "medication";
                else if( value==GroupType.Food )
                    return "food";
                else
                    throw new ArgumentException("Unrecognized GroupType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("GroupCharacteristicComponent")]
        public partial class GroupCharacteristicComponent : Element
        {
            /// <summary>
            /// Kind of characteristic
            /// </summary>
            public CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Value held by characteristic
            /// </summary>
            public Element Value { get; set; }
            
            /// <summary>
            /// Group includes or excludes
            /// </summary>
            public FhirBoolean Exclude { get; set; }
            
        }
        
        
        /// <summary>
        /// Unique id
        /// </summary>
        public Identifier Identifier { get; set; }
        
        /// <summary>
        /// Group Classification
        /// </summary>
        public Code<Group.GroupType> Type { get; set; }
        
        /// <summary>
        /// Descriptive or actual
        /// </summary>
        public FhirBoolean Actual { get; set; }
        
        /// <summary>
        /// Kind of Group members
        /// </summary>
        public CodeableConcept Code { get; set; }
        
        /// <summary>
        /// Label for Group
        /// </summary>
        public FhirString Name { get; set; }
        
        /// <summary>
        /// Number of members
        /// </summary>
        public Integer Quantity { get; set; }
        
        /// <summary>
        /// Trait of group members
        /// </summary>
        public List<GroupCharacteristicComponent> Characteristic { get; set; }
        
        /// <summary>
        /// Who is in group
        /// </summary>
        public List<ResourceReference> Member { get; set; }
        
    }
    
}
