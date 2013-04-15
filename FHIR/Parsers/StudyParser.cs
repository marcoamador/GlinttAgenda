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
// Generated on Thu, Apr 11, 2013 13:03+1000 for FHIR v0.08
//

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Study instances
    /// </summary>
    internal static partial class StudyParser
    {
        /// <summary>
        /// Parse Study
        /// </summary>
        public static Study ParseStudy(IFhirReader reader, ErrorList errors, Study existingInstance = null )
        {
            Study result = existingInstance != null ? existingInstance : new Study();
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
                    
                    // Parse element lastModified
                    else if( ParserUtils.IsAtFhirElement(reader, "lastModified") )
                        result.LastModified = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element versionId
                    else if( ParserUtils.IsAtFhirElement(reader, "versionId") )
                        result.VersionId = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element authorSystem
                    else if( ParserUtils.IsAtFhirElement(reader, "authorSystem") )
                        result.AuthorSystem = StudyParser.ParseStudyAuthorSystemComponent(reader, errors);
                    
                    // Parse element identifier
                    else if( ParserUtils.IsAtFhirElement(reader, "identifier") )
                    {
                        result.Identifier = new List<Identifier>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                            result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element title
                    else if( ParserUtils.IsAtFhirElement(reader, "title") )
                        result.Title = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element objective
                    else if( ParserUtils.IsAtFhirElement(reader, "objective") )
                    {
                        result.Objective = new List<FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "objective") )
                            result.Objective.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element outcomeMeasure
                    else if( ParserUtils.IsAtFhirElement(reader, "outcomeMeasure") )
                    {
                        result.OutcomeMeasure = new List<FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "outcomeMeasure") )
                            result.OutcomeMeasure.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element sponsor
                    else if( ParserUtils.IsAtFhirElement(reader, "sponsor") )
                        result.Sponsor = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element plannedParticipants
                    else if( ParserUtils.IsAtFhirElement(reader, "plannedParticipants") )
                        result.PlannedParticipants = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element group
                    else if( ParserUtils.IsAtFhirElement(reader, "group") )
                    {
                        result.Group = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "group") )
                            result.Group.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element focus
                    else if( ParserUtils.IsAtFhirElement(reader, "focus") )
                    {
                        result.Focus = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "focus") )
                            result.Focus.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element arm
                    else if( ParserUtils.IsAtFhirElement(reader, "arm") )
                    {
                        result.Arm = new List<Study.StudyArmComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "arm") )
                            result.Arm.Add(StudyParser.ParseStudyArmComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element epoch
                    else if( ParserUtils.IsAtFhirElement(reader, "epoch") )
                    {
                        result.Epoch = new List<Study.StudyEpochComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "epoch") )
                            result.Epoch.Add(StudyParser.ParseStudyEpochComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element timepoint
                    else if( ParserUtils.IsAtFhirElement(reader, "timepoint") )
                    {
                        result.Timepoint = new List<Study.StudyTimepointComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "timepoint") )
                            result.Timepoint.Add(StudyParser.ParseStudyTimepointComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element resource
                    else if( ParserUtils.IsAtFhirElement(reader, "resource") )
                    {
                        result.Resource = new List<Study.StudyResourceComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "resource") )
                            result.Resource.Add(StudyParser.ParseStudyResourceComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element stableDiseaseMinimumDuration
                    else if( ParserUtils.IsAtFhirElement(reader, "stableDiseaseMinimumDuration") )
                        result.StableDiseaseMinimumDuration = DurationParser.ParseDuration(reader, errors);
                    
                    // Parse element confirmedResponseDuration
                    else if( ParserUtils.IsAtFhirElement(reader, "confirmedResponseDuration") )
                        result.ConfirmedResponseDuration = DurationParser.ParseDuration(reader, errors);
                    
                    // Parse element start
                    else if( ParserUtils.IsAtFhirElement(reader, "start") )
                        result.Start = DateParser.ParseDate(reader, errors);
                    
                    // Parse element end
                    else if( ParserUtils.IsAtFhirElement(reader, "end") )
                        result.End = DateParser.ParseDate(reader, errors);
                    
                    // Parse element duration
                    else if( ParserUtils.IsAtFhirElement(reader, "duration") )
                        result.Duration = DurationParser.ParseDuration(reader, errors);
                    
                    // Parse element purpose
                    else if( ParserUtils.IsAtFhirElement(reader, "purpose") )
                        result.Purpose = CodeParser.ParseCode<Study.StudyPurpose>(reader, errors);
                    
                    // Parse element phase
                    else if( ParserUtils.IsAtFhirElement(reader, "phase") )
                        result.Phase = CodeParser.ParseCode<Study.StudyPhase>(reader, errors);
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeParser.ParseCode<Study.StudyType>(reader, errors);
                    
                    // Parse element trialType
                    else if( ParserUtils.IsAtFhirElement(reader, "trialType") )
                        result.TrialType = CodeParser.ParseCode<Study.StudyTrialType>(reader, errors);
                    
                    // Parse element isRandomized
                    else if( ParserUtils.IsAtFhirElement(reader, "isRandomized") )
                        result.IsRandomized = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element blindingScheme
                    else if( ParserUtils.IsAtFhirElement(reader, "blindingScheme") )
                        result.BlindingScheme = CodeParser.ParseCode<Study.StudyBlindingScheme>(reader, errors);
                    
                    // Parse element controlType
                    else if( ParserUtils.IsAtFhirElement(reader, "controlType") )
                        result.ControlType = CodeParser.ParseCode<Study.StudyControlType>(reader, errors);
                    
                    // Parse element interventionModel
                    else if( ParserUtils.IsAtFhirElement(reader, "interventionModel") )
                        result.InterventionModel = CodeParser.ParseCode<Study.StudyInterventionModel>(reader, errors);
                    
                    // Parse element interventionType
                    else if( ParserUtils.IsAtFhirElement(reader, "interventionType") )
                        result.InterventionType = CodeParser.ParseCode<Study.StudyInterventionType>(reader, errors);
                    
                    // Parse element isAddOn
                    else if( ParserUtils.IsAtFhirElement(reader, "isAddOn") )
                        result.IsAddOn = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element isAdaptive
                    else if( ParserUtils.IsAtFhirElement(reader, "isAdaptive") )
                        result.IsAdaptive = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element arms
                    else if( ParserUtils.IsAtFhirElement(reader, "arms") )
                        result.Arms = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element randomizationQuotient
                    else if( ParserUtils.IsAtFhirElement(reader, "randomizationQuotient") )
                        result.RandomizationQuotient = RatioParser.ParseRatio(reader, errors);
                    
                    // Parse element indication
                    else if( ParserUtils.IsAtFhirElement(reader, "indication") )
                        result.Indication = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element currentTreatment
                    else if( ParserUtils.IsAtFhirElement(reader, "currentTreatment") )
                    {
                        result.CurrentTreatment = new List<CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "currentTreatment") )
                            result.CurrentTreatment.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element comparativeTreatment
                    else if( ParserUtils.IsAtFhirElement(reader, "comparativeTreatment") )
                        result.ComparativeTreatment = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element treatment
                    else if( ParserUtils.IsAtFhirElement(reader, "treatment") )
                        result.Treatment = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element pharmacologicalClass
                    else if( ParserUtils.IsAtFhirElement(reader, "pharmacologicalClass") )
                        result.PharmacologicalClass = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element route
                    else if( ParserUtils.IsAtFhirElement(reader, "route") )
                        result.Route = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element dose
                    else if( ParserUtils.IsAtFhirElement(reader, "dose") )
                        result.Dose = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element doseFrequency
                    else if( ParserUtils.IsAtFhirElement(reader, "doseFrequency") )
                        result.DoseFrequency = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element stopRules
                    else if( ParserUtils.IsAtFhirElement(reader, "stopRules") )
                        result.StopRules = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element participants
                    else if( ParserUtils.IsAtFhirElement(reader, "participants") )
                        result.Participants = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element dataCutoff
                    else if( ParserUtils.IsAtFhirElement(reader, "dataCutoff") )
                        result.DataCutoff = StudyParser.ParseStudyDataCutoffComponent(reader, errors);
                    
                    // Parse element country
                    else if( ParserUtils.IsAtFhirElement(reader, "country") )
                    {
                        result.Country = new List<Code>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "country") )
                            result.Country.Add(CodeParser.ParseCode(reader, errors));
                        
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
        /// Parse StudyTimepointPreconditionConditionComponent
        /// </summary>
        public static Study.StudyTimepointPreconditionConditionComponent ParseStudyTimepointPreconditionConditionComponent(IFhirReader reader, ErrorList errors, Study.StudyTimepointPreconditionConditionComponent existingInstance = null )
        {
            Study.StudyTimepointPreconditionConditionComponent result = existingInstance != null ? existingInstance : new Study.StudyTimepointPreconditionConditionComponent();
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
                        result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element value
                    else if( ParserUtils.IsAtFhirElement(reader, "value", true) )
                        result.Value = FhirParser.ParseElement(reader, errors);
                    
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
        /// Parse StudyResourceComponent
        /// </summary>
        public static Study.StudyResourceComponent ParseStudyResourceComponent(IFhirReader reader, ErrorList errors, Study.StudyResourceComponent existingInstance = null )
        {
            Study.StudyResourceComponent result = existingInstance != null ? existingInstance : new Study.StudyResourceComponent();
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
                        result.Type = CodeParser.ParseCode<Study.StudyResourceType>(reader, errors);
                    
                    // Parse element content
                    else if( ParserUtils.IsAtFhirElement(reader, "content") )
                        result.Content = AttachmentParser.ParseAttachment(reader, errors);
                    
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
        /// Parse StudyEpochComponent
        /// </summary>
        public static Study.StudyEpochComponent ParseStudyEpochComponent(IFhirReader reader, ErrorList errors, Study.StudyEpochComponent existingInstance = null )
        {
            Study.StudyEpochComponent result = existingInstance != null ? existingInstance : new Study.StudyEpochComponent();
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
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse StudyTimepointActivityComponent
        /// </summary>
        public static Study.StudyTimepointActivityComponent ParseStudyTimepointActivityComponent(IFhirReader reader, ErrorList errors, Study.StudyTimepointActivityComponent existingInstance = null )
        {
            Study.StudyTimepointActivityComponent result = existingInstance != null ? existingInstance : new Study.StudyTimepointActivityComponent();
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
                    
                    // Parse element alternative
                    else if( ParserUtils.IsAtFhirElement(reader, "alternative") )
                    {
                        result.Alternative = new List<IdRef>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "alternative") )
                            result.Alternative.Add(IdRefParser.ParseIdRef(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element component
                    else if( ParserUtils.IsAtFhirElement(reader, "component") )
                    {
                        result.Component = new List<Study.StudyTimepointActivityComponentComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "component") )
                            result.Component.Add(StudyParser.ParseStudyTimepointActivityComponentComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element following
                    else if( ParserUtils.IsAtFhirElement(reader, "following") )
                    {
                        result.Following = new List<IdRef>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "following") )
                            result.Following.Add(IdRefParser.ParseIdRef(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element wait
                    else if( ParserUtils.IsAtFhirElement(reader, "wait") )
                        result.Wait = DurationParser.ParseDuration(reader, errors);
                    
                    // Parse element category
                    else if( ParserUtils.IsAtFhirElement(reader, "category") )
                        result.Category = CodeParser.ParseCode<Study.StudyActivityCategory>(reader, errors);
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
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
        /// Parse StudyTimepointPreconditionComponent
        /// </summary>
        public static Study.StudyTimepointPreconditionComponent ParseStudyTimepointPreconditionComponent(IFhirReader reader, ErrorList errors, Study.StudyTimepointPreconditionComponent existingInstance = null )
        {
            Study.StudyTimepointPreconditionComponent result = existingInstance != null ? existingInstance : new Study.StudyTimepointPreconditionComponent();
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
                    
                    // Parse element condition
                    else if( ParserUtils.IsAtFhirElement(reader, "condition") )
                        result.Condition = StudyParser.ParseStudyTimepointPreconditionConditionComponent(reader, errors);
                    
                    // Parse element intersection
                    else if( ParserUtils.IsAtFhirElement(reader, "intersection") )
                    {
                        result.Intersection = new List<Study.StudyTimepointPreconditionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "intersection") )
                            result.Intersection.Add(StudyParser.ParseStudyTimepointPreconditionComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element union
                    else if( ParserUtils.IsAtFhirElement(reader, "union") )
                    {
                        result.Union = new List<Study.StudyTimepointPreconditionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "union") )
                            result.Union.Add(StudyParser.ParseStudyTimepointPreconditionComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element exclude
                    else if( ParserUtils.IsAtFhirElement(reader, "exclude") )
                    {
                        result.Exclude = new List<Study.StudyTimepointPreconditionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "exclude") )
                            result.Exclude.Add(StudyParser.ParseStudyTimepointPreconditionComponent(reader, errors));
                        
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
        /// Parse StudyAuthorSystemComponent
        /// </summary>
        public static Study.StudyAuthorSystemComponent ParseStudyAuthorSystemComponent(IFhirReader reader, ErrorList errors, Study.StudyAuthorSystemComponent existingInstance = null )
        {
            Study.StudyAuthorSystemComponent result = existingInstance != null ? existingInstance : new Study.StudyAuthorSystemComponent();
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
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element version
                    else if( ParserUtils.IsAtFhirElement(reader, "version") )
                        result.Version = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse StudyDataCutoffComponent
        /// </summary>
        public static Study.StudyDataCutoffComponent ParseStudyDataCutoffComponent(IFhirReader reader, ErrorList errors, Study.StudyDataCutoffComponent existingInstance = null )
        {
            Study.StudyDataCutoffComponent result = existingInstance != null ? existingInstance : new Study.StudyDataCutoffComponent();
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
                    
                    // Parse element date
                    else if( ParserUtils.IsAtFhirElement(reader, "date") )
                        result.Date = DateParser.ParseDate(reader, errors);
                    
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
        /// Parse StudyTimepointActivityComponentComponent
        /// </summary>
        public static Study.StudyTimepointActivityComponentComponent ParseStudyTimepointActivityComponentComponent(IFhirReader reader, ErrorList errors, Study.StudyTimepointActivityComponentComponent existingInstance = null )
        {
            Study.StudyTimepointActivityComponentComponent result = existingInstance != null ? existingInstance : new Study.StudyTimepointActivityComponentComponent();
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
                    
                    // Parse element sequence
                    else if( ParserUtils.IsAtFhirElement(reader, "sequence") )
                        result.Sequence = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element activity
                    else if( ParserUtils.IsAtFhirElement(reader, "activity") )
                        result.Activity = IdRefParser.ParseIdRef(reader, errors);
                    
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
        /// Parse StudyArmComponent
        /// </summary>
        public static Study.StudyArmComponent ParseStudyArmComponent(IFhirReader reader, ErrorList errors, Study.StudyArmComponent existingInstance = null )
        {
            Study.StudyArmComponent result = existingInstance != null ? existingInstance : new Study.StudyArmComponent();
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
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse StudyTimepointComponent
        /// </summary>
        public static Study.StudyTimepointComponent ParseStudyTimepointComponent(IFhirReader reader, ErrorList errors, Study.StudyTimepointComponent existingInstance = null )
        {
            Study.StudyTimepointComponent result = existingInstance != null ? existingInstance : new Study.StudyTimepointComponent();
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
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element precondition
                    else if( ParserUtils.IsAtFhirElement(reader, "precondition") )
                        result.Precondition = StudyParser.ParseStudyTimepointPreconditionComponent(reader, errors);
                    
                    // Parse element exit
                    else if( ParserUtils.IsAtFhirElement(reader, "exit") )
                        result.Exit = StudyParser.ParseStudyTimepointPreconditionComponent(reader, errors);
                    
                    // Parse element arm
                    else if( ParserUtils.IsAtFhirElement(reader, "arm") )
                        result.Arm = IdRefParser.ParseIdRef(reader, errors);
                    
                    // Parse element epoch
                    else if( ParserUtils.IsAtFhirElement(reader, "epoch") )
                        result.Epoch = IdRefParser.ParseIdRef(reader, errors);
                    
                    // Parse element armSequence
                    else if( ParserUtils.IsAtFhirElement(reader, "armSequence") )
                        result.ArmSequence = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element firstActivity
                    else if( ParserUtils.IsAtFhirElement(reader, "firstActivity") )
                    {
                        result.FirstActivity = new List<IdRef>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "firstActivity") )
                            result.FirstActivity.Add(IdRefParser.ParseIdRef(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element activity
                    else if( ParserUtils.IsAtFhirElement(reader, "activity") )
                    {
                        result.Activity = new List<Study.StudyTimepointActivityComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "activity") )
                            result.Activity.Add(StudyParser.ParseStudyTimepointActivityComponent(reader, errors));
                        
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
