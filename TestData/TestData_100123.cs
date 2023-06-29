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