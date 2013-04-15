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
    /// Parser for ImagingStudy instances
    /// </summary>
    internal static partial class ImagingStudyParser
    {
        /// <summary>
        /// Parse ImagingStudy
        /// </summary>
        public static ImagingStudy ParseImagingStudy(IFhirReader reader, ErrorList errors, ImagingStudy existingInstance = null )
        {
            ImagingStudy result = existingInstance != null ? existingInstance : new ImagingStudy();
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
                    
                    // Parse element dateTime
                    else if( ParserUtils.IsAtFhirElement(reader, "dateTime") )
                        result.DateTime = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element uid
                    else if( ParserUtils.IsAtFhirElement(reader, "uid") )
                        result.Uid = OidParser.ParseOid(reader, errors);
                    
                    // Parse element identifier
                    else if( ParserUtils.IsAtFhirElement(reader, "identifier") )
                    {
                        result.Identifier = new List<Identifier>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                            result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element requester
                    else if( ParserUtils.IsAtFhirElement(reader, "requester") )
                        result.Requester = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element accessionNo
                    else if( ParserUtils.IsAtFhirElement(reader, "accessionNo") )
                        result.AccessionNo = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element clinicalInformation
                    else if( ParserUtils.IsAtFhirElement(reader, "clinicalInformation") )
                        result.ClinicalInformation = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element procedure
                    else if( ParserUtils.IsAtFhirElement(reader, "procedure") )
                    {
                        result.Procedure = new List<Coding>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "procedure") )
                            result.Procedure.Add(CodingParser.ParseCoding(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element interpreter
                    else if( ParserUtils.IsAtFhirElement(reader, "interpreter") )
                        result.Interpreter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element series
                    else if( ParserUtils.IsAtFhirElement(reader, "series") )
                    {
                        result.Series = new List<ImagingStudy.ImagingStudySeriesComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "series") )
                            result.Series.Add(ImagingStudyParser.ParseImagingStudySeriesComponent(reader, errors));
                        
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
        /// Parse ImagingStudySeriesComponent
        /// </summary>
        public static ImagingStudy.ImagingStudySeriesComponent ParseImagingStudySeriesComponent(IFhirReader reader, ErrorList errors, ImagingStudy.ImagingStudySeriesComponent existingInstance = null )
        {
            ImagingStudy.ImagingStudySeriesComponent result = existingInstance != null ? existingInstance : new ImagingStudy.ImagingStudySeriesComponent();
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
                    
                    // Parse element number
                    else if( ParserUtils.IsAtFhirElement(reader, "number") )
                        result.Number = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element modality
                    else if( ParserUtils.IsAtFhirElement(reader, "modality") )
                        result.Modality = CodeParser.ParseCode<ImagingStudy.ImageModality>(reader, errors);
                    
                    // Parse element datetime
                    else if( ParserUtils.IsAtFhirElement(reader, "datetime") )
                        result.Datetime = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element uid
                    else if( ParserUtils.IsAtFhirElement(reader, "uid") )
                        result.Uid = OidParser.ParseOid(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element bodySite
                    else if( ParserUtils.IsAtFhirElement(reader, "bodySite") )
                        result.BodySite = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element image
                    else if( ParserUtils.IsAtFhirElement(reader, "image") )
                    {
                        result.Image = new List<ImagingStudy.ImagingStudySeriesImageComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "image") )
                            result.Image.Add(ImagingStudyParser.ParseImagingStudySeriesImageComponent(reader, errors));
                        
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
        /// Parse ImagingStudySeriesImageComponent
        /// </summary>
        public static ImagingStudy.ImagingStudySeriesImageComponent ParseImagingStudySeriesImageComponent(IFhirReader reader, ErrorList errors, ImagingStudy.ImagingStudySeriesImageComponent existingInstance = null )
        {
            ImagingStudy.ImagingStudySeriesImageComponent result = existingInstance != null ? existingInstance : new ImagingStudy.ImagingStudySeriesImageComponent();
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
                    
                    // Parse element number
                    else if( ParserUtils.IsAtFhirElement(reader, "number") )
                        result.Number = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element dateTime
                    else if( ParserUtils.IsAtFhirElement(reader, "dateTime") )
                        result.DateTime = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element uid
                    else if( ParserUtils.IsAtFhirElement(reader, "uid") )
                        result.Uid = OidParser.ParseOid(reader, errors);
                    
                    // Parse element dicomClass
                    else if( ParserUtils.IsAtFhirElement(reader, "dicomClass") )
                        result.DicomClass = OidParser.ParseOid(reader, errors);
                    
                    // Parse element url
                    else if( ParserUtils.IsAtFhirElement(reader, "url") )
                        result.Url = FhirUriParser.ParseFhirUri(reader, errors);
                    
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
