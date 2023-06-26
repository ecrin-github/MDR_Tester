using System.Text;

namespace MDR_Tester;

public class TestData_100118 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "ChiCTR-OOC-16010171")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "A Clinical Study of Fundus Findings in Toxaemia of Pregnancy(Pregnancy Induced Hypertension)";
	        StringBuilder sb = new StringBuilder();
	        sb.Append("Interventions: An observational study in which the patients for the study are selected from antenatal clinic, antenatal ward ");
	        sb.Append("and preeclampsia and eclampsia room” in Department of Obstetrics and Gynecology and general ophthalmic OPD in case of ambulatory patients ");
	        sb.Append("during the period of November 2003 to June 2006 randomly.:ophthalmoscopy in pregnancy induced hypertension\n");
	        sb.Append("Primary outcome(s): Correlation of fundus changes with disease entity,age,gravida,systolic and diastolic blood pressure,duration of ");
	        sb.Append("pregnancy and significance of individual fundus changes were noted.\n");
	        sb.Append("Study Design: Case series");
	        string brief_desc = sb.ToString();
	        sb = new StringBuilder();
	        sb.Append("An observational study in which the patients for the study are selected from antenatal clinic, ");
	        sb.Append("antenatal ward and preeclampsia and eclampsia room” in Department of Obstetrics and Gynecology ");
	        sb.Append("and general ophthalmic OPD in case of ambulatory patients durin");
	        string enrolment = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2003, 11, 12, 21, 
		                         enrolment, 905, 18, 17, 42, 17, 7);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100118, 
		        "Chinese Clinical Trial Register", null, "2016 Dec 18", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "NCT03076619", 11, 100120, 
		        "Clinicaltrials.gov", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "JPRN-UMIN000024722", 11, 100127, 
		        "Japan Primary Registries Network", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
		        "From the Chinese Clinical Trials Register"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Rahul Navinchandra Bakhda",
		        "Ex-Resident, M and J Western Regional Institute of Ophthalmology, Ahmedabad", null,
		        "M and J Western Regional Institute of Ophthalmology", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "M and J Western Regional Institute of Ophthalmology, BJMedical College and Civil Hospital", null));
	        
	        fs.features!.Add(new (sd_sid, 20, 1500));  // Other
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Pregnancy Induced Hypertension", null, null, null, null));
	        fs.conditions!.Add(new StudyCondition(sd_sid, "O13- >", null, null, null, null));
            
	        fs.countries!.Add(new StudyCountry(sd_sid, 1269750, "India", null));

	        string ic = "An observational study in which the patients for the study are selected from antenatal clinic antenatal ward and preeclampsia and eclampsia ";
	        ic += "room in Department of Obstetrics and Gynecology and general ophthalmic OPD in case of ambulatory patients.Cases of Pregnancy Induced Hypertension.";
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1001, "none", "none", 0, "n0.A", ic ));
	        fs.iec!.Add(new StudyIEC(sd_sid, 2, 1002, "none", "none", 0, "e0.A", "Cases complicated by malignancy,renal,liver or any other secondary manifestations."));

            // Data Objects
	        
	        // 1) Trial registry entry

	       string sd_oid = sd_sid + " :: 13 :: Chinese registry web page";
	       string ob_title = display_title + " :: Chinese registry web page";
	       StudyDataObject sdo = CreateEmptyStudyDataObject();
	       
	       
	       sdo.data_object = new DataObject(sd_oid, sd_sid, "Chinese registry web page'", null, ob_title,
		       null, 9, 2016, 23, 13, 100118, "Chinese Clinical Trial Register",
		       null, "en", 12, null, null, 0, true, true);
	       
	       sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	       sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100118, "Chinese Clinical Trial Register", 
		       "http://www.chictr.org.cn/showproj.aspx?proj=17318", true, 35, null, null, null));
	       sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2016 Dec 18", 2016, 12, 18, null, null, null, null));
	       sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2017 Apr 18", 2017, 4, 18, null, null, null, null));
	       
	       fs.data_objects!.Add(sdo);
         
        }
        
        if (sd_sid == "ChiCTR-POC-17010431")
        {
	        
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "The analysis of current status in diagnosis and treatment of COPD";
	        StringBuilder sb = new StringBuilder();
	        sb.Append("Interventions: 1 cohort:NA\n");
	        sb.Append("Primary outcome(s): frequency of exacerbations;mortality;lung function;mMRC;CAT;CCQ\n");
	        sb.Append("Study Design: Cohort study'");
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2017, 1, 16, 16, 
		        "1 cohort:5000", 900, 40, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100118, 
		        "Chinese Clinical Trial Register", null, "2017 Jan 14", null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
		        "From the Chinese Clinical Trials Register"));

	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Zijing Zhou",
		        "Department of Respiratory Medicine, the Second Xiangya Hospital of Central South University", null,
		        "Second Xiangya Hospital of Central South University", null));
	        fs.people.Add(new StudyPerson(sd_sid, 56, "Ping Chen",
		        "Department of Respiratory Medicine, the Second Xiangya Hospital of Central South University", null,
		        "Second Xiangya Hospital of Central South University", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Department of Respiratory Medicine, the Second Xiangya Hospital of Central South University", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "the National Key Clinical Specialty Construction Projects, China", null));
	        
	        fs.features!.Add(new (sd_sid, 20, 1500));  // Other

	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "1.", 1, "n.1", "patients with a diagnosis of COPD, with a post-bronchodilator ratio of FEV1/FVC < 0.7;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "2.", 1, "n.2", "aged > 40 years;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "2.", 1, "n.3", "can complete mMRC CAT and CCQ without communication barrier."));
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 2, "cr", "1.", 1, "e.1", "with sever cardiac, liver and renal diseases;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr", "2.", 1, "e.2", "patients with cognition disorders. "));
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr", "3.", 1, "e.3", "patients who refuse to participate"));
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: Chinese registry web page";
            string ob_title = display_title + " :: Chinese registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Chinese registry web page'", null, ob_title,
	            null, 9, 2017, 23, 13, 100118, "Chinese Clinical Trial Register",
	            null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100118, "Chinese Clinical Trial Register", 
	            "http://www.chictr.org.cn/showproj.aspx?proj=17751", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2017 Jan 14", 2017, 1, 14, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2017 Apr 18", 2017, 4, 18, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

        }

        return null;
    }
}