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
    /// Parser for MedicationAdministration instances
    /// </summary>
    internal static partial class MedicationAdministrationParser
    {
        /// <summary>
        /// Parse MedicationAdministration
        /// </summary>
        public static MedicationAdministration ParseMedicationAdministration(IFhirReader reader, ErrorList errors, MedicationAdministration existingInstance = null )
        {
            MedicationAdministration result = existingInstance != null ? existingInstance : new MedicationAdministration();
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
                    
                    // Parse element administrationEventStatus
                    else if( ParserUtils.IsAtFhirElement(reader, "administrationEventStatus") )
                        result.AdministrationEventStatus = CodeParser.ParseCode<MedicationAdministration.MedicationAdministrationStatus>(reader, errors);
                    
                    // Parse element isNegated
                    else if( ParserUtils.IsAtFhirElement(reader, "isNegated") )
                        result.IsNegated = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element negatedReason
                    else if( ParserUtils.IsAtFhirElement(reader, "negatedReason") )
                    {
                        result.NegatedReason = new List<CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "negatedReason") )
                            result.NegatedReason.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element effectiveTime
                    else if( ParserUtils.IsAtFhirElement(reader, "effectiveTime") )
                        result.EffectiveTime = PeriodParser.ParsePeriod(reader, errors);
                    
                    // Parse element method
                    else if( ParserUtils.IsAtFhirElement(reader, "method") )
                        result.Method = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element approachSite
                    else if( ParserUtils.IsAtFhirElement(reader, "approachSite") )
                        result.ApproachSite = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element route
                    else if( ParserUtils.IsAtFhirElement(reader, "route") )
                        result.Route = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element administeredDose
                    else if( ParserUtils.IsAtFhirElement(reader, "administeredDose") )
                        result.AdministeredDose = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element doseRate
                    else if( ParserUtils.IsAtFhirElement(reader, "doseRate") )
                        result.DoseRate = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element id
                    else if( ParserUtils.IsAtFhirElement(reader, "id") )
                    {
                        result.Id = new List<Identifier>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "id") )
                            result.Id.Add(IdentifierParser.ParseIdentifier(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element prescription
                    else if( ParserUtils.IsAtFhirElement(reader, "prescription") )
                        result.Prescription = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element patient
                    else if( ParserUtils.IsAtFhirElement(reader, "patient") )
                        result.Patient = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element medication
                    else if( ParserUtils.IsAtFhirElement(reader, "medication") )
                    {
                        result.Medication = new List<CodeableConcept>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "medication") )
                            result.Medication.Add(CodeableConceptParser.ParseCodeableConcept(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element visit
                    else if( ParserUtils.IsAtFhirElement(reader, "visit") )
                        result.Visit = IdentifierParser.ParseIdentifier(reader, errors);
                    
                    // Parse element administrationDevice
                    else if( ParserUtils.IsAtFhirElement(reader, "administrationDevice") )
                    {
                        result.AdministrationDevice = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "administrationDevice") )
                            result.AdministrationDevice.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
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
