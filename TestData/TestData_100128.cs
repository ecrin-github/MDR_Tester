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
              sb.Append("\nPrimary outcome(s): Non-inferiority of the immune response to the hepatitis B antigen induced by the candidate ");  
              sb.Append("malaria vaccine versus a licensed hepatitis B vaccine");   
              sb.Append("\nStudy Design: Parallel: different groups receive different interventions at same time during study,Randomised,Central ");
              sb.Append("randomization system on internet, minimization procedure accounting for centre,Central randomization system on internet");          
              string brief_desc = sb.ToString();
              
              fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2011, 4, 11, 0, "705", 900,
                8, 15, 12, 15, 10);

              fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100128, 
                "Pan African Clinical Trial Registry", null, "29 Mar 2011", null));
              fs.identifiers.Add(new StudyIdentifier(sd_sid, "113681", 14, 100163, 
	              "GlaxoSmithKline", "https://ror.org/01xsqw823", null, null));
	              
              fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
                "From the Pan African Clinical Trial Registry"));
              fs.titles.Add(new StudyTitle(sd_sid, 
                "Immunogenicity of the hepatitis B antigen of the GSK Biologicals¿ candidate malaria vaccine (257049)", 
                16, "en", 11, false, "From the Pan African Clinical Trial Registry"));
				
              fs.organisations!.Add(new StudyOrganisation(sd_sid, 112, 100163, "GlaxoSmithKline", "https://ror.org/01xsqw823"));
              
              fs.iec!.Add(new StudyIEC(sd_sid, 1, 301, "cr", "Hdr", 0, "n.00", "All subjects must satisfy ALL the following criteria at study entry:"));	
              fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "¿", 1, "n.01", "A male or female infant aged between 8 and 12 weeks inclusive at the time of first vaccination"));	
              fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "¿", 1, "n.02", "Signed or thumb-printed informed consent obtained from the parent(s)/Legally Acceptable Representative [LAR(s)] of the child. Where parent(s)/LAR(s) are illiterate, the consent form will be countersigned by an independent witness"));	    
              fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr", "¿", 1, "n.03", "Subjects who the investigator believes that their parent(s)/LAR(s) can and will comply with the requirements of the protocol"));	    
              fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr", "¿", 1, "n.04", "Healthy subjects as established by medical history and clinical examination before entering into the study"));	    
              fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr", "¿", 1, "n.05", "Born to a mother who is Hepatitis B surface antigen (HBsAg) negative"));	    
              fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr", "¿", 1, "n.06", "Born to a mother who is Human Immunodeficiency Virus (HIV) negative"));	
              fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr", "¿", 1, "n.07", "Born after a normal gestation period of 36 to 42 weeks inclusive."));	
              
              fs.iec.Add(new StudyIEC(sd_sid, 9, 302, "cr", "Hdr", 0, "e.00", "The following criteria should be checked at the time of study entry. If ANY exclusion criterion applies, the subject must not be included in the study:"));	       
              fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "¿", 1, "e.01", "Child in care"));	    
              fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "¿", 1, "e.02", "Acute disease and/or fever at the time of enrolment"));
              fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr", "¿", 1, "e.03", "Serious acute or chronic illness determined by clinical or physical examination and laboratory screening tests"));	    
              fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr", "¿", 1, "e.04", "Laboratory screening tests out of range"));	    
              fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr", "¿", 1, "e.05", "Previous vaccination with diphtheria, tetanus, pertussis, Haemophilus influenzae type b, Streptococcus pneumoniae, hepatitis B vaccine or rotavirus vaccines."));	    
              fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr", "¿", 1, "e.06", "Planned administration/administration of a licensed vaccine not foreseen by the study protocol within 7 days of the first dose of study vaccine."));	   
              fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr", "¿", 1, "e.07", "Use of a drug or vaccine that is not approved for that indication other than the study vaccines within 30 days preceding the first dose of study vaccine, or planned use during the study period."));	    
              fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr", "¿", 1, "e.08", "Administration of immunoglobulins and/or any blood products in the period between birth and Dose 1 and within the three months preceding planned vaccine administration during the study period."));
              fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "cr", "¿", 1, "e.09", "Chronic administration of immunosuppressants or other immune-modifying drugs in the period between birth and Dose 1."));	    
              fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "cr", "¿", 1, "e.10", "Concurrently participating in another clinical study at any time during the study period, in which the subject has been or will be exposed to an investigational or a non-investigational product."));	    
              fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "cr", "¿", 1, "e.11", "Same sex twin"));	    
              fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "cr", "¿", 1, "e.12", "Maternal death"));	   
              fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "cr", "¿", 1, "e.13", "History of allergic reactions or anaphylaxis to previous immunizations."));	    
              fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr", "¿", 1, "e.14", "History of allergic disease or reactions likely to be exacerbated by any component of the vaccine."));
              fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr", "¿", 1, "e.15", "Any other findings that the investigator feels would increase the risk of having an adverse outcome from participation in the trial."));	    
              fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr", "¿", 1, "e.16", "Any other findings that the investigator feels would result in data collected being incomplete or of poor quality."));	    
              fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr", "¿", 1, "e.17", "Previous participation in any other malaria vaccine trial."));	    
   
            fs.features!.Add(new (sd_sid, 22, 205));  //  Randomised
            fs.features.Add(new (sd_sid, 23, 305));  //  Parallel assignment
            
            fs.conditions!.Add(new StudyCondition(sd_sid, "Malaria", null, null, "B2-1F4", "Malaria"));
            fs.conditions.Add(new StudyCondition(sd_sid, "Paediatrics", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "Hepatitis B", null, null, "B1-1E5", "Viral hepatitis"));
            
            fs.countries!.Add(new StudyCountry(sd_sid, 2300660, "Ghana", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2361809, "Burkina Faso", null));
            
            
            // Data Objects
	            
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: Pan African registry web page";
            string ob_title = display_title + " :: Pan African registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
           
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Pan African registry web page", null, ob_title,
              null, 9, 2011, 23, 13, 100128, "Pan African Clinical Trial Registry",
              null, "en", 12, null, null, 0, true, true);
	            
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100128, "Pan African Clinical Trial Registry", 
              "https://pactr.samrc.ac.za/TrialDisplay.aspx?TrialID=284", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "29 Mar 2011", 2011, 3, 29, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "29 May 2023", 2023, 5, 29, null, null, null, null));
	           
            fs.data_objects!.Add(sdo);

            return fs;
	    }

        
	    if (sd_sid == "PACTR202211575727659")
		{
            FullStudy fs = CreateEmptyFullStudy();
	        
            // Study
				    
            string display_title = "OPTIMAL DP dosing for malaria preventive treatment in Malawian infants";
            StringBuilder sb = new StringBuilder("Interventions: Dihydroartemisinin piperaquine ;DP Placebo Group");
            sb.Append("\nPrimary outcome(s): Age- and body-weight-related changes in pharmacokinetic properties of piperaquine (such ");  
            sb.Append("as clearance and volume of distribution) in infants receiving IPTi-DP \n");   
            sb.Append("Association between the incidence of malaria and pharmacokinetic parameters. This will be achieved by comparing ");  
            sb.Append("the Incidence of malaria from 2.5 months to 12 months of age, evaluated by comparing 1) DP exposed and unexposed infants "); 
            sb.Append("and 2) primary pharmacokinetic parameters of piperaquine and the difference in piperaquine clearance (and other pharmacokinetic ");  
            sb.Append("parameters such as trough concentrations) between infants who develop an episode of malaria and those who do not\n");             
            sb.Append("Recommendations for optimised DP dosing regimens for malaria intermittent preventive treatment in infants\nSafety and tolerability of IPTi-DP");
            sb.Append("\nStudy Design: Parallel: different groups receive different interventions at same time during study,Randomised,");
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
              "Pan African Clinical Trial Registry", null, "20 Oct 2022", null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "22038", 14, 101188, 
	            "Liverpool School of Tropical Medicine", "https://ror.org/03svjbs84", null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
              "From the Pan African Clinical Trial Registry"));
            fs.titles.Add(new StudyTitle(sd_sid, 
              "A pharmacokinetic randomised interventional study to optimise dihydroartemisinin-piperaquine dosing for malaria preventive treatment in Malawian infants", 
              16, "en", 11, false, "From the Pan African Clinical Trial Registry"));
            
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Karen Irma Barnes",  
	            "Overall Principal Investigator", null, "Overall Principal Investigator", null));	
            fs.people.Add(new StudyPerson(sd_sid, 56, "Clifford Banda",  
	            "Site Principal Investigator", null, "Site Principal Investigator", null));
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 101188, "Liverpool School of Tropical Medicine", 
	            "https://ror.org/03svjbs84"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, 
	            "National Institute for Health Research and the Wellcome through the Wellcome International Training Fellowship Scheme", 
	            null));
            
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "•", 1, "n.01", "Infants from 2.5 months (10 weeks) whose parent/guardian has provided informed consent"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "•", 1, "n.02", "No symptoms of malaria at the time of recruitment"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "•", 1, "n.03", "Parent or guardian willing to adhere to study procedures including infant follow-up"));	    
	        
            fs.iec.Add(new StudyIEC(sd_sid, 4, 2, "cr", "•", 1, "e.01", "Known allergy or contraindication to any study drugs"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr", "•", 1, "e.02", "Known HIV exposure"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr", "•", 1, "e.03", "Pre-existing medical history of significant comorbidities that may influence drug exposure, e.g. renal, liver, gastrointestinal or cardiac diseases"));
            fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr", "•", 1, "e.04", "Severe anaemia (haemoglobin (Hb) <7 g/dL)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr", "•", 1, "e.05", "Infant (breastfeeding mother) on medications that are known to have clinically significant interactions with DP"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "•", 1, "e.06", "Participation in another clinical trial"));	    
 
            fs.conditions!.Add(new StudyCondition(sd_sid, "Malaria", null, null, "B2-1F4", "Malaria"));
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
              null, 9, 2022, 23, 13, 100128, "Pan African Clinical Trial Registry",
              null, "en", 12, null, null, 0, true, true);
	            
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100128, "Pan African Clinical Trial Registry", 
              "https://pactr.samrc.ac.za/TrialDisplay.aspx?TrialID=24089", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "20 Oct 2022", 2022, 10, 20, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "29 May 2023", 2023, 5, 29, null, null, null, null));
	           
            fs.data_objects!.Add(sdo);

            return fs;
	    }

		return null;
	}
}
