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
    /// Parser for ValueSet instances
    /// </summary>
    internal static partial class ValueSetParser
    {
        /// <summary>
        /// Parse ValueSet
        /// </summary>
        public static ValueSet ParseValueSet(IFhirReader reader, ErrorList errors, ValueSet existingInstance = null )
        {
            ValueSet result = existingInstance != null ? existingInstance : new ValueSet();
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
                    
                    // Parse element author
                    else if( ParserUtils.IsAtFhirElement(reader, "author") )
                    {
                        result.Author = new List<ValueSet.AuthorComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "author") )
                            result.Author.Add(ValueSetParser.ParseAuthorComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element status
                    else if( ParserUtils.IsAtFhirElement(reader, "status") )
                        result.Status = CodeParser.ParseCode<ValueSet.ValueSetStatus>(reader, errors);
                    
                    // Parse element date
                    else if( ParserUtils.IsAtFhirElement(reader, "date") )
                        result.Date = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element identifier
                    else if( ParserUtils.IsAtFhirElement(reader, "identifier") )
                        result.Identifier = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element version
                    else if( ParserUtils.IsAtFhirElement(reader, "version") )
                        result.Version = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element restricts
                    else if( ParserUtils.IsAtFhirElement(reader, "restricts") )
                    {
                        result.Restricts = new List<FhirUri>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "restricts") )
                            result.Restricts.Add(FhirUriParser.ParseFhirUri(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element import
                    else if( ParserUtils.IsAtFhirElement(reader, "import") )
                    {
                        result.Import = new List<FhirUri>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "import") )
                            result.Import.Add(FhirUriParser.ParseFhirUri(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element include
                    else if( ParserUtils.IsAtFhirElement(reader, "include") )
                    {
                        result.Include = new List<ValueSet.ConceptSetComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "include") )
                            result.Include.Add(ValueSetParser.ParseConceptSetComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element exclude
                    else if( ParserUtils.IsAtFhirElement(reader, "exclude") )
                    {
                        result.Exclude = new List<ValueSet.ConceptSetComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "exclude") )
                            result.Exclude.Add(ValueSetParser.ParseConceptSetComponent(reader, errors));
                        
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
        /// Parse ConceptSetComponent
        /// </summary>
        public static ValueSet.ConceptSetComponent ParseConceptSetComponent(IFhirReader reader, ErrorList errors, ValueSet.ConceptSetComponent existingInstance = null )
        {
            ValueSet.ConceptSetComponent result = existingInstance != null ? existingInstance : new ValueSet.ConceptSetComponent();
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
                    
                    // Parse element system
                    else if( ParserUtils.IsAtFhirElement(reader, "system") )
                        result.System = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element version
                    else if( ParserUtils.IsAtFhirElement(reader, "version") )
                        result.Version = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element mode
                    else if( ParserUtils.IsAtFhirElement(reader, "mode") )
                        result.Mode = CodeParser.ParseCode<ValueSet.CodeSelectionMode>(reader, errors);
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                    {
                        result.Code = new List<Code>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "code") )
                            result.Code.Add(CodeParser.ParseCode(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element filter
                    else if( ParserUtils.IsAtFhirElement(reader, "filter") )
                    {
                        result.Filter = new List<ValueSet.ConceptSetFilterComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "filter") )
                            result.Filter.Add(ValueSetParser.ParseConceptSetFilterComponent(reader, errors));
                        
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
        /// Parse ConceptSetFilterComponent
        /// </summary>
        public static ValueSet.ConceptSetFilterComponent ParseConceptSetFilterComponent(IFhirReader reader, ErrorList errors, ValueSet.ConceptSetFilterComponent existingInstance = null )
        {
            ValueSet.ConceptSetFilterComponent result = existingInstance != null ? existingInstance : new ValueSet.ConceptSetFilterComponent();
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
                    
                    // Parse element property
                    else if( ParserUtils.IsAtFhirElement(reader, "property") )
                        result.Property = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element op
                    else if( ParserUtils.IsAtFhirElement(reader, "op") )
                        result.Op = CodeParser.ParseCode<ValueSet.FilterOperator>(reader, errors);
                    
                    // Parse element value
                    else if( ParserUtils.IsAtFhirElement(reader, "value") )
                        result.Value = CodeParser.ParseCode(reader, errors);
                    
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
        /// Parse AuthorComponent
        /// </summary>
        public static ValueSet.AuthorComponent ParseAuthorComponent(IFhirReader reader, ErrorList errors, ValueSet.AuthorComponent existingInstance = null )
        {
            ValueSet.AuthorComponent result = existingInstance != null ? existingInstance : new ValueSet.AuthorComponent();
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
                    
                    // Parse element role
                    else if( ParserUtils.IsAtFhirElement(reader, "role") )
                        result.Role = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element telecom
                    else if( ParserUtils.IsAtFhirElement(reader, "telecom") )
                    {
                        result.Telecom = new List<Contact>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "telecom") )
                            result.Telecom.Add(ContactParser.ParseContact(reader, errors));
                        
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
