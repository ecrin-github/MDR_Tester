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
	        
	        // countries
            
	        // iec
	        
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
            
            // countries
            
            // iec
            
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

			// countries
            
			// iec
            
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

	        // countries
            
	        // iec
	        
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
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2020 Jun 5", 2020, 6, 4, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2020 Jul 23", 2020, 6, 4, null, null, null, null));
	        
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

	        // countries
            
	        // iec
	        
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
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 May 12", 2021, 5, 12, null, null, null, null));
	       
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

            // countries
            
            // iec
	        
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
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 May 2 (est.)", 2022, 5, 2, null, null, null, null));
	       
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

            // countries
            
            // iec
	        
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
 
			// countries
            
            // iec
	        
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
	        sb.Append("roteinuria was tested using dipstick method as +=0.3 gm/L, ++=1 gm/L, and +++=3 gm/L.\n\n"); 
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

             // countries
                
             // iec
                
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

            // countries
            
            // iec
	        
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
		        null, null, null, null, 7);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2018 Dec 11", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "HSC-SPH-15-0991", 14, null, 
		        "The University of Texas Health Science Center, Houston", null, null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 70, "Herbert DuPont", "he University of Texas Health Science Center, Houston'", 
		        null, "he University of Texas Health Science Center, Houston'", null));

            /*

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Recurrent Clostridium Difficile Infection');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Multidrug-resistant Klebsiella Pneumoniae Urinary Tract Infection');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000007239', mvalue => 'Infection');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000003141', mvalue => 'Communicable Diseases');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000014552', mvalue => 'Urinary Tract Infections');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000003015', mvalue => 'Clostridium Infections');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000011014', mvalue => 'Pneumonia');

call expected.insert_study_relationship(sid => _sid, typeid => 24, targetsid => 'NCT02449174');
call expected.insert_study_relationship(sid => _sid, typeid => 24, targetsid => 'NCT02318992');
 */
            // countries
            
            // iec
	        
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
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 Jan 22 (est.)", 2021, 1, 22, null, null, null, null));
	       
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

 /*
 call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Pancreatic Adenocarcinoma');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Resectable Pancreatic Carcinoma');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000000230', mvalue => 'Adenocarcinoma');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000010190', mvalue => 'Pancreatic Neoplasms');

call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'C000056507', mvalue => 'Gemcitabine');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000017239', mvalue => 'Paclitaxel');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000002166', mvalue => 'Camptothecin');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000068196', mvalue => 'Albumin-Bound Paclitaxel');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000005472', mvalue => 'Fluorouracil');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000077150', mvalue => 'Oxaliplatin');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000077146', mvalue => 'Irinotecan');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000020799', mvalue => 'Pancrelipase');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000010194', mvalue => 'Pancreatin');
 */
			            
			sb = new StringBuilder("Sohal DPS, Duong M, Ahmad SA, Gandhi NS, Beg MS, Wang-Gillam A, Wade JL 3rd, Chiorean EG, Guthrie KA, Lowy AM, Philip PA, Hochster HS. ");
			sb.Append("Efficacy of Perioperative Chemotherapy for Resectable Pancreatic Adenocarcinoma: A Phase 2 Randomized Clinical Trial. ");
			sb.Append("JAMA Oncol. 2021 Mar 1;7(3):421-427. doi: 10.1001/jamaoncol.2020.7328. Erratum in: JAMA Oncol. 2021 Sep 23;:null.'");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "33475684", null, null, null));

			sb = new StringBuilder("Ahmad SA, Duong M, Sohal DPS, Gandhi NS, Beg MS, Wang-Gillam A, Wade JL 3rd, Chiorean EG, Guthrie KA, Lowy AM, Philip PA, Hochster HS. ");
			sb.Append("Surgical Outcome Results From SWOG S1505: A Randomized Clinical Trial of mFOLFIRINOX Versus Gemcitabine/Nab-paclitaxel for Perioperative Treatment of Resectable Pancreatic Ductal Adenocarcinoma. ");
			sb.Append("Ann Surg. 2020 Sep 1;272(3):481-486. doi: 10.1097/SLA.0000000000004155.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "32740235", null, null, null));

            // countries
            
            // iec
	        
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
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 Dec 2", 2021, 12, 2, null, null, null, null));
	       
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
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 Dec 2", 2021, 12, 2, null, null, null, null));

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
            
            /*	        
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'C. Difficile');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000003967', mvalue => 'Diarrhea');

call expected.insert_study_relationship(sid => _sid, typeid => 23, targetsid => 'NCT03786900');
 */

            sb = new StringBuilder("iang ZD, Jenq RR, Ajami NJ, Petrosino JF, Alexander AA, Ke S, Iqbal T, DuPont AW, Muldrew K, Shi Y, Peterson C, Do KA, DuPont HL. ");
			sb.Append("Safety and preliminary efficacy of orally administered lyophilized fecal microbiota product compared with frozen product given by enema for recurrent Clostridium difficile infection: A randomized clinical trial. ");
			sb.Append("PLoS One. 2018 Nov 2;13(11):e0205064. doi: 10.1371/journal.pone.0205064. eCollection 2018.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "30388112", null, null, null));

            // countries
            
            // iec
	        
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
	        
            /*
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000077300', mvalue => 'Bosentan');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000068677', mvalue => 'Sildenafil Citrate');

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Pulmonary Arterial Hypertension');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000065627', mvalue => 'Familial Primary Pulmonary Hypertension');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000006973', mvalue => 'Hypertension');

 */
            
			sb = new StringBuilder("Benza RL, Raina A, Gupta H, Murali S, Burden A, Zastrow MS, Park MH, Simon MA. ");
			sb.Append("Bosentan-based, treat-to-target therapy in patients with pulmonary arterial hypertension: results from the COMPASS-3 study. ");
			sb.Append("Pulm Circ. 2018 Jan-Mar;8(1):2045893217741480. doi: 10.1177/2045893217741480. Epub 2017 Oct 24.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "29064349", null, null, null));

            // countries
            
            // iec
	        
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
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Elcio Marcantonio Jr", null, null, null, null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 101740, "São Paulo State University", "https://ror.org/00987cb86"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "Fundação de Amparo à Pesquisa do Estado de São Paulo", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, null, "Conselho Nacional de Desenvolvimento Científico e Tecnológico", null));

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
	        
            /*
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Tooth Socket');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Dental Implants');

call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000000082', mvalue => 'Acetaminophen');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000000658', mvalue => 'Amoxicillin');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000002710', mvalue => 'Chlorhexidine');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'C000010882', mvalue => 'Chlorhexidine gluconate');

call expected.insert_study_ipd_available(sid => _sid, ipd_type => 'Individual Participant Data Set',
			ipd_url => 'http://aplicacao.saude.gov.br/plataformabrasil/login.jsf',
			ipd_comment => 'Public title: Stability of the architecture of the hard and soft tissue after immediate tooth replacement with implants in fresh grafted sockets.

All data can be downloaded from the website, if there are any questions please feel free to contact us.');
call expected.insert_study_ipd_available(sid => _sid, ipd_type => 'Study Protocol',
			ipd_url => 'http://aplicacao.saude.gov.br/plataformabrasil/login.jsf',
			ipd_comment => 'Public title: Stability of the architecture of the hard and soft tissue after immediate tooth replacement with implants in fresh grafted sockets. All data can be downloaded from the website, if there are any questions please feel free to contact us.');
call expected.insert_study_ipd_available(sid => _sid, ipd_type => 'Statistical Analysis Plan',
			ipd_url => 'http://aplicacao.saude.gov.br/plataformabrasil/login.jsf',
			ipd_comment => 'Public title: Stability of the architecture of the hard and soft tissue after immediate tooth replacement with implants in fresh grafted sockets. All data can be downloaded from the website, if there are any questions please feel free to contact us.');
call expected.insert_study_ipd_available(sid => _sid, ipd_type => 'Informed Consent Form',
			ipd_url => 'http://aplicacao.saude.gov.br/plataformabrasil/login.jsf',
			ipd_comment => 'Public title: Stability of the architecture of the hard and soft tissue after immediate tooth replacement with implants in fresh grafted sockets. All data can be downloaded from the website, if there are any questions please feel free to contact us.');
call expected.insert_study_ipd_available(sid => _sid, ipd_type => 'Clinical Study Report',
			ipd_url => 'http://aplicacao.saude.gov.br/plataformabrasil/login.jsf',
			ipd_comment => 'Public title: Stability of the architecture of the hard and soft tissue after immediate tooth replacement with implants in fresh grafted sockets. All data can be downloaded from the website, if there are any questions please feel free to contact us.');
call expected.insert_study_ipd_available(sid => _sid, ipd_type => 'Analytic Code',
			ipd_url => 'http://aplicacao.saude.gov.br/plataformabrasil/login.jsf',
			ipd_comment => 'Public title: Stability of the architecture of the hard and soft tissue after immediate tooth replacement with implants in fresh grafted sockets. All data can be downloaded from the website, if there are any questions please feel free to contact us.');

call  expected.insert_study_link (sid => _sid, label => 'All data can be downloaded from the website, if there are any questions please feel free to contact us', 
			url => 'http://aplicacao.saude.gov.br/plataformabrasil/login.jsf');
			 */
            // countries
            
            // iec
	        
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
	        
            /*
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000001507', mvalue => 'Beclomethasone');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000068299', mvalue => 'Salmeterol Xinafoate');

call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000001249', mvalue => 'Asthma');
			 */
            
			sb = new StringBuilder("Wechsler ME, Kunselman SJ, Chinchilli VM, Bleecker E, Boushey HA, Calhoun WJ, Ameredes BT, Castro M, Craig TJ, Denlinger L, Fahy JV, Jarjour N, Kazani S, Kim S, Kraft M, Lazarus SC, Lemanske RF Jr, Markezich A, Martin RJ, Permaul P, Peters SP, Ramsdell J, Sorkness CA, Sutherland ER, Szefler SJ, Walter MJ, Wasserman SI, Israel E; National Heart, Lung and Blood Institute’s Asthma Clinical Research Network. ");
			sb.Append("Effect of beta2-adrenergic receptor polymorphism on response to longacting beta2 agonist in asthma (LARGE trial): a genotype-stratified, randomised, placebo-controlled, crossover trial. ");
			sb.Append("Lancet. 2009 Nov 21;374(9703):1754-64. doi: 10.1016/S0140-6736(09)61492-6.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "19932356", null, null, null));		

			fs.studylinks!.Add(new StudyLink(sd_sid, "Asthma Clinical Research Network (ACRN) Website", 
				"http://www.acrn.org"));

            // countries
            
            // iec
	        
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
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54,  100837, "niversity of Leicester", "https://ror.org/04h699437"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100442, "National Institute for Health Research", "https://ror.org/0187kwz08"));

	        fs.features!.Add(new StudyFeature(sd_sid, 30, 600));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 31, 705));   //  
            fs.features.Add(new StudyFeature(sd_sid, 32, 805));   //
            
	        fs.topics!.Add(new StudyTopic(sd_sid, 11, "HFpEF", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "HFrEF", null, null, null, null));
	        
            /*
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Patients With Heart Failure and Preserved Ejection Fraction - HFpEF');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Patients With Heart Failure With Reduced Ejection Fraction - HFrEF');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Healthy Controls Group - Age and Sex-matched');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000006333', mvalue => 'Heart Failure');
 */
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

            // countries
            
            // iec
	        
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
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 1992, 7, 11, 0, null, 980,
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
            /*
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000003609', mvalue => 'Dactinomycin');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000003520', mvalue => 'Cyclophosphamide');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000007069', mvalue => 'Ifosfamide');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000004317', mvalue => 'Doxorubicin');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000005047', mvalue => 'Etoposide');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000014750', mvalue => 'Vincristine');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'C000506643', mvalue => 'Liposomal doxorubicin');

call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000012509', mvalue => 'Sarcoma');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000012512', mvalue => 'Sarcoma, Ewing');
 */
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

            // countries
            
            // iec
	        
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
	        
            /*	        
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000016572', mvalue => 'Cyclosporine');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000020123', mvalue => 'Sirolimus');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000013420', mvalue => 'Sulfamethoxazole');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000015662', mvalue => 'Trimethoprim, Sulfamethoxazole Drug Combination');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000011241', mvalue => 'Prednisone');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000008775', mvalue => 'Methylprednisolone');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000068338', mvalue => 'Everolimus');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000016559', mvalue => 'Tacrolimus');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000003524', mvalue => 'Cyclosporins');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000077552', mvalue => 'Basiliximab');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000007676', mvalue => 'Kidney Failure, Chronic');
			 */

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

            // countries
            
            // iec
	        
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
  /*
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000005459', mvalue => 'Fluorides');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000003807', mvalue => 'Dentin Sensitivity');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000006967', mvalue => 'Hypersensitivity');
 */
            // countries
            
            // iec
	        
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
	        fs.features.Add(new StudyFeature(sd_sid, 20, 120));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 

 /*
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Recurrent C. Difficile Associated Diarrhea');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000003967', mvalue => 'Diarrhea');

call expected.insert_study_relationship(sid => _sid, typeid => 23, targetsid => 'NCT03786900');

 */
            // countries
            
            // iec
	        
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
	        
	        string display_title = "Aldosterone Antagonist Therapy for Adults With Heart Failure and Preserved Systolic Function";
	        StringBuilder sb = new StringBuilder("The purpose of this study is to evaluate the effectiveness of aldosterone antagonist therapy in reducing cardiovascular ");
	        sb.Append("mortality, aborted cardiac arrest, and heart failure hospitalization in patients who have heart failure with preserved systolic function."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2006, 8, 12, 21, "3445", 900,
		        50, 17, null, null, 10);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100120, 
		        "Clinicaltrials.gov", null, "2004 Oct 15", null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "160", 14, null, 
		        "HealthCore-NERI", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "HHSN268200425207C", 13, 100134, 
		        "National Institutes of Health", "https://ror.org/01cwqze88", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "Treatment of Preserved Cardiac Function Heart Failure With an Aldosterone Antagonist (TOPCAT)", 16, "en", 11, false, "From Clinicaltrials.gov"));
	        fs.titles.Add(new StudyTitle(sd_sid, "TOPCAT", 14, "en", 11, false, "From Clinicaltrials.gov"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Sonja M McKinlay", "New England Research Institutes, Inc", 
		        null, "New England Research Institutes", null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "HealthCore-NERI", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 69, 100167, "National Heart, Lung, and Blood Institute", "https://ror.org/012pb6c26"));

	        fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 515));   // 

	        fs.topics!.Add(new StudyTopic(sd_sid, 11, "Diastolic Heart Failure", null, null, null, null));
	        fs.topics.Add(new StudyTopic(sd_sid, 11, "Preserved Ejection Fraction", null, null, null, null));
 /*
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000013148', mvalue => 'Spironolactone');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000000451', mvalue => 'Mineralocorticoid Receptor Antagonists');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000006333', mvalue => 'Heart Failure');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000006331', mvalue => 'Heart Diseases');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000002318', mvalue => 'Cardiovascular Diseases');

*/
			sb = new StringBuilder("Shah SJ, Heitner JF, Sweitzer NK, Anand IS, Kim HY, Harty B, Boineau R, Clausell N, Desai AS, Diaz R, Fleg JL, Gordeev I, Lewis EF, Markov V, O’Meara E, Kobulia B, Shaburishvili T, Solomon SD, Pitt B, Pfeffer MA, Li R. B");
			sb.Append("Baseline characteristics of patients in the treatment of preserved cardiac function heart failure with an aldosterone antagonist trial. ");
			sb.Append("Circ Heart Fail. 2013 Mar;6(2):184-92. doi: 10.1161/CIRCHEARTFAILURE.112.972794. Epub 2012 Dec 20.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "23258572", null, null, null));

			sb = new StringBuilder("Shah AM, Shah SJ, Anand IS, Sweitzer NK, O’Meara E, Heitner JF, Sopko G, Li G, Assmann SF, McKinlay SM, Pitt B, Pfeffer MA, Solomon SD; TOPCAT Investigators. ");
			sb.Append("Cardiac structure and function in heart failure with preserved ejection fraction: baseline findings from the echocardiographic study of the Treatment of Preserved Cardiac Function Heart Failure with an Aldosterone Antagonist trial. ");
			sb.Append("Circ Heart Fail. 2014 Jan;7(1):104-15. doi: 10.1161/CIRCHEARTFAILURE.113.000887. Epub 2013 Nov 18.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "24249049", null, null, null));

			sb = new StringBuilder("Pitt B, Pfeffer MA, Assmann SF, Boineau R, Anand IS, Claggett B, Clausell N, Desai AS, Diaz R, Fleg JL, Gordeev I, Harty B, Heitner JF, Kenwood CT, Lewis EF, O’Meara E, Probstfield JL, Shaburishvili T, Shah SJ, Solomon SD, Sweitzer NK, Yang S, McKinlay SM; TOPCAT Investigators. ");
			sb.Append("Spironolactone for heart failure with preserved ejection fraction. ");
			sb.Append("N Engl J Med. 2014 Apr 10;370(15):1383-92. doi: 10.1056/NEJMoa1313731.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "24716680", null, null, null));

			sb = new StringBuilder("Shah AM, Claggett B, Sweitzer NK, Shah SJ, Anand IS, O’Meara E, Desai AS, Heitner JF, Li G, Fang J, Rouleau J, Zile MR, Markov V, Ryabov V, Reis G, Assmann SF, McKinlay SM, Pitt B, Pfeffer MA, Solomon SD. ");
			sb.Append("Cardiac structure and function and prognosis in heart failure with preserved ejection fraction: findings from the echocardiographic study of the Treatment of Preserved Cardiac Function Heart Failure with an Aldosterone Antagonist (TOPCAT) Trial. ");
			sb.Append("Circ Heart Fail. 2014 Sep;7(5):740-51. doi: 10.1161/CIRCHEARTFAILURE.114.001583. Epub 2014 Aug 13.");
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
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31779923", null, null, null));

			sb = new StringBuilder("Angraal S, Mortazavi BJ, Gupta A, Khera R, Ahmad T, Desai NR, Jacoby DL, Masoudi FA, Spertus JA, Krumholz HM. ");
			sb.Append("Machine Learning Prediction of Mortality and Hospitalization in Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("JACC Heart Fail. 2020 Jan;8(1):12-21. doi: 10.1016/j.jchf.2019.06.013. Epub 2019 Oct 9.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31606361", null, null, null));

			sb = new StringBuilder("Beale AL, Nanayakkara S, Kaye DM. I");
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
			sb.Append("Am J Hypertens. 2018 Mar 10;31(4):407-414. doi: 10.1093/ajh/hpx210.'");
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
			sb.Append("Circ Heart Fail. 2016 Apr;9(4):e002763. doi: 10.1161/CIRCHEARTFAILURE.115.002763.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "27056882", null, null, null));

			sb = new StringBuilder("Joseph J, Claggett BC, Anand IS, Fleg JL, Huynh T, Desai AS, Solomon SD, O’Meara E, Mckinlay S, Pitt B, Pfeffer MA, Lewis EF. ");
			sb.Append("QRS Duration Is a Predictor of Adverse Outcomes in Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("JACC Heart Fail. 2016 Jun;4(6):477-86. doi: 10.1016/j.jchf.2016.02.013. Epub 2016 Mar 30.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "27039126", null, null, null));

			sb = new StringBuilder("Lewis EF, Kim HY, Claggett B, Spertus J, Heitner JF, Assmann SF, Kenwood CT, Solomon SD, Desai AS, Fang JC, McKinlay SA, Pitt BA, Pfeffer MA; TOPCAT Investigators. ");
			sb.Append("Impact of Spironolactone on Longitudinal Changes in Health-Related Quality of Life in the Treatment of Preserved Cardiac Function Heart Failure With an Aldosterone Antagonist Trial. ");
			sb.Append("Circ Heart Fail. 2016 Mar;9(3):e001937. doi: 10.1161/CIRCHEARTFAILURE.114.001937.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "26962133", null, null, null));

			sb = new StringBuilder("Shah AM, Claggett B, Sweitzer NK, Shah SJ, Deswal A, Anand IS, Fleg JL, Pitt B, Pfeffer MA, Solomon SD. ");
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
				
			sb = new StringBuilder("Borlaug BA, Lewis GD, McNulty SE, Semigran MJ, LeWinter M, Chen H, Lin G, Deswal A, Margulies KB, Redfield MM. ");
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

            // countries
            
            // iec
	        
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
	        
	         /*
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000007069', mvalue => 'Ifosfamide');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'C000027061', mvalue => 'Isophosphamide mustard');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'C000037144', mvalue => 'Mifamurtide');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000000119', mvalue => 'Acetylmuramyl-Alanyl-Isoglutamine');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000012516', mvalue => 'Osteosarcoma');
 */
            // countries
            
            // iec
	        
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
		    
	        /*		    

call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000015032', mvalue => 'Zinc');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000007213', mvalue => 'Indomethacin');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000003520', mvalue => 'Cyclophosphamide');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000009853', mvalue => 'Omeprazole');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 12, mcode => 'D000054328', mvalue => 'Proton Pump Inhibitors');

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Squamous Cell Carcinoma of the Oral Cavity');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000002277', mvalue => 'Carcinoma');
call expected.insert_mesh_study_topic(sid => _sid, typeid => 13, mcode => 'D000002294', mvalue => 'Carcinoma, Squamous Cell');

			 */

            sb = new StringBuilder("Wolf GT, Liu S, Bellile E, Sartor M, Rozek L, Thomas D, Nguyen A, Zarins K, McHugh JB; ");
			sb.Append("INSPIRE Trial Clinical Investigators. Tumor infiltrating lymphocytes after neoadjuvant IRX-2 immunotherapy in oral squamous cell carcinoma: Interim findings from the INSPIRE trial. ");
			sb.Append("Oral Oncol. 2020 Jul 29;111:104928. doi: 10.1016/j.oraloncology.2020.104928. [Epub ahead of print]");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "32738599", null, null, null));

			fs.studylinks!.Add(new StudyLink(sd_sid, "INSPIRE Trial website", "http://InspireHNC.com"));
			fs.studylinks.Add(new StudyLink(sd_sid, "Sponsor’s website", "http://irxtherapeutics.com"));

	        // countries

	        // iec

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
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2020 Aug 12", 2020, 8, 12, null, null, null, null));

	        fs.data_objects!.Add(sdo);

	        return fs;
        }

        return null;
    }
}