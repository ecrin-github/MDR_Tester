using System.Text;

namespace MDR_Tester;

public class TestData_100122 : TestData_Base
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
  "source_id": 100122,
  "record_date": "2023-05-29",
  "sd_sid": "RPCEC00000014",
  "public_title": "h-R3 MAb combined with radio chemotherapy to treat non-surgical esophagus tumors of epithelial origin.",
  "scientific_title": "Clinical trial, phase II. Evaluation of the antitumoral effect of monoclonal antibody h-R3 combined with radio chemotherapy to treat non-surgical esophagus tumors of epithelial origin.",
  "remote_url": "https://rpcec.sld.cu/en/trials/RPCEC00000014-En",
  "public_contact_givenname": "Mayra",
  "public_contact_familyname": "Ramos Suzarte",
  "public_contact_email": "mayra@cim.sld.cu",
  "public_contact_affiliation": "Center of Molecular Immunology(CIM)",
  "scientific_contact_givenname": "Mayra",
  "scientific_contact_familyname": "Ramos Suzarte",
  "scientific_contact_email": null,
  "scientific_contact_affiliation": "Center of Molecular Immunology(CIM)",
  "study_type": "Interventional",
  "date_registration": "2010-12-29",
  "date_enrolment": "2005-12-14",
  "target_size": "68",
  "study_status": "Completed",
  "primary_sponsor": "Center of Molecular Immunology(CIM)",
  "secondary_sponsors": "Not applicable",
  "source_support": "Government funds",
  "interventions": "Patients will be randomly assigned to 2 treatment groups. Group I. Vaccine This group will receive radio chemotherapy + TheraCIM h-R3 MAb, under the following scheme: Chemotherapy: - Cisplatin 75 mg/m2, by continuous infusion, 4 cycles on weeks 2, 6, 10 and 14, the 2nd day in every week. - 5-Fluorouracyl (5-FU) 750 mg/m2 by continuous infusion, 4 cycles on weeks 2, 6, 10 and 14, on days 2 to 5 every week. Radiotherapy: 1.8 to 2.0 Gy daily, on weeks 2, 3, 4, 5 and 6, five days a week, totaling 25 sessions until reaching 45 to 50 Gy. TheraCIM h-R3 MAb 200 mg of h-R3 MAb by intravenous route (antecubital vein), in 250ml volume (completed with saline solution) in rapid infusion (30 minutes), 6 administrations, on weeks 1, 2, 3, 4, 5 and 6, the 1st day every week. Group II. Control This group will be on radio chemotherapy, just as the previous group.;Antibodies, Monoclonal, Humanized;Radiotherapy;Drug Therapy, Combination;Cisplatin;Fluorouracil;Antibodies, Monoclonal;Infusions, Intravenous;Administration, Intravenous;TheraCIM hR3",
  "agemin": "19",
  "agemin_units": "Years",
  "agemax": "74",
  "agemax_units": "Years",
  "gender": "Both",
  "inclusion_criteria": "1. Patients with non-surgical esophagus tumors of epithelial origin in stages III or IV, located in the following portions of the esophagus: 1- Cervical esophagus: it begins at the lower edge of the cricoid cartilage and ends at the thoracic inlet (suprasternal fossa), 18cm from ICS. 2- Intrathoracic esophagus: a) Upper thoracic portion: from the thoracic inlet (suprasternal fossa) to the trachea bifurcation, 24cm from ICS. b) Middle thoracic segment: it is approximately half of the esophagus, between the trachea bifurcation and the esophagus-gastric join, approximately 32 cm from ICS. 2. Patients without any treatment who are eligible for radio chemotherapy treatment at the time of inclusion. 3. Capacity to understand the study and readiness to sign the informed consent document. 4. Patients with measurable lesions, (in, at least, one dimension: greater diameter) with a diameter greater than or equal to 20mm using conventional techniques (CAT, X rays, US) or greater than or equal to 10mm using helical CAT. 5. Age > 18 and < 75 years. 6. General health condition ECOG < 2 (Karnosfsky > 60%). 7. Life expectancy over 6 months. 8. Patients with organs and bone marrow working normally, defined by the following parameters: leucocytes >3,000/ul, hemoglobin >=9 g/L, absolute neutrophil counting >1,500/ul, platelets >100,000/ul, TGP/TGO 60 ml/min/1.73 m2 for patients with creatinine values higher than normal value, as established by the institution. 9. Reproductive-age females should have a negative pregnancy test and should use appropriate contraceptive methods such as intrauterine devices, hormonal contraceptives, barrier method or tubal ligation. Males should use contraceptive methods during treatment. 10. Patients who had received appropriate treatment for skin carcinoma or in situ uterus cancer can also be included.",
  "exclusion_criteria": "1. Patients with esophageal tumors in the inferior thoracic portion (distal half of the esophagus, between the tracheal bifurcation and the esophagus-gastric join, approximately 40cm from ICS). 2. Patients on another product under research. 3. Patients with allergy history attributed to chemical or biological compounds similar to TheraCIM h-R3 monoclonal antibody or the chemotherapy used in the study. 4. Patients previously treated with murine monoclonal antibodies (for example, ior egf/r3). 5. Patients with uncontrolled intercurrent diseases, including: active infections, symptomatic congestive heart failure, unstable angina pectoris, cardiac arrhythmia, and psychiatric or social diseases restricting compliance with clinical trial requirements. 6. Breastfeeding should be interrupted after patients are included in the clinical trial, due to potential and unknown adverse events for infants. 7. Patients with previous malignant neoplasias, except patients who received appropriate treatments for skin carcinoma or in situ uterus carcinoma. 8. Patients with brain metastasis.",
  "primary_outcome": "Objective antitumoral response, life expectancy over six months. Measuring time: 4 months.",
  "secondary_outcomes": "Quality of life, HAMA response, time of duration of objective antitumoral response. Measuring time: 12 months.",
  "bridging_flag": null,
  "bridged_type": null,
  "childs": null,
  "type_enrolment": "actual",
  "retrospective_flag": "1",
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
  "db_name": "rpcec",
  "design_string": "Allocation: Randomized controlled trial. Masking: Open. Control group: Active. Assignment: Parallel. Purpose: Treatment",
  "phase_string": "2",
  "country_list": [
    "Cuba"
  ],
  "secondary_ids": [
    {
      "source_field": "secondary ids",
      "sec_id": "IIC RD-EC075",
      "processed_id": "IIC RD-EC075",
      "sec_id_source": null,
      "sec_id_type_id": null,
      "sec_id_type": null
    }
  ],
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
      "fvalue_id": 500,
      "fvalue": "None (Open Label)"
    },
    {
      "ftype_id": 20,
      "ftype": "Phase",
      "fvalue_id": 120,
      "fvalue": "Phase 2"
    }
  ],
  "condition_list": [
    {
      "condition": "Non-surgical malignant esophagus tumors",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Esophageal Neoplasms",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Carcinoma",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Gastrointestinal Neoplasms",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Biliary Tract Neoplasms",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Digestive System Neoplasms",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Esophageal Diseases",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Gastrointestinal Diseases",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Digestive System Diseases",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Neoplasms, Glandular and Epithelial",
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
 * 
  "source_id": 100122,
  "record_date": "2023-05-29",
  "sd_sid": "RPCEC00000397",
  "public_title": "SOBERANA PLUS TURIN",
  "scientific_title": "Exploratory study of the SOBERANA Plus ST vaccine, to evaluate its reactogenicity and immunogenicity in adults from Italy: COVID-19 convalescents; and subjects without a history of this disease and previously immunized against SARS-CoV-2. (COVID-19) - SOBERANA PLUS TURIN",
  "remote_url": "https://rpcec.sld.cu/en/trials/RPCEC00000397-En",
  "public_contact_givenname": "Yanet",
  "public_contact_familyname": "Climent Ruiz",
  "public_contact_email": "ycliment@finlay.edu.cu",
  "public_contact_affiliation": "Finlay Vaccine Institute",
  "scientific_contact_givenname": "Rolando",
  "scientific_contact_familyname": "Ochoa Azze",
  "scientific_contact_email": null,
  "scientific_contact_affiliation": "Finlay Vaccine Institute",
  "study_type": "Interventional",
  "date_registration": "2021-11-12",
  "date_enrolment": "2021-11-16",
  "target_size": "Until 30 volunteers by group",
  "study_status": "Completed",
  "primary_sponsor": "Finlay Vaccine Institute (IFV)",
  "secondary_sponsors": "Not applicable",
  "source_support": "Finlay Vaccine Institute; Cuban Fund for Science and Innovation (FONCI) from Ministry of Science, Technology and Environment",
  "interventions": "SOBERANA Plus ST: 50 µg of d-RBD + adjuvant, 0.5 mL by intramuscular route. Treatment scheme: one dose. Presentation: Vial with single dose.<br>The vaccine will be applied to two groups of italian patients: <br>a) Group of convalescents. <br>b) Group of adults vaccinated with another vaccine against COVID-19<br>;Immunogenicity, Vaccine ;Immunotherapy, Active;Vaccines ;Injections, Intramuscular ;Single Dose;SOBERANA Plus",
  "agemin": "19",
  "agemin_units": "Years",
  "agemax": "59",
  "agemax_units": "Years",
  "gender": "Both",
  "inclusion_criteria": "1. The participant understands and agrees to comply with the study procedures and provides written informed consent.\n2. Adults, 19 to 59 years of age, at time of consent.\n3. Subjects with BMI of 18.5 to 34.9 kg/m2.\n",
  "exclusion_criteria": "1. A) COVID-19 convalescent group: a) A history of SARS-CoV-2 infection at time of recruitment or medical discharge for COVID-19 during the two months before recruitment; b) History of severe or asymptomatic COVID-19. B) Group of healthy individuals immunized with another vaccine: History of COVID-19.   \n2. Acute illness, febrile, 7 days prior to administration of investigational product or at screening. \n3. Current use of any prescription of non-steroidal anti-inflammatory drugs (NSAIDs) or antimicrobial medications within 7 days prior to vaccination.\n4. Any chronic medical disease or condition that, in the opinion of the clinical investigator, precludes study participation (e.g., subjects with respiratory disease (e.g., chronic obstructive pulmonary disease, asthma), diabetes mellitus, thyroid disease, cardiovascular disease (e.g., congestive heart failure, hypertension, and ischemic heart disease), liver and kidney chronic diseases, neurological conditions or bleeding disorder, psychiatric condition, etc.).\n5. Any primary or secondary immunodeficiency.\n6. Ongoing malignancy or recent diagnosis of malignancy.\n7. A history of alcohol abuse or other recreational drug use within 30 days before the first vaccine administration, except smoking.\n8. Demonstrated inability to comply with the study procedures (Mental problems or disorders).\n9. A history of hypersensitivity or severe allergic reaction (e.g., anaphylaxis, generalized urticarial, angioedema,). \n10. A history of hypersensitivity to some vaccine component.\n11. Participated in another investigational study involving any investigational product within 3 month prior to the day of enrollment.\n12. A) COVID-19 convalescent group: a) Subjects vaccinated with any vaccine against SARS-CoV-2. B) Group of healthy individuals previously immunized with another vaccine: Subjects are excluded if they were not vaccinated between 3 and 12 months before recruitment.\n13. Received any vaccine within 30 days prior to the day of enrollment.\n14. Received systemic immunosuppressant or immune-modifying drugs, including cytostatic drugs and steroids.\n15. History of transfusion of blood or blood products in the last 3 months.\n16. Difficulties to comply with the schedule of clinical visit or to continue follow up clinical visits.\n17. Splenectomy or splenic dysfunction.\n18. Women of childbearing potential not using safe contraceptive methods during the study\n19. Pregnancy, puerperium, or breastfeeding.\n20. Any abnormality or permanent body art (e.g., tattoo) that would interfere with the observation of local reactions at the injection site (both deltoid region).\n",
  "primary_outcome": "Serious Adverse Events-SAE (It will measure as: -Occurrence of the SAE (Yes, No), - Duration (Time from start date until end date of event), -Description of the event, Result (Recovered, Recovered with squeals, Persists, Death, Unknown), - Causality (Causal association consistent with vaccination, Undetermined, Inconsistent causal association with vaccination, not classifiable). Measurement time: daily for 28 days after dose.",
  "secondary_outcomes": "1) Solicited Local and systemic Adverse Events (AE) (They will measure as: -Occurrence of the AE (Yes, No), Duration (Time from start date until end date of event), -Intensity of the AE (mild, moderate, severe), -Severe (Serious, not serious), -Result (Recovered, Recovered with sequelae, Persists, Death, Unknown), -Causation (causal association consistent with vaccination, Indeterminate, causal association inconsistent with vaccination, not classifiable)). Measurement time: daily for 7 days after dose. \n2) Unsolicited Adverse Events (AE) (They will measure as: Description of the AE (name of the event), Duration (Time from start date until end date of event), -Intensity of the AE (mild, moderate, severe), -Severe (Serious, not serious), -Result (Recovered, Recovered with sequelae, Persists, Death, Unknown), -Causality (causal association consistent with vaccination, Undetermined, causal association inconsistent with vaccination, not classifiable)). Measurement time: daily for 28 days after dose. \n3) Concentration of specific anti-RBD IgG antibodies (Percentage of subjects with seroconversion 4 fold). Measurement time: Prevaccination and day 28 after vaccination.\n4) % ACE2-RBD inhibition and Half-maximal molecular virus neutralization titer (mVNT50). Measurement time: Prevaccination, and day 28 after vaccination. \n5) Viral Neutralization antibody titers against variants of concerns: Measurement time: Prevaccination and day 28 after vaccination.\n",
  "bridging_flag": null,
  "bridged_type": null,
  "childs": null,
  "type_enrolment": "anticipated",
  "retrospective_flag": null,
  "results_actual_enrollment": "30",
  "results_url_link": null,
  "results_summary": null,
  "results_date_posted": "2022-01-31",
  "results_date_first_publication": "2022-03-31",
  "results_url_protocol": null,
  "ipd_plan": null,
  "ipd_description": "The immunological individual data, and other supporting clinical documents, including study protocol, statistical analysis plan, and the informed consent form will be available after publication in specialized journals. Proposals should be sent to: ochoa@finlay.edu.cu or: vicente.verez@finlay.edu.cu. These proposals must be reviewed and approved by the sponsor and investigator. Finally, data access agreement must be signed.",
  "results_date_completed": "2022-01-31",
  "results_yes_no": null,
  "db_name": "rpcec",
  "design_string": "Allocation: Non-randomized controlled trial. Masking: Open. Control group: Uncontrolled. Assignment: Parallel. Purpose: Prevention",
  "phase_string": "N/A",
  "country_list": [
    "Cuba"
  ],
  "secondary_ids": [
    {
      "source_field": "secondary ids",
      "sec_id": "IFV/COR/16",
      "processed_id": "IFV/COR/16",
      "sec_id_source": null,
      "sec_id_type_id": null,
      "sec_id_type": null
    }
  ],
  "study_features": [
    {
      "ftype_id": 22,
      "ftype": "Allocation type",
      "fvalue_id": 210,
      "fvalue": "Nonrandomised"
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
      "fvalue_id": 500,
      "fvalue": "None (Open Label)"
    }
  ],
  "condition_list": [
    {
      "condition": "COVID-19",
      "code": null,
      "code_system": null
    },
    {
      "condition": "SARS-CoV2",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Coronavirus Infections",
      "code": null,
      "code_system": null
    },
    {
      "condition": "SARS Virus",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Coronaviridae Infections",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Nidovirales Infections",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Betacoronavirus",
      "code": null,
      "code_system": null
    },
    {
      "condition": "Aftercare",
      "code": null,
      "code_system": null
    }
  ]
}
 */
				return fs;
			}

			return null;
		}
	}
}