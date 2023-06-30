using System.Text;

namespace MDR_Tester;

public class TestData_100119 : TestData_Base
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
 * 
  "source_id": 100119,
  "record_date": "2021-03-22",
  "sd_sid": "KCT0003700",
  "public_title": "Safety and efficacy evaluation of Selumetinib in Neurofibromatosis type 1",
  "scientific_title": "Safety and efficacy of Selumetinib in Korean patients with neurofibromatosis type 1 and plexiform neurofibromas",
  "remote_url": "http://cris.nih.go.kr/cris/en/search/search_result_st01.jsp?seq=19080",
  "public_contact_givenname": "Beom Hee",
  "public_contact_familyname": "Lee",
  "public_contact_email": null,
  "public_contact_affiliation": "Asan Medical Center",
  "scientific_contact_givenname": "Beom Hee",
  "scientific_contact_familyname": "Lee",
  "scientific_contact_email": null,
  "scientific_contact_affiliation": "Asan Medical Center",
  "study_type": "Interventional",
  "date_registration": "2019-04-01",
  "date_enrolment": "2019-05-14",
  "target_size": "90",
  "study_status": "Recruiting",
  "primary_sponsor": "Asan Medical Center",
  "secondary_sponsors": null,
  "source_support": "AstraZeneca Korea",
  "interventions": "Drug : The dose of selumetinib administered will be the maximum tolerated dose (20-25 mg/m2/dose q 12 hrs for patients with age = 3 years and =18 years and 50 mg/dose or 25 mg/m2/dose q 12 hrs for patients with age &gt; 18 years). The total duration of treatment will be 2 years of 26 cycles. A cycle of therapy is considered to be 28 days with no rest periods in between cycles",
  "agemin": "3",
  "agemin_units": "Years",
  "agemax": null,
  "agemax_units": null,
  "gender": "Both",
  "inclusion_criteria": "For inclusion in the study subjects should fulfil the following criteria based on local regulations:\n1. Patients with Neurofibromatosis type I, in whom genetic study was performed for the germline NF1 mutations, and have significant symptoms/comorbidities as well as those with the potential to develop symptoms/comorbidities due to inoperable measurable plexiform neurofibroma (Surgeon’s statement of inoperability should be documented).\n2. Patients must have at least one measurable plexiform neurofibroma, defined as a lesion of at least 3 cm measured in one dimension.\n3. Patients with an absolute neutrophil count =1000/µL, hemoglobin = 9 g/dL, and platelet = 100,000/µL.\n4. Patients must have bilirubin within 1.5 x the upper limit of normal for age, with the exception of Gilbert syndrome, and Alanie aminotranferaase and aspartate aminotranferase within = 1.5 x upper limit of normal.\n5. Renal Function: age-adjusted normal serum creatinine.\n6. Cardiac function: Normal ejection fraction; echocardiogram = 55% (if a range is given then the upper value of the range will be used).\n7. Performance status: Patients = 16 years of age must have a Karnofsky performance level of =70%, and children &lt; 16 years old must have a Lansky performance of =70%\n8. Diagnostic or laboratory studies performed exclusively to determine eligibility for this trial must only be done after obtaining written informed consent from all patients or their legal guardians (if the patient is &lt;19 years old). When appropriate, pediatric patients will be included in all discussions.",
  "exclusion_criteria": "1.Any prior exposure to MEK, RASs, or RAF inhibitors, or any treatment regimen that involves the comparator / combination medications. \n2.Known severe hypersensitivity to selumetinib, comparator or combination medications or any excipient of these medicinal products or history of allergic reactions attributed to compounds of similar chemical or biologic composition to selumetinib or comparator\n3.Have received or are receiving an investigational medicinal product (IMP) or other systemic anticancer treatment within 4 weeks. \n4.Have had recent major surgery within a minimum 4 weeks prior to starting study treatment, with the exception of surgical placement for vascular access. \n5.The last radiation therapy within 4 weeks prior to starting study treatment, or limited field of radiation for palliation within 7 days of the first dose of study treatment.\n6.Evidence of a malignant glioma, malignant peripheral nerve sheath tumor, or other cancer requiring treatment with chemotherapy or radiation therapy.\n7.Any unresolved toxicity = CTCAE (Common Terminology Criteria for Adverse Events) Grade 2 from previous anti-cancer therapy, except for alopecia\n8.Cardiac conditions as follows:\na.Uncontrolled hypertension (BP = 150/95 mmHg despite medical therapy)\nb.Acute coronary syndrome within 6 months prior to starting treatment\nc.Uncontrolled Angina - Canadian Cardiovascular Society grade II-IV despite medical therapy \nd.Symptomatic heart failure NYHA Class II-IV, prior or current cardiomyopathy, or severe valvular heart disease \ne.Prior or current cardiomyopathy including but not limited to the following:\ni.Known hypertrophic cardiomyopathy\nii.Known arrhythmogenic right ventricular cardiomyopathy\nf.Previous moderate or severe impairment of left ventricular systolic function (Left ventricular ejection fraction &lt;45% on echocardiography or equivalent on multiple gated acquisition scan) even if full recovery has occurred.\ng.Severe valvular heart disease\nh.Baseline Left ventricular ejection fraction below the lower limit of normal or &lt;55% measured by echocardiography or institution’s lower limit of normal for multiple gated acquisition scan\ni.Atrial fibrillation with a ventricular rate &gt;100 bpm on electrocardiogram  at rest \nj.QTcF &gt;450ms or other factors that increase the risk of QT prolongation\n9.Laboratory values as listed below (SI units):\na.Absolute Neutrophil Count  &lt;1.5x1000,000,000/L (1500 per mm3)\nb.Platelets &lt;100x1000,000,000/L (100,000 per mm3)\nc.Hemoglobin  =9.0 g/dL\nd.Serum creatinine =1.5 X upper limit of normal (ULN)\ne.Serum bilirubin &gt;1.5 x ULN (Note that this will not apply to patients with confirmed Gilbert’s syndrome (persistent or recurrent hyperbilirubinemia that is predominantly unconjugated in the absence of evidence of hemolysis or hepatic pathology), who may be allowed included in specific studies, at the discretion of the doctor / physician responsible for the treatment.)\nf.Alanine aminotransferase or Aspartate aminotransferase &gt; 2.5 x Upper limit of normal for patients with no liver metastasis. \ng.Alanine aminotransferase or Aspartate aminotransferase &gt; 5 x Upper limit of normal for patients with liver metastasis.\nh.Alanine aminotransferase or Aspartate aminotransferase &gt; 3.5 x Upper limit of normal and &lt; 5 x Upper limit of normal for patients with liver metastasis and Alakaline phosphatase &gt; 6 x Upper limit of normal \n10.Ophthalmological conditions a",
  "primary_outcome": "To evaluate the safety of selumetinib in Korean patients with NF1 and PN and pharmacokinetic analysis",
  "secondary_outcomes": "To determine the effect of selumetinib on the volume reduction of PN using MRI analysis. (The decrease in volume (=20%) of target PN);To assess the operability of PN after administration of selumetinib;To assess quality of life and pain in patients with NF1 and PN after administration of selumitinib;To measure changes in Kinome activity by Kinase array;To measure changes of transcriptome profiles by gene expression array );To measure changes in neurofunctional images );To measure changes in neuropsychiatric function;To describe the correlation of clinical response to selumitinib with germline NF1 genotype",
  "bridging_flag": null,
  "bridged_type": null,
  "childs": null,
  "type_enrolment": "Actual",
  "retrospective_flag": null,
  "results_actual_enrollment": null,
  "results_url_link": null,
  "results_summary": null,
  "results_date_posted": "2019-04-01",
  "results_date_first_publication": null,
  "results_url_protocol": null,
  "ipd_plan": null,
  "ipd_description": null,
  "results_date_completed": null,
  "results_yes_no": null,
  "db_name": "cris",
  "design_string": "Primary Purpose : Treatment, Intervention Model : Single Group, Blinding/Masking : Open, Allocation : Non-RCT",
  "phase_string": "Phase1/Phase2",
  "country_list": [
    "Korea, Republic of"
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
      "fvalue_id": 210,
      "fvalue": "Nonrandomised"
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
      "fvalue_id": 115,
      "fvalue": "Phase 1/Phase 2"
    }
  ],
  "condition_list": [
    {
      "condition": "Neoplasms",
      "code": null,
      "code_system": null
    }
  ]
 */
				return fs;

			}

			if (sd_sid == "")
			{
				FullStudy fs = CreateEmptyFullStudy();

				// Study 
/*
 *
  "source_id": 100119,
  "record_date": "2022-11-28",
  "sd_sid": "KCT0007824",
  "public_title": "A Randomized, Double-Blind, Placebo-Controlled, Parallel, Phase 2a Clinical Trial to Evaluate the Safety and Efficacy of WK0202 Capsule to Prevent Cancer-Related Fatigue on Cytotoxic Chemotherapy",
  "scientific_title": "A Randomized, Double-Blind, Placebo-Controlled, Parallel, Phase 2a Clinical Trial to Evaluate the Safety and Efficacy of WK0202 Capsule to Prevent Cancer-Related Fatigue on Cytotoxic Chemotherapy",
  "remote_url": "https://cris.nih.go.kr/cris/search/detailSearchEn.do?seq=23046",
  "public_contact_givenname": "Hye jeong",
  "public_contact_familyname": "Kim",
  "public_contact_email": "oraios@naver.com",
  "public_contact_affiliation": "The Catholic University of Korea, Seoul St. Mary's Hospital",
  "scientific_contact_givenname": "Myung-Ah",
  "scientific_contact_familyname": "Lee",
  "scientific_contact_email": "angelamd@naver.com",
  "scientific_contact_affiliation": "The Catholic University of Korea, Seoul St. Mary's Hospital",
  "study_type": "Interventional",
  "date_registration": "2022-10-19",
  "date_enrolment": "2022-10-30",
  "target_size": "70",
  "study_status": "Not yet recruiting",
  "primary_sponsor": "The Catholic University of Korea, Seoul St. Mary's Hospital",
  "secondary_sponsors": null,
  "source_support": "Nadianbio",
  "interventions": "Drug : A combination of WK0202 capsules and XELOX or FOLFOX (mFOLFOX6) is administered.<br>Administration cycle: WK0202 capsules are orally administered once a day at a certain period of time (a.m. empty stomach), and each chemotherapy is administered according its administration.<br>Administration plan: WK0202 capsules are administered for 12 weeks, XELOX up to 8 cycles (3 weeks/cycle), FOLFOX (mFOLFOX6) can be administered for up to 12 cycles (2 weeks/cycle).<br><br>Treatment group:<br>Experimental 1 - WK0202 capsule 200mg (2 tablets of WK0202 capsule 100mg) + 1 tablet of placebo 100mg<br>Experimental 2 - WK0202 Capsule 300 mg (WK0202 Capsule 100 mg 3 tablets)<br>Control - 300 mg of placebo (three tablets of placebo 100 mg<br><br><br>",
  "agemin": "19",
  "agemin_units": "Years",
  "agemax": null,
  "agemax_units": null,
  "gender": "Both",
  "inclusion_criteria": "1) A person who voluntarily agrees to participate in this clinical trial\n2) An adult man or woman over the age of 19\n3) A person diagnosed with colorectal cancer by pathology (histology or cytolo\ngy)\n4) Patients requiring treatment with XELOX or FOLFOX (mFOLFOX6) therapy\n5) Those who have an average BFI score of less than 4 points during a screenin\ng visit (except when one of all BFI items has a score of 7 or higher\n6) Those who fall under Eastern Cooperative Oncology Group (ECOG) =1\n7) Person who is able to be measured by Inbody during screening visit\n8) If the person is female participant or female partner of male participant who\nhas not undergone infertility surgery if she is fertile, those who agrees to follo\nwing contraception in the period of clinical trial and after the end of the clinica\nl trial at least 4 months for men and for at least 6 months women\n(1) For both female participant or female partner of male participant: Use of int\nrauterine device/tubal ligation and infertility surgery/condom or diaphragm and\nspermicide or combination use of birth control pill\n(2) For male participant(not applicable for male partner of female participant):\nuse of condom\n(3) Absolute abstinence (Intermittent abstinence (e.g., during ovulation, sympt\nothermal method, or post ovulation) or coitus interruptus are not agreeing to a\nbstinence)\n9) During a screening visit, laboratory test meets the follow criteria:\n(1) ANC = 1,500/mm³\n(2) Platelet count =100,000/mm³\n(3) Hemoglobin = 9.0 g/dL (if hemoglobin level is less than 9.0 g/dl, recover to\n9.0 g/dL or higher; In such cases, participant may be registered at the discretion\nof the investigator. However, blood transfusions within 7 days are not allowed\nbased on the screening time to satisfy this standard.)\n(4) Patients with TSH in normal range (however, participant that was administe\nred thyroid hormone without changing the usage and dose for at least 4 weeks\nprior to screening may be registered at the discretion of the investigator)\n(5) Creatine clearance = 60mL/min or eGFR = 60mL/min/1.73?",
  "exclusion_criteria": "[Current disease and medical history]\n1) A person who is scheduled to undergo radiotherapy during the clinical trial p\neriod\n2) A person who is unable to orally administer drugs or may affect the absorpti\non of drugs for clinical trials\n3) Patients with the following cardiovascular diseases during screening visits\n(1) Myocardial infarction or unstable angina within 6 months prior to screening\nvisit\n(2) Congestion heart failure above class III according to the New York Heart Ass\nociation (NYHA) classification\n(3) QTc interval = 450 msec or clinically significant ECG changes\n4) A person who has undergone major surgery requiring general anesthesia wit\nhin 3 weeks prior to the screening visit\n5) an HIV-positive patient\n6) Patients with positive active hepatitis (HBV, HCV) test results\n7) Patients with acute or severe infections\n8) Patients who have experienced severe adverse reactions to drugs containing\ncomponents of the same family as clinical trial drugs or have a history of allergi\nes\n9) A person who lost more than 5% of weight within 6 months prior to the scr\neening or has a Body Mass Index (BMI) of less than 20 kg/m² within 6 months\nprior to the screening visit and has a weight loss of more than 2%\n[Prohibited drugs]\n10) A person who has taken the following drugs within 4 weeks prior to the screening visit:\n(1) Stimulants (Methylphenidate, Modafinil, etc.)\n(2) Antidepressants (such as Bupropion)\n(3) Herbal medicine or health functional food for fatigue control (such as red gi\nnseng)\n(4) another clinical trial drug\n[Others]\n11) A person with a life expectancy of 6 months or less\n12) Pregnant or lactating women\n13) A person who participated in another clinical trial within 6 months prior to\nthe screening visit\n14) Any other person who was determined by the investigator that is unsuitabl\ne for this clinical trial due to clinically significant medical or psychiatric findings",
  "primary_outcome": "Safety evaluation and laboratory testing",
  "secondary_outcomes": "Questionnaire evaluation and Inbody measurement;Biomarker evaluation (Cachexia-inducing factors, Muscle and Fat wating produ cts, Muscle fatigue and ATP dysregulation, Cytokine dysregulation, Male sex ho rmone, NQO1 genetic polymorphism(only for baseline;Pharmacokinetics",
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
  "db_name": "cris",
  "design_string": "Primary Purpose : Supportive Care, Intervention Model : Parallel, Blinding/Masking : , Blinding Target : Subject, Investigator, Allocation : RCT",
  "phase_string": "Phase2",
  "country_list": [
    "Korea, Republic of"
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
      "fvalue_id": 305,
      "fvalue": "Parallel assignment"
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
      "condition": "Neoplasms",
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