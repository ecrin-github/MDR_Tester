using System.Text;
namespace MDR_Tester;

public class TestData_100120 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "NCT00051350")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "OmniHeart Trial: Macronutrients and Cardiovascular Risk";
	        StringBuilder sb = new StringBuilder("To compare the effects on blood pressure and plasma lipids of three different diets--a carbohydrate-rich diet, ");
	        sb.Append("a protein-rich diet, or a diet rich in unsaturated fat."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2002, 5, 11, 21, "164", 900,
		        30, 17, 100, 17, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2003 Jan 9", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "NA_00069360", 14, 100190, 
		        "Johns Hopkins University", "https://ror.org/00za53h95", null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "R01HL067098", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, "https://projectreporter.nih.gov/reporterapi.cfm?PROJECTNUM=R01HL067098&Fy=all"));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "Macronutrients and Cardiovascular Risk", 16, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Lawrence Appel", "Johns Hopkins University", 
		                                   100190, "Johns Hopkins University", "https://ror.org/00za53h95"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100190, "Johns Hopkins University", "https://ror.org/00za53h95"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100167, "National Heart, Lung, and Blood Institute (NHLBI)", "https://ror.org/012pb6c26"));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 100));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 405));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 310));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 505));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Nutrients", 14, "D000078622", "D000078622", "Nutrients"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Hypertension", null, null, "BA00", "Essential hypertension"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Heart Diseases", null, null, "11", "Diseases of the circulatory system"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Atherosclerosis", null, null, "BD40", "Atherosclerotic chronic arterial occlusive disease"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Cardiovascular Diseases", null, null, "11", "Diseases of the circulatory system"));

	        sb = new StringBuilder("Mueller NT, Zhang M, Juraschek SP, Miller ER, Appel LJ. ");
	        sb.Append("Effects of high-fiber diets enriched with carbohydrate, protein, or unsaturated fat on circulating short chain fatty acids: results from the OmniHeart randomized trial. ");
	        sb.Append("Am J Clin Nutr. 2020 Mar 1;111(3):545-554. doi: 10.1093/ajcn/nqz322.");
	        fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "31927581", null, null, null));
	        
	        sb = new StringBuilder("Kovell LC, Yeung EH, Miller ER 3rd, Appel LJ, Christenson RH, Rebuck H, Schulman SP, Juraschek SP. ");
	        sb.Append("Healthy diet reduces markers of cardiac injury and inflammation regardless of macronutrients: Results from the OmniHeart trial. ");
	        sb.Append("Int J Cardiol. 2020 Jan 15;299:282-288. doi: 10.1016/j.ijcard.2019.07.102. Epub 2019 Aug 2.");
	        fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31447226", null, null, null));
	        
	        sb = new StringBuilder("Loo RL, Zou X, Appel LJ, Nicholson JK, Holmes E. ");
	        sb.Append("Characterization of metabolic responses to healthy diets and association with blood pressure: application to the Optimal Macronutrient Intake Trial for Heart Health (OmniHeart), a randomized controlled study. ");
	        sb.Append("Am J Clin Nutr. 2018 Mar 1;107(3):323-334. doi: 10.1093/ajcn/nqx072.");
	        fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29506183", null, null, null));
	        
	        sb = new StringBuilder("Juraschek SP, Miller ER 3rd, Appel LJ, Christenson RH, Sacks FM, Selvin E. ");
	        sb.Append("Effects of dietary carbohydrate on 1,5-anhydroglucitol in a population without diabetes: results from the OmniCarb trial. ");
	        sb.Append("Diabet Med. 2017 Oct;34(10):1407-1413. doi: 10.1111/dme.13391. Epub 2017 Jul 9.");
	        fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "28574153", null, null, null));
	        
	        sb = new StringBuilder("Haring B, von Ballmoos MC, Appel LJ, Sacks FM. ");
	        sb.Append("Healthy dietary interventions and lipoprotein (a) plasma levels: results from the Omni Heart Trial. ");
	        sb.Append("PLoS One. 2014 Dec 15;9(12):e114859. doi: 10.1371/journal.pone.0114859. eCollection 2014.");
	        fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "25506933", null, null, null));
	        
	        sb = new StringBuilder("Gadgil MD, Appel LJ, Yeung E, Anderson CA, Sacks FM, Miller ER 3rd. ");
	        sb.Append("The effects of carbohydrate, unsaturated fat, and protein intake on measures of insulin sensitivity: results from the OmniHeart trial. ");
	        sb.Append("Diabetes Care. 2013 May;36(5):1132-7. doi: 10.2337/dc12-0869. Epub 2012 Dec 5.");
	        fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "23223345", null, null, null));
	        
	        sb = new StringBuilder("Juraschek SP, Appel LJ, Anderson CA, Miller ER 3rd. ");
	        sb.Append("Effect of a high-protein diet on kidney function in healthy adults: results from the OmniHeart trial. ");
	        sb.Append("Am J Kidney Dis. 2013 Apr;61(4):547-54. doi: 10.1053/j.ajkd.2012.10.017. Epub 2012 Dec 4.");
	        fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "23219108", null, null, null));
	        
	        sb = new StringBuilder("Furtado JD, Campos H, Sumner AE, Appel LJ, Carey VJ, Sacks FM. ");
	        sb.Append("Dietary interventions that lower lipoproteins containing apolipoprotein C-III are more effective in whites than in blacks: results of the OmniHeart trial. ");
	        sb.Append("Am J Clin Nutr. 2010 Oct;92(4):714-22. doi: 10.3945/ajcn.2009.28532. Epub 2010 Sep 8.");
	        fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "20826623", null, null, null));
	        
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Healthy adults"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Aged 30 years and older"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Systolic blood pressure of 120 to 159 mm Hg or a diastolic blood pressure of 80 to 99 mm Hg."));	
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 2, "cr assumed", "@", 1, "e.01", "Diabetes"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr assumed", "@", 1, "e.02", "Active or prior Cardiovascular disease (CVD)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr assumed", "@", 1, "e.03", "LDL cholesterol greater than 220 mg/dL (>5.70 mmol/L)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr assumed", "@", 1, "e.04", "Fasting triglycerides greater than 750 mg/dL (>8.48 mmol/L)"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.05", "Weight more than 350 lb (>159 kg)"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.06", "Taking medications that affect blood pressure or blood lipid levels"));	 
		    fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr assumed", "@", 1, "e.07", "Unwillingness to stop taking vitamin and mineral supplements"));    
		    fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr assumed", "@", 1, "e.08", "Alcoholic beverage intake of more than 14 drinks per week.")); 
	        
	        // No location list
	        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
	        string ob_title = display_title + " :: CTG registry entry";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
		        null, 9, 2003, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
		        "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2003 Jan 13 (est.)", 2003, 1, 13, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2018 Oct 4", 2018, 10, 4, null, null, null, null));
	       
	        fs.data_objects!.Add(sdo);

	        return fs;

        }
        
        if (sd_sid == "NCT01973660")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "PAM50 HER2-enriched Phenotype as a Predictor of Response to Dual HER2 Blockade in HER2-positive Early Breast Cancer";
	        StringBuilder sb = new StringBuilder("Non-randomized, open label, multicentric translational research study in women with untreated invasive breast carcinoma eligible for primary surgery (Stage I-IIIA).\n\n");
	        sb.Append("The aim of PAMELA is to test the hypothesis that PAM50 HER2-enriched (HER2-E) subtype better predicts response to neoadjuvant dual anti-HER2 blockade, with or without endocrine therapy, "); 
	        sb.Append("compared to traditional clinical HER2 classification. Furthermore, we posit that characterization of gene expression patterns may identify profiles of those who may be safely spared chemotherapy."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2013, 10, 11, 21, "151", 905,
		        18, 17, null, null, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2013 Oct 25", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "SOLTI-1114", 14, null, 
		        "SOLTI Breast Cancer Research Group", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "2013-001036-22", 11, 100123,
		        "EU Clinical Trials Register", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "PAMELA: PAM50 HER2-enriched Phenotype as a Predictor of Early Response to Neoadjuvant Lapatinib Plus Trastuzumab in Stage I to IIIA HER2-positive Breast Cancer", 16, "en", 11, false, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "PAMELA", 14, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Antonio Llombart", "Hospital Arnau de Vilanova de Valencia", 
		        null, "Hospital Arnau de Vilanova de Valencia", null));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Aleix Prat", "Vall d’Hebron Institute of Oncology (VHIO)", 
		        null, "Vall d’Hebron Institute of Oncology (VHIO)", null));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Javier Cortés", "Vall d’Hebron University Hospital", 
		        null, "Vall d’Hebron University Hospital", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "SOLTI Breast Cancer Research Group", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100189, "Novartis", "https://ror.org/02f9zrr09"));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
            fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
            fs.features.Add(new StudyFeature(sd_sid, 22, 210));   // 
            fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
            fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
                       
            fs.topics!.Add(new StudyTopic(sd_sid, 11, "Human Epidermal Growth Factor Receptor 2", null, null, null, null));
            fs.topics.Add(new StudyTopic(sd_sid, 11, "HER2", null, null, null, null));
            fs.topics.Add(new StudyTopic(sd_sid, 11, "HER2 positive", null, null, null, null));
            fs.topics.Add(new StudyTopic(sd_sid, 11, "PAM50", null, null, null, null));
            fs.topics.Add(new StudyTopic(sd_sid, 11, "dual HER2 blockade", null, null, null, null));
            fs.topics.Add(new StudyTopic(sd_sid, 11, "neoadjuvant", null, null, null, null));
            
            fs.topics.Add(new StudyTopic(sd_sid, 12, "Tamoxifen", 14, "D000013629", "D000013629", "Tamoxifen"));
            fs.topics.Add(new StudyTopic(sd_sid, 12, "Trastuzumab", 14, "D000068878", "D000068878", "Trastuzumab"));
            fs.topics.Add(new StudyTopic(sd_sid, 12, "Letrozole", 14, "D000077289", "D000077289", "Letrozole"));
            fs.topics.Add(new StudyTopic(sd_sid, 12, "Lapatinib", 14, "D000077341", "D000077341", "Lapatinib"));
            
            fs.conditions!.Add(new StudyCondition(sd_sid, "Breast Neoplasms", 14, "D000001943", "B3-2C6", "Malignant neoplasms of breast"));
            
            sb = new StringBuilder("Nuciforo P, Pascual T, Cortés J, Llombart-Cussac A, Fasani R, Paré L, Oliveira M, Galvan P, Martínez N, Bermejo B, Vidal M, Pernas S, López R, Muñoz M, Garau I, Manso L, Alarcón J, Martínez E, Rodrik-Outmezguine V, Brase JC, Villagrasa P, Prat A, Holgado E. ");
            sb.Append("A predictive model of pathologic response based on tumor cellularity and tumor-infiltrating lymphocytes (CelTIL) in HER2-positive breast cancer treated with chemo-free dual HER2 blockade. ");
            sb.Append("Ann Oncol. 2018 Jan 1;29(1):170-177. doi: 10.1093/annonc/mdx647.");
            fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "29045543", null, null, null));

            sb = new StringBuilder("Llombart-Cussac A, Cortés J, Paré L, Galván P, Bermejo B, Martínez N, Vidal M, Pernas S, López R, Muñoz M, Nuciforo P, Morales S, Oliveira M, de la Peña L, Peláez A, Prat A. ");
            sb.Append("HER2-enriched subtype as a predictor of pathological complete response following trastuzumab and lapatinib without chemotherapy in early-stage HER2-positive breast cancer (PAMELA): an open-label, single-group, multicentre, phase 2 trial. ");
	        sb.Append("Lancet Oncol. 2017 Apr;18(4):545-554. doi: 10.1016/S1470-2045(17)30021-9. Epub 2017 Feb 24.");
            fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "28238593", null, null, null));

            fs.studylinks!.Add(new StudyLink(sd_sid, "SOLTI is a non-profit academic research organization dedicated to conducting innovative breast cancer clinical trials", "http://www.gruposolti.org"));
            
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Written informed consent prior to beginning specific protocol procedures"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Untreated invasive breast carcinoma eligible for primary definitive surgery (stage I-IIIA)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Histologically confirmed invasive breast carcinoma, with all of the following characteristics: primary tumor ≥1 cm in largest diameter, cN0-2, No evidence of distant metastasis (M0)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "HER2-positive invasive breast cancer by central assessment, defined by ASCO/CAP guidelines"));
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "Female patients"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "Age ≥18 years"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr assumed", "@", 1, "n.07", "ECOG performance status of 0 or 1"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr assumed", "@", 1, "n.08", "Adequate organ function defined as: Absolute neutrophil count (ANC) ≥1.5 × 109/L, Hemoglobin (Hgb) ≥10 g/dL, Platelets >100 000/mm3, Creatinine ≤1.6 mg/dL, ALT and AST ≤2.5 × ULN, Alkaline phosphatase ≤5 ULN, Total bilirubin ≤1.5 mg/dL, Baseline LVEF ≥50% measured by echocardiography (ECHO) or Multiple Gate Acquisition (MUGA) scan"));
            fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "cr assumed", "@", 1, "n.09", "Negative β-HCG pregnancy test (serum) for premenopausal women of reproductive capacity (those who are biologically capable of having children) and for women less than 12 months after the menopause. All subjects who are biologically capable of having children must agree and commit to the use of a reliable method of birth control from 2 weeks before administration of the first dose of investigational product until 28 days after last dose of investigational product"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "cr assumed", "@", 1, "n.10", "Absence of any psychological, familial, sociological or geographical condition potentially hampering compliance with the study protocol and follow-up schedule"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 11, 1, "cr assumed", "@", 1, "n.11", "In the case of multifocal tumor (defined as the presence of two or more tumor foci in the same quadrant of the breast), the largest lesion must be ≥ 1 cm, and \"target lesion\" must be designated for all subsequent tumor assessments. In all tumor foci should be documented HER2 status as positive"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 12, 1, "cr assumed", "@", 1, "n.12", "Availability of enough tumor sample or possibility to take a new biopsy for PAM50 analysis"));
            
            fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr assumed", "@", 1, "e.01", "Stage III inoperable breast cancer or known metastatic disease"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr assumed", "@", 1, "e.02", "Patients for whom upfront chemotherapy including taxanes and anthracyclines is clinically judged appropriate as optimal neoadjuvant treatment"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr assumed", "@", 1, "e.03", "Prior chemotherapy, radiotherapy or surgery for invasive breast cancer, other than excision of tumor in the contralateral breast, and provided that the patient did not previously receive adjuvant radiotherapy or chemotherapy"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr assumed", "@", 1, "e.04", "Subjects with a concurrently active second malignancy, other than adequately treated non-melanoma skin cancers, in situ melanoma or in situ cervical cancer. Subjects with other non-mammary malignancies must have been disease-free for at least 5 years"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr assumed", "@", 1, "e.05", "Known or suspected hypersensitivity reaction to any investigational or therapeutic compound or their incorporated substances"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "cr assumed", "@", 1, "e.06", "Concurrent congestive heart failure or LVEF <50%"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "cr assumed", "@", 1, "e.07", "Clinically significant (i.e. active) cardiovascular disease, including cerebrovascular accident (<6 months before enrollment), unstable angina pectoris, myocardial infarction ≤6 months before enrollment, uncontrolled hypertension (systolic >150 mmHg and/or diastolic >100 mmHg) or high-risk uncontrolled arrhythmias"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "cr assumed", "@", 1, "e.08", "Uncontrolled diabetes mellitus, active peptic ulcer disease or uncontrolled epilepsy"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "cr assumed", "@", 1, "e.09", "Active uncontrolled infection at the time of enrollment"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "cr assumed", "@", 1, "e.10", "History of significant comorbidities that, in the judgment of the investigator, may interfere with the conduction of the study, the evaluation of response, or with informed consent"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr assumed", "@", 1, "e.11", "Use of any investigational agent or participation in another therapeutic clinical trial concurrently or in the previous 30 days before the enrollment"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr assumed", "@", 1, "e.12", "Patients who are pregnant or breast-feeding"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr assumed", "@", 1, "e.13", "Women of child-bearing potential who are unable or unwilling to use contraceptive measures"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr assumed", "@", 1, "e.14", "Inability or unwillingness to abide by the study protocol or cooperate fully with the investigator"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "cr assumed", "@", 1, "e.15", "Malabsorption syndrome, disease significantly affecting gastrointestinal function, or resection of the stomach or small bowel. Subjects with ulcerative colitis are also excluded"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "cr assumed", "@", 1, "e.16", "Concurrent neoadjuvant cancer therapy (chemotherapy, radiation therapy, immunotherapy, biologic therapy other than the trial therapies)"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "cr assumed", "@", 1, "e.17", "Concomitant use of CYP3A4 inhibitors or inducers"));	       

	        fs.countries!.Add(new StudyCountry(sd_sid, 2510769, "Spain", null));
	         
	        fs.sites!.Add(new StudyLocation(sd_sid, null, "Hospital de Torrevieja", null, null, "Torrevieja", 2510769, "Spain", null));
	        fs.sites.Add(new StudyLocation(sd_sid, null, "Hospital Clínico Universitario de Santiago de Compostela", null, null, "Santiago de Compostela", 2510769, "Spain", null));
	        fs.sites.Add(new StudyLocation(sd_sid, null, "Hospital Universitario Son Espases", null, null, "Palma de Mallorca", 2510769, "Spain", null));
	        fs.sites.Add(new StudyLocation(sd_sid, null, "Hospital Universitario de Fuenlabrada", null, null, "Fuenlabrada", 2510769, "Spain", null));
	        fs.sites.Add(new StudyLocation(sd_sid, null, "Vall d'Hebron University Hospital", null, null, "Barcelona", 2510769, "Spain", null));
	        fs.sites.Add(new StudyLocation(sd_sid, null, "Hospital Clínic de Barcelona", null, null, "Barcelona", 2510769, "Spain", null));
	        fs.sites.Add(new StudyLocation(sd_sid, null, "Hospital Universitario Arnau de Vilanova de Lleida", null, null, "Lleida", 2510769, "Spain", null));
	        fs.sites.Add(new StudyLocation(sd_sid, null, "Hospital Universitario 12 de Octubre", null, null, "Madrid", 2510769, "Spain", null));
	        fs.sites.Add(new StudyLocation(sd_sid, null, "Hospital Clínico San Carlos", null, null, "Madrid", 2510769, "Spain", null));
	        fs.sites.Add(new StudyLocation(sd_sid, null, "Hospital Clínico Universitario de Valencia", null, null, "Valencia", 2510769, "Spain", null));
	        fs.sites.Add(new StudyLocation(sd_sid, null, "Hospital Universitario Arnau de Vilanova de Valencia", null, null, "Valencia", 2510769, "Spain", null));

            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2013, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2013 Oct 31 (est.)", 2013, 10, 31, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2018 Sep 19", 2018, 9, 19, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs; 
        }
        
        
        if (sd_sid == "NCT00094302")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Aldosterone Antagonist Therapy for Adults With Heart Failure and Preserved Systolic Function";
	        StringBuilder sb = new StringBuilder("The purpose of this study is to evaluate the effectiveness of aldosterone antagonist therapy in reducing cardiovascular mortality, ");
	        sb.Append("aborted cardiac arrest, and heart failure hospitalization in patients who have heart failure with preserved systolic function."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2006, 8, 11, 21, "3445", 900,
		        50, 17, null, null, 10);
	        
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
            		        "Clinicaltrials.gov", null, "2004 Oct 15", null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "160", 14, 100190, 
            		        "HealthCore-NERI", null, null, null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "HHSN268200425207C", 13, 100134, 
            		        "National Institutes of Health", "https://ror.org/01cwqze88", null, null));
            	        
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
            fs.titles.Add(new StudyTitle(sd_sid, "Treatment of Preserved Cardiac Function Heart Failure With an Aldosterone Antagonist (TOPCAT)", 16, "en", 11, false, "From Clinicaltrials.gov"));
            fs.titles.Add(new StudyTitle(sd_sid, "TOPCAT", 14, "en", 11, false, "From Clinicaltrials.gov"));
            
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Sonja M McKinlay", "New England Research Institutes, Inc", 
	            null, "New England Research Institutes", null));	
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "HealthCore-NERI", null));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100167, "National Heart, Lung, and Blood Institute (NHLBI)", "https://ror.org/012pb6c26"));

            fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 515));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 11, "Diastolic Heart Failure", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "Preserved Ejection Fraction", null, null, null, null));
            
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Spironolactone", 14, "D000013148", "D000013148", "Spironolactone"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Mineralocorticoid Receptor Antagonists", 14, "D000013148", 
		                           "D000013148", "Mineralocorticoid Receptor Antagonists"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Heart Failure", 14, "D000006333", "B1-BD1", "Heart failure"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Heart Diseases", 14, "D000006331", "11", "Diseases of the circulatory system"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Cardiovascular Diseases", 14, "D000002318", "11", "Diseases of the circulatory system"));
     
			sb = new StringBuilder("Shah AM, Shah SJ, Anand IS, Sweitzer NK, O’Meara E, Heitner JF, Sopko G, Li G, Assmann SF, McKinlay SM, Pitt B, Pfeffer MA, Solomon SD; TOPCAT Investigators. ");
			sb.Append("Cardiac structure and function in heart failure with preserved ejection fraction: baseline findings from the echocardiographic study of the Treatment of Preserved Cardiac Function Heart Failure with an Aldosterone Antagonist trial. ");
			sb.Append("Circ Heart Fail. 2014 Jan;7(1):104-15. doi: 10.1161/CIRCHEARTFAILURE.113.000887. Epub 2013 Nov 18.");
			fs.references! .Add(new StudyReference(sd_sid, sb.ToString(), "24249049", null, null, null));

			sb = new StringBuilder("Pitt B, Pfeffer MA, Assmann SF, Boineau R, Anand IS, Claggett B, Clausell N, Desai AS, Diaz R, Fleg JL, Gordeev I, Harty B, Heitner JF, Kenwood CT, Lewis EF, O’Meara E, Probstfield JL, Shaburishvili T, Shah SJ, Solomon SD, Sweitzer NK, Yang S, McKinlay SM; TOPCAT Investigators. ");
			sb.Append("Spironolactone for heart failure with preserved ejection fraction. ");
			sb.Append("N Engl J Med. 2014 Apr 10;370(15):1383-92. doi: 10.1056/NEJMoa1313731.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "24716680", null, null, null));

			sb = new StringBuilder("Shah AM, Claggett B, Sweitzer NK, Shah SJ, Anand IS, O’Meara E, Desai AS, Heitner JF, Li G, Fang J, Rouleau J, Zile MR, Markov V, Ryabov V, Reis G, Assmann SF, McKinlay SM, Pitt B, Pfeffer MA, Solomon SD. ");
			sb.Append("Cardiac structure and function and prognosis in heart failure with preserved ejection fraction: findings from the echocardiographic study of the Treatment of Preserved Cardiac Function Heart Failure with an Aldosterone Antagonist (TOPCAT) Trial. ");
			sb.Append("Circ Heart Fail. 2014 Sep;7(5):740-51. doi: 10.1161/CIRCHEARTFAILURE.114.001583. Epub 2014 Aug 13");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "25122186", null, null, null));

			sb = new StringBuilder("Pfeffer MA, Claggett B, Assmann SF, Boineau R, Anand IS, Clausell N, Desai AS, Diaz R, Fleg JL, Gordeev I, Heitner JF, Lewis EF, O’Meara E, Rouleau JL, Probstfield JL, Shaburishvili T, Shah SJ, Solomon SD, Sweitzer NK, McKinlay SM, Pitt B. ");
			sb.Append("Regional variation in patients and outcomes in the Treatment of Preserved Cardiac Function Heart Failure With an Aldosterone Antagonist (TOPCAT) trial. ");
			sb.Append("Circulation. 2015 Jan 6;131(1):34-42. doi: 10.1161/CIRCULATIONAHA.114.013255. Epub 2014 Nov 18.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "25406305", null, null, null));

			sb = new StringBuilder("Myhre PL, Vaduganathan M, O’Meara E, Claggett BL, de Denus S, Jarolim P, Anand IS, Pitt B, Rouleau JL, Solomon SD, Pfeffer MA, Desai AS. ");
			sb.Append("Mechanistic Effects of Spironolactone on Cardiovascular and Renal Biomarkers in Heart Failure With Preserved Ejection Fraction: A TOPCAT Biorepository Study. ");
			sb.Append("Circ Heart Fail. 2020 Jan;13(1):e006638. doi: 10.1161/CIRCHEARTFAILURE.119.006638. Epub 2020 Jan 20.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31957468", null, null, null));

			sb = new StringBuilder("Vardeny O, Claggett B, Vaduganathan M, Beldhuis I, Rouleau J, O’Meara E, Anand IS, Shah SJ, Sweitzer NK, Fang JC, Desai AS, Lewis EF, Pitt B, Pfeffer MA, Solomon SD; TOPCAT Investigators. ");
			sb.Append("Influence of Age on Efficacy and Safety of Spironolactone in Heart Failure. ");
			sb.Append("JACC Heart Fail. 2019 Dec;7(12):1022-1028. doi: 10.1016/j.jchf.2019.08.019.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "", null, null, null));

			sb = new StringBuilder("Angraal S, Mortazavi BJ, Gupta A, Khera R, Ahmad T, Desai NR, Jacoby DL, Masoudi FA, Spertus JA, Krumholz HM. ");
			sb.Append("Machine Learning Prediction of Mortality and Hospitalization in Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("JACC Heart Fail. 2020 Jan;8(1):12-21. doi: 10.1016/j.jchf.2019.06.013. Epub 2019 Oct 9.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31606361", null, null, null));

			sb = new StringBuilder("Beale AL, Nanayakkara S, Kaye DM. ");
			sb.Append("Impact of Sex on Ventricular-Vascular Stiffness and Long-Term Outcomes in Heart Failure With Preserved Ejection Fraction: TOPCAT Trial Substudy. ");
			sb.Append("J Am Heart Assoc. 2019 Jul 2;8(13):e012190. doi: 10.1161/JAHA.119.012190. Epub 2019 Jun 22.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31230508", null, null, null));

			sb = new StringBuilder("Selvaraj S, Claggett B, Shah SJ, Anand IS, Rouleau JL, Desai AS, Lewis EF, Vaduganathan M, Wang SY, Pitt B, Sweitzer NK, Pfeffer MA, Solomon SD. ");
			sb.Append("Utility of the Cardiovascular Physical Examination and Impact of Spironolactone in Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("Circ Heart Fail. 2019 Jul;12(7):e006125. doi: 10.1161/CIRCHEARTFAILURE.119.006125. Epub 2019 Jun 21.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31220936", null, null, null));

			sb = new StringBuilder("Neefs J, van den Berg NWE, Krul SPJ, Boekholdt SM, de Groot JR. ");
			sb.Append("Effect of Spironolactone on Atrial Fibrillation in Patients with Heart Failure with Preserved Ejection Fraction: Post-Hoc Analysis of the Randomized, Placebo-Controlled TOPCAT Trial. ");
			sb.Append("Am J Cardiovasc Drugs. 2020 Feb;20(1):73-80. doi: 10.1007/s40256-019-00353-5.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31214914", null, null, null));

			sb = new StringBuilder("Kristensen SL, Mogensen UM, Jhund PS, Rørth R, Anand IS, Carson PE, Desai AS, Pitt B, Pfeffer MA, Solomon SD, Zile MR, Køber L, McMurray JJV. ");
			sb.Append("N-Terminal Pro-B-Type Natriuretic Peptide Levels for Risk Prediction in Patients With Heart Failure and Preserved Ejection Fraction According to Atrial Fibrillation Status. ");
			sb.Append("Circ Heart Fail. 2019 Mar;12(3):e005766. doi: 10.1161/CIRCHEARTFAILURE.118.005766.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30871349", null, null, null));

			sb = new StringBuilder("Merrill M, Sweitzer NK, Lindenfeld J, Kao DP. ");
			sb.Append("Sex Differences in Outcomes and Responses to Spironolactone in Heart Failure With Preserved Ejection Fraction: A Secondary Analysis of TOPCAT Trial. ");
			sb.Append("JACC Heart Fail. 2019 Mar;7(3):228-238. doi: 10.1016/j.jchf.2019.01.003.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30819379", null, null, null));

			sb = new StringBuilder("Myhre PL, O’Meara E, Claggett BL, de Denus S, Jarolim P, Anand IS, Beldhuis IE, Fleg JL, Lewis E, Pitt B, Rouleau JL, Solomon SD, Pfeffer MA, Desai AS. ");
			sb.Append("Cardiac Troponin I and Risk of Cardiac Events in Patients With Heart Failure and Preserved Ejection Fraction. ");
			sb.Append("Circ Heart Fail. 2018 Nov;11(11):e005312. doi: 10.1161/CIRCHEARTFAILURE.118.005312.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30571192", null, null, null));

			sb = new StringBuilder("Selvaraj S, Claggett B, Shah SJ, Anand I, Rouleau JL, O’Meara E, Desai AS, Lewis EF, Pitt B, Sweitzer NK, Fang JC, Pfeffer MA, Solomon SD. ");
			sb.Append("Prognostic Value of Albuminuria and Influence of Spironolactone in Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("Circ Heart Fail. 2018 Nov;11(11):e005288. doi: 10.1161/CIRCHEARTFAILURE.118.005288.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30571191", null, null, null));

			sb = new StringBuilder("Myhre PL, Vaduganathan M, Claggett BL, Anand IS, Sweitzer NK, Fang JC, O’Meara E, Shah SJ, Desai AS, Lewis EF, Rouleau J, Pitt B, Pfeffer MA, Solomon SD. ");
			sb.Append("Association of Natriuretic Peptides With Cardiovascular Prognosis in Heart Failure With Preserved Ejection Fraction: Secondary Analysis of the TOPCAT Randomized Clinical Trial. ");
			sb.Append("JAMA Cardiol. 2018 Oct 1;3(10):1000-1005. doi: 10.1001/jamacardio.2018.2568.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30140899", null, null, null));

			sb = new StringBuilder("Cikes M, Claggett B, Shah AM, Desai AS, Lewis EF, Shah SJ, Anand IS, O’Meara E, Rouleau JL, Sweitzer NK, Fang JC, Saksena S, Pitt B, Pfeffer MA, Solomon SD. ");
			sb.Append("Atrial Fibrillation in Heart Failure With Preserved Ejection Fraction: The TOPCAT Trial. ");
			sb.Append("JACC Heart Fail. 2018 Aug;6(8):689-697. doi: 10.1016/j.jchf.2018.05.005. Epub 2018 Jul 11.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30007557", null, null, null));

			sb = new StringBuilder("Lewis EF, Claggett B, Shah AM, Liu J, Shah SJ, Anand I, O’Meara E, Sweitzer NK, Rouleau JL, Fang JC, Desai AS, Retta TM, Solomon SD, Heitner JF, Stamos TD, Boineau R, Pitt B, Pfeffer MA. ");
			sb.Append("Racial Differences in Characteristics and Outcomes of Patients With Heart Failure and Preserved Ejection Fraction in the Treatment of Preserved Cardiac Function Heart Failure Trial. ");
			sb.Append("Circ Heart Fail. 2018 Mar;11(3):e004457. doi: 10.1161/CIRCHEARTFAILURE.117.004457.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29664406", null, null, null));

			sb = new StringBuilder("Vaduganathan M, Claggett BL, Chatterjee NA, Anand IS, Sweitzer NK, Fang JC, O’Meara E, Shah SJ, Hegde SM, Desai AS, Lewis EF, Rouleau J, Pitt B, Pfeffer MA, Solomon SD. ");
			sb.Append("Sudden Death in Heart Failure With Preserved Ejection Fraction: A Competing Risks Analysis From the TOPCAT Trial. ");
			sb.Append("JACC Heart Fail. 2018 Aug;6(8):653-661. doi: 10.1016/j.jchf.2018.02.014. Epub 2018 Mar 4.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29501806", null, null, null));

			sb = new StringBuilder("Rossignol P, Claggett BL, Liu J, Vardeny O, Pitt B, Zannad F, Solomon S. ");
			sb.Append("Spironolactone and Resistant Hypertension in Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("Am J Hypertens. 2018 Mar 10;31(4):407-414. doi: 10.1093/ajh/hpx210.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29228101", null, null, null));

			sb = new StringBuilder("Selvaraj S, Claggett B, Shah SJ, Anand I, Rouleau JL, Desai AS, Lewis EF, Pitt B, Sweitzer NK, Pfeffer MA, Solomon SD. ");
			sb.Append("Systolic blood pressure and cardiovascular outcomes in heart failure with preserved ejection fraction: an analysis of the TOPCAT trial. ");
			sb.Append("Eur J Heart Fail. 2018 Mar;20(3):483-490. doi: 10.1002/ejhf.1060. Epub 2017 Nov 16.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29148144", null, null, null));

			sb = new StringBuilder("Pokharel Y, Khariton Y, Tang Y, Nassif ME, Chan PS, Arnold SV, Jones PG, Spertus JA. ");
			sb.Append("Association of Serial Kansas City Cardiomyopathy Questionnaire Assessments With Death and Hospitalization in Patients With Heart Failure With Preserved and Reduced Ejection Fraction: A Secondary Analysis of 2 Randomized Clinical Trials. ");
			sb.Append("JAMA Cardiol. 2017 Dec 1;2(12):1315-1321. doi: 10.1001/jamacardio.2017.3983. Erratum in: JAMA Cardiol. 2018 Feb 1;3(2):181.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29094152", null, null, null));

			sb = new StringBuilder("Hegde SM, Claggett B, Shah AM, Lewis EF, Anand I, Shah SJ, Sweitzer NK, Fang JC, Pitt B, Pfeffer MA, Solomon SD. ");
			sb.Append("Physical Activity and Prognosis in the TOPCAT Trial (Treatment of Preserved Cardiac Function Heart Failure With an Aldosterone Antagonist). ");
			sb.Append("Circulation. 2017 Sep 12;136(11):982-992. doi: 10.1161/CIRCULATIONAHA.117.028002. Epub 2017 Jun 21.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "28637881", null, null, null));

			sb = new StringBuilder("Anand IS, Claggett B, Liu J, Shah AM, Rector TS, Shah SJ, Desai AS, O’Meara E, Fleg JL, Pfeffer MA, Pitt B, Solomon SD. ");
			sb.Append("Interaction Between Spironolactone and Natriuretic Peptides in Patients With Heart Failure and Preserved Ejection Fraction: From the TOPCAT Trial. ");
			sb.Append("JACC Heart Fail. 2017 Apr;5(4):241-252. doi: 10.1016/j.jchf.2016.11.015.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "28359411", null, null, null));

			sb = new StringBuilder("Biering-Sørensen T, Shah SJ, Anand I, Sweitzer N, Claggett B, Liu L, Pitt B, Pfeffer MA, Solomon SD, Shah AM. ");
			sb.Append("Prognostic importance of left ventricular mechanical dyssynchrony in heart failure with preserved ejection fraction. ");
			sb.Append("Eur J Heart Fail. 2017 Aug;19(8):1043-1052. doi: 10.1002/ejhf.789. Epub 2017 Mar 21.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "28322009", null, null, null));

			sb = new StringBuilder("Santos AB, Roca GQ, Claggett B, Sweitzer NK, Shah SJ, Anand IS, Fang JC, Zile MR, Pitt B, Solomon SD, Shah AM. ");
			sb.Append("Prognostic Relevance of Left Atrial Dysfunction in Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("2016 Apr;9(4):e002763. doi: 10.1161/CIRCHEARTFAILURE.115.002763.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "27056882", null, null, null));	

			sb = new StringBuilder("Joseph J, Claggett BC, Anand IS, Fleg JL, Huynh T, Desai AS, Solomon SD, O’Meara E, Mckinlay S, Pitt B, Pfeffer MA, Lewis EF. ");
			sb.Append("QRS Duration Is a Predictor of Adverse Outcomes in Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("JACC Heart Fail. 2016 Jun;4(6):477-86. doi: 10.1016/j.jchf.2016.02.013. Epub 2016 Mar 30.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "27039126", null, null, null));

			sb = new StringBuilder("Lewis EF, Kim HY, Claggett B, Spertus J, Heitner JF, Assmann SF, Kenwood CT, Solomon SD, Desai AS, Fang JC, McKinlay SA, Pitt BA, Pfeffer MA; TOPCAT Investigators. ");
			sb.Append("Impact of Spironolactone on Longitudinal Changes in Health-Related Quality of Life in the Treatment of Preserved Cardiac Function Heart Failure With an Aldosterone Antagonist Trial. ");
			sb.Append("Circ Heart Fail. 2016 Mar;9(3):e001937. doi: 10.1161/CIRCHEARTFAILURE.114.001937.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "26962133", null, null, null));

			sb = new StringBuilder("Shah AM, Claggett B, Sweitzer NK, Shah SJ, Deswal A, Anand IS, Fleg JL, Pitt B, Pfeffer MA, Solomon SD. P");
			sb.Append("Prognostic Importance of Changes in Cardiac Structure and Function in Heart Failure With Preserved Ejection Fraction and the Impact of Spironolactone. ");
			sb.Append("Circ Heart Fail. 2015 Nov;8(6):1052-8. doi: 10.1161/CIRCHEARTFAILURE.115.002249. Epub 2015 Oct 16.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "26475142", null, null, null));
				
			sb = new StringBuilder("Solomon SD, Claggett B, Lewis EF, Desai A, Anand I, Sweitzer NK, O’Meara E, Shah SJ, McKinlay S, Fleg JL, Sopko G, Pitt B, Pfeffer MA; TOPCAT Investigators. ");
			sb.Append("Influence of ejection fraction on outcomes and efficacy of spironolactone in patients with heart failure with preserved ejection fraction. ");
			sb.Append("Eur Heart J. 2016 Feb 1;37(5):455-62. doi: 10.1093/eurheartj/ehv464. Epub 2015 Sep 15.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "26374849", null, null, null));

			sb = new StringBuilder("Shah AM, Claggett B, Sweitzer NK, Shah SJ, Anand IS, Liu L, Pitt B, Pfeffer MA, Solomon SD. ");
			sb.Append("Prognostic Importance of Impaired Systolic Function in Heart Failure With Preserved Ejection Fraction and the Impact of Spironolactone. ");
			sb.Append("Circulation. 2015 Aug 4;132(5):402-14. doi: 10.1161/CIRCULATIONAHA.115.015884. Epub 2015 Jun 30.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "26130119", null, null, null));

			sb = new StringBuilder("Borlaug BA, Lewis GD, McNulty SE, Semigran MJ, LeWinter M, Chen H, Lin G, Deswal A, Margulies KB, Redfield MM. E");
			sb.Append("Effects of sildenafil on ventricular and vascular function in heart failure with preserved ejection fraction. ");
			sb.Append("Circ Heart Fail. 2015 May;8(3):533-41. doi: 10.1161/CIRCHEARTFAILURE.114.001915. Epub 2015 Mar 17.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "25782985", null, null, null));

			sb = new StringBuilder("Hamo CE, Heitner JF, Pfeffer MA, Kim HY, Kenwood CT, Assmann SF, Solomon SD, Boineau R, Fleg JL, Spertus JA, Lewis EF. ");
			sb.Append("Baseline distribution of participants with depression and impaired quality of life in the Treatment of Preserved Cardiac Function Heart Failure with an Aldosterone Antagonist Trial. ");
			sb.Append("Circ Heart Fail. 2015 Mar;8(2):268-77. doi: 10.1161/CIRCHEARTFAILURE.114.001838. Epub 2015 Feb 3.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "25648577", null, null, null));

			sb = new StringBuilder("Mak GJ, Ledwidge MT, Watson CJ, Phelan DM, Dawkins IR, Murphy NF, Patle AK, Baugh JA, McDonald KM. ");
			sb.Append("Natural history of markers of collagen turnover in patients with early diastolic dysfunction and impact of eplerenone. ");
			sb.Append("J Am Coll Cardiol. 2009 Oct 27;54(18):1674-82. doi: 10.1016/j.jacc.2009.08.021.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "19850207", null, null, null));

			fs.studylinks!.Add(new StudyLink(sd_sid, "Link to PubMed Identification (ID) #22137068 publication in the American Heart Journal", "http://www.ahjonline.com/article/S0002-8703%2811%2900688-0/abstract"));
			fs.studylinks.Add(new StudyLink(sd_sid, "Link to PubMed ID #23258572 publication in Circulation: Heart Failure", "http://circheartfailure.ahajournals.org/content/6/2/184.long"));			
			fs.studylinks.Add(new StudyLink(sd_sid, "Link to PubMed ID #24249049 publication in Circulation: Heart Failure", "http://circheartfailure.ahajournals.org/content/7/1/104.long"));
			fs.studylinks.Add(new StudyLink(sd_sid, "Link to PubMed ID #24716680 publication in the New England Journal of Medicine", "http://www.nejm.org/doi/full/10.1056/NEJMoa1313731"));
			fs.studylinks.Add(new StudyLink(sd_sid, "Link to PubMed ID #25122186 publication in Circulation: Heart Failure", "http://circheartfailure.ahajournals.org/content/7/5/740.long"));
			fs.studylinks.Add(new StudyLink(sd_sid, "Link to PubMed ID #25406305 publication in Circulation", "http://circ.ahajournals.org/content/early/2014/11/18/CIRCULATIONAHA.114.013255.long"));

			fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Heart failure as defined by at least one of symptom (paroxysmal nocturnal dyspnea; orthopnea; or dyspnea on mild or moderate exertion) at the time of screening and at least one sign (any rales post cough; jugular venous pressure(JVP) greater than or equal to 10cm of water(H2O); lower extremity edema; or chest x-ray demonstrating pleural effusion, pulmonary congestion, or cardiomegaly) within 12 months prior to study entry:"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "left ventricular ejection fraction greater than or equal to 45% (per local reading); the ejection fraction must have been obtained within 6 months prior to randomization and after any MI or other event that would affect ejection fraction"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Controlled systolic blood pressure(BP), defined as a target systolic BP less than 140 mm Hg; participants with BP up to and including 160 mm Hg are eligible for enrollment if they are on three or more medications to control BP"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Serum potassium less than 5.0 mmol/L prior to randomization"));
			fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "At least one hospital admission for which heart failure was a major component of the hospitalization some time within the 12 months prior to study entry OR brain natriuretic peptide (BNP) greater than or equal to 100pg/ml or N-terminal pro-BNP greater than or equal to 360pg/ml within the 60 days prior to study entry"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "Women of child-bearing potential must have a negative serum/urine pregnancy test within 72 hours prior to randomization, must not be lactating, and must agree to use an effective method of contraception during the entire course of study participation"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr assumed", "@", 1, "n.07", "Willing to comply with scheduled visits"));
			fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr assumed", "@", 1, "n.08", "Informed consent form signed by the subject prior to participation in the trial"));
			
			fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.01", "Severe systemic illness with an expected life expectancy of less than 3 years"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr assumed", "@", 1, "e.02", "Chronic pulmonary disease requiring home O2, oral steroid therapy, or hospitalization for exacerbation within 12 months of study entry, or significant chronic pulmonary disease in the opinion of the investigator"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr assumed", "@", 1, "e.03", "Known infiltrative or hypertrophic obstructive cardiomyopathy or known pericardial constriction"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr assumed", "@", 1, "e.04", "Primary hemodynamically significant uncorrected valvular heart disease, obstructive or regurgitant, or any valvular disease expected to lead to surgery during the trial"));	  
			fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr assumed", "@", 1, "e.05", "Atrial fibrillation with a resting heart rate greater than 90 bpm"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr assumed", "@", 1, "e.06", "MI in the past 90 days"));	 
			fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr assumed", "@", 1, "e.07", "Coronary artery bypass graft surgery in the past 90 days"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr assumed", "@", 1, "e.08", "Percutaneous coronary intervention in the past 30 days"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr assumed", "@", 1, "e.09", "Heart transplant recipient"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "cr assumed", "@", 1, "e.10", "Currently implanted left ventricular assist device"));	
			fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "cr assumed", "@", 1, "e.11", "Stroke in past 90 days"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "cr assumed", "@", 1, "e.12", "Systolic BP (SBP) greater than 160 mm Hg"));	 
			fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "cr assumed", "@", 1, "e.13", "Known orthostatic hypotension"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "cr assumed", "@", 1, "e.14", "Gastrointestinal disorder that could interfere with study drug absorption"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr assumed", "@", 1, "e.15", "Use of any aldosterone antagonist or potassium sparing medication in the last 14 days or any known condition that would require the use of an aldosterone antagonist during study participation;"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr assumed", "@", 1, "e.16", "Known intolerance to aldosterone antagonists"));	  
			fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr assumed", "@", 1, "e.17", "Current lithium use"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr assumed", "@", 1, "e.18", "Current participation (including prior 30 days) in any other therapeutic trial"));	 
			fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "cr assumed", "@", 1, "e.19", "Any condition that, in the opinion of the investigator, may prevent the participant from adhering to the trial protocol"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "cr assumed", "@", 1, "e.20", "History of hyperkalemia (serum potassium greater than or equal to 5.5mmol/L) in the past 6 months or serum potassium greater than or equal to 5.0mmol/L within the past 2 weeks"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "cr assumed", "@", 1, "e.21", "Severe renal dysfunction, defined as an estimated glomerular filtration rate(GFR) less than 30ml/min. Participants with serum creatinine greater than or equal to 2.5mg/dl are also excluded even if their GFR is greater than or equal to 30ml/min"));	    
			fs.iec.Add(new StudyIEC(sd_sid, 30, 2, "cr assumed", "@", 1, "e.22", "Known chronic hepatic disease, defined as aspartate aminotransferase(AST) and alanine aminotransferase(ALT) levels greater than 3.0 times the upper limit of normal as read at the local lab."));	  
			
			fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3865483, "Argentina", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3469034, "Brazil", null));
            fs.countries.Add(new StudyCountry(sd_sid, 6251999, "Canada", null));
            fs.countries.Add(new StudyCountry(sd_sid, 614540, "Georgia", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2017370, "Russia", null));
             
			fs.sites!.Add(new StudyLocation(sd_sid, null, "University of Alabama at Birmingham", null, null, "Birmingham", 6252001, "United States", null));
			fs.sites.Add(new StudyLocation(sd_sid, null, "Cardiovascular Consultants, Ltd.", null, null, "Glendale", 6252001, "United States", null));
			fs.sites.Add(new StudyLocation(sd_sid, null, "Carl T. Hayden VA Medical Center", null, null, "Phoenix", 6252001, "United States", null));
			fs.sites.Add(new StudyLocation(sd_sid, null, "Central Arkansas Veterans Healthcare System", null, null, "Little Rock", 6252001, "United States", null));
			fs.sites.Add(new StudyLocation(sd_sid, null, "Saint-Petersburg State Healthcare Institution \"City Alexander's Hospital\"", null, null, "Saint Petersburg", 2017370, "Russia", null));
			fs.sites.Add(new StudyLocation(sd_sid, null, "Saint-Petersburg State Institution of Health Protection, \"City Hosptial # 15\"", null, null, "Saint Petersburg", 2017370, "Russia", null));
			fs.sites.Add(new StudyLocation(sd_sid, null, "Saint-Petersburg State Health Institution \"Pokrovskaya City Hospital\"", null, null, "Saint-Petersburg", 2017370, "Russia", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Federal State Institution", null, null, "Saratov", 2017370, "Russia", null));
			fs.sites.Add(new StudyLocation(sd_sid, null, "State Educational institution of Higher Professional Education \"Volgograd State Medical University o", null, null, "Volgograd", 2017370, "Russia", null));
			fs.sites.Add(new StudyLocation(sd_sid, null, "State Health Care Institution \"Voronezh Regional Clinical Consultative & Diagnostic Centre\"", null, null, "Voronezh", 2017370, "Russia", null));
            
			// Data Objects
	        
			// 1) Trial registry entry

			string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
			string ob_title = display_title + " :: CTG registry entry";
			StudyDataObject sdo = CreateEmptyStudyDataObject();
            
			sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
				null, 9, 2004, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
				"https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
			sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2004 Oct 15 (est.)", 2004, 10, 15, null, null, null, null));
			sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2015 Mar 2 (est.)", 2015, 3, 2, null, null, null, null));
	       
			fs.data_objects!.Add(sdo);
			
			// 2) Trial results entry
			
			sd_oid = sd_sid + " :: 28 :: CTG results entry";
			ob_title = display_title + " :: CTG results entry";
			sdo = CreateEmptyStudyDataObject();
			
			sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG results entry", null, ob_title,
				null, 9, 2015, 23, 28, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
				"https://clinicaltrials.gov/study/" + sd_sid + "?tab=results", true, 39, null, null, null));
			sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2015 Mar 2 (est.)", 2015, 3, 2, null, null, null, null));
			sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2015 Mar 2 (est.)", 2015, 3, 2, null, null, null, null));
			
			fs.data_objects!.Add(sdo);
			
			return fs; 
        
        }
        
        if (sd_sid == "NCT04419571")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Outcomes in Emergency Laparotomies During COVID-19 Pandemic";
	        StringBuilder sb = new StringBuilder("NLR has previously been observed to correlate with complications in upper GI (1) and colorectal (2) surgery. ");
	        sb.Append("The investigators sought to assess if a similar correlation can be identified in emergency general surgical patients and if the presence of suspected or confirmed COVID-19 may impact on this.\n\n"); 
	        sb.Append("Given the heterogeneity of emergency general surgery the investigators therefore plan to perform a retrospective review of patients having "); 
	        sb.Append("Given the heterogeneity of emergency general surgery the investigators therefore plan to perform a retrospective review of patients having "); 
	        sb.Append("laparotomies only at a single NHS site during COVID-19 pandemic. Assessment of outcomes and Neutrophil:lymphocyte ratio as a predictor of "); 
	        sb.Append("outcomes will be completed. Outcomes will be completed in line with the recent COVIDSurg study criteria (3). The primary outcome is 30-day mortality. "); 
	        sb.Append("Secondary outcomes are 7-day mortality, re-operation, length of stay, post-operative respiratory failure, post-operative ARDS (Acute Respiratory "); 
	        sb.Append("Distress Syndrome), post-operative sepsis and ITU (Intensive Therapy Unit)/HDU (High Dependency Unit) admission."); 
	        string brief_desc = sb.ToString();
	        sb = new StringBuilder("(As of July 2020): All collected IPD regardless of inclusion in final publication\n");
	        sb.Append("Time frame: Data will be available from completion of study for 10 years\n"); 
	        sb.Append("Access Criteria: On request\n"); 
	        sb.Append("Information available: Study Protocol, Statistical Analysis Plan (SAP), Clinical Study Report (CSR)"); 
	        string dss = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2020, 3, 12, 21, "94", 900,
		        18, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2020 Jun 4", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "133196", 14, null, 
		        "Barking, Havering and Redbridge University Hospitals NHS Trust", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "Emergency Laparotomies and Outcomes During the COVID-19 Pandemic - a Retrospective Cohort Study", 16, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Nader Habib Bedwani", "Barking, Havering and Redbridge University Hospitals NHS Trust", 
		        null, "Barking, Havering and Redbridge University Hospitals NHS Trust", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Barking, Havering and Redbridge University Hospitals NHS Trust", null));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 30, 600));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 31, 700));   //  
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "COVID-19", null, null, "RA01", "COVID-19"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Emergency General Surgery", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Emergencies", 14, "D000004630", null, null));

	        fs.ipd_info!.Add(new AvailableIPD(sd_sid, "285260", "Individual Participant Data Set", 
		                                      "https://www.myresearchproject.org.uk/", 
		        "Data collection template available on IRAS (Integrated Research Application System) registration"));
	        fs.ipd_info.Add(new AvailableIPD(sd_sid, "285260", "Statistical Analysis Plan", 
		                                      "https://www.myresearchproject.org.uk/", 
		        "Statistical analysis plan as part of protocol available on IRAS (Integrated Research Application System) registration"));
	        fs.ipd_info.Add(new AvailableIPD(sd_sid, "285260", "Study Protocol", 
		                                      "https://www.myresearchproject.org.uk/", 
		        "Protocol available on IRAS (Integrated Research Application System) registration")); 
	         
	        fs.studylinks!.Add(new StudyLink(sd_sid, "CovidSurg Cohort Study. Globalsurg", 
		                        "https://globalsurg.org/covidsurgcohortstudy"));
	        
	        fs.countries!.Add(new StudyCountry(sd_sid, 2635167, "United Kingdom", null));
	        
	        fs.sites!.Add(new StudyLocation(sd_sid, null, "Queen's Hospital", null, null, "Romford", 2635167, "United Kingdom", null));
            
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1001, "cr assumed", "@", 1, "n.0A", "Patients undergoing emergency laparotomy (change made due to heterogeneity of emergency general surgery)"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1002, "cr assumed", "@", 1, "e.0A", "Inherited or acquired immunodeficiency (which may directly skew NLR)"));	       
	        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
	        string ob_title = display_title + " :: CTG registry entry";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
		        null, 9, 2020, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
		        "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2020 Jun 5", 2020, 6, 5, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2020 Jul 23", 2020, 7, 23, null, null, null, null));
	       
	        fs.data_objects!.Add(sdo);
	        
	        // 2) Study Protocol and Statistical Analysis Plan
	        
	        sd_oid = sd_sid + " :: 74 :: Study Protocol and Statistical Analysis Plan";
	        ob_title = display_title + " :: Study Protocol and Statistical Analysis Plan";
	        sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Study Protocol and Statistical Analysis Plan", null, ob_title,
		        null, 9, 2020, 23, 74, 100120, "ClinicalTrials.gov", null, "en", 11, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
		        "https://storage.googleapis.com/ctgov2-large-docs/71/NCT04419571/Prot_SAP_000.pdf", 
		        true, 11, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2020 Jun 4", 2020, 6, 4, null, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        return fs;	        
        }
        
        if (sd_sid == "NCT04406714")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Scaling CRC Screening Through Outreach, Referral, and Engagement (SCORE)";
	        StringBuilder sb = new StringBuilder("Colorectal cancer (CRC) is a leading cause of cancer death in the United States. In North Carolina, as in many parts of the ");
	        sb.Append("CRC screening is substantially underused in vulnerable and marginalized populations. Uninsured, underinsured, and medically underserved populations rely "); 
	        sb.Append("on federally qualified health centers (FQHCs) for their healthcare and thus patients served by North Carolina’s FQHCs are particularly likely to benefit "); 
	        sb.Append("from efforts and resources to improve CRC screening. The United States Preventive Services Task Force recommends several tests to screen for CRC, "); 
	        sb.Append("including annual screening with a fecal immunochemical test (FIT), for patients ages 50-75 years. Programs that include mailing FITs to patients have "); 
	        sb.Append("shown promise as an effective means of increasing CRC screening, including for vulnerable populations.\n\n"); 
	        sb.Append("This randomized controlled trial is designed to assess the effectiveness, feasibility, acceptability, and cost-effectiveness of mailing FITs "); 
	        sb.Append("from a central location to patients served by FQHCs. This study also assesses the effectiveness, feasibility, acceptability, and costs of ");
	        sb.Append("delivering patient navigation from a central location to facilitate follow-up colonoscopy for patients with a positive (abnormal) FIT result. "); 
	        sb.Append("To assess adherence to the United States Preventive Services Task Force recommendations for annual screening with FIT, we will mail eligible "); 	        
	        sb.Append("participants one FIT per year for up to two years."); 
	        string brief_desc = sb.ToString();
	        sb = new StringBuilder("(As of May 2021): As outlined in the Notice of Award, each study site must make its Limited Data Set ");
	        sb.Append("(LDS) accessible to other sites in the ACCSIS consortium. Information Management Services (IMS) will serve as the "); 
	        sb.Append("repository and have responsibility for creating a Limited Consolidated Data Set (LCDS) for analytic use of researchers "); 
	        sb.Append("both within and external to the ACCSIS consortium. Dataset Items in the LDS are defined by the Common Data Elements. ");
	        sb.Append("There also will be a \"public use data set\" that consists of the Common Data Elements, available to external researchers. "); 
	        sb.Append("IMS will use a systematic process to remove identifiers. In addition, all data that underlie results in publications "); 
	        sb.Append("will be available per Cancer Moonshot Notice of Award.\n"); 
	        sb.Append("Time frame: The IPD sharing time frame has not been defined at this time.\n"); 
	        sb.Append("Access Criteria: There are 2 classes of dataset requests: public use and special. Requests are submitted via the IMS website. "); 
	        sb.Append("Requestors electronically sign and submit necessary forms, including an agreement to acknowledge ACCSIS in publications and presentations. "); 
	        sb.Append("A public use dataset containing common data elements is made available to external researchers by application. IMS responds to public use "); 
	        sb.Append("dataset applications by sending the requestor one-time access to a data download link. External researchers may also request a more "); 
	        sb.Append("customized data set. Requestors must submit a brief concept form or ancillary studies form, for preliminary review by the ACCSIS "); 
	        sb.Append("Steering Committee (SC), before invitation to submit a full proposal. Full proposals receive administrative review by NCI and RTI before "); 
	        sb.Append("being sent to the SC for review and approval. Requestors report every 6 months and published articles or conference presentations "); 
	        sb.Append("to RTI. Requestors are encouraged to make articles available through PubMed Central.\n");
	        sb.Append("Information available: Study Protocol"); 
	        string dss = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2020, 7, 11, 14, "4000", 900, 
		        50, 17, 75, 17, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2020 May 22", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "LCCC2056", 14, null, 
		        "UNC Lineberger Comprehensive Cancer Center", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "4UH3CA233251-02", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88" , null,
		        "https://projectreporter.nih.gov/reporterapi.cfm?PROJECTNUM=4UH3CA233251-02&Fy=all"));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, 
		        "Scaling Colorectal Cancer Screening Through Outreach, Referral, and Engagement (SCORE): A State-Level Program to Reduce Colorectal Cancer Burden in Vulnerable Populations", 
		        16, "en", 11, false, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "SCORE", 14, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Daniel S Reuland", "University of North Carolina, Chapel Hill", 
		        100209, "University of North Carolina, Chapel Hill", "https://ror.org/0130frc33"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "UNC Lineberger Comprehensive Cancer Center", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "National Cancer Institute (NCI)", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "East Carolina University", null));

		    fs.features!.Add(new StudyFeature(sd_sid, 20, 100));  // 
		    fs.features.Add(new StudyFeature(sd_sid, 21, 420));   // 
		    fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
		    fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
		    fs.features.Add(new StudyFeature(sd_sid, 24, 505));   // 

	        fs.topics!.Add(new StudyTopic(sd_sid, 11, "Cancer Screening", null, null, null, null));
		    fs.topics.Add(new StudyTopic(sd_sid, 11, "Colonoscopy", null, null, null, null));
		    fs.topics.Add(new StudyTopic(sd_sid, 11, "Community Health Centers", null, null, null, null));
		    fs.topics.Add(new StudyTopic(sd_sid, 11, "Implementation Science", null, null, null, null));
		    fs.topics.Add(new StudyTopic(sd_sid, 11, "Patient Navigation", null, null, null, null));
		   
		    fs.conditions!.Add(new StudyCondition(sd_sid, "Colorectal Neoplasms", 14, "D000015179", "B5-2B9", "Malignant neoplasms of large intestine"));

            fs.studylinks!.Add(new StudyLink(sd_sid, "UNC Lineberger Comprehensive Cancer Center Clinical Trials", "https://unclineberger.org/patientcare/clinical-trials"));

	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Age 45-75 years"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "At average risk for CRC (\"average risk\" is defined as those patients who do not have any of the following: documented history of CRC, colorectal neoplasms, colorectal polyps, colonic adenomas, family history of CRC among first degree relative [father, mother, sister, brother], or diagnosis of inflammatory bowel disease)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "No record of fecal occult blood test (FOBT)/FIT within the past 12 months or colonoscopy within 10 years, sigmoidoscopy within 5 years, barium enema within 5 years, or computed tomography (CT) colonography within 10 years of the EHR query date"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "No record of any CRC diagnosis or total colectomy"));
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "No record of comorbidities or screening contraindications, including dementia, hospice care, assisted living, end-stage renal disease, and other cancers (glioblastoma, pancreatic cancer, lung cancer, esophageal cancer, liver and bile duct cancer, mesothelioma)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "Has a complete North Carolina mailing address in the EHR\nActive patient of the clinic (seen within the past 18 months) at the time of randomization\nNo record of a positive (abnormal) FIT result in the first study round (Trial Ages 50-75 only)"));
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr assumed", "@", 1, "e.01", "Age younger than 45 years or older than 75 years"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.02", "Not at average risk for CRC (\"average risk\" is defined as those patients who do not have any of the following: documented history of CRC, colorectal neoplasms, colorectal polyps, colonic adenomas, family history of CRC among first degree relative [father, mother, sister, brother], or diagnosis of inflammatory bowel disease)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.03", "Record of FOBT/FIT within the past 12 months or colonoscopy within 10 years, sigmoidoscopy within 5 years, barium enema within 5 years, or CT colonography within 10 years of the EHR query date"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr assumed", "@", 1, "e.04", "Record of any CRC diagnosis or total colectomy"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr assumed", "@", 1, "e.05", "Record of comorbidities or screening contraindications, including dementia, hospice care, assisted living, end-stage renal disease, and other cancers (glioblastoma, pancreatic cancer, lung cancer, esophageal cancer, liver and bile duct cancer, mesothelioma)"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr assumed", "@", 1, "e.06", "Does not have a complete North Carolina mailing address in the EHR"));	 
	        fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr assumed", "@", 1, "e.07", "Not an active patient of the clinic (not seen within the past 18 months) at the time of randomization"));	 
	        fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr assumed", "@", 1, "e.08", "Record of a positive (abnormal) FIT result reported during the first study round (Trial Ages 50-75)"));	 
	        
	        fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
             
	        fs.sites!.Add(new StudyLocation(sd_sid, null, "Roanoke Chowan Community Health Center", null, null, "Ahoskie", 6252001, "United States", null));
	        fs.sites.Add(new StudyLocation(sd_sid, null, "Blue Ridge Health", null, null, "Hendersonville", 6252001, "United States", null));
	        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
	        string ob_title = display_title + " :: CTG registry entry";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
		        null, 9, 2020, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
		        "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2020 May 28", 2020, 5, 28, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Dec 7", 2022, 12, 7, null, null, null, null));
	       
	        fs.data_objects!.Add(sdo);

	        return fs;
        }
        
        if (sd_sid == "NCT03631199")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Study of Efficacy and Safety of Pembrolizumab Plus Platinum-based Doublet Chemotherapy With or Without Canakinumab in Previously Untreated Locally Advanced or Metastatic Non-squamous and Squamous NSCLC Subjects";
	        StringBuilder sb = new StringBuilder("This is a phase III study of pembrolizumab plus platinum-based doublet chemotherapy with or without canakinumab in previously ");
	        sb.Append("untreated locally advanced or metastatic non-squamous and squamous NSCLC subjects\n\n"); 
	        sb.Append("The study will assess primarily the safety and tolerability (safety run-in part) of pembrolizumab plus platinum-based doublet chemotherapy with canakinumab "); 
	        sb.Append("and then the efficacy (double-blind, randomized, placebo controlled part) of pembrolizumab plus platinum-based doublet chemotherapy with or without canakinumab."); 
	        string brief_desc = sb.ToString();
	        sb = new StringBuilder("(As of April 2022): Novartis is committed to sharing with qualified external researchers, access to patient-level ");
	        sb.Append("data and supporting clinical documents from eligible studies. These requests are reviewed and approved by an independent expert panel "); 
	        sb.Append("on the basis of scientific merit. All data provided is anonymized to respect the privacy of patients who have "); 
	        sb.Append("participated in the trial in line with applicable laws and regulations.\n\n"); 
	        sb.Append("This trial data is currently available according to the process described on www.clinicalstudydatarequest.com."); 
	        string dss = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2018, 12, 11, 15, "673", 900,
		        18, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2018 Aug 6", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "CACZ885U2301", 14, 100189, 
		        "Novartis", "https://ror.org/02f9zrr09", null, null));
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "2018-001547-32", 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        string title =
		        "A Randomized, Double-blind, Placebo-controlled, Phase III Study Evaluating the Efficacy and Safety of Pembrolizumab Plus Platinum-based Doublet Chemotherapy ";
	        title += "With or Without Canakinumab as First Line Therapy for Locally Advanced or Metastatic Non-squamous and Squamous Non-small Cell Lung Cancer Subjects (CANOPY-1)";
	        fs.titles.Add(new StudyTitle(sd_sid, title, 16, "en", 11, false, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "CANOPY-1", 14, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100189, "Novartis Pharmaceuticals", "https://ror.org/02f9zrr09"));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 

            fs.topics!.Add(new StudyTopic(sd_sid, 11, "ACZ885", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "canakinumab", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "cisplatin", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "nab-paclitaxel", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "squamous", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "non-squamous", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "hsCRP", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "IL-1β", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "PD-L1", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "CANOPY", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "CANOPY-1", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "platinum-based doublet chemotherapy", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "first line therapy", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "locally advanced", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "metastatic", null, null, null, null));
	        
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Paclitaxel", 14, "D000017239", "D000017239", "Paclitaxel"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Albumin-Bound Paclitaxel", 14, "D000068196", "D000068196", "Albumin-Bound Paclitaxel"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Carboplatin", 14, "D000016190", "D000016190", "Carboplatin"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Pembrolizumab", 14, "C000582435", "C000582435", "Pembrolizumab"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Pemetrexed", 14, "D000068437", "D000068437", "Pemetrexed"));	 	        
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Antibodies, Monoclonal", 14, "D000000911", "D000000911", "Antibodies, Monoclonal"));
       
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Lung Neoplasms", 14, "D000008175", "2C25", "Malignant neoplasms of bronchus or lung"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Carcinoma, Non-Small-Cell Lung", 14, "D000002289", "2C25", "Malignant neoplasms of bronchus or lung"));
            
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Histologically confirmed locally advanced stage IIIB or stage IV NSCLC for treatment in the first-line setting"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Known PD-L1 status determined by a Novartis designated central laboratory. A newly obtained tissue biopsy or an archival biopsy (block or slides) is required for PD-L1 determination (PD-L1 IHC 22C3 pharmDx assay), prior to study randomization. Note: For the safety run-in part, known PD-L1 status is not required."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Eastern Cooperative oncology group (ECOG) performance status of 0 or 1."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "At least 1 measurable lesion by RECIST 1.1"));
	        
            fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr assumed", "@", 1, "e.01", "Previous immunotherapy (e.g. anti-PD-1, anti-PD-L1, anti-PD-L2, anti-CTLA-4 antibody, or any other antibody or drug specifically targeting T-cell co-stimulation or immune checkpoint pathways)."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr assumed", "@", 1, "e.02", "Prior treatment with canakinumab or drugs of a similar mechanism of action (IL-1β inhibitor)."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr assumed", "@", 1, "e.03", "Subjects with epidermal growth factor receptor (EGFR) sensitizing mutations (identified in exons 19, 20, or 21), and/or ALK rearrangement by locally approved laboratory testing."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.04", "Previously untreated or symptomatic central nervous system (CNS) metastases or lepto-meningeal disease."));	  
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.05", "Subject with suspected or proven immune-compromised state or infections."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr assumed", "@", 1, "e.06", "Subject has prior to starting study drug: received live vaccination ≤3 months, had major surgery ≤4 weeks prior to starting study drug, has thoracic radiotherapy: lung fields ≤ 4 weeks, other anatomic sites ≤ 2 weeks, palliative radiotherapy for bone lesions ≤ 2 weeks."));	 
            fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr assumed", "@", 1, "e.07", "Other protocol-defined inclusion/exclusion criteria may apply."));	 
            
            fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3865483, "Argentina", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2077456, "Australia", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2782113, "Austria", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3469034, "Brazil", null));
             
            fs.countries.Add(new StudyCountry(sd_sid, 6251999, "Canada", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3895114, "Chile", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1814991, "China", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3686110, "Colombia", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3077311, "Czechia", null));
             
            fs.countries.Add(new StudyCountry(sd_sid, 2623032, "Denmark", null));
            fs.countries.Add(new StudyCountry(sd_sid, 660013, "Finland", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3017382, "France", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2921044, "Germany", null));
            fs.countries.Add(new StudyCountry(sd_sid, 390903, "Greece", null));
             
            fs.countries.Add(new StudyCountry(sd_sid, 1819730, "Hong Kong", null));
            fs.countries.Add(new StudyCountry(sd_sid, 719819, "Hungary", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2629691, "Iceland", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1269750, "India", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3175395, "Italy", null));

            fs.countries.Add(new StudyCountry(sd_sid, 1861060, "Japan", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1835841, "South Korea", null));
            fs.countries.Add(new StudyCountry(sd_sid, 272103, "Lebanon", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1733045, "Malaysia", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2750405, "Netherlands", null));
             
            fs.countries.Add(new StudyCountry(sd_sid, 3144096, "Norway", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1694008, "Philippines", null));
            fs.countries.Add(new StudyCountry(sd_sid, 798544, "Poland", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2264397, "Portugal", null));
            fs.countries.Add(new StudyCountry(sd_sid, 798549, "Romania", null));
             
            fs.countries.Add(new StudyCountry(sd_sid, 2017370, "Russia", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1880251, "Singapore", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3057568, "Slovakia", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2510769, "Spain", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2661886, "Sweden", null));
             
            fs.countries.Add(new StudyCountry(sd_sid, 2658434, "Switzerland", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1668284, "Taiwan", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1605651, "Thailand", null));
            fs.countries.Add(new StudyCountry(sd_sid, 298795, "Turkey", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2635167, "United Kingdom", null));
            fs.countries.Add(new StudyCountry(sd_sid, 1562822, "Vietnam", null));
             
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Pacific Shores Medical Group .", null, null, "Long Beach", 6252001, "United States", null));
			fs.sites.Add(new StudyLocation(sd_sid, null, "USC Kenneth Norris Comprehensive Cancer Center .", null, null, "Los Angeles", 6252001, "United States", null));
			fs.sites.Add(new StudyLocation(sd_sid, null, "Advent Health Cancer Institute", null, null, "Orlando", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Dana Farber Cancer Institute", null, null, "Boston", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Novartis Investigative Site", null, null, "Buenos Aires", 3865483, "Argentina", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Novartis Investigative Site", null, null, "Melbourne", 2077456, "Australia", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Novartis Investigative Site", null, null, "Murdoch", 2077456, "Australia", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Novartis Investigative Site", null, null, "Linz", 2782113, "Austria", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Novartis Investigative Site", null, null, "Salzburg", 2782113, "Austria", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Novartis Investigative Site", null, null, "Sao Paulo", 3469034, "Brazil", null));
             
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2018, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2018 Aug 15", 2018, 8, 15, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2023 June 13", 2023, 6, 13, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        if (sd_sid == "NCT03226236")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Vaccination With Dendritic Cells Pulsed With Autologous Tumor Homogenate in Combination With HD-IL2 and Immunomodulating Radiotherapy in Metastatic RCC";
	        StringBuilder sb = new StringBuilder("");
	        sb.Append("Single center, open-label Proof of Principle phase II trial to assess objective response (ORR).\n\n"); 
	        sb.Append("Three daily doses boost radiotherapy (XRT) at 6-12 Gy to at least 1, and up to a maximum of 5, metastatic fields, will be administrated on days "); 
	        sb.Append("-4 -3 -2 or -3 -2 -1 before the first and the third cycle of vaccine+IL-2. The first day of administration of vaccine is day +1 and of IL-2 is day +2.\n\n"); 
	        sb.Append("Treatment vaccine plus IL-2 (dose 18 MIU/m2/day in 500cc by continuous IV infusion for 72 hours) will be administered every 3 weeks up to 6 cycles.\n\n"); 
	        sb.Append("Total duration of the trial: 36 months\n\n"); 
	        sb.Append("Enrolment period: 24 months\n"); 
	        sb.Append("Treatment: maximum of 6 cycles (5 months) per patient\n"); 
	        sb.Append("Follow-up every three months until patient died (follow-up until PD and only survival contacts and subsequent therapy for metastatic disease after PD)."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2016, 3, 11, 11, "0", 900,
		       19, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2016 Sep 28", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "IRST189.03", 14, null, 
		        "Istituto Scientifico Romagnolo per lo Studio e la cura dei Tumori'", null, null, null));
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "2015-000556-14", 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "Vaccination With Dendritic Cells Pulsed With Autologous Tumor Homogenate in Combination With HD-IL2 and Immunomodulating Radiotherapy in Metastatic RCC: a Phase II Trial (RENALVax-2)",
		        16, "en", 11, false, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "RENALVax-2", 14, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Laura Ridolfi", "UO Immunoterapia e Laboratorio TCS, Istituto Scientifico Romagnolo per lo Studio e la Cura dei Tumori (IRST) Srl IRCCS", 
		        null, "Istituto Scientifico Romagnolo per lo Studio e la cura dei Tumori", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Istituto Scientifico Romagnolo per lo Studio e la cura dei Tumori", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 215));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 300));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 

            fs.topics!.Add(new StudyTopic(sd_sid, 11, "dendritic cells", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "autologous tumor homogenate", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "High Dose -IL2", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "immunomodulating radiotherapy", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "Vaccination", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "Secondary", null, null, null, null));
	        
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Interleukin-2", 14, "D000007376", "D000007376", "Interleukin-2"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Vaccines", 14, "D000014612", "D000014612", "Vaccines"));

	        fs.conditions!.Add(new StudyCondition(sd_sid, "Carcinoma, Renal Cell", 14, "D000002292", "2C90", "Malignant neoplasms of kidney, except renal pelvis"));
        
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Signed Written Informed Consent: patients must be willing and able to give written informed consent, that have to be given before starting of screening procedure."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Availability of autologous tumor tissue fulfilling acceptance criteria prescribed by the \"Product Specification File\"."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Patients must have histologically or cytologically confirmed RCC (all histology types except for urothelial cancer);"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Patients must have stage IV disease in progression after at least 1 TKI and/or antiangiogenetic and/or mTOR inhibitors therapy (patients must have finished prior treatments at least 4 weeks before the first IL2 dose)"));
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "Patients must have at least one measurable lesion, according to the irRC response criteria (see section 8 ), after asportation of tumor tissue for vaccine preparation. The tumor lesions that will be irradiated are excluded for response evaluation."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "Life expectancy of greater than 3 months."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr assumed", "@", 1, "n.07", "ECOG performance status 0-1"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr assumed", "@", 1, "n.08", "Patients must have organ and marrow function as defined below:"));
            fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "cr assumed", "@", 1, "n.09", "leukocytes >4000/µL"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "cr assumed", "@", 1, "n.10", "absolute neutrophil count >1,500/µL\nplatelets >100,000/µL"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 11, 1, "cr assumed", "@", 1, "n.11", "total bilirubin within normal institutional limits"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 12, 1, "cr assumed", "@", 1, "n.12", "AST(SGOT)/ALT(SGPT) <2.5 X institutional upper limit of normal"));
            fs.iec.Add(new StudyIEC(sd_sid, 13, 1, "cr assumed", "@", 1, "n.13", "creatinine < 1.5 mg/dl"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 14, 1, "cr assumed", "@", 1, "n.14", "haemoglobin >8.0 gm/dl"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 15, 1, "cr assumed", "@", 1, "n.15", "hematocrit <30%"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 16, 1, "cr assumed", "@", 1, "n.16", "ECG and echocardiogram within normal institutional limits"));
            fs.iec.Add(new StudyIEC(sd_sid, 17, 1, "cr assumed", "@", 1, "n.17", "Pulmonary function tests within normal institutional limits (to be performed only in patients with lung metastases or history of impaired lung function)"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 18, 1, "cr assumed", "@", 1, "n.18", "No contraindication for the use of vasopressor agents"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 19, 1, "cr assumed", "@", 1, "n.19", "Negative screening tests for HIV, HBV HCV and syphilis not older than 30 days before performing any of the GMP-regulated activities required (leukapheresis, collection of tumor biopsies to be used for tumor homogenate preparation);"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 20, 1, "cr assumed", "@", 1, "n.20", "Men and women aged > 18 years."));
            fs.iec.Add(new StudyIEC(sd_sid, 21, 1, "cr assumed", "@", 1, "n.21", "Women of childbearing potential (WOCBP) must be using an adequate method of contraception to avoid pregnancy throughout the study and for up 8 weeks after the study, in order to minimize the risk of pregnancy;"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 22, 1, "cr assumed", "@", 1, "n.22", "Men and women aged > 18 years."));	    

            fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr assumed", "@", 1, "e.01", "Patients who have positive tests to HCV, HBV, HIV, or syphilis (specific blood testing must be performed within 30 days before any GMP-regulated activity (leukapheresis and collection of tumor biopsies to be used for tumor homogenate preparation)."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr assumed", "@", 1, "e.02", "Patients who did not have prior lines of systemic therapy for advanced disease."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr assumed", "@", 1, "e.03", "Participation in another clinical trial with any investigational agents within 30 days prior to study screening."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr assumed", "@", 1, "e.04", "Uncontrolled intercurrent illness including, but not limited to, ongoing or active infection, symptomatic congestive heart failure, unstable angina pectoris, cardiac arrhythmia, or psychiatric illness/social situations that would limit compliance with study requirements (on physician's judgment)."));	  
            fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "cr assumed", "@", 1, "e.05", "Other known malignant neoplastic diseases in the patient's medical history with a disease-free interval of less than 3 years (except for previously treated basal cell carcinoma and in situ carcinoma of the uterine cervix);"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "cr assumed", "@", 1, "e.06", "Patients who have had chemotherapy or radiotherapy or immunotherapy within 4 weeks (6 weeks for nitrosoureas or mitomycin C) prior to entering the study or those who have not recovered from adverse events due to agents administered more than 4 weeks earlier."));	 
            fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "cr assumed", "@", 1, "e.07", "Patients with known brain metastases should be excluded from this clinical trial because of their poor prognosis and because they often develop progressive neurologic dysfunction that would confound the evaluation of neurologic and other adverse events."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 30, 2, "cr assumed", "@", 1, "e.08", "History of allergic reactions attributed to compounds of similar chemical or biologic composition to IL-2 or other agents used in the study."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 31, 2, "cr assumed", "@", 1, "e.09", "Any autoimmune disease which could be exacerbated by IL-2"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 32, 2, "cr assumed", "@", 1, "e.10", "A medical illness requiring chronic treatments with corticosteroids or other immunosuppressive agents"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 33, 2, "cr assumed", "@", 1, "e.11", "A history of significant cardiovascular disease, including myocardial infarction, congestive heart failure, primary cardiac arrhythmias, angina pectoris or cerebrovascular accident"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 34, 2, "cr assumed", "@", 1, "e.12", "HIV-positivity, whether or not symptomatic"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 35, 2, "cr assumed", "@", 1, "e.13", "Any contraindication to undergo leukapheresis as evaluated by transfusionist (e.g. severe anemia, piastrinopenia, oral anticoagulant therapy) or to undergo surgery."));	 
           
            fs.countries!.Add(new StudyCountry(sd_sid, 3175395, "Italy", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, "UO Immunoterapia e Laboratorio TCS, IRCCS IRST", null, null, "Meldola (FC)", 3175395, "Italy", null));
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2017, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2017 Jul 21", 2017, 7, 21, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2018 Nov 13", 2018, 11, 13, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
              
        }
       
        if (sd_sid == "NCT03167125")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Participatory Research to Advance Colon Cancer Prevention";
	        StringBuilder sb = new StringBuilder("The overall goal of this study is to test strategies to raise rates of colorectal cancer screening among the Latino ");
	        sb.Append("population in a federally qualified health center that operates multiple clinics. "); 
	        sb.Append("This intervention study will test automated and live prompts to a direct-mail fecal testing program in two phases.\n\n"); 
	        sb.Append("In Phase I (Years 01 - 02), the investigators will tailor and define intervention components using a community-based participatory research approach called boot camp translation (BCT). "); 
	        sb.Append("The ultimate design of the intervention will be defined by patient and provider feedback from BCT. The investigators will then conduct a three-arm patient-randomized "); 
	        sb.Append("comparative effectiveness trial in two pilot clinics to compare 1) automated prompts (i.e., automated phone calls, text messages) to alert and remind patients "); 
	        sb.Append("to complete screening, 2) live prompts (i.e., live phone calls), and 3) a combination approach of automated plus live prompts.\n\n"); 
	        sb.Append("In Phase II (Years 03 - 05), the investigators will spread and test the spread of the adapted intervention to additional clinics within "); 
	        sb.Append("the partnering health center using a two-arm main trial.\n\n"); 
	        sb.Append("Both phases will be guided by an advisory group of clinicians, researchers, policy makers, and patients."); 
	        string brief_desc = sb.ToString();

	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2017, 9, 11, 21, "27580", 900,
		        50, 17, 75, 17, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2017 May 24", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "1U01MD010665-01", 14, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null,
		        "https://reporter.nih.gov/quickSearch/1U01MD010665-01"));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "PROMPT", 14, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Gloria Coronado", "Kaiser Permanente", 
		        100335, "Kaiser Permanente", "https://ror.org/00t60zh31"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100335, "Kaiser Permanente", "https://ror.org/00t60zh31"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100257, "Oregon Health and Science University", "https://ror.org/009avj582"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "AltaMed Health Services", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 100));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 420));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 310));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
            
            fs.topics!.Add(new StudyTopic(sd_sid, 11, "colorectal cancer screening", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "cancer screening", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "pragmatic trial", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "boot camp translation", null, null, null, null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Colorectal Neoplasms", 14, "D000015179", "B5-2B9", "Malignant neoplasms of large intestine"));

			sb = new StringBuilder("Coronado GD, Nyongesa DB, Petrik AF, Thompson JH, Escaron AL, Younger B, Harbison S, Leo MC. ");
			sb.Append("Randomized Controlled Trial of Advance Notification Phone Calls vs Text Messages Prior to Mailed Fecal Test Outreach. ");
			sb.Append("Clin Gastroenterol Hepatol. 2021 Nov;19(11):2353-2360.e2. doi: 10.1016/j.cgh.2020.07.053. Epub 2020 Jul 30.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "32739569", null, null, null));

			sb = new StringBuilder("Coronado GD, Thompson JH, Petrik AF, Nyongesa DB, Leo MC, Castillo M, Younger B, Escaron A, Chen A. ");
			sb.Append("Patient-Refined Messaging for a Mailed Colorectal Cancer Screening Program: Findings from the PROMPT Study. ");
			sb.Append("J Am Board Fam Med. 2019 May-Jun;32(3):318-328. doi: 10.3122/jabfm.2019.03.180275.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31068396", null, null, null));

			sb = new StringBuilder("Thompson JH, Davis MM, Leo MC, Schneider JL, Smith DH, Petrik AF, Castillo M, Younger B, Coronado GD. ");
			sb.Append("Participatory Research to Advance Colon Cancer Prevention (PROMPT): Study protocol for a pragmatic trial. ");
			sb.Append("Contemp Clin Trials. 2018 Apr;67:11-15. doi: 10.1016/j.cct.2018.02.001. Epub 2018 Feb 9.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29408304", null, null, null));
 
			fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.0A", "Persons aged 50-75 years and not up-to-date with colorectal cancer screening"));	       
			fs.iec.Add(new StudyIEC(sd_sid, 2, 2, "cr assumed", "@", 1, "e.0A", "Persons having colorectal disease (e.g., ulcerative colitis or colectomy), personal history of colorectal cancer or colorectal disease, end-stage or life threatening diseases or, those known to be under hospice care or living in a skilled nursing facility may be excluded."));	       
			
            fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, "AltaMed Health Services", null, null, "Los Angeles", 6252001, "United States", null));
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2017, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2017 May 25", 2017, 5, 25, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Apr 5", 2022, 4, 5, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
            
        }
        
        if (sd_sid == "NCT03076619")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "A Clinical Study of Fundus Findings in Toxaemia of Pregnancy";
	        StringBuilder sb = new StringBuilder("Toxemia of pregnancy is a recognized entity for over 2000 years with its known complications ");
	        sb.Append("and fatality. Nowadays, a most accepted terminology for the following defined syndrome is \"hypertensive disorders "); 
	        sb.Append("in pregnancy\" given by American College of Obstetrics and Gynecology. It is an important cause of maternal and "); 
	        sb.Append("fetal morbidity and mortality. Pregnancy induced hypertension (PIH) was classified as gestational hypertension, "); 
	        sb.Append("preeclampsia, severe preeclampsia and eclampsia. PIH is a hypertensive disorder in pregnancy that occurs after 20 weeks "); 
	        sb.Append("of pregnancy in the absence of other causes of elevated blood pressure (BP) (BP >140/90 mmHg measured two times with "); 
	        sb.Append("at least of 4 hour interval) in combination with generalized edema and/or proteinuria (>300 mg per 24 hrs). When there "); 
	        sb.Append("is significant proteinuria it is termed as preeclampsia; seizure or coma as a consequence of PIH is "); 
	        sb.Append("termed as eclampsia. Preeclampsia was classified into mild and severe preeclampsia.\n\n"); 
	        sb.Append("mild eclampsia—BP >140/90 mmHg, proteinuria+, and/or mild edema of legs, Severe preeclampsia—BP >160/110 mmHg,proteinuria++ or ++++, "); 
	        sb.Append("headache, cerebral or visual disturbances, epigastric pain, impaired liver function tests and increase in serum creatinine.\n\n"); 
	        sb.Append("Proteinuria was tested using dipstick method as +=0.3 gm/L, ++=1 gm/L, and +++=3 gm/L.\n\n"); 
	        sb.Append("The pathological changes of this disease appear to be related to vascular endothelial dysfunction and its consequences (generalized vasospasm and "); 
	        sb.Append("capillary leak). Ocular involvement is common in PIH.Common symptoms are blurring of vision, photopsia, scotomas and diplopia. Visual symptoms may "); 
	        sb.Append("be the precursor of seizures.Progression of retinal changes correlates with progression of PIH and also with the fetal mortality due to similar vascular "); 
	        sb.Append("ischemic changes in placenta.Vasospastic manifestations are reversible and the retinal vessels rapidly return to normal after delivery. Ophthalmoscope "); 
	        sb.Append("should be rated next to the sphygmomanometer as an instrument of diagnostic importance in cases of PIH. Ophthalmoscopy does not only helps in "); 
	        sb.Append("diagnosing the disease but repeated observations assist in assessing the severity, progress of disease, response to treatment if any and ultimate outcome or prognosis."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2003, 11, 12, 21, "300", 905,
		        18, 17, 42, 17, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2016 Oct 30", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "Postgraduation Thesis'", 14, null, 
		        "B J Medical College, Ahmedabad", null, null, null));
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "DRKS00011324", 11, 100124, "Deutschen Register Klinischer Studien", null, null, null));
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "ChiCTR-OOC-16010171", 11, 100118, "Chinese Clinical Trial Register", null, null, null));
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "UMIN000024722", 11, 100156, "University Hospital Medical Information Network CTR", null, null, null));
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "U1111-1189-6165", 11, 100115, "International Clinical Trials Registry Platform", null, null, null));
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "TCTR20161221005", 11, 100131, "Thai Clinical Trials Register", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A Clinical Study of Fundus Findings in Toxaemia of Pregnancy (Pregnancy Induced Hypertension)", 16, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Rahul Bakhda", "Ex-Resident,M and J Western Regional Institute of Ophthalmology, BJMedical College and Civil Hospital Campus, Ahmedabad-380016Gujarat 07922680360 07922680314 Fax:07922680360", 
		        null, "BJMedical College and Civil Hospital Campus", null));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Rahul Navinchandra Bakhda", "B J Medical College, Ahmedabad", 
		        null, "B J Medical College, Ahmedabad", null));

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "B J Medical College, Ahmedabad", null));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "M and J Western Regional Institute of Ophthalmology,Ahmedabad", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 30, 630));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 31, 715));   //  

            fs.topics!.Add(new StudyTopic(sd_sid, 11, "ophthalmoscopy", null, null, null, null));
            
            fs.conditions!.Add(new StudyCondition(sd_sid, "Toxemia", 14, "D000014115", null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "Hypertension, Pregnancy-Induced", 14, "D000046110", null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "Pre-Eclampsia", 14, "D000011225", "JA24", "Pre-eclampsia"));
            fs.conditions.Add(new StudyCondition(sd_sid, "Hypertension", 14, "D000006973", "BA00", "Essential hypertension"));
            
			 sb = new StringBuilder("Bakhda RN. ");
			 sb.Append("Clinical study of fundus findings in pregnancy induced hypertension. ");
			 sb.Append("J Family Med Prim Care. 2016 Apr-Jun;5(2):424-429.");
			 fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "27843854", null, null, null));

             fs.studylinks!.Add(new StudyLink(sd_sid, "Published article", 
                   "http://www.jfmpc.com/article.asp?issn=2249-4863;year=2016;volume=5;issue=2;spage=424;epage=429;aulast=Bakhda"));

             fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.0A", "Cases of Pregnancy Induced Hypertension."));	       
             fs.iec.Add(new StudyIEC(sd_sid, 2, 2, "cr assumed", "@", 1, "e.0A", "Cases complicated by malignancy, renal, liver or other secondary manifestations."));	       
             
             fs.countries!.Add(new StudyCountry(sd_sid, 1269750, "India", null));
             
             fs.sites!.Add(new StudyLocation(sd_sid, null,
	             "M and J Western Regional Institute of Ophthalmology, B.J.Medical College and Civil Hospital Campus, Ahmedabad-380016.Gujarat. 07922680360 07922680314 Fax:07922680360", 
	             null, null, "Ahmedabad", 1269750, "India", null));
             
                
            // Data Objects
                
            // 1) Trial registry entry
    
            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
                null, 9, 2017, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
           
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
                "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2017 Mar 10", 2017, 3, 10, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2017 Mar 13", 2017, 3, 13, null, null, null, null));
           
            fs.data_objects!.Add(sdo);

            return fs;
        
        }
        
        if (sd_sid == "NCT02798978")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "A Phase I, 2-part (Part 1 Being a Single Dose Escalation and Part 2, a Parallel Group) Study of Toll-like Receptor (TLR4) Agonist (GSK1795091) in Healthy Subjects";
	        StringBuilder sb = new StringBuilder("This study is an ascending dose first-time-in-human study to determine the safety, tolerability, pharmacodynamic (PD), and ");
	        sb.Append("pharmacokinetics (PK) profile of GSK1795091 in healthy subjects. The results will support the design of future clinical trials "); 
	        sb.Append("of GSK1795091 administered to subjects with advanced malignancies in combination with immune system modulators.\n\n"); 
	        sb.Append("Part 1 will be a randomized, double-blind (sponsor-unblinded), placebo-controlled, single center, single dose escalation, sequential group evaluation of "); 
	        sb.Append("intravenously administered GSK1795091 to evaluate the safety and tolerability in healthy subjects. Part 2 will be an open-label, parallel group evaluation "); 
	        sb.Append("of 2 doses of GSK1795091 administered, either 1 week apart (Part 2, Cohort 1) or 2 weeks apart (Part 2, Cohort 2). In Part 2, on Day 1, subjects will "); 
	        sb.Append("receive intravenous GSK1795091 at a dose determined by results from Part 1. The total duration of this study is approximately 10 weeks from screening to the last study visit."); 
	        string brief_desc = sb.ToString();
	        sb = new StringBuilder("(As of November 2020): IPD for this study is available via the Clinical Study Data Request site.\n");
	        sb.Append("Time frame: IPD is available via the Clinical Study Data Request site (copy the URL below to your browser)"); 
	        sb.Append("Access Criteria: Access is provided after a research proposal is submitted and has received approval from the Independent Review "); 
	        sb.Append("Panel and after a Data Sharing Agreement is in place. Access is provided for an initial period of 12 months but an "); 
	        sb.Append("extension can be granted, when justified, for up to another 12 months.\n"); 
	        sb.Append("URL: https://www.clinicalstudydatarequest.com/Posting.aspx?ID=20725\n"); 
	        sb.Append("Information available: Study Protocol, Statistical Analysis Plan (SAP), Informed Consent Form (ICF), Clinical Study Report (CSR)"); 
	        string dss = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2017, 1, 11, 21, "42", 900,
		        18, 17, 50, 17, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2016 Jun 9", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "204685", 14, 100163, 
		        "GlaxoSmithKline", "https://ror.org/01xsqw823", null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "2016-000759-28'", 11, 100123, 
		        "EU Clinical Trials Register", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A 2-part Randomized, Double-blind (Sponsor-unblinded), Placebo-controlled, Ascending Dose and Parallel Group Study of TLR4 Agonist (GSK1795091) Administered to Healthy Subjects",
		        16, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100163, "GlaxoSmithKline", "https://ror.org/01xsqw823"));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 110));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 510));   // 
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Cancer", null, null, "2", "Neoplasms"));

            fs.topics!.Add(new StudyTopic(sd_sid, 11, "pharmacokinetics", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "safety", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "TLR4 agonist", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "GSK1795091", null, null, null, null));
    
			sb = new StringBuilder("Hug BA, Matheny CJ, Burns O, Struemper H, Wang X, Washburn ML. ");
			sb.Append("Safety, Pharmacokinetics, and Pharmacodynamics of the TLR4 Agonist GSK1795091 in Healthy Individuals: Results from a Randomized, Double-blind, Placebo-controlled, Ascending Dose Study. ");
			sb.Append("Clin Ther. 2020 Aug;42(8):1519-1534.e33. doi: 10.1016/j.clinthera.2020.05.022. Epub 2020 Jul 30.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "32739049", null, null, null));
            
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Between 18 and 50 years of age inclusive, at the time of signing the informed consent."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Healthy as determined by the investigator or medically qualified designee based on a medical evaluation including medical history, physical examination, laboratory tests, vital signs and 12-lead ECG. (A subject with a clinically insignificant abnormality or laboratory parameter(s) may be included only if the Investigator documents that the finding is unlikely to represent a safety risk and will not interfere with the study procedures.)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Body weight 55-95 kilogram (kg) and body mass index within the range 19-30 kg/meter (m)^2 (inclusive)."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Male or Female of non-childbearing potential:"));
            fs.iec!.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "Male subjects with female partners of child bearing potential must comply with the pre specified contraception requirements."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "A female subject is eligible to participate if she is not pregnant (as confirmed by a negative serum or urine human chorionic gonadotropin test), not lactating, and is either of non-reproductive potential or reproductive potential. If of reproductive potential, then the subject should agree to follow one of the options listed per GSK Modified List of Highly Effective Methods for Avoiding Pregnancy in Females of Reproductive Potential from 30 days prior to the first dose and until 30 days after the last dose of study medication The Investigator is responsible for ensuring that subjects understand how to properly use these methods of contraception"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr assumed", "@", 1, "n.07", "Capable of giving signed informed consent"));	    
	        
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.01", "History of any significant medical condition (e.g. cardiac, pulmonary, metabolic, renal, gastrointestinal, rheumatological, etc."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.02", "History of frequent (>1 per week) headache or myalgia, asthma, syncope."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr assumed", "@", 1, "e.03", "History of liver disease, or known hepatic or biliary abnormalities (with the exception of Gilbert's syndrome)."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr assumed", "@", 1, "e.04", "Alanine aminotransferase (ALT) and bilirubin >1.1×upper limit of normal (ULN; isolated bilirubin >1.5×ULN is acceptable if bilirubin is fractionated and direct bilirubin <35%)."));	  
            fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr assumed", "@", 1, "e.05", "Vital signs:"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr assumed", "@", 1, "e.06", "Systolic blood pressure (SBP) <90 and >140 milliliter of mercury (mmHg); diastolic BP <50 and >90 mmHg; heart rate (HR) <50 and >90 beats per minute (bpm); temperature >37.5 degree Celsius"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr assumed", "@", 1, "e.07", "Clinically significant ECG abnormality and/or HR < 50 and >90 bpm; PR interval >220 milliseconds (msec); QRS duration >120 msec; and QTcF > 450 msec"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr assumed", "@", 1, "e.08", "Anticipated requirement for any prescription medication during the study"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr assumed", "@", 1, "e.09", "History of regular alcohol consumption within 6 months of the study averaging a weekly intake of >14 drinks for males or >7 drinks for females or inability to abstain from alcohol from 1 day prior to the inpatient period of the study until discharge (one drink is equivalent to 8 grams of alcohol: 200 milliliter [mL] of beer, 100 mL of wine or 1 measure (25 mL) of spirits)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr assumed", "@", 1, "e.10", "Urinary cotinine levels indicative of smoking or history or regular use of tobacco or nicotine-containing products within 2 months prior to screening or inability to abstain from smoking during the study"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "cr assumed", "@", 1, "e.11", "History of sensitivity to any of the study medications, or components thereof or a history of drug or other allergy that, in the opinion of the investigator or Medical Monitor, contraindicates their participation"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "cr assumed", "@", 1, "e.12", "Presence of hepatitis B surface antigen, positive hepatitis C antibody test result at screening or within 3 months prior to first dose of study treatment. Subjects with positive Hepatitis C antibody due to prior resolved disease can be enrolled, only if a confirmatory negative Hepatitis C ribonucleic acid polymerase chain reaction test is obtained."));	 
            fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "cr assumed", "@", 1, "e.13", "A positive pre-study drug/alcohol screen."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "cr assumed", "@", 1, "e.14", "A positive test for human immunodeficiency antivirus antibody."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "cr assumed", "@", 1, "e.15", "Donation of blood or blood products in excess of 500 mL within a 56-day period."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr assumed", "@", 1, "e.16", "The subject has participated in a clinical trial and has received an investigational product within the following time period prior to the first visit (Day -2) in the current study: 30 days, 5 half-lives or twice the duration of the biological effect of the investigational product (whichever is longer)."));	  
            fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr assumed", "@", 1, "e.17", "Exposure to more than four new chemical entities within 12 months prior to the first visit (Day -2)."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr assumed", "@", 1, "e.18", "Exposure to GSK1795091 in a previous cohort of this study."));	 
            fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr assumed", "@", 1, "e.19", "Subject is unable to refrain from taking non-prescription drugs (including vitamins and dietary or herbal supplements), within 7 days prior to the first dose of study medication until completion of the follow-up visit, unless in the opinion of the investigator and sponsor, the medication will not interfere with the study."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "cr assumed", "@", 1, "e.20", "Subject is able to understand and communicate in German/or native language of the site. Subject, or close relative of the subject, is the investigator or a sub-investigator, research assistant, pharmacist, study coordinator, or other staff directly involved with the conduct of the study at that site"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "cr assumed", "@", 1, "e.21", "Vulnerable subjects (eg subjects kept in detention)"));	 
           
            fs.countries!.Add(new StudyCountry(sd_sid, 2921044, "Germany", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, "GSK Investigational Site", null, null, "Berlin",2921044, "Germany", null));
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2016, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2016 Jun 14 (est.)", 2016, 6, 14, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2020 Nov 27", 2020, 11, 27, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Trial results entry
			
            sd_oid = sd_sid + " :: 28 :: CTG results entry";
            ob_title = display_title + " :: CTG results entry";
            sdo = CreateEmptyStudyDataObject();
			
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG results entry", null, ob_title,
	            null, 9, 2019, 23, 28, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid + "?tab=results", true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2019 Jun 10", 2019, 6, 10, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2020 Nov 27", 2020, 11, 27, null, null, null, null));

            fs.data_objects!.Add(sdo);
            
            // 3) Study Protocol
            
            sd_oid = sd_sid + " :: 11 :: Study Protocol";
            ob_title = display_title + " :: Study Protocol";
            sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Study Protocol", null, ob_title,
	            null, 9, 2018, 23, 11, 100120, "ClinicalTrials.gov", null, "en", 11, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://storage.googleapis.com/ctgov2-large-docs/78/NCT02798978/Prot_000.pdf", 
	            true, 11, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2017 Apr 12", 2017, 4, 12, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 12, false, "2018 May 31", 2018, 5, 31, null, null, null, null));
            
            fs.data_objects!.Add(sdo);
            
            // 4) Statistical Analysis Plan
            
            sd_oid = sd_sid + " :: 22 :: Statistical Analysis Plan";
            ob_title = display_title + " :: Statistical Analysis Plan";
            sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Statistical Analysis Plan", null, ob_title,
	            null, 9, 2018, 23, 22, 100120, "ClinicalTrials.gov", null, "en", 11, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://storage.googleapis.com/ctgov2-large-docs/78/NCT02798978/SAP_001.pdf", 
	            true, 11, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2017 Nov 19", 2017, 11, 19, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 12, false, "2018 May 31", 2018, 5, 31, null, null, null, null));
            
            fs.data_objects!.Add(sdo);
            
            return fs;
     
        }
        
        if (sd_sid == "NCT03786900")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Fecal Microbiota Transplantation (FMT): PRIM-DJ2727";
	        StringBuilder sb = new StringBuilder("The Fecal Microbiota Transplantation (FMT) product PRIM-DJ2727 is prepared from human stool from a healthy, screened donor.\n\n");
	        sb.Append("Requestors will contact the study team about the product (PRIM-DJ2727) by email, visit, or phone call. A screening list for donors "); 
	        sb.Append("will be provided to make sure that the list fits the requestor’s requirements. A basic fee will be requested to recover the cost of "); 
	        sb.Append("making the product. After an agreement is made, a contract will be signed between the 2 parties. A week before the treatment, requestors "); 
	        sb.Append("will contact the study team for possible FMT product delivery. Delivery method will be confirmed for delivery by personnel (within 10 "); 
	        sb.Append("minutes driving distance) or by using FedEx services. Each delivered product will have an approved delivery form signed "); 
	        sb.Append("and dated by both the person who prepared the delivery and the person who received the package."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, null, null, 14, 12, null, 915,
		        null, null, null, null, 0);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2018 Dec 11", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "HSC-SPH-15-0991", 14, null, 
		        "The University of Texas Health Science Center, Houston", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 70, "Herbert DuPont", "he University of Texas Health Science Center, Houston'", 
		        null, "he University of Texas Health Science Center, Houston'", null));

	        fs.conditions!.Add(new StudyCondition(sd_sid, "Recurrent Clostridium Difficile Infection", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Multidrug-resistant Klebsiella Pneumoniae Urinary Tract Infection", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Infection", 14, "D000007239",  "1", "Certain infectious or parasitic diseases"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Communicable Diseases", 14, "D000003141", "1", "Certain infectious or parasitic diseases"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Urinary Tract Infections", 14, "D000014552", "GC08", "Urinary tract infection, site not specified"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Clostridium Infections", 14, "D000003015", null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Pneumonia", 14, "D000011014", "CA40", "Pneumonia"));

	        fs.relationships!.Add(new StudyRelationship(sd_sid, 24, "NCT02449174"));
	        fs.relationships!.Add(new StudyRelationship(sd_sid, 24, "NCT02318992"));
	        
            // no location list, iec - no IEC (!)
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2018, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2018 Dec 26", 2018, 12, 26, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2023 May 24", 2023, 5, 24, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
            
        }
        
        if (sd_sid == "NCT02562716")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "S1505: Combination Chemotherapy or Gemcitabine Hydrochloride and Paclitaxel Albumin-Stabilized Nanoparticle Formulation Before Surgery in Treating Patients With Pancreatic Cancer That Can Be Removed by Surgery";
	        StringBuilder sb = new StringBuilder("This randomized phase II trial studies how well fluorouracil, irinotecan hydrochloride, and ");
	        sb.Append("oxaliplatin (combination chemotherapy) works and compares to gemcitabine hydrochloride and paclitaxel albumin-stabilized nanoparticle formulation "); 
	        sb.Append("before surgery in treating patients with pancreatic cancer that can be removed by surgery. Drugs used in chemotherapy, such as fluorouracil, "); 
	        sb.Append("irinotecan hydrochloride, oxaliplatin, gemcitabine hydrochloride, and paclitaxel albumin-stabilized nanoparticle formulation, work in "); 
	        sb.Append("different ways to stop the growth of tumor cells, either by killing the cells, by stopping them from dividing, or by stopping them from "); 
	        sb.Append("spreading. Giving more than one drug (combination chemotherapy) may kill more tumor cells. It is not yet known whether combination "); 
	        sb.Append("chemotherapy is more effective than gemcitabine hydrochloride and paclitaxel albumin-stabilized nanoparticle formulation before surgery in treating pancreatic cancer."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2016, 1, 11, 15, "147", 900,
		        18, 17, 75, 17, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2015 Sep 25", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "S1505", 14, 100358, 
		        "Southwest Oncology Group", "https://ror.org/05n6zrm60", null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "NCI-2015-01236", 39, 100162, 
		        "National Cancer Institute", "https://ror.org/040gcmg81", null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U10CA180888", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, 
		        "https://reporter.nih.gov/quickSearch/U10CA180888"));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A Randomized Phase II Study of Perioperative mFOLFIRINOX Versus Gemcitabine/Nab-Paclitaxel as Therapy for Resectable Pancreatic Adenocarcinoma", 16, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Davendra Sohal", "Southwest Oncology Group", 
		        100358, "Southwest Oncology Group", "https://ror.org/05n6zrm60"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100358, "Southwest Oncology Group",
		        "https://ror.org/05n6zrm60"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100162, 
		        "National Cancer Institute", "https://ror.org/040gcmg81"));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Gemcitabine-2", 14, "C000056507", "C000056507", "Gemcitabine"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Paclitaxel", 14, "D000017239", "D000017239", "Paclitaxel"));

	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Camptothecin", 14, "D000002166", "D000002166", "Camptothecin"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Albumin-Bound Paclitaxel", 14, "D000068196", "D000068196", "Albumin-Bound Paclitaxel"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Fluorouracil", 14, "D000005472", "D000005472", "Fluorouracil"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Oxaliplatin", 14, "D000077150", "D000077150", "Oxaliplatin"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Irinotecan", 14, "D000077146", "D000077146", "Irinotecan"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Pancrelipase", 14, "D000020799", "D000020799", "Pancrelipase"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Pancreatin", 14, "D000010194", "D000010194", "Pancreatin"));

            fs.conditions!.Add(new StudyCondition(sd_sid, "Pancreatic Adenocarcinoma", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "Resectable Pancreatic Carcinoma", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "Adenocarcinoma", 14, "D000000230", "2", "Neoplasms"));
            fs.conditions.Add(new StudyCondition(sd_sid, "Pancreatic Neoplasms", 14, "D000010190", "2C10", "Malignant neoplasm of pancreas"));
            
			sb = new StringBuilder("Sohal DPS, Duong M, Ahmad SA, Gandhi NS, Beg MS, Wang-Gillam A, Wade JL 3rd, Chiorean EG, Guthrie KA, Lowy AM, Philip PA, Hochster HS. ");
			sb.Append("Efficacy of Perioperative Chemotherapy for Resectable Pancreatic Adenocarcinoma: A Phase 2 Randomized Clinical Trial. ");
			sb.Append("JAMA Oncol. 2021 Mar 1;7(3):421-427. doi: 10.1001/jamaoncol.2020.7328. Erratum in: JAMA Oncol. 2021 Sep 23;:null.'");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "33475684", null, null, null));

			sb = new StringBuilder("Ahmad SA, Duong M, Sohal DPS, Gandhi NS, Beg MS, Wang-Gillam A, Wade JL 3rd, Chiorean EG, Guthrie KA, Lowy AM, Philip PA, Hochster HS. ");
			sb.Append("Surgical Outcome Results From SWOG S1505: A Randomized Clinical Trial of mFOLFIRINOX Versus Gemcitabine/Nab-paclitaxel for Perioperative Treatment of Resectable Pancreatic Ductal Adenocarcinoma. ");
			sb.Append("Ann Surg. 2020 Sep 1;272(3):481-486. doi: 10.1097/SLA.0000000000004155.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "32740235", null, null, null));

            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Patients must have histologically or cytologically proven pancreatic adenocarcinoma; histologies other than adenocarcinoma, or any mixed histologies, will NOT be eligible"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Patients must have measurable disease in the pancreas; computed tomography (CT) scans or magnetic resonance imaging (MRIs) used to assess measurable disease must have been completed within 28 days prior to registration; all disease must be assessed and documented on the baseline tumor assessment form"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Patients must have resectable primary tumor based on contrast-enhanced CT or MRI (CT or MRI without contrast as part of positron emission tomography [PET]/CT or PET/MRI is NOT acceptable; CT or MRI with contrast as part of PET/CT or PET/MRI is acceptable) of the chest, abdomen, and pelvis, where resectable is defined as:"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "No involvement of the celiac artery, common hepatic artery, and superior mesenteric artery (and, if present, replaced right hepatic artery)"));
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "No involvement, or < 180° interface between tumor and vessel wall, of the portal vein and/or superior mesenteric vein; and patent portal vein/splenic vein confluence\nNo evidence of metastatic disease"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "Note: for tumors of the body and tail of the pancreas, involvement of the splenic artery and vein of any degree is considered resectable disease"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr assumed", "@", 1, "n.07", "CT scans or MRIs used to assess disease at baseline must be submitted for central review"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr assumed", "@", 1, "n.08", "Patients must have surgical consult to verify patient is a surgical candidate within 21 days prior to registration"));
            fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "cr assumed", "@", 1, "n.09", "Patients must not have received prior surgery, radiation therapy, chemotherapy, targeted therapy, or any investigational therapy for pancreatic cancer"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "cr assumed", "@", 1, "n.10", "Patients must have a Zubrod performance status of 0-1"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 11, 1, "cr assumed", "@", 1, "n.11", "Absolute neutrophil count (ANC) >= 1,500/mcL\nPlatelets >= 100,000/mcL"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 12, 1, "cr assumed", "@", 1, "n.12", "Hemoglobin >= 9 g/dL"));
            fs.iec.Add(new StudyIEC(sd_sid, 13, 1, "cr assumed", "@", 1, "n.13", "Total bilirubin =< 1.5 x institutional upper limit of normal (IULN)"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 14, 1, "cr assumed", "@", 1, "n.14", "Aspartate aminotransferase (AST) and alanine aminotransferase (ALT) =< 2.5 x IULN"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 15, 1, "cr assumed", "@", 1, "n.15", "Serum albumin >= 3 g/dL"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 16, 1, "cr assumed", "@", 1, "n.16", "Serum creatinine =< IULN within 14 days prior to registration"));
            fs.iec.Add(new StudyIEC(sd_sid, 17, 1, "cr assumed", "@", 1, "n.17", "Patients with uncontrolled intercurrent illness including, but not limited to ongoing or active infection, symptomatic congestive heart failure, unstable angina pectoris, cardiac arrhythmia, or psychiatric illness/social situations that would limit compliance with study requirements will NOT be eligible"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 18, 1, "cr assumed", "@", 1, "n.18", "No prior malignancy is allowed except for adequately treated basal (or squamous cell) skin cancer, in situ cervical cancer, in situ breast (ductal or lobular) cancer, or other cancer for which the patient has been disease and treatment-free for two years"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 19, 1, "cr assumed", "@", 1, "n.19", "Patients must not be pregnant or nursing; women/men of reproductive potential must have agreed to use an effective contraceptive method for up to 3 months after the final administered dose of chemotherapy; a woman is considered to be of \"reproductive potential\" if she has had menses at any time in the preceding 12 consecutive months; in addition to routine contraceptive methods, \"effective contraception\" also includes heterosexual celibacy and surgery intended to prevent pregnancy (or with a side-effect of pregnancy prevention) defined as a hysterectomy, bilateral oophorectomy or bilateral tubal ligation; however, if at any point a previously celibate patient chooses to become heterosexually active during the time period for use of contraceptive measures, he/she is responsible for beginning contraceptive measures"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 20, 1, "cr assumed", "@", 1, "n.20", "Sites must seek additional patient consent for the future use of specimens"));
            fs.iec.Add(new StudyIEC(sd_sid, 21, 1, "cr assumed", "@", 1, "n.21", "Patients must be informed of the investigational nature of this study and must sign and give written informed consent in accordance with institutional and federal guidelines"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 22, 1, "cr assumed", "@", 1, "n.22", "As a part of the OPEN registration process the treating institution's identity is provided in order to ensure that the current (within 365 days) date of institutional review board approval for this study has been entered in the system"));	    
           
            fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, "University of Alabama at Birmingham Cancer Center", null, null, "Birmingham", 6252001, "United States", null));
            fs.sites!.Add(new StudyLocation(sd_sid, null, "University of South Alabama Mitchell Cancer Institute", null, null, "Mobile", 6252001, "United States", null));
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Anchorage Associates in Radiation Medicine", null, null, "Anchorage", 6252001, "United States", null));
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Anchorage Radiation Therapy Center", null, null, "Anchorage", 6252001, "United States", null));
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Alaska Breast Care and Surgery LLC", null, null, "Anchorage", 6252001, "United States", null));
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Alaska Oncology and Hematology LLC", null, null, "Anchorage", 6252001, "United States", null));
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Alaska Regional Hospital", null, null, "Anchorage", 6252001, "United States", null));
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Alaska Women's Cancer Care", null, null, "Anchorage", 6252001, "United States", null)); 
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Anchorage Oncology Centre", null, null, "Anchorage", 6252001, "United States", null));
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Katmai Oncology Group", null, null, "Anchorage", 6252001, "United States", null));
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2015, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2015 Sep 29 (est.)", 2015, 9, 29, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Oct 19", 2022, 10, 19, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Trial results entry
			
            sd_oid = sd_sid + " :: 28 :: CTG results entry";
            ob_title = display_title + " :: CTG results entry";
            sdo = CreateEmptyStudyDataObject();
			
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG results entry", null, ob_title,
	            null, 9, 2021, 23, 28, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid + "?tab=results", true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2021 Jul 23", 2021, 7, 2, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Oct 19", 2022, 10, 19, null, null, null, null));

            fs.data_objects!.Add(sdo);

            // 3) Study Protocol, Statistical Analysis Plan, and Informed Consent Form
	        
            sd_oid = sd_sid + " :: 76 :: Study Protocol, Statistical Analysis Plan, and Informed Consent Form";
            ob_title = display_title + " :: Study Protocol, Statistical Analysis Plan, and Informed Consent Form";
            sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Study Protocol, Statistical Analysis Plan, and Informed Consent Form", null, ob_title,
	            null, 9, 2021, 23, 76, 100120, "ClinicalTrials.gov", null, "en", 11, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://storage.googleapis.com/ctgov2-large-docs/16/NCT02562716/Prot_SAP_ICF_000.pdf", 
	            true, 11, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2020 Sep 4", 2020, 9, 4, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 12, false, "2021 Jun 1", 2021, 6, 1, null, null, null, null));
            fs.data_objects!.Add(sdo);
            
            return fs;
                   
        }
        
        if (sd_sid == "NCT02449174")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Fecal Microbiota Transplantation to Treat Recurrent C. Difficile Associated Diarrhea Via Retention Enema or Oral Route";
	        StringBuilder sb = new StringBuilder("The objective of the study is to investigate the safety of a frozen or lyophilized inoculum administered, ");
	        sb.Append("respectively, by retention enema or capsules in patients with recurrent C. difficile associated diarrhea (RCDAD).\n\n"); 
	        sb.Append("This is a single center, randomized, parallel assignment, open label safety study conducted in subjects with RCDAD. Fifty "); 
	        sb.Append("subjects will be enrolled in the study and randomized at 1:1 ratio to receive frozen filtered intestinal bacteria via retention "); 
	        sb.Append("or lyophilized donor intestinal bacteria. All subjects will be followed for a total of 3 years after study completion.\n\n"); 
	        sb.Append("Donors will be enrolled and screened at the laboratory in the Center for Infectious Diseases at University of Texas School of "); 
	        sb.Append("Public Health (UT-SPH). The donors will come from a variety of places, including the UT-SPH. "); 
	        sb.Append("At least 20 donors will be screened to recruit at least 15 qualified donors.\n\n"); 
	        sb.Append("Recipients may self-refer but must have a physician who agrees to accept care of the patient following fecal microbiota transplantation (FMT). "); 
	        sb.Append("Subjects consenting to treatment at Baylor St. Luke’s Medical Center (BSLMC) and the UT-SPH must be willing to self-pay for the FMT in the "); 
	        sb.Append("amount of $1,500. There will be no insurance accepted. Subjects undergoing retention enema will be treated as outpatients at either at BSLMC, "); 
	        sb.Append("Kelsey-Seybold Clinic, or at the Memorial Hermann in the Texas Medical Center. All subjects taking capsules with lyophilized intestinal bacteria "); 
	        sb.Append("will be seen at UT-SPH. Once the procedure is completed, the recipient’s care will be returned to their physician. "); 
	        sb.Append("At least 75 recipients will be screened to recruit 50 qualified recipients.\n\n"); 
	        sb.Append("The primary endpoint is to evaluate the safety of FMT by rectal or oral routes with secondary endpoint related to efficacy prevention of RCDAD. "); 
	        sb.Append("In order to monitor any health effects for safety, participants will be contacted pre- and 7, 14, 30 days, then monthly basis for the first 90 ");
	        sb.Append("days after FMT and quarterly till 3 years after FMT. The following procedures will be completed: review recipient diary with the recipient to ");
	        sb.Append("ensure that the following information is recorded correctly and a fresh stool sample will be collected from recipient, tested for C. difficile ");
	        sb.Append("toxins and an aliquot (2mL) stored at -80C for microbiome analysis. Recipients will be contacted by phone for their diarrhea status on ");
	        sb.Append("monthly basis till 90 days after FMT, then on quarterly basis till 3 years after FMT."); 
	        string brief_desc = sb.ToString();	        
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2015, 3, 11, 21, "69", 900,
		        18, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2014 Dec 17", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "HSC-SPH-14-0020", 14, null, 
		        "The University of Texas Health Science Center, Houston", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A Study of Fecal Microbiota Transplantation (FMT) for the Treatment of Recurrent C. Difficile Associated Diarrhea (RCDAD) Via Retention Enema or Oral Route", 
		        16, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Zhi-Dong Jiang", "The University of Texas Health Science Center, Houston", 
		        null, "University of Texas School of Public Health", null));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Herbert l DuPont", "University of Texas School of Public Health", 
		        null, "University of Texas School of Public Health", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "The University of Texas Health Science Center, Houston", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "Roderick MacDonald Research Fund at Baylor St Luke’s", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "Kelsey Research Foundation", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null , "Texas Gulf Coast Digestive Diseases Center", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 110));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 505));   // 

            fs.topics!.Add(new StudyTopic(sd_sid, 11, "Fecal Microbiota transplantation", null, null, null, null));
            
            fs.conditions!.Add(new StudyCondition(sd_sid, "C. Difficile", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "Diarrhea", 14, "Diarrhea", null, null));
            
            fs.relationships!.Add(new StudyRelationship(sd_sid, 23, "NCT03786900"));

            sb = new StringBuilder("Jiang ZD, Jenq RR, Ajami NJ, Petrosino JF, Alexander AA, Ke S, Iqbal T, DuPont AW, Muldrew K, Shi Y, Peterson C, Do KA, DuPont HL. ");
			sb.Append("Safety and preliminary efficacy of orally administered lyophilized fecal microbiota product compared with frozen product given by enema for recurrent Clostridium difficile infection: A randomized clinical trial. ");
			sb.Append("PLoS One. 2018 Nov 2;13(11):e0205064. doi: 10.1371/journal.pone.0205064. eCollection 2018.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "30388112", null, null, null));

            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Male and female subjects 18 years of age or older"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Sexually active female subjects of child-bearing potential must agree to use an effective method of birth control during the treatment and follow-up period"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Required to sign an informed consent form"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Subject\"s attending physician agrees to provide care following FMT"));
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "Able to follow study procedures and follow-ups."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "Diagnosed by medical history of ≥ 3 RCDAD bouts in outpatients or ≥ 2 bouts of RCDAD in an inpatient with ≥ 2 positive fecal tests for C. difficile toxin"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr assumed", "@", 1, "n.07", "Received at least one course of adequate antibiotic therapy for CDAD (≥ 10 days of vancomycin, metronidazole or fidaxomicin) after the subjects last bout of CDAD"));
            
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.01", "Subjects with known neutropenia with absolute neutrophil count <0.5 x 109/L"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.02", "Evidence of toxic megacolon, fulminant colitis, gastrointestinal perforation, ileus, abdominal distension, lack of bowel sounds, fever, or hypotension"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr assumed", "@", 1, "e.03", "Known peripheral white blood cell count > 15.0 x 109/L or temperature > 38.0 °C"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr assumed", "@", 1, "e.04", "Diarrhea due to definable non-CDAD pathogen"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr assumed", "@", 1, "e.05", "Post total colectomy or presence of a colostomy"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr assumed", "@", 1, "e.06", "Unable to tolerate FMT via enema for any reason"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr assumed", "@", 1, "e.07", "Requiring systemic non-C. difficile antibiotic therapy at the time of FMT"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr assumed", "@", 1, "e.08", "Actively taking Saccharomyces boulardii or other probiotic at the time of FMT"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr assumed", "@", 1, "e.09", "Need for continuing use of oral vancomycin, oral or IV metronidazole, fidaxomicin, rifaximin or nitazoxanide at the time of FMT"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr assumed", "@", 1, "e.10", "Severe underlying disease such that the patient is not expected to survive for one or more years or unstable medical condition requiring daily change in treatments"));	
            
            fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, "University of Texas Health Science Center at Housotn", null, null, "Houston", 6252001, "United States", null));
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2015, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2015 May 20 (est.)", 2015, 5, 20, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2019 Mar 25", 2019, 3, 25, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Trial results entry
			
            sd_oid = sd_sid + " :: 28 :: CTG results entry";
            ob_title = display_title + " :: CTG results entry";
            sdo = CreateEmptyStudyDataObject();
			
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG results entry", null, ob_title,
	            null, 9, 2019, 23, 28, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid + "?tab=results", true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2019 Mar 25", 2019, 3, 25, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2019 Mar 25", 2019, 3, 25, null, null, null, null));

            fs.data_objects!.Add(sdo);
            
            // 3) Study Protocol and Statistical Analysis Plan
	        
            sd_oid = sd_sid + " :: 74 :: Study Protocol and Statistical Analysis Plan";
            ob_title = display_title + " :: Study Protocol and Statistical Analysis Plan";
            sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Study Protocol and Statistical Analysis Plan", null, ob_title,
	            null, 9, 2019, 23, 74, 100120, "ClinicalTrials.gov", null, "en", 11, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://storage.googleapis.com/ctgov2-large-docs/74/NCT02449174/Prot_SAP_000.pdf", 
	            true, 11, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2017 Jul 13", 2017, 7, 13, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 12, false, "2019 Mar 21", 2019, 3, 21, null, null, null, null));
            fs.data_objects!.Add(sdo);
            
            return fs;
        }
        
        if (sd_sid == "NCT00433329")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Combination Therapy in Pulmonary Arterial Hypertension";
	        StringBuilder sb = new StringBuilder("An open label, non-comparative study design is appropriate for this Phase 4 study designed to assess whether ");
	        sb.Append("a core therapy of bosentan, either as monotherapy or with the addition of sildenafil, enables patients with pulmonary arterial "); 
	        sb.Append("hypertension (PAH) to achieve a 6-minute walk distance (6 MWD) of ≥380 meters after 28 weeks of therapy This design is also "); 
	        sb.Append("appropriate to pioneer the utility of cardiac MRI in assessing improved functional capacity in PAH and exploring its correlation with other parameters."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2007, 3, 11, 21, "100", 900,
		       12, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2007 Feb 7", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "AC-052-419", 14, 100585, 
		        "Actelion", "https://ror.org/001yedb91", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        string title = "COMPASS 3: An Open-label, Multi-Center Study Employing a Targeted 6-Minute Walk Test (6-MWT) Distance Threshold Approach to Guide ";
	        title += "Bosentan-Based Therapy and to Assess the Utility of Magnetic Resonance Imaging (MRI) on Cardiac Remodeling";
	        fs.titles.Add(new StudyTitle(sd_sid, title, 16, "en", 11, false, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "COMPASS 3", 14, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100585, "Actelion", "https://ror.org/001yedb91"));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 135));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 210));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 300));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
            fs.topics!.Add(new StudyTopic(sd_sid, 11, "combination therapy", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "Compass 3", null, null, null, null));
	        
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Bosentan", 14, "D000077300", "D000077300", "Bosentan"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Sildenafil Citrate", 14, "D000068677", "D000068677", "Sildenafil Citrate"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Pulmonary Arterial Hypertension", null, null, "BB01", "Pulmonary hypertension"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Familial Primary Pulmonary Hypertension", 14, "D000065627", null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Hypertension", 14, "D000006973", "BA00", "Essential hypertension"));
           
			sb = new StringBuilder("Benza RL, Raina A, Gupta H, Murali S, Burden A, Zastrow MS, Park MH, Simon MA. ");
			sb.Append("Bosentan-based, treat-to-target therapy in patients with pulmonary arterial hypertension: results from the COMPASS-3 study. ");
			sb.Append("Pulm Circ. 2018 Jan-Mar;8(1):2045893217741480. doi: 10.1177/2045893217741480. Epub 2017 Oct 24.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "29064349", null, null, null));

            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Signed informed consent prior to initiation of any study-mandated procedures."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Males or females ≥ 12 years of age (females of child-bearing potential must have been surgically sterilized or use a reliable method of contraception)."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Symptomatic patients with the following types of PAH belonging to World Health Organization (WHO) Pulmonary Hypertension Classification Group I:"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Idiopathic (IPAH)"));
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "Familial (FPAH)"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "nAssociated with PAH (APAH):"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr assumed", "@", 1, "n.07", "Collagen vascular disease"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr assumed", "@", 1, "n.08", "Drugs and toxins"));
            fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "cr assumed", "@", 1, "n.09", "Patients naïve to treatment with advanced PAH therapies (i.e., endothelin receptor antagonists (ERAs), phosphodiesterase-5 (PDE-5) inhibitors or prostacyclins) with a right heart catheterization (RHC) showing all of the following:"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "cr assumed", "@", 1, "n.10", "Mean pulmonary arterial pressure (mPAP) ≥ 25 mm Hg"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 11, 1, "cr assumed", "@", 1, "n.11", "Pulmonary capillary wedge pressure (PCWP) ≤ 15 mm Hg or left ventricular end diastolic pressure (LVEDP) ≤ 15 mm Hg when PCWP is not accurately obtained"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 12, 1, "cr assumed", "@", 1, "n.12", "Pulmonary vascular resistance ≥ 3 Wood units"));
            fs.iec.Add(new StudyIEC(sd_sid, 13, 1, "cr assumed", "@", 1, "n.13", "6-MWT distance ≥ 150 meters and < 360 meters."));	       

            
            fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr assumed", "@", 1, "e.01", "Patients with Pulmonary Hypertension (PH) belonging to WHO Classification Group II-V."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr assumed", "@", 1, "e.02", "Patients with PAH (WHO PH Classification Group I) other than that listed in the Inclusion Criteria."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr assumed", "@", 1, "e.03", "Pregnant and/or nursing."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr assumed", "@", 1, "e.04", "Women of childbearing potential not using a reliable method of contraception."));	  
            fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "cr assumed", "@", 1, "e.05", "Patients with known human immunodeficiency virus (HIV) infection."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "cr assumed", "@", 1, "e.06", "Patients with significant vasoreactivity during right heart catheterization (i.e., a fall in mPAP to < 40 mm Hg with a decrease of ≥ 10 mm Hg and with a normal cardiac index ≥ 2.5 l/min.m^2)."));	
            fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "cr assumed", "@", 1, "e.07", "Patients with restrictive lung disease (i.e., total lung capacity (TLC) < 60% of normal predicted value)."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "cr assumed", "@", 1, "e.08", "Patients with obstructive lung disease (i.e., forced expiratory volume/ forced vital capacity (FEV1/FVC) < 0.5)."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "cr assumed", "@", 1, "e.09", "Patients with impaired left ventricular function (LVEF <50%) or diastolic dysfunction."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr assumed", "@", 1, "e.10", "Patients with portal hypertension, cirrhosis, moderate to severe liver impairment (Child-Pugh Class B or C), or liver enzymes (Aspartate aminotransferase (AST) and/or alanine aminotransferase (ALT)) > 3.0 times the upper limit of normal range."));	  
            fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr assumed", "@", 1, "e.11", "Treatment with glibenclamide (glyburide) and calcineurin inhibitors (cyclosporine A, tacrolimus) sirolimus, everolimus up to 1 week prior to Baseline (Day 1)."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr assumed", "@", 1, "e.12", "Patients currently receiving or predicted to require treatment, during the course of the study, with nitrates, protease inhibitors, or alpha-blockers."));	
            fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr assumed", "@", 1, "e.13", "Patients with a hemoglobin concentration < 75 % of the lower limit of the normal range or < 8.5 g/dL."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "cr assumed", "@", 1, "e.14", "Patients currently receiving or predicted to require treatment with a prostanoid during the course of the study."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "cr assumed", "@", 1, "e.15", "Patients with systolic blood pressure < 85 mm Hg."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "cr assumed", "@", 1, "e.16", "Patients with body weight < 40 kg."));	  
            fs.iec.Add(new StudyIEC(sd_sid, 30, 2, "cr assumed", "@", 1, "e.17", "Patients who have received any investigational product within 90 days prior to Baseline."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 31, 2, "cr assumed", "@", 1, "e.18", "Patients who previously received any advanced therapy for PAH (e.g., ERAs, PDE-5 inhibitors or prostacyclins)."));	
            fs.iec.Add(new StudyIEC(sd_sid, 32, 2, "cr assumed", "@", 1, "e.19", "Patients with hypersensitivity to sildenafil or any excipients of its formulation."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 33, 2, "cr assumed", "@", 1, "e.20", "Patients with any contraindication to sildenafil treatment (i.e., nitrates)."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 34, 2, "cr assumed", "@", 1, "e.21", "Patients with any recent medical condition limiting the ability to comply with the study requirements (i.e., stroke, myocardial infarction)."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 35, 2, "cr assumed", "@", 1, "e.22", "Patients with unstable PAH whose disease state would prohibit the completion of study procedures, in the opinion of the investigator."));	  
            fs.iec.Add(new StudyIEC(sd_sid, 36, 2, "cr assumed", "@", 1, "e.23", "Patients unable to complete a MRI scan (e.g., claustrophobia)."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 37, 2, "cr assumed", "@", 1, "e.24", "Patients with permanent cardiac pacemakers, automatic internal cardioverter defibrillators (AICD's), neurostimulators, hearing aides, and other implanted metallic devices that are contraindicated during a MRI study."));	
            fs.iec.Add(new StudyIEC(sd_sid, 38, 2, "cr assumed", "@", 1, "e.25", "Patients with conditions that would interfere with proper cardiac gating during MRI, such as atrial fibrillation or multiple premature ventricular contractions (PVCs)/premature atrial contractions (PACs)."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 39, 2, "cr assumed", "@", 1, "e.26", "Patients with conditions that prevent compliance with the protocol or the ability to adhere to therapy."));	
            
            fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, "University of Alabama Hospital at Birmingham", null, null, "Birmingham", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "University of South Alabama", null, null, "Mobile", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "UCLA - David Geffen School of Medicine", null, null, "Los Angeles", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Lung Health and Sleep Enhancement Center, LLC", null, null, "Newark", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Morton Plant Hospital (Bay Area Chest Physicians, P.A.)", null, null, "Clearwater", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Mayo Clinic Jacksonville", null, null, "Jacksonville", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "University of Miami School of Medicine", null, null, "Miami", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Cleveland Clinic Florida", null, null, "Weston", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Emory University Hospital", null, null, "Atlanta", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Atlanta Institute for Medical Research, Inc.", null, null, "Decatur", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Kentukiana Pulmonary Associates", null, null, "Louisville", 6252001, "United States", null));
     
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2007, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2007 Feb 9 (est.)", 2007, 2, 9, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2013 Jun 5 (est.)", 2013, 6, 5, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Trial results entry
			
            sd_oid = sd_sid + " :: 28 :: CTG results entry";
            ob_title = display_title + " :: CTG results entry";
            sdo = CreateEmptyStudyDataObject();
			
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG results entry", null, ob_title,
	            null, 9, 2013, 23, 28, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid + "?tab=results", true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2013 May 17 (est.)", 2013, 5, 17, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2013 Jun 5 (est.)", 2013, 6, 5, null, null, null, null));

            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        if (sd_sid == "NCT02922075")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Impact of Soft Tissue Grafts on Tissue Alterations After Immediate Tooth Replacement";
	        StringBuilder sb = new StringBuilder("This study evaluates the impact of soft tissue grafts on soft tissue recession following immediate implant, ");
	        sb.Append("provisional and bone graft placement in compromised sockets. One third of the patients received a collagen matrix (CM group), "); 
	        sb.Append("another third received a connective tissue graft removed from the palate (CTG group) and the final third did not receive any soft tissue graft (CTL group)."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2013, 2, 11, 21, "24", 900,
		        18, 17, 70, 17, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2016 Sep 24", null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "Soft and Hard Tissue Stability After Immediate Tooth Replacement With Implant in Fresh Sockets Grafted With Different Soft Tissue Grafts",
		        16, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "El cio Marcantonio Jr", null, null, null, null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 101740, "São Paulo State University", "https://ror.org/00987cb86"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "Fundação de Amparo à Pesquisa do Estado de São Paulo", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "Conselho Nacional de Desenvolvimento Científico e Tecnológi co", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 135));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 11, "gingival recession", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "immediate implant and provisional placement", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "bone graft", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "connective tissue graft", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "collagen matrix", null, null, null, null));
	        
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Acetaminophen", 14, "D000000082", "D000000082", "Acetaminophen"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Amoxicillin", 14, "D000000658", "D000000658", "Amoxicillin"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Chlorhexidine", 14, "D000002710", "D000002710", "Chlorhexidine"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Chlorhexidine gluconate", 14, "C000010882", "C000010882", "Chlorhexidine gluconate"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Tooth Socket", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Dental Implants", null, null, null, null));

	        string c1 = "Public title: Stability of the architecture of the hard and soft tissue after immediate tooth replacement with implants in fresh grafted sockets.\n\n";
	        c1 += "All data can be downloaded from the website, if there are any questions please feel free to contact us.";   
	        string c2 = "Public title: Stability of the architecture of the hard and soft tissue after immediate tooth replacement with implants in fresh grafted sockets.";
	        c2 += "All data can be downloaded from the website, if there are any questions please feel free to contact us.";  
	        
	        fs.ipd_info!.Add(new AvailableIPD(sd_sid, null, "Individual Participant Data Set", "http://aplicacao.saude.gov.br/plataformabrasil/login.jsf", c1));
	        fs.ipd_info.Add(new AvailableIPD(sd_sid, null, "Study Protocol", "http://aplicacao.saude.gov.br/plataformabrasil/login.jsf", c2));
	        fs.ipd_info.Add(new AvailableIPD(sd_sid, null, "Statistical Analysis Plan", "http://aplicacao.saude.gov.br/plataformabrasil/login.jsf", c2));
	        fs.ipd_info.Add(new AvailableIPD(sd_sid, null, "Informed Consent Form", "http://aplicacao.saude.gov.br/plataformabrasil/login.jsf", c2));
	        fs.ipd_info.Add(new AvailableIPD(sd_sid, null, "Clinical Study Report", "http://aplicacao.saude.gov.br/plataformabrasil/login.jsf", c2));
	        fs.ipd_info.Add(new AvailableIPD(sd_sid, null, "Analytic Code", "http://aplicacao.saude.gov.br/plataformabrasil/login.jsf", c2));
            
	        fs.studylinks!.Add(new StudyLink(sd_sid, "All data can be downloaded from the website, if there are any questions please feel free to contact us",
		                "http://aplicacao.saude.gov.br/plataformabrasil/login.jsf" ));

            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Presence of a failing maxillary incisor with neighbouring teeth and harmonic gingival contour;"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Operated area with appropriate palatal/apical bone to install the implant;"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "A buccal wall defect confirmed by cone beam computed tomography;"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Clinical attachment level > 3 mm;"));
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "Good oral hygiene with visible plaque index < 20%;"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "No bone loss in the neighbouring teeth;"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr assumed", "@", 1, "n.07", "Implant primary stability > 32N"));
	        
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.01", "History of periodontal surgeries in the failing tooth;"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.02", "Occlusal instability;"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr assumed", "@", 1, "e.03", "Systemic alterations that could compromise the surgical procedure, such ass smokers, bruxists; drug users; patients with diabetes or pregnants."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr assumed", "@", 1, "e.04", "Active infection involving the gingival margin"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr assumed", "@", 1, "e.05", "Patients undergoing radiotherapy in the head and neck area. Patients presented history of bone associated diseases or medication affecting bone metabolism;"));	       
 
            fs.countries!.Add(new StudyCountry(sd_sid, 3469034, "Brazil", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Araraquara Dental School at the São Paulo State University", null, null, "Araraquara", 3469034, "Brazil", null));
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2016, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2016 Oct 3 (est.)", 2016, 10, 3, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2016 Oct 3 (est.)", 2016, 10, 3, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
             
        }
        
        
        if (sd_sid == "NCT00200967")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Asthma Clinical Research Network (ACRN) Trial - Long-Acting Beta Agonist Response by Genotype (LARGE)";
	        StringBuilder sb = new StringBuilder("The purpose of this trial is to determine whether regularly scheduled use of an inhaled long-acting ");
	        sb.Append("beta agonist (salmeterol) in the setting of concomitant use of inhaled corticosteroids (beclomethasone hydroflouroalkane (HFA) "); 
	        sb.Append("inhaler) will have a detrimental effect on asthma control in people who bear the B16-Arg/Arg genotype of the beta-2 "); 
	        sb.Append("adrenergic receptor gene, as compared to people with asthma of similar severity who bear the B16-Gly/Gly genotype."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2004, 12, 11, 21, "87", 900,
		        18, 17, 90, 17, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2005 Sep 12", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "262", 14, 100375, 
		        "Milton S Hershey Medical Center", "https://ror.org/01h22ap11", null, null));
	        
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "5U10HL074231", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, 
		        "https://projectreporter.nih.gov/reporterapi.cfm?PROJECTNUM=5U10HL074231&Fy=all"));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U10HL074073", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, 
		        "https://projectreporter.nih.gov/reporterapi.cfm?PROJECTNUM=U10HL074073&Fy=all"));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U10HL074204", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, 
		        "https://projectreporter.nih.gov/reporterapi.cfm?PROJECTNUM=U10HL074204&Fy=all"));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U10HL074208", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, 
		        "https://projectreporter.nih.gov/reporterapi.cfm?PROJECTNUM=U10HL074208&Fy=all"));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U10HL074212", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, 
		        "https://projectreporter.nih.gov/reporterapi.cfm?PROJECTNUM=U10HL074212&Fy=all"));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U10HL074218", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, 
		        "https://projectreporter.nih.gov/reporterapi.cfm?PROJECTNUM=U10HL074218&Fy=all"));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U10HL074225", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, 
		        "https://projectreporter.nih.gov/reporterapi.cfm?PROJECTNUM=U10HL074225&Fy=all"));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U10HL074227", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, 
		        "https://projectreporter.nih.gov/reporterapi.cfm?PROJECTNUM=U10HL074227&Fy=all"));   
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "U10HL074231", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, 
		        "https://projectreporter.nih.gov/reporterapi.cfm?PROJECTNUM=U10HL074231&Fy=all"));   
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Vernon M Chinchilli", "Milton S Hershey Medical Center", 
		        100375, "Milton S Hershey Medical Center", "https://ror.org/01h22ap11"));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Homer Boushey", "University of California, San Francisco", 
		        100182, "University of California, San Francisco", "https://ror.org/043mz5j54"));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Mario Castro", "Washington University School of Medicine", 
		        100195, "Washington University School of Medicine", null));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Elliot Israel", "Brigham and Women’s Hospital", 
		        100203, "Brigham and Women’s Hospital", "https://ror.org/04b6nzv94"));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Robert Lemanske", "University of Wisconsin, Madison", 
		        100231, "University of Wisconsin, Madison", "https://ror.org/01y2jtd41"));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Richard Martin", "National Jewish Medical & Research Center", 
		        null, "National Jewish Medical & Research Center", null));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Stephen Peters", "Wake Forest University Health Sciences", 
		        null, "Wake Forest University Health Sciences", null));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Stephen Wasserman", "University of California, San Diego", 
		        100238, "University of California, San Diego", "https://ror.org/0168r3w48"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100375, "Milton S Hershey Medical Center", "https://ror.org/01h22ap11"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100167, "National Heart, Lung, and Blood Institute", "https://ror.org/012pb6c26"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "Asthma Clinical Research Network", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 310));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 520));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Beclomethasone", 14, "D000001507", "D000001507", "Beclomethasone"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Salmeterol Xinafoate", 14, "D000068299", "D000068299", "Salmeterol Xinafoate"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Asthma", 14, "D000001249", "CA23", "Asthma"));
            
			sb = new StringBuilder("Wechsler ME, Kunselman SJ, Chinchilli VM, Bleecker E, Boushey HA, Calhoun WJ, Ameredes BT, Castro M, Craig TJ, Denlinger L, Fahy JV, Jarjour N, Kazani S, Kim S, Kraft M, Lazarus SC, Lemanske RF Jr, Markezich A, Martin RJ, Permaul P, Peters SP, Ramsdell J, Sorkness CA, Sutherland ER, Szefler SJ, Walter MJ, Wasserman SI, Israel E; National Heart, Lung and Blood Institute’s Asthma Clinical Research Network. ");
			sb.Append("Effect of beta2-adrenergic receptor polymorphism on response to longacting beta2 agonist in asthma (LARGE trial): a genotype-stratified, randomised, placebo-controlled, crossover trial. ");
			sb.Append("Lancet. 2009 Nov 21;374(9703):1754-64. doi: 10.1016/S0140-6736(09)61492-6.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "19932356", null, null, null));		

			fs.studylinks!.Add(new StudyLink(sd_sid, "Asthma Clinical Research Network (ACRN) Website", 
				"http://www.acrn.org"));

            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Male or female, ages 18 and older"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Clinical history consistent with asthma"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "For subjects regularly using inhaled corticosteroids, FEV1 50% of predicted, methacholine PC20 FEV1 16 mg/ml or 12% and 200 ml, improvement in FEV1 after 2 puffs of inhaled albuterol"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "For subjects not regularly using inhaled corticosteroids, FEV1 40% of predicted, methacholine PC20 FEV1 8 mg/ml or 12% and 200 ml, improvement in FEV1 after 2 puffs of inhaled albuterol"));
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "Genotype eligibility (determined during screening)"));	
	        
            fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr assumed", "@", 1, "e.01", "Smoker (total smoking history must be less than 10 pack years)"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr assumed", "@", 1, "e.02", "Significant unstable medical condition other than asthma"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.03", "History of life-threatening asthma requiring treatment with intubation and mechanical ventilation in the past 10 years"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.04", "Pregnant or lactating"));	  
     
            fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, "University of California, San Diego", null, null, "San Diego", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "University of California, San Francisco", null, null, "San Francisco", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "National Jewish Medical & Research Center", null, null, "Denver", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Brigham & Women's Hospital", null, null, "Boston", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Washington University", null, null, "Saint Louis", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Wake Forest University Health Sciences", null, null, "Winston-Salem", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "University of Wisconsin Madison", null, null, "Madison", 6252001, "United States", null));
          
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2005, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2005 Sep 20 (est.)", 2005, 9, 20, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2018 Jan 23", 2018, 1, 23, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Trial results entry
			
            sd_oid = sd_sid + " :: 28 :: CTG results entry";
            ob_title = display_title + " :: CTG results entry";
            sdo = CreateEmptyStudyDataObject();
			
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG results entry", null, ob_title,
	            null, 9, 2009, 23, 28, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid + "?tab=results", true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2009 Jun 2 (est.)", 2009, 6, 2, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2018 Jan 23", 2018, 1, 23, null, null, null, null));

            fs.data_objects!.Add(sdo);

            return fs;
        }

        
        if (sd_sid == "NCT03050593")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Developing Imaging And plasMa biOmarkers iN Describing Heart Failure With Preserved Ejection Fraction (DIAMONDHFpEF)";
	        StringBuilder sb = new StringBuilder("The investigators wish to test a hypothesis that patients with HFpEF have different characteristics on echo, ");
	        sb.Append("cardiac MRI and plasma protein & chemical profiles compared to HFrEF and healthy volunteers."); 
	        string brief_desc = sb.ToString();

	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2013, 2, 12, 21, "280", 900,
		        18, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2017 Feb 6", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "0328", 14, 100837, 
		        "University of Leicester", "https://ror.org/04h699437", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "Prospective, Observational, Single-centre, Cohort Study Aimed at Developing Imaging and Plasma Biomarkers in Heart Failure With Preserved Ejection Fraction",
		        16, "en", 11, false, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "DIAMONDHFpEF",
		        14, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54,  100837, "University of Leicester", "https://ror.org/04h699437"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100442, "National Institute for Health Research", "https://ror.org/0187kwz08"));

	        fs.features!.Add(new StudyFeature(sd_sid, 30, 600));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 31, 705));   //  
            fs.features.Add(new StudyFeature(sd_sid, 32, 805));   //
            
	        fs.topics!.Add(new StudyTopic(sd_sid, 11, "HFpEF", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "HFrEF", null, null, null, null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Patients With Heart Failure and Preserved Ejection Fraction - HFpEF", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Patients With Heart Failure With Reduced Ejection Fraction - HFrEF", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Healthy Controls Group - Age and Sex-matched", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Heart Failure", 14, "D000006333", "B1-BD1", "Heart failure"));

			sb = new StringBuilder("Gulsin GS, Kanagala P, Chan DCS, Cheng ASH, Athithan L, Graham-Brown MPM, Singh A, Yang J, Li Z, Khunti K, Davies MJ, Arnold JR, Squire IB, Ng LL, McCann GP. ");
			sb.Append("Differential left ventricular and left atrial remodelling in heart failure with preserved ejection fraction patients with and without diabetes. ");
			sb.Append("Ther Adv Endocrinol Metab. 2019 Jul 5;10:2042018819861593. doi: 10.1177/2042018819861593. eCollection 2019.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "31308926", null, null, null));

			sb = new StringBuilder("Kanagala P, Cheng ASH, Singh A, Khan JN, Gulsin GS, Patel P, Gupta P, Arnold JR, Squire IB, Ng LL, McCann GP. ");
			sb.Append("Relationship Between Focal and Diffuse Fibrosis Assessed by CMR and Clinical Outcomes in Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("JACC Cardiovasc Imaging. 2019 Nov;12(11 Pt 2):2291-2301. doi: 10.1016/j.jcmg.2018.11.031. Epub 2019 Feb 13.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30772227", null, null, null));

			sb = new StringBuilder("Kanagala P, Cheng ASH, Singh A, McAdam J, Marsh AM, Arnold JR, Squire IB, Ng LL, McCann GP. ");
			sb.Append("Diagnostic and prognostic utility of cardiovascular magnetic resonance imaging in heart failure with preserved ejection fraction - implications for clinical trials. ");
			sb.Append("J Cardiovasc Magn Reson. 2018 Jan 11;20(1):4. doi: 10.1186/s12968-017-0424-9.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29321034", null, null, null));

            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1001, "cr assumed", "@", 1, "n.0A", "Clinical features of heart failure or prior radiographic evidence in the absence of symptoms And Either ejection fraction > 50% (for HFpEF arm) or ejection fraction < 40% (for HFrEF arm)"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 2, "cr assumed", "@", 1, "e.01", "Myocardial infarction within the preceding 6 months\nSuspected or confirmed cardiomyopathy (e.g. hypertrophic, infiltrative)"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 3, 2, "cr assumed", "@", 1, "e.02", "Suspected or confirmed constrictive pericarditis"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 2, "cr assumed", "@", 1, "e.03", "Significant native valve disease (≥ moderate severity)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr assumed", "@", 1, "e.04", "Known Significant lung disease (documented or FEV1< 30% or FVC < 50%)"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr assumed", "@", 1, "e.05", "Non-cardiovascular co-morbidity likely to cause death within 6 months (e.g. malignancy)\nSignificant renal failure (estimated GFR < 30 ml/min/m2)"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr assumed", "@", 1, "e.06", "Patient inability to provide informed consent (e.g. dementia)"));	 
           
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2017, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2017 Feb 13", 2017, 2, 13, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2017 Feb 13", 2017, 2, 13, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        if (sd_sid == "NCT00002516")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Combination Chemotherapy Plus Surgery and Radiation Therapy in Treating Patients With Ewing’s Sarcoma";
	        StringBuilder sb = new StringBuilder("RATIONALE: Drugs used in chemotherapy use different ways to stop tumor cells from dividing so they stop growing or die. ");
	        sb.Append("Radiation therapy uses high-energy x-rays to damage tumor cells. Combining more than one drug with surgery and radiation therapy may kill "); 
	        sb.Append("more tumor cells. It is not yet known which combination chemotherapy regimen is most effective in treating patients with Ewing’s sarcoma.\n\n"); 
	        sb.Append("PURPOSE: Randomized phase III trial to compare various combination chemotherapy regimens plus surgery and radiation therapy in treating patients who have Ewing’s sarcoma."); 
            string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 1992, 7, 11, 0, null, 900,
		        null, null, 35, 17, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "1999 Nov 1", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "CDR0000078196", 14, 100162, 
		        "National Cancer Institute", "https://ror.org/040gcmg81", null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "GER-GPOH-EICESS-92", 1, 12, 
		        "No organisation name provided in source data", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "MRC-EICESS-92", 1, 12, 
		        "No organisation name provided in source data", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "EU-92030", 1, 12, 
		        "No organisation name provided in source data", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "EU-205116", 1, 12, 
		        "No organisation name provided in source data", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "UKCCSG-ET1993-02", 1, 12, 
		        "No organisation name provided in source data", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "EUROPEAN INTERGROUP COOPERATIVE EWING’S SARCOMA STUDY [EICESS 92]", 16, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Heribert F Juergens", "University Hospital Muenster", 
		        100649, "University Hospital Muenster", null));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Alan W Craft", "Newcastle-upon-Tyne Hospitals NHS Trust", 
		        null, "Newcastle-upon-Tyne Hospitals NHS Trust", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100649, "University Hospital Muenster", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100456, "Medical Research Council", "https://ror.org/03x94j517"));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 215));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 325));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 525));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 11, "localized Ewing sarcoma/peripheral primitive neuroectodermal tumor", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "metastatic Ewing sarcoma/peripheral primitive neuroectodermal tumor", null, null, null, null));
	        
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Dactinomycin", 14, "D000003609", "D000003609", "Dactinomycin"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Cyclophosphamide", 14, "D000003520", "D000003520", "Cyclophosphamide"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Ifosfamide", 14, "D000007069", "D000007069", "Ifosfamide"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Doxorubicin", 14, "D000004317", "D000004317", "Doxorubicin"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Etoposide", 14, "D000005047", "D000005047", "Etoposide"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Vincristine", 14, "D000014750", "D000014750", "Vincristine"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Liposomal doxorubicin", 14, "C000506643", "C000506643", "Liposomal doxorubicin"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Sarcoma", 14, "D000012509", "2B5K", "Unspecified malignant soft tissue tumours or sarcomas of bone or articular cartilage of other or unspecified sites"));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Sarcoma, Ewing", 14, "D000012512", null, null));
            
			sb = new StringBuilder("Sari N, Toğral G, Cetindağ MF, Güngör BS, Ilhan IE. ");
			sb.Append("Treatment results of the Ewing sarcoma of bone and prognostic factors. ");
			sb.Append("Pediatr Blood Cancer. 2010 Jan;54(1):19-24. doi: 10.1002/pbc.22278.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "19760772", null, null, null));

			sb = new StringBuilder("Paulussen M, Craft AW, Lewis I, Hackshaw A, Douglas C, Dunst J, Schuck A, Winkelmann W, Köhler G, Poremba C, Zoubek A, Ladenstein R, van den Berg H, Hunold A, Cassoni A, Spooner D, Grimer R, Whelan J, McTiernan A, Jürgens H; European Intergroup Cooperative Ewing’s Sarcoma Study-92. ");
			sb.Append("Results of the EICESS-92 Study: two randomized trials of Ewing’s sarcoma treatment--cyclophosphamide compared with ifosfamide in standard-risk patients and assessment of benefit of etoposide added to standard treatment in high-risk patients. ");
			sb.Append("J Clin Oncol. 2008 Sep 20;26(27):4385-93. doi: 10.1200/JCO.2008.16.5720.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "18802150", null, null, null));
										
			sb = new StringBuilder("Whelan J, McTiernan A, Weston C, et al.: ");
			sb.Append("Consequences of different approaches to local treatment of Ewing’s sarcoma within an international randomised controlled trial: analysis of EICESS-92. [Abstract] ");
			sb.Append("J Clin Oncol 24 (Suppl 18): A-9533, 528s, 2006.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), null, null, null, null));

			sb = new StringBuilder("Paulussen M, Craft AW, Lewis I, et al.: ");
			sb.Append("Ewing tumor of bone - updated report of the European Intergroup Cooperative Ewing’s Sarcoma Study EICESS 92. [Abstract] ");
			sb.Append("Proceedings of the American Society of Clinical Oncology 21: A-1568, 2002.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), null, null, null, null));

            fs.iec!.Add(new StudyIEC(sd_sid, 1, 3, "cr assumed", "@", 1, "g.01", "DISEASE CHARACTERISTICS: Biopsy-proven Ewing's sarcoma, atypical Ewing's sarcoma, and peripheral neuroectodermal tumors No soft tissue Ewing's sarcoma or other small cell sarcomas of soft tissue Such patients should be treated on the appropriate national Soft Tissue Sarcoma Protocol Treatment must begin within 3 weeks after diagnostic biopsy Registration must occur within 6 weeks after initiation of treatment"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 3, "cr assumed", "@", 1, "g.02", "PATIENT CHARACTERISTICS: Age: Not over 35"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 3, "cr assumed", "@", 1, "g.03", "PRIOR CONCURRENT THERAPY: No prior therapy, including primary definitive local therapy"));	       
           
            fs.countries!.Add(new StudyCountry(sd_sid, 2635167, "United Kingdom", null));
	        
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Royal Victoria Infirmary", null, null, "Newcastle-upon-Tyne", 2635167, "United Kingdom", null));
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2004, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2004 May 5 (est.)", 2004, 5, 5, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2013 Sep 17 (est.)", 2013, 9, 17, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
 
        }
        
        if (sd_sid == "NCT00023244")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Steroid Withdrawal in Pediatric Kidney Transplant Recipients";
	        StringBuilder sb = new StringBuilder("The purpose of this study is to examine the effects of withdrawing steroids on graft rejection and ");
	        sb.Append("kidney functions in kidney transplant recipients between the ages of 0 and 20 years (prior to their 21st birthday).\n\n"); 
	        sb.Append("Graft survival has improved in recent years in children with kidney transplants. One bad side effect of steroid maintenance therapy "); 
	        sb.Append("has been growth retardation. Doctors believe steroids might be safely withdrawn in patients that are receiving other maintenance therapies. "); 
	        sb.Append("If steroids are removed, children might catch up in their growth and also might have fewer side effects of other kinds. "); 
	        sb.Append("This study evaluates whether steroid therapy can be withdrawn in a way that does not increase graft rejection."); 
	        string brief_desc = sb.ToString();
	        sb = new StringBuilder("(As of October 2016): Participant level data and additional relevant materials are available ");
	        sb.Append("to the public in the Immunology Database and Analysis Portal (ImmPort). "); 
	        sb.Append("ImmPort is a long-term archive of clinical and mechanistic data from DAIT-funded grants and contracts."); 
	        string dss = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2001, 1, 11, 22, "274", 900,
		        null, null, 20, 17, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2001 Aug 29", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "DAIT SW01", 14, 100168, 
		        "National Institute of Allergy and Infectious Diseases", "https://ror.org/043z4tv69", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A Double-Blind Randomized Trial of Steroid Withdrawal in Sirolimus- and Cyclosporine-Treated Primary Transplant Recipients", 
		        16, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100168, "National Institute of Allergy and Infectious Diseases", "https://ror.org/043z4tv69"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "Cooperative Clinical Trials in Pediatric Transplantation", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 510));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Cyclosporine", 14, "D000016572", "D000016572", "Cyclosporine"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Sirolimus", 14, "D000020123", "D000020123", "Sirolimus"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Sulfamethoxazole", 14, "D000013420", "D000013420", "Sulfamethoxazole"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Trimethoprim, Sulfamethoxazole Drug Combination", 14, "D000015662", "D000015662", "Trimethoprim, Sulfamethoxazole Drug Combination"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Prednisone", 14, "D000011241", "D000011241", "Prednisone"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Methylprednisolone", 14, "D000008775", "D000008775", "Methylprednisolone"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Everolimus", 14, "D000068338", "D000068338", "Everolimus"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Tacrolimus", 14, "D000016559", "D000016559", "Tacrolimus"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Cyclosporins", 14, "D000003524", "D000003524", "Cyclosporins"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Basiliximab", 14, "D000077552", "D000077552", "Basiliximab"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Kidney Failure, Chronic", 14, "D000007676", "GB61", "Chronic kidney disease"));
           
			sb = new StringBuilder("Benfield MR, Bartosh S, Ikle D, Warshaw B, Bridges N, Morrison Y, Harmon W. ");
			sb.Append("A randomized double-blind, placebo controlled trial of steroid withdrawal after pediatric renal transplantation. ");
			sb.Append("Am J Transplant. 2010 Jan;10(1):81-8. doi: 10.1111/j.1600-6143.2009.02767.x. Epub 2009 Jul 28.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "19663893", null, null, null));

			sb = new StringBuilder("McDonald RA, Smith JM, Ho M, Lindblad R, Ikle D, Grimm P, Wyatt R, Arar M, Liereman D, Bridges N, Harmon W; CCTPT Study Group. ");
			sb.Append("Incidence of PTLD in pediatric renal transplant recipients receiving basiliximab, calcineurin inhibitor, sirolimus and steroids. ");
			sb.Append("Am J Transplant. 2008 May;8(5):984-9. doi: 10.1111/j.1600-6143.2008.02167.x.'");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "18416737", null, null, null));

			fs.studylinks!.Add(new StudyLink(sd_sid, "National Institute of Allergy and Infectious Diseases (NIAID)", "https://www.niaid.nih.gov"));
			fs.studylinks.Add(new StudyLink(sd_sid, "Division of Allergy, Immunology, and Transplantation (DAIT)", "https://www.niaid.nih.gov/about/dait"));

            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Patients may be eligible for this study if they:"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Are between the ages of 0 and 20 years (prior to their 21st birthday)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Are receiving their first living related (e.g.,kidney from a relative or unrelated donor) or cadaver donor transplant"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Are willing to practice an acceptable method of birth control during the study, if women able to have children"));
            
            fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr assumed", "@", 1, "e.01", "Patients will not be eligible for this study if they:"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr assumed", "@", 1, "e.02", "Have received multiple organs"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr assumed", "@", 1, "e.03", "Have received 2 or more transplants\nHave an active infection (including tuberculosis), or cancer"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.04", "Have used an experimental agent within 4 weeks of transplantation"));	  
            
            fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            fs.countries!.Add(new StudyCountry(sd_sid, 3996063, "Mexico", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, "University of Alabama", null, null, "Birmingham", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "UCSD Medical Center", null, null, "San Diego", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Denver Children's Hospital", null, null, "Aurora", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "University of Florida Health Science Center", null, null, "Jacksonville", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Emory Children's Center", null, null, "Atlanta", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Tulane University Medical Center", null, null, "New Orleans", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "University of Maryland Medical Center", null, null, "Baltimore", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Children's Hospital of Boston", null, null, "Boston", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "University of New Mexico Health Science Center", null, null, "Albuquerque", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "The Children's Hospital of Buffalo", null, null, "Buffalo", 6252001, "United States", null));
   
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2001, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2001 Aug 31 (est.)", 2001, 8, 31, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2016 Oct 21 (est.)", 2016, 10, 21, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) IPD available - referencing IMMPORT

            sd_oid = sd_sid + " :: 80 :: Individual Participant Data Set (SDY133)";
            ob_title = display_title + " :: Individual Participant Data Set (SDY133)";
            sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Individual Participant Data Set (SDY133)", 
	            null, ob_title, null, 9, null, 14, 80, 100168, "National Institute of Allergy and Infectious Diseases", 
	            "https://ror.org/043z4tv69", "en", 12, null, null, 3, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, null, "Immport", 
	            "http://www.immport.org/immport-open/public/study/study/displayStudyDetail/SDY133", 
	            true, 39, null, null, null));

            sdo.dataset_details = new ObjectDataset(sd_oid, null, null, null, null, null, null,
	            null, null, null, null, null, null, null, null, null, null);

            fs.data_objects!.Add(sdo);

            // 3) Study protocol

            sd_oid = sd_sid + " :: 11 :: Study Protocol (SDY133)";
            ob_title = display_title + " :: Study Protocol (SDY133)";
            sdo = CreateEmptyStudyDataObject();

            sdo.data_object = new DataObject(sd_oid, sd_sid, "Study Protocol (SDY133)", null, ob_title,
	            null, 9, null, 23, 11, 100168, "National Institute of Allergy and Infectious Diseases", 
	            "https://ror.org/043z4tv69", "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, null, "Immport", 
	            "'http://www.immport.org/immport-open/public/study/study/displayStudyDetail/SDY133", 
	            true, 11, null, null, null));
 
	        fs.data_objects!.Add(sdo);
            
            // 4) Study summary, -design,-demographics, -files et al.

            sd_oid = sd_sid + " :: 38 :: Study summary, -design,-demographics, -files et al. (SDY133)";
            ob_title = display_title + " :: Study summary, -design,-demographics, -files et al. (SDY133)";
            sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Study summary, -design,-demographics, -files et al. (SDY133)", 
	            null, ob_title, null, 9, null, 23, 38, 100168, "National Institute of Allergy and Infectious Diseases", 
	            "https://ror.org/043z4tv69", "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, null, "Immport", 
	            "http://www.immport.org/immport-open/public/study/study/displayStudyDetail/SDY133", 
	            true, 11, null, null, null));
            
            fs.data_objects!.Add(sdo);
            
            return fs;
                 
        }

        if (sd_sid == "NCT01727258")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "A Test on a New Experimental Mouth Rinse for Relieving Tooth Sensitivity";
	        StringBuilder sb = new StringBuilder("This study is for people with sensitive teeth and involves going to the dentist for 4 visits over 6 weeks. ");
	        sb.Append("At each visit the dentist will look at the mouth, teeth, tongue and gums of subjects, and check for sensitive teeth.\n\n"); 
	        sb.Append("During the first 2 weeks, participants will brush their teeth two times a day with the fluoride toothpaste provided.\n\n"); 
	        sb.Append("Then, if they qualify to continue in the study, participants will be assigned to a treatment group. All the groups will "); 
	        sb.Append("get toothpaste currently sold on the market, and one group will get a mouthwash with an experimental ingredient to use "); 
	        sb.Append("as well. Subjects will have an equal chance of being assigned to any one of the three groups.\n\n"); 
	        sb.Append("For the next 4 weeks, subjects will use their assigned products according to the directions provided. At Visit 1 subjects "); 
	        sb.Append("ill be supervised while they brush their teeth to ensure they understand the directions. "); 
	        sb.Append("They will also have supervised use of the product at Visit 2.\n\n"); 
	        sb.Append("We will see if the mouthwash helps to reduce tooth sensitivity during the study.\n\n"); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2012, 12, 11, 21, "153", 900,
		        18, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2012 Nov 12", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "KOXDHY0008", 14, null, 
		        "Johnson & Johnson Consumer and Personal Products Worldwide", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "Evaluation of an Experimental Mouth Rinse Device for Relieving Dentinal Hypersensitivity", 16, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Michael Lynch", "Johnson & Johnson Consumer and Personal Products Worldwide", 
		        null, "Johnson & Johnson Consumer and Personal Products Worldwide", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Johnson & Johnson Consumer and Personal Products Worldwide", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 100));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 445));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 505));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Fluorides", 14, "D000005459", "D000005459", "Fluorides"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Dentin Sensitivity", 14, "D000003807", "D000003807", "Dentin Sensitivity"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Hypersensitivity", 14, "D000006967", "D000006967", "Hypersensitivity"));

            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Good general and oral health without any known allergy to commercial dental products or cosmetics"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Evidence of a personally signed and dated informed consent document indicating the subject (or legally acceptable representative) has been informed of all pertinent aspects of the trial"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Willingness to use the assigned products according to instructions, availability for appointments, and likelihood of completing the clinical trial"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Dental condition appropriate for inclusion in the trial according to protocol-specified parameters and the professional opinion of the investigator"));
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "Adequate oral hygiene (i.e. brush teeth daily and exhibit no signs of oral neglect"));	
            
            fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr assumed", "@", 1, "e.01", "Medical condition or history, or use of drugs or treatments that could possibly compromise the safety of the research subject or the interpretation of results, per protocol or in the opinion of the investigator"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr assumed", "@", 1, "e.02", "Use of home-care bleaching, whitening products or professional bleaching treatment within a protocol-specified time period"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.03", "Use of desensitizing agents within a protocol-specified time period"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.04", "Participation in a dental clinical trial involving oral care products within a protocol-specified time period"));	       
            
            fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, "BioSci Research America, Inc.", null, null, "Las Vegas", 6252001, "United States", null));
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2012, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2012 Nov 15 (est.)", 2012, 11, 15, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2015 Jun 10 (est.)", 2015, 6, 10, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Trial results entry
			
            sd_oid = sd_sid + " :: 28 :: CTG results entry";
            ob_title = display_title + " :: CTG results entry";
            sdo = CreateEmptyStudyDataObject();
			
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG results entry", null, ob_title,
	            null, 9, 2015, 23, 28, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid + "?tab=results", true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2015 Jun 10 (est.)", 2015, 6, 10, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2015 Jun 10 (est.)", 2015, 6, 10, null, null, null, null));

            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        if (sd_sid == "NCT02318992")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Fresh, Frozen or Lyophilized Fecal Microbiota Transplantation for Multiple Recurrent C. Difficile Associated Diarrhea";
	        StringBuilder sb = new StringBuilder("The objective of the study is to investigate the efficacy of fresh, frozen or lyophilized fecal ");
	        sb.Append("microbiota transplantation (FMT) via colonoscopy in patients with recurrent C. difficile associated diarrhea (RCDAD). "); 
	        sb.Append("Frozen, lyophilized or fresh fecal microbiota transplantation (FMT) inoculum will be generated from well-screened "); 
	        sb.Append("healthy volunteer donors of ≥150 gram/sample. Delivery of FMT will be performed colonoscopically. Fecal samples from "); 
	        sb.Append("donors and recipients will be saved for later metagenomic studies to characterize the microbiome of the gut in patients before and after FMT."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2013, 8, 11, 21, "79", 900,
		        18, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2014 Dec 9", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "HSC-SPH-13-0119", 14, null, 
		        "The University of Texas Health Science Center, Houston", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Herbert L DuPont", "The University of Texas Health Science Center, Houston", 
		        null, "The University of Texas Health Science Center, Houston", null));
	        fs.people.Add(new StudyPerson(sd_sid, 51, "Zhi-Dong Jiang", "The University of Texas Health Science Center, Houston", 
		        null, "The University of Texas Health Science Center, Houston", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "The University of Texas Health Science Center, Houston", null));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 110));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 20, 120));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Recurrent C. Difficile Associated Diarrhea", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Diarrhea", 14, "D000003967", null, null));

	        fs.relationships!.Add(new StudyRelationship(sd_sid, 23, "NCT03786900"));
	        
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Recipients"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Male and female patients ≥ 18 years of age"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Sexually active male and female patients of child-bearing potential must agree to use an effective method of birth control during the treatment and follow-up period"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Female patients of child-bearing potential must have a negative pregnancy test in the 72 hours before the procedure"));
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "Required to sign an informed consent form"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "Deemed likely to survive for ≥ 3 months after enrolment"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr assumed", "@", 1, "n.07", "Diagnosis of ≥ 3 recurrent CDAD (RCDAD) bouts in outpatients or ≥ 2 bouts of CDAD in an inpatient without other explanation for diarrhea and with ≥ 2 positive fecal tests for C. difficile toxin"));
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr assumed", "@", 1, "n.08", "Referred by subjects attending physician who will provide non-transplant care for the subject and follow up at 1, 7, 14, 30 days after FMT"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "cr assumed", "@", 1, "n.09", "Received at least one course of adequate antibiotic therapy for CDAD (≥ 10 days of vancomycin at a dose of ≥125 mg four times per day, ≥ 10 days of metronidazole at a dose of 500mg three times per day or fidaxomixin 200mg twice a day for 10 days"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "cr assumed", "@", 1, "n.10", "nAnti-Clostridium difficile infection (CDI) antibiotic treatment stopped 2-4 days before the transplantation"));
	        fs.iec.Add(new StudyIEC(sd_sid, 11, 1, "cr assumed", "@", 1, "n.11", "Donors"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 12, 1, "cr assumed", "@", 1, "n.12", "Able to provide and sign informed consent"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 13, 1, "cr assumed", "@", 1, "n.13", "Able to complete and sign the donor questionnaire"));
	        fs.iec.Add(new StudyIEC(sd_sid, 14, 1, "cr assumed", "@", 1, "n.14", "Able to adhere to fecal transplantation stool collection requirements"));
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr assumed", "@", 1, "e.01", "Recipients"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr assumed", "@", 1, "e.02", "Patients with neutropenia with absolute neutrophil count <0.5 x 109/L"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr assumed", "@", 1, "e.03", "Evidence of toxic megacolon or gastrointestinal perforation on abdominal x-ray"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "cr assumed", "@", 1, "e.04", "Peripheral white blood cell count > 15.0 x 109/L AND temperature > 38.0 °C"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "cr assumed", "@", 1, "e.05", "Active gastroenteritis due to Salmonella, Shigella, E. coli 0157:H7, Yersinia or Campylobacter, and Norovirus"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "cr assumed", "@", 1, "e.06", "Presence of colostomy"));	 
	        fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "cr assumed", "@", 1, "e.07", "Unable to tolerate human biotherapy (HBT) for any reason"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "cr assumed", "@", 1, "e.08", "Requiring systemic antibiotic therapy for more than 7 days"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr assumed", "@", 1, "e.09", "Actively taking Saccharomyces boulardii or other probiotic"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr assumed", "@", 1, "e.10", "Severe underlying disease such that the patient is not expected to survive for one or more years or unstable medical condition requiring daily change in treatments"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr assumed", "@", 1, "e.11", "Prolonged compromised immunity due to cytotoxic chemotherapy or HIV infection"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr assumed", "@", 1, "e.12", "Donors"));	 
	        fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "cr assumed", "@", 1, "e.13", "Test positive for any of variables"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "cr assumed", "@", 1, "e.14", "History of any type of active cancer or autoimmune disease"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "cr assumed", "@", 1, "e.15", "History of risk factors for acquisition of HIV, syphilis, Hepatitis B, Hepatitis C, prion or any neurological disease as determined by the donor questionnaire"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 30, 2, "cr assumed", "@", 1, "e.16", "History of gastrointestinal disorder, e.g., inflammatory bowel disease, irritable bowel syndrome, chronic constipation or diarrhea"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 31, 2, "cr assumed", "@", 1, "e.17", "Antibiotic use or any systemic immunosuppressive agents in the 3 months prior to stool donation"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 32, 2, "cr assumed", "@", 1, "e.18", "Receipt of any type of live vaccine within 3 months prior to stool donation"));	 
	        fs.iec.Add(new StudyIEC(sd_sid, 33, 2, "cr assumed", "@", 1, "e.19", "Current or previous medical or psychosocial condition"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 34, 2, "cr assumed", "@", 1, "e.20", "Body mass index over 30"));	
           
            fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, "University of Texas Health Science Center at Housotn", null, null, "Houston", 6252001, "United States", null));
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2014, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2014 Dec 18 (est.)", 2014, 12, 18, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2019 May 13", 2019, 5, 13, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Trial results entry
			
            sd_oid = sd_sid + " :: 28 :: CTG results entry";
            ob_title = display_title + " :: CTG results entry";
            sdo = CreateEmptyStudyDataObject();
			
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG results entry", null, ob_title,
	            null, 9, 2019, 23, 28, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid + "?tab=results", true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2019 May 13", 2019, 5, 13, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2019 May 13", 2019, 5, 13, null, null, null, null));

            fs.data_objects!.Add(sdo);
            
            // 3) Study Protocol and Statistical Analysis Plan
            
            sd_oid = sd_sid + " :: 74 :: Study Protocol and Statistical Analysis Plan";
            ob_title = display_title + " :: Study Protocol and Statistical Analysis Plan";
            sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Study Protocol and Statistical Analysis Plan", null, ob_title,
	            null, 9, 2019, 23, 74, 100120, "ClinicalTrials.gov", null, "en", 11, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://storage.googleapis.com/ctgov2-large-docs/92/NCT02318992/Prot_SAP_000.pdf", 
	            true, 11, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2017 Mar 15", 2017, 3, 15, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2019 Mar 25", 2019, 3, 25, null, null, null, null));
	            
            fs.data_objects!.Add(sdo);
            
            return fs;
        }
        
        if (sd_sid == "NCT02243202")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Effects of Co-administration of Canagliflozin 300 mg and Phentermine 15 mg With Placebo in the Treatment of Non-Diabetic Overweight and Obese Participants";
	        string brief_desc = "The purpose of this study is to compare the effects of canagliflozin and phentermine to those of placebo to promote on a change in body weight over a 26 week period.";
	       
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2014, 9, 12, 21, "335", 900,
		        18, 17, 65, 17, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2016 Oct 6", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "CR103086", 14, 100773, "Janssen", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "28431754OBE2002", 14, 100773, "Janssen", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, 
		        "A Randomized, Double-Blind, Placebo-Controlled, Parallel-Group Study to Investigate the Safety and Efficacy of the Co-administration of Canagliflozin 300 mg and Phentermine 15 mg Compared With Placebo for the Treatment of Non-diabetic Overweight and Obese Subjects",
		        16, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100773, "Janssen", null));
	       
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // Phase 2
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 11, "INVOKANA", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Canagliflozin", 14, "D000068896", "D000068896", "Canagliflozin"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Phentermine", 14, "D000010645", "D000010645", "Phentermine"));
	       
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Obesity", null, null, "5B81", "Obesity"));
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Overweight", 14, "D000050177", "5B80", "Overweight or localised adiposity"));

	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Must have BMI >=30 kg/m2 and <50 kg/m2 at screening or BMI >=27 kg/m2 and <50 kg/m2 at screening in the presence of a comorbidity of hypertension and/or dyslipidemia"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Must have stable weight, ie, change of < =5% in the 3 months before screening"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Must agree to utilize a highly effective method of birth control"));	    
	        
            fs.iec.Add(new StudyIEC(sd_sid, 4, 2, "cr assumed", "@", 1, "e.01", "An established diagnosis of diabetes mellitus"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr assumed", "@", 1, "e.02", "Has a history of obesity with a known secondary cause (eg, Cushing's disease/syndrome)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr assumed", "@", 1, "e.03", "Has a history of hereditary glucose-galactose malabsorption or primary renal glycosuria"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr assumed", "@", 1, "e.04", "Myocardial infarction, unstable angina, revascularization procedure, or cerebrovascular accident within 12 weeks before screening"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.05", "Has an Glycated hemoglobin (HBA1c) greater than or equal (>=) to 65 percent"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.06", "An average of 3 seated blood pressure (BP) readings of systolic BP >= 160 mm Hg and/or Diastolic BP >= 100 millimeters of mercury at screening"));	 
           
            fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            
            fs.sites!.Add(new StudyLocation(sd_sid, null, null, null, null, "Phoenix", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, null, null, null, "Walnut Creek", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, null, null, null, "Jacksonville", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, null, null, null, "Meridian", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, null, null, null, "Evansville", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, null, null, null, "Lexington", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, null, null, null, "Louisville", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, null, null, null, "New Orleans", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, null, null, null, "Milford", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, null, null, null, "Warwick", 6252001, "United States", null));
          
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2014, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2014 Sep 14 (est.)", 2014, 9, 14, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2016 Oct 6 (est.)", 2016, 10, 6, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Trial results entry
			
            sd_oid = sd_sid + " :: 28 :: CTG results entry";
            ob_title = display_title + " :: CTG results entry";
            sdo = CreateEmptyStudyDataObject();
			
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG results entry", null, ob_title,
	            null, 9, 2016, 23, 28, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid + "?tab=results", true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2016 Oct 6 (est.)", 2016, 10, 6, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2016 Oct 6 (est.)", 2016, 10, 6, null, null, null, null));

            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        
        if (sd_sid == "NCT02441309")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "A Eurosarc Study of Mifamurtide in Advanced Osteosarcoma (MEMOS)";
	        StringBuilder sb = new StringBuilder("This is a Bayesian designed multi-arm, multi-centre, open label phase II study. The target sample ");
	        sb.Append("size of 40 patients will be recruited from up to 8 EU countries, but this may be revised in light of the interim analysis. "); 
	        sb.Append("Patients with relapsed or metastatic osteosarcoma will be divided into three treatment groups. They will all either have "); 
	        sb.Append("surgery or a biopsy before and after six weeks exposure to either Mifamurtide alone, Ifosfamide alone, or Mifamurtide "); 
	        sb.Append("combined with Ifosfamide. They will then receive further treatment to a maximum of 42 or 36 weeks in "); 
	        sb.Append("total (depending on Arm), with all patients being able to receive 36 weeks of Mifamurtide treatment."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2014, 10, 11, 22, "8", 900,
		        16, 17, 65, 17, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2015 Mar 16", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "OCTO_039", 14, 100253, 
		        "University of Oxford", "https://ror.org/052gg0110", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A Mechanistic Study Of Mifamurtide (MTP-PE) In Patients With Metastatic And/Or Recurrent Osteosarcoma",
		        16, "en", 11, false, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "MEMOS", 14, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Bass Hassan", "University of Oxford", 
		        100253, "University of Oxford", "https://ror.org/052gg0110"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100253, "University of Oxford", "https://ror.org/052gg0110"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "Millennium: The Takeda Oncology Company", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100442, "National Institute for Health Research", "https://ror.org/0187kwz08"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100707, "Oxford University Hospitals NHS Trust", "https://ror.org/03h2bh287"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100574, "European Commission", "https://ror.org/00k4n6c32"));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 

	        fs.topics!.Add(new StudyTopic(sd_sid, 11, "Metastatic and/or Recurrent Osteosarcoma", null, null, null, null));
	        
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Ifosfamide", 14, "D000007069", "D000007069", "Ifosfamide"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Isophosphamide mustard", 14, "C000027061", "C000027061", "Isophosphamide mustard"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Mifamurtide", 14, "C000037144", "C000037144", "Mifamurtide"));
	        fs.topics.Add(new StudyTopic(sd_sid, 12, "Acetylmuramyl-Alanyl-Isoglutamine", 14, "D000000119", "D000000119", "Acetylmuramyl-Alanyl-Isoglutamine"));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Osteosarcoma", 14, "D000012516", "2B51", "Osteosarcoma, primary site"));

            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Relapsed osteosarcoma (first, second, third or any relapse, patient has recovered from chemotherapy and any other investigational drug/agent treatment, radiotherapy or surgical procedure)."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Histological confirmed diagnosis of osteosarcoma at original presentation."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Tumour at biopsy accessible or resectable site."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Progressive disease documented by imaging within 3 months of entry into the trial."));
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "At least one measurable lesion on CT scan (RECIST) performed in past 21 days prior to trial entry."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "Male or female, age ≥ 16 years to 65 (or ≥18 based on institutional practice for Teenage and Young Adult Cancer patients)."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr assumed", "@", 1, "n.07", "Life expectancy of at least 3 months."));
            fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr assumed", "@", 1, "n.08", "WHO performance score of 0 - 2."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "cr assumed", "@", 1, "n.09", "The patient is willing and able to comply with the protocol and scheduled follow-up visits and examinations."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "cr assumed", "@", 1, "n.10", "Written (signed and dated) informed consent."));
            fs.iec.Add(new StudyIEC(sd_sid, 11, 1, "cr assumed", "@", 1, "n.11", "Cardiac shortening fraction ≥ 28% or ejection fraction ≥ 45%"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 12, 1, "cr assumed", "@", 1, "n.12", "Renal function is adequate for ifosfamide treatment (GFR as per table below, other renal function screening tests as per local practice)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 13, 1, "cr assumed", "@", 1, "n.13", "Haematological and biochemical indices within the ranges shown below:"));
            fs.iec.Add(new StudyIEC(sd_sid, 14, 1, "cr assumed", "@", 1, "n.14", "Lab Test Value required"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 15, 1, "cr assumed", "@", 1, "n.15", "Haemoglobin (Hb) ≥ 9 g/dL (Previous transfusion is allowed)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 16, 1, "cr assumed", "@", 1, "n.16", "Absolute neutrophil count (ANC) >=1.0 x 10*9/L without growth factor support"));
            fs.iec.Add(new StudyIEC(sd_sid, 17, 1, "cr assumed", "@", 1, "n.17", "Platelet count > 80.x 10*9/L (Previous transfusion is allowed)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 18, 1, "cr assumed", "@", 1, "n.18", "Total bilirubin <1.5 times the upper limit of normal (ULN) for age (except for Gilbert's syndrome patients)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 19, 1, "cr assumed", "@", 1, "n.19", "Serum alanine aminotransferase (ALT) and/or Aspartate aminotransferase (AST) <2.5 × ULN for age, <2.5 × ULN for age"));
            fs.iec.Add(new StudyIEC(sd_sid, 20, 1, "cr assumed", "@", 1, "n.20", "Serum creatinine Normal range for age"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 21, 1, "cr assumed", "@", 1, "n.21", "Glomerular filtration rate (GFR) (calculated as 51Cr-EDTA/99mTc-DTPA clearance) >40ml/min if deemed resectable (for Arm A), >60ml/min if not deemed resectable (for Arm B or C)"));	    
  
            fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "cr assumed", "@", 1, "e.01", "Pregnant or breast-feeding woman. Men or women of childbearing potential unless effective methods of contraception are used during study treatment and for at least 7 days after the last mifamurtide dose (see section 5.1 Informed consent - Contraceptive/ Pregnancy counselling)."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr assumed", "@", 1, "e.02", "Previous treatment with mifamurtide or a mifamurtide-like drug* in a clinical trial setting for the treatment of metastatic and/or recurrent osteosarcoma in the six months prior to registration."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr assumed", "@", 1, "e.03", "Contraindications to lung biopsies."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr assumed", "@", 1, "e.04", "Hypersensitivity to ifosfamide or any component of the formulation."));	  
            fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr assumed", "@", 1, "e.05", "Previously diagnosed brain metastases."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "cr assumed", "@", 1, "e.06", "Significant active cardiac disease including: uncontrolled high blood pressure (no greater than 2 standard deviations above the mean for age for systolic blood pressure (SBP) and diastolic blood pressure (DBP), unstable angina, congestive heart failure, myocardial infarction within the previous 6 months, or serious cardiac arrhythmias and with a history of pericarditis and myocarditis"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "cr assumed", "@", 1, "e.07", "Treatment with any other investigational agent, or participation in another interventional clinical trial within 21 days prior to enrolment."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "cr assumed", "@", 1, "e.08", "Major surgery within 21 days prior to first study biopsy"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 30, 2, "cr assumed", "@", 1, "e.09", "Currently taking high-dose non-steroidal anti-inflammatory drugs (NSAIDs) or corticosteroid treatment"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 31, 2, "cr assumed", "@", 1, "e.10", "Concurrent use of ciclosporin or other calcineurin inhibitors."));	  
            fs.iec.Add(new StudyIEC(sd_sid, 32, 2, "cr assumed", "@", 1, "e.11", "Any psychological, social or medical condition, physical examination finding or a laboratory abnormality that the Investigator considers would make the patient a poor trial candidate or could interfere with protocol compliance or the interpretation of trial results."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 33, 2, "cr assumed", "@", 1, "e.12", "Any other active malignancy, with the exception of adequately treated cone-biopsied in situ carcinoma of the cervix uteri and non-melanoma skin lesions."));	 
            fs.iec.Add(new StudyIEC(sd_sid, 34, 2, "cr assumed", "@", 1, "e.13", "Patients who are known to be serologically positive for Hepatitis B, Hepatitis C or HIV."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 35, 2, "cr assumed", "@", 1, "e.14", "mifamurtide-like drugs include GCSF, GMCSF, interferon and other macrophage activating molecules."));	 
            
            fs.countries!.Add(new StudyCountry(sd_sid, 2921044, "Germany", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3175395, "Italy", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2750405, "Netherlands", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3144096, "Norway", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2635167, "United Kingdom", null));
             
            fs.sites!.Add(new StudyLocation(sd_sid, null, "Pediatric Hematology and Oncology, University Hospital Münster", null, null, "Münster", 2921044, "Germany", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Istituti Ortopedici Rizzoli", null, null, "Bologna",  3175395, "Italy", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Department of Clinical Oncology, Leiden University Medical Center", null, null, "Leiden", 2750405, "Netherlands", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Radium Hospital, Oslo University", null, null, "Oslo", 3144096, "Norway", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Leeds Teaching Hospitals NHS Trust", null, null, "Leeds", 2635167, "United Kingdom", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "University College London Hospitals NHS Foundation Trust", null, null, "London", 2635167, "United Kingdom", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Christie Hospital NHS Foundation Trust", null, null, "Manchester", 2635167, "United Kingdom", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Oxford University Hospitals NHS Foundations Trust", null, null, "Oxford", 2635167, "United Kingdom", null));
         
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
            string ob_title = display_title + " :: CTG registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
	            null, 9, 2015, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2015 May 12 (est.)", 2015, 5, 12, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2019 Sep 13", 2019, 9, 13, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Trial results entry
			
            sd_oid = sd_sid + " :: 28 :: CTG results entry";
            ob_title = display_title + " :: CTG results entry";
            sdo = CreateEmptyStudyDataObject();
			
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG results entry", null, ob_title,
	            null, 9, 2019, 23, 28, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov", 
	            "https://clinicaltrials.gov/study/" + sd_sid + "?tab=results", true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2019 Sep 13", 2019, 9, 13, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2019 Sep 13", 2019, 9, 13, null, null, null, null));

            fs.data_objects!.Add(sdo);

            return fs;
        }

        
        if (sd_sid == "NCT02609386")
        {
	        FullStudy fs = CreateEmptyFullStudy();

	        // Study 

	        string display_title =
		        "IRX-2 Regimen in Patients With Newly Diagnosed Stage II, III, or IVA Squamous Cell Carcinoma of the Oral Cavity";
	        StringBuilder sb =
		        new StringBuilder(
			        "The purpose of this study is to determine whether a pre-operative regimen of the study drug, ");
	        sb.Append(
		        "IRX-2, a human cell-derived biologic with multiple active cytokine components, plus a single dose of cyclophosphamide, ");
	        sb.Append(
		        "followed by 21 days of indomethacin, zinc-containing multivitamins, and omeprazole is active in treatment ");
	        sb.Append(
		        "of oral cavity cancer. The regimen is intended to stimulate an immune response against the cancer.");
	        string brief_desc = sb.ToString();

	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2015, 12, 11, 15, "105", 900,
		        18, 17, null, null, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2015 Sep 10", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "IRX-2 2015-A", 14, null, 
		        "Brooklyn ImmunoTherapeutics, LLC", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "A Randomized Phase 2 Trial of Neoadjuvant and Adjuvant Therapy With the IRX 2 Regimen in Patients With Newly Diagnosed Stage II, III, or IVA Squamous Cell Carcinoma of the Oral Cavity", 16, "en", 11, false, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "INSPIRE", 14, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Gregory T Wolf", "University of Michigan Hospitals", 
		        null, "University of Michigan Hospitals", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Brooklyn ImmunoTherapeutics, LLC", null));

		    fs.features!.Add(new StudyFeature(sd_sid, 20, 120));  // 
		    fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
		    fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
		    fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
		    fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 

		    fs.topics!.Add(new StudyTopic(sd_sid, 11, "Head and Neck Neoplasms", null, null, null, null));
		    fs.topics.Add(new StudyTopic(sd_sid, 11, "Immunotherapy", null, null, null, null));
		    fs.topics.Add(new StudyTopic(sd_sid, 11, "Cancer", null, null, null, null));
		    fs.topics.Add(new StudyTopic(sd_sid, 11, "Oral Cavity", null, null, null, null));
		    
		    fs.topics.Add(new StudyTopic(sd_sid, 12, "Zinc", 14, "D000015032", "D000015032", "Zinc"));
		    fs.topics.Add(new StudyTopic(sd_sid, 12, "Indomethacin", 14, "D000007213", "D000007213", "Indomethacin"));
		    fs.topics.Add(new StudyTopic(sd_sid, 12, "Cyclophosphamide", 14, "D000003520", "D000003520", "Cyclophosphamide"));
		    fs.topics.Add(new StudyTopic(sd_sid, 12, "Omeprazole", 14, "D000009853", "D000009853", "Omeprazole"));
		    fs.topics.Add(new StudyTopic(sd_sid, 12, "Proton Pump Inhibitors", 14, "D000054328", "D000054328", "Proton Pump Inhibitors"));
		    
		    fs.conditions!.Add(new StudyCondition(sd_sid, "Squamous Cell Carcinoma of the Oral Cavity", null, null, "", ""));
		    fs.conditions.Add(new StudyCondition(sd_sid, "Carcinoma", 14, "D000002277", "2", "Neoplasms"));
		    fs.conditions.Add(new StudyCondition(sd_sid, "Carcinoma, Squamous Cell", 14, "D000002294", "2C31", "Squamous cell carcinoma of skin"));
	        
            sb = new StringBuilder("Wolf GT, Liu S, Bellile E, Sartor M, Rozek L, Thomas D, Nguyen A, Zarins K, McHugh JB; ");
			sb.Append("INSPIRE Trial Clinical Investigators. Tumor infiltrating lymphocytes after neoadjuvant IRX-2 immunotherapy in oral squamous cell carcinoma: Interim findings from the INSPIRE trial. ");
			sb.Append("Oral Oncol. 2020 Jul 29;111:104928. doi: 10.1016/j.oraloncology.2020.104928. [Epub ahead of print]");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "32738599", null, null, null));

			fs.studylinks!.Add(new StudyLink(sd_sid, "INSPIRE Trial website", "http://InspireHNC.com"));
			fs.studylinks.Add(new StudyLink(sd_sid, "Sponsor’s website", "http://irxtherapeutics.com"));

	        // countries
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Pathologically confirmed (histology or cytology) clinical Stage II, III, or IVA squamous cell cancer of the oral cavity (excluding lip). Subjects must be staged using AJCC Cancer Staging Manual Edition 7.0 (appendices 1 and 2)."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Disease surgically resectable with curative intent"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Hematological function: hemoglobin >9 g/dL; lymphocyte count >0.50 x 109/L; neutrophil count >1.5 x 109/L; platelet count >100 x 109/L"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Hepatic function: serum albumin >3.0 g/dL; aspartate aminotransferase (AST/SGOT) and alanine aminotransferase (ALT/SGPT) <3x the upper limits of normal (ULN); alkaline phosphatase <2x the ULN"));
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr assumed", "@", 1, "n.05", "Prothrombin time (PT) and partial thromboplastin time (PTT) < 1.4x the ULN"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr assumed", "@", 1, "n.06", "Calculated creatinine clearance > 50 mL/minute (Appendix 4)"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr assumed", "@", 1, "n.07", "At least 18 years of age"));
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr assumed", "@", 1, "n.08", "Willing and able to give informed consent and adhere to protocol therapy"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "cr assumed", "@", 1, "n.09", "Karnofsky performance status (KPS) >=70%"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "cr assumed", "@", 1, "n.10", "Females of childbearing potential (not surgically sterile or less than 12 months post-menopausal) must be able and willing to use a highly effective form of pregnancy prevention from the time of screening, during the study and 30 days after last dose of study regimen. Males with a partner of childbearing potential must use condoms with spermicide from the date of screening to 30 days after their last dose of study regimen"));
	        fs.iec.Add(new StudyIEC(sd_sid, 11, 1, "cr assumed", "@", 1, "n.11", "Negative urine/serum pregnancy test, if applicable"));
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr assumed", "@", 1, "e.01", "Prior surgery, radiation therapy, or chemotherapy other than biopsy or emergency procedure required for supportive care of this oral cavity cancer."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr assumed", "@", 1, "e.02", "Any medical contraindications or previous therapy that would preclude treatment with either IRX 2 Regimen 1 or 2 or the surgery, reconstruction or adjuvant therapy required to treat the oral tumor appropriately"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr assumed", "@", 1, "e.03", "Live vaccines should ideally not be administered to any patients undergoing treatment with chemotherapy or immunotherapy, but if need be, they should be administered >4 months prior to the initiation of treatment or >4 months after the completion of all treatment"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr assumed", "@", 1, "e.04", "Inactivated vaccines should precede the initiation of any study regimen and/or standard adjuvant therapy by at least 2 weeks, but preferably 4 weeks or longer"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr assumed", "@", 1, "e.05", "Clinical status of either subject or tumor such that administration of 21 day neoadjuvant IRX-2 Regimen 1 or 2 before surgery would be medically inappropriate"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr assumed", "@", 1, "e.06", "Tumor of the oropharynx"));	
	        fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "cr assumed", "@", 1, "e.07", "Tumor involvement of the following sites or any of these signs or symptoms likely to be associated with T4b cancer:"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "cr assumed", "@", 1, "e.08", "involvement of pterygopalatine fossa, maxillary sinus, or facial skin;."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "cr assumed", "@", 1, "e.09", "gross extension of tumor to the skull base;"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "cr assumed", "@", 1, "e.10", "pterygoid plate erosion;"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "cr assumed", "@", 1, "e.11", "sphenoid bone or foramen ovale involvement;"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr assumed", "@", 1, "e.12", "direct extension to involve prevertebral fascia;"));	
	        fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr assumed", "@", 1, "e.13", "extension to superior nasopharynx or Eustachian tube;"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr assumed", "@", 1, "e.14", "direct extension into the neck with involvement of the deep neck musculature (neck node fixation);"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr assumed", "@", 1, "e.15", "suspected invasion (encasement) of the common or internal carotid arteries. Encasement will be assessed radiographically and will be defined as tumor surrounding the carotid artery 270º or greater;"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "cr assumed", "@", 1, "e.16", "direct extension of neck disease to involve the external skin;"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "cr assumed", "@", 1, "e.17", "direct extension to mediastinal structures;"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "cr assumed", "@", 1, "e.18", "regional metastases to the supraclavicular neck (low level IVB or VB)"));	
	        fs.iec.Add(new StudyIEC(sd_sid, 30, 2, "cr assumed", "@", 1, "e.19", "Any investigational agent within the previous 30 days."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 31, 2, "cr assumed", "@", 1, "e.20", "Daily administration of systemic immunosuppressive therapy or corticosteroids (except in physiological doses for hormone deficiency) during the previous 30 days."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 32, 2, "cr assumed", "@", 1, "e.21", "nChronic anticoagulation, not including aspirin, but including heparins, warfarin, oral anticoagulation or other platelet function inhibitors, that can not, in the documented opinion of the investigator, safely be interrupted from at least 2 days prior to the initiation of the study regimen until after surgical resection of the tumor."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 33, 2, "cr assumed", "@", 1, "e.22", "Symptomatic cardiopulmonary disease (including congestive heart failure and hypertension), coronary artery disease, serious arrhythmia or chronic lung disease. Patients with these conditions who are stable with relatively minor symptoms and who are appropriate candidates for surgical treatment of their tumor need not be excluded"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 34, 2, "cr assumed", "@", 1, "e.23", "Myocardial infarction within the last 3 months"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 35, 2, "cr assumed", "@", 1, "e.24", "Distant metastases (M1 disease)."));	
	        fs.iec.Add(new StudyIEC(sd_sid, 36, 2, "cr assumed", "@", 1, "e.25", "Known infection with hepatitis B, hepatitis C, or HIV."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 37, 2, "cr assumed", "@", 1, "e.26", "Signs or symptoms of systemic bacterial infection (use of antibiotics to treat superficial infection or contamination of tumor shall not, by itself, be considered evidence of infection)."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 38, 2, "cr assumed", "@", 1, "e.27", "Clinically significant gastritis or peptic ulcer disease that would contraindicate the use of indomethacin."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 39, 2, "cr assumed", "@", 1, "e.28", "Stroke or other symptoms of cerebral vascular insufficiency within the last 3 months."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 40, 2, "cr assumed", "@", 1, "e.29", "Allergy to ciprofloxacin (or other quinolones), acetylsalicylic acid, or indomethacin."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 41, 2, "cr assumed", "@", 1, "e.30", "Previous diagnosis of invasive cancer from which the individual is NOT disease-free AND that has required treatment within the past 5 years, except for superficial skin, cervical cancer in-situ, well-differentiated thyroid or early stage prostate or bladder cancer (i.e., treatment with curative intent and long term disease-free expectations)."));	
	        fs.iec.Add(new StudyIEC(sd_sid, 42, 2, "cr assumed", "@", 1, "e.31", "Prior axillary dissection."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 43, 2, "cr assumed", "@", 1, "e.32", "Breastfeeding women."));	
	        
	        fs.countries!.Add(new StudyCountry(sd_sid, 6252001, "United States", null));
            fs.countries.Add(new StudyCountry(sd_sid, 3469034, "Brazil", null));
            fs.countries.Add(new StudyCountry(sd_sid, 6251999, "Canada", null));
            fs.countries.Add(new StudyCountry(sd_sid, 2635167, "United Kingdom", null));

            fs.sites!.Add(new StudyLocation(sd_sid, null, "Banner University Medical Center", null, null, "Tucson", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "University of Arkansas For Medical Sciences", null, null, "Little Rock", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "USC Norris Comprehensive Cancer Center", null, null, "Los Angeles", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Stanford University Medical Center", null, null, "Stanford", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Emory University - Winship Cancer Center", null, null, "Atlanta", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "University of Kentucky", null, null, "Lexington", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "University of Michigan", null, null, "Ann Arbor", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Nebraska Methodist Hospital", null, null, "Omaha", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Monter Cancer Center - North Shore LIJ", null, null, "New Hyde Park", 6252001, "United States", null));
            fs.sites.Add(new StudyLocation(sd_sid, null, "Lenox Hill Hospital", null, null, "New York", 6252001, "United States", null));
	        
	        // Data Objects

	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: CTG registry entry";
	        string ob_title = display_title + " :: CTG registry entry";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();

	        sdo.data_object = new DataObject(sd_oid, sd_sid, "CTG registry entry", null, ob_title,
		        null, 9, 2015, 23, 13, 100120, "ClinicalTrials.gov", null, "en", 12, null, null, 0, true, true);

	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100120, "ClinicalTrials.gov",
		        "https://clinicaltrials.gov/study/" + sd_sid, true, 39, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2015 Nov 20 (est.)", 2015, 11, 20, null, null,
		        null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2023 May 9", 2023, 5, 9, null, null, null, null));

	        fs.data_objects!.Add(sdo);

	        return fs;
        }

        return null;
    }
}