using System.Text;

namespace MDR_Tester;

public class TestData_100125 : TestData_Base
{
	public override FullStudy? FetchStudyData(string sd_sid)
	{
		if (sd_sid == "IRCT138707201323N1")
		{
	          FullStudy fs = CreateEmptyFullStudy();
		          
	          // Study
					  
	          string display_title = "Comparison of efficacy and complications of PCNL under General and Spinal anesthesia";
	          StringBuilder sb = new StringBuilder("Interventions: Intervention 1: Performing PCNL under spinal anesthesia at the prone position. ");
	          sb.Append("Intervention 2: Performing PCNL under general anesthesia at the prone position.;Treatment - Surgery;Treatment - Surgery;");
	          sb.Append("Performing PCNL under spinal anesthesia at the prone position;Performing PCNL under general anesthesia at the prone position");
	          sb.Append("Primary outcome(s): Success rate of operation. Timepoint: during operation and two week later. ");  
	          sb.Append("Method of measurement: observation by nephroscope and fluroscopy during operation and with sonography and KUB two weeks later.");   
	          sb.Append("Study Design: Randomization: Randomized, Blinding: Single blinded, Placebo: Not used, Assignment: Parallel, Purpose: Treatment.");
	          string brief_desc = sb.ToString();
	          
	          fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2008, 2, 11, 21, "1", 900,
	            18, 17, null, null, 10);

	          fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100125, 
	            "Iranian Registry of Clinical Trials", null, "2009 Dec 20", null));
		          
	          fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
	            "From the Iranian Clinical Trials Registry"));
	          
	          fs.people!.Add(new StudyPerson(sd_sid, 56, "Sadrollah Mehrabi", 
		          "Yasuj university of medical science", null, "Yasuj university of medical science", null));	
			
	          fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null,
		          "Research manager, Yasuj University of Medical Sciences", null));
	          fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, 
		          "Research manager, Yasuj University of Medical Sciences", null));

		
