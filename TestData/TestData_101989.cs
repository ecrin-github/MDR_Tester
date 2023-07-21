using System.Text;

namespace MDR_Tester;

public class TestData_101989 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "LBCTR2019070214")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 

	        string display_title = "Study of Efficacy and Safety of Pembrolizumab Plus Platinum-based Doublet Chemotherapy With or Without Canakinumab in Previously Untreated ";
	        display_title += "Locally Advanced or Metastatic Non-squamous and Squamous NSCLC Subjects  ( CANOPY 1 )"; 
	        StringBuilder sb = new StringBuilder("Interventions: •Drug: canakinumab \ncanakinumab every 3 weeks (squamous and non-squamous)\n\n");
	        sb.Append("Other Name: ACZ885\n\n"); 
	        sb.Append("•Drug: pembrolizumab \n200 mg every 3 weeks (squamous and non-squamous)\n\n"); 
	        sb.Append("•Drug: carboplatin \nAUC 5 mg/mL*min every 3 weeks (non-squamous) or AUC 6 mg/mL*min (squamous)\n\n"); 
	        sb.Append("•Drug: carboplatin \nAUC 5 mg/mL*min every 3 weeks (non-squamous) or AUC 6 mg/mL*min (squamous)\n\n"); 
	        sb.Append("•Drug: paclitaxel \n200 mg/m2 every 3 weeks (squamous)\n\n"); 
	        sb.Append("•Drug: nab-paclitaxel \n100 mg/m2 every 3 weeks (squamous)\n\n"); 
	        sb.Append("•Drug: pemetrexed \n500 mg/m2 every 3 weeks (non-squamous)\n"); 
	        sb.Append(";Blood test (Hematology, Chemistry, Coagulation, PK, ct DNA, Biomarkers...), CT Scan, MRI, Whole body bone scan, Skin photography, "); 
	        sb.Append("ital signs, Physical exam, Urinalysis, X-Ray;ICF, IMP, Lab tests\n"); 
	        sb.Append("Primary outcome(s): Name: *To compare PFS by local investigator assessment as per RECIST1.1 ;Timepoints: 6 months;Measure: "); 
	        sb.Append("6 months;Name: Progression free survival;Timepoints: Duing the study ;Measure: during the study\n"); 
	        sb.Append("Study Design: Allocation: Randomized controlled trial;Masking: Blinded (masking used);Control: Placebo;Assignment: Parallel;Purpose: Treatment"); 
	        string brief_desc = sb.ToString();
	        sb = new StringBuilder("Novartis is committed to sharing with qualified external researchers, access to patient-level data and supporting clinical ");
	        sb.Append("documents from eligible studies. These requests are reviewed and approved by an independent expert panel on the basis of scientific merit. ");
	        sb.Append("All data provided is anonymized to respect the privacy of patients who have participated in the trial in line with applicable laws and regulations.  ");
	        sb.Append("This trial data is currently available according to the process described on www.clinicalstudydatarequest.com.");
	        string dss = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2019, 11, 11, 21, "8", 900,
		        18, 17, 90, 17, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 101989, 
		        "Lebanon Clinical Trials Registry", null, "2022 Jan 4", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "NCT03631199", 11, 100120,
		        "ClinicalTrials.gov", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Lebanon Clinical Trials Registry"));
	        string title = "A Randomized, Double-blind, Placebo-controlled, Phase III Study Evaluating the Efficacy and Safety of Pembrolizumab Plus ";
	        title += "Platinum-based Doublet Chemotherapy With or Without Canakinumab as First Line Therapy for Locally Advanced or Metastatic Non-squamous and ";
	        title += "Squamous Non-small Cell Lung Cancer Subjects (CANOPY-1)";
	        fs.titles!.Add(new StudyTitle(sd_sid, title, 16, "en", 11, true, "From the Lebanon Clinical Trials Registry"));
        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Hind Khairallah", "Khalil Fattal et Fils sal", null, 
		        "Khalil Fattal et Fils sal", null));
	        fs.people.Add(new StudyPerson(sd_sid, 56, "Fadi Farhat", "Hammoud Hospital", null, "Hammoud Hospital", null));
	
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Novartis Pharma Services Inc", null));
	
            fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 	        
	        fs.features.Add(new StudyFeature(sd_sid, 24, 502));   // 

            fs.conditions!.Add(new StudyCondition(sd_sid, "Patients with Non-Small Cell Lung Cancer", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "NSCLC", null, null, "2C25", "Malignant neoplasms of bronchus or lung"));
            
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "•", 1, "n.01", "Histologically confirmed locally advanced stage IIIB or stage IV NSCLC for treatment in the first-line setting"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "•", 1, "n.02", "Known PD-L1 status determined by a Novartis designated central laboratory. A newly obtained tissue biopsy or an archival biopsy (block or slides) is required for PD-L1 determination (PD-L1 IHC 22C3 pharmDx assay), prior to study randomization. Note: For the safety run-in part, known PD-L1 status is not required."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "•", 1, "n.03", "Eastern Cooperative oncology group (ECOG) performance status of 0 or 1."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr", "•", 1, "n.04", "At least 1 measurable lesion by RECIST 1.1"));	    
	        
            fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr", "•", 1, "e.01", "Previous immunotherapy (e.g. anti-PD-1, anti-PD-L1, anti-PD-L2, anti-CTLA-4 antibody, or any other antibody or drug specifically targeting T-cell co-stimulation or immune checkpoint pathways)."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr", "•", 1, "e.02", "Prior treatment with canakinumab or drugs of a similar mechanism of action (IL-1ß inhibitor)."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr", "•", 1, "e.03", "Subjects with epidermal growth factor receptor (EGFR) sensitizing mutations (identified in exons 19, 20, or 21), and/or ALK rearrangement by locally approved laboratory testing."));
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr", "•", 1, "e.04", "Previously untreated or symptomatic central nervous system (CNS) metastases or lepto-meningeal disease."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "•", 1, "e.05", "Subject with suspected or proven immune-compromised state or infections."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "•", 1, "e.06", "Subject has prior to starting study drug: received live vaccination =3 months, had major surgery =4 weeks prior to starting study drug, has thoracic radiotherapy: lung fields = 4 weeks, other anatomic sites = 2 weeks, palliative radiotherapy for bone lesions = 2 weeks."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "•", 1, "e.07", "Other protocol-defined inclusion/exclusion criteria may apply."));	   
            
            fs.countries!.Add(new StudyCountry(sd_sid, 272103, "Lebanon", null));
            fs.countries.Add(new StudyCountry(sd_sid, 6251999, "Canada", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3017382, "France", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2629691, "Iceland", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2921044, "Germany", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1861060, "Japan", null));
            fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2658434, "Switzerland", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2510769, "Spain", null));
            
			// Data Objects
				        
			// 1) Trial registry entry

			string sd_oid = "LBCTR2019070214 :: 13 :: Lebanese registry web page";
			string ob_title = display_title + " :: Lebanese registry web page";
			StudyDataObject sdo = CreateEmptyStudyDataObject();

			sdo.data_object = new DataObject(sd_oid, sd_sid, "ISRCTN registry entry", null, ob_title,
				null, 9, 2022, 23, 13, 101989, "Lebanon Clinical Trials Registry", 
				null, "en", 12, null, null, 0, true, true);
				       
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101989, "Lebanon Clinical Trials Registry", 
				"https://lbctr.moph.gov.lb/Trials/Details/4971", true, 35, null, null, null));
			sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2022 Jan 4", 2022, 1, 4, null, null, null, null));
			sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2023 Apr 3", 2022, 4, 3, null, null, null, null));
				       
			fs.data_objects!.Add(sdo);
	
	        return fs;
        }
        
        return null;
    }
}