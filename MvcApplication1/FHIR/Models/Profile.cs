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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Resource Profile
    /// </summary>
    [FhirResource("Profile")]
    public partial class Profile : Resource
    {
        /// <summary>
        /// How this binding is mapped to a set of codes
        /// </summary>
        public enum BindingType
        {
            Valueset, // The binding name has an associated URL which is a reference to a Value Set Resource that provides a formal definition of the set of possible codes
            Codelist, // The binding name is associated with a simple list of codes, and definitions from some identified code system (SID, URI, OID, UUID). In resource definitions, the system reference may be omitted, and a list of custom codes with definitions supplied (this is for status and workflow fields that applications need to know)
            Reference, // The binding name has an associated URL which refers to some external standard or specification that defines the possible codes
            Special, // The binding points to a list of concepts defined as part of FHIR itself (see below for possible values)
        }
        
        /// <summary>
        /// Conversion of BindingTypefrom and into string
        /// <summary>
        public static class BindingTypeHandling
        {
            public static bool TryParse(string value, out BindingType result)
            {
                result = default(BindingType);
                
                if( value=="valueset")
                    result = BindingType.Valueset;
                else if( value=="codelist")
                    result = BindingType.Codelist;
                else if( value=="reference")
                    result = BindingType.Reference;
                else if( value=="special")
                    result = BindingType.Special;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(BindingType value)
            {
                if( value==BindingType.Valueset )
                    return "valueset";
                else if( value==BindingType.Codelist )
                    return "codelist";
                else if( value==BindingType.Reference )
                    return "reference";
                else if( value==BindingType.Special )
                    return "special";
                else
                    throw new ArgumentException("Unrecognized BindingType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Must applications comply with this binding?
        /// </summary>
        public enum BindingConformance
        {
            Required, // Only codes in the specified set are allowed.  If the binding is extensible, other codes may be used for concepts not covered by the bound set of codes
            Preferred, // For greater interoperability, implementers are strongly encouraged to use the bound set of codes, however alternate codes may be used in derived profiles and implementations if necessary without being considered non-conformant
            Example, // The codes in the set are an example to illustrate the meaning of the field. There is no particular preference for its use nor any assertion that the provided values are sufficient to meet implementation needs
        }
        
        /// <summary>
        /// Conversion of BindingConformancefrom and into string
        /// <summary>
        public static class BindingConformanceHandling
        {
            public static bool TryParse(string value, out BindingConformance result)
            {
                result = default(BindingConformance);
                
                if( value=="required")
                    result = BindingConformance.Required;
                else if( value=="preferred")
                    result = BindingConformance.Preferred;
                else if( value=="example")
                    result = BindingConformance.Example;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(BindingConformance value)
            {
                if( value==BindingConformance.Required )
                    return "required";
                else if( value==BindingConformance.Preferred )
                    return "preferred";
                else if( value==BindingConformance.Example )
                    return "example";
                else
                    throw new ArgumentException("Unrecognized BindingConformance value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Must applications comply with this constraint?
        /// </summary>
        public enum ConstraintSeverity
        {
            Error, // If the constraint is violated, the resource is not conformant
            Warning, // If the constraint is violated, the resource is conformant, but it is not necessarily following best practice.
        }
        
        /// <summary>
        /// Conversion of ConstraintSeverityfrom and into string
        /// <summary>
        public static class ConstraintSeverityHandling
        {
            public static bool TryParse(string value, out ConstraintSeverity result)
            {
                result = default(ConstraintSeverity);
                
                if( value=="error")
                    result = ConstraintSeverity.Error;
                else if( value=="warning")
                    result = ConstraintSeverity.Warning;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ConstraintSeverity value)
            {
                if( value==ConstraintSeverity.Error )
                    return "error";
                else if( value==ConstraintSeverity.Warning )
                    return "warning";
                else
                    throw new ArgumentException("Unrecognized ConstraintSeverity value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// The lifecycle status of a Resource Profile
        /// </summary>
        public enum ResourceProfileStatus
        {
            Draft, // This profile is still under development
            Testing, // This profile was authored for testing purposes (or education/evaluation/marketing)
            Review, // This profile is undergoing review to check that it is ready for production use
            Production, // This profile is ready for use in production systems
            Withdrawn, // This profile has been withdrawn and should no longer be used
            Superseded, // This profile has been replaced and a different valueset should be used in its place
        }
        
        /// <summary>
        /// Conversion of ResourceProfileStatusfrom and into string
        /// <summary>
        public static class ResourceProfileStatusHandling
        {
            public static bool TryParse(string value, out ResourceProfileStatus result)
            {
                result = default(ResourceProfileStatus);
                
                if( value=="draft")
                    result = ResourceProfileStatus.Draft;
                else if( value=="testing")
                    result = ResourceProfileStatus.Testing;
                else if( value=="review")
                    result = ResourceProfileStatus.Review;
                else if( value=="production")
                    result = ResourceProfileStatus.Production;
                else if( value=="withdrawn")
                    result = ResourceProfileStatus.Withdrawn;
                else if( value=="superseded")
                    result = ResourceProfileStatus.Superseded;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ResourceProfileStatus value)
            {
                if( value==ResourceProfileStatus.Draft )
                    return "draft";
                else if( value==ResourceProfileStatus.Testing )
                    return "testing";
                else if( value==ResourceProfileStatus.Review )
                    return "review";
                else if( value==ResourceProfileStatus.Production )
                    return "production";
                else if( value==ResourceProfileStatus.Withdrawn )
                    return "withdrawn";
                else if( value==ResourceProfileStatus.Superseded )
                    return "superseded";
                else
                    throw new ArgumentException("Unrecognized ResourceProfileStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// How an extension context is interpreted
        /// </summary>
        public enum ExtensionContext
        {
            Resource, // The context is all elements matching a particular resource element path
            Datatype, // The context is all nodes matching a particular data type element path (root or repeating element) or all elements referencing a particular primitive data type (expressed as the datatype name)
            Mapping, // The context is all nodes whose mapping to a specified reference model corresponds to a particular mapping structure.  The context identifies the mapping target. The mapping should clearly identify where such an extension could be used, though this
            Extension, // The context is a particular extension from a particular profile.  Expressed as uri#name, where uri identifies the profile and #name identifies the extension code
        }
        
        /// <summary>
        /// Conversion of ExtensionContextfrom and into string
        /// <summary>
        public static class ExtensionContextHandling
        {
            public static bool TryParse(string value, out ExtensionContext result)
            {
                result = default(ExtensionContext);
                
                if( value=="resource")
                    result = ExtensionContext.Resource;
                else if( value=="datatype")
                    result = ExtensionContext.Datatype;
                else if( value=="mapping")
                    result = ExtensionContext.Mapping;
                else if( value=="extension")
                    result = ExtensionContext.Extension;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ExtensionContext value)
            {
                if( value==ExtensionContext.Resource )
                    return "resource";
                else if( value==ExtensionContext.Datatype )
                    return "datatype";
                else if( value==ExtensionContext.Mapping )
                    return "mapping";
                else if( value==ExtensionContext.Extension )
                    return "extension";
                else
                    throw new ArgumentException("Unrecognized ExtensionContext value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProfileConstraintSearchParamComponent")]
        public partial class ProfileConstraintSearchParamComponent : Element
        {
            /// <summary>
            /// Name of search parameter
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Type of search parameter
            /// </summary>
            public Code<SearchParamType> Type { get; set; }
            
            /// <summary>
            /// If multiples are allowed, and what it means
            /// </summary>
            public Code<SearchRepeatBehavior> Repeats { get; set; }
            
            /// <summary>
            /// Contents and meaning of search parameter
            /// </summary>
            public FhirString Documentation { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProfileConstraintComponent")]
        public partial class ProfileConstraintComponent : Element
        {
            /// <summary>
            /// The Resource or Data Type being described
            /// </summary>
            public Code Type { get; set; }
            
            /// <summary>
            /// Name for this particular resource profile (internal usage)
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Human summary: why describe this resource?
            /// </summary>
            public FhirString Purpose { get; set; }
            
            /// <summary>
            /// Resource Profile reference (supplies the constraints)
            /// </summary>
            public FhirUri Profile { get; set; }
            
            /// <summary>
            /// Definition of elements in the resource (if no profile)
            /// </summary>
            public List<ElementComponent> Element { get; set; }
            
            /// <summary>
            /// Additional search params defined
            /// </summary>
            public List<ProfileConstraintSearchParamComponent> SearchParam { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("CodeDefinitionComponent")]
        public partial class CodeDefinitionComponent : Element
        {
            /// <summary>
            /// Code to use for this concept
            /// </summary>
            public FhirString Code { get; set; }
            
            /// <summary>
            /// Source for the code, if taken from another system
            /// </summary>
            public FhirUri System { get; set; }
            
            /// <summary>
            /// Print name - defaults to code
            /// </summary>
            public FhirString Display { get; set; }
            
            /// <summary>
            /// Meaning of the concept
            /// </summary>
            public FhirString Definition { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("AuthorComponent")]
        public partial class AuthorComponent : Element
        {
            /// <summary>
            /// Name of the recognized author
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// How the author contributed
            /// </summary>
            public FhirString Role { get; set; }
            
            /// <summary>
            /// Contact information of the author
            /// </summary>
            public List<Contact> Telecom { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("TypeRefComponent")]
        public partial class TypeRefComponent : Element
        {
            /// <summary>
            /// Data type or Resource
            /// </summary>
            public Code Code { get; set; }
            
            /// <summary>
            /// Profile to apply
            /// </summary>
            public FhirUri Profile { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ElementDefinitionConstraintComponent")]
        public partial class ElementDefinitionConstraintComponent : Element
        {
            /// <summary>
            /// Target of 'condition' reference above
            /// </summary>
            public Id Id { get; set; }
            
            /// <summary>
            /// Short human label
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// error | warning
            /// </summary>
            public Code<Profile.ConstraintSeverity> Severity { get; set; }
            
            /// <summary>
            /// Human description of constraint
            /// </summary>
            public FhirString Human { get; set; }
            
            /// <summary>
            /// XPath expression of constraint
            /// </summary>
            public FhirString Xpath { get; set; }
            
            /// <summary>
            /// OCL expression of constraint
            /// </summary>
            public FhirString Ocl { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProfileExtensionDefnComponent")]
        public partial class ProfileExtensionDefnComponent : Element
        {
            /// <summary>
            /// Identifies the extension in this profile
            /// </summary>
            public Id Id { get; set; }
            
            /// <summary>
            /// resource | datatype | mapping | extension
            /// </summary>
            public Code<Profile.ExtensionContext> ContextType { get; set; }
            
            /// <summary>
            /// Where the extension can be used in instances
            /// </summary>
            public List<FhirString> Context { get; set; }
            
            /// <summary>
            /// Definition of the extension and its content
            /// </summary>
            public ElementDefinitionComponent Definition { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ElementDefinitionComponent")]
        public partial class ElementDefinitionComponent : Element
        {
            /// <summary>
            /// Concise definition for xml presentation
            /// </summary>
            public FhirString Short { get; set; }
            
            /// <summary>
            /// Formal definition
            /// </summary>
            public FhirString Formal { get; set; }
            
            /// <summary>
            /// Comments about the use of this element
            /// </summary>
            public FhirString Comments { get; set; }
            
            /// <summary>
            /// Why is this needed?
            /// </summary>
            public FhirString Requirements { get; set; }
            
            /// <summary>
            /// Other names
            /// </summary>
            public List<FhirString> Synonym { get; set; }
            
            /// <summary>
            /// Minimum Cardinality
            /// </summary>
            public Integer Min { get; set; }
            
            /// <summary>
            /// Maximum Cardinality (a number or *)
            /// </summary>
            public FhirString Max { get; set; }
            
            /// <summary>
            /// Type of the element
            /// </summary>
            public List<TypeRefComponent> Type { get; set; }
            
            /// <summary>
            /// To another element constraint (by element.name)
            /// </summary>
            public FhirString NameReference { get; set; }
            
            /// <summary>
            /// Fixed value: [as defined for type]
            /// </summary>
            public Element Value { get; set; }
            
            /// <summary>
            /// Length for strings
            /// </summary>
            public Integer MaxLength { get; set; }
            
            /// <summary>
            /// Reference to invariant about presence
            /// </summary>
            public List<Id> Condition { get; set; }
            
            /// <summary>
            /// Condition that must evaluate to true
            /// </summary>
            public List<ElementDefinitionConstraintComponent> Constraint { get; set; }
            
            /// <summary>
            /// If the element must be usable
            /// </summary>
            public FhirBoolean MustSupport { get; set; }
            
            /// <summary>
            /// If the element must be understood
            /// </summary>
            public FhirBoolean MustUnderstand { get; set; }
            
            /// <summary>
            /// Binding - see bindings below (only if coded)
            /// </summary>
            public FhirString Binding { get; set; }
            
            /// <summary>
            /// Map element to another set of definitions
            /// </summary>
            public List<ElementDefinitionMappingComponent> Mapping { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProfileImportComponent")]
        public partial class ProfileImportComponent : Element
        {
            /// <summary>
            /// Profile location
            /// </summary>
            public FhirUri Uri { get; set; }
            
            /// <summary>
            /// Short form for referencing
            /// </summary>
            public FhirString Prefix { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProfileBindingComponent")]
        public partial class ProfileBindingComponent : Element
        {
            /// <summary>
            /// Binding name
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Human explanation of the binding
            /// </summary>
            public FhirString Definition { get; set; }
            
            /// <summary>
            /// valueset | codelist | reference | special
            /// </summary>
            public Code<Profile.BindingType> Type { get; set; }
            
            /// <summary>
            /// Can additional codes be used?
            /// </summary>
            public FhirBoolean IsExtensible { get; set; }
            
            /// <summary>
            /// required | preferred | example
            /// </summary>
            public Code<Profile.BindingConformance> Conformance { get; set; }
            
            /// <summary>
            /// Source of binding content
            /// </summary>
            public FhirUri Reference { get; set; }
            
            /// <summary>
            /// Enumerated codes that are the binding
            /// </summary>
            public List<CodeDefinitionComponent> Concept { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProfileStatusComponent")]
        public partial class ProfileStatusComponent : Element
        {
            /// <summary>
            /// draft | testing | review | production | withdrawn | superseded
            /// </summary>
            public Code<Profile.ResourceProfileStatus> Code { get; set; }
            
            /// <summary>
            /// Date for given status
            /// </summary>
            public FhirDateTime Date { get; set; }
            
            /// <summary>
            /// Supplemental status info
            /// </summary>
            public FhirString Comment { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ElementDefinitionMappingComponent")]
        public partial class ElementDefinitionMappingComponent : Element
        {
            /// <summary>
            /// Which mapping this is (v2, CDA, openEHR, etc.)
            /// </summary>
            public FhirString Target { get; set; }
            
            /// <summary>
            /// Details of the mapping
            /// </summary>
            public FhirString Map { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ElementComponent")]
        public partial class ElementComponent : Element
        {
            /// <summary>
            /// The path of the element (see the formal definitions)
            /// </summary>
            public FhirString Path { get; set; }
            
            /// <summary>
            /// Name of constraint for slicing - see above
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// More specific definition of the element
            /// </summary>
            public ElementDefinitionComponent Definition { get; set; }
            
            /// <summary>
            /// If type is Resource, is it in the bundle?
            /// </summary>
            public FhirBoolean Bundled { get; set; }
            
        }
        
        
        /// <summary>
        /// Informal name for this profile
        /// </summary>
        public FhirString Name { get; set; }
        
        /// <summary>
        /// Used by external version specific references
        /// </summary>
        public FhirString Version { get; set; }
        
        /// <summary>
        /// (Organization or individual)
        /// </summary>
        public List<AuthorComponent> Author { get; set; }
        
        /// <summary>
        /// Natural language description of the profile
        /// </summary>
        public FhirString Description { get; set; }
        
        /// <summary>
        /// Assist with indexing and finding
        /// </summary>
        public List<Coding> Code { get; set; }
        
        /// <summary>
        /// Current status
        /// </summary>
        public ProfileStatusComponent Status { get; set; }
        
        /// <summary>
        /// External source of extensions and bindings
        /// </summary>
        public List<ProfileImportComponent> Import { get; set; }
        
        /// <summary>
        /// If this describes a bundle, the first resource in the bundle
        /// </summary>
        public Code Bundle { get; set; }
        
        /// <summary>
        /// A constraint on a resource or a data type
        /// </summary>
        public List<ProfileConstraintComponent> Constraint { get; set; }
        
        /// <summary>
        /// Definition of an extension
        /// </summary>
        public List<ProfileExtensionDefnComponent> ExtensionDefn { get; set; }
        
        /// <summary>
        /// Define code sets for coded elements
        /// </summary>
        public List<ProfileBindingComponent> Binding { get; set; }
        
    }
    
}
