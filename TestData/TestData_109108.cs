using System.Text;

namespace MDR_Tester;

public class TestData_109108 : TestData_Base
{
	public override FullStudy? FetchStudyData(string sd_sid)
	{
		if (sd_sid == "ITMCTR1900002289")
		{
			FullStudy fs = CreateEmptyFullStudy();
        
			// Study
			
			string display_title = "Optimal intervention time and risk of the Activating Blood and Removing Stasis Method in acute cerebral hemorrhage patients: A Randomized Placebo-Controlled Trial";
			StringBuilder sb = new StringBuilder("Interventions: Placebo group:Placebo of Blood Stasis Removing Granule + routine treatment;");
			sb.Append("Blood Stasis Removing group:Blood Stasis Removing Granule + routine treatment");
			sb.Append("Primary outcome(s): The degree of disability (modified Ranking Scale, mRS)");  
			sb.Append("Study Design: Parallel");
			string brief_desc = sb.ToString();
    
			fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2019, 5, 11, 16,
				"Placebo group:156;Blood Stasis Removing group:156", 900,
				35, 17, 80, 17, 10);

			fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 109108, 
				"International Traditional Medicine Clinical Trials Registry", null, "2019 Apr 19", null));
			fs.identifiers!.Add(new StudyIdentifier(sd_sid, "ChiCTR1900022627", 11, 100118, 
				"Chinese Clinical Trial Register", null, null, null));
			fs.identifiers!.Add(new StudyIdentifier(sd_sid, "ChiMCTR1900002289", 11, 104545, 
				"Chinese Medicine Clinical Trials Registry", null, null, null));

			fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
				"From the Traditional Medicine Clinical Trials Registry"));
		
			fs.people!.Add(new StudyPerson(sd_sid, 51, "Cui Yabin", 
				"The Affiliated Hospital to Changchun University of Chinese Medicine", null, 
				"The Affiliated Hospital to Changchun University of Chinese Medicine", null));
			fs.people.Add(new StudyPerson(sd_sid, 56, "Wang Jian", 
				"The Affiliated Hospital to Changchun University of Chinese Medicine", null, 
				"The Affiliated Hospital to Changchun University of Chinese Medicine", null));
            
			fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, 
				"The Affiliated Hospital to Changchun University of Chinese Medicine", 
				null));
			fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, 
				"National clinical research base construction project of the national administration of traditional Chinese medicine", 
				null));

			fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "1.", 1, "n.01", "Patient diagnosed to be cerebral hemorrhagic stroke and confirmed by CT;"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "2.", 1, "n.02", "Age 35 to 80 years"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "3.", 1, "n.03", "The stroke onset time is within 24-72h;"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr", "4.", 1, "n.04", "Patients receive conservative treatment of conventional medicine;"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr", "5.", 1, "n.05", "Glasgow Coma Score > 6 points;"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr", "6.", 1, "n.06", "The modified Rankin Scale Score before the onset is 0 to 1 point;"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr", "7.", 1, "n.07", "Inform-consented"));	    
			
			fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr", "", 1, "e.01", "Confirmed cerebral hemorrhage that is caused by brain tumor, blood disease, brain trauma (or postoperative);"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "", 1, "e.02", "Patients with coma or patients with cerebral hernia at the onset of the cerebral hemorrhage;"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "", 1, "e.03", "Those who cannot take the study drug by orall or nasal feeding because of gastrointestinal bleeding;"));
			fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "", 1, "e.04", "Patients need emergency surgery;"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr", "", 1, "e.05", "Patients with subarachnoid hemorrhage;"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr", "", 1, "e.06", "Women who are pregnant or lactating;"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr", "", 1, "e.07", "Patients with severe primary diseases such as cardiovascular, hepatic, renal and hematopoietic systems diseases, and mental diseases. Patients with abnormal (doubled level) conventional coagulation examinations, iver function and kidney function."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr", "", 1, "e.08", "Allergic constitution or known allergy to alcohol or ingredients of Chinese medicine BSR."));	    
			fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr", "", 1, "e.09", "Hemorrhagic stroke induced by taking anticoagulant drugs;"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr", "", 1, "e.10", "Patients who participated in other clinical trials in the recent 3 months."));	   
				
			fs.conditions!.Add(new StudyCondition(sd_sid, "Acute Cerebral Hemorrhage", null, null, null, null));
			
			fs.features!.Add(new (sd_sid, 20, 105));  // Early phase 1
			fs.features.Add(new (sd_sid, 23, 305));  //  Parallel assignment
			
			fs.countries!.Add(new StudyCountry(sd_sid, 1814991, "China", null));
			
			// Data Objects
        
			// 1) Trial registry entry

			string sd_oid = sd_sid + " :: 13 :: Traditional Medicine registry web page";
			string ob_title = display_title + " :: Traditional Medicine registry web page";
			StudyDataObject sdo = CreateEmptyStudyDataObject();
   
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Traditional Medicine registry web page", null, ob_title,
				null, 9, 2019, 23, 13, 109108, "International Traditional Medicine Clinical Trials Registry",
				null, "en", 12, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
        
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 109108, "International Traditional Medicine Clinical Trials Registry", 
				"http://itmctr.ccebtcm.org.cn/en-US/Home/ProjectView?pid=b349edbc-f969-4a58-aace-2135a05ccc9b", 
				true, 35, null, null, null));
			sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2019 Apr 19", 2019, 4, 19, null, null, null, null));
			sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2023-02-20", 2023, 2, 20, null, null, null, null));
       
			fs.data_objects!.Add(sdo);

			return fs;

		}

		return null;
	}
}
