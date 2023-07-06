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
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 1500));  // Other
	        
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
	       
	       return fs;
        }
        
        if (sd_sid == "ChiCTR-POC-17010431")
        {
	        
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "The analysis of current status in diagnosis and treatment of COPD";
	        StringBuilder sb = new StringBuilder();
	        sb.Append("Interventions: 1 cohort:NA\n");
	        sb.Append("Primary outcome(s): frequency of exacerbations;mortality;lung function;mMRC;CAT;CCQ\n");
	        sb.Append("Study Design: Cohort study");
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
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 1500));  // Other

	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "1.", 1, "n.01", "patients with a diagnosis of COPD, with a post-bronchodilator ratio of FEV1/FVC < 0.7;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "2.", 1, "n.02", "aged > 40 years;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "2.", 1, "n.03", "can complete mMRC CAT and CCQ without communication barrier."));
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 2, "cr", "1.", 1, "e.01", "with sever cardiac, liver and renal diseases;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr", "2.", 1, "e.02", "patients with cognition disorders. "));
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr", "3.", 1, "e.03", "patients who refuse to participate"));
	        
	        // Null condition list
	        
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
            
            return fs;

        }

        if (sd_sid == "ChiCTR1900022627")
        {

	        FullStudy fs = CreateEmptyFullStudy();

	        // Study 

	        string display_title = "Optimal intervention time and risk of the Activating Blood and Removing Stasis Method in acute cerebral hemorrhage patients: a Randomized Placebo-Controlled Trial";
	        StringBuilder sb = new StringBuilder();
	        sb.Append("Interventions: Blood Stasis Removing group:Blood Stasis Removing Granule + routine treatment;Placebo group:Placebo of Blood Stasis Removing Granule + routine treatment");
	        sb.Append("Primary outcome(s): The degree of disability (modified Ranking Scale, mRS)");
	        sb.Append("Study Design: Parallel");
	        string brief_desc = sb.ToString();

	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2019, 5, 11, 14,
		        "Blood Stasis Removing group:156;Placebo group:156", 900, 
		        35, 17, 80, 17, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100118,
		        "Chinese Clinical Trial Register", null, "2019 Apr 19", null));

	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true,
		        "From the Chinese Clinical Trials Register"));

	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Cui Yabin",
		        "Affiliated Hospital to Changchun University of Chinese Medicine", null,
		        "Affiliated Hospital to Changchun University of Chinese Medicine", null));
	        fs.people.Add(new StudyPerson(sd_sid, 56, "Wang Jian",
		        "The Affiliated Hospital to Changchun University of Chinese Medicine", null,
		        "The Affiliated Hospital to Changchun University of Chinese Medicine", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Affiliated Hospital to Changchun University of Chinese Medicine", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "National clinical research base construction project of the national administration of traditional Chinese medicine", null));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 1500));  // Other
	        
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "1.", 1, "n.01", "Patient diagnosed to be cerebral hemorrhagic stroke and confirmed by CT"));
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "2.", 1, "n.02", "Age 35 to 80 years;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "2.", 1, "n.03", "The stroke onset time is within 24-72h;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr", "4.", 1, "n.04", "Patients receive conservative treatment of conventional medicine;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr", "5.", 1, "n.05", "Glasgow Coma Score > 6 points;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr", "6.", 1, "n.06", "The modified Rankin Scale Score before the onset is 0 to 1 point;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr", "7.", 1, "n.07", "Inform-consented"));
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr", "1.", 1, "e.01", "Confirmed cerebral hemorrhage that is caused by brain tumor, blood disease, brain trauma (or postoperative);"));
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "2.", 1, "e.02", "Patients with coma or patients with cerebral hernia at the onset of the cerebral hemorrhage;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "3.", 1, "e.03", "Those who cannot take the study drug by orall or nasal feeding because of gastrointestinal bleeding;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "4.", 1, "e.04", "Patients need emergency surgery;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr", "5.", 1, "e.05", "Patients with subarachnoid hemorrhage;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr", "6.", 1, "e.06", "Women who are pregnant or lactating;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr", "7.", 1, "e.07", "Patients with severe primary diseases such as cardiovascular, hepatic, renal and hematopoietic systems diseases, and mental diseases. Patients with abnormal (doubled level) conventional coagulation examinations, liver function and kidney function."));
	        fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr", "8.", 1, "e.08", "Allergic constitution or known allergy to alcohol or ingredients of Chinese medicine BSR."));
	        fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr", "9.", 1, "e.09", "Hemorrhagic stroke induced by taking anticoagulant drugs;"));
	        fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr", "10.", 1, "e.10", "Patients who participated in other clinical trials in the recent 3 months."));
	       
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Acute Cerebral Hemorrhage", null, null, null, null));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 105));  // Early phase 1
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));  // Parallel assignment

	        fs.countries!.Add(new StudyCountry(sd_sid, 1814991, "China", null));
	        
	        // Data Objects

	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: Chinese registry web page";
	        string ob_title = display_title + " :: Chinese registry web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();

	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Chinese registry web page'", null, ob_title,
		        null, 9, 2019, 23, 13, 100118, "Chinese Clinical Trial Register",
		        null, "en", 12, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));

	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100118, "Chinese Clinical Trial Register",
		        "http://www.chictr.org.cn/showproj.aspx?proj=38214", true, 35, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2019 Apr 19", 2019, 4, 19, null, null, null,
		        null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 Mar 08", 2021, 3, 8, null, null, null, null));

	        fs.data_objects!.Add(sdo);

	        return fs;
        }

        return null;
    }
}