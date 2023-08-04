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
	        StringBuilder sb = new StringBuilder("Primary outcome(s): In our study out of 300 cases of PIH, there \n");
	        sb.Append("are 182 cases of mild preeclampsia and 76 cases of severe preeclampsia and 42 cases of eclampsia. Among these, 37 cases (20.33%) \n"); 
	        sb.Append("of mild preeclampsia and 75 cases (98.68%) of severe preeclampsia and 41 cases (97.62%) of eclampsia show positive fundus changes. \n"); 
	        sb.Append("Timepoint: November 2003 to June 2006"); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2003, 11, 12, 21, "300", 915,
		        null, null, null, null, 7);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100121, 
		        "Clinical Trials Registry - India", null, "27 Mar 2017", null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Clinical Trials Registry - India"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A Clinical Study of Fundus Findings in Toxaemia of Pregnancy(Pregnancy Induced Hypertension)", 16, "en", 11, false, "From the Clinical Trials Registry - India"));

	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Rekha Bharwada", "M and J Western Regional Institute of Ophthalmology", 
		        null, "M and J Western Regional Institute of Ophthalmology", null));
	        fs.people!.Add(new StudyPerson(sd_sid, 56, "Rahul Navinchandra Bakhda", "M and J Western Regional Institute of Ophthalmology", 
		        null, "M and J Western Regional Institute of Ophthalmology", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "M and J Western Regional Institute of Ophthalmology", null));

	        fs.conditions!.Add(new StudyCondition(sd_sid,"Fundus assessment of patients of Pregnancy Induced Hypertension", 
		        null, null, null, null));
	        
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1001, "none", "All", 0, "n.0A", "An observational study in which the patients for the study are selected from antenatal clinic, antenatal ward and preeclampsia and eclampsia room in Department of Obstetrics and Gynecology and general ophthalmic OPD in case of ambulatory patients.Cases of Pregnancy Induced Hypertension."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1002, "none", "All", 0, "e.0A", "Cases complicated by malignancy,renal,liver or other secondary manifestations."));	       
            
	        fs.countries!.Add(new StudyCountry(sd_sid, 1269750, "India", null));

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
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "27 Mar 2017", 2017, 3, 27, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "24 Nov 2021", 2021, 11, 24, null, null, null, null));
	       
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
	        sb.Append("Primary outcome(s): 1.Safety run-in part: Incidence of dose limiting toxicities (DLTs. Incidence of DLTs assessed among at least 6 evaluable subjects during the first 42 days of study treatment. \n"); 
	        sb.Append("2. 2.Double-blind, randomized, placebo-controlled part: Progression free survival (PFS) per investigator assessment using RECIST v1.1 \n"); 
	        sb.Append("3. 3.Double-blind, randomized, placebo-controlled part: Overall survival (OS) per investigator assessment using RECIST v1.1.Timepoint: 1. Time Frame: 6 months from start of safety run-in part \n"); 
	        sb.Append("2. Time Frame: 18 months from start of randomization part \n"); 
	        sb.Append("3. Time Frame: 38 months from start of randomization part\n"); 
	        sb.Append("Study Design: Randomized, Parallel Group, Placebo Controlled Trial\n"); 
	        sb.Append(" Method of generating randomization sequence:Computer generated randomization  Method of allocation concealment:Centralized  Blinding and masking:Participant and Investigator Blinded"); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2019, 6, 11, 15, "627", 915,
		        null, null, null, null, 10);
    
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100121, 
		        "Clinical Trials Registry - India", null, "3 Jun 2019", null));
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

	        fs.conditions!.Add(new StudyCondition(sd_sid, "Malignant neoplasm of upper respiratory tract, part unspecified", 
		        12, "C390", null, null));
    
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "1-", 1, "n.01", "Histologically confirmed locally advanced or metastatic NSCLC"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "2-", 1, "n.02", "Measurable disease by RECIST 1.1"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "3-", 1, "n.03", "Known PD-L1 status"));
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr", "4-", 1, "n.04", "ECOG performance status (PS) 0 or 1"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr", "1-", 1, "e.01", "Previous immunotherapy or treatment with IL-1Î² inhibitor."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr", "2-", 1, "e.02", "Subjects with epidermal growth factor receptor (EGFR) sensitizing mutations and/or anaplastic lymphoma kinase (ALK) rearrangement"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr", "3-", 1, "e.03", "History of severe hypersensitivity reaction to monoclonal antibodies, platinum containing drugs, nab-paclitaxel, paclitaxel, pemetrexed or any known excipients of these drugs."));	    
           
            fs.countries!.Add(new StudyCountry(sd_sid, 2077456, "Australia", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2782113, "Austria", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1814991, "China", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3077311, "Czechia", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2623032, "Denmark", null));
            fs.countries.Add(new StudyCountry(sd_sid, 660013, "Finland", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3017382, "France", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2921044, "Germany", null));
            fs.countries.Add(new StudyCountry(sd_sid, 390903, "Greece", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1819730, "Hong Kong", null));
            fs.countries.Add(new StudyCountry(sd_sid, 719819, "Hungary", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2629691, "Iceland", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1269750, "India", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3175395, "Italy", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1861060, "Japan", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1873107, "North Korea", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1835841, "South Korea", null));
            fs.countries.Add(new StudyCountry(sd_sid, 272103, "Lebanon", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1733045, "Malaysia", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2750405, "Netherlands", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3144096, "Norway", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1694008, "Philippines", null));
            fs.countries.Add(new StudyCountry(sd_sid, 798544, "Poland", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2264397, "Portugal", null));
            fs.countries.Add(new StudyCountry(sd_sid, 798549, "Romania", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2017370, "Russia", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1880251, "Singapore", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3057568, "Slovakia", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2510769, "Spain", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2661886, "Sweden", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2658434, "Switzerland", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1668284, "Taiwan", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1605651, "Thailand", null));
            fs.countries.Add(new StudyCountry(sd_sid, 298795, "Turkey", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2635167, "United Kingdom", null));
            fs.countries.Add(new StudyCountry(sd_sid, 953987, "South Africa", null));

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
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "3 Jun 2019", 2019, 6, 3, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "24 Nov 2021", 2021, 11, 24, null, null, null, null));
	       
	        fs.data_objects!.Add(sdo);

	        return fs;
        }

        return null;
    }
}