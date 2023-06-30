using System.Text;

namespace MDR_Tester;

public class TestData_100130 : TestData_Base
{ 
	public override FullStudy? FetchStudyData(string sd_sid)
	{
		{
			if (sd_sid == "")
			{
				FullStudy fs = CreateEmptyFullStudy();

				// Study 
				/*
				 * *
				 * "source_id": 100130,
  "record_date": "2023-05-29",
  "sd_sid": "SLCTR-2008-006",
  "public_title": "Study of Abetimus Sodium in Lupus Patients With History of Renal Disease",
  "scientific_title": "A randomized, double blind, placebo-controlled, three arm, parallel group, multicenter, multinational safety and efficacy trial of 300 mg and 900 mg of abetimus sodium in systemic lupus erythematosus (SLE) patients with a history of renal disease",
  "remote_url": "https://slctr.lk/trials/slctr-2008-006",
  "public_contact_givenname": "Dr Priyadarshani Galappatthy",
  "public_contact_familyname": null,
  "public_contact_email": "priyadarshani1232000@yahoo.com",
  "public_contact_affiliation": "Senior Lecturer and Specialist Physician",
  "scientific_contact_givenname": "Dr Priyadarshani Galappatthy",
  "scientific_contact_familyname": null,
  "scientific_contact_email": "priyadarshani1232000@yahoo.com",
  "scientific_contact_affiliation": "Senior Lecturer and Specialist Physician",
  "study_type": "Interventional",
  "date_registration": "2008-03-28",
  "date_enrolment": "2008-04-07",
  "target_size": "740",
  "study_status": "Terminated",
  "primary_sponsor": "La Jolla Pharmaceutical Company",
  "secondary_sponsors": null,
  "source_support": "La Jolla Pharmaceutical Company, San Diego, California, USA",
  "interventions": "Weekly intravenous administration of 300 or 900 mg abetimus sodium or placebo for 52 weeks in patients with a history of SLE renal disease",
  "agemin": null,
  "agemin_units": null,
  "agemax": null,
  "agemax_units": null,
  "gender": "Not provided",
  "inclusion_criteria": "Males or females between 12 and 70 years old, inclusive Female patients must be non-pregnant and non-lactating and have a negative urine pregnancy test result prior to enrollment in the study. Female patients of childbearing potential (including peri menopausal women who have had a menstrual period within 1 year) must be using appropriate birth control (defined as a method which results in a low failure rate of less than 1% per year, when used consistently and correctly, for example oral contraceptives, contraceptive patch, implants, injectables, some intrauterine contraceptive devices [IUDs], or sexual abstinence) during the entire duration of the study. Males enrolled in the trial must have no plans to father a child during the course of the trial and agree to use adequate birth control methods Diagnosis of SLE for purposes of this trial utilize the 1996 Revised Criteria for the Classification of SLE as defined by the American College of Rheumatology (ACR) where a diagnosis of SLE is established when = 4 of the 11 criteria are met 1. At least one documented episode of active SLE renal disease within 4 years prior to randomization at study Visit 3 2. Elevated anti-dsDNA antibody concentration at pre-screening Visit 0 (= 10 IU/mL) as measured by the Farr assay at the regional central laboratory 3. Ability to communicate meaningfully with the investigational staff, competence to give written informed consent, and ability to comply with the entire study procedure 4. Duly executed, written, informed consent obtained from the patient, next of kin, or other legal representative",
  "exclusion_criteria": "Active SLE renal disease in the 3 months prior to Visit 3 An increase in the anti-ds DNA antibody concentration of more than 50% with an incremental increase of at least 50 units in anti-dsDNA antibody concentration by Farr assay between the samples taken at Visit 0 and Visit 1 during the screening period Use of the following therapeutics: Prednisone > 20 mg/day within 1 month prior to Visit 1 ,Any use of the following within 2 months prior to randomization or 1 month prior to Visit 1: alkylating agents (e.g., cyclophosphamide) TNF inhibitors (e.g., etanercept, infliximab) cyclosporine plasmapheresis intravenous immunoglobulin,prosorba column Any use of mycophenolate mofetil that exceeds 1000 mg/day, azathioprine that exceeds100 mg/day, methotrexate that exceeds 10 mg/week , leflunomide that exceeds 10 mg/day , rituximab within 5 months Previous or concurrent medications and other therapies or devices that in the judgement of the Investigator are likely to confound the evaluation of the safety or efficacy of abetimus sodium Patient has received any investigational new drug ordevice within 30 days prior to screening or 5 half-lives of the agent (whichever is longer), or any investigational new drug with a long-term effect Prior participation in study LJP 394-90-14 Exclusionary laboratory values: leukocyte count < 2,000 cells/mm3 , platelet count < 50,000 cells/mm3, hemoglobin < 8.5 gm/dL , serum hepatic transaminases = 3X the upper limit of normal, serum creatinine > 3.5 mg/dL within the 2 months prior to randomization Malignant disease or immunodeficiency syndrome within 5 years, excepting patients with basal cell or squamous cell carcinoma of the skin with complete excision and clean borders Evidence of current abuse of drugs or alcohol History of poor procedural compliance in previous investigational studies History of serious cardiac disease or functional classification New York Heart Association Class III or IV Patient has previously undergone organ transplantation 10 Other medical conditions, including but not limited to diabetic nephropathy, uncontrolled hypertension, history of patient being HIV positive, that are considered by the Investigator to preclude adequate evaluation of drug safety or efficacy. 11 Patient has known hypersensitivity to the class of medications under study or any of the constituents of abetimus sodium. 12 Patients who have any other acute or chronic disease which in the opinion of the Investigator that may influence the outcome of the study may also be excluded",
  "primary_outcome": "The primary objective of this trial is to determine whether abetimus sodium is more effective than place in delaying the time to renal flare in SLE patients with a history of SLE renal disease. The safety and efficacy of abetimus sodium in SLE patients will be evaluated at weekly doses of 300 and 900 mg over than intended 52-week exposure period []\n",
  "secondary_outcomes": "The secondary objectives of the trial are to determine whether treatment with abetimus sodium is more effective than placebo in reducing proteinuria and in delaying time to all major SLE flares []\n",
  "bridging_flag": null,
  "bridged_type": null,
  "childs": null,
  "type_enrolment": "Anticipated",
  "retrospective_flag": null,
  "results_actual_enrollment": "2008-05-06",
  "results_url_link": null,
  "results_summary": null,
  "results_date_posted": null,
  "results_date_first_publication": null,
  "results_url_protocol": null,
  "ipd_plan": null,
  "ipd_description": null,
  "results_date_completed": null,
  "results_yes_no": null,
  "db_name": "slctr",
  "design_string": "Randomized controlled trial",
  "phase_string": "Not Available",
  "country_list": [
    "Argentina,Belarus,Brazil,Czech Republic,Georgia,Germany,Hong Kong,Hungary,India,Indonesia,Korea, Democratic People's Republic of,Malaysia,Mexico,Philippines,Poland,Singapore,Slovakia,Taiwan, Province of China"
  ],
  "secondary_ids": [],
  "study_features": [
    {
      "ftype_id": 22,
      "ftype": "Allocation type",
      "fvalue_id": 205,
      "fvalue": "Randomised"
    },
    {
      "ftype_id": 20,
      "ftype": "Phase",
      "fvalue_id": 1500,
      "fvalue": "Not Available"
    }
  ],
  "condition_list": [
    {
      "condition": "Systemic Lupus Erythematosus",
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
				 *   "source_id": 100130,
  "record_date": "2023-05-29",
  "sd_sid": "SLCTR-2021-023",
  "public_title": "Comparison of efficacy and safety outcomes in mother and neonate following, sending home versus keeping in the hospital after induction of labour with Foley catheter",
  "scientific_title": "Sending home versus staying in the hospital for induction of labour using a Foley catheter at term: a non-inferiority randomised controlled trial (HOME Trial)",
  "remote_url": "https://slctr.lk/trials/slctr-2021-023",
  "public_contact_givenname": "Malitha Patabendige",
  "public_contact_familyname": null,
  "public_contact_email": "mpatabendige@gmail.com",
  "public_contact_affiliation": "Consultant Obstetrician and Gynaecologist",
  "scientific_contact_givenname": "Malitha Patabendige",
  "scientific_contact_familyname": null,
  "scientific_contact_email": "mpatabendige@gmail.com",
  "scientific_contact_affiliation": "Consultant Obstetrician and Gynaecologist",
  "study_type": "Interventional",
  "date_registration": "2021-08-04",
  "date_enrolment": "2021-09-06",
  "target_size": "1096 [548 for each arm]",
  "study_status": "Not yet recruiting",
  "primary_sponsor": "Dr. Malitha Patabendige",
  "secondary_sponsors": null,
  "source_support": "Department of Obstetrics and Gynaecology, Faculty of Medicine, Nursing and Health Sciences, Monash University, Clayton, Victoria, Australia",
  "interventions": "Study settings: <br>Six Teaching Hospitals in Sri Lanka- Teaching Hospital, Mahamodara, Galle, North Colombo Teaching Hospital, Teaching Hospital, Anuradhapura, Teaching Hospital, Batticaloa, Castle Street Hospital for Women, Colombo and De Soysa Hospital for Women, Colombo.<br><br>Randomization<br><br>a. Method of randomization into study arms - Variable block randomisation <br>b. Unit of randomization- Each eligible woman for induction of labour.<br>c. Method of sequence generation- Randomisation sequence will be prepared by an independent <br>statistician and maintained centrally by the central coordinating center (central telephone randomisation by the research nurse/doctor from De Soysa Hospital for Women, Colombo).  Allocation ratio - 1:1.<br>d. Method of allocation concealment- Central telephone randomisation. <br><br>Intervention<br><br>Eligible women will be identified at their last antenatal clinic visit and low-risk women at 40 weeks +3 days of gestation and/or any other low-risk women requiring induction of labour after 37 weeks of gestation will be admitted to the hospital. After admission, patient information sheets will be provided and informed written consent will be taken from all eligible women.<br><br>Thereafter, a vaginal examination will take place. For women who have a Bishop score <6, a sterile vaginal speculum examination will be performed in the dorsal position by a postgraduate resident or a senior medical officer (at least one year experience) and a 16Fr standard latex transcervical Foley catheter will be inserted under aseptic conditions after cleaning with povidone-iodine. The catheter will be inflated with 60mL sterile water. The urinary channel of the Foley catheter will be closed off with a sterile cap. The catheter will be taped into the inner aspect of the thigh to allow her to mo",
  "agemin": null,
  "agemin_units": null,
  "agemax": null,
  "agemax_units": null,
  "gender": "Not provided",
  "inclusion_criteria": "•Women with live singleton pregnancies with a cephalic presentation \n•Women with >37 weeks +0 days  to 42 weeks +0 days  gestation,  with intact membranes requiring IOL\n•Women living within 20km or less (40-minute drive or less) from the hospital, having a telephone, and someone to provide transport to the hospital in an emergency\n",
  "exclusion_criteria": "•Women with high-risk pregnancies (heart disease, hypertension, hyper-glycaemia on metformin or insulin therapy, fetal growth restriction)\n•Less than 18 years of age\n•Major congenital anomaly as per routine anomaly scan\n•Previous caesarean delivery\n•Modified Bishop Score (MBS) > 6\n•Evidence of regular uterine contractions\n•Known hypersensitivity for any of the products for induction/ latex\n•Any contraindications to vaginal birth, i.e. Placenta praevia\n•Evidence of any vaginal or cervical infection\n",
  "primary_outcome": "Vaginal delivery rate\n\n [At the time of hospital discharge]\n Perinatal morbidity and mortality parameters (composite measure) \na.Stillbirth\nb.Admission to neonatal intensive care unit (NICU- for any period)\nc.Birth trauma (mechanical causes during childbirth) \nd.Intrapartum death\ne.Neonatal mortality\nf.Neonatal seizures\ng.Confirmed neonatal infection needing antibiotics\nh.Hypoxic-ischaemic encephalopathy (HIE)\ni.Meconium aspiration syndrome (MAS)\nj.Severe neonatal respiratory morbidity (consists of mechanical ventilation, infantile respiratory distress syndrome (RDS) and pneumothorax)\n [ At the time of hospital discharge]\n",
  "secondary_outcomes": "Admission to intensive care unit (ICU)- for any period [At the time of hospital discharge]\nMaternal infection (temperature = 38 ºC at any time during induction, labour, and delivery/ use of intravenous antibiotics/ clinically suspected/confirmed infection such as chorioamnionitis or postpartum endometritis)\n [48 hours postpartum]\nPostpartum haemorrhage > 1000mLs [ 48 hours postpartum]\nUterine rupture [48 hours postpartum]\nHysterectomy for any complications resulting from birth [ At the time of hospital discharge and six weeks postpartum]\nDamage to internal organs (bladder, bowel, ureters) [48 hours postpartum]\nCardio-respiratory arrest [at the time of hospital discharge upto six weeks postpartum]\nStroke [ at the time of hospital discharge and six weeks postpartum]\nPulmonary embolism [at the time of hospital discharge and six weeks postpartum]\nPostnatal depression [48 hours postpartum]\nMaternal mortality [48 hours postpartum]\nMode of delivery (spontaneous vaginal and operative  delivery and caesarean delivery with indications [48 hours postpartum]\nInduction to delivery interval [48 hours postpartum]\nLength of hospital stay for mother and baby [at the time of hospital discharge]\nWomen’s satisfaction with their respective outpatient or inpatient approach [48 hours postpartum]\nAcceptability of the Foley catheter as an outpatient method to women [ After six weeks of delivery]\nAcceptability of the Foley catheter as an outpatient method to partners [  After six weeks of delivery]\n Healthcare cost for the two methods of induction of labour and their cost-effectiveness [at the time of hospital discharge and six weeks postpartum]\n",
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
  "results_url_protocol": "Version 4,  18 June 2021, Not available",
  "ipd_plan": null,
  "ipd_description": "All the individual participant data after deidentification (including data dictionaries) will be shared along with the study protocol, data collection tools, and analysis plan immediately following publication and there will be no end date. These will be shared for researchers with a methodologically sound proposal and for an individual participant meta-analysis. Data will be available upon a reasonable request from the corresponding author.",
  "results_date_completed": null,
  "results_yes_no": null,
  "db_name": "slctr",
  "design_string": "Randomized controlled trial",
  "phase_string": "Not Applicable",
  "country_list": [
    "Sri Lanka"
  ],
  "secondary_ids": [],
  "study_features": [
    {
      "ftype_id": 22,
      "ftype": "Allocation type",
      "fvalue_id": 205,
      "fvalue": "Randomised"
    }
  ],
  "condition_list": [
    {
      "condition": "Pregnancy",
      "code": null,
      "code_system": null
    }
  ]
				 */

				return fs;
			}

			return null;
		}
	}
}