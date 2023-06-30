using System.Text;

namespace MDR_Tester;

public class TestData_100125 : TestData_Base
{
	public override FullStudy? FetchStudyData(string sd_sid)
	{
		{
			if (sd_sid == "")
			{
				FullStudy fs = CreateEmptyFullStudy();

				// Study 
/*
 * 
  "source_id": 100125,
  "record_date": "2018-02-22",
  "sd_sid": "IRCT138707201323N1",
  "public_title": "Comparison of efficacy and complications of PCNL under General and Spinal anesthesia",
  "scientific_title": "Comparison of efficacy and complications of PCNL under General and Spinal anesthesia",
  "remote_url": "http://en.irct.ir/trial/570",
  "public_contact_givenname": "Dr Sadrollah Mehrabi",
  "public_contact_familyname": null,
  "public_contact_email": "mehrabi390@yahoo.com and dr mehrabiyums.ac.ir",
  "public_contact_affiliation": "Yasuj university of medical science",
  "scientific_contact_givenname": "Dr Sadrollah Mehrabi",
  "scientific_contact_familyname": null,
  "scientific_contact_email": "mehrabi390@yahoo.com and dr mehrabiyums.ac.ir",
  "scientific_contact_affiliation": "Yasuj University of Medical Sciences",
  "study_type": "Interventional",
  "date_registration": "2009-12-20",
  "date_enrolment": "2008-02-01",
  "target_size": "1",
  "study_status": "Completed",
  "primary_sponsor": "Research manager, Yasuj University of Medical Sciences",
  "secondary_sponsors": null,
  "source_support": "Research manager, Yasuj University of Medical Sciences",
  "interventions": "Intervention 1: Performing PCNL under spinal anesthesia at the prone position. Intervention 2: Performing PCNL under general anesthesia at the prone position.;Treatment - Surgery;Treatment - Surgery;Performing PCNL under spinal anesthesia at the prone position;Performing PCNL under general anesthesia at the prone position",
  "agemin": "18",
  "agemin_units": "Years",
  "agemax": null,
  "agemax_units": null,
  "gender": "Both",
  "inclusion_criteria": "Inclusion criteria: Age more than 18 years, presence of renal or upper ureteral stone, candidate for PCNL (multiple stones, staghorn stones, calyceal diverticule stones, stone which are resistant to ESWL, lower pole renal stone larger than >15 mm and other renal stone larger than 25 mm, upper ureteral stone >20mm, Having informed consent \nExclusion criteria: Any contraindication for regional anesthesia, presence of coagulopathy, acute infection ore urosepsis, presence of acute renal failure",
  "exclusion_criteria": null,
  "primary_outcome": "Success rate of operation. Timepoint: during operation and two week later. Method of measurement: observation by nephroscope and fluroscopy during operation and with sonography and KUB two weeks later.",
  "secondary_outcomes": "Any complications of surgery. Timepoint: during operation to one week later. Method of measurement: report of patients and observation with examination of patients.",
  "bridging_flag": null,
  "bridged_type": null,
  "childs": null,
  "type_enrolment": "anticipated",
  "retrospective_flag": "1",
  "results_actual_enrollment": null,
  "results_url_link": null,
  "results_summary": "Background: The aim of this study is Comparison of efficacy, complications and patient satisfaction from percutaneous nephrolithotomy (PCNL) in prone and supine position under spinal anesthesia.<br /> Materials and methods:  In this clinical trial 60 patients candidate for PCNL after taking consent form ‚ randomly assigned in two groups. In group 1 PCNL was done in supine position under spinal anesthesia by standard method. In group 2 after changing patients to prone position PCNL was done as first group.<br /> <br /> <br /> In both groups after operation patients satisfaction from position during operation was checked by Beck scale. Two weeks later patients again visit and efficacy of operation checked by KUB and ultrasonography. All data records and analysed by SPSS software and statistical Tests.<br /> Results: Mean operative time was similar in the two groups (112±24.5 minute in supine and 109±19.7 minute in prone) (p=0.18)<br /> The mean hospital stay in supine position and prone position were 2.44±1.02 and 2.12 ±0.56 days respectively (p>0.05). The patient’s satisfaction was more from operation in supine position (89.7 %in supine and 61.4 in prone position (P=0.018).<br /> There was no significant differences between the supine and prone position in complications (p=0.3). Considering efficacy and success of operation in supine and prone position it was 69% and 58.4% respectively (p=0.195).<br /> Conclusion: PCNL in supine position is a safe procedure and with similar performance compared to standard prone position for treatment of urolithiasis and patient 'satisfaction is more from this position although more studies with larger sample size are necessary<br /> Key word: percutaneous nephrolithotomy‚position‚efficacy‚complications<br />",
  "results_date_posted": null,
  "results_date_first_publication": null,
  "results_url_protocol": null,
  "ipd_plan": null,
  "ipd_description": null,
  "results_date_completed": null,
  "results_yes_no": "Yes",
  "db_name": "irct",
  "design_string": "Randomization: Randomized, Blinding: Single blinded, Placebo: Not used, Assignment: Parallel, Purpose: Treatment.",
  "phase_string": "N/A",
  "country_list": [
    "Iran (Islamic Republic of)"
  ],
  "secondary_ids": [],
  "study_features": [
    {
      "ftype_id": 21,
      "ftype": "Primary purpose",
      "fvalue_id": 400,
      "fvalue": "Treatment"
    },
    {
      "ftype_id": 22,
      "ftype": "Allocation type",
      "fvalue_id": 205,
      "fvalue": "Randomised"
    },
    {
      "ftype_id": 23,
      "ftype": "Intervention model",
      "fvalue_id": 305,
      "fvalue": "Parallel assignment"
    },
    {
      "ftype_id": 24,
      "ftype": "Masking",
      "fvalue_id": 505,
      "fvalue": "Single"
    }
  ],
  "condition_list": [
    {
      "condition": "Renal and ureteral stones",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Calculus of kidney with calculus of ureter",
      "code": null,
      "code_system": null
    }
  ]
}
 */
				return fs;

			}

			if (sd_sid == "")
			{
				FullStudy fs = CreateEmptyFullStudy();

				// Study 
/*
 *
  "source_id": 100125,
  "record_date": "2021-08-30",
  "sd_sid": "IRCT20210521051357N1",
  "public_title": "The effect of combined exercises with the approach of extreme readiness and coffee consumption on liver enzymes and motor function of middle-aged men with non-alcoholic fatty liver",
  "scientific_title": "The effect of eight weeks of independent combined training with coffee consumption on blood lipid profile of middle-aged men with non-alcoholic fatty liver in Covid-19 condition",
  "remote_url": "http://en.irct.ir/trial/56894",
  "public_contact_givenname": "Alireza Taheri Dilatabadi",
  "public_contact_familyname": null,
  "public_contact_email": "Talireza099@gmail.com",
  "public_contact_affiliation": "Shahed University",
  "scientific_contact_givenname": "Nahid Talebi",
  "scientific_contact_familyname": null,
  "scientific_contact_email": "talebi@shahed.ac.ir",
  "scientific_contact_affiliation": "Shahed University",
  "study_type": "Interventional",
  "date_registration": "2021-07-22",
  "date_enrolment": "2021-06-16",
  "target_size": "50",
  "study_status": "Completed",
  "primary_sponsor": "Shahed University",
  "secondary_sponsors": null,
  "source_support": "Shahed University",
  "interventions": "Intervention 1: Intervention group: Intervention group 1: Combined exercise, training intervention will be done 3 sessions per week for 60 minutes. Each session consists of 3 parts of practice, 5 parts. Start the training program by warming up for 10 to 15 minutes. Then the training sections are performed as follows three times without rest: 1- Balance movement for 15 to 20 seconds 2- Aerobic movement for 20 to 30 seconds and with an intensity of 55 to 65% of the maximum heart rate. Pilates largely avoids high impact, high power output, and heavy muscular and skeletal loading. Pilates largely avoids high impact, high power output, and heavy muscular and skeletal loading. Pilates largely avoids high impact, high power output, and heavy muscular and skeletal loading. Becomes.Subjects rest for 1 to 2 minutes before the start of the next part. Subsequent parts will be performed according to the same procedure and with various movements on other parts of the body. After finishing 3 parts, cooling is done for 5 minutes. Intervention 2: Intervention group: Intervention group 2 combined exercises with coffee consumption, combined exercise intervention 3 sessions per week for 60 minutes. Each session consists of 3 parts of practice, 5 parts. Start the training program by warming up for 10 to 15 minutes. Then the training sections are performed in the following way three times without rest: 1- Balance movement for 15 to 20 seconds 2- Aerobic movement for 20 to 30 seconds and with an intensity of 55 to 65% of the maximum heart rate. Pilates largely avoids high impact, high power output, and heavy muscular and skeletal loading. Pilates largely avoids high impact, high power output, and heavy muscular and skeletal loading. Pilates largely avoids high impact, high power output, and h",
  "agemin": "30",
  "agemin_units": "Years",
  "agemax": "60",
  "agemax_units": "Years",
  "gender": "Male",
  "inclusion_criteria": "Middle-aged men 30 to 60 years\nGrade 1, 2 and 3 liver disease\nPeople with high blood lipid profiles\nPeople without cardiovascular disease\nPeople without physical disabilities",
  "exclusion_criteria": "Men over 60 years old\nPeople with fatty liver disease grade 4\nPeople with physical disabilities\nPeople with heart failure\nPeople with lung disease",
  "primary_outcome": "Serum levels of hepatic alanine transaminase and aspartate transaminase enzymes. Timepoint: Measurement three days before the start of the study intervention. Method of measurement: Blood test to determine the serum levels of alanine transaminase and aspartate transaminase liver enzymes is performed by BT 2500 analyzer and 3000 rpm centrifuge for 5 minutes with Behdad device made in Iran and standard kits of Par Azmoon company.;Liver grade. Timepoint: Measurement three days before the start of the study intervention. Method of measurement: Liver grade with ultrasound device from Samsung Korea WS80A model.;Blood lipid profile. Timepoint: Measurement three days before the start of the study intervention. Method of measurement: Blood test to determine the amount of blood lipid profile is measured by BT 2500 analyzer and 3000 rpm centrifuge in 5 minutes with Behdad device made in Iran and standard kits of Par Azmoon company.;Motor function. Timepoint: Measurement three days before the start of the study intervention. Method of measurement: Motor function is performed by fitness tests (sit-ups, steps, stork balance, quadratic agility, and Welsh flexibility).",
  "secondary_outcomes": "Decreased hepatic alanine transaminase and aspartate transaminase enzymes. Timepoint: Measurement three days after the end of the study. Method of measurement: Blood test is done to determine the serum levels of the liver enzymes alanine transaminase and aspartate transaminase.;Decreased liver grade. Timepoint: Measurement three days after the end of the study. Method of measurement: Liver grade with ultrasound device from Samsung Korea WS80A model.;Decreased blood lipid profile. Timepoint: Measurement three days after the end of the study. Method of measurement: Blood sample to determine the amount of blood lipid profile by BT 2500 analyzer and 3000 rpm centrifuge in 5 minutes with Behdad machine made in Iran and standard kits of Pars Azmoon company.;Increase motor performance. Timepoint: Measurement three days after the end of the study. Method of measurement: Motor function is performed by physical fitness tests (sitting position, step test, quadratic agility, stork balance and flexibility).",
  "bridging_flag": null,
  "bridged_type": null,
  "childs": null,
  "type_enrolment": "anticipated",
  "retrospective_flag": "1",
  "results_actual_enrollment": null,
  "results_url_link": null,
  "results_summary": null,
  "results_date_posted": null,
  "results_date_first_publication": null,
  "results_url_protocol": null,
  "ipd_plan": "Yes - There is a plan to make this available",
  "ipd_description": "What will be shared: Information on the main outcomes studied Possibility of subscription Has a transition.  When: The data are available after the publication of all the results obtained Will take Community Verified icon  To whom: Only for researchers working in academic and scientific institutions  Conditions: The study or proposal protocol should be submitted by the Ethics Committee of the institution or university To be approved. The rights of authors and their sponsors must be protected Be  Where to obtain: Talireza099@gmail.com or alireza.taheri@shahed.ac.ir  How to obtain: This request must be addressed to the Vice Chancellor for Research and Technology of Shahed University of Tehran and will be done with the information of the project manager  Comments:",
  "results_date_completed": null,
  "results_yes_no": null,
  "db_name": "irct",
  "design_string": "Randomization: Randomized, Blinding: Not blinded, Placebo: Not used, Assignment: Factorial, Purpose: Supportive, Randomization description: Describe how to randomizeRandom assignment to intervention and control groupsIn this study, we used the restricted randomization method for all study groups with sample size.We will use the same type of random allocation rule. This method represents a large block for the total sample size, which means that the balance in the number of people assigned to each group will be achieved at the end of the study. For this purpose, the sample size (44 people) will be determined first. Then we randomly assign their set to groups A, B and C to the intervention groups (11 people in each group). And group D is for control (11 people). 11 balls (or lottery cards) for each group And we consider a total of 44 numbers.We throw the balls (sheets) into a container and then randomly, the balls (sheets) are taken out of the container without replacement, and t",
  "phase_string": "N/A",
  "country_list": [
    "Iran (Islamic Republic of)"
  ],
  "secondary_ids": [],
  "study_features": [
    {
      "ftype_id": 21,
      "ftype": "Primary purpose",
      "fvalue_id": 415,
      "fvalue": "Supportive care"
    },
    {
      "ftype_id": 22,
      "ftype": "Allocation type",
      "fvalue_id": 205,
      "fvalue": "Randomised"
    },
    {
      "ftype_id": 23,
      "ftype": "Intervention model",
      "fvalue_id": 315,
      "fvalue": "Factorial assignment"
    },
    {
      "ftype_id": 24,
      "ftype": "Masking",
      "fvalue_id": 500,
      "fvalue": "None (Open Label)"
    }
  ],
  "condition_list": [
    {
      "condition": "Non-alcoholic fatty liver disease",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Fatty (change of) liver, not elsewhere classified",
      "code": null,
      "code_system": null
    },
    {
      "condition": "K76.0",
      "code": null,
      "code_system": null
    }
  ]
}
 * 
 */
				return fs;
			}

			return null;
		}
	}
}
