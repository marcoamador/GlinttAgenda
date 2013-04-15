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
    /// Parser for DiagnosticReport instances
    /// </summary>
    internal static partial class DiagnosticReportParser
    {
        /// <summary>
        /// Parse DiagnosticReport
        /// </summary>
        public static DiagnosticReport ParseDiagnosticReport(IFhirReader reader, ErrorList errors, DiagnosticReport existingInstance = null )
        {
            DiagnosticReport result = existingInstance != null ? existingInstance : new DiagnosticReport();
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
                    
                    // Parse element status
                    else if( ParserUtils.IsAtFhirElement(reader, "status") )
                        result.Status = CodeParser.ParseCode<ObservationStatus>(reader, errors);
                    
                    // Parse element issued
                    else if( ParserUtils.IsAtFhirElement(reader, "issued") )
                        result.Issued = InstantParser.ParseInstant(reader, errors);
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element performer
                    else if( ParserUtils.IsAtFhirElement(reader, "performer") )
                        result.Performer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element reportId
                    else if( ParserUtils.IsAtFhirElement(reader, "reportId") )
                        result.ReportId = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element requestDetail
                    else if( ParserUtils.IsAtFhirElement(reader, "requestDetail") )
                    {
                        result.RequestDetail = new List<DiagnosticReport.DiagnosticReportRequestDetailComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "requestDetail") )
                            result.RequestDetail.Add(DiagnosticReportParser.ParseDiagnosticReportRequestDetailComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element serviceCategory
                    else if( ParserUtils.IsAtFhirElement(reader, "serviceCategory") )
                        result.ServiceCategory = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element diagnosticTime
                    else if( ParserUtils.IsAtFhirElement(reader, "diagnosticTime") )
                        result.DiagnosticTime = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element results
                    else if( ParserUtils.IsAtFhirElement(reader, "results") )
                        result.Results = DiagnosticReportParser.ParseResultGroupComponent(reader, errors);
                    
                    // Parse element image
                    else if( ParserUtils.IsAtFhirElement(reader, "image") )
                    {
                        result.Image = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "image") )
                            result.Image.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element conclusion
                    else if( ParserUtils.IsAtFhirElement(reader, "conclusion") )
                        result.Conclusion = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element codedDiagnosis
                    else if( ParserUtils.IsAtFhirElement(reader, "codedDiagnosis") )
                    {
                        result.CodedDiagnosis = new List<CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "codedDiagnosis") )
                            result.CodedDiagnosis.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element representation
                    else if( ParserUtils.IsAtFhirElement(reader, "representation") )
                    {
                        result.Representation = new List<Attachment>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "representation") )
                            result.Representation.Add(AttachmentParser.ParseAttachment(reader, errors));
                        
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
        /// Parse DiagnosticReportRequestDetailComponent
        /// </summary>
        public static DiagnosticReport.DiagnosticReportRequestDetailComponent ParseDiagnosticReportRequestDetailComponent(IFhirReader reader, ErrorList errors, DiagnosticReport.DiagnosticReportRequestDetailComponent existingInstance = null )
        {
            DiagnosticReport.DiagnosticReportRequestDetailComponent result = existingInstance != null ? existingInstance : new DiagnosticReport.DiagnosticReportRequestDetailComponent();
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
                    
                    // Parse element visit
                    else if( ParserUtils.IsAtFhirElement(reader, "visit") )
                        result.Visit = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element requestOrderId
                    else if( ParserUtils.IsAtFhirElement(reader, "requestOrderId") )
                        result.RequestOrderId = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element receiverOrderId
                    else if( ParserUtils.IsAtFhirElement(reader, "receiverOrderId") )
                        result.ReceiverOrderId = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element requestTest
                    else if( ParserUtils.IsAtFhirElement(reader, "requestTest") )
                    {
                        result.RequestTest = new List<CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "requestTest") )
                            result.RequestTest.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element bodySite
                    else if( ParserUtils.IsAtFhirElement(reader, "bodySite") )
                        result.BodySite = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element requester
                    else if( ParserUtils.IsAtFhirElement(reader, "requester") )
                        result.Requester = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element clinicalInfo
                    else if( ParserUtils.IsAtFhirElement(reader, "clinicalInfo") )
                        result.ClinicalInfo = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ResultGroupComponent
        /// </summary>
        public static DiagnosticReport.ResultGroupComponent ParseResultGroupComponent(IFhirReader reader, ErrorList errors, DiagnosticReport.ResultGroupComponent existingInstance = null )
        {
            DiagnosticReport.ResultGroupComponent result = existingInstance != null ? existingInstance : new DiagnosticReport.ResultGroupComponent();
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
                        result.Name = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element specimen
                    else if( ParserUtils.IsAtFhirElement(reader, "specimen") )
                        result.Specimen = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element group
                    else if( ParserUtils.IsAtFhirElement(reader, "group") )
                    {
                        result.Group = new List<DiagnosticReport.ResultGroupComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "group") )
                            result.Group.Add(DiagnosticReportParser.ParseResultGroupComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element result
                    else if( ParserUtils.IsAtFhirElement(reader, "result") )
                    {
                        result.Result = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "result") )
                            result.Result.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
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
