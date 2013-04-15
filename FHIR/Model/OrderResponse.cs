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
    /// A Response to an order
    /// </summary>
    [FhirResource("OrderResponse")]
    public partial class OrderResponse : Resource
    {
        /// <summary>
        /// The status of the response to an order
        /// </summary>
        public enum OrderOutcomeCode
        {
            Pending,
            Review,
            Rejected,
            Error,
            Accepted,
            Cancelled,
            Aborted,
            Complete,
        }
        
        /// <summary>
        /// Conversion of OrderOutcomeCodefrom and into string
        /// <summary>
        public static class OrderOutcomeCodeHandling
        {
            public static bool TryParse(string value, out OrderOutcomeCode result)
            {
                result = default(OrderOutcomeCode);
                
                if( value=="pending")
                    result = OrderOutcomeCode.Pending;
                else if( value=="review")
                    result = OrderOutcomeCode.Review;
                else if( value=="rejected")
                    result = OrderOutcomeCode.Rejected;
                else if( value=="error")
                    result = OrderOutcomeCode.Error;
                else if( value=="accepted")
                    result = OrderOutcomeCode.Accepted;
                else if( value=="cancelled")
                    result = OrderOutcomeCode.Cancelled;
                else if( value=="aborted")
                    result = OrderOutcomeCode.Aborted;
                else if( value=="complete")
                    result = OrderOutcomeCode.Complete;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(OrderOutcomeCode value)
            {
                if( value==OrderOutcomeCode.Pending )
                    return "pending";
                else if( value==OrderOutcomeCode.Review )
                    return "review";
                else if( value==OrderOutcomeCode.Rejected )
                    return "rejected";
                else if( value==OrderOutcomeCode.Error )
                    return "error";
                else if( value==OrderOutcomeCode.Accepted )
                    return "accepted";
                else if( value==OrderOutcomeCode.Cancelled )
                    return "cancelled";
                else if( value==OrderOutcomeCode.Aborted )
                    return "aborted";
                else if( value==OrderOutcomeCode.Complete )
                    return "complete";
                else
                    throw new ArgumentException("Unrecognized OrderOutcomeCode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The order this is a response to
        /// </summary>
        public ResourceReference Request { get; set; }
        
        /// <summary>
        /// When the response was made
        /// </summary>
        public FhirDateTime Date { get; set; }
        
        /// <summary>
        /// Who made the rResponse
        /// </summary>
        public ResourceReference Who { get; set; }
        
        /// <summary>
        /// If required by policy
        /// </summary>
        public ResourceReference Authority { get; set; }
        
        /// <summary>
        /// How much the request will/did cost
        /// </summary>
        public Money Cost { get; set; }
        
        /// <summary>
        /// The status of the response
        /// </summary>
        public Code<OrderResponse.OrderOutcomeCode> Code { get; set; }
        
        /// <summary>
        /// Additional description of the response
        /// </summary>
        public FhirString Description { get; set; }
        
        /// <summary>
        /// Details of the outcome of performing the order
        /// </summary>
        public List<ResourceReference> Fulfillment { get; set; }
        
    }
    
}
