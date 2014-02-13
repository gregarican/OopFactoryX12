﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OopFactory.X12.Attributes;

namespace OopFactory.X12.Parsing.Model.Typed
{
    public enum ServiceTypeCodes
    {
    [EDIFieldValue("1")] MedicalCare, 
    [EDIFieldValue("2")] Surgical, 
    [EDIFieldValue("3")] Consultation, 
    [EDIFieldValue("4")] DiagnosticXRay, 
    [EDIFieldValue("5")] DiagnosticLab, 
    [EDIFieldValue("6")] RadiationTherapy, 
    [EDIFieldValue("7")] Anesthesia, 
    [EDIFieldValue("8")] SurgicalAssistance, 
    [EDIFieldValue("10")] Blood, 
    [EDIFieldValue("11")] DurableMedicalEquipmentUsed, 
    [EDIFieldValue("12")] DurableMedicalEquipmentPurchased, 
    [EDIFieldValue("14")] RenalSupplies, 
    [EDIFieldValue("17")] PreAdmissionTesting, 
    [EDIFieldValue("18")] DurableMedicalEquipmentRental, 
    [EDIFieldValue("19")] PneumoniaVaccine, 
    [EDIFieldValue("20")] SecondSurgicalOpinion, 
    [EDIFieldValue("21")] ThirdSurgicalOpinion, 
    [EDIFieldValue("22")] SocialWork, 
    [EDIFieldValue("23")] DiagnosticDental, 
    [EDIFieldValue("24")] Periodontics, 
    [EDIFieldValue("25")] Restorative, 
    [EDIFieldValue("26")] Endodontics, 
    [EDIFieldValue("27")] MaxillofacialProsthetics, 
    [EDIFieldValue("28")] AdjunctiveDentalServices, 
    [EDIFieldValue("30")] HealthBenefitPlanCoverage, 
    [EDIFieldValue("32")] PlanWaitingPeriod, 
    [EDIFieldValue("33")] Chiropractic, 
    [EDIFieldValue("34")] ChiropracticModality, 
    [EDIFieldValue("35")] DentalCare, 
    [EDIFieldValue("36")] DentalCrowns, 
    [EDIFieldValue("37")] DentalAccident, 
    [EDIFieldValue("38")] Orthodontics, 
    [EDIFieldValue("39")] Prosthodontics, 
    [EDIFieldValue("40")] OralSurgery, 
    [EDIFieldValue("41")] PreventiveDental, 
    [EDIFieldValue("42")] HomeHealthCare, 
    [EDIFieldValue("43")] HomeHealthPrescriptions, 
    [EDIFieldValue("45")] Hospice, 
    [EDIFieldValue("46")] RespiteCare, 
    [EDIFieldValue("47")] Hospitalization, 
    [EDIFieldValue("49")] HospitalRoomandBoard, 
    [EDIFieldValue("54")] LongTermCare, 
    [EDIFieldValue("55")] MajorMedical, 
    [EDIFieldValue("56")] MedicallyRelatedTransportation, 
    [EDIFieldValue("60")] GeneralBenefits, 
    [EDIFieldValue("61")] InvitroFertilization, 
    [EDIFieldValue("62")] MRIScan, 
    [EDIFieldValue("63")] DonorProcedures, 
    [EDIFieldValue("64")] Acupuncture, 
    [EDIFieldValue("65")] NewbornCare, 
    [EDIFieldValue("66")] Pathology, 
    [EDIFieldValue("67")] SmokingCessation, 
    [EDIFieldValue("68")] WellBabyCare, 
    [EDIFieldValue("69")] Maternity, 
    [EDIFieldValue("70")] Transplants, 
    [EDIFieldValue("71")] Audiology, 
    [EDIFieldValue("72")] InhalationTherapy, 
    [EDIFieldValue("73")] DiagnosticMedical, 
    [EDIFieldValue("74")] PrivateDutyNursing, 
    [EDIFieldValue("75")] ProstheticDevice, 
    [EDIFieldValue("76")] Dialysis, 
    [EDIFieldValue("77")] Otology, 
    [EDIFieldValue("78")] Chemotherapy, 
    [EDIFieldValue("79")] AllergyTesting, 
    [EDIFieldValue("80")] Immunizations, 
    [EDIFieldValue("81")] RoutinePhysical, 
    [EDIFieldValue("82")] FamilyPlanning, 
    [EDIFieldValue("83")] Infertility, 
    [EDIFieldValue("84")] Abortion, 
    [EDIFieldValue("85")] HIVAIDSTreatment, 
    [EDIFieldValue("86")] EmergencyServices, 
    [EDIFieldValue("87")] CancerTreatment, 
    [EDIFieldValue("88")] Pharmacy, 
    [EDIFieldValue("89")] FreeStandingPrescriptionDrug, 
    [EDIFieldValue("90")] MailOrderPrescriptionDrug, 
    [EDIFieldValue("91")] BrandNamePrescriptionDrug, 
    [EDIFieldValue("92")] GenericPrescriptionDrug, 
    [EDIFieldValue("93")] Podiatry, 
    [EDIFieldValue("A4")] Psychiatric, 
    [EDIFieldValue("A6")] Psychotherapy, 
    [EDIFieldValue("A7")] PsychiatricInpatient, 
    [EDIFieldValue("A8")] PsychiatricOutpatient, 
    [EDIFieldValue("A9")] Rehabilitation, 
    [EDIFieldValue("AB")] RehabilitationInpatient, 
    [EDIFieldValue("AC")] RehabilitationOutpatient, 
    [EDIFieldValue("AD")] OccupationalTherapy, 
    [EDIFieldValue("AE")] PhysicalMedicine, 
    [EDIFieldValue("AF")] SpeechTherapy, 
    [EDIFieldValue("AG")] SkilledNursingCare, 
    [EDIFieldValue("AI")] SubstanceAbuse, 
    [EDIFieldValue("AJ")] AlcoholismTreatment, 
    [EDIFieldValue("AK")] DrugAddiction, 
    [EDIFieldValue("AL")] Optometry, 
    [EDIFieldValue("AM")] Frames, 
    [EDIFieldValue("AO")] Lenses, 
    [EDIFieldValue("AP")] RoutineEyeExam, 
    [EDIFieldValue("AQ")] NonmedicallyNecessaryPhysical, 
    [EDIFieldValue("AR")] ExperimentalDrugTherapy, 
    [EDIFieldValue("B1")] BurnCare, 
    [EDIFieldValue("B2")] BrandNamePrescriptionDrugFormulary, 
    [EDIFieldValue("B3")] BrandNamePrescriptionDrugNonFormulary, 
    [EDIFieldValue("BA")] IndependentMedicalEvaluation, 
    [EDIFieldValue("BB")] PsychiatricTreatmentPartialHospitalization, 
    [EDIFieldValue("BC")] DayCarePsychiatric, 
    [EDIFieldValue("BD")] CognitiveTherapy, 
    [EDIFieldValue("BE")] MassageTherapy, 
    [EDIFieldValue("BF")] PulmonaryRehabilitation, 
    [EDIFieldValue("BG")] CardiacRehabilitation, 
    [EDIFieldValue("BH")] Pediatric, 
    [EDIFieldValue("BI")] NurseryRoomandBoard, 
    [EDIFieldValue("BK")] Orthopedic, 
    [EDIFieldValue("BL")] Cardiac, 
    [EDIFieldValue("BM")] Lymphatic, 
    [EDIFieldValue("BN")] Gastrointestinal, 
    [EDIFieldValue("BP")] Endocrine, 
    [EDIFieldValue("BQ")] Neurology, 
    [EDIFieldValue("BT")] Gynecological, 
    [EDIFieldValue("BU")] Obstetrical, 
    [EDIFieldValue("BV")] ObstetricalGynecological, 
    [EDIFieldValue("BW")] MailOrderPrescriptionDrugBrandName, 
    [EDIFieldValue("BX")] MailOrderPrescriptionDrugGeneric, 
    [EDIFieldValue("BY")] PhysicianVisitSick, 
    [EDIFieldValue("BZ")] PhysicianVisitWell, 
    [EDIFieldValue("C1")] CoronaryCare, 
    [EDIFieldValue("CK")] ScreeningXray, 
    [EDIFieldValue("CL")] Screeninglaboratory, 
    [EDIFieldValue("CM")] MammogramHighRiskPatient, 
    [EDIFieldValue("CN")] MammogramLowRiskPatient, 
    [EDIFieldValue("CO")] FluVaccination, 
    [EDIFieldValue("CP")] EyewearAccessories, 
    [EDIFieldValue("CQ")] CaseManagement, 
    [EDIFieldValue("DG")] Dermatology, 
    [EDIFieldValue("DM")] DurableMedicalEquipment, 
    [EDIFieldValue("DS")] DiabeticSupplies, 
    [EDIFieldValue("E0")] AlliedBehavioralAnalysisTherapy, 
    [EDIFieldValue("E1")] NonMedicalEquipmentnonDME, 
    [EDIFieldValue("E2")] PsychiatricEmergency, 
    [EDIFieldValue("E3")] StepDownUnit, 
    [EDIFieldValue("E4")] SkilledNursingFacilityHeadLevelofCare, 
    [EDIFieldValue("E5")] SkilledNursingFacilityVentilatorLevelofCare, 
    [EDIFieldValue("E6")] LevelofCare1, 
    [EDIFieldValue("E7")] LevelofCare2, 
    [EDIFieldValue("E8")] LevelofCare3, 
    [EDIFieldValue("E9")] LevelofCare4, 
    [EDIFieldValue("E10")] Radiographs, 
    [EDIFieldValue("E11")] DiagnosticImaging, 
    [EDIFieldValue("E12")] BasicRestorativeDental, 
    [EDIFieldValue("E13")] MajorRestorativeDental, 
    [EDIFieldValue("E14")] FixedProsthodontics, 
    [EDIFieldValue("E15")] RemovableProsthodontics, 
    [EDIFieldValue("E16")] IntraoralImagesCompleteSeries, 
    [EDIFieldValue("E17")] OralEvaluation, 
    [EDIFieldValue("E18")] DentalProphylaxis, 
    [EDIFieldValue("E19")] PanoramicImages, 
    [EDIFieldValue("E20")] Sealants, 
    [EDIFieldValue("E21")] FlourideTreatments, 
    [EDIFieldValue("E22")] DentalImplants, 
    [EDIFieldValue("E23")] TemporomandibularJointDysfunction, 
    [EDIFieldValue("E24")] RetailPharmacyPrescriptionDrug, 
    [EDIFieldValue("E25")] LongTermCarePharmacy, 
    [EDIFieldValue("E26")] ComprehensiveMedicationTherapyManagementReview, 
    [EDIFieldValue("E27")] TargetedMedicationTherapyManagementReview, 
    [EDIFieldValue("E28")] DietaryNutritionalServices, 
    [EDIFieldValue("E29")] TechnicalCardiacRehabilitationServicesComponent, 
    [EDIFieldValue("E30")] ProfessionalCardiacRehabilitationServicesComponent, 
    [EDIFieldValue("E31")] ProfessionalIntensiveCardiacRehabilitationServicesComponent, 
    [EDIFieldValue("E32")] IntensiveCardiacRehabilitationTechnicalComponent, 
    [EDIFieldValue("E33")] IntensiveCardiacRehabilitation, 
    [EDIFieldValue("E34")] PulmonaryRehabilitationTechnicalComponent, 
    [EDIFieldValue("E35")] PulmonaryRehabilitationProfessionalComponent, 
    [EDIFieldValue("E36")] ConvenienceCare, 
    [EDIFieldValue("EA")] PreventiveServices, 
    [EDIFieldValue("EB")] SpecialtyPharmacy, 
    [EDIFieldValue("EC")] DurableMedicalEquipmentNew, 
    [EDIFieldValue("ED")] CATScan, 
    [EDIFieldValue("EE")] Ophthalmology, 
    [EDIFieldValue("EF")] ContactLenses, 
    [EDIFieldValue("GF")] GenericPrescriptionDrugFormulary, 
    [EDIFieldValue("GN")] GenericPrescriptionDrugNonFormulary, 
    [EDIFieldValue("GY")] Allergy, 
    [EDIFieldValue("IC")] IntensiveCare, 
    [EDIFieldValue("MH")] MentalHealth, 
    [EDIFieldValue("NI")] NeonatalIntensiveCare, 
    [EDIFieldValue("ON")] Oncology, 
    [EDIFieldValue("PE")] PositronEmissionTomographyPETScan, 
    [EDIFieldValue("PT")] PhysicalTherapy, 
    [EDIFieldValue("PU")] Pulmonary, 
    [EDIFieldValue("RN")] Renal, 
    [EDIFieldValue("RT")] ResidentialPsychiatricTreatment, 
    [EDIFieldValue("SMH")] SeriousMentalHealth, 
    [EDIFieldValue("TC")] TransitionalCare, 
    [EDIFieldValue("TN")] TransitionalNurseryCare, 
    [EDIFieldValue("UC")] UrgentCare, 


    }
}
