using System.Text;

namespace MDR_Tester;

public class TestData_100131 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "TCTR20161221005")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "A Clinical Study of Fundus Findings in Toxaemia of Pregnancy(Pregnancy Induced Hypertension)";
	        StringBuilder sb = new StringBuilder("Interventions: Carvedilol 12.5 mg immediate release tablets,Carvedilol 12.5 mg immediate release tablets;");
	        sb.Append("Experimental Drug,Active Comparator Drug;Carvolol (12.5 mg),Dilatrend (12.5 mg)\n"); 
	        sb.Append("Primary outcome(s): Correlation of fundus changes with disease entity,age,gravida, blood pressure,duration,imp of fundus "); 
	        sb.Append("Nov. 2003 to June 2006 randomly Clinical ophthalmoscopy(Fundus Examination)"); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2003, 11, 12, 21, "300", 905,
		        18, 17, 42, 17, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100131, 
		        "Thai Clinical Trials Register", null, "2016 Dec 21", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U1111-1189-6165", 11, 100115, 
		        "International Clinical Trials Registry Platform (WHO)", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "NCT03076619", 11, 100120,
		        "ClinicalTrials.gov", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Thai Clinical Trials Register"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Rahul Bakhda", "Ex-Resident, M and J Western Regional Institute of Ophthalmology, Ahmedabad", 
		        null, "M and J Western Regional Institute of Ophthalmology", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "M and J Western Regional Institute of Ophthalmology", null));
            
            fs.features!.Add(new StudyFeature(sd_sid, 24, 599));   // 
            
            fs.conditions!.Add(new StudyCondition(sd_sid, "Pregnancy Induced Hypertension", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Fundus findings", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "hypertensive disorders of pregnancy", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "ophthalmoscopy", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "perinatal mortality", null, null, null, null));
            
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1001, "none", "none", 1, "n.0A", "An observational study in which the patients for the study are selected from antenatal clinic&#44; antenatal ward and preeclampsia and eclampsia room in Department of Obstetrics and Gynecology and general ophthalmic OPD in case of ambulatory patients.Cases of Pregnancy Induced Hypertension."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 1002, "none", "none", 1, "e.0A", "Cases complicated by malignancy&#44;renal&#44;liver or any other secondary manifestations."));	       
	        
            fs.countries!.Add(new StudyCountry(sd_sid, 1269750, "India", null));
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: Thai registry web page";
            string ob_title = display_title + " :: Thai registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Thai registry web page", null, ob_title,
	            null, 9, 2016, 23, 13, 100131, "Thai Clinical Trials Register", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100131, "Thai Clinical Trials Register", 
	            "www.thaiclinicaltrials.org/show/TCTR20161221005", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2016 Dec 21", 2016, 12, 21, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2025 May 1", 2023, 5, 1, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs; 
        }
        
        return null;
    }
}