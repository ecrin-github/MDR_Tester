using System.Text;

namespace MDR_Tester;

public class TestData_100130 : TestData_Base
{ 
	public override FullStudy? FetchStudyData(string sd_sid)
	{
		{
			if (sd_sid == "SLCTR-2008-006")
			{
				FullStudy fs = CreateEmptyFullStudy();
	        
				// Study
				
				string display_title = "Study of Abetimus Sodium in Lupus Patients With History of Renal Disease";
				StringBuilder sb = new StringBuilder("Interventions: Weekly intravenous administration of 300 or 900 mg abetimus sodium or placebo for 52 weeks in patients with a history of SLE renal disease");
				sb.Append("\nPrimary outcome(s): The primary objective of this trial is to determine whether abetimus sodium is more effective than place in ");  
				sb.Append("delaying the time to renal flare in SLE patients with a history of SLE renal disease. The safety and efficacy of abetimus sodium in ");   
				sb.Append("SLE patients will be evaluated at weekly doses of 300 and 900 mg over than intended 52-week exposure period []");  
				sb.Append("\nStudy Design: Randomized controlled trial");
				string brief_desc = sb.ToString();
        
				fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2008, 4, 11, 22, "740", 915,
					null, null, null, null, 9);

				fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100130, 
					"Sri Lanka Clinical Trials Registry", null, "28 Mar 2008", null));
	        
				fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Sri Lanka Clinical Trials Registry"));
				string title = "A randomized, double blind, placebo-controlled, three arm, parallel group, multicenter, multinational safety and efficacy trial of 300 mg ";
				title += "and 900 mg of abetimus sodium in systemic lupus erythematosus (SLE) patients with a history of renal disease";
				fs.titles.Add(new StudyTitle(sd_sid, title, 16, "en", 11, false, "From the Sri Lanka Clinical Trials Registry"));
				
				fs.people!.Add(new StudyPerson(sd_sid, 51, "Priyadarshani Galappatthy", 
					"Senior Lecturer and Specialist Physician", null, "Senior Lecturer and Specialist Physician", null));	
            
				fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "La Jolla Pharmaceutical Company", null));
				fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, 
					"La Jolla Pharmaceutical Company, San Diego, California, USA", null));

				sb = new StringBuilder("Males or females between 12 and 70 years old, inclusive Female patients must be non-pregnant and non-lactating and ");
				sb.Append("have a negative urine pregnancy test result prior to enrollment in the study. Female patients of childbearing ");
				sb.Append("potential (including peri menopausal women who have had a menstrual period within 1 year) must be using appropriate ");
				sb.Append("birth control (defined as a method which results in a low failure rate of less than 1% per year, when used ");
				sb.Append("consistently and correctly, for example oral contraceptives, contraceptive patch, implants, injectables, ");
				sb.Append("some intrauterine contraceptive devices [IUDs], or sexual abstinence) during the entire duration of the study. ");
				sb.Append("Males enrolled in the trial must have no plans to father a child during the course of the trial and agree to ");
				sb.Append("use adequate birth control methods Diagnosis of SLE for purposes of this trial utilize the 1996 Revised Criteria for ");
				sb.Append("the Classification of SLE as defined by the American College of Rheumatology (ACR) where a diagnosis of SLE is established when = 4 of the 11 criteria are met");
				fs.iec!.Add(new StudyIEC(sd_sid, 1, 301, "seq", "Hdr", 1, "n.01.01", sb.ToString()));	       
				fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "seq", "1.", 1, "n.01.02", "At least one documented episode of active SLE renal disease within 4 years prior to randomization at study Visit 3"));	    
				fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "seq", "2.", 1, "n.01.03", "Elevated anti-dsDNA antibody concentration at pre-screening Visit 0 (= 10 IU/mL) as measured by the Farr assay at the regional central laboratory"));	    
				fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "seq", "3.", 1, "n.01.04", "Ability to communicate meaningfully with the investigational staff, competence to give written informed consent, and ability to comply with the entire study procedure"));	    
				fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "seq", "4.", 1, "n.01.05", "Duly executed, written, informed consent obtained from the patient, next of kin, or other legal representative"));
				sb = new StringBuilder("Active SLE renal disease in the 3 months prior to Visit 3 An increase in the anti-ds DNA antibody concentration of more than ");
				sb.Append("50% with an incremental increase of at least 50 units in anti-dsDNA antibody concentration by Farr assay between the ");
				sb.Append("samples taken at Visit 0 and Visit 1 during the screening period Use of the following therapeutics: Prednisone > 20 mg/day ");
				sb.Append("within 1 month prior to Visit 1 ,Any use of the following within 2 months prior to randomization or 1 month prior to Visit 1: ");
				sb.Append("alkylating agents (e.g., cyclophosphamide) TNF inhibitors (e.g., etanercept, infliximab) cyclosporine plasmapheresis ");
				sb.Append("intravenous immunoglobulin,prosorba column Any use of mycophenolate mofetil that exceeds 1000 mg/day, ");
				sb.Append("azathioprine that exceeds100 mg/day, methotrexate that exceeds 10 mg/week , leflunomide that exceeds 10 mg/day , ");
				sb.Append("rituximab within 5 months Previous or concurrent medications and other therapies or devices that ");
				sb.Append("in the judgement of the Investigator are likely to confound the evaluation of the safety or efficacy ");
				sb.Append("of abetimus sodium Patient has received any investigational new drug ordevice within 30 days prior to screening or ");
				sb.Append("5 half-lives of the agent (whichever is longer), or any investigational new drug with a long-term effect ");
				sb.Append("Prior participation in study LJP 394-90-14 Exclusionary laboratory values: leukocyte count < 2,000 cells/mm3 , ");
				sb.Append("platelet count < 50,000 cells/mm3, hemoglobin < 8.5 gm/dL , serum hepatic transaminases = 3X the ");
				sb.Append("upper limit of normal, serum creatinine > 3.5 mg/dL within the 2 months prior to randomization Malignant disease or ");
				sb.Append("immunodeficiency syndrome within 5 years, excepting patients with basal cell or squamous cell carcinoma of ");
				sb.Append("the skin with complete excision and clean borders Evidence of current abuse of drugs or alcohol History of poor procedural compliance ");
				sb.Append("in previous investigational studies History of serious cardiac disease or functional classification New York ");
				sb.Append("Heart Association Class III or IV Patient has previously undergone organ transplantation ");
				sb.Append("10 Other medical conditions, including but not limited to diabetic nephropathy, uncontrolled hypertension, history of patient being HIV positive, ");
				sb.Append("that are considered by the Investigator to preclude adequate evaluation of drug safety or efficacy. 11 Patient has known hypersensitivity to the class of ");
				sb.Append("medications under study or any of the constituents of abetimus sodium. 12 Patients who have any other acute or chronic ");
				sb.Append("disease which in the opinion of the Investigator that may influence the outcome of the study may also be excluded");
				fs.iec.Add(new StudyIEC(sd_sid, 6, 1002, "none", "All", 0, "e.0A", sb.ToString()));	   
				
				fs.features!.Add(new StudyFeature(sd_sid, 20, 1500));  // Not Available
				fs.features.Add(new StudyFeature(sd_sid, 22, 205));  //  Randomised
				
				fs.conditions!.Add(new StudyCondition(sd_sid, "Systemic Lupus Erythematosus", null, null, "4A40", "Lupus erythematosus"));
				
				fs.countries!.Add(new StudyCountry(sd_sid, 3865483, "Argentina", null));
				fs.countries.Add(new StudyCountry(sd_sid, 630336, "Belarus", null));
				fs.countries.Add(new StudyCountry(sd_sid, 3469034, "Brazil", null));
				fs.countries.Add(new StudyCountry(sd_sid, 3077311, "Czechia", null));
				fs.countries.Add(new StudyCountry(sd_sid, 614540, "Georgia", null));
				fs.countries.Add(new StudyCountry(sd_sid, 2921044, "Germany", null));
				fs.countries.Add(new StudyCountry(sd_sid, 1819730, "Hong Kong", null));
				fs.countries.Add(new StudyCountry(sd_sid, 719819, "Hungary", null));
				fs.countries.Add(new StudyCountry(sd_sid, 1269750, "India", null));
				fs.countries.Add(new StudyCountry(sd_sid, 1643084, "Indonesia", null));
				fs.countries.Add(new StudyCountry(sd_sid, 1873107, "North Korea", null));
				fs.countries.Add(new StudyCountry(sd_sid, 1733045, "Malaysia", null));
				fs.countries.Add(new StudyCountry(sd_sid, 3996063, "Mexico", null));
				fs.countries.Add(new StudyCountry(sd_sid, 1694008, "Philippines", null));
				fs.countries.Add(new StudyCountry(sd_sid, 798544, "Poland", null));
				fs.countries.Add(new StudyCountry(sd_sid, 1880251, "Singapore", null));
				fs.countries.Add(new StudyCountry(sd_sid, 3057568, "Slovakia", null));
				fs.countries.Add(new StudyCountry(sd_sid, 1668284, "Taiwan", null));
				
				// Data Objects
	        
				// 1) Trial registry entry

				string sd_oid = sd_sid + " :: 13 :: Sri Lankan registry web page";
				string ob_title = display_title + " :: Sri Lankan registry web page";
				StudyDataObject sdo = CreateEmptyStudyDataObject();
       
				sdo.data_object = new DataObject(sd_oid, sd_sid, "Sri Lankan registry web page", null, ob_title,
					null, 9, 2008, 23, 13, 100130, "Sri Lanka Clinical Trials Registry",
					null, "en", 12, null, null, 0, true, true);
				sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        
				sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100130, "Sri Lanka Clinical Trials Registry", 
					"https://slctr.lk/trials/slctr-2008-006", true, 35, null, null, null));
				sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "28 Mar 2008", 2008, 3, 28, null, null, null, null));
				sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "26 Jun 2023", 2023, 6, 26, null, null, null, null));
	      
				fs.data_objects!.Add(sdo);

				return fs;

			}

			if (sd_sid == "SLCTR-2021-023")
			{
				FullStudy fs = CreateEmptyFullStudy();
	        
				// Study
				
				string display_title = "Comparison of efficacy and safety outcomes in mother and neonate following, sending home versus keeping in the hospital after induction of labour with Foley catheter";
				StringBuilder sb = new StringBuilder("Interventions: Study settings: \nSix Teaching Hospitals in Sri Lanka- Teaching Hospital, Mahamodara, ");
				sb.Append("Galle, North Colombo Teaching Hospital, Teaching Hospital, Anuradhapura, Teaching Hospital, Batticaloa, ");
				sb.Append("Castle Street Hospital for Women, Colombo and De Soysa Hospital for Women, Colombo.\nRandomization\n");
				sb.Append("a. Method of randomization into study arms - Variable block randomisation \nb. Unit of randomization- ");
				sb.Append("Each eligible woman for induction of labour.\nc. Method of sequence generation- Randomisation sequence will be ");
				sb.Append("prepared by an independent \nstatistician and maintained centrally by the central coordinating center (central telephone ");
				sb.Append("randomisation by the research nurse/doctor from De Soysa Hospital for Women, Colombo). Allocation ratio - 1:1.\nd. ");
				sb.Append("Method of allocation concealment- Central telephone randomisation. \nIntervention\nEligible women will be identified ");
				sb.Append("at their last antenatal clinic visit and low-risk women at 40 weeks +3 days of gestation and/or any other low-risk women ");
				sb.Append("requiring induction of labour after 37 weeks of gestation will be admitted to the hospital. After admission, patient information ");
				sb.Append("sheets will be provided and informed written consent will be taken from all eligible women.\nThereafter, a vaginal examination ");
				sb.Append("will take place. For women who have a Bishop score <6, a sterile vaginal speculum examination will be performed in the dorsal position ");
				sb.Append("by a postgraduate resident or a senior medical officer (at least one year experience) and a 16Fr standard latex transcervical Foley ");
				sb.Append("catheter will be inserted under aseptic conditions after cleaning with povidone-iodine. The catheter will be inflated with 60mL sterile water. ");
				sb.Append("The urinary channel of the Foley catheter will be closed off with a sterile cap. The catheter will be taped into the inner aspect of ");
				sb.Append("the thigh to allow her to mo");
				sb.Append("\nPrimary outcome(s): Vaginal delivery rate\n[At the time of hospital discharge]\nPerinatal morbidity and ");  
				sb.Append("mortality parameters (composite measure) \na.Stillbirth\nb.Admission to neonatal intensive care unit (NICU- for any period)");
				sb.Append("\nc.Birth trauma (mechanical causes during childbirth) \nd.Intrapartum death\ne.Neonatal mortality\nf.Neonatal seizures\ng.");
				sb.Append("Confirmed neonatal infection needing antibiotics\nh.Hypoxic-ischaemic encephalopathy (HIE)\ni.Meconium aspiration syndrome ");				
				sb.Append("(MAS)\nj.Severe neonatal respiratory morbidity (consists of mechanical ventilation, infantile respiratory distress syndrome ");   
				sb.Append("(RDS) and pneumothorax)\n[ At the time of hospital discharge]");  
				sb.Append("\nStudy Design: Randomized controlled trial");
				string brief_desc = sb.ToString();
				sb = new StringBuilder("All the individual participant data after deidentification (including data dictionaries) will be shared ");
				sb.Append("along with the study protocol, data collection tools, and analysis plan immediately following publication and there will be no end date. "); 
				sb.Append("These will be shared for researchers with a methodologically sound proposal and for an individual participant meta-analysis. ");
				sb.Append("Data will be available upon a reasonable request from the corresponding author.");  
				string dss = sb.ToString();
				
				fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2021, 9, 11, 16, "1096 [548 for each arm]", 915,
					null, null, null, null, 10);

				fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100130, 
					"Sri Lanka Clinical Trials Registry", null, "4 Aug 2021", null));
	        
				fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
					"From the Sri Lanka Clinical Trials Registry"));
				fs.titles.Add(new StudyTitle(sd_sid, 
					"Sending home versus staying in the hospital for induction of labour using a Foley catheter at term: a non-inferiority randomised controlled trial (HOME Trial)", 
					16, "en", 11, false, "From the Sri Lanka Clinical Trials Registry"));
				
				fs.people!.Add(new StudyPerson(sd_sid, 70, "Malitha Patabendige", 
					"Consultant Obstetrician and Gynaecologist", null, "Consultant Obstetrician and Gynaecologist", null));	
            
				fs.organisations!.Add(new StudyOrganisation(sd_sid, 58, null, 
					"Department of Obstetrics and Gynaecology, Faculty of Medicine, Nursing and Health Sciences, Monash University, Clayton, Victoria, Australia", 
					null));
				
				fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "•", 1, "n.01", "Women with live singleton pregnancies with a cephalic presentation"));	       
				fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "•", 1, "n.02", "Women with >37 weeks +0 days to 42 weeks +0 days gestation, with intact membranes requiring IOL"));	    
				fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "•", 1, "n.03", "Women living within 20km or less (40-minute drive or less) from the hospital, having a telephone, and someone to provide transport to the hospital in an emergency"));	    

				fs.iec.Add(new StudyIEC(sd_sid, 4, 2, "cr", "•", 1, "e.01", "Women with high-risk pregnancies (heart disease, hypertension, hyper-glycaemia on metformin or insulin therapy, fetal growth restriction)"));	       
				fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr", "•", 1, "e.02", "Less than 18 years of age"));	    
				fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr", "•", 1, "e.03", "Major congenital anomaly as per routine anomaly scan"));	 
				fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr", "•", 1, "e.04", "Previous caesarean delivery"));
				fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr", "•", 1, "e.05", "Modified Bishop Score (MBS) > 6"));
				fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "•", 1, "e.06", "Evidence of regular uterine contractions"));	  
				fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "•", 1, "e.07", "Known hypersensitivity for any of the products for induction/ latex"));	
				fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "•", 1, "e.08", "Any contraindications to vaginal birth, i.e. Placenta praevia"));	    
				fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr", "•", 1, "e.09", "Evidence of any vaginal or cervical infection"));	    
				
				fs.features!.Add(new StudyFeature(sd_sid, 22, 205));  //  Randomised
				
				fs.conditions!.Add(new StudyCondition(sd_sid, "Pregnancy", null, null, "XT0S", "Pregnancy"));
				
				fs.countries!.Add(new StudyCountry(sd_sid, 1227603, "Sri Lanka", null));
				 
				// Data Objects
	        
				// 1) Trial registry entry

				string sd_oid = sd_sid + " :: 13 :: Sri Lankan registry web page";
				string ob_title = display_title + " :: Sri Lankan registry web page";
				StudyDataObject sdo = CreateEmptyStudyDataObject();
       
				sdo.data_object = new DataObject(sd_oid, sd_sid, "Sri Lankan registry web page", null, ob_title,
					null, 9, 2021, 23, 13, 100130, "Sri Lanka Clinical Trials Registry",
					null, "en", 12, null, null, 0, true, true);
				sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        
				sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100130, "Sri Lanka Clinical Trials Registry", 
					"https://slctr.lk/trials/slctr-2021-023", true, 35, null, null, null));
				sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "4 Aug 2021", 2021, 8, 4, null, null, null, null));
				sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "26 Jun 2023", 2023, 6, 26, null, null, null, null));
	       
				fs.data_objects!.Add(sdo);

				return fs;
			}

			return null;
		}
	}
}