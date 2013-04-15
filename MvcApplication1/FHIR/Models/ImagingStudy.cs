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
    /// Manifest of a set of images produced in study
    /// </summary>
    [FhirResource("ImagingStudy")]
    public partial class ImagingStudy : Resource
    {
        /// <summary>
        /// Type of the image capturing machinery
        /// </summary>
        public enum ImageModality
        {
            XC, // External Camera (Photography)
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
        /// Conversion of ImageModalityfrom and into string
        /// <summary>
        public static class ImageModalityHandling
        {
            public static bool TryParse(string value, out ImageModality result)
            {
                result = default(ImageModality);
                
                if( value=="XC")
                    result = ImageModality.XC;
                else if( value=="DIA")
                    result = ImageModality.DIA;
                else if( value=="BI")
                    result = ImageModality.BI;
                else if( value=="CR")
                    result = ImageModality.CR;
                else if( value=="CT")
                    result = ImageModality.CT;
                else if( value=="DG")
                    result = ImageModality.DG;
                else if( value=="DX")
                    result = ImageModality.DX;
                else if( value=="ECG")
                    result = ImageModality.ECG;
                else if( value=="EM")
                    result = ImageModality.EM;
                else if( value=="ES")
                    result = ImageModality.ES;
                else if( value=="GM")
                    result = ImageModality.GM;
                else if( value=="LS")
                    result = ImageModality.LS;
                else if( value=="MG")
                    result = ImageModality.MG;
                else if( value=="MR")
                    result = ImageModality.MR;
                else if( value=="NM")
                    result = ImageModality.NM;
                else if( value=="OP")
                    result = ImageModality.OP;
                else if( value=="OPM")
                    result = ImageModality.OPM;
                else if( value=="OPR")
                    result = ImageModality.OPR;
                else if( value=="OPV")
                    result = ImageModality.OPV;
                else if( value=="PT")
                    result = ImageModality.PT;
                else if( value=="RD")
                    result = ImageModality.RD;
                else if( value=="RF")
                    result = ImageModality.RF;
                else if( value=="RG")
                    result = ImageModality.RG;
                else if( value=="RTIMAG")
                    result = ImageModality.RTIMAG;
                else if( value=="RP")
                    result = ImageModality.RP;
                else if( value=="RS")
                    result = ImageModality.RS;
                else if( value=="RT")
                    result = ImageModality.RT;
                else if( value=="SC")
                    result = ImageModality.SC;
                else if( value=="SM")
                    result = ImageModality.SM;
                else if( value=="SR")
                    result = ImageModality.SR;
                else if( value=="TG")
                    result = ImageModality.TG;
                else if( value=="US")
                    result = ImageModality.US;
                else if( value=="VL")
                    result = ImageModality.VL;
                else if( value=="XA")
                    result = ImageModality.XA;
                else if( value=="HC")
                    result = ImageModality.HC;
                else if( value=="OT")
                    result = ImageModality.OT;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ImageModality value)
            {
                if( value==ImageModality.XC )
                    return "XC";
                else if( value==ImageModality.DIA )
                    return "DIA";
                else if( value==ImageModality.BI )
                    return "BI";
                else if( value==ImageModality.CR )
                    return "CR";
                else if( value==ImageModality.CT )
                    return "CT";
                else if( value==ImageModality.DG )
                    return "DG";
                else if( value==ImageModality.DX )
                    return "DX";
                else if( value==ImageModality.ECG )
                    return "ECG";
                else if( value==ImageModality.EM )
                    return "EM";
                else if( value==ImageModality.ES )
                    return "ES";
                else if( value==ImageModality.GM )
                    return "GM";
                else if( value==ImageModality.LS )
                    return "LS";
                else if( value==ImageModality.MG )
                    return "MG";
                else if( value==ImageModality.MR )
                    return "MR";
                else if( value==ImageModality.NM )
                    return "NM";
                else if( value==ImageModality.OP )
                    return "OP";
                else if( value==ImageModality.OPM )
                    return "OPM";
                else if( value==ImageModality.OPR )
                    return "OPR";
                else if( value==ImageModality.OPV )
                    return "OPV";
                else if( value==ImageModality.PT )
                    return "PT";
                else if( value==ImageModality.RD )
                    return "RD";
                else if( value==ImageModality.RF )
                    return "RF";
                else if( value==ImageModality.RG )
                    return "RG";
                else if( value==ImageModality.RTIMAG )
                    return "RTIMAG";
                else if( value==ImageModality.RP )
                    return "RP";
                else if( value==ImageModality.RS )
                    return "RS";
                else if( value==ImageModality.RT )
                    return "RT";
                else if( value==ImageModality.SC )
                    return "SC";
                else if( value==ImageModality.SM )
                    return "SM";
                else if( value==ImageModality.SR )
                    return "SR";
                else if( value==ImageModality.TG )
                    return "TG";
                else if( value==ImageModality.US )
                    return "US";
                else if( value==ImageModality.VL )
                    return "VL";
                else if( value==ImageModality.XA )
                    return "XA";
                else if( value==ImageModality.HC )
                    return "HC";
                else if( value==ImageModality.OT )
                    return "OT";
                else
                    throw new ArgumentException("Unrecognized ImageModality value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImagingStudySeriesComponent")]
        public partial class ImagingStudySeriesComponent : Element
        {
            /// <summary>
            /// Number of this series in overall sequence (0020,0011)
            /// </summary>
            public Integer Number { get; set; }
            
            /// <summary>
            /// The modality of this sequence (0008,0060)
            /// </summary>
            public Code<ImagingStudy.ImageModality> Modality { get; set; }
            
            /// <summary>
            /// When the series started
            /// </summary>
            public FhirDateTime Datetime { get; set; }
            
            /// <summary>
            /// Formal identifier for this series (0020,000E)
            /// </summary>
            public Oid Uid { get; set; }
            
            /// <summary>
            /// A description of the series (0008,103E)
            /// </summary>
            public FhirString Description { get; set; }
            
            /// <summary>
            /// Body part examined (0018,0015)
            /// </summary>
            public Coding BodySite { get; set; }
            
            /// <summary>
            /// A single image taken from a patient
            /// </summary>
            public List<ImagingStudySeriesImageComponent> Image { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImagingStudySeriesImageComponent")]
        public partial class ImagingStudySeriesImageComponent : Element
        {
            /// <summary>
            /// The number of this image in the series (0020,0013)
            /// </summary>
            public Integer Number { get; set; }
            
            /// <summary>
            /// When this image was taken
            /// </summary>
            public FhirDateTime DateTime { get; set; }
            
            /// <summary>
            /// Formal identifier for this image (0008,0018)
            /// </summary>
            public Oid Uid { get; set; }
            
            /// <summary>
            /// DICOM Image type (0008,0016)
            /// </summary>
            public Oid DicomClass { get; set; }
            
            /// <summary>
            /// WADO service where image is available
            /// </summary>
            public FhirUri Url { get; set; }
            
        }
        
        
        /// <summary>
        /// Shortname
        /// </summary>
        public FhirDateTime DateTime { get; set; }
        
        /// <summary>
        /// Who the images are of
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Formal identifier for the study (0020,000D)
        /// </summary>
        public Oid Uid { get; set; }
        
        /// <summary>
        /// Other identifiers for the study (0020,0010)
        /// </summary>
        public List<Identifier> Identifier { get; set; }
        
        /// <summary>
        /// Requesting physician (0008,0090)
        /// </summary>
        public ResourceReference Requester { get; set; }
        
        /// <summary>
        /// Accession Number (0008,0050)
        /// </summary>
        public Identifier AccessionNo { get; set; }
        
        /// <summary>
        /// Diagnoses etc with request (0008,1080)
        /// </summary>
        public FhirString ClinicalInformation { get; set; }
        
        /// <summary>
        /// Type of procedure performed (0008,1032)
        /// </summary>
        public List<Coding> Procedure { get; set; }
        
        /// <summary>
        /// Who interpreted images (0008,1060)
        /// </summary>
        public ResourceReference Interpreter { get; set; }
        
        /// <summary>
        /// Institution-generated description (0008,1030)
        /// </summary>
        public FhirString Description { get; set; }
        
        /// <summary>
        /// Each study has one or more series of image instances
        /// </summary>
        public List<ImagingStudySeriesComponent> Series { get; set; }
        
    }
    
}
