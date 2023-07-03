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
        
			fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
				"From the Traditional Medicine Clinical Trials Registry"));
		
				/*


    {
      "source_field": "secondary ids",
      "sec_id": "ChiCTR1900022627",
      "processed_id": "ChiCTR1900022627",
      "sec_id_source": 100118,
      "sec_id_type_id": 11,
      "sec_id_type": "Trial Registry ID"
    },
    {
      "source_field": "secondary ids",
      "sec_id": "ChiMCTR1900002289",
      "processed_id": "ChiMCTR1900002289",
      "sec_id_source": 104545,
      "sec_id_type_id": 11,
      "sec_id_type": "Trial Registry ID"
    }				 *
				 * 
  "public_contact_givenname": "Wang Jian",
  "public_contact_affiliation": "The Affiliated Hospital to Changchun University of Chinese Medicine",
  "scientific_contact_givenname": "Cui Yabin",
  "scientific_contact_affiliation": "The Affiliated Hospital to Changchun University of Chinese Medicine",

  "primary_sponsor": "The Affiliated Hospital to Changchun University of Chinese Medicine",
  "source_support": "National clinical research base construction project of the national administration of traditional Chinese medicine",
    
  "inclusion_criteria": 
  "1. Patient diagnosed to be cerebral hemorrhagic stroke and confirmed by CT;
  \n2. Age 35 to 80 years;
  \n3. The stroke onset time is within 24-72h;
  \n4. Patients receive conservative treatment of conventional medicine;
  \n5. Glasgow Coma Score > 6 points;
  \n6. The modified Rankin Scale Score before the onset is 0 to 1 point;
  \n7. Inform-consented",
  "exclusion_criteria": 
  "1. Confirmed cerebral hemorrhage that is caused by brain tumor, blood disease, brain trauma (or postoperative);
  \n2. Patients with coma or patients with cerebral hernia at the onset of the cerebral hemorrhage;
  \n3. Those who cannot take the study drug by orall or nasal feeding because of gastrointestinal bleeding;
  \n4. Patients need emergency surgery;
  \n5. Patients with subarachnoid hemorrhage;
  \n6. Women who are pregnant or lactating;
  \n7. Patients with severe primary diseases such as cardiovascular, hepatic, renal and hematopoietic systems diseases, and mental diseases. Patients with abnormal (doubled level) conventional coagulation examinations, liver function and kidney function.
  \n8. Allergic constitution or known allergy to alcohol or ingredients of Chinese medicine BSR. 
  \n9. Hemorrhagic stroke induced by taking anticoagulant drugs;
  \n10. Patients who participated in other clinical trials in the recent 3 months.",
 
  ],
				 */
				
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
