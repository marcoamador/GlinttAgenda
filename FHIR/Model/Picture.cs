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
    /// An Image used in healthcare. The actual pixels maybe inline or provided by direct reference
    /// </summary>
    [FhirResource("Picture")]
    public partial class Picture : Resource
    {
        /// <summary>
        /// Type of the image capturing machinery
        /// </summary>
        public enum ImageModality3
        {
            XC, // External Camera (Photography - Still picture)
            VC, // Video Camera (Moving picture)
            DIA, // Diagram / Hand drawn image
            BI, // Biomagnetic Imaging
            CR, // Computed Radiography
            CT, // Computed Tomography
            DG, // Diaphanography
            DX, // Digital Radiography
            ECG, // Electrocardiograms
            EM, // Electron Microscope
            ES, // Endoscopy
            GM, // General Microscopy
            LS, // Laser Surface Scan
            MG, // Mammography
            MR, // Magnetic Resonance
            NM, // Nuclear Medicine
            OP, // Ophthalmic Photography
            OPM, // Ophthalmic Mapping
            OPR, // Ophthalmic Refraction
            OPV, // Ophthalmic Visual Field
            PT, // Positron Emission Tomography (PET)
            RD, // Radiotherapy Dose (a.k.a. RTDOSE)
            RF, // Radio Fluoroscopy
            RG, // Radiographic Imaging (conventional film screen)
            RTIMAG, // Radiotherapy Image
            RP, // Radiotherapy Plan (a.k.a. RTPLAN)
            RS, // Radiotherapy Structure Set (a.k.a. RTSTRUCT)
            RT, // Radiation Therapy
            SC, // Secondary Capture
            SM, // Slide Microscopy
            SR, // Structured Reporting
            TG, // Thermography
            US, // Ultrasound
            VL, // Visible Light
            XA, // X-Ray Angiography
            HC, // Hard Copy
            OT, // Other
        }
        
        /// <summary>
        /// Conversion of ImageModality3from and into string
        /// <summary>
        public static class ImageModality3Handling
        {
            public static bool TryParse(string value, out ImageModality3 result)
            {
                result = default(ImageModality3);
                
                if( value=="XC")
                    result = ImageModality3.XC;
                else if( value=="VC")
                    result = ImageModality3.VC;
                else if( value=="DIA")
                    result = ImageModality3.DIA;
                else if( value=="BI")
                    result = ImageModality3.BI;
                else if( value=="CR")
                    result = ImageModality3.CR;
                else if( value=="CT")
                    result = ImageModality3.CT;
                else if( value=="DG")
                    result = ImageModality3.DG;
                else if( value=="DX")
                    result = ImageModality3.DX;
                else if( value=="ECG")
                    result = ImageModality3.ECG;
                else if( value=="EM")
                    result = ImageModality3.EM;
                else if( value=="ES")
                    result = ImageModality3.ES;
                else if( value=="GM")
                    result = ImageModality3.GM;
                else if( value=="LS")
                    result = ImageModality3.LS;
                else if( value=="MG")
                    result = ImageModality3.MG;
                else if( value=="MR")
                    result = ImageModality3.MR;
                else if( value=="NM")
                    result = ImageModality3.NM;
                else if( value=="OP")
                    result = ImageModality3.OP;
                else if( value=="OPM")
                    result = ImageModality3.OPM;
                else if( value=="OPR")
                    result = ImageModality3.OPR;
                else if( value=="OPV")
                    result = ImageModality3.OPV;
                else if( value=="PT")
                    result = ImageModality3.PT;
                else if( value=="RD")
                    result = ImageModality3.RD;
                else if( value=="RF")
                    result = ImageModality3.RF;
                else if( value=="RG")
                    result = ImageModality3.RG;
                else if( value=="RTIMAG")
                    result = ImageModality3.RTIMAG;
                else if( value=="RP")
                    result = ImageModality3.RP;
                else if( value=="RS")
                    result = ImageModality3.RS;
                else if( value=="RT")
                    result = ImageModality3.RT;
                else if( value=="SC")
                    result = ImageModality3.SC;
                else if( value=="SM")
                    result = ImageModality3.SM;
                else if( value=="SR")
                    result = ImageModality3.SR;
                else if( value=="TG")
                    result = ImageModality3.TG;
                else if( value=="US")
                    result = ImageModality3.US;
                else if( value=="VL")
                    result = ImageModality3.VL;
                else if( value=="XA")
                    result = ImageModality3.XA;
                else if( value=="HC")
                    result = ImageModality3.HC;
                else if( value=="OT")
                    result = ImageModality3.OT;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ImageModality3 value)
            {
                if( value==ImageModality3.XC )
                    return "XC";
                else if( value==ImageModality3.VC )
                    return "VC";
                else if( value==ImageModality3.DIA )
                    return "DIA";
                else if( value==ImageModality3.BI )
                    return "BI";
                else if( value==ImageModality3.CR )
                    return "CR";
                else if( value==ImageModality3.CT )
                    return "CT";
                else if( value==ImageModality3.DG )
                    return "DG";
                else if( value==ImageModality3.DX )
                    return "DX";
                else if( value==ImageModality3.ECG )
                    return "ECG";
                else if( value==ImageModality3.EM )
                    return "EM";
                else if( value==ImageModality3.ES )
                    return "ES";
                else if( value==ImageModality3.GM )
                    return "GM";
                else if( value==ImageModality3.LS )
                    return "LS";
                else if( value==ImageModality3.MG )
                    return "MG";
                else if( value==ImageModality3.MR )
                    return "MR";
                else if( value==ImageModality3.NM )
                    return "NM";
                else if( value==ImageModality3.OP )
                    return "OP";
                else if( value==ImageModality3.OPM )
                    return "OPM";
                else if( value==ImageModality3.OPR )
                    return "OPR";
                else if( value==ImageModality3.OPV )
                    return "OPV";
                else if( value==ImageModality3.PT )
                    return "PT";
                else if( value==ImageModality3.RD )
                    return "RD";
                else if( value==ImageModality3.RF )
                    return "RF";
                else if( value==ImageModality3.RG )
                    return "RG";
                else if( value==ImageModality3.RTIMAG )
                    return "RTIMAG";
                else if( value==ImageModality3.RP )
                    return "RP";
                else if( value==ImageModality3.RS )
                    return "RS";
                else if( value==ImageModality3.RT )
                    return "RT";
                else if( value==ImageModality3.SC )
                    return "SC";
                else if( value==ImageModality3.SM )
                    return "SM";
                else if( value==ImageModality3.SR )
                    return "SR";
                else if( value==ImageModality3.TG )
                    return "TG";
                else if( value==ImageModality3.US )
                    return "US";
                else if( value==ImageModality3.VL )
                    return "VL";
                else if( value==ImageModality3.XA )
                    return "XA";
                else if( value==ImageModality3.HC )
                    return "HC";
                else if( value==ImageModality3.OT )
                    return "OT";
                else
                    throw new ArgumentException("Unrecognized ImageModality3 value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// Who/What this image is taken of
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// When the image was taken
        /// </summary>
        public FhirDateTime DateTime { get; set; }
        
        /// <summary>
        /// The person who generated the image
        /// </summary>
        public ResourceReference Operator { get; set; }
        
        /// <summary>
        /// Identifier for the image
        /// </summary>
        public Identifier Identifier { get; set; }
        
        /// <summary>
        /// Used by the requester to link back to the original context
        /// </summary>
        public Identifier AccessionNo { get; set; }
        
        /// <summary>
        /// The session in which the picture was taken
        /// </summary>
        public Identifier StudyId { get; set; }
        
        /// <summary>
        /// The series of images in which this picture was taken
        /// </summary>
        public Identifier SeriesId { get; set; }
        
        /// <summary>
        /// How the image was taken
        /// </summary>
        public CodeableConcept Method { get; set; }
        
        /// <summary>
        /// Who asked that this image be collected
        /// </summary>
        public ResourceReference Requester { get; set; }
        
        /// <summary>
        /// Type of the image capturing machinery
        /// </summary>
        public Code<Picture.ImageModality3> Modality { get; set; }
        
        /// <summary>
        /// Name of the manufacturer
        /// </summary>
        public FhirString DeviceName { get; set; }
        
        /// <summary>
        /// Height of the image
        /// </summary>
        public Integer Height { get; set; }
        
        /// <summary>
        /// Width of the image
        /// </summary>
        public Integer Width { get; set; }
        
        /// <summary>
        /// Number of bits of colour (2..32)
        /// </summary>
        public Integer Bits { get; set; }
        
        /// <summary>
        /// Number of frames
        /// </summary>
        public Integer Frames { get; set; }
        
        /// <summary>
        /// Length of time between frames
        /// </summary>
        public Duration FrameDelay { get; set; }
        
        /// <summary>
        /// Imaging view e.g Lateral or Antero-posterior (AP)
        /// </summary>
        public CodeableConcept View { get; set; }
        
        /// <summary>
        /// Actual picture - reference or data
        /// </summary>
        public Attachment Content { get; set; }
        
    }
    
}
