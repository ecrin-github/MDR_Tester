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
            StringBuilder sb =
                new StringBuilder(
                    "Interventions: Drug : The dose of selumetinib administered will be the maximum tolerated dose (20-25 mg/m2/dose q 12 ");
            sb.Append(
                "hrs for patients with age = 3 years and =18 years and 50 mg/dose or 25 mg/m2/dose q 12 hrs for patients with age &gt; 18 years). ");
            sb.Append(
                "The total duration of treatment will be 2 years of 26 cycles. A cycle of therapy is considered to be 28 days with no rest periods in between cycles");
            sb.Append(
                "Primary outcome(s): To evaluate the safety of selumetinib in Korean patients with NF1 and PN and pharmacokinetic analysis");
            sb.Append(
                "Study Design: Primary Purpose : Treatment, Intervention Model : Single Group, Blinding/Masking : Open, Allocation : Non-RCT");
            string brief_desc = sb.ToString();

            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2019, 5, 11, 14, "90", 900,
                3, 17, null, null, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100119,
                "Clinical Research Information Service (South Korea)", null, "2019 Apr 1", null));

            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true,
                "From the South Korean Clinical Trials Registry"));
            fs.titles.Add(new StudyTitle(sd_sid,
                "Safety and efficacy of Selumetinib in Korean patients with neurofibromatosis type 1 and plexiform neurofibromas",
                16, "en", 11, false, "From the South Korean Clinical Trials Registry"));
            
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Beom Hee", "Lee", "Beom Hee Lee", null,
                "Asan Medical Center", 100300,
                "Asan Medical Center", "https://ror.org/03s5q0090"));
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54,  100300, "Asan Medical Center", 
                "https://ror.org/03s5q0090"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "AstraZeneca Korea", null));

