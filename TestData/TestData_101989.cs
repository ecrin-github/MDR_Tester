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
		        "Clinicaltrials.gov", null, null, null));
	        
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
            fs.conditions.Add(new StudyCondition(sd_sid, "NSCLC", null, null, null, null));
  
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
			sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Mar 8", 2022, 3, 8, null, null, null, null));
				       
			fs.data_objects!.Add(sdo);
	
	        return fs;
        }
        
        return null;
    }
}