/*
  "inclusion_criteria": 
  "Age more than 18 years, presence of renal or upper ureteral stone, candidate for PCNL (multiple stones, staghorn stones, calyceal diverticule stones, stone which are resistant to ESWL, lower pole renal stone larger than >15 mm and other renal stone larger than 25 mm, upper ureteral stone >20mm, Having informed consent 
  \nAny contraindication for regional anesthesia, presence of coagulopathy, acute infection ore urosepsis, presence of acute renal failure",
  "exclusion_criteria": null,
  
  */

        fs.conditions!.Add(new StudyCondition(sd_sid, "Renal and ureteral stones", null, null, null, null));
        fs.conditions.Add(new StudyCondition(sd_sid, "Calculus of kidney with calculus of ureter", null, null, null, null));

        fs.features!.Add(new (sd_sid, 21, 400));  // Treatment
        fs.features.Add(new (sd_sid, 22, 205));  //  Randomised
        fs.features.Add(new (sd_sid, 23, 305));  //  Parallel assignment
        fs.features.Add(new (sd_sid, 24, 505));  //  Single
        
        fs.countries!.Add(new StudyCountry(sd_sid, 130758, "Iran", null));
        
        // Data Objects
	        
        // 1) Trial registry entry

        string sd_oid = sd_sid + " :: 13 :: Iranian registry web page";
        string ob_title = display_title + " :: Iranian registry web page";
        StudyDataObject sdo = CreateEmptyStudyDataObject();
       
        sdo.data_object = new DataObject(sd_oid, sd_sid, "Iranian registry web page", null, ob_title,
          null, 9, 2009, 23, 13, 100125, "Iranian Registry of Clinical Trials",
          null, "en", 12, null, null, 0, true, true);
        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        
        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100125, "Iranian Registry of Clinical Trials", 
          "http://en.irct.ir/trial/570", true, 35, null, null, null));
        sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2009 Dec 20", 2009, 12, 20, null, null, null, null));
        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2018 Feb 22", 2018, 2, 22, null, null, null, null));
	       
        fs.data_objects!.Add(sdo);

        return fs;

		}

		if (sd_sid == "IRCT20210521051357N1")
		{
          FullStudy fs = CreateEmptyFullStudy();
	          
          // Study
				  
          string display_title = "The effect of combined exercises with the approach of extreme readiness and coffee consumption on liver enzymes and motor function of middle-aged men with non-alcoholic fatty liver";
          StringBuilder sb = new StringBuilder("Interventions: Intervention 1: Intervention group: Intervention group 1: Combined exercise, training intervention will be done 3 sessions per week for 60 minutes. ");
          sb.Append("Each session consists of 3 parts of practice, 5 parts. Start the training program by warming up for 10 to 15 minutes. Then the training sections are ");
          sb.Append("performed as follows three times without rest: 1- Balance movement for 15 to 20 seconds 2- Aerobic movement for 20 to 30 seconds and with an intensity ");
          sb.Append("55 to 65% of the maximum heart rate. Pilates largely avoids high impact, high power output, and heavy muscular and skeletal loading. Pilates largely avoids ");
          sb.Append("high impact, high power output, and heavy muscular and skeletal loading. Pilates largely avoids high impact, high power output, and heavy muscular and skeletal ");
          sb.Append("loading. Becomes.Subjects rest for 1 to 2 minutes before the start of the next part. Subsequent parts will be performed according to the same procedure and ");
          sb.Append("with various movements on other parts of the body. After finishing 3 parts, cooling is done for 5 minutes. Intervention 2: Intervention group: ");
          sb.Append("Intervention group 2 combined exercises with coffee consumption, combined exercise intervention 3 sessions per week for 60 minutes. Each session consists ");
          sb.Append("3 parts of practice, 5 parts. Start the training program by warming up for 10 to 15 minutes. Then the training sections are performed in the following way three ");
          sb.Append("times without rest: 1- Balance movement for 15 to 20 seconds 2- Aerobic movement for 20 to 30 seconds and with an intensity of 55 to 65% of the maximum heart rate. ");
          sb.Append("Pilates largely avoids high impact, high power output, and heavy muscular and skeletal loading. Pilates largely avoids high impact, high power output, and heavy ");
          sb.Append("muscular and skeletal loading. Pilates largely avoids high impact, high power output, and h");
          sb.Append("Primary outcome(s): Serum levels of hepatic alanine transaminase and aspartate transaminase enzymes. Timepoint: Measurement three days before the ");  
          sb.Append("start of the study intervention. Method of measurement: Blood test to determine the serum levels of alanine transaminase and aspartate transaminase liver ");   
          sb.Append("enzymes is performed by BT 2500 analyzer and 3000 rpm centrifuge for 5 minutes with Behdad device made in Iran and standard kits of Par Azmoon company.;Liver grade. ");  
          sb.Append("Timepoint: Measurement three days before the start of the study intervention. Method of measurement: Liver grade with ultrasound device from Samsung "); 
          sb.Append("Korea WS80A model.;Blood lipid profile. Timepoint: Measurement three days before the start of the study intervention. Method of measurement: Blood test ");
          sb.Append("to determine the amount of blood lipid profile is measured by BT 2500 analyzer and 3000 rpm centrifuge in 5 minutes with Behdad device made in Iran and standard ");  
          sb.Append("kits of Par Azmoon company.;Motor function. Timepoint: Measurement three days before the start of the study intervention. Method of measurement: Motor function is "); 
          sb.Append("performed by fitness tests (sit-ups, steps, stork balance, quadratic agility, and Welsh flexibility).");
          sb.Append("Study Design: Randomization: Randomized, Blinding: Not blinded, Placebo: Not used, Assignment: Factorial, Purpose: Supportive, ");
          sb.Append("Randomization description: Describe how to randomizeRandom assignment to intervention and control groupsIn this study, we used the restricted ");
          sb.Append("randomization method for all study groups with sample size.We will use the same type of random allocation rule. This method represents a large ");
          sb.Append("block for the total sample size, which means that the balance in the number of people assigned to each group will be achieved at the end of the study. ");
          sb.Append("For this purpose, the sample size (44 people) will be determined first. Then we randomly assign their set to groups A, B and C to the intervention ");
          sb.Append("groups (11 people in each group). And group D is for control (11 people). 11 balls (or lottery cards) for each group And we consider a total of 44 numbers.");
          sb.Append("We throw the balls (sheets) into a container and then randomly, the balls (sheets) are taken out of the container without replacement, and t");
          string brief_desc = sb.ToString();
          sb = new StringBuilder("Yes - There is a plan to make this available\n");
          sb.Append("What will be shared: Information on the main outcomes studied Possibility of subscription Has a transition.  ");
          sb.Append("When: The data are available after the publication of all the results obtained Will take Community Verified icon  ");
          sb.Append("To whom: Only for researchers working in academic and scientific institutions  ");
          sb.Append("Conditions: The study or proposal protocol should be submitted by the Ethics Committee of the institution or university To be approved. ");
          sb.Append("The rights of authors and their sponsors must be protected Be  Where to obtain: Talireza099@gmail.com or alireza.taheri@shahed.ac.ir  ");
          sb.Append("How to obtain: This request must be addressed to the Vice Chancellor for Research and Technology of Shahed University of Tehran and will be done with the information of the project manager  Comments:");
          
          string dss = sb.ToString();
          
          fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2021, 6, 11, 21, "50", 910,
            30, 17, 60, 17, 10);

          fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100125, 
            "Iranian Registry of Clinical Trials", null, "2021 Jul 22", null));
	          
          fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
            "From the Iranian Clinical Trials Registry"));
          fs.titles.Add(new StudyTitle(sd_sid, 
            "The effect of eight weeks of independent combined training with coffee consumption on blood lipid profile of middle-aged men with non-alcoholic fatty liver in Covid-19 condition", 
            16, "en", 11, false, "From the Iranian Clinical Trials Registry"));
          
          fs.people!.Add(new StudyPerson(sd_sid, 51, "Nahid Talebi", 
	          "Shahed University", 102305, "Shahed University", "https://ror.org/01e8ff003"));	
          fs.people!.Add(new StudyPerson(sd_sid, 56, "Alireza Taheri Dilatabadi", 
	          "Shahed University", 102305, "Shahed University", "https://ror.org/01e8ff003"));	
			
          fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 102305,
	          "Shahed University", "https://ror.org/01e8ff003"));
          fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 102305, 
	          "Shahed University", "https://ror.org/01e8ff003"));
