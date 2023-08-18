using System.Text;

namespace MDR_Tester;

public class TestData_100122 : TestData_Base
{
	public override FullStudy? FetchStudyData(string sd_sid)
	{
		if (sd_sid == "RPCEC00000014")
		{
	        FullStudy fs = CreateEmptyFullStudy();
		        
	        // Study
					
	        string display_title = "h-R3 MAb combined with radio chemotherapy to treat non-surgical esophagus tumors of epithelial origin.";
	        StringBuilder sb = new StringBuilder("Interventions: Patients will be randomly assigned to 2 treatment groups. Group I. Vaccine This group will receive radio chemotherapy + ");
	        sb.Append("TheraCIM h-R3 MAb, under the following scheme: Chemotherapy: - Cisplatin 75 mg/m2, by continuous infusion, 4 cycles on weeks 2, 6, 10 and 14, ");
	        sb.Append("the 2nd day in every week. - 5-Fluorouracyl (5-FU) 750 mg/m2 by continuous infusion, 4 cycles on weeks 2, 6, 10 and 14, on days 2 to 5 every week. ");
	        sb.Append("Radiotherapy: 1.8 to 2.0 Gy daily, on weeks 2, 3, 4, 5 and 6, five days a week, totaling 25 sessions until reaching 45 to 50 Gy. ");
	        sb.Append("TheraCIM h-R3 MAb 200 mg of h-R3 MAb by intravenous route (antecubital vein), in 250ml volume (completed with saline solution) in rapid infusion (30 minutes), ");
	        sb.Append("6 administrations, on weeks 1, 2, 3, 4, 5 and 6, the 1st day every week. Group II. Control This group will be on radio chemotherapy, just as the previous group.;");
	        sb.Append("Antibodies, Monoclonal, Humanized;Radiotherapy;Drug Therapy, Combination;Cisplatin;Fluorouracil;Antibodies, Monoclonal;Infusions, ");
	        sb.Append("Intravenous;Administration, Intravenous;TheraCIM hR3");
	        sb.Append("\nPrimary outcome(s): Objective antitumoral response, life expectancy over six months. Measuring time: 4 months.");  
	        sb.Append("\nStudy Design: Allocation: Randomized controlled trial. Masking: Open. Control group: Active. Assignment: Parallel. Purpose: Treatment");
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2005, 12, 11, 21, "68", 900,
	          19, 17, 74, 17, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100122, 
	          "Registro Público Cubano de Ensayos Clínicos", null, "29 Dec 2010", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "IIC RD-EC075", 14, 104276, 
		        "Centro de Inmunología Molecular", "https://ror.org/01gh7yb82", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
	          "From the Registro Público Cubano de Ensayos Clínicos"));
	        fs.titles.Add(new StudyTitle(sd_sid, 
	          "Clinical trial, phase II. Evaluation of the antitumoral effect of monoclonal antibody h-R3 combined with radio chemotherapy to treat non-surgical esophagus tumors of epithelial origin.", 
	          16, "en", 11, false, "From the Registro Público Cubano de Ensayos Clínicos"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Mayra Ramos Suzarte",  
		        "Center of Molecular Immunology(CIM)", 104276, "Centro de Inmunología Molecular", "https://ror.org/01gh7yb82"));	
			
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 104276, "Centro de Inmunología Molecular", "https://ror.org/01gh7yb82"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 24, "Reported as government funded, no further details", null));

	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 301, "seq", "Hdr", 1, "n.01.01", "Patients with non-surgical esophagus tumors of epithelial origin in stages III or IV, located in the following portions of the esophagus:"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 301, "seq", "Hdr", 2, "n.01.02.01", "Cervical esophagus:"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "seq", "1-", 2, "n.01.02.02", "it begins at the lower edge of the cricoid cartilage and ends at the thoracic inlet (suprasternal fossa), 18cm from ICS."));
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 301, "seq", "Hdr", 2, "n.01.02.03", "Intrathoracic esophagus:"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 301, "seq", "Hdr", 3, "n.01.02.04.01", "Upper thoracic portion:"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "seq", "a)", 3, "n.01.02.04.02", "from the thoracic inlet (suprasternal fossa) to the trachea bifurcation, 24cm from ICS."));	 
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 301, "seq", "Hdr", 3, "n.01.02.04.03", "Middle thoracic segment:"));
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "seq", "b)", 3, "n.01.02.04.04", "it is approximately half of the esophagus, between the trachea bifurcation and the esophagus-gastric join, approximately 32 cm from ICS."));
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "seq", "2.", 1, "n.01.03", "Patients without any treatment who are eligible for radio chemotherapy treatment at the time of inclusion."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "seq", "3.", 1, "n.01.04", "Capacity to understand the study and readiness to sign the informed consent document."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 11, 301, "seq", "Hdr", 1, "n.01.05", "Patients with measurable lesions, (in, at least, one dimension:")); 
	        fs.iec.Add(new StudyIEC(sd_sid, 12, 1, "seq", "4.", 1, "n.01.06", "greater diameter) with a diameter greater than or equal to 20mm using conventional techniques (CAT, X rays, US) or greater than or equal to 10mm using helical CAT."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 13, 1, "seq", "5.", 1, "n.01.07", "Age > 18 and < 75 years."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 14, 1, "seq", "6.", 1, "n.01.08", "General health condition ECOG < 2 (Karnosfsky > 60%)."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 15, 1, "seq", "7.", 1, "n.01.09", "Life expectancy over 6 months."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 16, 301, "seq", "Hdr", 1, "n.01.10", "Patients with organs and bone marrow working normally, defined by the following parameters:"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 17, 1, "seq", "8.", 1, "n.01.11", "leucocytes >3,000/ul, hemoglobin >=9 g/L, absolute neutrophil counting >1,500/ul, platelets >100,000/ul, TGP/TGO 60 ml/min/1.73 m2 for patients with creatinine values higher than normal value, as established by the institution."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 18, 1, "seq", "9.", 1, "n.01.12", "Reproductive-age females should have a negative pregnancy test and should use appropriate contraceptive methods such as intrauterine devices, hormonal contraceptives, barrier method or tubal ligation. Males should use contraceptive methods during treatment."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 19, 1, "seq", "10.", 1, "n.01.13", "Patients who had received appropriate treatment for skin carcinoma or in situ uterus cancer can also be included."));	
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "seq", "1.", 1, "e.01.01", "Patients with esophageal tumors in the inferior thoracic portion (distal half of the esophagus, between the tracheal bifurcation and the esophagus-gastric join, approximately 40cm from ICS)."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "seq", "2.", 1, "e.01.02", "Patients on another product under research."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "seq", "3.", 1, "e.01.03", "Patients with allergy history attributed to chemical or biological compounds similar to TheraCIM h-R3 monoclonal antibody or the chemotherapy used in the study."));
	        fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "seq", "4.", 1, "e.01.04", "Patients previously treated with murine monoclonal antibodies (for example, ior egf/r3)."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 24, 302, "seq", "Hdr", 1, "e.01.05", "Patients with uncontrolled intercurrent diseases, including:"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "seq", "5.", 1, "e.01.06", "active infections, symptomatic congestive heart failure, unstable angina pectoris, cardiac arrhythmia, and psychiatric or social diseases restricting compliance with clinical trial requirements."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "seq", "6.", 1, "e.01.07", "Breastfeeding should be interrupted after patients are included in the clinical trial, due to potential and unknown adverse events for infants."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "seq", "7.", 1, "e.01.08", "Patients with previous malignant neoplasias, except patients who received appropriate treatments for skin carcinoma or in situ uterus carcinoma."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "seq", "8.", 1, "e.01.09", "Patients with brain metastasis."));	
	
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Non-surgical malignant esophagus tumors", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Esophageal Neoplasms", null, null, "2B70", "Malignant neoplasms of oesophagus"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Carcinoma", null, null, "2", "Neoplasms"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Biliary Tract Neoplasms", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Gastrointestinal Neoplasms", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Digestive System Neoplasms", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Esophageal Diseases", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Gastrointestinal Diseases", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Digestive System Diseases", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Neoplasms, Glandular and Epithelial", null, null, null, null));
        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // Phase 2
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));  // Treatment
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));  //  Randomised
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));  //  Parallel assignment
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));  //  None (Open Label)
	        
	        fs.countries!.Add(new StudyCountry(sd_sid, 3562981, "Cuba", null));
					
	        // Data Objects
		        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: Cuban registry web page";
	        string ob_title = display_title + " :: Cuban registry web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
	       
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Cuban registry web page", null, ob_title,
	          null, 9, 2010, 23, 13, 100122, "Registro Público Cubano de Ensayos Clínicos",
	          null, "en", 12, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
		        
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100122, "Registro Público Cubano de Ensayos Clínicos", 
	          "https://rpcec.sld.cu/en/trials/RPCEC00000014-En", true, 35, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "29 Dec 2010", 2010, 12, 29, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "26 Jun 2023", 2023, 6, 26, null, null, null, null));
		       
	        fs.data_objects!.Add(sdo);

	        return fs;

		}


		if (sd_sid == "RPCEC00000397")
		{
			FullStudy fs = CreateEmptyFullStudy();

			// Study

			string display_title = "SOBERANA PLUS TURIN";
			StringBuilder sb =
				new StringBuilder("Interventions: SOBERANA Plus ST: 50 µg of d-RBD + adjuvant, 0.5 mL by intramuscular route. Treatment scheme: one dose. ");
			sb.Append("Presentation: Vial with single dose.\nThe vaccine will be applied to two groups of italian patients: \n");
			sb.Append("a) Group of convalescents. \nb) Group of adults vaccinated with another vaccine against COVID-19\n;");
			sb.Append("Immunogenicity, Vaccine ;Immunotherapy, Active;Vaccines ;Injections, Intramuscular ;Single Dose;SOBERANA Plus");
			sb.Append("\nPrimary outcome(s): Serious Adverse Events-SAE (It will measure as: -Occurrence of the SAE (Yes, No), - Duration ");
			sb.Append("(Time from start date until end date of event), -Description of the event, Result (Recovered, Recovered with squeals, ");
			sb.Append("Persists, Death, Unknown), - Causality (Causal association consistent with vaccination, Undetermined, Inconsistent ");
			sb.Append("causal association with vaccination, not classifiable). Measurement time: daily for 28 days after dose.");
			sb.Append("\nStudy Design: Allocation: Non-randomized controlled trial. Masking: Open. Control group: Uncontrolled. Assignment: Parallel. Purpose: Prevention");
			string brief_desc = sb.ToString();
			sb = new StringBuilder("The immunological individual data, and other supporting clinical documents, including study protocol, statistical analysis plan, ");
			sb.Append("and the informed consent form will be available after publication in specialized journals. Proposals should be sent to: ochoa@finlay.edu.cu or: ");
			sb.Append("vicente.verez@finlay.edu.cu. These proposals must be reviewed and approved by the sponsor and investigator. Finally, data access agreement must be signed.");
			string dss = sb.ToString();

			fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2021, 11, 11, 21, "30", 900,
				19, 17, 59, 17, 10);

			fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100122,
				"Registro Público Cubano de Ensayos Clínicos", null, "12 Nov 2021", null));
			fs.identifiers.Add(new StudyIdentifier(sd_sid, "IFV/COR/16", 14, 103167, "Instituto Finlay de Vacunas", "https://ror.org/00kq7a553", null, null));

			fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true,
				"From the Registro Público Cubano de Ensayos Clínicos"));
			string title =
				"Exploratory study of the SOBERANA Plus ST vaccine, to evaluate its reactogenicity and immunogenicity in adults from Italy: ";
			title +=
				"COVID-19 convalescents; and subjects without a history of this disease and previously immunized against SARS-CoV-2. (COVID-19) - SOBERANA PLUS TURIN";
			fs.titles.Add(new StudyTitle(sd_sid, title, 16, "en", 11 , false,
				"From the Registro Público Cubano de Ensayos Clínicos"));

			fs.people!.Add(new StudyPerson(sd_sid, 51, "Rolando Ochoa Azze",  
				"Finlay Vaccine Institute",  103167, "Instituto Finlay de Vacunas", "https://ror.org/00kq7a553"));	
			fs.people.Add(new StudyPerson(sd_sid, 56, "Yanet Climent Ruiz",  
				"Finlay Vaccine Institute", 103167, "Instituto Finlay de Vacunas", "https://ror.org/00kq7a553"));

			fs.organisations!.Add(new StudyOrganisation(sd_sid, 112, 103167, "Instituto Finlay de Vacunas", "https://ror.org/00kq7a553"));
			fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, 
				"Cuban Fund for Science and Innovation (FONCI) from Ministry of Science, Technology and Environment",
				null));
			
			fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "1.", 1, "n.01", "The participant understands and agrees to comply with the study procedures and provides written informed consent."));	       
			fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "2.", 1, "n.02", "Adults, 19 to 59 years of age, at time of consent."));	    
			fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "3.", 1, "n.03", "Subjects with BMI of 18.5 to 34.9 kg/m2."));	    

			fs.iec.Add(new StudyIEC(sd_sid, 4, 302, "seq", "Hdr", 2, "e.01.01", "A) COVID-19 convalescent group:"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "seq", "a)", 2, "e.01.02", "A history of SARS-CoV-2 infection at time of recruitment or medical discharge for COVID-19 during the two months before recruitment;"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 6, 302, "seq", "Hdr", 2, "e.01.03", "History of severe or asymptomatic COVID-19. B) Group of healthy individuals immunized with another vaccine:"));
			fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "seq", "b)", 2, "e.01.04", "History of COVID-19."));	    
			fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr", "2.", 1, "e.02", "Acute illness, febrile, 7 days prior to administration of investigational product or at screening."));	    
			fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "3.", 1, "e.03", "Current use of any prescription of non-steroidal anti-inflammatory drugs (NSAIDs) or antimicrobial medications within 7 days prior to vaccination."));	    
			fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "4.", 1, "e.04", "Any chronic medical disease or condition that, in the opinion of the clinical investigator, precludes study participation (e.g., subjects with respiratory disease (e.g., chronic obstructive pulmonary disease, asthma), diabetes mellitus, thyroid disease, cardiovascular disease (e.g., congestive heart failure, hypertension, and ischemic heart disease), liver and kidney chronic diseases, neurological conditions or bleeding disorder, psychiatric condition, etc.)."));	  
			fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "5.", 1, "e.05", "Any primary or secondary immunodeficiency."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr", "6.", 1, "e.06", "Ongoing malignancy or recent diagnosis of malignancy."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr", "7.", 1, "e.07", "A history of alcohol abuse or other recreational drug use within 30 days before the first vaccine administration, except smoking."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr", "8.", 1, "e.08", "Demonstrated inability to comply with the study procedures (Mental problems or disorders)."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr", "9.", 1, "e.09", "A history of hypersensitivity or severe allergic reaction (e.g., anaphylaxis, generalized urticarial, angioedema,)."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr", "10.", 1, "e.10", "A history of hypersensitivity to some vaccine component."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr", "11.", 1, "e.11", "Participated in another investigational study involving any investigational product within 3 month prior to the day of enrollment."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "cr", "12.", 1, "e.12", "A) COVID-19 convalescent group: a) Subjects vaccinated with any vaccine against SARS-CoV-2. B) Group of healthy individuals previously immunized with another vaccine: Subjects are excluded if they were not vaccinated between 3 and 12 months before recruitment."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "cr", "13.", 1, "e.13", "Received any vaccine within 30 days prior to the day of enrollment."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "cr", "14.", 1, "e.14", "Received systemic immunosuppressant or immune-modifying drugs, including cytostatic drugs and steroids."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "cr", "15.", 1, "e.15", "History of transfusion of blood or blood products in the last 3 months."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "cr", "16.", 1, "e.16", "Difficulties to comply with the schedule of clinical visit or to continue follow up clinical visits."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr", "17.", 1, "e.17", "Splenectomy or splenic dysfunction."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr", "18.", 1, "e.18", "Women of childbearing potential not using safe contraceptive methods during the study"));	   
			fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr", "19.", 1, "e.19", "Pregnancy, puerperium, or breastfeeding."));	   
			fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr", "20.", 1, "e.20", "Any abnormality or permanent body art (e.g., tattoo) that would interfere with the observation of local reactions at the injection site (both deltoid region)."));	  

			fs.conditions!.Add(new StudyCondition(sd_sid, "COVID-19", null, null, "RA01", "COVID-19"));
			fs.conditions.Add(new StudyCondition(sd_sid, "SARS-CoV2", null, null, null, null));
			fs.conditions.Add(new StudyCondition(sd_sid, "Coronavirus Infections", null, null, "RA01", "COVID-19"));
			fs.conditions.Add(new StudyCondition(sd_sid, "SARS Virus", null, null, null, null));
			fs.conditions.Add(new StudyCondition(sd_sid, "Coronaviridae Infections", null, null, null, null));
			fs.conditions.Add(new StudyCondition(sd_sid, "Nidovirales Infections", null, null, null, null));
			fs.conditions.Add(new StudyCondition(sd_sid, "Betacoronavirus", null, null, null, null));
			fs.conditions.Add(new StudyCondition(sd_sid, "Aftercare", null, null, null, null));

			fs.features!.Add(new StudyFeature(sd_sid, 22, 210)); // Nonrandomised
			fs.features.Add(new StudyFeature(sd_sid, 23, 305)); // Parallel assignment
			fs.features.Add(new StudyFeature(sd_sid, 24, 500)); // None (Open Label)

			fs.countries!.Add(new StudyCountry(sd_sid, 3562981, "Cuba", null));

			// Data Objects

			// 1) Trial registry entry

			string sd_oid = sd_sid + " :: 13 :: Cuban registry web page";
			string ob_title = display_title + " :: Cuban registry web page";
			StudyDataObject sdo = CreateEmptyStudyDataObject();

			sdo.data_object = new DataObject(sd_oid, sd_sid, "Cuban registry web page", null, ob_title,
				null, 9, 2021, 23, 13, 100122, "Registro Público Cubano de Ensayos Clínicos",
				null, "en", 12, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));

			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100122, "Registro Público Cubano de Ensayos Clínicos",
				"https://rpcec.sld.cu/en/trials/RPCEC00000397-En", true, 35, null, null, null));
			sdo.object_dates!.Add(
				new ObjectDate(sd_oid, 15, false, "12 Nov 2021", 2021, 11, 12, null, null, null, null));
			sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "26 Jun 2023", 2023, 6, 26, null, null, null, null));

			fs.data_objects!.Add(sdo);

			return fs;
		}

		return null;
	}
}
