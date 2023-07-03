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
        
        /*
         *
         * 
  "source_id": 100118,
  "record_date": "2021-03-08",
  "sd_sid": "ChiCTR1900022627",
  "public_title": "Optimal intervention time and risk of the Activating Blood and Removing Stasis Method in acute cerebral hemorrhage patients: a Randomized Placebo-Controlled Trial",
  "scientific_title": "Optimal intervention time and risk of the Activating Blood and Removing Stasis Method in acute cerebral hemorrhage patients: a Randomized Placebo-Controlled Trial",
  "remote_url": "http://www.chictr.org.cn/showproj.aspx?proj=38214",
  "public_contact_givenname": "Wang Jian",
  "public_contact_familyname": null,
  "public_contact_email": "jian-w222@163.com",
  "public_contact_affiliation": "The Affiliated Hospital to Changchun University of Chinese Medicine",
  "scientific_contact_givenname": "Cui Yabin",
  "scientific_contact_familyname": null,
  "scientific_contact_email": "58370183@qq.com",
  "scientific_contact_affiliation": "The Affiliated Hospital to Changchun University of Chinese Medicine",
  "study_type": "Interventional",
  "date_registration": "2019-04-19",
  "date_enrolment": "2019-05-01",
  "target_size": "Blood Stasis Removing group:156;Placebo group:156",
  "study_status": "Recruiting",
  "primary_sponsor": "The Affiliated Hospital to Changchun University of Chinese Medicine",
  "secondary_sponsors": null,
  "source_support": "National clinical research base construction project of the national administration of traditional Chinese medicine",
  "interventions": "Blood Stasis Removing group:Blood Stasis Removing Granule + routine treatment;Placebo group:Placebo of Blood Stasis Removing Granule + routine treatment",
  "agemin": "35",
  "agemin_units": "Other (35)",
  "agemax": "80",
  "agemax_units": "Other (80)",
  "gender": "Both",
  "inclusion_criteria": "1. Patient diagnosed to be cerebral hemorrhagic stroke and confirmed by CT;\n2. Age 35 to 80 years;\n3. The stroke onset time is within 24-72h;\n4. Patients receive conservative treatment of conventional medicine;\n5. Glasgow Coma Score > 6 points;\n6. The modified Rankin Scale Score before the onset is 0 to 1 point;\n7. Inform-consented",
  "exclusion_criteria": "1. Confirmed cerebral hemorrhage that is caused by brain tumor, blood disease, brain trauma (or postoperative);\n2. Patients with coma or patients with cerebral hernia at the onset of the cerebral hemorrhage;\n3. Those who cannot take the study drug by orall or nasal feeding because of gastrointestinal bleeding;\n4. Patients need emergency surgery;\n5. Patients with subarachnoid hemorrhage;\n6. Women who are pregnant or lactating;\n7. Patients with severe primary diseases such as cardiovascular, hepatic, renal and hematopoietic systems diseases, and mental diseases. Patients with abnormal (doubled level) conventional coagulation examinations, liver function and kidney function.\n8. Allergic constitution or known allergy to alcohol or ingredients of Chinese medicine BSR. \n9. Hemorrhagic stroke induced by taking anticoagulant drugs;\n10. Patients who participated in other clinical trials in the recent 3 months.",
  "primary_outcome": "The degree of disability (modified Ranking Scale, mRS)",
  "secondary_outcomes": "Percentage of hematoma enlargement after taking the drug in patients within 72 hours of onset;Ability of daily life (Barthel Index);Mortality rate due to cerebral hemorrhage;All-cause mortality;National Institute of Health stroke scale (NIHSS);Traditional Chinese Medicine Stroke Syndrome Evaluation Scale;The degree of disability (modified Ranking Scale, mRS)",
  "bridging_flag": null,
  "bridged_type": null,
  "childs": null,
  "type_enrolment": null,
  "retrospective_flag": null,
  "results_actual_enrollment": null,
  "results_url_link": null,
  "results_summary": null,
  "results_date_posted": null,
  "results_date_first_publication": null,
  "results_url_protocol": null,
  "ipd_plan": null,
  "ipd_description": null,
  "results_date_completed": null,
  "results_yes_no": null,
  "db_name": "chictr",
  "design_string": "Parallel",
  "phase_string": "0",
  "country_list": [
    "China"
  ],
  "study_features": [
    {
      "ftype_id": 23,
      "ftype": "Intervention model",
      "fvalue_id": 305,
      "fvalue": "Parallel assignment"
    },
    {
      "ftype_id": 20,
      "ftype": "Phase",
      "fvalue_id": 105,
      "fvalue": "Early phase 1"
    }
  ],
  "condition_list": [
    {
      "condition": "Acute Cerebral Hemorrhage",
      "code": null,
      "code_system": null
    }
  ]
         */

        return null;
    }
}