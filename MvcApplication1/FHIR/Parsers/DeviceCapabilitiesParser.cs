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

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for DeviceCapabilities instances
    /// </summary>
    internal static partial class DeviceCapabilitiesParser
    {
        /// <summary>
        /// Parse DeviceCapabilities
        /// </summary>
        public static DeviceCapabilities ParseDeviceCapabilities(IFhirReader reader, ErrorList errors, DeviceCapabilities existingInstance = null )
        {
            DeviceCapabilities result = existingInstance != null ? existingInstance : new DeviceCapabilities();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element language
                    else if( ParserUtils.IsAtFhirElement(reader, "language") )
                        result.Language = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element text
                    else if( ParserUtils.IsAtFhirElement(reader, "text") )
                        result.Text = NarrativeParser.ParseNarrative(reader, errors);
                    
                    // Parse element contained
                    else if( ParserUtils.IsAtFhirElement(reader, "contained") )
                    {
                        result.Contained = new List<Resource>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "contained") )
                            result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element manufacturer
                    else if( ParserUtils.IsAtFhirElement(reader, "manufacturer") )
                        result.Manufacturer = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element compartment
                    else if( ParserUtils.IsAtFhirElement(reader, "compartment") )
                    {
                        result.Compartment = new List<DeviceCapabilities.DeviceCapabilitiesCompartmentComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "compartment") )
                            result.Compartment.Add(DeviceCapabilitiesParser.ParseDeviceCapabilitiesCompartmentComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse DeviceCapabilitiesCompartmentChannelComponent
        /// </summary>
        public static DeviceCapabilities.DeviceCapabilitiesCompartmentChannelComponent ParseDeviceCapabilitiesCompartmentChannelComponent(IFhirReader reader, ErrorList errors, DeviceCapabilities.DeviceCapabilitiesCompartmentChannelComponent existingInstance = null )
        {
            DeviceCapabilities.DeviceCapabilitiesCompartmentChannelComponent result = existingInstance != null ? existingInstance : new DeviceCapabilities.DeviceCapabilitiesCompartmentChannelComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element metrics
                    else if( ParserUtils.IsAtFhirElement(reader, "metrics") )
                    {
                        result.Metrics = new List<DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricsComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "metrics") )
                            result.Metrics.Add(DeviceCapabilitiesParser.ParseDeviceCapabilitiesCompartmentChannelMetricsComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse DeviceCapabilitiesCompartmentChannelMetricsComponent
        /// </summary>
        public static DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricsComponent ParseDeviceCapabilitiesCompartmentChannelMetricsComponent(IFhirReader reader, ErrorList errors, DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricsComponent existingInstance = null )
        {
            DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricsComponent result = existingInstance != null ? existingInstance : new DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricsComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element key
                    else if( ParserUtils.IsAtFhirElement(reader, "key") )
                        result.Key = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element facet
                    else if( ParserUtils.IsAtFhirElement(reader, "facet") )
                    {
                        result.Facet = new List<DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricsFacetComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "facet") )
                            result.Facet.Add(DeviceCapabilitiesParser.ParseDeviceCapabilitiesCompartmentChannelMetricsFacetComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse DeviceCapabilitiesCompartmentComponent
        /// </summary>
        public static DeviceCapabilities.DeviceCapabilitiesCompartmentComponent ParseDeviceCapabilitiesCompartmentComponent(IFhirReader reader, ErrorList errors, DeviceCapabilities.DeviceCapabilitiesCompartmentComponent existingInstance = null )
        {
            DeviceCapabilities.DeviceCapabilitiesCompartmentComponent result = existingInstance != null ? existingInstance : new DeviceCapabilities.DeviceCapabilitiesCompartmentComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element channel
                    else if( ParserUtils.IsAtFhirElement(reader, "channel") )
                    {
                        result.Channel = new List<DeviceCapabilities.DeviceCapabilitiesCompartmentChannelComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "channel") )
                            result.Channel.Add(DeviceCapabilitiesParser.ParseDeviceCapabilitiesCompartmentChannelComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse DeviceCapabilitiesCompartmentChannelMetricsFacetComponent
        /// </summary>
        public static DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricsFacetComponent ParseDeviceCapabilitiesCompartmentChannelMetricsFacetComponent(IFhirReader reader, ErrorList errors, DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricsFacetComponent existingInstance = null )
        {
            DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricsFacetComponent result = existingInstance != null ? existingInstance : new DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricsFacetComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element key
                    else if( ParserUtils.IsAtFhirElement(reader, "key") )
                        result.Key = FhirStringParser.ParseFhirString(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
    }
}
