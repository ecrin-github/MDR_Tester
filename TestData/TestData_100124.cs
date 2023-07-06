using System.Text;

namespace MDR_Tester;

public class TestData_100124 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "DRKS00011324")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "A Clinical Study of Fundus Findings in Toxaemia of Pregnancy(Pregnancy Induced Hypertension)";
	        StringBuilder sb = new StringBuilder("Intervention 1: An observational study in which the patients for the study are selected from antenatal clinic, antenatal ward and preeclampsia and eclampsia");
	        sb.Append("room” in Department of Obstetrics and Gynecology and general ophthalmic OPD in case of ambulatory patients during the period of November 2003 to June 2006 randomly."); 
	        sb.Append("In every case detail obstetric history, general examination and relevant pathological investigations were carried out. In every case, pupil was dilated with\n"); 
	        sb.Append("homatropine (2%) eye drops and detailed ophthalmic examination was carried out.Assessment of prognosis as regards to vision and life (mortality) was made.\n"); 
	        sb.Append("Primary outcome(s): An observational study in which the patients for the study are selected from antenatal clinic, antenatal ward and "); 
	        sb.Append("preeclampsia and eclampsia room” in Department of Obstetrics and Gynecology and general ophthalmic OPD in case of ambulatory patients "); 
	        sb.Append("during the period of November 2003 to June 2006 randomly.\n"); 
	        sb.Append("In every case detail obstetric history, general examination and relevant pathological investigations were carried out. In every case, "); 
	        sb.Append("pupil was dilated with homatropine (2%) eye drops and detailed ophthalmic examination was carried out.\n"); 
	        sb.Append("Fundus findings were noted in detail, changes in the color of the disc, disc margin, physiological cup, changes in retinal blood "); 
	        sb.Append("vessels especially caliber of vessels, arterio-venous (AV) ratio,changes in vessel wall, blood column, appearance of vascular\n"); 
	        sb.Append("light reflex, changes at AV crossings, changes in macular area and changes in background, overall appearance, presence of hemorrhages, "); 
	        sb.Append("exudates or any pathology were recorded.Correlation of fundus changes with disease entity,age,gravida,systolic and diastolic blood "); 
	        sb.Append("pressure,duration of pregnancy and significance of individual fundus changes were noted.\n"); 
	        sb.Append("Study Design: Allocation: Single arm study;. Masking: Open (masking not used). Control: Uncontrolled/Single arm. Assignment: Single (group). Study design purpose: Diagnostic"); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2003, 11, 12, 21, "300", 905,
		        18, 17, 42, 17, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100124, 
		        "Deutschen Register Klinischer Studien", null, "2016 Dec 5", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U1111-1189-6165", 11,  100115, 
		        "International Clinical Trials Registry Platform", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "JPRN-UMIN000024722", 11,  100127, 
		        "Japan Primary Registries Network", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "NCT03076619", 11,  100120, 
		        "ClinicalTrials.gov", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Deutschen Register Klinischer Studien"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Rahul Bakhda", "Ex-Resident, M and J Western Regional Institute of Ophthalmology, Ahmedabad", 
		        null, "M and J Western Regional Institute of Ophthalmology", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null,
		        "M and J Western Regional Institute of Ophthalmology, Ahmedabad", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, 
		        "M and J Western Regional Institute of Ophthalmology", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 24, 599));   // 
            
            fs.conditions!.Add(new StudyCondition(sd_sid, "Pregnancy Induced Hypertension", null, null, null, null));
            
	        // countries
            
	        // iec
	        /***
	         *"inclusion_criteria": "An observational study in which the patients for the study are selected from antenatal clinic, antenatal ward and preeclampsia and eclampsia room in Department of Obstetrics and Gynecology and general ophthalmic OPD in case of ambulatory patients.Cases of Pregnancy Induced Hypertension.",
  "exclusion_criteria": "Cases complicated by malignancy,renal,liver or any other secondary manifestations.",

	         */
	        fs.countries!.Add(new StudyCountry(sd_sid, 1269750, "India", null));
	        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: German registry web page";
	        string ob_title = display_title + " :: German registry web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "German registry web page", null, ob_title,
		        null, 9, 2016, 23, 13, 100124, "Deutschen Register Klinischer Studien", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100124, "Deutschen Register Klinischer Studien", 
		        "http://www.drks.de/DRKS00011324", true, 35, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2016 Dec 5", 2016, 12, 5, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Mar 7", 2022, 3, 7, null, null, null, null));
	       
	        fs.data_objects!.Add(sdo);

	        return fs;
        }


        if (sd_sid == "DRKS00030023")
        {
	        FullStudy fs = CreateEmptyFullStudy();

	        // Study 

	        string display_title =
		        "Rehabilitation and Clinical Observation of stroke patients to validate prognostic factors of functional and subjective Recovery after Stroke (RECOVER-S): A registry-based cohort study";
	        StringBuilder sb = new StringBuilder("Intervention 1: Registry: Patients with acute stroke requiring rehabilitation will be clinically assessed at 7 days after stroke ");
	        sb.Append("(if included in the acute hospital), and at 28 days, 3, 6, 12, and 24 months after stroke. Routine data and patient-reported outcome measures (PROMS) ");
	        sb.Append("will be collected. Start date of recruitment 24.10.2022 Intervention 2: Cohort 'Therapy': Patients with acute stroke requiring rehabilitation will be ");
	        sb.Append("clinically assessed at 7 days after stroke (if included in the acute hospital) and at 28 days, 3, 6, 12 and 24 months after stroke. ");	        
	        sb.Append("Routine data and patient-reported outcome measures (PROMS) will be collected, as well as routine data from rehabilitation clinics on the ");
	        sb.Append("therapy provided. All patients in the cohort study will also participate in the registry (Arm 1) at the same time). Start date of recruitment planned for November 2022.");
	        sb.Append("Primary outcome(s): RECOVER-S aims to examine stroke rehabilitation in Germany using a multicentric- and biomarker-based approach ");
	        sb.Append("to provide a reliable depiction on the standard of care in stroke stroke rehabilitation.\nThis registry-based cohort study has the ");
	        sb.Append("following goals: 1. To evaluate the association between stroke rehabilitation therapies and long-term functional and subjective outcome ");
	        sb.Append("with regards to timing, intensity, duration, dosing and amount of stroke rehabilitation.\nHypothesis to goal 1: There is an interindividual ");
	        sb.Append("difference in the subjective and functional recovery of stroke patients after 6 months, that depends on the type, timing, intensity, ");
	        sb.Append("duration, dosing and amount of stroke rehabiliation. This hypothesis will be tested using the following endpoints:\nPrimary Endpoints:");
	        sb.Append("\n1. Activities in daily living (assessed by the Barthel-Index) at six months after stroke\n2. Health-related quality ");
	        sb.Append("of life (assessed by the EQ-5D-5L) at six months after stroke");
	        sb.Append("Study Design: Allocation: Other;. Masking: Open (masking not used). Control: Other. Assignment: Other. Study design purpose: Prognosis");
	        string brief_desc = sb.ToString();
	        sb = new StringBuilder("In case of interest to utilize our IPD (individual participant data) the official (legally responsible) ");
	        sb.Append("investigator of a research project must apply at the specifically designated committee (Data Use and Access Committee – DUAC). ");
	        sb.Append("The application process is a standardized procedure determined by the DUAC. The DUAC consists of members of the RECOVER-S ");
	        sb.Append("chairpersons (principle investigator and/or deputy principle investigator), as well as representatives of the Charité – ");
	        sb.Append("Universitätsmedizin Berlin. The application to utilize RECOVER-S IPD will be reviewed regarding a number of formal and ");
	        sb.Append("study-specific criteria, with special attention focused on the purposefulness and necessity to specifically require RECOVER-S data. ");
	        sb.Append("Certain documents (e.g. the decision of the responsible ethics committee) will also be required in the application process. ");
	        sb.Append("If the DUAC accedes to the utilization of the RECOVER-S IPD the specific arrangements regarding the return of data, data saving, ");
	        sb.Append("elimination, deletion and anonymization procedures will be documented in written formed and signed by both parties. ");
	        sb.Append("The applicant is thus bound to concise legal conditions concerning the treatment of the data. Study participants are required ");
	        sb.Append("to state in their declaration of consent, if external research groups may acquire access to their (anonymized) study data.");

	        string dss = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2022, 10, 12, 14, "1000", 900,
		        18, 17, null, null, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100124,
		        "Deutschen Register Klinischer Studien", null, "2022 Aug 25", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U1111-1281-7659", 11, 100115,
		        "International Clinical Trials Registry Platform", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "2022-106-BO-ff", 14, 1,
		        "", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true,
		        "From the Deutschen Register Klinischer Studien"));
	        fs.titles!.Add(new StudyTitle(sd_sid,
		        "Rehabilitation and Clinical Observation of stroke patients to validate prognostic factors of functional and subjective Recovery after Stroke (RECOVER-S): A registry-based cohort study - RECOVER-S"
		        , 16, "en", 11, true, "From the Deutschen Register Klinischer Studien"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Alexander Heinrich", "Nave", "Alexander Heinrich Nave", null,
		        "Charité Universitätsmedizin Berlin Klinik für Neurologie", 
		        null, "Charité Universitätsmedizin Berlin Klinik für Neurologie", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100241,
		        "Charité - Universitätsmedizin Berlin", "https://ror.org/001w7jn25"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, 
		        "Corona-Stiftung im Stifterverband", null));
	        
	        /*
	         
	  "inclusion_criteria": 
	  "1. Male or female adult = 18 years of age at time of enrollment
	  \n2. Acute stroke (ischemic stroke or intracerebral hemorrhage) diagnosed on computed tomography (CT) or magnetic resonance imaging (MRI)
	  \n3. Time period of inclusion within = 9 days after stroke onset (acute clinic with subsequent referral to stroke rehabilitation care) or = 35 days after stroke onset (in-patient rehabilitation clinic)",
	  "exclusion_criteria": 
	  "1. No referral to subsequent stroke rehabilitation care (to neurological early rehabilitation ward or to in-patient rehabilitation clinic)
	  \n2. Presence of intracranial hemorrhage on imaging other than intracerebral hemorrhage (e.g., subarachnoid hemorrhage)
	  \n3. History of stroke (listed in pre-existing illnesses before current stroke)
	  \n4. Participant dependent on invasive ventilation
	  \n5. Life expectancy = 12 months.
	  \nBiomarker-cohort-specific exclusion criteria:
	  \n1. Patients with a primary hemorrhagic stroke
	  \n2. Presence of MRI – contraindications (e.g., cardiac pacemaker, claustrophobia, ferromagnetic implants, etc.)
	  \n3. Unable to lay still in MRI scanner for > 30 minutes",
	  
	         */
	        
	        fs.countries!.Add(new StudyCountry(sd_sid, 2921044, "Germany", null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Cerebral infarction", 12, "I63", "8B11", "Cerebral ischaemic stroke"));
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Intracerebral haemorrhage", 12, "I61", "8B00", "Intracerebral haemorrhage"));
	        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: German registry web page";
	        string ob_title = display_title + " :: German registry web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();

	        sdo.data_object = new DataObject(sd_oid, sd_sid, "German registry web page", null, ob_title,
		        null, 9, 2022, 23, 13, 100124, "Deutschen Register Klinischer Studien", null, "en", 12, null, null, 0,
		        true, true);

	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100124, "Deutschen Register Klinischer Studien",
		        "http://www.drks.de/DRKS00030023", true, 35, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2022 Aug 25", 2022, 8, 25, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Nov 14", 2022, 11, 14, null, null, null, null));

	        fs.data_objects!.Add(sdo);

	        return fs;
        }

        return null;
    }
}