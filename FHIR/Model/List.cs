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
    /// Information summarized from a list of other resources
    /// </summary>
    [FhirResource("List")]
    public partial class List : Resource
    {
        /// <summary>
        /// The processing mode that applies to this list
        /// </summary>
        public enum ListMode
        {
            Working, // This list is the master list, maintained in an ongoing fashion with regular updates as the real world list it is tracking changes
            Snapshot, // This list was prepared as a snapshot. It should not be assumed to be current
            Changes, // The list is prepared as a statement of changes that have been made or recommended
        }
        
        /// <summary>
        /// Conversion of ListModefrom and into string
        /// <summary>
        public static class ListModeHandling
        {
            public static bool TryParse(string value, out ListMode result)
            {
                result = default(ListMode);
                
                if( value=="working")
                    result = ListMode.Working;
                else if( value=="snapshot")
                    result = ListMode.Snapshot;
                else if( value=="changes")
                    result = ListMode.Changes;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ListMode value)
            {
                if( value==ListMode.Working )
                    return "working";
                else if( value==ListMode.Snapshot )
                    return "snapshot";
                else if( value==ListMode.Changes )
                    return "changes";
                else
                    throw new ArgumentException("Unrecognized ListMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ListEntryComponent")]
        public partial class ListEntryComponent : Element
        {
            /// <summary>
            /// Workflow information about this item
            /// </summary>
            public List<CodeableConcept> Flag { get; set; }
            
            /// <summary>
            /// If this item is actually marked as deleted
            /// </summary>
            public FhirBoolean Deleted { get; set; }
            
            /// <summary>
            /// Actual entry
            /// </summary>
            public ResourceReference Item { get; set; }
            
        }
        
        
        /// <summary>
        /// What the purpose of this list is
        /// </summary>
        public CodeableConcept Code { get; set; }
        
        /// <summary>
        /// Source of the list
        /// </summary>
        public ResourceReference Source { get; set; }
        
        /// <summary>
        /// When the list was prepared
        /// </summary>
        public FhirDateTime Date { get; set; }
        
        /// <summary>
        /// Whether items in the list have a meaningful order
        /// </summary>
        public FhirBoolean Ordered { get; set; }
        
        /// <summary>
        /// working | snapshot | changes
        /// </summary>
        public Code<List.ListMode> Mode { get; set; }
        
        /// <summary>
        /// Entries in the list
        /// </summary>
        public List<ListEntryComponent> Entry { get; set; }
        
        /// <summary>
        /// Why list is empty
        /// </summary>
        public CodeableConcept EmptyReason { get; set; }
        
    }
    
}
