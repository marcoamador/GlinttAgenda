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
    /// Insurance or medical plan
    /// </summary>
    [FhirResource("Coverage")]
    public partial class Coverage : Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("CoveragePlanHolderComponent")]
        public partial class CoveragePlanHolderComponent : Element
        {
            /// <summary>
            /// PolicyHolder name
            /// </summary>
            public HumanName Name { get; set; }
            
            /// <summary>
            /// PolicyHolder address
            /// </summary>
            public Address Address { get; set; }
            
            /// <summary>
            /// PolicyHolder date of birth
            /// </summary>
            public Date Birthdate { get; set; }
            
        }
        
        
        /// <summary>
        /// An identifier for the plan issuer
        /// </summary>
        public ResourceReference Issuer { get; set; }
        
        /// <summary>
        /// Coverage start and end dates
        /// </summary>
        public Period Period { get; set; }
        
        /// <summary>
        /// Type of coverage
        /// </summary>
        public Coding Type { get; set; }
        
        /// <summary>
        /// The primary coverage ID
        /// </summary>
        public Identifier Identifier { get; set; }
        
        /// <summary>
        /// An identifier for the plan
        /// </summary>
        public Identifier Plan { get; set; }
        
        /// <summary>
        /// An identifier for the subsection of the plan
        /// </summary>
        public Identifier Subplan { get; set; }
        
        /// <summary>
        /// The dependent number
        /// </summary>
        public Integer Dependent { get; set; }
        
        /// <summary>
        /// The plan instance or sequence counter
        /// </summary>
        public Integer Sequence { get; set; }
        
        /// <summary>
        /// Planholder information
        /// </summary>
        public CoveragePlanHolderComponent PlanHolder { get; set; }
        
    }
    
}
