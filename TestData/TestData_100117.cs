using System.Text;

namespace MDR_Tester;

public class TestData_100117 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "")
        {
	        FullStudy fs = CreateEmptyFullStudy();
	        
	        // Study 
	        
	        /*
	         * 
  "source_id": 100117,
  "record_date": "2023-05-29",
  "sd_sid": "RBR-386rm8",
  "public_title": "Effects of Electro-stimulation combined with Blood Flow Restriction affected by spinal injury muscles",
  "scientific_title": "Effect of Neuromuscular Electrostimulation combined with Blood Flow Restriction on muscle thickness and reflex responses in people with spinal cord injury",
  "remote_url": "http://ensaiosclinicos.gov.br/rg/RBR-386rm8",
  "public_contact_givenname": "Gabriel",
  "public_contact_familyname": "Skiba",
  "public_contact_email": "gabrielskiba13@yahoo.com.br",
  "public_contact_affiliation": "Universidade Federal do Paraná",
  "scientific_contact_givenname": "Gabriel",
  "scientific_contact_familyname": "Skiba",
  "scientific_contact_email": "gabrielskiba13@yahoo.com.br",
  "scientific_contact_affiliation": "Universidade Federal do Paraná",
  "study_type": "Interventional",
  "date_registration": "2020-10-31",
  "date_enrolment": "2015-12-01",
  "target_size": null,
  "study_status": "Completed",
  "primary_sponsor": "Universidade Federal do Paraná",
  "secondary_sponsors": "Universidade Federal do Paraná",
  "source_support": "Universidade Federal do Paraná",
  "interventions": "The intervention (training) consists of two protocols: blood flow restriction and functional electrostimulation. <br><br>Combined Group: The two techniques were applied to 9 individuals (right thigh + left thigh = N-18), totaling 16 training sessions over 8 weeks.<br><br>Individual Group: Applied only functional electro-stimulation in 7 individuals (right thigh + left thigh - N-14), totaling 16 training sessions over 8 weeks.<br>The intervention (training) consists of two protocols: blood flow restriction and functional electrostimulation.<br><br>INTERVENTION DESCRIPTION:<br><br>Blood flow restriction (BFR):<br><br>The BFR was applied using a sphygmomanometer (25 cm wide x 92 cm long) placed around the thigh immediately below the inguinal crease. The BFR pressure for the training of each participant in the FES + BFR group was sufficient to interrupt the auscultatory pulse from tibial artery, as was measured by a vascular Doppler device (DV-600, Martec, Ribeirão Preto, São Paulo). The training pressure was established to be 50% of the pressure obtained in the test, which has been shown to be effective in producing increases in thigh muscle mass (LAURENTINO et al., 2012). The average training pressure was 65.2 ± 7 mmHg. The pressure of the sphygmomanometer was maintained throughout the protocol of each session, including the intervals between series. The total time under pressure was approximately 15 minutes. No reported adverse reactions (e.g., dizziness or headache) were reported.<br><br>Functional electrostimulation protocol (FES)<br><br>Functional electro-stimulation (FES) was applied with the participants sitting in their own wheelchairs, with their hips and knees flexed at approximately 80° and 30°, respectively. Successive contractions were evoked unilaterally thro;Other;E02.331.800",
  "agemin": null,
  "agemin_units": null,
  "agemax": null,
  "agemax_units": null,
  "gender": "Male",
  "inclusion_criteria": "Men volunteers with complete spinal cord injury (ASIA A) and eligible for quadriceps responsiveness.",
  "exclusion_criteria": "Cauda equina injury; spinal shock; venous thrombosis; autonomic dysreflexia; vascular complications; pressure ulcers; osteoporosis; recent fracture; implants and femur metal pins and two consecutive absences to the training sessions as well.",
  "primary_outcome": "1- Expected primary outcome:\nChronic increases in muscle mass measurement in the combined training group are expected to be significantly higher than the measurements in the individual group. It will be verified by the ultrasound technique, during the period of 8 weeks.;1- Primary outcome found:\nChronic increases in muscle mass measurements (11.7% = 2.67cm) in the combined training group significantly higher than the measurements in the individual group (non-significant values), using the ultrasound technique, during the 8-week period.;2- Expected primary outcome:\nIt is expected to find sharp increases in the measurement of muscle mass in the combined training group, significantly higher than the measurements in the individual group. It will be checked by ultrasound technique, before exercise and 5 minutes after the first training session.;2- Primary outcome found:\nAcute increases in muscle mass measurements (19.7% = 2.79cm) in the combined training group are significantly higher than the values of the individual group (7.6% = 2.68cm), using the ultrasound technique, assessed before exercise and 5 minutes after the first training session.;3- Expected primary outcome:\nIt is expected to find sharp increases in the measure of edema in the combined training group significantly higher than the measures in the individual group. It will be checked by the echo intensity technique, before exercise and 5 minutes after the first training session.;3- Primary outcome found:\nAcute increases in edema measurements (34.8% = 15 arbitrary units) in the combined training group are significantly higher than the values of the individual group (10.5% = 4 arbitrary units), using the echo intensity technique, assessed before the exercise and 5 minutes after the first training session.;4- Expected primary outcome:\nIt is expected to find chronic increases in the measure of edema in the combined training group, significantly higher than the measures of the individual group. It will be verified by the echo intensity technique, during the period of 8 weeks.;4- Primary outcome found:\nChronic increases in edema measurements (5.1% = 2 arbitrary units) in the combined training group are not significantly higher than the values of the individual group (non-significant values). Checked by the echo intensity technique, over a period of 8 weeks.",
  "secondary_outcomes": "1- Outcome secondary expected:\nExpected that muscle thickness will return to baseline after a detraining period (3 weeks after last trainnig session), mensured by ultrasound technique. ;1- Outcome:\nMuscle thickness reduced to baseline after the detraining period, by ultrasound technique. ;2- Outcome secondary expected:\nExpected edema will return to baseline after a detraining period (3 weeks after last trainnig session), mensured by echo intensity technique. ;2- Outcome:\nEdema reduced to baseline after the detraining period (3 weeks after last trainnig session), mensured by echo intensity technique. ;Information after trial completion:\nMuscle atrophy is one of the most evident consequences of spinal cord injuries (SCI), as a result of chronic immobility. The detrimental effects of SCI on large skeletal muscle groups may lead to secondary effects such as glucose intolerance, increased risk of metabolic syndrome and type 2 diabetes mellitus. Blood flow restriction (BFR) training has been proposed as an effective method to induce hypertrophy using low training loads, with little or no muscle damage. This study aimed to investigate the acute and chronic effects of low-intensity functional electrical stimulation (FES) combined with blood flow restriction (BFR) on muscles affected by spinal cord injury. The acute effects of one bout of FES with (FES+BFR group) and without BFR (FES group) on muscle thickness (MT) and edema formation were compared. The chronic effects on MT and edema following 8-weeks of twice weekly training with and without BFR were also compared. The FES+BFR group showed MT and edema increases compared to the FES only group (p<0,05). The FES+BFR group showed a chronic MT increase after 4 weeks of training (p<0.05), with no further MT increases from the 4th to the 8th week (p>0,05). Following 3 week of detraining, MT decreased to baseline values. No MT changes were observed in the FES group throughout the 8 weeks (p>0.05). This current study showed that 8 weeks of low-intensity FES training combined with BFR induces MT increases on the paralyzed skeletal muscles of spinal cord-injured men. The acute effects suggest that functional electrical stimulation induces a greater metabolites accumulation and edema, when combined with BFR. The chronic effects suggest that early increases in MT can be attributed to edema, whereas after the 4th week the increased MT can be interpreted predominantly as muscle hypertrophy.\n\n",
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
  "db_name": "rebec",
  "design_string": "Clinical intervention / training trial, controlled/randomized, parallel, open with two arms.",
  "phase_string": "N/A",
  "country_list": [
    "Brazil"
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
      "ftype_id": 23,
      "ftype": "Intervention model",
      "fvalue_id": 305,
      "fvalue": "Parallel assignment"
    }
  ],
  "condition_list": [
    {
      "condition": "Spinal cord injuries",
      "code": null,
      "code_system": null
    },
    {
      "condition": "C10.228. 854.763",
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
             *"source_id": 100117,
  "record_date": "2023-05-29",
  "sd_sid": "RBR-5cqndz",
  "public_title": "The effects of Pain Neuroscience Eucation and Pilates on kinesiophobia in older people with chronic low back pain: randomized controlled clinical study",
  "scientific_title": "Pain Neuroscience Eucation for the older people with chronic low back pain: randomized controlled trial",
  "remote_url": "http://ensaiosclinicos.gov.br/rg/RBR-5cqndz",
  "public_contact_givenname": "Mariane",
  "public_contact_familyname": "Campos",
  "public_contact_email": "mari.marquesc@yahoo.com.br",
  "public_contact_affiliation": "Universidade Federal de São Carlos",
  "scientific_contact_givenname": "Mariane",
  "scientific_contact_familyname": "Campos",
  "scientific_contact_email": "mari.marquesc@yahoo.com.br",
  "scientific_contact_affiliation": "Universidade Federal de São Carlos",
  "study_type": "Interventional",
  "date_registration": "2018-09-20",
  "date_enrolment": "2017-10-04",
  "target_size": null,
  "study_status": "Active, not recruiting",
  "primary_sponsor": "Centro de Ciências Biológicas e da Saúde da Universidade Federal de São Carlos",
  "secondary_sponsors": "Mariane Marques de Campos",
  "source_support": "Coordenação de Aperfeiçoamento de Pessoal de Nível Superior",
  "interventions": "The older people participants will be divided into two groups being the Control Group (CG), who will participate in 16 classes of the Pilates Method solo, 2 times a week, totaling 8 weeks, lasting 1 hour each and the Intervention Group (IG) that will first participate in 3 sessions of Pain Neuroscience Education, taught individually with intervals of 1 or 2 days between them, lasting 30 minutes each, and soon thereafter, 16 Pilates Method classes in the same models of the Control Group, and Pilates classes are taught in groups of 5 people. Both the GC and the GI will consist of 40 people each.;Other;E02.779.474;I02.233.332",
  "agemin": "60",
  "agemin_units": "Other (60y)",
  "agemax": null,
  "agemax_units": null,
  "gender": "Not provided",
  "inclusion_criteria": "Be 60 years old or over;\nBe a carrier of nonspecific chronic low back pain;\nScore at least the cut grade according to their education in the instrument: Mini Mental State Examination (MMSE);\nScore up to 5 points on the Geriatric Depression Scale instrument (GDS-15)",
  "exclusion_criteria": "Older people who underwent physiotherapeutic treatment for pain management in the last six months;\nOlder people who underwent surgical treatment for pain management;\nOlder people with diagnosis of Fibromyalgia;\nInvolvement in regular sports activities that have the same benefits as Pilates;\nActive inflammatory diseases;\nPain related to previous fractures of the spine or lower limbs;\nNeoplasms;\nDeath.",
  "primary_outcome": "It's expected that all variables in both groups will be improved, but it will be more significant in the Intervention Group, after the application of Pain Neuroscience Education.\nPresentation of expected outcome: Kinesiophobia\nPresentation of the method used to verify the outcome: Kinesiophobia TAMPA scale\nPresentation of the parameters: it is expected a reduction of the score in the post-intervention evaluation when compared to the pre-intervention. There is no clinically important minimal difference established for this scale.",
  "secondary_outcomes": "Presentation of expected outcome: functional capacity and physical performance\nPresentation of the method used to verify the outcome: Short Physical Performance Battery (SPPB)\nPresentation of the parameters: it is expected an improvement in the total score of the test in the post intervention evaluation when compared to the pre intervention. There is no clinically important minimal difference established for this test.;Presentation of expected outcome: Flexibility of the back of the trunk and lower limb muscles\nPresentation of the method used to verify the outcome: flexibility in the Wells Bank\nPresentation of the parameters: it is only expected an improvement of the flexibility measured in centimeters in the post intervention evaluation when compared to the pre intervention. There is no clinically important minimal difference established for this test.;Presentation of expected outcome: muscular electrical activity of the trunk muscles\nPresentation of the method used to evaluate the outcome: surface electromyography\nPresentation of the parameters: it is expected an improvement in muscle recruitment (more coordinated recruitment) of the trunk muscles in the activities of reaching and rising in the post-intervention evaluation when compared to the pre-intervention.\nThere is no clinically important minimal difference established for this test.;Presentation of expected outcome: Intensity of pain\nPresentation of the method used to verify the outcome: Visual Analogue Scale (VAS) and Numerical Pain Scale.\nPresentation of the parameters: it is expected a decrease of 2 points in the post-intervention evaluation when compared to the pre-intervention in both scales.;Presentation of expected outcome: Mobility and functional balance\nPresentation of the method used to verify the outcome: Timed Up and Go (TUG)\nPresentation of the parameters: it is expected a reduction of the time of execution of the test in the post-intervention evaluation when compared to the pre-intervention. There is no clinically important minimal difference established for this test.",
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
  "db_name": "rebec",
  "design_string": "Clinical trial of a randomized, controlled, parallel, double-blind, two-arm treatment trial",
  "phase_string": "N/A",
  "country_list": [
    "Brazil"
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
      "ftype_id": 23,
      "ftype": "Intervention model",
      "fvalue_id": 305,
      "fvalue": "Parallel assignment"
    },
    {
      "ftype_id": 24,
      "ftype": "Masking",
      "fvalue_id": 510,
      "fvalue": "Double"
    }
  ],
  "condition_list": [
    {
      "condition": "older people, chronic pain, chronic low back pain, aging",
      "code": null,
      "code_system": null
    },
    {
      "condition": "C23.888.592.612.274",
      "code": null,
      "code_system": null
    },
    {
      "condition": "G07.345.124",
      "code": null,
      "code_system": null
    },
    {
      "condition": "C23.888.592.612.107.400",
      "code": null,
      "code_system": null
    },
    {
      "condition": "M01.060.116.100",
      "code": null,
      "code_system": null
    }
  ]
             * 
             */

	        return fs;
        }

        return null;
    }
}