/*
  "inclusion_criteria": 
  "For inclusion in the study subjects should fulfil the following criteria based on local regulations:
  \n1. Patients with Neurofibromatosis type I, in whom genetic study was performed for the germline NF1 mutations, and have significant symptoms/comorbidities as well as those with the potential to develop symptoms/comorbidities due to inoperable measurable plexiform neurofibroma (Surgeon’s statement of inoperability should be documented).
  \n2. Patients must have at least one measurable plexiform neurofibroma, defined as a lesion of at least 3 cm measured in one dimension.
  \n3. Patients with an absolute neutrophil count =1000/µL, hemoglobin = 9 g/dL, and platelet = 100,000/µL.
  \n4. Patients must have bilirubin within 1.5 x the upper limit of normal for age, with the exception of Gilbert syndrome, and Alanie aminotranferaase and aspartate aminotranferase within = 1.5 x upper limit of normal.
  \n5. Renal Function: age-adjusted normal serum creatinine. 
  \n6. Cardiac function: Normal ejection fraction; echocardiogram = 55% (if a range is given then the upper value of the range will be used).
  \n7. Performance status: Patients = 16 years of age must have a Karnofsky performance level of =70%, and children &lt; 16 years old must have a Lansky performance of =70%
  \n8. Diagnostic or laboratory studies performed exclusively to determine eligibility for this trial must only be done after obtaining written informed consent from all patients or their legal guardians (if the patient is &lt;19 years old). When appropriate, pediatric patients will be included in all discussions.",
  "exclusion_criteria": 
  "1.Any prior exposure to MEK, RASs, or RAF inhibitors, or any treatment regimen that involves the comparator / combination medications. 
  \n2.Known severe hypersensitivity to selumetinib, comparator or combination medications or any excipient of these medicinal products or history of allergic reactions attributed to compounds of similar chemical or biologic composition to selumetinib or comparator
  \n3.Have received or are receiving an investigational medicinal product (IMP) or other systemic anticancer treatment within 4 weeks. 
  \n4.Have had recent major surgery within a minimum 4 weeks prior to starting study treatment, with the exception of surgical placement for vascular access. 
  \n5.The last radiation therapy within 4 weeks prior to starting study treatment, or limited field of radiation for palliation within 7 days of the first dose of study treatment.
  \n6.Evidence of a malignant glioma, malignant peripheral nerve sheath tumor, or other cancer requiring treatment with chemotherapy or radiation therapy.
  \n7.Any unresolved toxicity = CTCAE (Common Terminology Criteria for Adverse Events) Grade 2 from previous anti-cancer therapy, except for alopecia
  \n8.Cardiac conditions as follows:
  \na.Uncontrolled hypertension (BP = 150/95 mmHg despite medical therapy)
  \nb.Acute coronary syndrome within 6 months prior to starting treatment
  \nc.Uncontrolled Angina - Canadian Cardiovascular Society grade II-IV despite medical therapy 
  \nd.Symptomatic heart failure NYHA Class II-IV, prior or current cardiomyopathy, or severe valvular heart disease 
  \ne.Prior or current cardiomyopathy including but not limited to the following:\ni.Known hypertrophic cardiomyopathy\nii.Known arrhythmogenic right ventricular cardiomyopathy
  \nf.Previous moderate or severe impairment of left ventricular systolic function (Left ventricular ejection fraction &lt;45% on echocardiography or equivalent on multiple gated acquisition scan) even if full recovery has occurred.
  \ng.Severe valvular heart disease
  \nh.Baseline Left ventricular ejection fraction below the lower limit of normal or &lt;55% measured by echocardiography or institution’s lower limit of normal for multiple gated acquisition scan
  \ni.Atrial fibrillation with a ventricular rate &gt;100 bpm on electrocardiogram  at rest 
  \nj.QTcF &gt;450ms or other factors that increase the risk of QT prolongation\n9.Laboratory values as listed below (SI units):
  \na.Absolute Neutrophil Count  &lt;1.5x1000,000,000/L (1500 per mm3)
  \nb.Platelets &lt;100x1000,000,000/L (100,000 per mm3)
  \nc.Hemoglobin  =9.0 g/dL
  \nd.Serum creatinine =1.5 X upper limit of normal (ULN)
  \ne.Serum bilirubin &gt;1.5 x ULN (Note that this will not apply to patients with confirmed Gilbert’s syndrome (persistent or recurrent hyperbilirubinemia that is predominantly unconjugated in the absence of evidence of hemolysis or hepatic pathology), who may be allowed included in specific studies, at the discretion of the doctor / physician responsible for the treatment.)
  \nf.Alanine aminotransferase or Aspartate aminotransferase &gt; 2.5 x Upper limit of normal for patients with no liver metastasis. 
  \ng.Alanine aminotransferase or Aspartate aminotransferase &gt; 5 x Upper limit of normal for patients with liver metastasis.
  \nh.Alanine aminotransferase or Aspartate aminotransferase &gt; 3.5 x Upper limit of normal and &lt; 5 x Upper limit of normal for patients with liver metastasis and Alakaline phosphatase &gt; 6 x Upper limit of normal 
  \n10.Ophthalmological conditions a",


 
 */
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
                null, 9, 2019, 23, 13, 100119, "Clinical Research Information Service (South Korea)",
                null, "en", 12, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));

            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100119,
                "Clinical Research Information Service (South Korea)",
                "http://cris.nih.go.kr/cris/en/search/search_result_st01.jsp?seq=19080", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2019 Apr 1", 2019, 4, 1, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 Mar 22", 2021, 3, 22, null, null, null, null));

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
                new StringBuilder(
                    "Interventions: Drug : A combination of WK0202 capsules and XELOX or FOLFOX (mFOLFOX6) is administered.\n");
            sb.Append(
                "Administration cycle: WK0202 capsules are orally administered once a day at a certain period of time (a.m. empty stomach), and each ");
            sb.Append(
                "chemotherapy is administered according its administration.<br>Administration plan: WK0202 capsules are administered for 12 weeks, ");
            sb.Append(
                "XELOX up to 8 cycles (3 weeks/cycle), FOLFOX (mFOLFOX6) can be administered for up to 12 cycles (2 weeks/cycle).\n\n");
            sb.Append(
                "Treatment group:<br>Experimental 1 - WK0202 capsule 200mg (2 tablets of WK0202 capsule 100mg) + 1 tablet of placebo 100mg\n");
            sb.Append(
                "Experimental 2 - WK0202 Capsule 300 mg (WK0202 Capsule 100 mg 3 tablets)<br>Control - 300 mg of placebo (three tablets of placebo 100 mg");
            sb.Append("Primary outcome(s): Safety evaluation and laboratory testing");
            sb.Append(
                "Study Design: Primary Purpose : Supportive Care, Intervention Model : Parallel, Blinding/Masking : , Blinding Target : Subject, Investigator, Allocation : RCT");
            string brief_desc = sb.ToString();

            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2022, 10, 11, 16, "70", 900,
                19, 17, null, null, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100119,
                "Clinical Research Information Service (South Korea)", null, "2018 Sep 20", null));

            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true,
                "From the South Korean Clinical Trials Registry"));
            
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Myung-Ah", "Lee", "Beom Hee Lee", null,
                "The Catholic University of Korea, Seoul St. Mary's Hospital", 100598,
                "Catholic University of Korea", "https://ror.org/01fpnj063"));
            fs.people.Add(new StudyPerson(sd_sid, 56, "Hye jeong", "Kim", "Beom Hee Lee", null,
                "The Catholic University of Korea, Seoul St. Mary's Hospital", 100598,
                "Catholic University of Korea", "https://ror.org/01fpnj063"));
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54,  100598,
                "Catholic University of Korea", "https://ror.org/01fpnj063"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "Nadianbio", null));

