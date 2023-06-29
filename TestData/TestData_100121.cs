using System.Text;

namespace MDR_Tester;

public class TestData_100121 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "CTRI-2017-03-008228")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "A Clinical Study of Fundus Findings in Toxaemia of Pregnancy";
	        StringBuilder sb = new StringBuilder("Primary outcome(s): In our study out of 300 cases of PIH, there \n\n");
	        sb.Append("are 182 cases of mild preeclampsia and 76 cases of severe preeclampsia and 42 cases of eclampsia. Among these, 37 cases (20.33%) \n\n"); 
	        sb.Append("of mild preeclampsia and 75 cases (98.68%) of severe preeclampsia and 41 cases (97.62%) of eclampsia show positive fundus changes.\n\n"); 
	        sb.Append("Timepoint: November 2003 to June 2006"); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2003, 11, 12, 21, "300", 915,
		        null, null, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100121, 
		        "Clinical Trials Registry - India", null, "2017 Mar 27", null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Clinical Trials Registry - India"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A Clinical Study of Fundus Findings in Toxaemia of Pregnancy(Pregnancy Induced Hypertension)", 16, "en", 11, false, "From the Clinical Trials Registry - India"));

	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Rekha Bharwada", "M and J Western Regional Institute of Ophthalmology", 
		        null, "M and J Western Regional Institute of Ophthalmology", null));
	        fs.people!.Add(new StudyPerson(sd_sid, 56, "Rahul Navinchandra Bakhda", "M and J Western Regional Institute of Ophthalmology", 
		        null, "M and J Western Regional Institute of Ophthalmology", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "M and J Western Regional Institute of Ophthalmology", null));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 24, 599));  
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Fundus assessment of patients of Pregnancy Induced Hypertension", 
		        null, null, null, null));
	        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: Indian registry web page";
	        string ob_title = display_title + " :: Indian registry web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Indian registry web page", null, ob_title,
		        null, 9, 2017, 23, 13, 100121, "Clinical Trials Registry - India", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100121, "Clinical Trials Registry - India", 
		        "http://www.ctri.nic.in/Clinicaltrials/pmaindet2.php?trialid=16622", true, 35, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2017 Mar 27", 2017, 3, 27, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 Nov 24", 2021, 11, 24, null, null, null, null));
	       
	        fs.data_objects!.Add(sdo);

	        return fs;
  
        }
        
        if (sd_sid == "CTRI-2019-06-019509")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "This is a phase III study of pembrolizumab plus platinum-based doublet chemotherapy with or without canakinumab in previously untreated locally advanced or metastatic non-squamous and squamous NSCLC subjects.";
	        StringBuilder sb = new StringBuilder("Intervention1: Canakinumab (ACZ885)(150 mg/1 mL AND 50 mg/0.5 mL): Dose 200 mg Solution for s.c.\n");
	        sb.Append("injection in prefilled syringe once every 3 weeks or 6 weeks\n"); 
	        sb.Append("Intervention2: Canakinumab matching-placebo\n"); 
	        sb.Append("(ACZ885)(0 mg/1 mL AND 0\n"); 
	        sb.Append("mg/0.5 mL): Solution for s.c. injection in prefilled syringe once every 3 weeks or 6 weeks\n"); 
	        sb.Append("Control Intervention1: Pembrolizumab (50 mg): Dose in Lyophilized 200 mg powder for solution for\n"); 
	        sb.Append("infusion in vial given once every 3weeks\n"); 
	        sb.Append("Control Intervention2: Pembrolizumab 100 mg/4 mL (25\n"); 
	        sb.Append("mg/mL): Dose of 200 mg Concentrate for\n"); 
	        sb.Append("solution for i.v. infusion in vial once every 3 weeks\n"); 
	        sb.Append("Control Intervention3: Pembrolizumab 100 mg/4 mL\n"); 
	        sb.Append("(25 mg/mL): Dose of 200 mg Concentrate for\n"); 
	        sb.Append("solution for i.v. infusion in vial given once every 3 weeks.\n"); 
	        sb.Append("Control Intervention4: Pembrolizumab 50 mg: Dose 200mg Lyophilized\n"); 
	        sb.Append("powder for solution for\n"); 
	        sb.Append("infusion in vial given once in every week.\n"); 
	        sb.Append("Control Intervention5: Pemetrexed (500 mg/m2): Concentrate for solution for i.v. infusion in vial given once in 3 weeks\n"); 
	        sb.Append("Control Intervention6: Carboplatin AUC 6 mg/ml min: Concentrate for solution for i.v. infusion in vial given once every 3 weeks\n"); 
	        sb.Append("Control Intervention7: Paclitaxel OR nab-paclitaxel 200 mg/m2(paclitaxel) OR\n"); 
	        sb.Append("100 mg/m2(nab-paclitaxel): Concentrate for solution for i.v. infusion in vial given once every 3 weeks\n"); 
	        sb.Append("Control Intervention8: Carboplatin OR cisplatin AUC 5mg/ml min(carboplatin)OR\n"); 
	        sb.Append("75 mg/m2(cisplatin): Concentrate for solution for i.v. infusion in vial given once every 3 weeks.\n"); 
	        sb.Append("Primary outcome(s): 1.Safety run-in part: Incidence of dose limiting toxicities (DLTs. Incidence of DLTs assessed among at least 6 evaluable subjects during the first 42 days of study treatment. \n\n"); 
	        sb.Append("2. 2.Double-blind, randomized, placebo-controlled part: Progression free survival (PFS) per investigator assessment using RECIST v1.1\n\n"); 
	        sb.Append("3. 3.Double-blind, randomized, placebo-controlled part: Overall survival (OS) per investigator assessment using RECIST v1.1.Timepoint: 1. Time Frame: 6 months from start of safety run-in part \n\n"); 
	        sb.Append("2. Time Frame: 18 months from start of randomization part  \n\n"); 
	        sb.Append("3. Time Frame: 38 months from start of randomization part\n"); 
	        sb.Append("Study Design: Randomized, Parallel Group, Placebo Controlled Trial\n"); 
	        sb.Append("Method of generating randomization sequence:Computer generated randomization  Method of allocation concealment:Centralized  Blinding and masking:Participant and Investigator Blinded"); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2019, 6, 11, 15, "627", 915,
		        null, null, null, null, 10);
    
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100121, 
		        "Clinical Trials Registry - India", null, "2019 Jun 3", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "NCT03631199", 11, 100120, 
		        "ClinicalTrials.gov", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "CACZ885U2301, Version:00, dated: 02-Aug-2018", 14, 100189, 
		        "Novartis", "https://ror.org/02f9zrr09", null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "CACZ885U2301, Version:1.0, dated: 12-Dec-2018", 14, 100189, 
		        "Novartis", "https://ror.org/02f9zrr09", null, null));
    
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Clinical Trials Registry - India"));
	        string title =
		        "A randomized, double-blind, placebo-controlled, phase IIIstudy evaluating the efficacy and safety of pembrolizumabplus platinum-based doublet ";
	        title += "chemotherapy with or withoutcanakinumab as first line therapy for locally advanced ormetastatic non-squamous and squamous non-small celllung cancer subjects - CANOPY 1";
	        fs.titles.Add(new StudyTitle(sd_sid, title, 16, "en", 11, false, "From the Clinical Trials Registry - India"));

	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Murugananthan K", "Novartis Healthcare Private LTD", 
		        100189, "Novartis", "https://ror.org/02f9zrr09"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100189, "Novartis", "https://ror.org/02f9zrr09"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "Novartis Pharma AG, CH-4002 Basel, Switzerland", null));
    
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 505));   // 

	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Malignant neoplasm of upper respiratory tract, part unspecified", 
		        12, "C390", null, null));
    
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: Indian registry web page";
	        string ob_title = display_title + " :: Indian registry web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Indian registry web page", null, ob_title,
		        null, 9, 2019, 23, 13, 100121, "Clinical Trials Registry - India", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100121, "Clinical Trials Registry - India", 
		        "http://www.ctri.nic.in/Clinicaltrials/pmaindet2.php?trialid=29960", true, 35, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2019 Jun 3", 2019, 6, 3, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 Nov 24", 2021, 11, 24, null, null, null, null));
	       
	        fs.data_objects!.Add(sdo);

	        return fs;
    
        }

        return null;
    }
}