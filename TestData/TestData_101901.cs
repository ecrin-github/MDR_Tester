﻿using System.Text;

namespace MDR_Tester;

public class TestData_101901 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
		string asb = "Material provided under managed access. Please follow the link to the yoda site for details of the application process.";
	    StringBuilder dsb =
		    new StringBuilder("Yoda states that “...researchers will be granted access to participant-level study data that are devoid ");
	    dsb.Append("of personally identifiable information; current best guidelines for de-identification of data will be used.”");
	    
        if (sd_sid == "Y-NCT01727258")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 

	        string display_title = "A Test on a New Experimental Mouth Rinse for Relieving Tooth Sensitivity";
	        string yoda_title =
		        "Evaluation of an experimental mouth rinse device for relieving dentinal hypersenstivity";
	        StringBuilder sb = new StringBuilder("This study is for people with sensitive teeth and involves going to the dentist for 4 visits over 6 weeks. ");
	        sb.Append("At each visit the dentist will look at the mouth, teeth, tongue and gums of subjects, and check for sensitive teeth.\n"); 
	        sb.Append("During the first 2 weeks, participants will brush their teeth two times a day with the fluoride toothpaste provided.\n"); 
	        sb.Append("Then, if they qualify to continue in the study, participants will be assigned to a treatment group. All the groups will get toothpaste "); 
	        sb.Append("currently sold on the market, and one group will get a mouthwash with an experimental ingredient to use as well. Subjects will have an "); 
	        sb.Append("equal chance of being assigned to any one of the three groups.\n"); 
	        sb.Append("For the next 4 weeks, subjects will use their assigned products according to the directions provided. At Visit 1 subjects will "); 
	        sb.Append("be supervised while they brush their teeth to ensure they understand the directions. They will also have supervised use of the product at Visit 2.\n"); 
	        sb.Append("We will see if the mouthwash helps to reduce tooth sensitivity during the study."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, yoda_title, "en", brief_desc, null, null, null, 11, 21, "153", 900,
		        null, null, null, null, 0);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT01727258", 11, 100120, 
		        "ClinicalTrials.gov", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "KOXDHY0008", 14, 100290, 
		        "Johnson & Johnson", "https://ror.org/03qd7mz70", null, null));
      
	        fs.titles!.Add(new StudyTitle(sd_sid, yoda_title, 18, "en", 11, true, "From YODA web page"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100290, "Johnson & Johnson", 
		        "https://ror.org/03qd7mz70"));
      
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Mouth Rinse, potassium oxalate 1.4%", null, null, null, null));
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Dentinal Hypersensitivity", null, null, "DA08", 
		             "Diseases of hard tissues of teeth"));
	        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 38 :: Yoda web page";
	        string ob_title = display_title + " :: Yoda web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Yoda web page", null, ob_title,
		        null, 9, null, 23, 38, 101901, "Yoda", null, "en", 12, null, null, 0, true, true);

	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101901, "Yoda", 
		        "https://yoda.yale.edu/clinical-trial/nct01727258-evaluation-of-an-experimental-mouth-rinse-device-for-relieving-dentinal-hypersenstivity/", 
		        true, 35, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 2) Clinical Study Report

	        sd_oid = sd_sid + " :: 26 :: Clinical study report";
	        ob_title = display_title + " :: Clinical study report";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Clinical study report", null, ob_title,
		        null, 9, null, 23, 26, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
	        
	        
	        // 3) Protocol

	        sd_oid = sd_sid + " :: 11 :: Study protocol";
	        ob_title = display_title + " :: Study protocol";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Study protocol", null, ob_title,
		        null, 9, null, 23, 11, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 4) Statistical Analysis Plan
	        
	        sd_oid = sd_sid + " :: 22 :: Statistical analysis plan";
	        ob_title = display_title + " :: Statistical analysis plan";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Statistical analysis plan", null, ob_title,
		        null, 9, null, 23, 22, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 5) Data Definition Specification
	        
	        sd_oid = sd_sid + " :: 31 :: Data dictionary";
	        ob_title = display_title + " :: Data dictionary";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Data dictionary", null, ob_title,
		        null, 9, null, 23, 31, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	       
	        fs.data_objects!.Add(sdo);

	        // 6) Collected Datasets
	        
	        sd_oid = sd_sid + " :: 80 :: Individual participant data";
	        ob_title = display_title + " :: Individual participant data";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Individual participant data", null, ob_title,
		        null, 9, null, 14, 80, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 3, true, true);

	        sdo.dataset_details = new ObjectDataset(sd_oid, 0, null, 2, null, null, null, null, null,
		        dsb.ToString(), 0, null, null, null, null, null, null);
	        
	        fs.data_objects!.Add(sdo);
	        
	        return fs; 
        }
        
        
        if (sd_sid == "Y-JandJ-30-49")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 

	        string display_title = "A Phase 3, Randomized, Open-Label, Comparative Study of DOXIL/CAELYX versus Topotecan HCl in Patients with Epithelial ";
	        display_title += "Ovarian Carcinoma Following Failure of First-Line, Platinum-Based Chemotherapy";
	        StringBuilder sb = new StringBuilder("The primary objective of this study was to compare the efficacy and safety of DOXIL to those of topotecan ");
	        sb.Append("in subjects with epithelial ovarian carcinoma following failure of first-line, platinum-based chemotherapy."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, null, null, 11, 21, "481", 905,
		        null, null, null, null, 0);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "30-49", 14, 100290, 
		        "Johnson & Johnson", "https://ror.org/03qd7mz70", null, null));
      
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 18, "en", 11, true, "From YODA web page"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100290, "Johnson & Johnson", 
		        "https://ror.org/03qd7mz70"));

	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Doxorubicin hydrochloride", null, null, "D004317", "Doxorubicin"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Doxil", null, null, null, null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Neoplasms, Ovarian", null, null, "2C73", 
		        "Malignant neoplasms of ovary"));
	        
	        fs.references!.Add(new StudyReference(sd_sid, null, "15385103", null, null, null));
	        
            // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 38 :: Yoda web page";
	        string ob_title = display_title + " :: Yoda web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Yoda web page", null, ob_title,
		        null, 9, null, 23, 38, 101901, "Yoda", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101901, "Yoda", 
		        "https://yoda.yale.edu/clinical-trial/a-phase-3-randomized-open-label-comparative-study-of-doxil-caelyx-versus-topotecan-hcl-in-patients-with-epithelial-ovarian-carcinoma-following-failure-of-first-line-platinum-based-chemothera/", 
		        true, 35, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 2) Clinical Study Report

	        sd_oid = sd_sid + " :: 26 :: Clinical study report";
	        ob_title = display_title + " :: Clinical study report";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Clinical study report", null, ob_title,
		        null, 9, null, 23, 26, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	       
	        fs.data_objects!.Add(sdo);

	        // 3) Protocol

	        sd_oid = sd_sid + " :: 11 :: Study protocol";
	        ob_title = display_title + " :: Study protocol";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Study protocol", null, ob_title,
		        null, 9, null, 23, 11, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);

	        fs.data_objects!.Add(sdo);
	        
	        // 4) Statistical Analysis Plan
	        
	        sd_oid = sd_sid + " :: 22 :: Statistical analysis plan";
	        ob_title = display_title + " :: Statistical analysis plan";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Statistical analysis plan", null, ob_title,
		        null, 9, null, 23, 22, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 5) CSR Summary
	        
	        sd_oid = sd_sid + " :: 79 :: Results or CSR summary";
	        ob_title = display_title + " :: Results or CSR summary";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Results or CSR summary", null, ob_title,
		        null, 9, null, 23, 79, 101901, "Yoda", null, "en", 11, null, null, 0, true, true);

	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101901, "Yoda", 
		        "https://yoda.yale.edu/wp-content/uploads/2023/02/30-49_csr_synopsis.pdf", 
		        true, 11, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 6) Data Definition Specification
	        
	        sd_oid = sd_sid + " :: 31 :: Data dictionary";
	        ob_title = display_title + " :: Data dictionary";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Data dictionary", null, ob_title,
		        null, 9, null, 23, 31, 101901, "Yoda", null, "en", 11, null, null, 0, true, true);

	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101901, "Yoda", 
		        "https://yoda.yale.edu/wp-content/uploads/2023/02/30-49_data_dictionary.pdf", 
		        true, 11, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 7) Collected Datasets
	        
	        sd_oid = sd_sid + " :: 80 :: Individual participant data";
	        ob_title = display_title + " :: Individual participant data";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Individual participant data", null, ob_title,
		        null, 9, null, 14, 80, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 3, true, true);

	        sdo.dataset_details = new ObjectDataset(sd_oid, 0, null, 2, null, null, null, null, null,
		        dsb.ToString(), 0, null, null, null, null, null, null);
	        
	        fs.data_objects!.Add(sdo);
	        
	        
	        return fs; 
        }

        
        if (sd_sid == "Y-NCT02243202")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 

	        string display_title = "Effects of Co-administration of Canagliflozin 300 mg and Phentermine 15 mg With Placebo in the Treatment of Non-Diabetic Overweight and Obese Participants";
	        string yoda_title = "A Randomized, Double-Blind, Placebo-Controlled, Parallel-Group Study to Investigate the Safety and Efficacy of the ";
	        yoda_title += "Co-administration of Canagliflozin 300 mg and Phentermine 15 mg Compared With Placebo for the Treatment of Non-diabetic Overweight and Obese Subjects";
	        StringBuilder sb = new StringBuilder("The purpose of this study is to compare the effects of canagliflozin and phentermine to those of placebo to promote ");
	        sb.Append("on a change in body weight over a 26 week period."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, yoda_title, "en", brief_desc, null, null, null, 11, 21, "335", 900,
		        null, null, null, null, 0);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT02243202", 11, 100120, 
            		        "ClinicalTrials.gov", null, null, null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "28431754OBE2002", 14, 100773, 
            		        "Janssen", null, null, null));
                  
            fs.titles!.Add(new StudyTitle(sd_sid, yoda_title, 18, "en", 11, true, "From YODA web page"));
            	        
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100773, "Janssen", null));
                  
            fs.topics!.Add(new StudyTopic(sd_sid, 12, "Canagliflozin", null, null, "D000068896", "Canagliflozin"));
            fs.topics.Add(new StudyTopic(sd_sid, 12, "Invokana", null, null, "D000068896", "Canagliflozin"));
            
            fs.conditions!.Add(new StudyCondition(sd_sid, "Obesity", null, null, "5B81", "Obesity"));

	        fs.references!.Add(new StudyReference(sd_sid, null, "28289041", null, null, null));
	        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 38 :: Yoda web page";
	        string ob_title = display_title + " :: Yoda web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Yoda web page", null, ob_title,
		        null, 9, null, 23, 38, 101901, "Yoda", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101901, "Yoda", 
		        "https://yoda.yale.edu/clinical-trial/nct02243202-a-randomized-double-blind-placebo-controlled-parallel-group-study-to-investigate-the-safety-and-efficacy-of-the-co-administration-of-canagliflozin-300-mg-and-phentermine-15-mg-compare/", 
		        true, 35, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        
	        // 2) Clinical Study Report

	        sd_oid = sd_sid + " :: 26 :: Clinical study report";
	        ob_title = display_title + " :: Clinical study report";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Clinical study report", null, ob_title,
		        null, 9, null, 23, 26, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
	        
	        
	        // 3) Protocol

	        sd_oid = sd_sid + " :: 11 :: Study protocol";
	        ob_title = display_title + " :: Study protocol";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Study protocol", null, ob_title,
		        null, 9, null, 23, 11, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
	        
	        
	        // 4) Statistical Analysis Plan
	        
	        sd_oid = sd_sid + " :: 22 :: Statistical analysis plan";
	        ob_title = display_title + " :: Statistical analysis plan";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Statistical analysis plan", null, ob_title,
		        null, 9, null, 23, 22, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
	        
	        
	        // 5) Collected Datasets
	        
	        sd_oid = sd_sid + " :: 80 :: Individual participant data";
	        ob_title = display_title + " :: Individual participant data";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Individual participant data", null, ob_title,
		        null, 9, null, 14, 80, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 3, true, true);

	        sdo.dataset_details = new ObjectDataset(sd_oid, 0, null, 2, null, null, null, null, null,
		        dsb.ToString(), 0, null, null, null, null, null, null);
	        
	        fs.data_objects!.Add(sdo);
	        
	        
	        // 6) Data Definition Specification
	        
	        sd_oid = sd_sid + " :: 31 :: Data dictionary";
	        ob_title = display_title + " :: Data dictionary";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Data dictionary", null, ob_title,
		        null, 9, null, 23, 31, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
	        
	        return fs; 
        }
        
        
        if (sd_sid == "Y-JandJ-GAL-MVD-301")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 

	        string display_title = "A long-term comparison of galantamine and donepezil in the treatment of Alzheimer’s disease";
	        StringBuilder sb = new StringBuilder("The primary objective of this trial was to document the long-term response and safety of galantamine ");
	        sb.Append("in subjects with Alzheimer’s Disease or vascular dementia or AD with cerebrovascular disease."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, null, null, 11, 21, null, 900,
		        null, null, null, null, 0);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "GAL-MVD-301", 14, 100290, "Johnson & Johnson", "https://ror.org/03qd7mz70", null, null));
      
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 18, "en", 11, true, "From YODA web page"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100290, "Johnson & Johnson", "https://ror.org/03qd7mz70"));

	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Galantamine", null, null, "D005702", "Galantamine"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Razadyne", null, null, "D005702", "Galantamine"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Alzheimer Disease", null, null, "8A20", 
		        "Alzheimer disease"));
	        
	        fs.references!.Add(new StudyReference(sd_sid, null, "12875613", null, null, null));
	        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 38 :: Yoda web page";
	        string ob_title = display_title + " :: Yoda web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Yoda web page", null, ob_title,
		        null, 9, null, 23, 38, 101901, "Yoda", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101901, "Yoda", 
		        "https://yoda.yale.edu/clinical-trial/a-long-term-comparison-of-galantamine-and-donepezil-in-the-treatment-of-alzheimers-disease/", true, 35, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 2) Clinical Study Report

	        sd_oid = sd_sid + " :: 26 :: Clinical study report";
	        ob_title = display_title + " :: Clinical study report";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Clinical study report", null, ob_title,
		        null, 9, null, 23, 26, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);

	        
	        // 3) Protocol

	        sd_oid = sd_sid + " :: 11 :: Study protocol";
	        ob_title = display_title + " :: Study protocol";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Study protocol", null, ob_title,
		        null, 9, null, 23, 11, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 4) CSR Summary
	        
	        sd_oid = sd_sid + " :: 79 :: Results or CSR summary";
	        ob_title = display_title + " :: Results or CSR summary";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Results or CSR summary", null, ob_title,
		        null, 9, null, 23, 79, 101901, "Yoda", null, "en", 11, null, null, 0, true, true);

	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101901, "Yoda", 
		        "https://yoda.yale.edu/wp-content/uploads/2023/02/gal-mvd-301_csr_synopsis.pdf", 
		        true, 11, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        return fs; 
        }
        
        
        if (sd_sid == "Y-NCT00433329")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 

	        string display_title = "Combination Therapy in Pulmonary Arterial Hypertension";
	        string yoda_title = "COMPASS 3: An Open-label, Multi-Center Study Employing a Targeted 6-Minute Walk Test (6-MWT) Distance Threshold Approach to Guide ";
	        yoda_title += "Bosentan-Based Therapy and to Assess the Utility of Magnetic Resonance Imaging (MRI) on Cardiac Remodeling";
	        StringBuilder sb = new StringBuilder("An open label, non-comparative study design is appropriate for this Phase 4 study designed to assess whether a core ");
	        sb.Append("therapy of bosentan, either as monotherapy or with the addition of sildenafil, enables patients with pulmonary arterial hypertension ");
	        sb.Append(
		        "(PAH) to achieve a 6-minute walk distance (6 MWD) of ≥380 meters after 28 weeks of therapy This design is also appropriate to pioneer ");
	        sb.Append("the utility of cardiac MRI in assessing improved functional capacity in PAH and exploring its correlation with other parameters.");
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, yoda_title, "en", brief_desc, null, null, null, 11, 21, "100", 900,
		        null, null, null, null, 0);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT00433329", 11, 100120, 
		        "ClinicalTrials.gov", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "AC-052-419", 14, 100585, 
		        "Actelion", "https://ror.org/001yedb91", null, null));
                  
	        fs.titles!.Add(new StudyTitle(sd_sid, yoda_title, 18, "en", 11, true, "From YODA web page"));
            	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100585, "Actelion", "https://ror.org/001yedb91"));
                  
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Bosentan", null, null, "D000077300", "Bosentan"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Tracleer", null, null, "D000077300", "Bosentan"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Hypertension, Pulmonary, Arterial", null, null, "BB01", "Pulmonary hypertension"));

	        fs.references!.Add(new StudyReference(sd_sid, null, "29064349", null, null, null));
	        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 38 :: Yoda web page";
	        string ob_title = display_title + " :: Yoda web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Yoda web page", null, ob_title,
		        null, 9, null, 23, 38, 101901, "Yoda", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101901, "Yoda", 
		        "https://yoda.yale.edu/clinical-trial/nct00433329-compass-3-an-open-label-multi-center-study-employing-a-targeted-6-minute-walk-test-6-mwt-distance-threshold-approach-to-guide-bosentan-based-therapy-and-to-assess-the-utility-of-magn/", 
		        true, 35, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 2) Clinical Study Report

	        sd_oid = sd_sid + " :: 26 :: Clinical study report";
	        ob_title = display_title + " :: Clinical study report";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Clinical study report", null, ob_title,
		        null, 9, null, 23, 26, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
 
	        // 3) Protocol

	        sd_oid = sd_sid + " :: 11 :: Study protocol";
	        ob_title = display_title + " :: Study protocol";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Study protocol", null, ob_title,
		        null, 9, null, 23, 11, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 4) Statistical Analysis Plan
	        
	        sd_oid = sd_sid + " :: 22 :: Statistical analysis plan";
	        ob_title = display_title + " :: Statistical analysis plan";
	        sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Statistical analysis plan", null, ob_title,
		        null, 9, null, 23, 22, 101901, "Yoda", null, "en", 17, asb.ToString(), 
		        "https://yoda.yale.edu/how-request-data", 0, true, true);
	        
	        fs.data_objects!.Add(sdo);
	        
	        return fs; 
     
        }

        return null;
    }
}