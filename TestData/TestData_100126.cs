using System.Text;

namespace MDR_Tester;

public class TestData_100126 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "ISRCTN00075564")
        {
	        FullStudy fs = CreateEmptyFullStudy();
             
            // Study 
            
            string display_title = "A trial of withdrawal of nocturnal non-invasive positive pressure ventilation (NIPPV) in chronic obstructive pulmonary disease (COPD) patients ";
            display_title += "with chronic hypercapnic ventilatory failure previously stable on nocturnal NIPPV";
            StringBuilder sb = new StringBuilder("Study hypothesis: Currently it is unclear whether patients with severe COPD benefit from noninvasive positive pressure ventilation in the long term. ");
            sb.Append("There is divided opinion and evidence on whether this is a beneficial treatment and who might benefit. In performing this clinical trial of withdrawal of a non-proven "); 
            sb.Append("treatment with close monitoring we plan to address the issue of whether of not the treatment does maintain the patients in a stable clinical state and improve their quality of life.\n"); 
            sb.Append("Primary outcome(s): ‘Withdrawal Failure’ as stipulated by preset criteria. The effect of withdrawal of NIPPV therapy on arterial blood gas analysis.\n\n"); 
            sb.Append("Criteria for Withdrawal Failure:\n"); 
            sb.Append("1. Daytime PaCO2 >9 kPa\n"); 
            sb.Append("2. Nocturnal PtcCO2 >10 on night study\n"); 
            sb.Append("3. Respiratory acidosis pH <7.35\n"); 
            sb.Append("4. Intolerable symptoms, including morning headache and drowsiness\n"); 
            string brief_desc = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2005, 5, 11, 21, "40", 900,
                18, 17, 65, 17, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100126, 
                "ISRCTN", null, "2005 Jul 8", null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "04/Q0104/139 - NRR Publication ID: N0542155456", 14, null, 
                "Papworth Hospital NHS Trust (UK)", null, null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From ISRCTN"));

            fs.people!.Add(new StudyPerson(sd_sid, 51, "Nick Oscroft", null, null, null, null));
	        
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Papworth Hospital NHS Trust (UK)", null));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null,
	            "Respiratory Support and Sleep Centre Trust fund supported by an unrestricted grant from B & D Electromedical (UK))", 
	            null));

            fs.features!.Add(new StudyFeature(sd_sid, 20, 140));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 525));   // 
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Chronic Obstructive Pulmonary Disease (COPD)", 
		        null, null, null, null));
	        
	        fs.references!.Add(new StudyReference(sd_sid, "http://www.ncbi.nlm.nih.gov/pubmed/20397811", 
		        "20397811", "2010 results in ", null, ""));

	        // countries
            
	        // iec
	        /*
     *
     * 
     */
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: ISRCTN registry entry";
	        string ob_title = display_title + " :: ISRCTN registry entry";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "ISRCTN registry entry", null, ob_title,
		        "10.1186/ISRCTN00075564", 1, 2005, 23, 13, 100126, "ISRCTN", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100126, "ISRCTN", 
		        "https://www.isrctn.com/" + sd_sid, true, 39, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2005 Jul 8", 2005, 7, 8, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2010 Jul 16", 2010, 7, 16, null, null, null, null));
	       
	        fs.data_objects!.Add(sdo);

	        return fs;
        }
        
        if (sd_sid == "ISRCTN16535250")
        {
	        FullStudy fs = CreateEmptyFullStudy();
             
            // Study 
            
            string display_title = "Comparison between injection of local analgesia and performing a specific nerve block in the management of vaginal pain after delivery";
            StringBuilder sb = new StringBuilder("Study hypothesis: In women in labor and undergoing episiotomy pudendal nerve block may be similar to ");
            sb.Append("local infiltration by analgesic as regard post episiotomy pain relief.\n"); 
            sb.Append("Primary outcome(s): Pain measured using the Visual Analogue Scale assessed every hour for the first 6 hours postpartum starting from the time of the analgesia injection"); 
            string brief_desc = sb.ToString();
            sb = new StringBuilder("IPD sharing statement: The datasets generated during and/or analysed during the current study ");
            sb.Append("are/will be available upon request from Abdelrahman Abouelhassan (Bodym93@yahoo.com).\n"); 
            sb.Append("IPD: Available on request"); 
            string dss = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2018, 7, 11, 21, "100", 905,
                18, 17, 65, 17, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100126, 
                "ISRCTN", null, "2021 Jan 24", null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "20092018", 14, 100328, 
                "Ain Shams University", "https://ror.org/00cb9w016", null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From ISRCTN"));
            fs.titles.Add(new StudyTitle(sd_sid, 
	            "Effect of pudendal nerve block versus perineal local infiltration of analgesia in post episiotomy pain relief", 
	            16, "en", 11, false, "From ISRCTN"));
            
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Abdelrahman Abouelhassan", null, null, null, null));
	        
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100328, "Ain Shams University", 
	            "https://ror.org/00cb9w016"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 101522, "Ain Shams University Hospital", 
	            "https://ror.org/00p59qs14"));

	        fs.features!.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 525));   // 
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Post episiotomy pain after delivery", null, null, null, null));
            
            // countries
            
            // iec
            /*
     *
     * 
     */
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: ISRCTN registry entry";
            string ob_title = display_title + " :: ISRCTN registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "ISRCTN registry entry", null, ob_title,
	            "10.1186/ISRCTN16535250", 1, 2021, 23, 13, 100126, "ISRCTN", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100126, "ISRCTN", 
	            "https://www.isrctn.com/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2021 Jan 24", 2021,1, 24, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 Feb 4", 2021, 2, 4, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Protocol
            
            sd_oid = sd_sid + " :: 11 :: ISRCTN16535250_PROTOCOL";
            ob_title = display_title + " :: ISRCTN16535250_PROTOCOL";
            sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "ISRCTN16535250_PROTOCOL", null, ob_title,
	            null, 9, 2020, 23, 11, 100126, "ISRCTN", null, "en", 11, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 20, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100126, "ISRCTN", 
	            "https://www.isrctn.com/editorial/retrieveFile/24eb625c-779e-4308-a397-3b6a588edf4f/38799", 
	            true, 11, null, null, null));
            
            fs.data_objects!.Add(sdo);

            return fs;            
                  
        }

        if (sd_sid == "ISRCTN59589587")
        {
	        FullStudy fs = CreateEmptyFullStudy();
             
            // Study 
            
            string display_title = "A European Intergroup Cooperative Ewing’s Sarcoma Study: A randomised study for the treatment of Ewing’s sarcoma of bone";
            
            fs.study = new Study(sd_sid, display_title, "en", null, null, 1994, 1, 11, 21, "40", 915,
                18, 17, 65, 17, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100126, 
                "ISRCTN", null, "2001 Jul 1", null));
            fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT00002516", 11, 100120, 
	            "Clinicaltrials.gov", null, null, null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "ET 9302'", 14, null, 
                "Cancer Research UK (CRUK) (UK)", null, null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From ISRCTN"));
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Cancer Research UK", 
	            "https://ror.org/054225q67"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 100517, "Cancer Research UK", 
	            "https://ror.org/054225q67"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "European Community (BIOMED)", null));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 103602, "German Cancer Aid", 
	            "https://ror.org/01wxdd722"));

            fs.features!.Add(new StudyFeature(sd_sid, 20, 140));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 445));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 525));   // 
	        
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Cancer drugs", null, null, null, null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Bone cancer", null, null, null, null));
	        
            fs.references!.Add(new StudyReference(sd_sid, "http://www.ncbi.nlm.nih.gov/pubmed/10472562", 
		        "10472562", "1. 1999 preliminary results in ", null, ""));
		    fs.references!.Add(new StudyReference(sd_sid, "http://www.ncbi.nlm.nih.gov/pubmed/12504050", 
		        "12504050", "2. 2003 results in ", null, ""));
		    fs.references!.Add(new StudyReference(sd_sid, "http://www.ncbi.nlm.nih.gov/pubmed/16137838", 
		        "16137838", "3. 2005 results in '", null, ""));
		    fs.references!.Add(new StudyReference(sd_sid, "http://www.ncbi.nlm.nih.gov/pubmed/18398583", 
		        "18398583", "4. 2008 results in ", null, ""));
		    fs.references!.Add(new StudyReference(sd_sid, "http://www.ncbi.nlm.nih.gov/pubmed/18802150", 
		        "18802150", "5. 2008 results in ", null, ""));

            // countries
            
            // iec
            /*
     *
     * 
     */
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: ISRCTN registry entry";
            string ob_title = display_title + " :: ISRCTN registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "ISRCTN registry entry", null, ob_title,
	            "10.1186/ISRCTN59589587", 1, 2001, 23, 13, 100126, "ISRCTN", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100126, "ISRCTN", 
	            "https://www.isrctn.com/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2001 Jul 1", 2001, 7, 1, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2012 Feb 1", 2012, 2, 1, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        if (sd_sid == "ISRCTN88368130")
        {
	        FullStudy fs = CreateEmptyFullStudy();
             
            // Study 
            
            string display_title = "Scaling Colorectal cancer screening through Outreach, Referral, and Engagement (SCORE)";
            StringBuilder sb = new StringBuilder("Study hypothesis: This pilot study aims to assess the effectiveness, feasibility, acceptability, and cost-effectiveness of mailed ");
            sb.Append("fecal immunochemical test (FIT) screening, compared to usual care, among patients of two community health "); 
            sb.Append("centers who are due for colorectal cancer (CRC) screening\n"); 
            sb.Append("Primary outcome(s): The proportion of individuals who complete colorectal cancer (CRC) screening within 6 months, using any of "); 
            sb.Append("the screening modalities recommended by the United States Preventive Service Task Force (fecal immunochemical test [FIT], fecal "); 
            sb.Append("occult blood test [FOBT], FIT-DNA, colonoscopy, flexible sigmoidoscopy, flexible sigmoidoscopy with FIT, "); 
            sb.Append("CT colonography), assessed through electronic health record review at 6 months."); 
            string brief_desc = sb.ToString();
            sb = new StringBuilder("General dissemination plan: Planned publication in a high-impact peer-reviewed journal.\n");
            sb.Append("IPD: Stored in publicly available repository"); 
            string dss = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2018, 9, 11, 15, "711", 900,
                18, 17, 65, 17, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100106, 
                "ISRCTN", null, "2020 Jun 9", null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "NCT04406714", 11, 100120, 
                "Clinicaltrials.gov", null, null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From ISRCTN"));
            fs.titles.Add(new StudyTitle(sd_sid,
	            "Scaling Colorectal cancer screening through Outreach, Referral, and Engagement (SCORE): a state-level program to reduce colorectal cancer burden in vulnerable populations", 
	            16, "en", 11, false, "From ISRCTN"));
            fs.titles.Add(new StudyTitle(sd_sid, "SCORE", 14, "en", 11, false, "From ISRCTN"));
            
            fs.people!.Add(new StudyPerson(sd_sid, 51, null, null, "Daniel Reuland", "0000-0002-7839-6581'", null, null, null, null));
            fs.people.Add(new StudyPerson(sd_sid, 56, null, null, "Teri Malo", "0000-0002-5620-4841", null, null, null, null));
            fs.people.Add(new StudyPerson(sd_sid, 56, "Alexis Moore", null, null, null, null));
	        
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100482, "UNC Lineberger Comprehensive Cancer Center", 
	            null));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 100162, "National Cancer Institute", 
	            "https://ror.org/040gcmg81"));

	        fs.features!.Add(new StudyFeature(sd_sid, 21, 420));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 525));   // 
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Colorectal cancer'", null, null, "B5-2B9", 
		        "Malignant neoplasms of large intestine"));
	        
            // countries
            
            // iec
            /*
     *
     * 
     */
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: ISRCTN registry entry";
            string ob_title = display_title + " :: ISRCTN registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "ISRCTN registry entry", null, ob_title,
	            "10.1186/ISRCTN88368130", 1, 2020, 23, 13, 100126, "ISRCTN", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100126, "ISRCTN", 
	            "https://www.isrctn.com/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2020 Jun 9", 2020, 6, 9, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 Dec 16", 2021, 12, 16, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 2) Patient Information Sheets
            
            sd_oid = sd_sid + " :: 19 :: ISRCTN88368130_PIS";
            ob_title = display_title + " :: ISRCTN88368130_PIS";
            sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "ISRCTN88368130_PIS", null, ob_title,
	            null, 9, 2020, 23, 19, 100126, "ISRCTN", null, "en", 11, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 20, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100126, "ISRCTN", 
	            "https://www.isrctn.com/editorial/retrieveFile/51892cf1-c381-43fc-8930-d146ea1a6d83/38390", 
	            true, 11, null, null, null));
            
            fs.data_objects!.Add(sdo);

            return fs;            
                   
        }
        
        if (sd_sid == "ISRCTN82138287")
        {
	        FullStudy fs = CreateEmptyFullStudy();
             
            // Study 
            
            string display_title = "A Mechanistic Study Of Mifamurtide (MTPPE) In Patients With Metastatic And/Or Recurrent Osteosarcoma";
            StringBuilder sb = new StringBuilder("This is a Bayesian designed multi-arm, multi-centre open-label phase II study in patients with metastatic ");
            sb.Append("and/or recurrent osteosarcoma, which will investigate why some patients with osteosarcoma may respond better "); 
            sb.Append("than others to mifamurtide given alone or in combination with ifosfamide.\n"); 
            sb.Append("Primary outcome(s): Objective Radiological response; Timepoint(s): Pre-treatment, after 6, 12, 18, 24 & 36 weeks of treatment"); 
            string brief_desc = sb.ToString();
            sb = new StringBuilder("IPD sharing statement: The data sharing plans for the current study are unknown and will be made available at a later date.\n");
            sb.Append("IPD: To be made available at a later date"); 
            string dss = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, dss, 2014, 9, 11, 21, 
	            "Planned Sample Size: 40; UK Sample Size: 10", 900, 18, 17, 65, 17, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100106, 
                "ISRCTN", null, "2014 Sep 18", null));
            fs.identifiers!.Add(new StudyIdentifier(sd_sid, "2012-000615-84", 11, 100123, 
	            "EU Clinical Trials Register", null, null, null));
            fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT02441309", 11, 100120, 
	            "Clinicaltrials.gov'", null, null, null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "16801", 14, 100253, 
                "University of Oxford", "https://ror.org/052gg0110", null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From ISRCTN"));
            fs.titles.Add(new StudyTitle(sd_sid, "MEMOS: a Eurosarc Study of Mifamurtide in advanced osteosarcoma", 
	            14, "en", 11, false, "From ISRCTN"));
            
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Linda Collins", null, null, null, null));
	        
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100253, "University of Oxford", 
	            "https://ror.org/052gg0110"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 100574, "European Commission", 
	            "https://ror.org/00k4n6c32"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "Millenium Pharmaceuticals Inc (USA)", 
	            null));

            fs.features!.Add(new StudyFeature(sd_sid, 20, 1220));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 21, 400));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        
	        fs.features.Add(new StudyFeature(sd_sid, 24, 525));   // 
	        fs.topics!.Add(new StudyTopic(sd_sid, 12, "Mifamurtide, Ifosfamide", null, null, null, null));
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Topic: Cancer; Subtopic: Sarcoma; Disease: Bone", 
		        null, null, null, null));
            
            // countries
            
            // iec
            /*
             *
             * 
             */
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: ISRCTN registry entry";
            string ob_title = display_title + " :: ISRCTN registry entry";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "ISRCTN registry entry", null, ob_title,
	            "10.1186/ISRCTN82138287", 1, 2005, 23, 13, 100126, "ISRCTN", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100126, "ISRCTN", 
	            "https://www.isrctn.com/" + sd_sid, true, 39, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2014 Sep 18", 2014, 9, 18, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2019 Jun 11", 2019, 6, 11, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
        }

        return null;
    }
}