﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OopFactory.X12.Hipaa.Claims.Forms.Professional
{
    public class HCFA1500Claim
    {
        /*
         * 2011/8/16, jhalliday - New Data Model for 837P (Professional) claim.
         * 
         * Team: dstrubhar, jhalliday and epkrause
         * 
         * Purpose:
         * To create a C# object model that will serve as a container for the X12 837P data
         * AS ENTERED from a HCFA 1500 Professional claim form.
         * 
         * Goal:
         * The team has the overall goal of creating tools that can be used to consume and
         * manipulate X12 messages (AKA files/documents) without the need to have a big project
         * budget.  For that reason, this and the related X12 Parser project tools are all open
         * source and freely usable.
         */

        // Fields in the HCFA1500 object model are defined in the order they appear on the HCFA1500 form.

        public bool Field01_TypeOfCoverageIsMedicare { get; set; }
        public bool Field01_TypeOfCoverageIsMedicaid { get; set; }
        public bool Field01_TypeOfCoverageIsTricareChampus { get; set; }
        public bool Field01_TypeOfCoverageIsChampVa { get; set; }
        public bool Field01_TypeOfCoverageIsGroupHealthPlan { get; set; }
        public bool Field01_TypeOfCoverageIsFECABlkLung { get; set; }
        public bool Field01_TypeOfCoverageIsOther { get; set; }
        public string Field01b_InsuredsIDNumber  { get; set; }
        public string Field02_PatientsLastName   { get; set; }                              // HCFA 1500 standard allows 29 total characters for these (3) fields
        public string Field02_PatientsFirstName  { get; set; }
        public string Field02_PatientsMiddleName  { get; set; }
        public DateTime? Field03_PatientsDateOfBirth   { get; set; }                           // MMDDCCYY - 8 characters
        public bool? Field03_PatientsSexMale  { get; set; }
        public bool? Field03_PatientsSexFemale { get; set; }  
        public string Field04_InsuredsLastName  { get; set; }                              // HCFA 1500 standard allows 29 total characters for these (3) fields
        public string Field04_InsuredsFirstName  { get; set; }
        public string Field04_InsuredsMiddleName { get; set; }
        public string Field05_PatientsAddress_Street  { get; set; }                         // 28 characters
        public string Field05_PatientsAddress_City  { get; set; }                           // 24 characters
        public string Field05_PatientsAddress_State { get; set; }                           // 3 characters
        public string Field05_PatientsAddress_Zip { get; set; }                             // 12 characters
        public string Field05_PatientsAreaCode { get; set; }                                // 3 digits
        public string Field05_PatientsPhoneNumber { get; set; }                             // 10 digits
        public bool Field06_PatientRelationshipToInsuredIsSelf { get; set; }
        public bool Field06_PatientRelationshipToInsuredIsSpouseOf { get; set; }
        public bool Field06_PatientRelationshipToInsuredIsChildOf { get; set; }
        public bool Field06_PatientRelationshipToInsuredIsOther { get; set; }
        public string Field07_InsuredsAddress_Street { get; set; }                         // 29 characters (yes, '29' not 28)
        public string Field07_InsuredsAddress_City { get; set; }                           // 23 characters (yes, '23' not 24)
        public string Field07_InsuredsAddress_State { get; set; }                           // 4 characters (yes, '4' not 3)
        public string Field07_InsuredsAddress_Zip { get; set; }                            // 12 characters
        public string Field07_InsuredsAreaCode { get; set; }                                // 3 digits
        public string Field07_InsuredsPhoneNumber { get; set; }                             // 10 digits
        public bool Field08_PatientStatusSingle { get; set; }
        public bool Field08_PatientStatusMarried { get; set; }
        public bool Field08_PatientStatusOther { get; set; }
        public bool Field08_PatientStatusEmployed { get; set; }
        public bool Field08_PatientStatusFullTimeStudent { get; set; }
        public bool Field08_PatientStatusPartTimeStudent { get; set; }
        public string Field09_OtherInsuredsLastName { get; set; }                           // HCFA 1500 standard allows 28 total characters for these (3) fields
        public string Field09_OtherInsuredsFirstName { get; set; } 
        public string Field09_OtherInsuredsMiddleName { get; set; } 
        public string Field09a_OtherInsuredsPolicyOrGroup { get; set; }                     // 28 characters
        public DateTime? Field09b_OtherInsuredsDateOfBirth { get; set; }                       // MMDDCCYY - 8 characters, goes to DMG02 (page 151) from X12 spec.
        public bool Field09b_OtherInsuredIsMale { get; set; }                               // 1 = Male, 2 = Female;  1 character.
        public bool Field09b_OtherInsuredIsFemale { get; set; }
        public string Field09c_OtherInsuredsEmployerNameOrSchoolName { get; set; }          // 28 characters
        public string Field09d_OtherInsuredsInsurancePlanNameOrProgramName  { get; set; }   // 28 characters
        public bool Field10a_PatientConditionRelatedToEmployment { get; set; }           // 1 = Yes, 2 = No
        public bool Field10b_PatientConditionRelatedToAutoAccident { get; set; }
        public string Field10b_PtConditionRelToAutoAccidentState { get; set; }                 // 2 characters// 1 = Yes, 2 = No
        public bool Field10c_PatientConditionRelatedToOtherAccident { get; set; }         // 1 = Yes, 2 = No
        public string Field10d_ReservedForLocalUse { get; set; }                            // 19 characters
        public string Field11_InsuredsPolicyGroupOfFECANumber { get; set; }                 // 29 characters
        public DateTime? Field11a_InsuredsDateOfBirth { get; set; }                            // MMDDCCYY - 8 characters
        public bool Field11a_InsuredsSexIsMale { get; set; }                                    // 1 = Male, 2 = Female;  1 character.
        public bool Field11a_InsuredsSexIsFemale { get; set; }  
        public string Field11b_InsuredsEmployerOrSchool { get; set; }                       // 29 characters
        public string Field11c_InsuredsPlanOrProgramName { get; set; }                      // 29 characters
        public bool Field11d_IsThereOtherHealthBenefitPlan { get; set; }                  // 1 = Yes, 2 = No
        public string Field12_PatientsOrAuthorizedSignature { get; set; }                   // Signed field.  Store 1 = Signature On File, 2 = Signature NOT On File.  If SOF, enter date in next field
        public DateTime? Field12_PatientsOrAuthorizedSignatureDate { get; set; }               // MMDDCCYY 
        public string Field13_InsuredsOrAuthorizedSignature { get; set; }                   // Signed field.  Store 1 = Signature On File, 2 = Signature NOT On File.  If SOF, enter date in next field
        public DateTime? Field14_DateOfCurrentIllnessInjuryOrPregnancy { get; set; }           // MMDDCCYY
        public DateTime? Field15_DatePatientHadSameOrSimilarIllness { get; set; }              // MMDDCCYY
        public DateTime? Field16_DatePatientUnableToWork_Start { get; set; }                  // MMDDCCYY
        public DateTime? Field16_DatePatientUnableToWork_End { get; set; }                    // MMDDCCYY
        public string Field17_ReferringProviderOrOtherSource_LastName { get; set; }         // HCFA 1500 standard allows 28 total characters for these (3) fields
        public string Field17_ReferringProviderOrOtherSource_FirstName { get; set; }
        public string Field17_ReferringProviderOrOtherSource_MiddleName { get; set; }
        public string Field17_ReferringProviderOrOtherSource_Credentials { get; set; }     // ie., 'MD', 'MRCVS'
        public string Field17a_OtherID_Qualifier { get; set; }                             // 2 digit alpha-numeric value
        public string Field17a_OtherID_Number { get; set; }                                // 17 characters
        public string Field17b_NationalProviderIdentifier { get; set; }                    // 10 digit numeric
        public DateTime? Field18_HospitalizationDateFrom { get; set; }                         // MMDDCCYY
        public DateTime? Field18_HospitalizationDateTo { get; set; }                           // MMDDCCYY
        public string Field19_ReservedForLocalUse { get; set; }                            // 83 characters
        public bool Field20_OutsideLab { get; set; }                                      // 1 = Yes, 2 = No
        public decimal? Field20_OutsideLabCharges { get; set; }                                // 8 digit numeric with implied decimal.  ie '20300' is $203.00.
        public string Field21_Diagnosis_1 { get; set; }                          // 3-1-4 part diagnosis code.
        public string Field21_Diagnosis_2 { get; set; }                         // 3-1-4 part diagnosis code.
        public string Field21_Diagnosis_3 { get; set; }                          // 3-1-4 part diagnosis code.
        public string Field21_Diagnosis_4 { get; set; }                         // 3-1-4 part diagnosis code.
        public string Field22_MedicaidSubmissionCode { get; set; }                          // 11 characters
        public string Field22_OriginalReferenceNumber { get; set; }                        // 18 characters
        public string Field23_PriorAuthorizationNumber { get; set; }                       // 29 characters
        public List<HCFA1500ServiceLine> Field24_ServiceLines { get; set; }                          // Service line details
        public string Field25_FederalTaxIDNumber { get; set; }                             // 15 characters
        public bool Field25_IsEIN { get; set; }                                     // 1 = SSN, 2 = EIN
        public bool Field25_IsSSN { get; set; }
        public string Field26_PatientAccountNumber { get; set; }                            // 14 characters
        public bool Field27_AcceptAssignment { get; set; }                               // 1 = Yes, 2 = No.  Refers to acceptance of terms of payor's program.
        public decimal Field28_TotalCharge { get; set; }                                  // 7 digits           
        public decimal? Field29_AmountPaid { get; set; }  // 6 digits                               // 2 digits
        public decimal? Field30_BalanceDue { get; set; }                                       // 6 digits                               // 2 digits
        public bool Field31_PhysicianOrSupplierSignatureIsOnFile { get; set; }                      // Signed field.  Store true = Signature On File, false = Signature NOT On File.  If SOF, enter date in next field
        public DateTime? Field31_PhysicianOrSupplierSignatureDate { get; set; }                  // MMDDCCYY 
        public string Field32_FacilityLocationInfo_Name { get; set; }                      // 26 characters
        public string Field32_FacilityLocationInfo_Street { get; set; }                     // 26 characters
        public string Field32_FacilityLocationInfo_City { get; set; }                       // 26 characters for this and next two fields combined
        public string Field32_FacilityLocationInfo_State { get; set; }                     //
        public string Field32_FacilityLocationInfo_Zip { get; set; }                        //
        public string Field32a_FacilityNationalProviderIdentifier { get; set; }            // 10 characters
        public string Field32b_FacilityOtherID { get; set; }                               // 14 characters
        public string Field33_BillingProvider_AreaCode { get; set; }                       // 3 characters
        public string Field33_BillingProvider_PhoneNumber { get; set; }                    // 9 characters
        public string Field33_BillingProvider_Name { get; set; }                          // 29 characters
        public string Field33_BillingProvider_Street { get; set; }                          // 29 characters
        public string Field33_BillingProvider_City { get; set; }                           // 29 characters for this and next two fields combined
        public string Field33_BillingProvider_State { get; set; }                           //
        public string Field33_BillingProvider_Zip { get; set; }                             //
        public string Field33a_BillingProviderNationalProviderIdentifier { get; set; }     // 10 characters
        public string Field33b_BillingProviderOtherID { get; set; }                         // 17 characters
        #region Serialization Methods

        public string Serialize()
        {
            var writer = new StringWriter();
            new XmlSerializer(typeof(ClaimDocument)).Serialize(writer, this);
            return writer.ToString();
        }

        public static ClaimDocument Deserialize(string xml)
        {
            var serializer = new XmlSerializer(typeof(ClaimDocument));
            return (ClaimDocument)serializer.Deserialize(new StringReader(xml));
        }
        #endregion
    }
}