/*
 *
  
  "inclusion_criteria": 
  "1) A person who voluntarily agrees to participate in this clinical trial
  \n2) An adult man or woman over the age of 19
  \n3) A person diagnosed with colorectal cancer by pathology (histology or cytology)
  \n4) Patients requiring treatment with XELOX or FOLFOX (mFOLFOX6) therapy
  \n5) Those who have an average BFI score of less than 4 points during a screening visit (except when one of all BFI items has a score of 7 or higher
  \n6) Those who fall under Eastern Cooperative Oncology Group (ECOG) =1
  \n7) Person who is able to be measured by Inbody during screening visit
  \n8) If the person is female participant or female partner of male participant whohas not undergone infertility surgery if she is fertile, those who agrees to following contraception in the period of clinical trial and after the end of the clinical trial at least 4 months for men and for at least 6 months women
  \n(1) For both female participant or female partner of male participant: Use of intrauterine device/tubal ligation and infertility surgery/condom or diaphragm andspermicide or combination use of birth control pill
  \n(2) For male participant(not applicable for male partner of female participant):use of condom
  \n(3) Absolute abstinence (Intermittent abstinence (e.g., during ovulation, symptothermal method, or post ovulation) or coitus interruptus are not agreeing to abstinence)
  \n9) During a screening visit, laboratory test meets the follow criteria:
  \n(1) ANC = 1,500/mm³
  \n(2) Platelet count =100,000/mm³
  \n(3) Hemoglobin = 9.0 g/dL (if hemoglobin level is less than 9.0 g/dl, recover to\n9.0 g/dL or higher; In such cases, participant may be registered at the discretionof the investigator. However, blood transfusions within 7 days are not allowed\nbased on the screening time to satisfy this standard.)
  \n(4) Patients with TSH in normal range (however, participant that was administered thyroid hormone without changing the usage and dose for at least 4 weeksprior to screening may be registered at the discretion of the investigator)
  \n(5) Creatine clearance = 60mL/min or eGFR = 60mL/min/1.73?",
  "exclusion_criteria": 
  "[Current disease and medical history]
  \n1) A person who is scheduled to undergo radiotherapy during the clinical trial period
  \n2) A person who is unable to orally administer drugs or may affect the absorption of drugs for clinical trials
  \n3) Patients with the following cardiovascular diseases during screening visits
  \n(1) Myocardial infarction or unstable angina within 6 months prior to screeningvisit
  \n(2) Congestion heart failure above class III according to the New York Heart Association (NYHA) classification
  \n(3) QTc interval = 450 msec or clinically significant ECG changes
  \n4) A person who has undergone major surgery requiring general anesthesia wit\nhin 3 weeks prior to the screening visit
  \n5) an HIV-positive patient
  \n6) Patients with positive active hepatitis (HBV, HCV) test results
  \n7) Patients with acute or severe infections
  \n8) Patients who have experienced severe adverse reactions to drugs containingcomponents of the same family as clinical trial drugs or have a history of allergies
  \n9) A person who lost more than 5% of weight within 6 months prior to the screening or has a Body Mass Index (BMI) of less than 20 kg/m² within 6 months\nprior to the screening visit and has a weight loss of more than 2%
  \n[Prohibited drugs]
  \n10) A person who has taken the following drugs within 4 weeks prior to the screening visit:
  \n(1) Stimulants (Methylphenidate, Modafinil, etc.)
  \n(2) Antidepressants (such as Bupropion)
  \n(3) Herbal medicine or health functional food for fatigue control (such as red ginseng)
  \n(4) another clinical trial drug
  \n[Others]
  \n11) A person with a life expectancy of 6 months or less\n12) Pregnant or lactating women
  \n13) A person who participated in another clinical trial within 6 months prior to\nthe screening visit
  \n14) Any other person who was determined by the investigator that is unsuitable for this clinical trial due to clinically significant medical or psychiatric findings",
  
 * 
 */
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
                null, 9, 2022, 23, 13, 100119, "Clinical Research Information Service (South Korea)",
                null, "en", 12, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));

            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100119,
                "Clinical Research Information Service (South Korea)",
                "https://cris.nih.go.kr/cris/search/detailSearchEn.do?seq=23046", true, 35, null, null, null));
            sdo.object_dates!.Add(
                new ObjectDate(sd_oid, 15, false, "2022 Oct 19", 2022, 10, 19, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Nov 28", 2022, 11, 28, null, null, null,
                null));

            fs.data_objects!.Add(sdo);

            return fs;

        }

        return null;
    }
}