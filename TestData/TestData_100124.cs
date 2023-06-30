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

        
        return null;
    }
}