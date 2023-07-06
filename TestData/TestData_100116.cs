using System.Text;

namespace MDR_Tester;

public class TestData_100116 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "ACTRN12616000771459")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Effect of a preload on postprandial glycaemic response and satiety.";
	        StringBuilder sb = new StringBuilder();
	        sb.Append("Interventions: This will be a randomised crossover study involving five visits on five days. On three days, participants will receive breakfast at 8am consisting of a ");
	        sb.Append("different preload on each day (water, kiwifruit, portion of rice-based meal) followed half an hour later by a rice-based meal. Blood will be sampled via cannula at intervals over ");
	        sb.Append("two-and-a-half-hours following consumption of the preload. On the other two days, participants will receive a standard breakfast at 8am after which participants will be permitted ");
	        sb.Append("to leave the facility and asked to return for lunch at 12pm. At lunchtime, the same protocol as described previously (one of two preloads, water and kiwifruit followed by a rice-");
	        sb.Append("based meal) will be used. On each test day, the amount of carbohydrate in the preload plus rice meal will be standardized. Subjective appetite ratings will be taken via questionnaire.\n\n");
	        sb.Append("The preloads will comprise 2 kiwifruit (24g available carbohydrate; 400kJ); apple segments (24g available carbohydrate; 380kJ); sugar (24g; 400kJ); or water.\n");
	        sb.Append("The meal following the preloads will comprise cooked white rice (250g containing 50g avail CHO; 840kJ) garnished with leafy green vegetables in soy sauce.\n");
	        sb.Append("On the days of lunch testing, a standard breakfast will be served comprising noodles (200g containing 40g avail CHO; 600kJ) in beef stock.\n");
	        sb.Append("The washout will be one week between treatments.\n");
	        sb.Append("All meals will be eaten under supervision to ensure the preloads and meals are fully consumed. The preload will be eaten within 10 minutes of starting. \n");
	        sb.Append("The test meals will be consumed within 15 minutes of starting.\n\n");
	        sb.Append("Primary outcome(s): Blood glucose response[Blood glucose concentrations will be measured at baseline (before eating) and at 15, 30, 45, 60, 75, 90, 120, and ");  
	        sb.Append("150 minutes thereafter];Satiety will be assessed using a visual analogue scale (reference Flint et al. Reproducibility, power and validity of visual analogue ");   
	        sb.Append("scales in assessment of appetite sensations in single test meal studies. Int J Obes 2000;24:38-48). [Satiety will be measured via a validated questionnaire at ");  
	        sb.Append("baseline (before eating) and at 15, 30, 45, 60, 75, 90, 120, and 150 minute thereafter];Circulating blood vitamin C concentration[The vitamin C concentration "); 
	        sb.Append("will be measured at baseline (before eating) and at 15, 30, 45, 60, 75, 90, 120, and 150 minutes thereafter]");
	        sb.Append("Study Design: Purpose: Prevention; Allocation: Randomised controlled trial; Masking: Open (masking not used);Assignment: Crossover");
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2016, 6, 11, 16, "40", 900,
		        18, 17, 75, 17, 7);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100116, 
		             "Australian New Zealand Clinical Trials Registry", null, "2016 Jun 14", null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
		                             "From the Australian New Zealand Clinical Trials Registry"));
	        fs.titles.Add(new StudyTitle(sd_sid, 
		        "The effect of consuming a carbohydrate preload 30 minutes before a starchy carbohydrate meal on postprandial glycaemic response and satiety in Asian adults.", 
		        16, "en", 11, false, "From the Australian New Zealand Clinical Trials Registry"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 102166, "University of Otago", "https://ror.org/01jmxt844"));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "High Value Nutrition", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "Zespri International", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 102166, "University of Otago", "https://ror.org/01jmxt844"));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 22, 205));  // Randomised
	        fs.features.Add(new StudyFeature(sd_sid, 23, 310));  // Crossover assignment
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));  // None (Open Label)
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Dysglycaemia", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Diet and Nutrition - Other diet and nutrition disorders", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Metabolic and Endocrine - Metabolic disorders", null, null, null, null));
	        
	        fs.countries!.Add(new StudyCountry(sd_sid, 2186224, "New Zealand", null));

	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1001, "none", "All", 0, "n.0A", "Healthy adults of Chinese ethnicity"));	       
	        string excrit =
		        "Inability to speak English; self-reported disease of the digestive system (coeliac, Crohn’s); ";
	        excrit += "having had gastrointestinal surgical procedures; an allergy to kiwifruit; and pregnancy.";
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1002, "seq", "All" , 0, "e.0A", excrit));
		        
	        // Data Objects
	        
	        // 1) Trial registry entry

	       string sd_oid = sd_sid + " :: 13 :: Australian / NZ registry web page";
	       string ob_title = display_title + " :: Australian / NZ registry web page";
	       StudyDataObject sdo = CreateEmptyStudyDataObject();
       
	       sdo.data_object = new DataObject(sd_oid, sd_sid, "Australian / NZ registry web page", null, ob_title,
		       null, 9, 2016, 23, 13, 100116, "Australian New Zealand Clinical Trials Registry",
		       null, "en", 12, null, null, 0, true, true);
	       sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	       
	       sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100116, "Australian New Zealand Clinical Trials Registry", 
		                     "https://anzctr.org.au/ACTRN12616000771459.aspx", true, 35, null, null, null));
	       sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2016 Jun 14", 2016, 6, 14, null, null, null, null));
	       sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2020 Jan 13", 2020, 1, 13, null, null, null, null));
	       
	       fs.data_objects!.Add(sdo);

	       return fs;

        }
        
        if (sd_sid == "ACTRN12620001103954")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "A Seamless Phase 1b Study to Evaluate Safety, Tolerability and Efficacy of SER-301 in Adult Subjects with Active Mild-to-Moderate Ulcerative Colitis (Part 2)";
	        StringBuilder sb = new StringBuilder();
	        sb.Append(
		        "Interventions: This is a seamless Phase 1b multicentre study to evaluate safety, tolerability, and efficacy of SER-301 in adult participants with active mild-to-moderate UC.\n\n");
	        sb.Append("SER-301 is a live microbiome therapeutic - a designed set of 18 live human-commensal bacterial strains representing different species administered as oral capsules. ");
	        sb.Append("SEach strain was purified from the stool of healthy donors and used to establish pure bacterial cell lines suitable for further good manufacturing practice use. ");
	        sb.Append("The strains were selected based on their pharmacological properties and safety profile, including genomic and microbiological characterisation of the strains.\n\n");
	        sb.Append("SER-301 drug product consists of 2 different capsule types each containing a different formulation containing a part of the total SER-301 composition. ");
	        sb.Append("Two capsules of each part are delivered in the complete dose for a total of 4 capsules once-daily, or 5.1 x 10^7 colony forming units (CFU).\n");
	        sb.Append("•SER-301 Part 1 is a liquid formulation of bacterial spores containing 10 strains delivered in 2 oral capsules. Part 1 contains 5.6 x 10^6 CFU.\n");
	        sb.Append("•SER-301 Part 2 is a dry powder formulation of vegetative bacteria containing 8 strains delivered in 2 oral capsules. Part 2 contains 4.5 x 10^7 CFU.\n\n");
	        sb.Append("This study has a seamless design, as it is composed of two study parts, with an operationally seamless transition in between. ");
	        sb.Append("Both study parts share objectives of safety, tolerability, and engraftment measures. Part 2 also has some additional ");
	        sb.Append("clinical and exploratory objectives. \n\n");
	        sb.Append("Participants will be enrolled into either Part 1 or Part 2 of the study, but not both. This record describes Part 2 only.\n\n");
	        sb.Append("Part 2 is randomised, double-blind, placebo-controlled. Approximately 50 participants will be randomised 2:3 to receive eithe");
	        sb.Append("Primary outcome(s): Part 2 (Placebo-Controlled)\n\n");
	        sb.Append("Primary Endpoint: Safety & tolerability of SER-301\n\n");
	        sb.Append("The evaluation of safety data will be performed by descriptively summarising various safety parameters for patients ");
	        sb.Append("treated with SER-301 and placebo. The following safety endpoints will be measured:\n");
	        sb.Append("• Incidence of AEs, SAEs and AESIs\n");
	        sb.Append("• Laboratory results \n");
	        sb.Append("\t- Haematology (Erythrocytes, Hemoglobin, Hematocrit, MCV, MCH, MCHC, Leukocytes, Neutrophils (%, abs.), Lymphocytes (%, abs.), Monocytes (%, abs.), Eosinophils (%, abs.), Basophils (%, abs.), Platelets)\n");
	        sb.Append("\t- Blood Chemistry (Sodium, Potassium, Albumin, Glucose(random), Triglycerides, Total Cholesterol, Creatinine, Uric Acid, Blood urea nitrogen, AST, ALT, Alkaline phosphatase, GGT, Bilirubin (total, direct, indirect), CRP)\n");
	        sb.Append("\t- Urinalysis (pH, Specific gravity, Blood, Protein, Glucose, Leukocytes, Bilirubin, Ketones, Urobilinogen, Nitrites, RBC, WBC, Bacteria, Casts, Crystals, Yeasts, Epithelial Cells)\n");
	        sb.Append("• Vital sign measurements\n");
	        sb.Append("Physical examination findings[After the pre-conditioning period (Week 1), after 10 weeks of induction treatment (Week 11), and 4 weeks after the last treatment dose (Week 15).]\n");
	        sb.Append("Study Design: Purpose: Treatment; Allocation: Randomised controlled trial");
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2021, 126, 11, 14, "50", 900,
		        18, 17, 65, 17, 10);
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
		        "From the Australian New Zealand Clinical Trials Registry"));
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100116, 
		        "Australian New Zealand Clinical Trials Registry", null, "2020 Oct 23", null));
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "SER-301-001", 14, null, 
		        "PSI CRO Australia Pty Ltd", null, null, null));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "PSI CRO Australia Pty Ltd", null));
	        fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "Seres Therapeutics, Inc", null));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 110));  // Phase 1
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));  // Treatment
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));  //  Randomised
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Ulcerative Colitis", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "Oral and Gastrointestinal - Other diseases of the mouth, teeth, oesophagus, digestive system including liver and colon", null, null, null, null));
	        
	        fs.countries!.Add(new StudyCountry(sd_sid, 2077456, "Australia", null));
	        fs.countries.Add(new StudyCountry(sd_sid, 2186224, "New Zealand", null));

	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Documented diagnosis of UC prior to screening endoscopy"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Active mild-to-moderate UC as determined by a 3-Component Modified Mayo Score"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Minimum disease extent of 15 cm from the anal verge, confirmed at the screening endoscopy"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Naïve to UC treatment or with an inadequate response to, loss of response to, or intolerance of, at least one of the following conventional therapies: 5-ASA compounds, corticosteroids or immunomodulators (e.g., 6-MP, AZA, methotrexate)"));
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr assumed", "@", 1, "e.01", "Known history of Crohn’s disease"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr assumed", "@", 1, "e.02", "On steroid medication who are unable to have steroids tapered, and be completely off steroids at least 2 weeks prior to screening"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr assumed", "@", 1, "e.03", "Unable to stop steroid enemas or suppositories, or 5-ASA enemas or suppositories, at least 2 weeks prior to screening"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.04", "Previously received any investigational or approved biologic therapy"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.05", "Previously received any investigational or approved non-biologic therapy, except for those specifically listed in the Permitted Concomitant Medications (e.g., stable dose of 6-MP, AZA, methotrexate)"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr assumed", "@", 1, "e.06", "Major gastrointestinal surgery (not including appendectomy or cholecystectomy) within 2 months prior to screening"));	 
		        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: Australian / NZ registry web page";
	        string ob_title = display_title + " :: Australian / NZ registry web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
       
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Australian / NZ registry web page", null, ob_title,
		        null, 9, 2020, 23, 13, 100116, "Australian New Zealand Clinical Trials Registry",
		        null, "en", 12, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	       
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100116, "Australian New Zealand Clinical Trials Registry", 
		        "https://anzctr.org.au/ACTRN12620001103954.aspx", true, 35, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, "2020 Oct 23", 2020, 10, 23));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, "2022 Aug 9", 2022, 8, 9));
	       
	        fs.data_objects!.Add(sdo);

	        return fs;
        }

        return null;
    }
}