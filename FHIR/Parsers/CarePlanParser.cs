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
    /// Parser for CarePlan instances
    /// </summary>
    internal static partial class CarePlanParser
    {
        /// <summary>
        /// Parse CarePlan
        /// </summary>
        public static CarePlan ParseCarePlan(IFhirReader reader, ErrorList errors, CarePlan existingInstance = null )
        {
            CarePlan result = existingInstance != null ? existingInstance : new CarePlan();
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
                    
                    // Parse element identifier
                    else if( ParserUtils.IsAtFhirElement(reader, "identifier") )
                        result.Identifier = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element patient
                    else if( ParserUtils.IsAtFhirElement(reader, "patient") )
                        result.Patient = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element status
                    else if( ParserUtils.IsAtFhirElement(reader, "status") )
                        result.Status = CodeParser.ParseCode<CarePlan.CarePlanStatus>(reader, errors);
                    
                    // Parse element period
                    else if( ParserUtils.IsAtFhirElement(reader, "period") )
                        result.Period = PeriodParser.ParsePeriod(reader, errors);
                    
                    // Parse element modified
                    else if( ParserUtils.IsAtFhirElement(reader, "modified") )
                        result.Modified = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element concern
                    else if( ParserUtils.IsAtFhirElement(reader, "concern") )
                    {
                        result.Concern = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "concern") )
                            result.Concern.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element participant
                    else if( ParserUtils.IsAtFhirElement(reader, "participant") )
                    {
                        result.Participant = new List<CarePlan.CarePlanParticipantComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "participant") )
                            result.Participant.Add(CarePlanParser.ParseCarePlanParticipantComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element goal
                    else if( ParserUtils.IsAtFhirElement(reader, "goal") )
                    {
                        result.Goal = new List<CarePlan.CarePlanGoalComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "goal") )
                            result.Goal.Add(CarePlanParser.ParseCarePlanGoalComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element activity
                    else if( ParserUtils.IsAtFhirElement(reader, "activity") )
                    {
                        result.Activity = new List<CarePlan.CarePlanActivityComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "activity") )
                            result.Activity.Add(CarePlanParser.ParseCarePlanActivityComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element notes
                    else if( ParserUtils.IsAtFhirElement(reader, "notes") )
                        result.Notes = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse CarePlanGoalComponent
        /// </summary>
        public static CarePlan.CarePlanGoalComponent ParseCarePlanGoalComponent(IFhirReader reader, ErrorList errors, CarePlan.CarePlanGoalComponent existingInstance = null )
        {
            CarePlan.CarePlanGoalComponent result = existingInstance != null ? existingInstance : new CarePlan.CarePlanGoalComponent();
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
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element status
                    else if( ParserUtils.IsAtFhirElement(reader, "status") )
                        result.Status = CodeParser.ParseCode<CarePlan.CarePlanGoalStatus>(reader, errors);
                    
                    // Parse element notes
                    else if( ParserUtils.IsAtFhirElement(reader, "notes") )
                        result.Notes = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse CarePlanParticipantComponent
        /// </summary>
        public static CarePlan.CarePlanParticipantComponent ParseCarePlanParticipantComponent(IFhirReader reader, ErrorList errors, CarePlan.CarePlanParticipantComponent existingInstance = null )
        {
            CarePlan.CarePlanParticipantComponent result = existingInstance != null ? existingInstance : new CarePlan.CarePlanParticipantComponent();
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
                    
                    // Parse element role
                    else if( ParserUtils.IsAtFhirElement(reader, "role") )
                        result.Role = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element member
                    else if( ParserUtils.IsAtFhirElement(reader, "member") )
                        result.Member = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
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
        /// Parse CarePlanActivityComponent
        /// </summary>
        public static CarePlan.CarePlanActivityComponent ParseCarePlanActivityComponent(IFhirReader reader, ErrorList errors, CarePlan.CarePlanActivityComponent existingInstance = null )
        {
            CarePlan.CarePlanActivityComponent result = existingInstance != null ? existingInstance : new CarePlan.CarePlanActivityComponent();
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
                    
                    // Parse element category
                    else if( ParserUtils.IsAtFhirElement(reader, "category") )
                        result.Category = CodeParser.ParseCode<CarePlan.CarePlanActivityCategory>(reader, errors);
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element status
                    else if( ParserUtils.IsAtFhirElement(reader, "status") )
                        result.Status = CodeParser.ParseCode<CarePlan.CarePlanActivityStatus>(reader, errors);
                    
                    // Parse element prohibited
                    else if( ParserUtils.IsAtFhirElement(reader, "prohibited") )
                        result.Prohibited = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element timing
                    else if( ParserUtils.IsAtFhirElement(reader, "timing", true) )
                        result.Timing = FhirParser.ParseElement(reader, errors);
                    
                    // Parse element location
                    else if( ParserUtils.IsAtFhirElement(reader, "location") )
                        result.Location = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element performer
                    else if( ParserUtils.IsAtFhirElement(reader, "performer") )
                    {
                        result.Performer = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "performer") )
                            result.Performer.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element product
                    else if( ParserUtils.IsAtFhirElement(reader, "product") )
                        result.Product = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element dailyAmount
                    else if( ParserUtils.IsAtFhirElement(reader, "dailyAmount") )
                        result.DailyAmount = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element quantity
                    else if( ParserUtils.IsAtFhirElement(reader, "quantity") )
                        result.Quantity = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element details
                    else if( ParserUtils.IsAtFhirElement(reader, "details") )
                        result.Details = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element actionTaken
                    else if( ParserUtils.IsAtFhirElement(reader, "actionTaken") )
                    {
                        result.ActionTaken = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "actionTaken") )
                            result.ActionTaken.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element notes
                    else if( ParserUtils.IsAtFhirElement(reader, "notes") )
                        result.Notes = FhirStringParser.ParseFhirString(reader, errors);
                    
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