/*
 * 
  "inclusion_criteria": 
  "Middle-aged men 30 to 60 years
  \nGrade 1, 2 and 3 liver disease
  \nPeople with high blood lipid profiles
  \nPeople without cardiovascular disease
  \nPeople without physical disabilities",
  "exclusion_criteria": 
  "Men over 60 years old
  \nPeople with fatty liver disease grade 4
  \nPeople with physical disabilities
  \nPeople with heart failure
  \nPeople with lung disease",

}
 * 
 */

        fs.conditions!.Add(new StudyCondition(sd_sid, "Non-alcoholic fatty liver disease", null, null, null, null));
        fs.conditions.Add(new StudyCondition(sd_sid, "Fatty (change of) liver, not elsewhere classified", null, null, null, null));
        fs.conditions.Add(new StudyCondition(sd_sid, "K76.0", null, null, null, null));

        fs.features!.Add(new (sd_sid, 21, 415));  // Supportive care
        fs.features.Add(new (sd_sid, 22, 205));  //  Randomised
        fs.features.Add(new (sd_sid, 23, 315));  //  Factorial assignment
        fs.features.Add(new (sd_sid, 24, 500));  //  None (Open Label)
        
        fs.countries!.Add(new StudyCountry(sd_sid, 130758, "Iran", null));
				
        // Data Objects
	        
        // 1) Trial registry entry

        string sd_oid = sd_sid + " :: 13 :: Iranian registry web page";
        string ob_title = display_title + " :: Iranian registry web page";
        StudyDataObject sdo = CreateEmptyStudyDataObject();
       
        sdo.data_object = new DataObject(sd_oid, sd_sid, "Iranian registry web page", null, ob_title,
          null, 9, 2021, 23, 13, 100125, "Iranian Registry of Clinical Trials",
          null, "en", 12, null, null, 0, true, true);
        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        
        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100125, "Iranian Registry of Clinical Trials", 
          "http://en.irct.ir/trial/56894", true, 35, null, null, null));
        sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2021 Jul 22", 2021, 7, 22, null, null, null, null));
        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 Aug 30", 2021, 8, 30, null, null, null, null));
	       
        fs.data_objects!.Add(sdo);

        return fs;
		}

		return null;
	}
}

