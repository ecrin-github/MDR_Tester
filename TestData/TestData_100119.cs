using System.Text;

namespace MDR_Tester;

public class TestData_100119 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "KCT0003700")
        {
            FullStudy fs = CreateEmptyFullStudy();

            // Study

            string display_title = "Safety and efficacy evaluation of Selumetinib in Neurofibromatosis type 1";
            StringBuilder sb = new StringBuilder("Interventions: Drug : The dose of selumetinib administered will be the maximum tolerated dose (20-25 mg/m2/dose q 12 ");
            sb.Append("hrs for patients with age = 3 years and =18 years and 50 mg/dose or 25 mg/m2/dose q 12 hrs for patients with age > 18 years). ");
            sb.Append("The total duration of treatment will be 2 years of 26 cycles. A cycle of therapy is considered to be 28 days with no rest periods in between cycles");
            sb.Append("\nPrimary outcome(s): To evaluate the safety of selumetinib in Korean patients with NF1 and PN and pharmacokinetic analysis");
            sb.Append("\nPrimary Purpose : Treatment, Intervention Model : Single Group, Blinding/Masking : Open, Allocation : Non-RCT");
            string brief_desc = sb.ToString();

            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2019, 5, 11, 14, "90", 900,
                3, 17, null, null, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100119,
                "Clinical Research Information Service", null, "1 Apr 2019", null));

            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true,
                "From the Clinical Research Information Service (South Korea)"));
            fs.titles.Add(new StudyTitle(sd_sid,
                "Safety and efficacy of Selumetinib in Korean patients with neurofibromatosis type 1 and plexiform neurofibromas",
                16, "en", 11, false, "From the Clinical Research Information Service (South Korea)"));
            
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Beom Hee Lee", "Asan Medical Center", 100300,
                "Asan Medical Center", "https://ror.org/03s5q0090"));
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54,  100300, "Asan Medical Center", "https://ror.org/03s5q0090"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 100166, "AstraZeneca", "https://ror.org/04r9x1a08"));
            
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 301, "cr", "Hdr", 0, "n.00", "For inclusion in the study subjects should fulfil the following criteria based on local regulations:"));
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "1.", 1, "n.01", "Patients with Neurofibromatosis type I, in whom genetic study was performed for the germline NF1 mutations, and have significant symptoms/comorbidities as well as those with the potential to develop symptoms/comorbidities due to inoperable measurable plexiform neurofibroma (Surgeon’s statement of inoperability should be documented)."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "2.", 1, "n.02", "Patients must have at least one measurable plexiform neurofibroma, defined as a lesion of at least 3 cm measured in one dimension."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr", "3.", 1, "n.03", "Patients with an absolute neutrophil count =1000/µL, hemoglobin = 9 g/dL, and platelet = 100,000/µL."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr", "4.", 1, "n.04", "Patients must have bilirubin within 1.5 x the upper limit of normal for age, with the exception of Gilbert syndrome, and Alanie aminotranferaase and aspartate aminotranferase within = 1.5 x upper limit of normal."));
            fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr", "5.", 1, "n.05", "Renal Function: age-adjusted normal serum creatinine."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr", "6.", 1, "n.06", "Cardiac function: Normal ejection fraction; echocardiogram = 55% (if a range is given then the upper value of the range will be used)."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr", "7.", 1, "n.07", "Performance status: Patients = 16 years of age must have a Karnofsky performance level of =70%, and children < 16 years old must have a Lansky performance of =70%"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "cr", "8.", 1, "n.08", "Diagnostic or laboratory studies performed exclusively to determine eligibility for this trial must only be done after obtaining written informed consent from all patients or their legal guardians (if the patient is <19 years old). When appropriate, pediatric patients will be included in all discussions."));
            
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "1.", 1, "e.01", "Any prior exposure to MEK, RASs, or RAF inhibitors, or any treatment regimen that involves the comparator / combination medications."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "2.", 1, "e.02", "Known severe hypersensitivity to selumetinib, comparator or combination medications or any excipient of these medicinal products or history of allergic reactions attributed to compounds of similar chemical or biologic composition to selumetinib or comparator"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr", "3.", 1, "e.03", "Have received or are receiving an investigational medicinal product (IMP) or other systemic anticancer treatment within 4 weeks."));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr", "4.", 1, "e.04", "Have had recent major surgery within a minimum 4 weeks prior to starting study treatment, with the exception of surgical placement for vascular access."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr", "5.", 1, "e.05", "The last radiation therapy within 4 weeks prior to starting study treatment, or limited field of radiation for palliation within 7 days of the first dose of study treatment."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr", "6.", 1, "e.06", "Evidence of a malignant glioma, malignant peripheral nerve sheath tumor, or other cancer requiring treatment with chemotherapy or radiation therapy."));	 
            fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr", "7.", 1, "e.07", "Any unresolved toxicity = CTCAE (Common Terminology Criteria for Adverse Events) Grade 2 from previous anti-cancer therapy, except for alopecia"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr", "8.", 1, "e.08", "Cardiac conditions as follows:"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "cr", "a.", 2, "e.08.01", "Uncontrolled hypertension (BP = 150/95 mmHg despite medical therapy)"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "cr", "b.", 2, "e.08.02", "Acute coronary syndrome within 6 months prior to starting treatment"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "cr", "c.", 2, "e.08.03", "Uncontrolled Angina - Canadian Cardiovascular Society grade II-IV despite medical therapy"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "cr", "d.", 2, "e.08.04", "Symptomatic heart failure NYHA Class II-IV, prior or current cardiomyopathy, or severe valvular heart disease"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "cr", "e.", 2, "e.08.05", "Prior or current cardiomyopathy including but not limited to the following:"));
            fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr", "i.", 3, "e.08.05.01", "Known hypertrophic cardiomyopathy"));
            fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr", "ii.", 3, "e.08.05.02", "Known arrhythmogenic right ventricular cardiomyopathy"));
            fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr", "f.", 2, "e.08.06", "Previous moderate or severe impairment of left ventricular systolic function (Left ventricular ejection fraction <45% on echocardiography or equivalent on multiple gated acquisition scan) even if full recovery has occurred."));	 
            fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr", "g.", 2, "e.08.07", "Severe valvular heart disease"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "cr", "h.", 2, "e.08.08", "Baseline Left ventricular ejection fraction below the lower limit of normal or <55% measured by echocardiography or institution’s lower limit of normal for multiple gated acquisition scan"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "cr", "i.", 2, "e.08.09", "Atrial fibrillation with a ventricular rate >100 bpm on electrocardiogram at rest"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "cr", "j.", 2, "e.08.10", "QTcF >450ms or other factors that increase the risk of QT prolongation"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 30, 2, "cr", "9.", 1, "e.09", "Laboratory values as listed below (SI units):"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 31, 2, "cr", "a.", 2, "e.09.01", "Absolute Neutrophil Count <1.5x1000,000,000/L (1500 per mm3)"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 32, 2, "cr", "b.", 2, "e.09.02", "Platelets <100x1000,000,000/L (100,000 per mm3)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 33, 2, "cr", "c.", 2, "e.09.03", "Hemoglobin =9.0 g/dL"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 34, 2, "cr", "d.", 2, "e.09.04", "Serum creatinine =1.5 X upper limit of normal (ULN)"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 35, 2, "cr", "e.", 2, "e.09.05", "Serum bilirubin >1.5 x ULN (Note that this will not apply to patients with confirmed Gilbert’s syndrome (persistent or recurrent hyperbilirubinemia that is predominantly unconjugated in the absence of evidence of hemolysis or hepatic pathology), who may be allowed included in specific studies, at the discretion of the doctor / physician responsible for the treatment.)"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 36, 2, "cr", "f.", 2, "e.09.06", "Alanine aminotransferase or Aspartate aminotransferase > 2.5 x Upper limit of normal for patients with no liver metastasis."));	 
            fs.iec.Add(new StudyIEC(sd_sid, 37, 2, "cr", "g.", 2, "e.09.07", "Alanine aminotransferase or Aspartate aminotransferase > 5 x Upper limit of normal for patients with liver metastasis."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 38, 2, "cr", "h.", 2, "e.09.08", "Alanine aminotransferase or Aspartate aminotransferase > 3.5 x Upper limit of normal and < 5 x Upper limit of normal for patients with liver metastasis and Alakaline phosphatase > 6 x Upper limit of normal"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 39, 2, "cr", "10.", 1, "e.10", "Ophthalmological conditions a"));	 
            
            fs.features!.Add(new StudyFeature(sd_sid, 20, 115)); // Phase 1/Phase 2
            fs.features.Add(new StudyFeature(sd_sid, 21, 400)); // Treatment
            fs.features.Add(new StudyFeature(sd_sid, 22, 210)); // Nonrandomised
            fs.features.Add(new StudyFeature(sd_sid, 24, 500)); // None (Open Label)

            fs.conditions!.Add(new StudyCondition(sd_sid, "Neoplasms", null, null, "2", "Neoplasms"));

            fs.countries!.Add(new StudyCountry(sd_sid, 1835841, "South Korea", null));

            // Data Objects

            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: South Korean registry web page";
            string ob_title = display_title + " :: South Korean registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();

            sdo.data_object = new DataObject(sd_oid, sd_sid, "South Korean registry web page", null, ob_title,
                null, 9, 2019, 23, 13, 100119, "Clinical Research Information Service",
                null, "en", 12, null, null, 0, true, true);
           
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100119,
                "Clinical Research Information Service",
                "http://cris.nih.go.kr/cris/en/search/search_result_st01.jsp?seq=19080", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "1 Apr 2019", 2019, 4, 1, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "22 Mar 2021", 2021, 3, 22, null, null, null, null));

            fs.data_objects!.Add(sdo);

            return fs;

        }

        if (sd_sid == "KCT0007824")
        {
            FullStudy fs = CreateEmptyFullStudy();

            // Study

            string display_title =
                "A Randomized, Double-Blind, Placebo-Controlled, Parallel, Phase 2a Clinical Trial to Evaluate the Safety and Efficacy of WK0202 Capsule to Prevent Cancer-Related Fatigue on Cytotoxic Chemotherapy";
            StringBuilder sb =
                new StringBuilder("Interventions: Drug : A combination of WK0202 capsules and XELOX or FOLFOX (mFOLFOX6) is administered.\n");
            sb.Append("Administration cycle: WK0202 capsules are orally administered once a day at a certain period of time (a.m. empty stomach), and each ");
            sb.Append("chemotherapy is administered according its administration.\nAdministration plan: WK0202 capsules are administered for 12 weeks, ");
            sb.Append("XELOX up to 8 cycles (3 weeks/cycle), FOLFOX (mFOLFOX6) can be administered for up to 12 cycles (2 weeks/cycle).\n");
            sb.Append("Treatment group:\nExperimental 1 - WK0202 capsule 200mg (2 tablets of WK0202 capsule 100mg) + 1 tablet of placebo 100mg\n");
            sb.Append("Experimental 2 - WK0202 Capsule 300 mg (WK0202 Capsule 100 mg 3 tablets)\nControl - 300 mg of placebo (three tablets of placebo 100 mg");
            sb.Append("\nPrimary outcome(s): Safety evaluation and laboratory testing");
            sb.Append("\nPrimary Purpose : Supportive Care, Intervention Model : Parallel, Blinding/Masking : , Blinding Target : Subject, Investigator, Allocation : RCT");
            string brief_desc = sb.ToString();

            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2022, 10, 11, 16, "70", 900,
                19, 17, null, null, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100119,
                "Clinical Research Information Service", null, "19 Oct 2022", null));

            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true,
                "From the Clinical Research Information Service (South Korea)"));
            
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Myung-Ah Lee", 
                "Catholic University of Korea, Seoul St Mary’s Hospital", 100598,
                "Catholic University of Korea", "https://ror.org/01fpnj063"));
            fs.people.Add(new StudyPerson(sd_sid, 56, "Hye jeong Kim", 
                "Catholic University of Korea, Seoul St Mary’s Hospital", 100598,
                "Catholic University of Korea", "https://ror.org/01fpnj063"));
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54,  102134,
                "Seoul St Mary’s Hospital", "https://ror.org/056cn0e37"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "Nadianbio", null));
            
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "1)", 1, "n.01", "A person who voluntarily agrees to participate in this clinical trial"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "2)", 1, "n.02", "An adult man or woman over the age of 19"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "3)", 1, "n.03", "A person diagnosed with colorectal cancer by pathology (histology or cytolo gy)"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr", "4)", 1, "n.04", "Patients requiring treatment with XELOX or FOLFOX (mFOLFOX6) therapy"));
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr", "5)", 1, "n.05", "Those who have an average BFI score of less than 4 points during a screenin g visit (except when one of all BFI items has a score of 7 or higher"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr", "6)", 1, "n.06", "Those who fall under Eastern Cooperative Oncology Group (ECOG) =1"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr", "7)", 1, "n.07", "Person who is able to be measured by Inbody during screening visit"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr", "8)", 1, "n.08", "If the person is female participant or female partner of male participant who has not undergone infertility surgery if she is fertile, those who agrees to follo wing contraception in the period of clinical trial and after the end of the clinica l trial at least 4 months for men and for at least 6 months women"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 9, 1, "cr", "(1)", 2, "n.08.01", "For both female participant or female partner of male participant: Use of int rauterine device/tubal ligation and infertility surgery/condom or diaphragm and spermicide or combination use of birth control pill"));
            fs.iec.Add(new StudyIEC(sd_sid, 10, 1, "cr", "(2)", 2, "n.08.02", "For male participant(not applicable for male partner of female participant):"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 11, 301, "cr", "Hdr", 2, "n.08.03", "use of condom"));	
            fs.iec.Add(new StudyIEC(sd_sid, 12, 1, "cr", "(3)", 2, "n.08.04", "Absolute abstinence (Intermittent abstinence (e.g., during ovulation, sympt othermal method, or post ovulation) or coitus interruptus are not agreeing to a bstinence)"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 13, 1, "cr", "9)", 1, "n.09", "During a screening visit, laboratory test meets the follow criteria:"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 14, 1, "cr", "(1)", 2, "n.09.01", "ANC = 1,500/mm³"));
            fs.iec.Add(new StudyIEC(sd_sid, 15, 1, "cr", "(2)", 2, "n.09.02", "Platelet count =100,000/mm³"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 16, 1, "cr", "(3)", 2, "n.09.03", "Hemoglobin = 9.0 g/dL (if hemoglobin level is less than 9.0 g/dl, recover to 9.0 g/dL or higher; In such cases, participant may be registered at the discretion of the investigator. However, blood transfusions within 7 days are not allowed based on the screening time to satisfy this standard.)"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 17, 1, "cr", "(4)", 2, "n.09.04", "Patients with TSH in normal range (however, participant that was administe red thyroid hormone without changing the usage and dose for at least 4 weeks prior to screening may be registered at the discretion of the investigator)"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 18, 1, "cr", "(5)", 2, "n.09.05", "Creatine clearance = 60mL/min or eGFR = 60mL/min/1.73?"));	 
            
            fs.iec.Add(new StudyIEC(sd_sid, 19, 302, "cr", "Hdr", 0, "e.00", "[Current disease and medical history]"));	      
            fs.iec.Add(new StudyIEC(sd_sid, 20, 2, "cr", "1)", 1, "e.01", "A person who is scheduled to undergo radiotherapy during the clinical trial p eriod"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 21, 2, "cr", "2)", 1, "e.02", "A person who is unable to orally administer drugs or may affect the absorpti on of drugs for clinical trials"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 22, 2, "cr", "3)", 1, "e.03", "Patients with the following cardiovascular diseases during screening visits"));
            fs.iec.Add(new StudyIEC(sd_sid, 23, 2, "cr", "(1)", 2, "e.03.01", "Myocardial infarction or unstable angina within 6 months prior to screening visit"));
            fs.iec.Add(new StudyIEC(sd_sid, 24, 2, "cr", "(2)", 2, "e.03.02", "Congestion heart failure above class III according to the New York Heart Ass ociation (NYHA) classification"));
            fs.iec.Add(new StudyIEC(sd_sid, 25, 2, "cr", "(3)", 2, "e.03.03", "QTc interval = 450 msec or clinically significant ECG changes"));
            fs.iec.Add(new StudyIEC(sd_sid, 26, 2, "cr", "4)", 1, "e.04", "A person who has undergone major surgery requiring general anesthesia wit hin 3 weeks prior to the screening visit"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 27, 2, "cr", "5)", 1, "e.05", "an HIV-positive patient"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 28, 2, "cr", "6)", 1, "e.06", "Patients with positive active hepatitis (HBV, HCV) test results"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 29, 2, "cr", "7)", 1, "e.07", "Patients with acute or severe infections"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 30, 2, "cr", "8)", 1, "e.08", "Patients who have experienced severe adverse reactions to drugs containing components of the same family as clinical trial drugs or have a history of allergi es"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 31, 2, "cr", "9)", 1, "e.09", "A person who lost more than 5% of weight within 6 months prior to the scr eening or has a Body Mass Index (BMI) of less than 20 kg/m² within 6 months prior to the screening visit and has a weight loss of more than 2% [Prohibited drugs]"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 32, 2, "cr", "10)", 1, "e.10", "A person who has taken the following drugs within 4 weeks prior to the screening visit:"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 33, 2, "cr", "(1)", 2, "e.10.01", "Stimulants (Methylphenidate, Modafinil, etc.)"));
            fs.iec.Add(new StudyIEC(sd_sid, 34, 2, "cr", "(2)", 2, "e.10.02", "Antidepressants (such as Bupropion)"));
            fs.iec.Add(new StudyIEC(sd_sid, 35, 2, "cr", "(3)", 2, "e.10.03", "Herbal medicine or health functional food for fatigue control (such as red gi nseng)"));
            fs.iec.Add(new StudyIEC(sd_sid, 36, 2, "cr", "(4)", 2, "e.10.04", "another clinical trial drug [Others]"));
            fs.iec.Add(new StudyIEC(sd_sid, 37, 2, "cr", "11)", 1, "e.11", "A person with a life expectancy of 6 months or less"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 38, 2, "cr", "12)", 1, "e.12", "Pregnant or lactating women"));	 
            fs.iec.Add(new StudyIEC(sd_sid, 39, 2, "cr", "13)", 1, "e.13", "A person who participated in another clinical trial within 6 months prior to the screening visit"));	  
            fs.iec.Add(new StudyIEC(sd_sid, 40, 2, "cr", "14)", 1, "e.14", "Any other person who was determined by the investigator that is unsuitabl e for this clinical trial due to clinically significant medical or psychiatric findings"));	

            fs.features!.Add(new StudyFeature(sd_sid, 20, 120)); // Phase 2
            fs.features.Add(new StudyFeature(sd_sid, 21, 415)); // Supportive care
            fs.features.Add(new StudyFeature(sd_sid, 22, 205)); // Randomised
            fs.features.Add(new StudyFeature(sd_sid, 23, 305)); // Parallel assignment

            fs.conditions!.Add(new StudyCondition(sd_sid, "Neoplasms", null, null, "2", "Neoplasms"));

            fs.countries!.Add(new StudyCountry(sd_sid, 1835841, "South Korea", null));

            // Data Objects

            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: South Korean registry web page";
            string ob_title = display_title + " :: South Korean registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();

            sdo.data_object = new DataObject(sd_oid, sd_sid, "South Korean registry web page", null, ob_title,
                null, 9, 2022, 23, 13, 100119, "Clinical Research Information Service",
                null, "en", 12, null, null, 0, true, true);
            
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100119,
                "Clinical Research Information Service",
                "https://cris.nih.go.kr/cris/search/detailSearchEn.do?seq=23046", true, 35, null, null, null));
            sdo.object_dates!.Add(
                new ObjectDate(sd_oid, 15, false, "19 Oct 2022", 2022, 10, 19, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "28 Nov 2022", 2022, 11, 28, null, null, null,
                null));

            fs.data_objects!.Add(sdo);

            return fs;

        }

        return null;
    }
}