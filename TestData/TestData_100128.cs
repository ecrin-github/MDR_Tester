using System.Text;

namespace MDR_Tester;

public class TestData_100128 : TestData_Base
{
	public override FullStudy? FetchStudyData(string sd_sid)
	{
		if (sd_sid == "PACTR201104000284208")
		{
              FullStudy fs = CreateEmptyFullStudy();
	              
              // Study
				      
              string display_title = "Study to evaluate immunogenicity of the hepatitis B antigen of the GSK Biologicals¿ candidate malaria vaccine (257049)";
              StringBuilder sb = new StringBuilder("Interventions: Candidate malaria vaccine lot 1 & co-administred vaccines;Candidate malaria vaccine lot 2 ");
              sb.Append("& co-administered vaccines;Candidate malaria vaccine lot 3 & co-administered vaccines;Candidate malaria vaccine ");
              sb.Append("lot 1 & co-administered vaccines;Candidate malaria vaccine lot 2 & co-administered vaccines;Candidate malaria ");
              sb.Append("vaccine lot 3 & co-administered vaccines;Candidate malaria vaccine lot 1 & co-administered vaccines;Candidate malaria ");
              sb.Append("vaccine lot 2 & co-administered vaccines;Candidate malaria vaccine lot 3 & co-administered vaccines;Engerix-B + ");
              sb.Append("co-administered vaccines;Engerix-B + co-administered vaccines");
              sb.Append("Primary outcome(s): Non-inferiority of the immune response to the hepatitis B antigen induced by the candidate ");  
              sb.Append("malaria vaccine versus a licensed hepatitis B vaccine");   
              sb.Append("Study Design: Parallel: different groups receive different interventions at same time during study,Randomised,Central ");
              sb.Append("randomization system on internet, minimization procedure accounting for centre,Central randomization system on internet");          
              string brief_desc = sb.ToString();
              
              fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2011, 4, 11, null, "705", 900,
                8, 15, 12, 15, 10);

              fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100128, 
                "Pan African Clinical Trials Registry", null, "2011 Mar 29", null));
              fs.identifiers.Add(new StudyIdentifier(sd_sid, "113681", 14, 12, 
	              "No organisation name provided in source data", null, null, null));
	              
              fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
                "From the Pan African Clinical Trials Registry"));
              fs.titles.Add(new StudyTitle(sd_sid, 
                "Immunogenicity of the hepatitis B antigen of the GSK Biologicals¿ candidate malaria vaccine (257049)", 
                16, "en", 11, false, "From the Pan African Clinical Trials Registry"));
				
              fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100163, "GlaxoSmithKline", "https://ror.org/01xsqw823"));
              fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 100163, "GlaxoSmithKline", "https://ror.org/01xsqw823"));
              
              
				/*
  
  "inclusion_criteria": 
  "All subjects must satisfy ALL the following criteria at study entry:
  \n¿A male or female infant aged between 8 and 12 weeks inclusive at the time of first vaccination
  \n¿Signed or thumb-printed informed consent obtained from the parent(s)/Legally Acceptable Representative [LAR(s)] of the child. Where parent(s)/LAR(s) are illiterate, the consent form will be countersigned by an independent witness
  \n¿Subjects who the investigator believes that their parent(s)/LAR(s) can and will comply with the requirements of the protocol
  \n¿Healthy subjects as established by medical history and clinical examination before entering into the study
  \n¿Born to a mother who is Hepatitis B surface antigen (HBsAg) negative
  \n¿Born to a mother who is Human Immunodeficiency Virus (HIV) negative
  \n¿Born after a normal gestation period of 36 to 42 weeks inclusive.\n",
  "exclusion_criteria": 
  "The following criteria should be checked at the time of study entry. If ANY exclusion criterion applies, the subject must not be included in the study:
  \n¿Child in care\n¿Acute disease and/or fever at the time of enrolment
  \n¿Serious acute or chronic illness determined by clinical or physical examination and laboratory screening tests
  \n¿Laboratory screening tests out of range\n¿Previous vaccination with diphtheria, tetanus, pertussis, Haemophilus influenzae type b, Streptococcus pneumoniae, hepatitis B vaccine or rotavirus vaccines.
  \n¿Planned administration/administration of a licensed vaccine not foreseen by the study protocol within 7 days of the first dose of study vaccine.
  \n¿Use of a drug or vaccine that is not approved for that indication other than the study vaccines within 30 days preceding the first dose of study vaccine, or planned use during the study period.
  \n¿Administration of immunoglobulins and/or any blood products in the period between birth and Dose 1 and within the three months preceding planned vaccine administration during the study period.
  \n¿Chronic administration of immunosuppressants or other immune-modifying drugs in the period between birth and Dose 1.
  \n¿Concurrently participating in another clinical study at any time during the study period, in which the subject has been or will be exposed to an investigational or a non-investigational product.
  \n¿Same sex twin\n¿Maternal death\n¿History of allergic reactions or anaphylaxis to previous immunizations.
  \n¿History of allergic disease or reactions likely to be exacerbated by any component of the vaccine.
  \n¿Any other findings that the investigator feels would increase the risk of having an adverse outcome from participation in the trial.
  \n¿Any other findings that the investigator feels would result in data collected being incomplete or of poor quality.
  \n¿Previous participation in any other malaria vaccine trial.\n",
  
  ],

				 */
                
            fs.features!.Add(new (sd_sid, 22, 205));  //  Randomised
            fs.features.Add(new (sd_sid, 23, 305));  //  Parallel assignment
            
            fs.conditions!.Add(new StudyCondition(sd_sid, "Malaria", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "Paediatrics", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "Hepatitis B", null, null, null, null));
            
            fs.countries!.Add(new StudyCountry(sd_sid, 2300660, "Ghana", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2361809, "Burkina Faso", null));
            
            
            // Data Objects
	            
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: Pan African registry web page";
            string ob_title = display_title + " :: Pan African registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
           
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Pan African registry web page", null, ob_title,
              null, 9, 2011, 23, 13, 100128, "Pan African Clinical Trials Registry",
              null, "en", 12, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	            
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100128, "Pan African Clinical Trials Registry", 
              "https://pactr.samrc.ac.za/TrialDisplay.aspx?TrialID=284", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2011 Mar 29", 2011, 3, 29, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2023-05-29", 2023, 5, 29, null, null, null, null));
	           
            fs.data_objects!.Add(sdo);

            return fs;
	    }

        
	    if (sd_sid == "PACTR202211575727659")
		{
            FullStudy fs = CreateEmptyFullStudy();
	        
            // Study
				    
            string display_title = "OPTIMAL DP dosing for malaria preventive treatment in Malawian infants";
            StringBuilder sb = new StringBuilder("Interventions: Dihydroartemisinin piperaquine ;DP Placebo Group");
            sb.Append("Primary outcome(s): Age- and body-weight-related changes in pharmacokinetic properties of piperaquine (such ");  
            sb.Append("as clearance and volume of distribution) in infants receiving IPTi-DP\n");   
            sb.Append("Association between the incidence of malaria and pharmacokinetic parameters. This will be achieved by comparing ");  
            sb.Append("the Incidence of malaria from 2.5 months to 12 months of age, evaluated by comparing 1) DP exposed and unexposed infants "); 
            sb.Append("and 2) primary pharmacokinetic parameters of piperaquine and the difference in piperaquine clearance (and other pharmacokinetic ");  
            sb.Append("parameters such as trough concentrations) between infants who develop an episode of malaria and those who do not\n");             
            sb.Append("Recommendations for optimised DP dosing regimens for malaria intermittent preventive treatment in infants\nSafety and tolerability of IPTi-DP");
            sb.Append("Study Design: Parallel: different groups receive different interventions at same time during study,Randomised,");
            sb.Append("Simple randomization using a randomization table created by a computer software program,Sealed opaque envelopes");
            string brief_desc = sb.ToString();
            sb = new StringBuilder("To support national and regional policies and meet the data-sharing requirements of funders ");
            sb.Append("and peer-reviewed journal publishers, individual, de-identified participant data will be made available for individual ");
            sb.Append("patient data meta-analyses as soon as the data analysis is completed, with the understanding that the results of the ");
            sb.Append("meta-analysis will not be published prior to the results of the present study without the prior agreement of the lead ");
            sb.Append("and co-investigators. No later than 6 months after the publication of the results from this study, a fully anonymised ");
            sb.Append("data set will be available for sharing purposes through the WWARN data repository and written permission to access this "); 
            sb.Append("shared data will be sought from the overall principal- and site principal investigators on the project. The informed ");
            sb.Append("consent form will include a statement that seeks consent from the guardian to allow sharing of de-identified data ");  
            sb.Append("with collaborators and a data-sharing platform."); 
            string dss = sb.ToString();
                        
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2022, 11, 11, 16, "220", 900,
              1, 16, 23, 16, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100128, 
              "Pan African Clinical Trials Registry", null, "2022 Oct 20", null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "22038", 14, 12, 
	            "No organisation name provided in source data", null, null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
              "From the Pan African Clinical Trials Registry"));
            fs.titles.Add(new StudyTitle(sd_sid, 
              "A pharmacokinetic randomised interventional study to optimise dihydroartemisinin-piperaquine dosing for malaria preventive treatment in Malawian infants", 
              16, "en", 11, false, "From the Pan African Clinical Trials Registry"));
            
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Karen", "Irma Barnes", "Karen Irma Barnes", null, 
	            "Overall Principal Investigator", null, "Overall Principal Investigator", null));	
            fs.people.Add(new StudyPerson(sd_sid, 56, "Clifford", "Banda", "Clifford Banda", null, 
	            "Site Principal Investigator", null, "Site Principal Investigator", null));
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 101188, "Liverpool School of Tropical Medicine", 
	            "https://ror.org/03svjbs84"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, 
	            "National Institute for Health Research and the Wellcome through the Wellcome International Training Fellowship Scheme", 
	            null));
            
				/*
 
  "inclusion_criteria": 
  \n•Infants from 2.5 months (10 weeks) whose parent/guardian has provided informed consent 
  \n•No symptoms of malaria at the time of recruitment
  \n•Parent or guardian willing to adhere to study procedures including infant follow-up",
  
  "exclusion_criteria": 
  \n•Known allergy or contraindication to any study drugs \n•Known HIV exposure 
  \n•Pre-existing medical history of significant comorbidities that may influence drug exposure, e.g. renal, liver, gastrointestinal or cardiac diseases  
  \n•Severe anaemia (haemoglobin (Hb) <7 g/dL)
  \n•Infant (breastfeeding mother) on medications that are known to have clinically significant interactions with DP
  \n•Participation in another clinical trial \n",
   * 
 */
            fs.conditions!.Add(new StudyCondition(sd_sid, "Malaria", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "Paediatrics", null, null, null, null));
                
            fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // Phase 3
            fs.features.Add(new StudyFeature(sd_sid, 22, 205));  //  Randomised
            fs.features.Add(new StudyFeature(sd_sid, 23, 305));  //  Parallel assignment
				
            fs.countries!.Add(new StudyCountry(sd_sid, 927384, "Malawi", null));
            
            // Data Objects
	            
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: Pan African registry web page";
            string ob_title = display_title + " :: Pan African registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
           
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Pan African registry web page", null, ob_title,
              null, 9, 2022, 23, 13, 100128, "Pan African Clinical Trials Registry",
              null, "en", 12, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	            
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100128, "Pan African Clinical Trials Registry", 
              "https://pactr.samrc.ac.za/TrialDisplay.aspx?TrialID=24089", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2022 Oct 20", 2022, 10, 20, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2023-05-29", 2023, 5, 29, null, null, null, null));
	           
            fs.data_objects!.Add(sdo);

            return fs;
	    }

		return null;
	}
}
