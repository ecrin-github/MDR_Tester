using System.Text;

namespace MDR_Tester;

public class TestData_100128 : TestData_Base
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
  "source_id": 100128,
  "record_date": "2023-05-29",
  "sd_sid": "PACTR201104000284208",
  "public_title": "Study to evaluate immunogenicity of the hepatitis B antigen of the GSK Biologicals¿ candidate malaria vaccine (257049)",
  "scientific_title": "Immunogenicity of the hepatitis B antigen of the GSK Biologicals¿ candidate malaria vaccine (257049)",
  "remote_url": "https://pactr.samrc.ac.za/TrialDisplay.aspx?TrialID=284",
  "public_contact_givenname": "Clinical Disclosure",
  "public_contact_familyname": "Advisor",
  "public_contact_email": "GSKClinicalSupportHD@gsk.com",
  "public_contact_affiliation": "Clinical Disclosure Advisor",
  "scientific_contact_givenname": "Clinical Disclosure",
  "scientific_contact_familyname": "Advisor",
  "scientific_contact_email": "GSKClinicalSupportHD@gsk.com",
  "scientific_contact_affiliation": "Clinical Disclosure Advisor",
  "study_type": "Interventional",
  "date_registration": "2011-03-29",
  "date_enrolment": "2011-04-30",
  "target_size": "705",
  "study_status": null,
  "primary_sponsor": "GlaxoSmithKline Biologicals",
  "secondary_sponsors": null,
  "source_support": "GlaxoSmithKline Biologicals",
  "interventions": "Candidate malaria vaccine lot 1 & co-administred vaccines;Candidate malaria vaccine lot 2 & co-administered vaccines;Candidate malaria vaccine lot 3 & co-administered vaccines;Candidate malaria vaccine lot 1 & co-administered vaccines;Candidate malaria vaccine lot 2 & co-administered vaccines;Candidate malaria vaccine lot 3 & co-administered vaccines;Candidate malaria vaccine lot 1 & co-administered vaccines;Candidate malaria vaccine lot 2 & co-administered vaccines;Candidate malaria vaccine lot 3 & co-administered vaccines;Engerix-B + co-administered vaccines;Engerix-B + co-administered vaccines",
  "agemin": "8",
  "agemin_units": "Weeks",
  "agemax": "12",
  "agemax_units": "Weeks",
  "gender": "Both",
  "inclusion_criteria": "All subjects must satisfy ALL the following criteria at study entry:\n¿A male or female infant aged between 8 and 12 weeks inclusive at the time of first vaccination\n¿Signed or thumb-printed informed consent obtained from the parent(s)/Legally Acceptable Representative [LAR(s)] of the child. Where parent(s)/LAR(s) are illiterate, the consent form will be countersigned by an independent witness\n¿Subjects who the investigator believes that their parent(s)/LAR(s) can and will comply with the requirements of the protocol\n¿Healthy subjects as established by medical history and clinical examination before entering into the study\n¿Born to a mother who is Hepatitis B surface antigen (HBsAg) negative\n¿Born to a mother who is Human Immunodeficiency Virus (HIV) negative\n¿Born after a normal gestation period of 36 to 42 weeks inclusive.\n",
  "exclusion_criteria": "The following criteria should be checked at the time of study entry. If ANY exclusion criterion applies, the subject must not be included in the study:\n¿Child in care\n¿Acute disease and/or fever at the time of enrolment\n¿Serious acute or chronic illness determined by clinical or physical examination and laboratory screening tests\n¿Laboratory screening tests out of range\n¿Previous vaccination with diphtheria, tetanus, pertussis, Haemophilus influenzae type b, Streptococcus pneumoniae, hepatitis B vaccine or rotavirus vaccines.\n¿Planned administration/administration of a licensed vaccine not foreseen by the study protocol within 7 days of the first dose of study vaccine.\n¿Use of a drug or vaccine that is not approved for that indication other than the study vaccines within 30 days preceding the first dose of study vaccine, or planned use during the study period.\n¿Administration of immunoglobulins and/or any blood products in the period between birth and Dose 1 and within the three months preceding planned vaccine administration during the study period.\n¿Chronic administration of immunosuppressants or other immune-modifying drugs in the period between birth and Dose 1.\n¿Concurrently participating in another clinical study at any time during the study period, in which the subject has been or will be exposed to an investigational or a non-investigational product.\n¿Same sex twin\n¿Maternal death\n¿History of allergic reactions or anaphylaxis to previous immunizations.\n¿History of allergic disease or reactions likely to be exacerbated by any component of the vaccine.\n¿Any other findings that the investigator feels would increase the risk of having an adverse outcome from participation in the trial.\n¿Any other findings that the investigator feels would result in data collected being incomplete or of poor quality.\n¿Previous participation in any other malaria vaccine trial.\n",
  "primary_outcome": "Non-inferiority of the immune response to the hepatitis B antigen induced by the candidate malaria vaccine versus a licensed hepatitis B vaccine",
  "secondary_outcomes": "Immune response against the protein D (PD) component of the pneumococcal antigen;Non-inferiority of the immune response to the rotavirus antigen when the rotavirus vaccine is given as part of an EPI regimen with and without the candidate malaria vaccine co-administration;Immune response to the rotavirus antigen of the rotavirus vaccine, when given as part of an EPI regimen with and without the candidate malaria vaccine co-administration;Immune response to hepatitis B antigen of the candidate malaria vaccine or a licensed hepatitis B vaccine;Immune response to the circumsporozoite protein (CS) antigen of the candidate malaria vaccine when given as part of an EPI regimen with and without pneumococcal conjugate vaccine co-administration;Immune response to the CS antigen of the candidate malaria vaccine when given as part of an EPI regimen with and without rotavirus co-administration;Lot-to lot consistency for immunogenicity of three lots of the candidate malaria vaccine;Non-inferiority of the immune response to the acellular B pertussis antigens of the diphtheria, tetanus, pertussis (acellular) and Haemophillus influenza type b (DTPa/Hib) vaccine when given with and without the candidate malaria vaccine co-administration;Immune response to the acellular B pertussis antigens of the DTPa/Hib vaccine when given with the candidate malaria vaccine;Non-inferiority & immune response to the 10 pneumococcal serotype antigens when pneumococcal conjugate vaccine is given as part of an EPI regimen with and without the candidate malaria vaccine co-administration;Non-inferiority & immune response to the 10 pneumococcal serotype antigens when pneumococcal conjugate vaccine is given as part of an EPI regimen with and without the candidate malaria vaccine co-administration;Immune response (on a long-term) to the hepatitis B antigen after a primary course of the candidate malaria vaccine or a licensed hepatitis B vaccine;Immune response to a booster dose of a licensed hepatitis B vaccine;Immune response (on a long-term) to the CS-antigen after a primary course of the candidate malaria vaccine;Immune response to a booster dose of pneumococcal conjugate vaccine when primary vaccination is given as part of an EPI regimen with and without the candidate malaria vaccine co-administration;Occurrence of solicited general and local adverse events (AEs) after vaccination with the candidate malaria vaccine or a licensed hepatitis B vaccine ;Occurrence of unsolicited AEs after vaccination with the candidate malaria vaccine or a licensed hepatitis B vaccine;Occurrence of serious adverse events (SAEs);Occurrence of SAEs;Occurrence of fatal SAEs;Occurrence of immune mediated disorders (IMDs)",
  "bridging_flag": null,
  "bridged_type": null,
  "childs": null,
  "type_enrolment": "Anticipated",
  "retrospective_flag": null,
  "results_actual_enrollment": null,
  "results_url_link": null,
  "results_summary": null,
  "results_date_posted": null,
  "results_date_first_publication": null,
  "results_url_protocol": null,
  "ipd_plan": null,
  "ipd_description": null,
  "results_date_completed": null,
  "results_yes_no": null,
  "db_name": "pactr",
  "design_string": "Parallel: different groups receive different interventions at same time during study,Randomised,Central randomization system on internet, minimization procedure accounting for centre,Central randomization system on internet",
  "phase_string": "Not Applicable",
  "country_list": [
    "Ghana",
    "Burkina Faso"
  ],
  "secondary_ids": [
    {
      "source_field": "secondary ids",
      "sec_id": "113681",
      "processed_id": "113681",
      "sec_id_source": null,
      "sec_id_type_id": null,
      "sec_id_type": null
    }
  ],
  "study_features": [
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
    }
  ],
  "condition_list": [
    {
      "condition": "Malaria",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Paediatrics",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Hepatitis B",
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
  "source_id": 100128,
  "record_date": "2023-05-29",
  "sd_sid": "PACTR202211575727659",
  "public_title": "OPTIMAL DP dosing for malaria preventive treatment in Malawian infants",
  "scientific_title": "A pharmacokinetic randomised interventional study to optimise dihydroartemisinin-piperaquine dosing for malaria preventive treatment in Malawian infants",
  "remote_url": "https://pactr.samrc.ac.za/TrialDisplay.aspx?TrialID=24089",
  "public_contact_givenname": "Clifford",
  "public_contact_familyname": "Banda",
  "public_contact_email": "cgbanda@mlw.mw",
  "public_contact_affiliation": "Site Principal Investigator",
  "scientific_contact_givenname": "Karen",
  "scientific_contact_familyname": "Irma Barnes",
  "scientific_contact_email": "karen.barnes@uct.ac.za",
  "scientific_contact_affiliation": "Overall Principal Investigator",
  "study_type": "Interventional",
  "date_registration": "2022-10-20",
  "date_enrolment": "2022-11-01",
  "target_size": "220",
  "study_status": "Not yet recruiting",
  "primary_sponsor": "Liverpool School of Tropical Medicine",
  "secondary_sponsors": null,
  "source_support": "National Institute for Health Research and the Wellcome through the Wellcome International Training Fellowship Scheme",
  "interventions": "Dihydroartemisinin piperaquine ;DP Placebo Group",
  "agemin": "1",
  "agemin_units": "Months",
  "agemax": "23",
  "agemax_units": "Months",
  "gender": "Both",
  "inclusion_criteria": "Inclusion criteria \n•Infants from 2.5 months (10 weeks) whose parent/guardian has provided informed consent \n•No symptoms of malaria at the time of recruitment\n•Parent or guardian willing to adhere to study procedures including infant follow-up \n",
  "exclusion_criteria": "Exclusion criteria \n•Known allergy or contraindication to any study drugs \n•Known HIV exposure \n•Pre-existing medical history of significant comorbidities that may influence drug exposure, e.g. renal, liver, \n        gastrointestinal or cardiac diseases  \n•Severe anaemia (haemoglobin (Hb) <7 g/dL)\n•Infant (breastfeeding mother) on medications that are known to have clinically significant interactions with \n        DP\n•Participation in another clinical trial \n",
  "primary_outcome": "Age- and body-weight-related changes in pharmacokinetic properties of piperaquine (such as clearance and volume of distribution) in infants receiving IPTi-DP                                                                                                           \nAssociation between the incidence of malaria and pharmacokinetic parameters. This will be achieved by comparing the Incidence of malaria from 2.5 months to 12 months of age, evaluated by comparing 1) DP exposed and unexposed infants and 2) primary pharmacokinetic parameters of piperaquine and the difference in piperaquine clearance (and other pharmacokinetic parameters such as trough concentrations) between infants who develop an episode of malaria and those who do not\nRecommendations for optimised DP dosing regimens for malaria intermittent preventive treatment in infants\nSafety and tolerability of IPTi-DP \n",
  "secondary_outcomes": "Association between piperaquine pharmacokinetic exposure parameters and possible determinants of drug exposure such as nutritional status (weight for age z-score [WAZ], height for age [HAZ], weight for height z-score [WHZ], mid-upper arm circumference [MUAC]) and sex \n",
  "bridging_flag": null,
  "bridged_type": null,
  "childs": null,
  "type_enrolment": "Anticipated",
  "retrospective_flag": null,
  "results_actual_enrollment": null,
  "results_url_link": "https://www.wwarn.org/working-together/sharing-accessing-data/contributing-data#:%7E:text=WWARN%20is%20a%20registered%20repository,Share%20your%20data%20now.",
  "results_summary": null,
  "results_date_posted": null,
  "results_date_first_publication": null,
  "results_url_protocol": null,
  "ipd_plan": null,
  "ipd_description": "To support national and regional policies and meet the data-sharing requirements of funders and peer-reviewed journal publishers, individual, de-identified participant data will be made available for individual patient data meta-analyses as soon as the data analysis is completed, with the understanding that the results of the meta-analysis will not be published prior to the results of the present study without the prior agreement of the lead and co-investigators. No later than 6 months after the publication of the results from this study, a fully anonymised data set will be available for sharing purposes through the WWARN data repository and written permission to access this shared data will be sought from the overall principal- and site principal investigators on the project. The informed consent form will include a statement that seeks consent from the guardian to allow sharing of de-identified data with collaborators and a data-sharing platform.",
  "results_date_completed": null,
  "results_yes_no": null,
  "db_name": "pactr",
  "design_string": "Parallel: different groups receive different interventions at same time during study,Randomised,Simple randomization using a randomization table created by a computer software program,Sealed opaque envelopes",
  "phase_string": "Phase-3",
  "country_list": [
    "Malawi"
  ],
  "secondary_ids": [
    {
      "source_field": "secondary ids",
      "sec_id": "22038",
      "processed_id": "22038",
      "sec_id_source": null,
      "sec_id_type_id": null,
      "sec_id_type": null
    }
  ],
  "study_features": [
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
      "ftype_id": 20,
      "ftype": "Phase",
      "fvalue_id": 130,
      "fvalue": "Phase 3"
    }
  ],
  "condition_list": [
    {
      "condition": "Malaria",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Paediatrics",
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