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
    /// Parser for Profile instances
    /// </summary>
    internal static partial class ProfileParser
    {
        /// <summary>
        /// Parse Profile
        /// </summary>
        public static Profile ParseProfile(IFhirReader reader, ErrorList errors, Profile existingInstance = null )
        {
            Profile result = existingInstance != null ? existingInstance : new Profile();
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
                    
                    // Parse element version
                    else if( ParserUtils.IsAtFhirElement(reader, "version") )
                        result.Version = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element author
                    else if( ParserUtils.IsAtFhirElement(reader, "author") )
                    {
                        result.Author = new List<Profile.AuthorComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "author") )
                            result.Author.Add(ProfileParser.ParseAuthorComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                    {
                        result.Code = new List<Coding>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "code") )
                            result.Code.Add(CodingParser.ParseCoding(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element status
                    else if( ParserUtils.IsAtFhirElement(reader, "status") )
                        result.Status = ProfileParser.ParseProfileStatusComponent(reader, errors);
                    
                    // Parse element import
                    else if( ParserUtils.IsAtFhirElement(reader, "import") )
                    {
                        result.Import = new List<Profile.ProfileImportComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "import") )
                            result.Import.Add(ProfileParser.ParseProfileImportComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element bundle
                    else if( ParserUtils.IsAtFhirElement(reader, "bundle") )
                        result.Bundle = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element constraint
                    else if( ParserUtils.IsAtFhirElement(reader, "constraint") )
                    {
                        result.Constraint = new List<Profile.ProfileConstraintComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "constraint") )
                            result.Constraint.Add(ProfileParser.ParseProfileConstraintComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element extensionDefn
                    else if( ParserUtils.IsAtFhirElement(reader, "extensionDefn") )
                    {
                        result.ExtensionDefn = new List<Profile.ProfileExtensionDefnComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extensionDefn") )
                            result.ExtensionDefn.Add(ProfileParser.ParseProfileExtensionDefnComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element binding
                    else if( ParserUtils.IsAtFhirElement(reader, "binding") )
                    {
                        result.Binding = new List<Profile.ProfileBindingComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "binding") )
                            result.Binding.Add(ProfileParser.ParseProfileBindingComponent(reader, errors));
                        
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
        /// Parse ProfileConstraintSearchParamComponent
        /// </summary>
        public static Profile.ProfileConstraintSearchParamComponent ParseProfileConstraintSearchParamComponent(IFhirReader reader, ErrorList errors, Profile.ProfileConstraintSearchParamComponent existingInstance = null )
        {
            Profile.ProfileConstraintSearchParamComponent result = existingInstance != null ? existingInstance : new Profile.ProfileConstraintSearchParamComponent();
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
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeParser.ParseCode<SearchParamType>(reader, errors);
                    
                    // Parse element repeats
                    else if( ParserUtils.IsAtFhirElement(reader, "repeats") )
                        result.Repeats = CodeParser.ParseCode<SearchRepeatBehavior>(reader, errors);
                    
                    // Parse element documentation
                    else if( ParserUtils.IsAtFhirElement(reader, "documentation") )
                        result.Documentation = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ProfileConstraintComponent
        /// </summary>
        public static Profile.ProfileConstraintComponent ParseProfileConstraintComponent(IFhirReader reader, ErrorList errors, Profile.ProfileConstraintComponent existingInstance = null )
        {
            Profile.ProfileConstraintComponent result = existingInstance != null ? existingInstance : new Profile.ProfileConstraintComponent();
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
                        result.Type = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element purpose
                    else if( ParserUtils.IsAtFhirElement(reader, "purpose") )
                        result.Purpose = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element profile
                    else if( ParserUtils.IsAtFhirElement(reader, "profile") )
                        result.Profile = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element element
                    else if( ParserUtils.IsAtFhirElement(reader, "element") )
                    {
                        result.Element = new List<Profile.ElementComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "element") )
                            result.Element.Add(ProfileParser.ParseElementComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element searchParam
                    else if( ParserUtils.IsAtFhirElement(reader, "searchParam") )
                    {
                        result.SearchParam = new List<Profile.ProfileConstraintSearchParamComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "searchParam") )
                            result.SearchParam.Add(ProfileParser.ParseProfileConstraintSearchParamComponent(reader, errors));
                        
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
        /// Parse CodeDefinitionComponent
        /// </summary>
        public static Profile.CodeDefinitionComponent ParseCodeDefinitionComponent(IFhirReader reader, ErrorList errors, Profile.CodeDefinitionComponent existingInstance = null )
        {
            Profile.CodeDefinitionComponent result = existingInstance != null ? existingInstance : new Profile.CodeDefinitionComponent();
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
                        result.Code = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element system
                    else if( ParserUtils.IsAtFhirElement(reader, "system") )
                        result.System = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element display
                    else if( ParserUtils.IsAtFhirElement(reader, "display") )
                        result.Display = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element definition
                    else if( ParserUtils.IsAtFhirElement(reader, "definition") )
                        result.Definition = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        public static Profile.AuthorComponent ParseAuthorComponent(IFhirReader reader, ErrorList errors, Profile.AuthorComponent existingInstance = null )
        {
            Profile.AuthorComponent result = existingInstance != null ? existingInstance : new Profile.AuthorComponent();
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
        
        /// <summary>
        /// Parse TypeRefComponent
        /// </summary>
        public static Profile.TypeRefComponent ParseTypeRefComponent(IFhirReader reader, ErrorList errors, Profile.TypeRefComponent existingInstance = null )
        {
            Profile.TypeRefComponent result = existingInstance != null ? existingInstance : new Profile.TypeRefComponent();
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
                    
                    // Parse element profile
                    else if( ParserUtils.IsAtFhirElement(reader, "profile") )
                        result.Profile = FhirUriParser.ParseFhirUri(reader, errors);
                    
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
        /// Parse ElementDefinitionConstraintComponent
        /// </summary>
        public static Profile.ElementDefinitionConstraintComponent ParseElementDefinitionConstraintComponent(IFhirReader reader, ErrorList errors, Profile.ElementDefinitionConstraintComponent existingInstance = null )
        {
            Profile.ElementDefinitionConstraintComponent result = existingInstance != null ? existingInstance : new Profile.ElementDefinitionConstraintComponent();
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
                        result.Id = IdParser.ParseId(reader, errors);
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element severity
                    else if( ParserUtils.IsAtFhirElement(reader, "severity") )
                        result.Severity = CodeParser.ParseCode<Profile.ConstraintSeverity>(reader, errors);
                    
                    // Parse element human
                    else if( ParserUtils.IsAtFhirElement(reader, "human") )
                        result.Human = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element xpath
                    else if( ParserUtils.IsAtFhirElement(reader, "xpath") )
                        result.Xpath = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element ocl
                    else if( ParserUtils.IsAtFhirElement(reader, "ocl") )
                        result.Ocl = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ProfileExtensionDefnComponent
        /// </summary>
        public static Profile.ProfileExtensionDefnComponent ParseProfileExtensionDefnComponent(IFhirReader reader, ErrorList errors, Profile.ProfileExtensionDefnComponent existingInstance = null )
        {
            Profile.ProfileExtensionDefnComponent result = existingInstance != null ? existingInstance : new Profile.ProfileExtensionDefnComponent();
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
                        result.Id = IdParser.ParseId(reader, errors);
                    
                    // Parse element contextType
                    else if( ParserUtils.IsAtFhirElement(reader, "contextType") )
                        result.ContextType = CodeParser.ParseCode<Profile.ExtensionContext>(reader, errors);
                    
                    // Parse element context
                    else if( ParserUtils.IsAtFhirElement(reader, "context") )
                    {
                        result.Context = new List<FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "context") )
                            result.Context.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element definition
                    else if( ParserUtils.IsAtFhirElement(reader, "definition") )
                        result.Definition = ProfileParser.ParseElementDefinitionComponent(reader, errors);
                    
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
        /// Parse ElementDefinitionComponent
        /// </summary>
        public static Profile.ElementDefinitionComponent ParseElementDefinitionComponent(IFhirReader reader, ErrorList errors, Profile.ElementDefinitionComponent existingInstance = null )
        {
            Profile.ElementDefinitionComponent result = existingInstance != null ? existingInstance : new Profile.ElementDefinitionComponent();
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
                    
                    // Parse element short
                    else if( ParserUtils.IsAtFhirElement(reader, "short") )
                        result.Short = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element formal
                    else if( ParserUtils.IsAtFhirElement(reader, "formal") )
                        result.Formal = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element comments
                    else if( ParserUtils.IsAtFhirElement(reader, "comments") )
                        result.Comments = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element requirements
                    else if( ParserUtils.IsAtFhirElement(reader, "requirements") )
                        result.Requirements = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element synonym
                    else if( ParserUtils.IsAtFhirElement(reader, "synonym") )
                    {
                        result.Synonym = new List<FhirString>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "synonym") )
                            result.Synonym.Add(FhirStringParser.ParseFhirString(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element min
                    else if( ParserUtils.IsAtFhirElement(reader, "min") )
                        result.Min = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element max
                    else if( ParserUtils.IsAtFhirElement(reader, "max") )
                        result.Max = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                    {
                        result.Type = new List<Profile.TypeRefComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "type") )
                            result.Type.Add(ProfileParser.ParseTypeRefComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element nameReference
                    else if( ParserUtils.IsAtFhirElement(reader, "nameReference") )
                        result.NameReference = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element value
                    else if( ParserUtils.IsAtFhirElement(reader, "value", true) )
                        result.Value = FhirParser.ParseElement(reader, errors);
                    
                    // Parse element maxLength
                    else if( ParserUtils.IsAtFhirElement(reader, "maxLength") )
                        result.MaxLength = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element condition
                    else if( ParserUtils.IsAtFhirElement(reader, "condition") )
                    {
                        result.Condition = new List<Id>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "condition") )
                            result.Condition.Add(IdParser.ParseId(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element constraint
                    else if( ParserUtils.IsAtFhirElement(reader, "constraint") )
                    {
                        result.Constraint = new List<Profile.ElementDefinitionConstraintComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "constraint") )
                            result.Constraint.Add(ProfileParser.ParseElementDefinitionConstraintComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element mustSupport
                    else if( ParserUtils.IsAtFhirElement(reader, "mustSupport") )
                        result.MustSupport = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element mustUnderstand
                    else if( ParserUtils.IsAtFhirElement(reader, "mustUnderstand") )
                        result.MustUnderstand = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element binding
                    else if( ParserUtils.IsAtFhirElement(reader, "binding") )
                        result.Binding = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element mapping
                    else if( ParserUtils.IsAtFhirElement(reader, "mapping") )
                    {
                        result.Mapping = new List<Profile.ElementDefinitionMappingComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "mapping") )
                            result.Mapping.Add(ProfileParser.ParseElementDefinitionMappingComponent(reader, errors));
                        
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
        /// Parse ProfileImportComponent
        /// </summary>
        public static Profile.ProfileImportComponent ParseProfileImportComponent(IFhirReader reader, ErrorList errors, Profile.ProfileImportComponent existingInstance = null )
        {
            Profile.ProfileImportComponent result = existingInstance != null ? existingInstance : new Profile.ProfileImportComponent();
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
                    
                    // Parse element uri
                    else if( ParserUtils.IsAtFhirElement(reader, "uri") )
                        result.Uri = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element prefix
                    else if( ParserUtils.IsAtFhirElement(reader, "prefix") )
                        result.Prefix = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ProfileBindingComponent
        /// </summary>
        public static Profile.ProfileBindingComponent ParseProfileBindingComponent(IFhirReader reader, ErrorList errors, Profile.ProfileBindingComponent existingInstance = null )
        {
            Profile.ProfileBindingComponent result = existingInstance != null ? existingInstance : new Profile.ProfileBindingComponent();
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
                    
                    // Parse element definition
                    else if( ParserUtils.IsAtFhirElement(reader, "definition") )
                        result.Definition = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeParser.ParseCode<Profile.BindingType>(reader, errors);
                    
                    // Parse element isExtensible
                    else if( ParserUtils.IsAtFhirElement(reader, "isExtensible") )
                        result.IsExtensible = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element conformance
                    else if( ParserUtils.IsAtFhirElement(reader, "conformance") )
                        result.Conformance = CodeParser.ParseCode<Profile.BindingConformance>(reader, errors);
                    
                    // Parse element reference
                    else if( ParserUtils.IsAtFhirElement(reader, "reference") )
                        result.Reference = FhirUriParser.ParseFhirUri(reader, errors);
                    
                    // Parse element concept
                    else if( ParserUtils.IsAtFhirElement(reader, "concept") )
                    {
                        result.Concept = new List<Profile.CodeDefinitionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "concept") )
                            result.Concept.Add(ProfileParser.ParseCodeDefinitionComponent(reader, errors));
                        
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
        /// Parse ProfileStatusComponent
        /// </summary>
        public static Profile.ProfileStatusComponent ParseProfileStatusComponent(IFhirReader reader, ErrorList errors, Profile.ProfileStatusComponent existingInstance = null )
        {
            Profile.ProfileStatusComponent result = existingInstance != null ? existingInstance : new Profile.ProfileStatusComponent();
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
                        result.Code = CodeParser.ParseCode<Profile.ResourceProfileStatus>(reader, errors);
                    
                    // Parse element date
                    else if( ParserUtils.IsAtFhirElement(reader, "date") )
                        result.Date = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element comment
                    else if( ParserUtils.IsAtFhirElement(reader, "comment") )
                        result.Comment = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ElementDefinitionMappingComponent
        /// </summary>
        public static Profile.ElementDefinitionMappingComponent ParseElementDefinitionMappingComponent(IFhirReader reader, ErrorList errors, Profile.ElementDefinitionMappingComponent existingInstance = null )
        {
            Profile.ElementDefinitionMappingComponent result = existingInstance != null ? existingInstance : new Profile.ElementDefinitionMappingComponent();
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
                    
                    // Parse element target
                    else if( ParserUtils.IsAtFhirElement(reader, "target") )
                        result.Target = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element map
                    else if( ParserUtils.IsAtFhirElement(reader, "map") )
                        result.Map = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse ElementComponent
        /// </summary>
        public static Profile.ElementComponent ParseElementComponent(IFhirReader reader, ErrorList errors, Profile.ElementComponent existingInstance = null )
        {
            Profile.ElementComponent result = existingInstance != null ? existingInstance : new Profile.ElementComponent();
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
                    
                    // Parse element path
                    else if( ParserUtils.IsAtFhirElement(reader, "path") )
                        result.Path = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                        result.Name = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element definition
                    else if( ParserUtils.IsAtFhirElement(reader, "definition") )
                        result.Definition = ProfileParser.ParseElementDefinitionComponent(reader, errors);
                    
                    // Parse element bundled
                    else if( ParserUtils.IsAtFhirElement(reader, "bundled") )
                        result.Bundled = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
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
