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
    /// Parser for ImmunizationProfile instances
    /// </summary>
    internal static partial class ImmunizationProfileParser
    {
        /// <summary>
        /// Parse ImmunizationProfile
        /// </summary>
        public static ImmunizationProfile ParseImmunizationProfile(IFhirReader reader, ErrorList errors, ImmunizationProfile existingInstance = null )
        {
            ImmunizationProfile result = existingInstance != null ? existingInstance : new ImmunizationProfile();
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
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element recommendation
                    else if( ParserUtils.IsAtFhirElement(reader, "recommendation") )
                    {
                        result.Recommendation = new List<ImmunizationProfile.ImmunizationProfileRecommendationComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "recommendation") )
                            result.Recommendation.Add(ImmunizationProfileParser.ParseImmunizationProfileRecommendationComponent(reader, errors));
                        
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
        /// Parse ImmunizationProfileRecommendationProtocolComponent
        /// </summary>
        public static ImmunizationProfile.ImmunizationProfileRecommendationProtocolComponent ParseImmunizationProfileRecommendationProtocolComponent(IFhirReader reader, ErrorList errors, ImmunizationProfile.ImmunizationProfileRecommendationProtocolComponent existingInstance = null )
        {
            ImmunizationProfile.ImmunizationProfileRecommendationProtocolComponent result = existingInstance != null ? existingInstance : new ImmunizationProfile.ImmunizationProfileRecommendationProtocolComponent();
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
                    
                    // Parse element doseSequence
                    else if( ParserUtils.IsAtFhirElement(reader, "doseSequence") )
                        result.DoseSequence = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element authority
                    else if( ParserUtils.IsAtFhirElement(reader, "authority") )
                        result.Authority = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element series
                    else if( ParserUtils.IsAtFhirElement(reader, "series") )
                        result.Series = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ImmunizationProfileRecommendationDateCriterionComponent
        /// </summary>
        public static ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent ParseImmunizationProfileRecommendationDateCriterionComponent(IFhirReader reader, ErrorList errors, ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent existingInstance = null )
        {
            ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent result = existingInstance != null ? existingInstance : new ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent();
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
                        result.Code = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element value
                    else if( ParserUtils.IsAtFhirElement(reader, "value") )
                        result.Value = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
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
        /// Parse ImmunizationProfileRecommendationSupportingAdverseEventReportComponent
        /// </summary>
        public static ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent ParseImmunizationProfileRecommendationSupportingAdverseEventReportComponent(IFhirReader reader, ErrorList errors, ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent existingInstance = null )
        {
            ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent result = existingInstance != null ? existingInstance : new ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent();
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
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                    {
                        result.Id = new List<Id>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "id") )
                            result.Id.Add(IdParser.ParseId(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element reportType
                    else if( ParserUtils.IsAtFhirElement(reader, "reportType") )
                        result.ReportType = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element reportDate
                    else if( ParserUtils.IsAtFhirElement(reader, "reportDate") )
                        result.ReportDate = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element text
                    else if( ParserUtils.IsAtFhirElement(reader, "text") )
                        result.Text = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element reaction
                    else if( ParserUtils.IsAtFhirElement(reader, "reaction") )
                    {
                        result.Reaction = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "reaction") )
                            result.Reaction.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
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
        /// Parse ImmunizationProfileRecommendationComponent
        /// </summary>
        public static ImmunizationProfile.ImmunizationProfileRecommendationComponent ParseImmunizationProfileRecommendationComponent(IFhirReader reader, ErrorList errors, ImmunizationProfile.ImmunizationProfileRecommendationComponent existingInstance = null )
        {
            ImmunizationProfile.ImmunizationProfileRecommendationComponent result = existingInstance != null ? existingInstance : new ImmunizationProfile.ImmunizationProfileRecommendationComponent();
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
                    
                    // Parse element recommendationDate
                    else if( ParserUtils.IsAtFhirElement(reader, "recommendationDate") )
                        result.RecommendationDate = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element vaccineType
                    else if( ParserUtils.IsAtFhirElement(reader, "vaccineType") )
                        result.VaccineType = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element doseNumber
                    else if( ParserUtils.IsAtFhirElement(reader, "doseNumber") )
                        result.DoseNumber = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element forecastStatus
                    else if( ParserUtils.IsAtFhirElement(reader, "forecastStatus") )
                        result.ForecastStatus = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element dateCriterion
                    else if( ParserUtils.IsAtFhirElement(reader, "dateCriterion") )
                    {
                        result.DateCriterion = new List<ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "dateCriterion") )
                            result.DateCriterion.Add(ImmunizationProfileParser.ParseImmunizationProfileRecommendationDateCriterionComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element protocol
                    else if( ParserUtils.IsAtFhirElement(reader, "protocol") )
                        result.Protocol = ImmunizationProfileParser.ParseImmunizationProfileRecommendationProtocolComponent(reader, errors);
                    
                    // Parse element supportingImmunization
                    else if( ParserUtils.IsAtFhirElement(reader, "supportingImmunization") )
                    {
                        result.SupportingImmunization = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "supportingImmunization") )
                            result.SupportingImmunization.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element supportingAdverseEventReport
                    else if( ParserUtils.IsAtFhirElement(reader, "supportingAdverseEventReport") )
                    {
                        result.SupportingAdverseEventReport = new List<ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "supportingAdverseEventReport") )
                            result.SupportingAdverseEventReport.Add(ImmunizationProfileParser.ParseImmunizationProfileRecommendationSupportingAdverseEventReportComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element supportingPatientObservation
                    else if( ParserUtils.IsAtFhirElement(reader, "supportingPatientObservation") )
                    {
                        result.SupportingPatientObservation = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "supportingPatientObservation") )
                            result.SupportingPatientObservation.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
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
