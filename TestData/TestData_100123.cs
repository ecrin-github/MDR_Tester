using System.Text;

namespace MDR_Tester;

public class TestData_100123 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "2009-011622-34")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "An open label non-randomized extension study to evaluate the safety and tolerability of AIN457 (anti interleukin-17 monoclonal antibody) in patientswith psoriatic arthritis";
	        StringBuilder sb = new StringBuilder("Primary objectives: To assess the safety and tolerability of AIN457 administered i.v. initially up to six months (Part 1) with a ");
	        sb.Append("possible extension of a further 6 months (Part 2) in patients with psoriatic arthritis who participated in the core CAIN457A2206 phase II proof-of-concept study"); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2010, 4, 11, 21, null, 900,
		        18, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "CAIN457A2206E1", 14,100189, 
		        "Novartis", "https://ror.org/02f9zrr09", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A2206E1", 14, "en", 11, false, "From the EU CTR"));

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100189, "Novartis", "https://ror.org/02f9zrr09"));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "AIN457", null, null, null, null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Psoriatic arthritis (PsA), which belongs to seronegative spondyloarthropathies (SpA).", 
		        null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Psoriatic arthritis", 16, "10037160", null, null));
	        
	        // countries
            
	        // iec
	        /*
	         *"inclusion_criteria":
	         * "1. Patients who participate and complete the core CAIN457A2206 study up to and including the EoS i.e. Visit 16 (Week 24), may enter the extension study upon signing informed consent.
	         * \n2. Patients who discontinued the core study due to unsatisfactory therapeutic effect at their Visit 14 (Week 16) or a later visit may enter the extension study within three weeks of completing the study discontinuation visit of the core study, provided that at their discontinuation visit they meet the criteria below. Patients who do not enter the extension study within 3 weeks of completing the study discontinuation visit of the core study, will have an additional baseline visit (Visit 17) and must meet the criteria below::\n• The number of tender joints is the same or more than the core study baseline OR,• The number of swollen joints is the same or more than the core study baseline OR,• There is no improvement compared with the core study baseline in at least three of the following five domains: patient global assessment, physician global assessment, patient pain assessment, Health Assessment Questionnaire and CRP.
	         * \n3. Women of childbearing potential must be using simultaneously double-barrier or two highly effective methods of contraception, (e.g. intra-uterine device plus condom,diaphragm plus condom, etc; hormone replacement as either oral or implantable isacceptable as one form), from the time of screening for the duration of the entire study, up to study completion and up to 16 weeks post last drug administration. Periodic abstinence (e.g. calendar, ovulation, symptothermal, post-ovulation methods) and withdrawal are not acceptable methods of contraception.
	         * \n4. Male patients willing to use simultaneously two highly effective methods of contraception (e.g. intra-uterine device plus condom) for the duration of the entire study, up to study completion visit and up to 16 weeks post the last drug administration. Periodic abstinence and withdrawal are not acceptable methods of contraception.",
  "exclusion_criteria":
   "1. Patients for whom continued treatment with AIN457 in the extension is not considered appropriate by the treating physician.
   \n2. Patients who were non-compliant or who demonstrated a major protocol deviation in the core CAIN457A2206 study.
   \n3. Patients who discontinued from the core CAIN457A2206 study before Visit 14 (Week 16)
   \n4. Female patients who are pregnant or lactating.
   \n5. Any active systemic infection within the past 2 weeks including a positive chest X-ray.
   \n6. Positive human immunodeficient virus (HIV: ELISA and Western blot) test result,Hepatitis B surface antigen (HBsAg) or Hepatitis C test result, where patients have been re-tested.The following Exclusion Criteria as defined in the core trial [CAIN457A2206] will continue to be valid with minor revisions:
   \n7. Positive Purified Protein Derivative (PPD) tuberculin skin test of ≥ 5 mm at baseline, (where patients have been re-tested). A positive PPD test will be defined using the MMWR 2000 guidance, summarized as criteria for tuberculin positivity by risk group. A PPD test should not be done in subjects who had a tuberculosis vaccination in the past. These subjects will be eligible to participate if – according to local guidelines – latent tuberculosis can be excluded. For those study sites using QuantiFeron test a positive test at baseline (where patients have been re-tested) will exclude the subject from the participation in the study. If the result for either PPD or QuantiFeron test is indeterminate the subject will be excluded.
   \n8. For previous use of immunosuppressive agents a wash-out period of at least 1 month or 5 half-lives, whatever is longer, is required. Immunosuppressive agent include but are not limited to cyclosporine, mycophenolate, tacrolimus, and 5-aminosalicylic acid (5-ASA).\nIf on previous treatment with anti-TNF-α therapy (or other biological therapy), thefollowing washout periods will be required for such patients to be eligible to participate in the trial.\n• Six (6)-months wash out prior to dosing for alefacept, rituxan and raptiva,• Three (3)-months washout prior to baseline for adalimumab and certolizumab,• Two (2)-months washout prior to baseline for etanercept and infliximab.• One (1) month washout prior to baseline for systemic immunosuppressants including, but not limited to azathioprine, cyclosporine and leflunomide.Patients on concomitant prednisone, Methotrexate (MTX) or SSZ can be included,whereby:• Prednisone should be kept at a stable dose 4 weeks before baseline and throughout the study and not exceed 10 mg/day.\n• MTX should be kept at a stable dose 4 weeks before baseline and throughout thestudy and not exceed 25 mg/week.\n• SSZ should be kept at a stable dose 4 weeks before baseline and throughout the study
  \n9. Patients who are on NSAIDS should be kept at a stable dose 4 weeks before baseline and throughout the study.",
	         *
	         * "countries": [
    {
      "country_name": "Germany",
      "status": "Completed"
    },
    {
      "country_name": "United Kingdom",
      "status": "Completed"
    }
	         */
            
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: EU CTR registry entry";
	        string ob_title = display_title + " :: EU CTR registry entry";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "EU CTR registry entry", null, ob_title,
		        null, 9, 2010, 23, 13, 100123, "EU Clinical Trials Register", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
		        "https://www.clinicaltrialsregister.eu/ctr-search/trial/2009-011622-34/DE", true, 35, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2010 Jan 5", 2010, 1, 5, null, null, null, null));
	       
	        fs.data_objects!.Add(sdo);
			
	        // 2) Trial results entry
			
	        sd_oid = sd_sid + " :: 28 :: EU CTR results entry";
	        ob_title = display_title + " :: EU CTR results entry";
	        sdo = CreateEmptyStudyDataObject();
			
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "EU CTR results entry", null, ob_title,
		        null, 9, 2016, 23, 28, 100123, "EU Clinical Trials Register", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
		        "https://www.clinicaltrialsregister.eu/ctr-search/trial/2009-011622-34/results", true, 35, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2016 Dec 15", 2016, 12, 15, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2016 Dec 15", 2016, 12, 15, null, null, null, null));
			
	        fs.data_objects!.Add(sdo);
	        
	        // 3) Results Summary
	        
	        sd_oid = sd_sid + " :: 79 :: CAIN457A2206E1.CTR.08Nov2016";
	        ob_title = display_title + " :: CAIN457A2206E1.CTR.08Nov2016";
	        sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "CAIN457A2206E1.CTR.08Nov2016", null, ob_title,
		        null, 9, 2016, 23, 79, 100189, "Novartis", "https://ror.org/02f9zrr09", "en", 11, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
		        "https://www.clinicaltrialsregister.eu/ctr-search/rest/download/result/attachment/2009-011622-34/1/16214",
		        true, 11, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        return fs; 
        }
        
        if (sd_sid == "2018-001547-32")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Study of efficacy and safety of pembrolizumab plus platinum-based doublet chemotherapy with or without canakinumab in previously untreated locally advanced or metastatic non-squamous and squamous NSCLC subjects";
	        StringBuilder sb = new StringBuilder("Primary objectives: Safety run-in part: To determine the recommended phase 3 dose regimen (RP3R) of canakinumab in combination with  pembrolizumab plus platinum-based doublet chemotherapy. \n");
	        sb.Append("Double-blind, randomized, placebo-controlled part: To compare progression free survival (PFS) by local investigator assessment as per RECIST 1.1 and overall survival (OS) between the two treatment arms."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2018, 12, 11, 25, null, 900,
		        18, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "CACZ885U2301", 14,100189, 
		        "Novartis", "https://ror.org/02f9zrr09", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the EU CTR"));
	        string title = "A randomized, double-blind, placebo-controlled, phase III study evaluating the efficacy and safety of pembrolizumab plus platinum-based doublet ";
	        title += "chemotherapy with or without canakinumab as first line therapy for locally advanced or metastatic non-squamous and squamous non-small cell lung cancer subjects (CANOPY-1)";
	        fs.titles.Add(new StudyTitle(sd_sid, title, 16, "en", 11, false, "From the EU CTR"));

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100189, "Novartis", "https://ror.org/02f9zrr09"));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 510));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "canakinumab", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "pembrolizumab", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "cisplatin", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "carboplatin", null, null, "D000016190", "Carboplatin"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "paclitaxel", null, null, "D000017239", "Paclitaxel"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "nab-paclitaxel", null, null, null, null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Non-small cell lung cancer", 16, "10061873", 
		           "2C25", "Malignant neoplasms of bronchus or lung"));
            
            // countries
            
            // iec
            /*
             * "inclusion_criteria": "\n1. Histologically confirmed locally advanced  or metastatic NSCLC
             * \r\n2. Measurable disease  by RECIST 1.1
             * \r\n3. Known PD-L1 status
             * \r\n4. ECOG performance status (PS) ≤ 1.
             * \r\n5. Other protocol-defined inclusion criteria may apply. \n",
  "exclusion_criteria": 
  "\n1. Previous immunotherapy or treatment with IL-1β inhibitor.
  \r\n2. Subjects with epidermal growth factor receptor (EGFR) sensitizing\r\nmutations and/or ALK rearrangement
  \r\n3. History of severe hypersensitivity reaction to monoclonal antibodies,\r\nplatinum containing drugs, nab-paclitaxel, paclitaxel, pemetrexed or any\r\nknown excipients of these drugs
  \r\n4. Other protocol-defined exclusion criteria may apply.
  \r\n5. Known active central nervous system (CNS) metastases and/or\r\ncarcinomatous meningitis.
  \r\n6. Presence or history of a malignant disease, other than NSCLC, that has\r\nbeen diagnosed and/or required therapy within the past 3 years prior to\r\nrandomization.
  \r\n7. Active autoimmune disease that has required systemic treatment in\r\nthe past 2 years prior to randomization (i.e. with use of disease\r\nmodifying agents, corticosteroids or immunosuppressive drugs).Control\r\nof the disorder with replacement therapy (e.g., thyroxine, insulin, or\r\nphysiologic corticosteroid replacement therapy for adrenal or pituitary\r\ninsufficiency, etc) is permitted.
  \r\n13. History of (non-infectious) pneumonitis that required steroids or\r\ncurrent pneumonitis.\r\n\n",
             *
             *
             * "countries": [
    {
      "country_name": "Germany",
      "status": "Ongoing"
    },
    {
      "country_name": "United Kingdom",
      "status": null
    },
    {
      "country_name": "France",
      "status": "Ongoing"
    },
    {
      "country_name": "Czechia",
      "status": "Completed"
    },
    {
      "country_name": "Netherlands",
      "status": "Completed"
    },
    {
      "country_name": "Greece",
      "status": "Ongoing"
    },
    {
      "country_name": "Spain",
      "status": "Ongoing"
    },
    {
      "country_name": "Iceland",
      "status": "Ongoing"
    },
    {
      "country_name": "Slovakia",
      "status": "Ongoing"
    },
    {
      "country_name": "Austria",
      "status": "Ongoing"
    },
    {
      "country_name": "Portugal",
      "status": "Ongoing"
    },
    {
      "country_name": "Denmark",
      "status": "Completed"
    },
    {
      "country_name": "Finland",
      "status": "Completed"
    },
    {
      "country_name": "Sweden",
      "status": "Ongoing"
    },
    {
      "country_name": "Hungary",
      "status": "Ongoing"
    },
    {
      "country_name": "Italy",
      "status": "Ongoing"
    },
    {
      "country_name": "Romania",
      "status": "Ongoing"
    },
    {
      "country_name": "Russian Federation",
      "status": null
    },
    {
      "country_name": "Singapore",
      "status": null
    },
    {
      "country_name": "Hong Kong",
      "status": null
    },
    {
      "country_name": "United States",
      "status": null
    },
    {
      "country_name": "Malaysia",
      "status": null
    },
    {
      "country_name": "Thailand",
      "status": null
    },
    {
      "country_name": "Vietnam",
      "status": null
    },
    {
      "country_name": "China",
      "status": null
    },
    {
      "country_name": "Brazil",
      "status": null
    },
    {
      "country_name": "Guatemala",
      "status": null
    },
    {
      "country_name": "Korea, Republic of",
      "status": null
    },
    {
      "country_name": "Poland",
      "status": null
    },
    {
      "country_name": "Chile",
      "status": null
    },
    {
      "country_name": "Colombia",
      "status": null
    },
    {
      "country_name": "Argentina",
      "status": null
    },
    {
      "country_name": "Japan",
      "status": null
    },
    {
      "country_name": "Philippines",
      "status": null
    },
    {
      "country_name": "Switzerland",
      "status": null
    },
    {
      "country_name": "India",
      "status": null
    },
    {
      "country_name": "Lebanon",
      "status": null
    },
    {
      "country_name": "Canada",
      "status": null
    },
    {
      "country_name": "Czech Republic",
      "status": null
    },
    {
      "country_name": "Turkey",
      "status": null
    },
    {
      "country_name": "Norway",
      "status": null
    },
    {
      "country_name": "Taiwan",
      "status": null
    },
    {
      "country_name": "Mexico",
      "status": null
    },
    {
      "country_name": "South Africa",
      "status": null
    },
    {
      "country_name": "Australia",
      "status": null
    },
    {
      "country_name": "Peru",
      "status": null
    }
             */
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: EU CTR registry entry";
            string ob_title = display_title + " :: EU CTR registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "EU CTR registry entry", null, ob_title,
	            null, 9, 2018, 23, 13, 100123, "EU Clinical Trials Register", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
	            "https://www.clinicaltrialsregister.eu/ctr-search/trial/2018-001547-32/DE", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2018 Oct 1", 2018, 10, 1, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
            
        }

        if (sd_sid == "2004-001569-16")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "EFFICIENCY AND SAFETY OF CLINAVIT PAEDIATRIC AT A WEIGHT DEPENDANT DOSE ADMINISTERED DAILY FOR 5 CONTINUOUS DAYS ON 4 VITAMINS BLOOD LEVEL IN NEONATES AND CHILDREN UP TO 11 YEARS OF AGE ";
	        display_title += "RECEIVING PARENTERAL NUTRITION. A PROSPECTIVE, MULTICENTRE, RANDOMISED, COMPARATIVE, DOUBLE BLIND PHASE III STUDY IN THERAPEUTIC USE VERSUS SOLUVIT AND VITALIPID INFANT CARRIED OUT IN PARALLEL GROUPS.";
	        StringBuilder sb = new StringBuilder("Primary objectives: Main objective : To confirm that Clinavit Paediatric is an efficient and safe alternative to Soluvit and Vitalipid Infant, the current vitamins cocktail used for ");
	        sb.Append("parenteral nutrition supplementation in neonates, infants and children up to 11 years of age, through the assessment of:·	The blood levels of the most commonly explored vitamins "); 
	        sb.Append("in literature as surrogate markers of effective intake,·	The vital signs and adverse events occurring within the 5-day treatment period."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2006, 7, 11, 25, null, 900,
		        0, 14, 11, 17, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "VITPED/P01/04/MU.UK", 14, null, 
		        "BAXTER SAS R&D Parenteral Nutrition", null, null, null));
	        
	        string title = "EFFICIENCY AND SAFETY OF CLINAVIT PAEDIATRIC AT A WEIGHT DEPENDANT DOSE ADMINISTERED DAILY FOR 5 CONTINUOUS DAYS ON 4 VITAMINS BLOOD LEVEL IN NEONATES AND CHILDREN UP TO 11 YEARS OF AGE ";
	        title += "RECEIVING PARENTERAL NUTRITION. A PROSPECTIVE, MULTICENTRE, RANDOMISED, COMPARATIVE, DOUBLE BLIND PHASE III STUDY IN THERAPEUTIC USE VERSUS SOLUVIT AND VITALIPID INFANT CARRIED OUT IN PARALLEL GROUPS.";
	        fs.titles!.Add(new StudyTitle(sd_sid, title, 16, "en", 11, true, "From the EU CTR"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "BAXTER SAS R&D Parenteral Nutrition", null));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 510));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Clinavit Pediatric", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Vitalipid infant", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "soluvit", null, null, null, null));
           
            // countries
            
            // iec
            /*
             * "inclusion_criteria": "·In or out patients of both genders,·\tAged up to 11 years of age at the first visit,·\tPatient requiring for any underlying pathology at least 5 days of total parenteral nutrition, representing at least 90% of their total energy needs,·\tPatient to be supplemented by intravenous vitamins,·\tPatient whose parents or legal representative have freely given their written informed consent.",
  "exclusion_criteria": "·Known HIV infection,·\tKnown pre-existing hypervitaminosis,·\tKnown hypersensitivity to intravenous vitamins, or any excipients of the preparation,·Participation in another clinical trial within a month prior to the first visit, ·Patient with any underlying pathology at risk of foreseeable drop out before the 6th day,·\tPatients requiring treatment by anticonvulsants (barbiturics or phenytoin),·Patients requiring an extra supplementation by products containing vitamins, whatever the route,·\tPrevious inclusion in this study,·\tParents or legal representative’s potential non-cooperation or unwillingness to comply fully with the protocol.",
  "medical_condition": "No special medical condition but Patient requiring for any underlying pathology at least 5 days of total parenteral nutrition, representing at least 90% of their total energy needs",
             *
             *  "countries": [
    {
      "country_name": "Spain",
      "status": "Ongoing"
    }
  ],
             */
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: EU CTR registry entry";
            string ob_title = display_title + " :: EU CTR registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "EU CTR registry entry", null, ob_title,
	            null, 9, 2006, 23, 13, 100123, "EU Clinical Trials Register", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
	            "https://www.clinicaltrialsregister.eu/ctr-search/trial/2004-001569-16/ES", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2006 Jun 30", 2006, 6, 30, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        
        if (sd_sid == "2012-000615-84")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "The MEMOS study: A Eurosarc Study of Mifamurtide in advanced osteosarcoma";
	        StringBuilder sb = new StringBuilder("Primary objectives: The principal research question is to identify markers of response to mifurmatide by looking at biological markers of immune response activation ");
	        sb.Append("in tumour biopsies taken before and after 6 weeks of treatment. The pharmacodynamic readouts will be compared with radiological (CT scan) response measured by standard RECIST criteria."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2014, 11, 11, 21, null, 900,
		        12, 17, 64, 17, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "OCTO_039", 14, 100253, "University of Oxford", 
		        "https://ror.org/052gg0110", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A Mechanistic Study Of Mifamurtide (MTP-PE) In Patients With Metastatic And/Or Recurrent Osteosarcoma", 16, "en", 11, false, "From the EU CTR"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100253, "University of Oxford", "https://ror.org/052gg0110"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "Millennium Pharmaceuticals, Inc, a wholly-owned subsidiary of Takeda Pharmaceutical Company Limited", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "EU frame grant", null));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "mifamurtide", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Ifosfamide", null, null, null, null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Relapsed or metastatic osteosarcoma", null, null, 
		        null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Osteosarcoma", 16, "10031291", 
		        "2B51", "Osteosarcoma, primary site"));

            // countries
            
            // iec
            /*
             * "inclusion_criteria": "A patient will be eligible for inclusion in this study if all of the following criteria apply.
             * 1.\tRelapsed osteosarcoma (first, second, third or any relapse, patient has recovered from chemotherapy and any other investigational drug/agent treatment, radiotherapy or surgical procedure).
             * 2.\tHistological confirmed diagnosis of osteosarcoma at original presentation.
             * 3.\tTumour at biopsy accessible or resectable site.
             * 4.\tProgressive disease documented by imaging within 3 months of entry into the trial.
             * 5.\tAt least one measurable lesion on CT scan (RECIST) performed in past 21 days prior to trial entry.
             * 6.\tMale or female, age ≥ 16 years to 65 (or ≥18 based on institutional practice for Teenage and Young Adult Cancer patients).
             * 7.\tLife expectancy of at least 3 months.
             * 8.\tWHO performance score of 0 – 2.
             * 9.\tThe patient is willing and able to comply with the protocol and scheduled follow-up visits and examinations.
             * 10.\tWritten (signed and dated) informed consent.
             * 11.\tCardiac shortening fraction ≥ 28% or ejection fraction ≥ 45%
             * 12.\tRenal function is adequate for ifosfamide treatment (GFR as per table below, other renal function screening tests as per local practice)
             * 13.\tHaematological and biochemical indices within the ranges detailed in the protocol",
  "exclusion_criteria": 
  "Patient will not be eligible for the trial if any of the following apply:
  1.\tPregnant or breast-feeding woman. Men or women of childbearing potential unless effective methods of contraception are used during study treatment and for at least 7 days after the last mifamurtide dose.
  2.\tPrevious treatment with mifamurtide or a mifamurtide-like drug* in a clinical trial setting for the treatment of metastatic and/or recurrent osteosarcoma in the six months prior to registration. 
  3.\tContraindications to lung biopsies
  4. \tHypersensitivity to ifosfamide or any component of the formulation.
  5.\tPreviously diagnosed brain metastases.
  6.\tSignificant active cardiac disease including: uncontrolled high blood pressure (no greater than 2 standard deviations above the mean for age for systolic blood pressure (SBP) and diastolic blood pressure (DBP), unstable angina, congestive heart failure, myocardial infarction within the previous 6 months, or serious cardiac arrhythmias and with a history of pericarditis and myocarditis
  7.\tTreatment with any other investigational agent, or participation in another interventional clinical trial within 21 days prior to enrolment.
  8.\tMajor surgery within 21 days prior first study biopsy
  9.\tCurrently taking of high-dose non-steroidal anti-inflammatory drugs (NSAIDs) or corticosteroid treatment
  10.\tConcurrent use of ciclosporin or other calcineurin inhibitors.
  11.\tAny psychological, social or medical condition, physical examination finding or a laboratory abnormality that the Investigator considers would make the patient a poor trial candidate or could interfere with protocol compliance or the interpretation of trial results.
  12.\tAny other active malignancy, with the exception of adequately treated cone-biopsied in situ carcinoma of the cervix uteri and non-melanoma skin lesions.
  13.\tPatients who are known to be serologically positive for Hepatitis B, Hepatitis C or HIV.* mifamurtide-like drugs include GMCSF, interferon and other macrophage activating molecules.",
             *
             *"countries": [
    {
      "country_name": "Italy",
      "status": "Completed"
    },
    {
      "country_name": "Netherlands",
      "status": "Completed"
    },
    {
      "country_name": "Germany",
      "status": "Completed"
    }
  ],
             * 
             */
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: EU CTR registry entry";
            string ob_title = display_title + " :: EU CTR registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "EU CTR registry entry", null, ob_title,
	            null, 9, 2014, 23, 13, 100123, "EU Clinical Trials Register", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
	            "https://www.clinicaltrialsregister.eu/ctr-search/trial/2012-000615-84/IT", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2014 Sep 10", 2014, 9, 10, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Trial results entry
			
            sd_oid = sd_sid + " :: 28 :: EU CTR results entry";
            ob_title = display_title + " :: EU CTR results entry";
            sdo = CreateEmptyStudyDataObject();
			
            sdo.data_object = new DataObject(sd_oid, sd_sid, "EU CTR results entry", null, ob_title,
	            null, 9, 2017, 23, 28, 100123, "EU Clinical Trials Register", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
	            "https://www.clinicaltrialsregister.eu/ctr-search/trial/2012-000615-84/results", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2017 Aug 16", 2017, 8, 16, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2017 Aug 16", 2017, 8, 16, null, null, null, null));
			
            fs.data_objects!.Add(sdo);
	        
            // 3) Results Summary
	        
            sd_oid = sd_sid + " :: 79 :: CSR summary - PDF DL";
            ob_title = display_title + " :: CSR summary - PDF DL";
            sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CSR summary - PDF DL", null, ob_title,
	            null, 9, 2017, 23, 79, 100253, "University of Oxford", "https://ror.org/052gg0110", 
	            "en", 11, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
	            "https://www.clinicaltrialsregister.eu/ctr-search/rest/download/result/zip/pdf/2012-000615-84/1",
	            true, 11, null, null, null));
	        
            fs.data_objects!.Add(sdo);
	        
            return fs; 
        }
        
        
        if (sd_sid == "2013-001036-22")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Assesment of response predictor genes in patients with initial breast cancer HER2+ to the lapatinib and trastuzumab treatment combination before surgery.";
	        StringBuilder sb = new StringBuilder("Primary objectives: To evaluate the ability of the PAM50 HER2-enriched (HER2-E) subtype to predict pathological complete response in the breast (pCRB) ");
	        sb.Append("to dual HER2 blockade with lapatinib and trastuzumab, with or without endocrine therapy, at the time of surgery."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2013, 10, 11, 21, null, 905,
		        18, 17, null, null, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "SOLTI-1114", 14, null, 
		        "SOLTI", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid,
		        "Determinación de genes predictores de respuesta a la combinación del tratamiento con lapatinib y trastuzumab en pacientes con cancer de mama inicial HER2+ previo a la cirugia.", 
		        15, "es", 22, false, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid,
		        "PAM50 HER2-enriched phenotype as a predictor of early response to neoadjuvant lapatinib plus trastuzumab in Stage I to IIIA HER2-positive breast cancer", 
		        16, "en", 11, false, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid,
		        "Fenotipo HER2-enriquecido determinado por la plataforma PAM50 como predictor de respuesta temprana a la administración neoadyuvante de la combinación de lapatinib y trastuzumab con o sin terapia hormonal en cáncer de mama HER2+ estadios I a IIIA", 
		        16, "es", 22, false, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid, "PAMELA", 14, "en", 11, false, "From the EU CTR"));

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "SOLTI", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 100163, "GlaxoSmithKline", "https://ror.org/01xsqw823"));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Lapatinib", null, null, "D000077341", "Lapatinib"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Letrozol", null, null, "D000077289", "Letrozol"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Citrato de Tamoxifeno", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Trastuzumab", null, null, "D000068878", "Trastuzumab"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "PACLITAXEL", null, null, "D017239", "Paclitaxel"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Relapsed or metastatic osteosarcoma", null, null, 
		        null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Osteosarcoma", 16, "10031291", 
		        "2B51", "Osteosarcoma, primary site"));
	        
            // countries
            
            // iec
            /*
             * "inclusion_criteria":
             * "1.Consentimiento informado por escrito para todos los procedimientos del estudio, de acuerdo con los requerimientos legales locales, antes de iniciar cualquier procedimiento específico del protocolo
             * \n2.Carcinoma de mama invasivo no tratado, elegible para cirugía definitiva primaria (estadios I-IIIa)
             * \n3.Carcinoma de mama invasivo confirmado histológicamente, con todas las características siguientes:
             * \na.Tumor primario ?1cm en su diámetro mayor
             * \nb.cN0-2
             * \nc.Sin evidencias de metástasis a distancia (M0)
             * \n4.CM invasivo HER2+, definido por las guías del CAP como:
             * \na.sobreexpresión 3+ por IHQ (tinción uniforme e intensa de la membrana de >30% de las células tumorales invasivas)o
             * \nb.sobreexpresión 2+ o 3+ (en un 30% o menos de las células neoplásicas) por IHQ y amplificación génica de HER2 por hibridación in situ (ISH; >6 copias del gen HER2 por núcleo, o un cociente entre las pruebas de ISH [copias del gen HER2 respecto a señales en el cromosoma 17] >2,2)
             * \n5.Pacientes mujeres
             * \n6.Edad ?18 años
             * \n7.Estado funcional del ECOG de 0 ó 1
             * \n8.Función orgánica adecuada, definida por:
             * \na.Recuento absoluto de neutrófilos (RAN) ?1,5 x 109/l
             * \nb.Hemoglobina (Hg) ?10 g/dl\nc.Plaquetas >100.000/mm3
             * \nd.Creatinina ?1,6 mg/dl
             * \ne.ALT y AST ?2,5 x LSN,
             * \nf.Fosfatasa alcalina ?5 LSN
             * \ng.Bilirrubina total ?1,5 mg/dl
             * \n9.Fracción de eyección del ventrículo izquierdo (FEVI) basal ?50%, determinada mediante ecocardiograma (ECO) o ventriculografía isotópica (MUGA).
             * \n10.En las mujeres premenopáusicas con capacidad reproductiva (biológicamente fértiles) y en aquellas cuya menopausia se haya producido con una anterioridad menor a 12 meses: prueba de embarazo de ?-HCG (en suero) negativa. Todas las pacientes biológicamente fértiles deberán estar de acuerdo en utilizar un método anticonceptivo fiable y comprometerse a emplearlo desde las 2 semanas previas a la administración de la primera dosis del producto en investigación hasta 28 días después de haber recibido la última dosis del mismo.
             * \n11.Ausencia de anomalías psicológicas, familiares, sociológicas o geográficas que potencialmente puedan dificultar el cumplimiento del protocolo del estudio y la pauta de seguimiento. Estas anomalías deberán ser discutidas con la paciente antes de su inclusión en el estudio.",
  "exclusion_criteria": 
  "1.Cáncer de mama inoperable en estadio III (p.ej., tumores T4 y/o N3)
  \n2.Pacientes con enfermedad localmente avanzada, o aquellas en quienes se considere apropiada la quimioterapia de primera línea con taxanos y antraciclinas como tratamiento neoadyuvante óptimo
  \n3.Quimioterapia, radioterapia o cirugía previas para el cáncer de mama invasivo, a excepción de la resección de tumor en la mama contralateral y a condición de que la paciente no haya recibido previamente radio o quimioterapia adyuvantes
  \n4.Pacientes con una segunda neoplasia activa simultánea, a excepción del cáncer de piel distinto del melanoma tratado satisfactoriamente, del melanoma in situ o del carcinoma in situ de cérvix. Las pacientes con otras neoplasias malignas no mamarias deberán haber permanecido sin enfermedad durante 5 años como mínimo
  \n5.Presencia o sospecha de reacción de hipersensibilidad a cualquier fármaco en investigación o compuesto terapéutico, o a sus excipientes
  \n6.Insuficiencia cardiaca congestiva concomitante o FEVI <50%
  \n7.Enfermedades cardiovasculares clínicamente significativas (es decir, activas): accidente vascular cerebral (<6 meses previamente a la inclusión), angina inestable, infarto de miocardio ?6 meses antes de la inclusión, hipertensión no controlada (presión sistólica >150 mmHg y/o diastólica >100 mmHg) y arritmias de alto riesgo no controladas
  \n8.Diabetes mellitus no controlada, úlcera péptica activa o epilepsia no controlada
  \n9.Infecciones activas no controladas presentes en el momento de la inclusión
  \n10.Antecedentes de comorbilidades significativas que, a juicio del investigador, puedan interferir con la ejecución del estudio, la evaluación de la respuesta o el consentimiento informado
  \n11.Uso de cualquier fármaco en investigación o participación en otro ensayo clínico terapéutico de forma simultánea o durante los 30 días anteriores a la inclusión
  \n12.Pacientes gestantes o en período de lactancia
  \n13.Mujeres con capacidad de concebir que no puedan o no deseen emplear métodos anticonceptivos
  \n14.Incapacidad o rechazo a cumplir con el protocolo del estudio o a colaborar plenamente con el investigador o el profesional que él designe
  \n15.Síndrome de malabsorción, patologías que afecten de forma significativa a la función gastrointestinal o resección gástrica o del intestino delgado. Las pacientes con colitis ulcerosa también quedarán excluidas del estudio
  \n16.Tratamiento antineoplásico neoadyuvante simultáneo (quimioterapia, radioterapia, inmunoterapia o terapias biológicas, exceptuando los tratamientos del ensayo)
  \n17.Tratamiento simultáneo con inhibidores o inductores del CYP3A4",
             *
             *"countries": [
    {
      "country_name": "Spain",
      "status": "Completed"
    }
  ],
             * 
             */
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: EU CTR registry entry";
            string ob_title = display_title + " :: EU CTR registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "EU CTR registry entry", null, ob_title,
	            null, 9, 2013, 23, 13, 100123, "EU Clinical Trials Register", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
	            "https://www.clinicaltrialsregister.eu/ctr-search/trial/2013-001036-22/ES", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2013 Jul 12", 2013, 7, 12, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
        }

        
        if (sd_sid == "2015-000556-14")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Vaccination with dendritic cells pulsed with autologous tumorhomogenate in combination with HD-IL2 and immunomodulating radiotherapy in metastatic RCC: a phase II trial (RENALVax-2)";
	        string brief_desc = "Primary objectives: Overal Response Rate by irRC";
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2016, 2, 11, 22, null, 900,
		        18, 17, null, null, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "IRST189.03", 14, null, 
		        "ISTITUTO SCIENTIFICO ROMAGNOLO PER LO STUDIO E LA CURA DEI TUMORI (IRST) SRL IRCCS", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid,
		        "Vaccination with dendritic cells pulsed with autologous tumorhomogenate in combination with HD-IL2 and immunomodulating radiotherapy in metastatic RCC: a phase II trial (RENALVax-2)", 
		        15, "it", 22, false, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid,
		        "Vaccination with dendritic cells pulsed with autologous tumor homogenate in combination with HD-IL2 and immunomodulating radiotherapy in metastatic RCC: a phase II trial (RENALVax-2)", 
		        16, "en", 11, false, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid, "RENALVax-2", 14, "en", 11, false, "From the EU CTR"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "ISTITUTO SCIENTIFICO ROMAGNOLO PER LO STUDIO E LA CURA DEI TUMORI (IRST) SRL IRCCS", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "IRST-IRCCS", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "DC-VACCINE_IRSTIRCCS", null, null, "D000077341", "Lapatinib"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "IL2_IRSTIRCCS", null, null, "D000077289", "Letrozol"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "metastatic renal cancer", null, null, 
		        null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "carcinoma renale metastatico", null, null, 
		        null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Metastatic renal cell carcinoma", 16, "10050513", 
		        null, null));
	        
           // countries
            
            // iec
            /*
             * "inclusion_criteria":
             * "1. Firma del consenso informato: I pazienti devono essere disposti e capaci a fornire il proprio consenso informato scritto prima di ogni altra procedura di screening prevista per lo studio.
             * 2. Disponibilità di materiale tumorale raccolto e conservato secondo le procedure del Laboratorio di Terapia Cellulare Somatica IRST.
             * 3. Diagnosi istologica o citologica confermata di RCC (tutte le istologie tranne carcinoma uroteliale)
             * 4. Stadio IV, in progressione dopo almeno una linea di terapia con TKI e/o antiangiogenetici e/o inibitori di mTOR (i pazienti dovranno aver terminato i precedenti trattamenti almeno 4 settimane prima della prima dose di IL-2)
             * 5. I pazienti dovranno avere almeno una lesione misurabile, secondo i criteri di risposta irRC (vedere sezione 8), dopo asportazione del tessuto tumorale per la preparazione dei vaccini. Le lesioni tumorali che verranno irradiate sono esclusi dalla valutazione della risposta.
             * 6. Aspettativa di vita superiore a 3 mesi
             * 7. ECOG performance status 0-1
             * 8. Funzionalità midollare e d’organo definite come:-leucociti>4000/L-neutrofili >1,500/L-piastrine>100,000/L-bilirubina totale nei limiti della norma (nil)- AST(SGOT)/ALT(SGPT) <2.5 X institutional upper limit of normal- creatinina< 1.5 mg/dl- emoglobina >8.0 gm/dl- ematocrito <30%
             * 9. ECG ed ecocardiogramma nella norma
             * 10. Normale funzionalità polmonare
             * 11. Non controindicazioni nell’uso di agenti vasopressori
             * 12. Test per HIV, HBV HCV e sifilide negativi non più vecchi di 30 giorni prima dell’esecuzione di qualunque procedura GCP.
             * 13. Uomini e donne di età superiore a 18 anni.",
  "exclusion_criteria": 
  "1. I pazienti che hanno test positivi per HCV, HBV, HIV, o sifilide (test ematici specifici devono essere effettuati entro 30 giorniprima di qualsiasi attività regolamentata dalle GMP).
  2. I pazienti che non hanno avuto precedenti linee di terapia sistemica per malattia avanzata.
  3. Partecipazione ad un altro studio clinico con eventuali farmaci sperimentali nei 30 giorni precedenti allo screening per questo studio.
  4. malattia non controllata intercorrente tra cui, ma non solo, l'infezione in corso o attiva, insufficienza cardiaca congestizia sintomatica, angina pectoris instabile, aritmia cardiaca, o malattia psichiatrica / situazioni sociali che limiterebbero la conformitàcon i requisiti di studio (a giudizio del medico).
  5. Altre note patologie neoplastiche maligne nella storia clinica del paziente, con un intervallo libero da malattia di meno di 3 anni (tranne che per il carcinoma a cellule basali e carcinoma in situ della cervice uterina trattati precedentemente);
  6. Precedente chemioterapia, radioterapia o immunoterapia entro 4 settimane (6 settimane per nitrosouree o mitomicina C) prima di entrare nello studio o pazienti che non hanno recuperato da eventi avversi a causa di agenti somministrati più di 4 settimane prima.
  7. I pazienti con note metastasi cerebrali dovrebbero essere esclusi da questo studio clinico a causa della loro scarsa prognosi eperché spesso sviluppano una progressiva disfunzione neurologica che confonderebbe la valutazione degli eventi avversi di tiponeurologico e non.
  8. Storia di reazioni allergiche attribuite a composti chimici o biologici simili all'IL-2 o ad altri agenti utilizzati nello studio.
  9. Ogni malattia autoimmune che potrebbe essere aggravata da IL-2
  10. Una condizione medica che richiede trattamenti cronici con corticosteroidi o altri farmaci immunosoppressori
  11. Una storia di malattia cardiovascolare significativa, tra cui infarto miocardico, insufficienza cardiaca congestizia, aritmiecardiache primarie, angina pectoris o incidente cerebrovascolare
  12. HIV-positività, anche sintomatica13. Qualsiasi controindicazione a sottoporsi a leucaferesi, come valutato dal transfusionista (ad esempio una grave anemia, piastrinopenia, terapia anticoagulante orale) o a sottoporsi ad un intervento chirurgico.",
             *
             *"countries": [
    {
      "country_name": "Italy",
      "status": "Prematurely Ended"
    }
             * 
             */
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: EU CTR registry entry";
            string ob_title = display_title + " :: EU CTR registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "EU CTR registry entry", null, ob_title,
	            null, 9, 2017, 23, 13, 100123, "EU Clinical Trials Register", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
	            "https://www.clinicaltrialsregister.eu/ctr-search/trial/2015-000556-14/IT", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2017 Dec 15", 2017, 12, 15, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
           
        }
        
        return null;
    }
}