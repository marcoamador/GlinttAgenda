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
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element manufacturer
                    else if( ParserUtils.IsAtFhirElement(reader, "manufacturer") )
                        result.Manufacturer = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element identity
                    else if( ParserUtils.IsAtFhirElement(reader, "identity") )
                        result.Identity = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
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
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element metric
                    else if( ParserUtils.IsAtFhirElement(reader, "metric") )
                    {
                        result.Metric = new List<DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "metric") )
                            result.Metric.Add(DeviceCapabilitiesParser.ParseDeviceCapabilitiesCompartmentChannelMetricComponent(reader, errors));
                        
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
        /// Parse DeviceCapabilitiesCompartmentChannelMetricFacetComponent
        /// </summary>
        public static DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricFacetComponent ParseDeviceCapabilitiesCompartmentChannelMetricFacetComponent(IFhirReader reader, ErrorList errors, DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricFacetComponent existingInstance = null )
        {
            DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricFacetComponent result = existingInstance != null ? existingInstance : new DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricFacetComponent();
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
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element key
                    else if( ParserUtils.IsAtFhirElement(reader, "key") )
                        result.Key = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element info
                    else if( ParserUtils.IsAtFhirElement(reader, "info") )
                        result.Info = DeviceCapabilitiesParser.ParseDeviceCapabilitiesCompartmentChannelMetricInfoComponent(reader, errors);
                    
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
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
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
        /// Parse DeviceCapabilitiesCompartmentChannelMetricInfoComponent
        /// </summary>
        public static DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricInfoComponent ParseDeviceCapabilitiesCompartmentChannelMetricInfoComponent(IFhirReader reader, ErrorList errors, DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricInfoComponent existingInstance = null )
        {
            DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricInfoComponent result = existingInstance != null ? existingInstance : new DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricInfoComponent();
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
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeParser.ParseCode<DeviceCapabilities.DeviceDataType>(reader, errors);
                    
                    // Parse element units
                    else if( ParserUtils.IsAtFhirElement(reader, "units") )
                        result.Units = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element ucum
                    else if( ParserUtils.IsAtFhirElement(reader, "ucum") )
                        result.Ucum = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element system
                    else if( ParserUtils.IsAtFhirElement(reader, "system") )
                        result.System = FhirUriParser.ParseFhirUri(reader, errors);
                    
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
        /// Parse DeviceCapabilitiesCompartmentChannelMetricComponent
        /// </summary>
        public static DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricComponent ParseDeviceCapabilitiesCompartmentChannelMetricComponent(IFhirReader reader, ErrorList errors, DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricComponent existingInstance = null )
        {
            DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricComponent result = existingInstance != null ? existingInstance : new DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricComponent();
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
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element key
                    else if( ParserUtils.IsAtFhirElement(reader, "key") )
                        result.Key = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element info
                    else if( ParserUtils.IsAtFhirElement(reader, "info") )
                        result.Info = DeviceCapabilitiesParser.ParseDeviceCapabilitiesCompartmentChannelMetricInfoComponent(reader, errors);
                    
                    // Parse element facet
                    else if( ParserUtils.IsAtFhirElement(reader, "facet") )
                    {
                        result.Facet = new List<DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricFacetComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "facet") )
                            result.Facet.Add(DeviceCapabilitiesParser.ParseDeviceCapabilitiesCompartmentChannelMetricFacetComponent(reader, errors));
                        
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
        
    }
}
