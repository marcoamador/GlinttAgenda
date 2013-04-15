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
    /// Parser for Picture instances
    /// </summary>
    internal static partial class PictureParser
    {
        /// <summary>
        /// Parse Picture
        /// </summary>
        public static Picture ParsePicture(IFhirReader reader, ErrorList errors, Picture existingInstance = null )
        {
            Picture result = existingInstance != null ? existingInstance : new Picture();
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
                    
                    // Parse element dateTime
                    else if( ParserUtils.IsAtFhirElement(reader, "dateTime") )
                        result.DateTime = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element operator
                    else if( ParserUtils.IsAtFhirElement(reader, "operator") )
                        result.Operator = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element identifier
                    else if( ParserUtils.IsAtFhirElement(reader, "identifier") )
                        result.Identifier = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element accessionNo
                    else if( ParserUtils.IsAtFhirElement(reader, "accessionNo") )
                        result.AccessionNo = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element studyId
                    else if( ParserUtils.IsAtFhirElement(reader, "studyId") )
                        result.StudyId = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element seriesId
                    else if( ParserUtils.IsAtFhirElement(reader, "seriesId") )
                        result.SeriesId = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element method
                    else if( ParserUtils.IsAtFhirElement(reader, "method") )
                        result.Method = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element requester
                    else if( ParserUtils.IsAtFhirElement(reader, "requester") )
                        result.Requester = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element modality
                    else if( ParserUtils.IsAtFhirElement(reader, "modality") )
                        result.Modality = CodeParser.ParseCode<Picture.ImageModality3>(reader, errors);
                    
                    // Parse element deviceName
                    else if( ParserUtils.IsAtFhirElement(reader, "deviceName") )
                        result.DeviceName = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element height
                    else if( ParserUtils.IsAtFhirElement(reader, "height") )
                        result.Height = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element width
                    else if( ParserUtils.IsAtFhirElement(reader, "width") )
                        result.Width = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element bits
                    else if( ParserUtils.IsAtFhirElement(reader, "bits") )
                        result.Bits = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element frames
                    else if( ParserUtils.IsAtFhirElement(reader, "frames") )
                        result.Frames = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element frameDelay
                    else if( ParserUtils.IsAtFhirElement(reader, "frameDelay") )
                        result.FrameDelay = DurationParser.ParseDuration(reader, errors);
                    
                    // Parse element view
                    else if( ParserUtils.IsAtFhirElement(reader, "view") )
                        result.View = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
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
        
    }
}
