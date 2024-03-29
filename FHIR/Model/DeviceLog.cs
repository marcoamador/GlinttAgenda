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
    /// A set of data produced by a device
    /// </summary>
    [FhirResource("DeviceLog")]
    public partial class DeviceLog : Resource
    {
        /// <summary>
        /// Flags that supply information about the status of a device reading
        /// </summary>
        public enum DeviceValueFlag
        {
            Ok, // the value is valid
            Ongoing, // An early estimate of value; measurement is still occurring
            Early, // An early estimate of value; processing is still occurring
            Questionable, // The observation value should be treated with care (there are reasons for doubting the accuracy of the current value)
            Calibrating, // The value has been generated while calibration is occurring
            Error, // the current conditions are invalid, and the value should not be used
            Unknown, // No observation value was available
            Test, // this is test data
            Demo, // this is demo data
            Under, // the value is under accurate measurement limits
            Over, // the value is over accurate measurement limits
            Alarm, // the value is associated with an active alarm condition
            AlarmOff, // the value would be associated with an active alarm, but alarms are turned off
        }
        
        /// <summary>
        /// Conversion of DeviceValueFlagfrom and into string
        /// <summary>
        public static class DeviceValueFlagHandling
        {
            public static bool TryParse(string value, out DeviceValueFlag result)
            {
                result = default(DeviceValueFlag);
                
                if( value=="ok")
                    result = DeviceValueFlag.Ok;
                else if( value=="ongoing")
                    result = DeviceValueFlag.Ongoing;
                else if( value=="early")
                    result = DeviceValueFlag.Early;
                else if( value=="questionable")
                    result = DeviceValueFlag.Questionable;
                else if( value=="calibrating")
                    result = DeviceValueFlag.Calibrating;
                else if( value=="error")
                    result = DeviceValueFlag.Error;
                else if( value=="unknown")
                    result = DeviceValueFlag.Unknown;
                else if( value=="test")
                    result = DeviceValueFlag.Test;
                else if( value=="demo")
                    result = DeviceValueFlag.Demo;
                else if( value=="under")
                    result = DeviceValueFlag.Under;
                else if( value=="over")
                    result = DeviceValueFlag.Over;
                else if( value=="alarm")
                    result = DeviceValueFlag.Alarm;
                else if( value=="alarm-off")
                    result = DeviceValueFlag.AlarmOff;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DeviceValueFlag value)
            {
                if( value==DeviceValueFlag.Ok )
                    return "ok";
                else if( value==DeviceValueFlag.Ongoing )
                    return "ongoing";
                else if( value==DeviceValueFlag.Early )
                    return "early";
                else if( value==DeviceValueFlag.Questionable )
                    return "questionable";
                else if( value==DeviceValueFlag.Calibrating )
                    return "calibrating";
                else if( value==DeviceValueFlag.Error )
                    return "error";
                else if( value==DeviceValueFlag.Unknown )
                    return "unknown";
                else if( value==DeviceValueFlag.Test )
                    return "test";
                else if( value==DeviceValueFlag.Demo )
                    return "demo";
                else if( value==DeviceValueFlag.Under )
                    return "under";
                else if( value==DeviceValueFlag.Over )
                    return "over";
                else if( value==DeviceValueFlag.Alarm )
                    return "alarm";
                else if( value==DeviceValueFlag.AlarmOff )
                    return "alarm-off";
                else
                    throw new ArgumentException("Unrecognized DeviceValueFlag value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceLogItemComponent")]
        public partial class DeviceLogItemComponent : Element
        {
            /// <summary>
            /// Reference to device capabilities declaration
            /// </summary>
            public FhirString Key { get; set; }
            
            /// <summary>
            /// The value of the data item, if available
            /// </summary>
            public FhirString Value { get; set; }
            
            /// <summary>
            /// Information about the quality of the data etc
            /// </summary>
            public List<Code<DeviceLog.DeviceValueFlag>> Flag { get; set; }
            
        }
        
        
        /// <summary>
        /// When the data values are reported
        /// </summary>
        public Instant Instant { get; set; }
        
        /// <summary>
        /// Explicit reference to the capabilities
        /// </summary>
        public ResourceReference Capabilities { get; set; }
        
        /// <summary>
        /// Subject of the measurement
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// An item of data
        /// </summary>
        public List<DeviceLogItemComponent> Item { get; set; }
        
    }
    
}
