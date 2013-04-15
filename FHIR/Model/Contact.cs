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
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// All kinds of technology mediated contact details for a person or organisation, including telephone, email, etc.
    /// </summary>
    [FhirComposite("Contact")]
    public partial class Contact : Element
    {
        /// <summary>
        /// What kind of contact this is
        /// </summary>
        public enum ContactSystem
        {
            Phone, // The value is a telephone number used for voice calls. Use of full international numbers starting with + is recommended to enable automatic dialing support but not required.
            Fax, // The value is a fax machine. Use of full international numbers starting with + is recommended to enable automatic dialing support but not required.
            Email, // The value is an email address
            Url, // The value is a url. This is intended for various personal contacts including blogs, Twitter, Facebook, etc. Do not use for email addresses
        }
        
        /// <summary>
        /// Conversion of ContactSystemfrom and into string
        /// <summary>
        public static class ContactSystemHandling
        {
            public static bool TryParse(string value, out ContactSystem result)
            {
                result = default(ContactSystem);
                
                if( value=="phone")
                    result = ContactSystem.Phone;
                else if( value=="fax")
                    result = ContactSystem.Fax;
                else if( value=="email")
                    result = ContactSystem.Email;
                else if( value=="url")
                    result = ContactSystem.Url;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ContactSystem value)
            {
                if( value==ContactSystem.Phone )
                    return "phone";
                else if( value==ContactSystem.Fax )
                    return "fax";
                else if( value==ContactSystem.Email )
                    return "email";
                else if( value==ContactSystem.Url )
                    return "url";
                else
                    throw new ArgumentException("Unrecognized ContactSystem value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// How to use this address
        /// </summary>
        public enum ContactUse
        {
            Home, // A communication contact at a home; attempted contacts for business purposes might intrude privacy and chances are one will contact family or other household members instead of the person one wishes to call. Typically used with urgent cases, or if no other contacts are available.
            Work, // An office contact. First choice for business related contacts during business hours.
            Temp, // A temporary contact. The period can provide more detailed information.
            Old, // This contact is no longer in use (or was never correct, but retained for records)
            Mobile, // A telecommunication device that moves and stays with its owner. May have characteristics of all other use codes, suitable for urgent matters, not the first choice for routine business
        }
        
        /// <summary>
        /// Conversion of ContactUsefrom and into string
        /// <summary>
        public static class ContactUseHandling
        {
            public static bool TryParse(string value, out ContactUse result)
            {
                result = default(ContactUse);
                
                if( value=="home")
                    result = ContactUse.Home;
                else if( value=="work")
                    result = ContactUse.Work;
                else if( value=="temp")
                    result = ContactUse.Temp;
                else if( value=="old")
                    result = ContactUse.Old;
                else if( value=="mobile")
                    result = ContactUse.Mobile;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ContactUse value)
            {
                if( value==ContactUse.Home )
                    return "home";
                else if( value==ContactUse.Work )
                    return "work";
                else if( value==ContactUse.Temp )
                    return "temp";
                else if( value==ContactUse.Old )
                    return "old";
                else if( value==ContactUse.Mobile )
                    return "mobile";
                else
                    throw new ArgumentException("Unrecognized ContactUse value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// What kind of contact this is
        /// </summary>
        public Code<Contact.ContactSystem> System { get; set; }
        
        /// <summary>
        /// The actual contact details
        /// </summary>
        public FhirString Value { get; set; }
        
        /// <summary>
        /// How to use this address
        /// </summary>
        public Code<Contact.ContactUse> Use { get; set; }
        
        /// <summary>
        /// Time period when the contact was/is in use
        /// </summary>
        public Period Period { get; set; }
        
    }
    
}
