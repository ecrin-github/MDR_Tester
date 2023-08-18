using System.Text;

namespace MDR_Tester;

public class TestData_100123 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
	    
        if (sd_sid == "2004-001569-16")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "EFFICIENCY AND SAFETY OF CLINAVIT PAEDIATRIC AT A WEIGHT DEPENDANT DOSE ADMINISTERED DAILY FOR 5 CONTINUOUS DAYS ON 4 VITAMINS BLOOD LEVEL IN NEONATES AND CHILDREN UP TO 11 YEARS OF AGE ";
	        display_title += "RECEIVING PARENTERAL NUTRITION. A PROSPECTIVE, MULTICENTRE, RANDOMISED, COMPARATIVE, DOUBLE BLIND PHASE III STUDY IN THERAPEUTIC USE VERSUS SOLUVIT AND VITALIPID INFANT CARRIED OUT IN PARALLEL GROUPS.   EFICACIA Y ...";
	        StringBuilder sb = new StringBuilder("Main objective : To confirm that Clinavit Paediatric is an efficient and safe alternative to Soluvit and Vitalipid Infant, the current vitamins cocktail used for ");
	        sb.Append("parenteral nutrition supplementation in neonates, infants and children up to 11 years of age, through the assessment of:·	The blood levels of the most commonly explored vitamins "); 
	        sb.Append("in literature as surrogate markers of effective intake,·	The vital signs and adverse events occurring within the 5-day treatment period.");
	        sb.Append("\nPrimary endpoints: Efficiency criteria:Plasma level of 2 oil-soluble vitamins (A and E) and 2 water-soluble ones ");
	        sb.Append("(folates and B12) as surrogate markers of effective intake. Blood levels of retinol binding protein and lipids ");
	        sb.Append("(total cholesterol and triglycerides) as carriers of vitamin A and E respectively and total proteins, as carrier ");
	        sb.Append("for other vitamins, will be examined in case of abnormal vitamins blood level values.Safety criteria: Vital signs and adverse events");
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2006, 7, 11, 25, null, 900,
		        0, 14, 11, 17, 7);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "VITPED/P01/04/MU.UK", 14, null, 
		        "BAXTER SAS R&D Parenteral Nutrition", null, null, null));
	        
	        string title = "EFFICIENCY AND SAFETY OF CLINAVIT PAEDIATRIC AT A WEIGHT DEPENDANT DOSE ADMINISTERED DAILY FOR 5 CONTINUOUS DAYS ON 4 VITAMINS BLOOD LEVEL IN NEONATES AND CHILDREN UP TO 11 YEARS OF AGE ";
	        title += "RECEIVING PARENTERAL NUTRITION. A PROSPECTIVE, MULTICENTRE, RANDOMISED, COMPARATIVE, DOUBLE BLIND PHASE III STUDY IN THERAPEUTIC USE VERSUS SOLUVIT AND VITALIPID INFANT CARRIED OUT IN PARALLEL GROUPS.";
	        title += "   EFICACIA Y SEGURIDAD DE CLINAVIT PEDIÁTRICO,  A UNA  DOSIS DEPENDIENTE DEL PESO, ADMINISTRADO A DIARIO DURANTE 5 DÍAS CONSECUTIVOS, MEDIDAS ";
	        title += "POR LA CONCENTRACIÓN SANGUÍNEA DE 4 VITAMINAS EN NEONATOS Y NIÑOS DE HASTA 11 AÑOS DE EDAD TRATADOS CON NUTRICIÓN ";
	        title +=
		        "PARENTERAL. ESTUDIO EN FASE III PROSPECTIVO, MULTICÉNTRICO, ALEATORIZADO, COMPARATIVO, ABIERTO Y DE GRUPOS PARALELOS EN USO TERAPÉUTICO FRENTE A SOLUVIT Y VITALIPID INFANT.";
	        fs.titles!.Add(new StudyTitle(sd_sid, title, 16, "en", 11, true, "From the EU CTR"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "BAXTER SAS R&D Parenteral Nutrition", null));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 510));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Clinavit Pediatric", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Vitalipid infant", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "soluvit", null, null, null, null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, 
		        "No special medical condition but Patient requiring for any underlying pathology at least 5 days of total parenteral nutrition, representing at least 90% of their total energy needs", 
		        null, null, null, null));

	        sb = new StringBuilder("·In or out patients of both genders,·\tAged up to 11 years of age at the first visit,");
	        sb.Append("·\tPatient requiring for any underlying pathology at least 5 days of total parenteral nutrition, representing at least 90% of their total energy needs,");
	        sb.Append("·\tPatient to be supplemented by intravenous vitamins,");
	        sb.Append("·\tPatient whose parents or legal representative have freely given their written informed consent.");
	        
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1001, "none", "All", 0, "n.0A", sb.ToString()));	     
	        
	        sb = new StringBuilder("·Known HIV infection,·\tKnown pre-existing hypervitaminosis,");
	        sb.Append("·\tKnown hypersensitivity to intravenous vitamins, or any excipients of the preparation,");
	        sb.Append("·Participation in another clinical trial within a month prior to the first visit, ");
	        sb.Append("·Patient with any underlying pathology at risk of foreseeable drop out before the 6th day,");
	        sb.Append("·\tPatients requiring treatment by anticonvulsants (barbiturics or phenytoin),");
	        sb.Append("·Patients requiring an extra supplementation by products containing vitamins, whatever the route,");
	        sb.Append("·\tPrevious inclusion in this study,");
	        sb.Append("·\tParents or legal representative’s potential non-cooperation or unwillingness to comply fully with the protocol.");
	       
	        fs.iec!.Add(new StudyIEC(sd_sid, 2, 1002, "none", "All", 0, "e.0A", sb.ToString()));

	        fs.countries!.Add(new StudyCountry(sd_sid, 2510769, "Spain", 25));
            
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
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "30 Jun 2006", 2006, 6, 30, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        
        if (sd_sid == "2009-011622-34")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "An open label non-randomized extension study to evaluate the safety and tolerability of AIN457 (anti interleukin-17 monoclonal antibody) in patientswith psoriatic arthritis";
	        StringBuilder sb = new StringBuilder("Primary objectives: To assess the safety and tolerability of AIN457 administered i.v. initially up to six months (Part 1) with a ");
	        sb.Append("possible extension of a further 6 months (Part 2) in patients with psoriatic arthritis who participated in the core CAIN457A2206 phase II proof-of-concept study");
	        sb.Append("\nPrimary endpoints: Safety and tolerability.");
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2010, 4, 11, 21, null, 900,
		        18, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "CAIN457A2206E1", 14,100189, 
		        "Novartis", "https://ror.org/02f9zrr09", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 16, "en", 11, true, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A2206E1", 14, "en", 11, false, "From the EU CTR"));

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100189, "Novartis", "https://ror.org/02f9zrr09"));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "AIN457", null, null, null, null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Psoriatic arthritis (PsA), which belongs to seronegative spondyloarthropathies (SpA).", 
		        null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Psoriatic arthritis", 16, "10037160", "FA21", "Psoriatic arthritis"));
            
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "1.", 1, "n.01", "Patients who participate and complete the core CAIN457A2206 study up to and including the EoS i.e. Visit 16 (Week 24), may enter the extension study upon signing informed consent."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "2.", 1, "n.02", "Patients who discontinued the core study due to unsatisfactory therapeutic effect at their Visit 14 (Week 16) or a later visit may enter the extension study within three weeks of completing the study discontinuation visit of the core study, provided that at their discontinuation visit they meet the criteria below. Patients who do not enter the extension study within 3 weeks of completing the study discontinuation visit of the core study, will have an additional baseline visit (Visit 17) and must meet the criteria below::"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "split", "•", 3, "n.02.01.01", "The number of tender joints is the same or more than the core study baseline OR,"));	
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "split", "•", 3, "n.02.01.02","The number of swollen joints is the same or more than the core study baseline OR,"));	
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "split", "•", 3, "n.02.01.03", "There is no improvement compared with the core study baseline in at least three of the following five domains: patient global assessment, physician global assessment, patient pain assessment, Health Assessment Questionnaire and CRP."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr", "3.", 1, "n.03", "Women of childbearing potential must be using simultaneously double-barrier or two highly effective methods of contraception, (e.g. intra-uterine device plus condom,diaphragm plus condom, etc; hormone replacement as either oral or implantable isacceptable as one form), from the time of screening for the duration of the entire study, up to study completion and up to 16 weeks post last drug administration. Periodic abstinence (e.g. calendar, ovulation, symptothermal, post-ovulation methods) and withdrawal are not acceptable methods of contraception."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr", "4.", 1, "n.04", "Male patients willing to use simultaneously two highly effective methods of contraception (e.g. intra-uterine device plus condom) for the duration of the entire study, up to study completion visit and up to 16 weeks post the last drug administration. Periodic abstinence and withdrawal are not acceptable methods of contraception."));	
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr", "1.", 1, "e.01", "Patients for whom continued treatment with AIN457 in the extension is not considered appropriate by the treating physician."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "2.", 1, "e.02", "Patients who were non-compliant or who demonstrated a major protocol deviation in the core CAIN457A2206 study."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "3.", 1, "e.03", "Patients who discontinued from the core CAIN457A2206 study before Visit 14 (Week 16)"));
	        fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "4.", 1, "e.04", "Female patients who are pregnant or lactating."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr", "5.", 1, "e.05", "Any active systemic infection within the past 2 weeks including a positive chest X-ray."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr", "6.", 1, "e.06", "Positive human immunodeficient virus (HIV: ELISA and Western blot) test result,Hepatitis B surface antigen (HBsAg) or Hepatitis C test result, where patients have been re-tested."));	
	        fs.iec.Add(new StudyIEC(sd_sid, 14, 302, "cr", "Hdr", 1, "e.07", "The following Exclusion Criteria as defined in the core trial [CAIN457A2206] will continue to be valid with minor revisions:"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr", "7.", 1, "e.08", "Positive Purified Protein Derivative (PPD) tuberculin skin test of ≥ 5 mm at baseline, (where patients have been re-tested). A positive PPD test will be defined using the MMWR 2000 guidance, summarized as criteria for tuberculin positivity by risk group. A PPD test should not be done in subjects who had a tuberculosis vaccination in the past. These subjects will be eligible to participate if – according to local guidelines – latent tuberculosis can be excluded. For those study sites using QuantiFeron test a positive test at baseline (where patients have been re-tested) will exclude the subject from the participation in the study. If the result for either PPD or QuantiFeron test is indeterminate the subject will be excluded."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr", "8.", 1, "e.09", "For previous use of immunosuppressive agents a wash-out period of at least 1 month or 5 half-lives, whatever is longer, is required. Immunosuppressive agent include but are not limited to cyclosporine, mycophenolate, tacrolimus, and 5-aminosalicylic acid (5-ASA)."));
	        fs.iec.Add(new StudyIEC(sd_sid, 17, 302, "cr", "Hdr", 1, "e.10", "If on previous treatment with anti-TNF-α therapy (or other biological therapy), thefollowing washout periods will be required for such patients to be eligible to participate in the trial."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "split", "•", 3, "e.10.01.01", "Six (6)-months wash out prior to dosing for alefacept, rituxan and raptiva,"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "split", "•", 3, "e.10.01.02", "Three (3)-months washout prior to baseline for adalimumab and certolizumab,"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "split", "•", 3, "e.10.01.03", "Two (2)-months washout prior to baseline for etanercept and infliximab."));
	        fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "split", "•", 3, "e.10.01.04", "One (1) month washout prior to baseline for systemic immunosuppressants including, but not limited to azathioprine, cyclosporine and leflunomide.Patients on concomitant prednisone, Methotrexate (MTX) or SSZ can be included,whereby:"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "split", "•", 3, "e.10.01.05", "Prednisone should be kept at a stable dose 4 weeks before baseline and throughout the study and not exceed 10 mg/day."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr", "•", 2, "e.10.02", "MTX should be kept at a stable dose 4 weeks before baseline and throughout thestudy and not exceed 25 mg/week."));
	        fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr", "•", 2, "e.10.03", "SSZ should be kept at a stable dose 4 weeks before baseline and throughout the study"));
	        fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr", "9.", 1, "e.11", "Patients who are on NSAIDS should be kept at a stable dose 4 weeks before baseline and throughout the study."));	 
	      
	        fs.countries!.Add(new StudyCountry(sd_sid, 2921044, "Germany", 21));
	        fs.countries.Add(new StudyCountry(sd_sid, 2635167, "United Kingdom", 21));
	        
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
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "5 Jan 2010", 2010, 1, 5, null, null, null, null));
	       
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
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "15 Dec 2016", 2016, 12, 15, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "15 Dec 2016", 2016, 12, 15, null, null, null, null));
			
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
	        StringBuilder sb = new StringBuilder("Main Objective: Safety run-in part: To determine the recommended phase 3 dose regimen (RP3R) of canakinumab in combination with pembrolizumab plus platinum-based doublet chemotherapy. \n");
	        sb.Append("Double-blind, randomized, placebo-controlled part: To compare progression free survival (PFS) by local investigator assessment as per RECIST 1.1 and overall survival (OS) between the two treatment arms.");
	        sb.Append("\nPrimary end point(s): Safety run-in part: Incidence of dose limiting toxicities in the first 42 days of study treatment. ");
	        sb.Append("\nDouble-blind, randomized, placebo-controlled part: PFS based on local investigator assessment as per RECIST 1.1 and OS");
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

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 112, 100189, "Novartis", "https://ror.org/02f9zrr09"));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 510));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "canakinumab", 23, "914613-48-2", "C541220", "canakinumab"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "pembrolizumab", 23, "1374853-91-4", "C582435", "pembrolizumab"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "cisplatin", 23, "15663-27-1", "D002945", "Cisplatin"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "carboplatin", 23, "41575-94-4", "D016190", "Carboplatin"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "paclitaxel", 23, "33069-62-4", "D017239", "Paclitaxel"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "nab-paclitaxel", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "pemetrexed", 23, "137281-23-3", "D000068437", "Pemetrexed"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Non-small cell lung cancer", 16, "10061873", 
		           "2C25", "Malignant neoplasms of bronchus or lung"));
	        fs.conditions.Add(new StudyCondition(sd_sid, 
		        "stages AJCC v. 8 IIIB/IIIC (not eligible for definite chemoradiationtherapy) or stage IV (metastatic) non-small cell lung cancer (NSCLC)", 
		        null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, 
		        "stages AJCC v. 8 IIIB/IIIC (not eligible for definite chemoradiation therapy) or stage IV (metastatic) non-small cell lung cancer (NSCLC)", 
		        null, null, null, null));
	        
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "1.", 1, "n.01", "Histologically confirmed locally advanced or metastatic NSCLC"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "2.", 1, "n.02", "Measurable disease by RECIST 1.1"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "3.", 1, "n.03", "Known PD-L1 status"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr", "4.", 1, "n.04", "ECOG performance status (PS) ≤ 1."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr", "5.", 1, "n.05", "Other protocol-defined inclusion criteria may apply."));	    
            
            fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr", "1.", 1, "e.01", "Previous immunotherapy or treatment with IL-1β inhibitor."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr", "2.", 1, "e.02", "Subjects with epidermal growth factor receptor (EGFR) sensitizing mutations and/or ALK rearrangement"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr", "3.", 1, "e.03", "History of severe hypersensitivity reaction to monoclonal antibodies, platinum containing drugs, nab-paclitaxel, paclitaxel, pemetrexed or any known excipients of these drugs"));
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "4.", 1, "e.04", "Other protocol-defined exclusion criteria may apply."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "5.", 1, "e.05", "Known active central nervous system (CNS) metastases and/or carcinomatous meningitis."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "6.", 1, "e.06", "Presence or history of a malignant disease, other than NSCLC, that has been diagnosed and/or required therapy within the past 3 years prior to randomization."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr", "7.", 1, "e.07", "Active autoimmune disease that has required systemic treatment in the past 2 years prior to randomization (i.e. with use of disease modifying agents, corticosteroids or immunosuppressive drugs).Control of the disorder with replacement therapy (e.g., thyroxine, insulin, or physiologic corticosteroid replacement therapy for adrenal or pituitary insufficiency, etc) is permitted."));	   
            fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr", "13.", 1, "e.08", "History of (non-infectious) pneumonitis that required steroids or current pneumonitis."));	            
           
            fs.countries!.Add(new StudyCountry(sd_sid, 2921044, "Germany", 25));
            fs.countries.Add(new StudyCountry(sd_sid, 2635167, "United Kingdom", null));             
            fs.countries.Add(new StudyCountry(sd_sid, 3017382, "France", 25));
            fs.countries.Add(new StudyCountry(sd_sid, 3077311, "Czechia", null));  // in twice in source data - takes the later value for status
            fs.countries.Add(new StudyCountry(sd_sid, 2750405, "Netherlands", 21));
            fs.countries.Add(new StudyCountry(sd_sid, 390903, "Greece", 25));
            fs.countries.Add(new StudyCountry(sd_sid, 2510769, "Spain", 25));
            fs.countries.Add(new StudyCountry(sd_sid, 2629691, "Iceland", 25));
            fs.countries.Add(new StudyCountry(sd_sid, 3057568, "Slovakia", 25));
            fs.countries.Add(new StudyCountry(sd_sid, 2782113, "Austria", 25));
            fs.countries.Add(new StudyCountry(sd_sid, 2264397, "Portugal", 25));
            fs.countries.Add(new StudyCountry(sd_sid, 2623032, "Denmark", 21));
            fs.countries.Add(new StudyCountry(sd_sid, 660013, "Finland", 21));
            fs.countries.Add(new StudyCountry(sd_sid, 2661886, "Sweden", 25));
            fs.countries.Add(new StudyCountry(sd_sid, 719819, "Hungary", 25));
            fs.countries.Add(new StudyCountry(sd_sid, 3175395, "Italy", 25));
            fs.countries.Add(new StudyCountry(sd_sid, 798549, "Romania", 25));
	        fs.countries.Add(new StudyCountry(sd_sid, 2017370, "Russia", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 1880251, "Singapore", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 1819730, "Hong Kong", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 1733045, "Malaysia", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 1605651, "Thailand", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 1562822, "Vietnam", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 1814991, "China", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 3469034, "Brazil", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 3595528, "Guatemala", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 1835841, "South Korea", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 798544, "Poland", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 3895114, "Chile", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 3686110, "Colombia", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 3865483, "Argentina", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 1861060, "Japan", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 1694008, "Philippines", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 2658434, "Switzerland", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 1269750, "India", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 272103, "Lebanon", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 6251999, "Canada", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 3077311, "Czechia", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 298795, "Turkey", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 3144096, "Norway", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 1668284, "Taiwan", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 3996063, "Mexico", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 953987, "South Africa", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 2077456, "Australia", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 3932488, "Peru", null));
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: EU CTR registry entry";
            string ob_title = display_title + " :: EU CTR registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "EU CTR registry entry", null, ob_title,
	            null, 9, 2019, 23, 13, 100123, "EU Clinical Trials Register", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
	            "https://www.clinicaltrialsregister.eu/ctr-search/trial/2018-001547-32/DK", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "24 May 2019", 2019, 5, 24, null, null, null, null));
	       
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
	        sb.Append("\nPrimary endpoints: The primary endpoint is to determine the efficacy of mifamurtide treatment according to biological and radiological markers of response.");
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2014, 11, 11, 21, null, 900,
		        12, 17, 64, 17, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "OCTO_039", 14, 100253, "University of Oxford", 
		        "https://ror.org/052gg0110", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A Mechanistic Study Of Mifamurtide (MTP-PE) In Patients With Metastatic And/Or Recurrent Osteosarcoma", 16, "en", 11, false, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid, "MEMOS", 14, "en", 11, false, "From the EU CTR"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100253, "University of Oxford", "https://ror.org/052gg0110"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "Millennium Pharmaceuticals, Inc, a wholly-owned subsidiary of Takeda Pharmaceutical Company Limited", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "EU frame grant", null));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "mifamurtide", 23, "83461-56-7", "C037144", "mifamurtide"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Ifosfamide", 23, "3778-73-2", "D007069", "Ifosfamide"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Relapsed or metastatic osteosarcoma", null, null, 
		        null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Osteosarcoma", 16, "10031291", null, null));
	        
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 301, "seq", "Hdr", 1, "n.01.01", "A patient will be eligible for inclusion in this study if all of the following criteria apply."));	
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "seq", "1.", 1, "n.01.02", "Relapsed osteosarcoma (first, second, third or any relapse, patient has recovered from chemotherapy and any other investigational drug/agent treatment, radiotherapy or surgical procedure)."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "seq", "2.", 1, "n.01.03", "Histological confirmed diagnosis of osteosarcoma at original presentation."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "seq", "3.", 1, "n.01.04", "Tumour at biopsy accessible or resectable site."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "seq", "4.", 1, "n.01.05", "Progressive disease documented by imaging within 3 months of entry into the trial."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "seq", "5.", 1, "n.01.06", "At least one measurable lesion on CT scan (RECIST) performed in past 21 days prior to trial entry."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "seq", "6.", 1, "n.01.07", "Male or female, age ≥ 16 years to 65 (or ≥18 based on institutional practice for Teenage and Young Adult Cancer patients)."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "seq", "7.", 1, "n.01.08", "Life expectancy of at least 3 months."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "seq", "8.", 1, "n.01.09", "WHO performance score of 0 – 2."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "seq", "9.", 1, "n.01.10", "The patient is willing and able to comply with the protocol and scheduled follow-up visits and examinations."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 11, 1, "seq", "10.", 1, "n.01.11", "Written (signed and dated) informed consent."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 12, 1, "seq", "11.", 1, "n.01.12", "Cardiac shortening fraction ≥ 28% or ejection fraction ≥ 45%"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 13, 1, "seq", "12.", 1, "n.01.13", "Renal function is adequate for ifosfamide treatment (GFR as per table below, other renal function screening tests as per local practice)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 14, 1, "seq", "13.", 1, "n.01.14", "Haematological and biochemical indices within the ranges detailed in the protocol"));	    
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 15, 302, "seq", "Hdr", 1, "e.01.01", "Patient will not be eligible for the trial if any of the following apply:"));	
	        fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "seq", "1.", 1, "e.01.02", "Pregnant or breast-feeding woman. Men or women of childbearing potential unless effective methods of contraception are used during study treatment and for at least 7 days after the last mifamurtide dose."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "seq", "2.", 1, "e.01.03", "Previous treatment with mifamurtide or a mifamurtide-like drug* in a clinical trial setting for the treatment of metastatic and/or recurrent osteosarcoma in the six months prior to registration."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "seq", "3.", 1, "e.01.04", "Contraindications to lung biopsies"));
	        fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "seq", "4.", 1, "e.01.05", "Hypersensitivity to ifosfamide or any component of the formulation."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "seq", "5.", 1, "e.01.06", "Previously diagnosed brain metastases."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 21, 302, "seq", "Hdr", 1, "e.01.07", "Significant active cardiac disease including:"));
	        fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "seq", "6.", 1, "e.01.08",  "uncontrolled high blood pressure (no greater than 2 standard deviations above the mean for age for systolic blood pressure (SBP) and diastolic blood pressure (DBP), unstable angina, congestive heart failure, myocardial infarction within the previous 6 months, or serious cardiac arrhythmias and with a history of pericarditis and myocarditis"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "seq", "7.", 1, "e.01.09", "Treatment with any other investigational agent, or participation in another interventional clinical trial within 21 days prior to enrolment."));	   
	        fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "seq", "8.", 1, "e.01.10", "Major surgery within 21 days prior first study biopsy"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "seq", "9.", 1, "e.01.11", "Currently taking of high-dose non-steroidal anti-inflammatory drugs (NSAIDs) or corticosteroid treatment"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "seq", "10.", 1, "e.01.12", "Concurrent use of ciclosporin or other calcineurin inhibitors."));
	        fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "seq", "11.", 1, "e.01.13", "Any psychological, social or medical condition, physical examination finding or a laboratory abnormality that the Investigator considers would make the patient a poor trial candidate or could interfere with protocol compliance or the interpretation of trial results."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "seq", "12.", 1, "e.01.14", "Any other active malignancy, with the exception of adequately treated cone-biopsied in situ carcinoma of the cervix uteri and non-melanoma skin lesions."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "seq", "13.", 1, "e.01.15", "Patients who are known to be serologically positive for Hepatitis B, Hepatitis C or HIV.* mifamurtide-like drugs include GMCSF, interferon and other macrophage activating molecules."));	    
	        
	        fs.countries!.Add(new StudyCountry(sd_sid, 3175395, "Italy", 21));
            fs.countries.Add(new StudyCountry(sd_sid, 2750405, "Netherlands", 21));
            fs.countries.Add(new StudyCountry(sd_sid, 2921044, "Germany", 21));
            
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
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "10 Sep 2014", 2014, 9, 10, null, null, null, null));
	       
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
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "16 Aug 2017", 2017, 8, 16, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "16 Aug 2017", 2017, 8, 16, null, null, null, null));
			
            fs.data_objects!.Add(sdo);
	        
            // 3) Results Summary
	        
            sd_oid = sd_sid + " :: 79 :: CSR summary - PDF DL";
            ob_title = display_title + " :: CSR summary";
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
	        sb.Append(
		        "\nPrimary endpoints: Comparison between the PAM50 HER2-enriched versus non HER2-enriched cases to achieve pCRB from dual HER2 blockade with lapatinib and trastuzumab at the time of surgery.");
	        
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2013, 10, 11, 21, null, 905,
		        18, 17, null, null, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "SOLTI-1114", 14, null, 
		        "SOLTI", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid,
		        "PAM50 HER2-enriched phenotype as a predictor of early response to neoadjuvant lapatinib plus trastuzumab in Stage I to IIIA HER2-positive breast cancer", 
		        16, "en", 11, false, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid, "PAMELA", 14, "en", 11, false, "From the EU CTR"));

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "SOLTI", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 100163, "GlaxoSmithKline", "https://ror.org/01xsqw823"));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Tyverb", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Letrozol", 23, "112809-51-5", null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Citrato de Tamoxifeno", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Trastuzumab", 23, "180288-69-1", "D000068878", "Trastuzumab"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "PACLITAXEL", 23, "33069-62-4", "D017239", "Paclitaxel"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "HER-2 positive breast cancer", 16, "10065430", 
		        null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Untreated invasive breast carcinoma eligible for primary definitive surgery (Stage I-IIIA)",  
		        null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Carcinoma de mama invasivo, inicial, y apto para la cirugía definitiva (Fase I-IIIA)",  
		        null, null, null, null));
	        
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "1.", 1, "n.01", "Consentimiento informado por escrito para todos los procedimientos del estudio, de acuerdo con los requerimientos legales locales, antes de iniciar cualquier procedimiento específico del protocolo"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "2.", 1, "n.02", "Carcinoma de mama invasivo no tratado, elegible para cirugía definitiva primaria (estadios I-IIIa)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "3.", 1, "n.03", "Carcinoma de mama invasivo confirmado histológicamente, con todas las características siguientes:"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr", "a.", 2, "n.03.01", "Tumor primario ?1cm en su diámetro mayor"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr", "b.", 2, "n.03.02", "cN0-2"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr", "c.", 2, "n.03.03", "Sin evidencias de metástasis a distancia (M0)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr", "4.", 1, "n.04", "CM invasivo HER2+, definido por las guías del CAP como:"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr", "a.", 2, "n.04.01", "sobreexpresión 3+ por IHQ (tinción uniforme e intensa de la membrana de >30% de las células tumorales invasivas) o"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "cr", "b.", 2, "n.04.02", "sobreexpresión 2+ o 3+ (en un 30% o menos de las células neoplásicas) por IHQ y amplificación génica de HER2 por hibridación in situ (ISH; >6 copias del gen HER2 por núcleo, o un cociente entre las pruebas de ISH [copias del gen HER2 respecto a señales en el cromosoma 17] >2,2)"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "cr", "5.", 1, "n.05", "Pacientes mujeres"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 11, 1, "cr", "6.", 1, "n.06", "Edad ?18 años"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 12, 1, "cr", "7.", 1, "n.07", "Estado funcional del ECOG de 0 ó 1"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 13, 1, "cr", "8.", 1, "n.08", "Función orgánica adecuada, definida por:"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 14, 1, "cr", "a.", 2, "n.08.01", "Recuento absoluto de neutrófilos (RAN) ?1,5 x 109/l"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 15, 1, "cr", "b.", 2, "n.08.02", "Hemoglobina (Hg) ?10 g/dl"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 16, 1, "cr", "c.", 2, "n.08.03", "Plaquetas >100.000/mm3"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 17, 1, "cr", "d.", 2, "n.08.04", "Creatinina ?1,6 mg/dl"));	
	        fs.iec.Add(new StudyIEC(sd_sid, 18, 1, "cr", "e.", 2, "n.08.05", "ALT y AST ?2,5 x LSN,"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 19, 1, "cr", "f.", 2, "n.08.06", "Fosfatasa alcalina ?5 LSN"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 20, 1, "cr", "g.", 2, "n.08.07", "Bilirrubina total ?1,5 mg/dl"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 21, 1, "cr", "9.", 1, "n.09", "Fracción de eyección del ventrículo izquierdo (FEVI) basal ?50%, determinada mediante ecocardiograma (ECO) o ventriculografía isotópica (MUGA)."));
	        fs.iec.Add(new StudyIEC(sd_sid, 22, 1, "cr", "10.", 1, "n.10", "En las mujeres premenopáusicas con capacidad reproductiva (biológicamente fértiles) y en aquellas cuya menopausia se haya producido con una anterioridad menor a 12 meses: prueba de embarazo de ?-HCG (en suero) negativa. Todas las pacientes biológicamente fértiles deberán estar de acuerdo en utilizar un método anticonceptivo fiable y comprometerse a emplearlo desde las 2 semanas previas a la administración de la primera dosis del producto en investigación hasta 28 días después de haber recibido la última dosis del mismo."));
	        fs.iec.Add(new StudyIEC(sd_sid, 23, 1, "cr", "11.", 1, "n.11", "Ausencia de anomalías psicológicas, familiares, sociológicas o geográficas que potencialmente puedan dificultar el cumplimiento del protocolo del estudio y la pauta de seguimiento. Estas anomalías deberán ser discutidas con la paciente antes de su inclusión en el estudio."));
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr", "1.", 1, "e.01", "Cáncer de mama inoperable en estadio III (p.ej., tumores T4 y/o N3)"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr", "2.", 1, "e.02", "Pacientes con enfermedad localmente avanzada, o aquellas en quienes se considere apropiada la quimioterapia de primera línea con taxanos y antraciclinas como tratamiento neoadyuvante óptimo"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr", "3.", 1, "e.03", "Quimioterapia, radioterapia o cirugía previas para el cáncer de mama invasivo, a excepción de la resección de tumor en la mama contralateral y a condición de que la paciente no haya recibido previamente radio o quimioterapia adyuvantes"));
	        fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "cr", "4.", 1, "e.04", "Pacientes con una segunda neoplasia activa simultánea, a excepción del cáncer de piel distinto del melanoma tratado satisfactoriamente, del melanoma in situ o del carcinoma in situ de cérvix. Las pacientes con otras neoplasias malignas no mamarias deberán haber permanecido sin enfermedad durante 5 años como mínimo"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "cr", "5.", 1, "e.05", "Presencia o sospecha de reacción de hipersensibilidad a cualquier fármaco en investigación o compuesto terapéutico, o a sus excipientes"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "cr", "6.", 1, "e.06", "Insuficiencia cardiaca congestiva concomitante o FEVI <50%"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 30, 2, "cr", "7.", 1, "e.07", "Enfermedades cardiovasculares clínicamente significativas (es decir, activas): accidente vascular cerebral (<6 meses previamente a la inclusión), angina inestable, infarto de miocardio ?6 meses antes de la inclusión, hipertensión no controlada (presión sistólica >150 mmHg y/o diastólica >100 mmHg) y arritmias de alto riesgo no controladas"));	   
	        fs.iec.Add(new StudyIEC(sd_sid, 31, 2, "cr", "8.", 1, "e.08", "Diabetes mellitus no controlada, úlcera péptica activa o epilepsia no controlada"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 32, 2, "cr", "9.", 1, "e.09", "Infecciones activas no controladas presentes en el momento de la inclusión"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 33, 2, "cr", "10.", 1, "e.10", "Antecedentes de comorbilidades significativas que, a juicio del investigador, puedan interferir con la ejecución del estudio, la evaluación de la respuesta o el consentimiento informado"));
	        fs.iec.Add(new StudyIEC(sd_sid, 34, 2, "cr", "11.", 1, "e.11", "Uso de cualquier fármaco en investigación o participación en otro ensayo clínico terapéutico de forma simultánea o durante los 30 días anteriores a la inclusión"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 35, 2, "cr", "12.", 1, "e.12", "Pacientes gestantes o en período de lactancia"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 36, 2, "cr", "13.", 1, "e.13", "Mujeres con capacidad de concebir que no puedan o no deseen emplear métodos anticonceptivos"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 37, 2, "cr", "14.", 1, "e.14", "Incapacidad o rechazo a cumplir con el protocolo del estudio o a colaborar plenamente con el investigador o el profesional que él designe"));	   
	        fs.iec.Add(new StudyIEC(sd_sid, 38, 2, "cr", "15.", 1, "e.15", "Síndrome de malabsorción, patologías que afecten de forma significativa a la función gastrointestinal o resección gástrica o del intestino delgado. Las pacientes con colitis ulcerosa también quedarán excluidas del estudio"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 39, 2, "cr", "16.", 1, "e.16", "Tratamiento antineoplásico neoadyuvante simultáneo (quimioterapia, radioterapia, inmunoterapia o terapias biológicas, exceptuando los tratamientos del ensayo)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 40, 2, "cr", "17.", 1, "e.17", "Tratamiento simultáneo con inhibidores o inductores del CYP3A4"));

            fs.countries!.Add(new StudyCountry(sd_sid, 2510769, "Spain", 21));
            
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
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "12 Jul 2013", 2013, 7, 12, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Trial results entry
			
            sd_oid = sd_sid + " :: 28 :: EU CTR results entry";
            ob_title = display_title + " :: EU CTR results entry";
            sdo = CreateEmptyStudyDataObject();
			
            sdo.data_object = new DataObject(sd_oid, sd_sid, "EU CTR results entry", null, ob_title,
	            null, 9, 2022, 23, 28, 100123, "EU Clinical Trials Register", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
	            "https://www.clinicaltrialsregister.eu/ctr-search/trial/2013-001036-22/results", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "5 May 2022", 2022, 5, 5, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "5 May 2022", 2022, 5, 5, null, null, null, null));
			
            fs.data_objects!.Add(sdo);

            // 3) Results Summary
	        
            sd_oid = sd_sid + " :: 79 :: SOLTI-1114_Sinopsys_CSR_ENG";
            ob_title = display_title + " :: SOLTI-1114_Sinopsys_CSR_ENG";
            sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "SOLTI-1114_Sinopsys_CSR_ENG", null, ob_title,
	            null, 9, 2022, 23, 79, null, "SOLTI", null, "en", 11, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
	            "https://www.clinicaltrialsregister.eu/ctr-search/rest/download/result/attachment/2013-001036-22/1/30154",
	            true, 11, null, null, null));
	        
            fs.data_objects!.Add(sdo);
            
            // 4) Results Summary - pfd download
	        
            sd_oid = sd_sid + " :: 79 :: CSR summary - PDF DL";
            ob_title = display_title + " :: CSR summary";
            sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CSR summary - PDF DL", null, ob_title,
	            null, 9, 2022, 23, 79, null, "SOLTI", null, 
	            "en", 11, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100123, "EU Clinical Trials Register", 
	            "https://www.clinicaltrialsregister.eu/ctr-search/rest/download/result/zip/pdf/2013-001036-22/1",
	            true, 11, null, null, null));
	        
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
		        "Vaccination with dendritic cells pulsed with autologous tumor homogenate in combination with HD-IL2 and immunomodulating radiotherapy in metastatic RCC: a phase II trial (RENALVax-2)", 
		        16, "en", 11, false, "From the EU CTR"));
	        fs.titles.Add(new StudyTitle(sd_sid, "RENALVax-2", 14, "en", 11, false, "From the EU CTR"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "ISTITUTO SCIENTIFICO ROMAGNOLO PER LO STUDIO E LA CURA DEI TUMORI (IRST) SRL IRCCS", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "IRST-IRCCS", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "DC-VACCINE_IRSTIRCCS", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "IL2_IRSTIRCCS", 23, "110942-02-4", null, null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Metastatic renal cell carcinoma", 16, "10050513", null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "metastatic renal cancer", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "carcinoma renale metastatico", null, null, null, null));
	        
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 301, "seq", "Hdr", 1, "n.01.01", "Firma del consenso informato:"));
	        fs.iec!.Add(new StudyIEC(sd_sid, 2, 1, "seq", "1.", 1, "n.01.02", "I pazienti devono essere disposti e capaci a fornire il proprio consenso informato scritto prima di ogni altra procedura di screening prevista per lo studio."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "seq", "2.", 1, "n.01.03", "Disponibilità di materiale tumorale raccolto e conservato secondo le procedure del Laboratorio di Terapia Cellulare Somatica IRST."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "seq", "3.", 1, "n.01.04", "Diagnosi istologica o citologica confermata di RCC (tutte le istologie tranne carcinoma uroteliale)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "seq", "4.", 1, "n.01.05", "Stadio IV, in progressione dopo almeno una linea di terapia con TKI e/o antiangiogenetici e/o inibitori di mTOR (i pazienti dovranno aver terminato i precedenti trattamenti almeno 4 settimane prima della prima dose di IL-2)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "seq", "5.", 1, "n.01.06", "I pazienti dovranno avere almeno una lesione misurabile, secondo i criteri di risposta irRC (vedere sezione 8), dopo asportazione del tessuto tumorale per la preparazione dei vaccini. Le lesioni tumorali che verranno irradiate sono esclusi dalla valutazione della risposta."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "seq", "6.", 1, "n.01.07", "Aspettativa di vita superiore a 3 mesi"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "seq", "7.", 1, "n.01.08", "ECOG performance status 0-1"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 301, "seq", "Hdr", 1, "n.01.09", "Funzionalità midollare e d’organo definite come:"));
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "seq", "-", 2, "n.01.10.01", "leucociti>4000/L-neutrofili >1,500/L-piastrine>100,000/L-bilirubina totale nei limiti della norma (nil)"));
		    fs.iec.Add(new StudyIEC(sd_sid, 11, 1, "seq", "-", 2, "n.01.10.02", "AST(SGOT)/ALT(SGPT) <2.5 X institutional upper limit of normal"));
			fs.iec.Add(new StudyIEC(sd_sid, 12, 1, "seq", "-", 2, "n.01.10.03", "creatinina< 1.5 mg/dl"));
			fs.iec.Add(new StudyIEC(sd_sid, 13, 1, "seq", "-", 2, "n.01.10.04", "emoglobina >8.0 gm/dl"));
			fs.iec.Add(new StudyIEC(sd_sid, 14, 1, "seq", "-", 2, "n.01.10.05", "ematocrito <30%"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 15, 1, "seq", "9.", 1, "n.01.11", "ECG ed ecocardiogramma nella norma"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 16, 1, "seq", "10.", 1, "n.01.12", "Normale funzionalità polmonare"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 17, 1, "seq", "11.", 1, "n.01.13", "Non controindicazioni nell’uso di agenti vasopressori"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 18, 1, "seq", "12.", 1, "n.01.14", "Test per HIV, HBV HCV e sifilide negativi non più vecchi di 30 giorni prima dell’esecuzione di qualunque procedura GCP."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 19, 1, "seq", "13.", 1, "n.01.15", "Uomini e donne di età superiore a 18 anni."));	  
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "seq", "1.", 1, "e.01.01", "I pazienti che hanno test positivi per HCV, HBV, HIV, o sifilide (test ematici specifici devono essere effettuati entro 30 giorniprima di qualsiasi attività regolamentata dalle GMP)."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "seq", "2.", 1, "e.01.02", "I pazienti che non hanno avuto precedenti linee di terapia sistemica per malattia avanzata."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "seq", "3.", 1, "e.01.03", "Partecipazione ad un altro studio clinico con eventuali farmaci sperimentali nei 30 giorni precedenti allo screening per questo studio."));
	        fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "seq", "4.", 1, "e.01.04", "malattia non controllata intercorrente tra cui, ma non solo, l’infezione in corso o attiva, insufficienza cardiaca congestizia sintomatica, angina pectoris instabile, aritmia cardiaca, o malattia psichiatrica / situazioni sociali che limiterebbero la conformitàcon i requisiti di studio (a giudizio del medico)."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "seq", "5.", 1, "e.01.05", "Altre note patologie neoplastiche maligne nella storia clinica del paziente, con un intervallo libero da malattia di meno di 3 anni (tranne che per il carcinoma a cellule basali e carcinoma in situ della cervice uterina trattati precedentemente);"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "seq", "6.", 1, "e.01.06", "Precedente chemioterapia, radioterapia o immunoterapia entro 4 settimane (6 settimane per nitrosouree o mitomicina C) prima di entrare nello studio o pazienti che non hanno recuperato da eventi avversi a causa di agenti somministrati più di 4 settimane prima."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "seq", "7.", 1, "e.01.07", "I pazienti con note metastasi cerebrali dovrebbero essere esclusi da questo studio clinico a causa della loro scarsa prognosi eperché spesso sviluppano una progressiva disfunzione neurologica che confonderebbe la valutazione degli eventi avversi di tiponeurologico e non."));
	        fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "seq", "8.", 1, "e.01.08", "Storia di reazioni allergiche attribuite a composti chimici o biologici simili all’IL-2 o ad altri agenti utilizzati nello studio."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "seq", "9.", 1, "e.01.09", "Ogni malattia autoimmune che potrebbe essere aggravata da IL-2"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "seq", "10.", 1, "e.01.10", "Una condizione medica che richiede trattamenti cronici con corticosteroidi o altri farmaci immunosoppressori"));
	        fs.iec.Add(new StudyIEC(sd_sid, 30, 2, "seq", "11.", 1, "e.01.11", "Una storia di malattia cardiovascolare significativa, tra cui infarto miocardico, insufficienza cardiaca congestizia, aritmiecardiache primarie, angina pectoris o incidente cerebrovascolare"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 31, 2, "seq", "12.", 1, "e.01.12", "HIV-positività, anche sintomatica"));
	        fs.iec.Add(new StudyIEC(sd_sid, 32, 2, "seq", "13.", 1, "e.01.13", "Qualsiasi controindicazione a sottoporsi a leucaferesi, come valutato dal transfusionista (ad esempio una grave anemia, piastrinopenia, terapia anticoagulante orale) o a sottoporsi ad un intervento chirurgico."));	
            
            fs.countries!.Add(new StudyCountry(sd_sid, 3175395, "Italy", 22));
            
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
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "15 Dec 2017", 2017, 12, 15, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
           
        }
        
        return null;
    }
}