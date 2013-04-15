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
    /// Describes the set of data produced by a device
    /// </summary>
    [FhirResource("DeviceCapabilities")]
    public partial class DeviceCapabilities : Resource
    {
        /// <summary>
        /// The type of data produced by a device
        /// </summary>
        public enum DeviceDataType
        {
            Quantity,
            Range,
            Coding,
            String,
        }
        
        /// <summary>
        /// Conversion of DeviceDataTypefrom and into string
        /// <summary>
        public static class DeviceDataTypeHandling
        {
            public static bool TryParse(string value, out DeviceDataType result)
            {
                result = default(DeviceDataType);
                
                if( value=="Quantity")
                    result = DeviceDataType.Quantity;
                else if( value=="Range")
                    result = DeviceDataType.Range;
                else if( value=="Coding")
                    result = DeviceDataType.Coding;
                else if( value=="string")
                    result = DeviceDataType.String;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DeviceDataType value)
            {
                if( value==DeviceDataType.Quantity )
                    return "Quantity";
                else if( value==DeviceDataType.Range )
                    return "Range";
                else if( value==DeviceDataType.Coding )
                    return "Coding";
                else if( value==DeviceDataType.String )
                    return "string";
                else
                    throw new ArgumentException("Unrecognized DeviceDataType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceCapabilitiesCompartmentChannelComponent")]
        public partial class DeviceCapabilitiesCompartmentChannelComponent : Element
        {
            /// <summary>
            /// Describes the channel
            /// </summary>
            public CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Piece of data reported by device
            /// </summary>
            public List<DeviceCapabilitiesCompartmentChannelMetricComponent> Metric { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceCapabilitiesCompartmentChannelMetricFacetComponent")]
        public partial class DeviceCapabilitiesCompartmentChannelMetricFacetComponent : Element
        {
            /// <summary>
            /// Describes the facet
            /// </summary>
            public CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Used to link to data in device log
            /// </summary>
            public FhirString Key { get; set; }
            
            /// <summary>
            /// How to interpret this facet value
            /// </summary>
            public DeviceCapabilitiesCompartmentChannelMetricInfoComponent Info { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceCapabilitiesCompartmentComponent")]
        public partial class DeviceCapabilitiesCompartmentComponent : Element
        {
            /// <summary>
            /// Describes the compartment
            /// </summary>
            public CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Groups related data items
            /// </summary>
            public List<DeviceCapabilitiesCompartmentChannelComponent> Channel { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceCapabilitiesCompartmentChannelMetricInfoComponent")]
        public partial class DeviceCapabilitiesCompartmentChannelMetricInfoComponent : Element
        {
            /// <summary>
            /// Quantity | Coding | string
            /// </summary>
            public Code<DeviceCapabilities.DeviceDataType> Type { get; set; }
            
            /// <summary>
            /// Human Readable units of data value
            /// </summary>
            public FhirString Units { get; set; }
            
            /// <summary>
            /// UCUM units for data value
            /// </summary>
            public Code Ucum { get; set; }
            
            /// <summary>
            /// System for coding
            /// </summary>
            public FhirUri System { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceCapabilitiesCompartmentChannelMetricComponent")]
        public partial class DeviceCapabilitiesCompartmentChannelMetricComponent : Element
        {
            /// <summary>
            /// Describes the metrics
            /// </summary>
            public CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Used to link to data in device log
            /// </summary>
            public FhirString Key { get; set; }
            
            /// <summary>
            /// How to interpret this metric value
            /// </summary>
            public DeviceCapabilitiesCompartmentChannelMetricInfoComponent Info { get; set; }
            
            /// <summary>
            /// Additional clarifying or qualifiying data
            /// </summary>
            public List<DeviceCapabilitiesCompartmentChannelMetricFacetComponent> Facet { get; set; }
            
        }
        
        
        /// <summary>
        /// The name of this device
        /// </summary>
        public FhirString Name { get; set; }
        
        /// <summary>
        /// What kind of device this is
        /// </summary>
        public CodeableConcept Type { get; set; }
        
        /// <summary>
        /// Company that built the device
        /// </summary>
        public FhirString Manufacturer { get; set; }
        
        /// <summary>
        /// Identifies this particular device uniquely
        /// </summary>
        public ResourceReference Identity { get; set; }
        
        /// <summary>
        /// A medical-related subsystem of a medical device
        /// </summary>
        public List<DeviceCapabilitiesCompartmentComponent> Compartment { get; set; }
        
    }
    
}
