using System.Text;

namespace MDR_Tester;

public class TestData_101900 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
	    StringBuilder asb =
		    new StringBuilder("Investigators wishing to request materials from studies ... must register (free) on the BioLINCC website. ");
	    asb.Append("Registered investigators may then request detailed searches and submit an application for data sets and/or biospecimens. (from the BioLINCC website)");
	    
	    StringBuilder dsb =
		    new StringBuilder("All BioLINCC data and biospecimens are de-identified. Obvious subject identifiers and data collected solely for ");
	    dsb.Append("administrative purposes are redacted from datasets, and dates are recoded relative to a specific reference point. ");
	    dsb.Append("In addition recodes of selected low-frequency data values may be carried out to protect subject privacy and minimize ");
	    dsb.Append("re-identification risks (from the BioLINCC documentation).");
	    
        if (sd_sid == "BABY HUG")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Long-Term Effects of Hydroxyurea in Children With Sickle Cell Anemia (The BABY HUG Follow-up Study)";
	        StringBuilder sb = new StringBuilder("Objectives: The purpose of the Randomized Controlled Trial was to determine if hydroxyurea can safely ");
	        sb.Append("prevent early end organ damage in very young children with sickle cell anemia.\n"); 
	        sb.Append("The purpose of the BABY HUG Follow-up Study I was to provide structured follow-up of the children enrolled in the BABY HUG "); 
	        sb.Append("Randomized Controlled Trial, in order to characterize the long-term toxicities and unexpected risks (if any) associated "); 
	        sb.Append("with treatment with hydroxyurea at an early age.\n"); 
	        sb.Append("The objective of Follow-Up Study II was to obtain additional data about the long-term safety and efficacy of hydroxyurea "); 
	        sb.Append("use in children with Sickle Cell Anemia through at least the first decade of life."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2000, 8, 11, 21, null, 915,
		        null, null, null, null, 0);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT00006400", 11, 100120, 
		        "ClinicalTrials.gov", null, null, null));
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT00890396", 11, 100120, 
		        "ClinicalTrials.gov", null, null, null));
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT01783990", 11, 100120, 
		        "ClinicalTrials.gov", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "HLB02352022a", 42, 100167, 
		        "National Heart, Lung, and Blood Institute", "https://ror.org/012pb6c26", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, 
		        "Hydroxyurea to Prevent Organ Damage in Children with Sickle Cell Anemia (BABY HUG) Phase III Clinical Trial and Follow-Up Observational Studies I and II", 
		        18, "en", 11, false, "From BioLINCC web page"));
	        fs.titles.Add(new StudyTitle(sd_sid, "BABY HUG", 14, "en", 11, false, "From BioLINCC web page"));

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100167, 
		        "National Heart, Lung, and Blood Institute", "https://ror.org/012pb6c26"));

	        fs.references!.Add(new StudyReference(sd_sid, null, "21571150", 
		        "https://www.ncbi.nlm.nih.gov/pubmed/2157115", null, "primary"));	
            
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 38 :: NHLBI web page";
	        string ob_title = display_title + " :: NHLBI web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "NHLBI web page", null, ob_title,
		        null, 9, null, 23, 38, 100167, "National Heart, Lung, and Blood Institute", 
		        "https://ror.org/012pb6c26", "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
		        "https://biolincc.nhlbi.nih.gov/studies/baby_hug/", true, 35, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 2) Datasets
	        
	        sd_oid = sd_sid + " :: 80 :: Individual participant data";
	        ob_title = display_title + " :: Individual participant data";
	        sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Individual participant data", null, ob_title,
		        null, 9, 2022, 14, 80, 100167, "National Heart, Lung, and Blood Institute", 
		        "https://ror.org/012pb6c26", "en", 17, asb.ToString(), 
		        "https://biolincc.nhlbi.nih.gov/media/guidelines/handbook.pdf?link_time=2019-12-13_11:33:44.807479#page=15",
		        3, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        
	        sdo.dataset_details = new ObjectDataset(sd_oid, null, null, 2, null, null, null, null, null,
		        dsb.ToString(), 6, null, null, null, null, null, 
		        "Restrictions reported on the use of data depending on the area of research. Use of data and/or specimens is limited to research on sickle cell anemia and related disorders.");
	        
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 18, false, "2022 Feb 7", 2022, 2, 7, null, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 3) Data Dictionary
	        
	        sd_oid = sd_sid + " :: 31 :: Data Dictionary";
	        ob_title = display_title + " :: Data Dictionary";
	        sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Data Dictionary", null, ob_title,
		        null, 9, null, 23, 31, 100167, "National Heart, Lung, and Blood Institute", 
		        "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
		        "https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/data_dictionary/Baby_HUG_2021a.pdf",
		        true, 11, "3.1", "MB", null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 4) BABY HUG Follow-up Study II Annotated CRFs
	        
	        sd_oid = sd_sid + " :: 30 :: BABY HUG Follow-up Study II Annotated CRFs";
	        ob_title = display_title + " :: BABY HUG Follow-up Study II Annotated CRFs";
	        sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "BABY HUG Follow-up Study II Annotated CRFs", null, ob_title,
		        null, 9, null, 23, 30, 100167, "National Heart, Lung, and Blood Institute", 
		        "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
		        "https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_II_Annotated_CRFs.pdf",
		        true, 11, "1.2", "MB", null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 5) BABY HUG Follow-up Study II Manual of Operations
	        
	        sd_oid = sd_sid + " :: 35 :: BABY HUG Follow-up Study II Manual of Operations";
	        ob_title = display_title + " :: BABY HUG Follow-up Study II Manual of Operations";
	        sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "BABY HUG Follow-up Study II Manual of Operations", null, ob_title,
		        null, 9, null, 23, 35, 100167, "National Heart, Lung, and Blood Institute", 
		        "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
		        "https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_II_Manual_of_Operations.pdf",
		        true, 11, "2.3", "MB", null));
	        
	        fs.data_objects!.Add(sdo);

	        // 6) BABY HUG Follow-up Study II Protocol
	        
	        sd_oid = sd_sid + " :: 11 :: BABY HUG Follow-up Study II Protocol";
	        ob_title = display_title + " :: BABY HUG Follow-up Study II Protocol";
	        sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "BABY HUG Follow-up Study II Protocol", null, ob_title,
		        null, 9, null, 23, 11, 100167, "National Heart, Lung, and Blood Institute", 
		        "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
		        "https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_II_Protocol.pdf",
		        true, 11, "568.5", "KB", null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 7) BABY HUG Follow-up Study I Annotated CRFs
            	        
            sd_oid = sd_sid + " :: 30 :: BABY HUG Follow-up Study I Annotated CRFs";
            ob_title = display_title + " :: BABY HUG Follow-up Study I Annotated CRFs";
            sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "BABY HUG Follow-up Study I Annotated CRFs", null, ob_title,
                null, 9, null, 23, 30, 100167, "National Heart, Lung, and Blood Institute", 
                "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
                "https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_I_Annotated_CRFs.pdf",
                true, 11, "5.8", "MB", null));
            
            fs.data_objects!.Add(sdo);
            
            // 8) BABY HUG Follow-up Study I Manual of Operations
            
            sd_oid = sd_sid + " :: 35 :: BABY HUG Follow-up Study I Manual of Operations";
            ob_title = display_title + " :: BABY HUG Follow-up Study I Manual of Operations";
            sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "BABY HUG Follow-up Study I Manual of Operations", null, ob_title,
                null, 9, null, 23, 35, 100167, "National Heart, Lung, and Blood Institute", 
                "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
                "https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_I_Manual_of_Operations.pdf",
                true, 11, "2.8", "MB", null));
            
            fs.data_objects!.Add(sdo);

            // 9) BABY HUG Follow-up Study I Protocol
            
            sd_oid = sd_sid + " :: 11 :: BABY HUG Follow-up Study I Protocol";
            ob_title = display_title + " :: BABY HUG Follow-up Study I Protocol";
            sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "BABY HUG Follow-up Study I Protocol", null, ob_title,
                null, 9, null, 23, 11, 100167, "National Heart, Lung, and Blood Institute", 
                "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
                "https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_I_Protocol.pdf",
                true, 11, "659.8", "KB", null));
            
            fs.data_objects!.Add(sdo);
                    
            
	        // 10) BABY HUG RCT Annotated CRFs
            	        
            sd_oid = sd_sid + " :: 30 :: BABY HUG RCT Annotated CRFs";
            ob_title = display_title + " :: BABY HUG RCT Annotated CRFs";
            sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "BABY HUG RCT Annotated CRFs", null, ob_title,
                null, 9, null, 23, 30, 100167, "National Heart, Lung, and Blood Institute", 
                "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
                "https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_RCT_Annotated_CRFs.pdf",
                true, 11, "3.3", "MB", null));
            
            fs.data_objects!.Add(sdo);
            
            // 11) BABY HUG RCT Manual of Operations
            
            sd_oid = sd_sid + " :: 35 :: BABY HUG RCT Manual of Operations";
            ob_title = display_title + " :: BABY HUG RCT Manual of Operations";
            sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "BABY HUG RCT Manual of Operations", null, ob_title,
                null, 9, null, 23, 35, 100167, "National Heart, Lung, and Blood Institute", 
                "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
                "https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_RCT_Manual_of_Operations.pdf",
                true, 11, "2.7", "MB", null));
            
            fs.data_objects!.Add(sdo);

            // 12) BABY HUG RCT Protocol
            
            sd_oid = sd_sid + " :: 11 :: BABY HUG RCT Protocol";
            ob_title = display_title + " :: BABY HUG RCT Protocol";
            sdo = CreateEmptyStudyDataObject();
            
            sdo.data_object = new DataObject(sd_oid, sd_sid, "BABY HUG RCT Protocol", null, ob_title,
                null, 9, null, 23, 11, 100167, "National Heart, Lung, and Blood Institute", 
                "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
            
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
                "https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_RCT_Protocol.pdf",
                true, 11, "1.2", "MB", null));
            
            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        if (sd_sid == "ACRN-BAGS")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Asthma Clinical Research Network (ACRN) Beta Agonist in Mild Asthma Study (BAGS)";
	        StringBuilder sb = new StringBuilder("Objectives: An important question in current asthma research is whether regularly scheduled treatment ");
	        sb.Append("with inhaled Beta-agonists in asthmatics produces adverse effects on asthma control. Because an estimated 60-70% of patients with "); 
	        sb.Append("asthma have mild disease and are treated only with inhaled Beta2-adrenergic agonists of medium duration, a firm basis upon which "); 
	        sb.Append("to make treatment recommendations for this large number of patients was critically needed. Therefore, the ACRN developed a protocol "); 
	        sb.Append("to test the following null hypothesis: In patients with mild asthma, whose only asthma treatment is inhaled Beta-agonists, addition "); 
	        sb.Append("of regular inhaled Beta-agonist treatment to treatment on an \"as needed only\" basis will result in no effect on asthma control."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 1994, null, 11, 21, null, 915,
		        null, null, null, null, 0);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT00000577", 11, 100120, 
		        "ClinicalTrials.gov", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "HLB00140202a", 42, 100167, 
		        "National Heart, Lung, and Blood Institute", "https://ror.org/012pb6c26", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, 
		        "Asthma Clinical Research Network Trial (ACRN) - Long-Acting Beta Agonist Response by Genotype (LARGE)", 
		        18, "en", 11, false, "From BioLINCC web page"));
	        fs.titles.Add(new StudyTitle(sd_sid, "ACRN-BAGS", 14, "en", 11, false, "From BioLINCC web page"));

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100375, "Milton S Hershey Medical Center", 
		        "https://ror.org/01h22ap11"));

	        fs.references!.Add(new StudyReference(sd_sid, null, "19932356", 
		        "https://www.ncbi.nlm.nih.gov/pubmed/19932356", null, "primary"));	
	        
            // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 38 :: NHLBI web page";
	        string ob_title = display_title + " :: NHLBI web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
            
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "NHLBI web page", null, ob_title,
		        null, 9, null, 23, 38, 100167, "National Heart, Lung, and Blood Institute", 
		        "https://ror.org/012pb6c26", "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
		        "https://biolincc.nhlbi.nih.gov/studies/bags/", true, 35, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 2) Datasets
	        
	        sd_oid = sd_sid + " :: 80 :: Individual participant data";
	        ob_title = display_title + " :: Individual participant data";
	        sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Individual participant data", null, ob_title,
		        null, 9, 2018, 14, 80, 100167, "National Heart, Lung, and Blood Institute", 
		        "https://ror.org/012pb6c26", "en", 17, asb.ToString(), 
		        "https://biolincc.nhlbi.nih.gov/media/guidelines/handbook.pdf?link_time=2019-12-13_11:33:44.807479#page=15",
		        3, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        
	        sdo.dataset_details = new ObjectDataset(sd_oid, null, null, 2, null, null, null, null, null,
		        dsb.ToString(), null, null, null, null, null, null, null);
	        
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 18, false, "2018 Jan 3", 2018, 1, 3, null, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 3) Data Dictionary
	        
	        sd_oid = sd_sid + " :: 31 :: Data Dictionary";
	        ob_title = display_title + " :: Data Dictionary";
	        sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Data Dictionary", null, ob_title,
		        null, 9, null, 23, 31, 100167, "National Heart, Lung, and Blood Institute", 
		        "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
		        "https://biolincc.nhlbi.nih.gov/media/studies/bags/data_dictionary/ACRN_BAGS.pdf",
		        true, 11, "240.2", "KB", null));
	        
	        fs.data_objects!.Add(sdo);
	        
	        // 4) Forms
	        
	        sd_oid = sd_sid + " :: 86 :: Forms";
	        ob_title = display_title + " :: Forms";
	        sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Forms", null, ob_title,
		        null, 9, null, 23, 86, 100167, "National Heart, Lung, and Blood Institute", 
		        "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
		        "https://biolincc.nhlbi.nih.gov/studies/bags/Forms/",
		        true, 35, null, null, null));
	        
	        fs.data_objects!.Add(sdo);
			
	        // 5) Manual of Operations
	        
	        sd_oid = sd_sid + " :: 36 :: Manual";
	        ob_title = display_title + " :: Manual";
	        sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Manual", null, ob_title,
		        null, 9, null, 23, 36, 100167, "National Heart, Lung, and Blood Institute", 
		        "https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
		        "https://biolincc.nhlbi.nih.gov/media/studies/bags/Manual.pdf",
		        true, 11, "250.3", "KB", null));
	        
	        fs.data_objects!.Add(sdo);

	        return fs;
        }
        

        if (sd_sid == "TOPCAT")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Aldosterone Antagonist Therapy for Adults With Heart Failure and Preserved Systolic Function";
	        StringBuilder sb = new StringBuilder("Objectives: The TOPCAT trial evaluated the effectiveness of aldosterone antagonist therapy in ");
	        sb.Append("reducing cardiovascular mortality, aborted cardiac arrest, and heart failure hospitalization in patients "); 
	        sb.Append("who have heart failure with preserved systolic function."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2006, 8, 11, 21, null, 915,
		        null, null, null, null, 0);
	        
	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT00094302", 11, 100120, 
		        "ClinicalTrials.gov", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "HLB01341616a", 42, 100167, 
		        "National Heart, Lung, and Blood Institute", "https://ror.org/012pb6c26", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, 
		        "Treatment of Preserved Cardiac Function Heart Failure With an Aldosterone Antagonist (TOPCAT)", 
		        18, "en", 11, false, "From BioLINCC web page"));
	        fs.titles.Add(new StudyTitle(sd_sid, "TOPCAT", 14, "en", 11, false, "From BioLINCC web page"));

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 101993, "HealthCore-NERI", null));

	        fs.references!.Add(new StudyReference(sd_sid, null, "24716680", 	
		        "https://www.ncbi.nlm.nih.gov/pubmed/24716680", null, "primary"));
	        
			sb = new StringBuilder("Adabag S, Langsetmo L. ");
			sb.Append("Sudden cardiac death risk prediction in heart failure with preserved ejection fraction. ");
			sb.Append("Heart Rhythm 2020 Mar;17(3):358-364. Epub 2019 Dec 13.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31838199", "bb7380553e0c4745a062406843f78b22",
			null, "associated"));	

			sb = new StringBuilder("Beale AL, Nanayakkara S, Kaye DM. ");
			sb.Append("Impact of Sex on Ventricular-Vascular Stiffness and Long-Term Outcomes in Heart Failure With Preserved Ejection Fraction: TOPCAT Trial Substudy. ");
			sb.Append("J Am Heart Assoc 2019 Jul 2;8(13):e012190. Epub 2019 Jun 22.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31230508", "9705894e33d743ca86693716494142a9", 
			null, "associated"));	
			
			sb = new StringBuilder("Berkowitz SA, Rudolph KE, Basu S. ");
			sb.Append("Detecting Anomalies Among Practice Sites Within Multicenter Trials. ");
			sb.Append("Circ Cardiovasc Qual Outcomes 2019 Mar;12(3):e004907.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30857413", "225391cc827e4601a6b6acc26c484527",
			null, "associated"));	
			
			sb = new StringBuilder("Berkowitz SA, Sussman JB, Jonas DE, Basu S. ");
			sb.Append("Generalizing Intensive Blood Pressure Treatment to Adults With Diabetes Mellitus. ");
			sb.Append("J Am Coll Cardiol 2018 Sep 11;72(11):1214-1223.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30189998", "93c88c882f264dad96d248d4cabd08b9",
			null, "associated"));
			
			sb = new StringBuilder("Buckley LF, Dixon DL, Wohlford GF 4th, Wijesinghe DS, Baker WL, Van Tassell BW. ");
			sb.Append("Effect of intensive blood pressure control in patients with type 2 diabetes mellitus over 9 years of follow-up: ");
			sb.Append("A subgroup analysis of high-risk ACCORDION trial participants. ");
			sb.Append("Diabetes Obes Metab 2018 Jun;20(6):1499-1502. Epub 2018 Mar 2.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29424469", "9d59f37cd472448e803c63a42bb66af9",
			null, "associated"));	

			sb = new StringBuilder("Caraballo C, Desai NR, Mulder H, Alhanti B, Wilson FP, Fiuzat M, Felker GM, Piña IL, O’Connor CM, Lindenfeld J, Januzzi JL, Cohen LS, Ahmad T. Cl");
			sb.Append("Clinical Implications of the New York Heart Association Classification. ");
			sb.Append("J Am Heart Assoc 2019 Dec 3;8(23):e014240. Epub 2019 Nov 27.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31771438", "c52f71df349b4d5dbaf3fbed0f9def37",
			null, "associated"));	
			
			sb = new StringBuilder("Cohen JB, Schrauben SJ, Zhao L, Basso MD, Cvijic ME, Li Z, Yarde M, Wang Z, Bhattacharya PT, Chirinos DA, Prenner S, Zamani P, Seiffert DA, Car BD, Gordon DA, Margulies K, Cappola T, Chirinos JA. ");
			sb.Append("Clinical Phenogroups in Heart Failure With Preserved Ejection Fraction: Detailed Phenotypes, Prognosis, and Response to Spironolactone. ");
			sb.Append("JACC Heart Fail 2020 Mar;8(3):172-184. Epub 2020 Jan 8.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31926856", "e7d11b6b65eb4ba5b5edacad09f32dea",
			null, "associated"));	
			
			sb = new StringBuilder("Curtis JP, Rathore SS, Wang Y, Krumholz HM. ");
			sb.Append("The association of 6-minute walk performance and outcomes in stable outpatients with heart failure. ");
			sb.Append("J Card Fail 2004 Feb;10(1):9-14.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "14966769", "92f20d8af2e84784a84295a589bb81c1",
			null, "associated"));	
			
			sb = new StringBuilder("Dewan P, Rørth R, Raparelli V, Campbell RT, Shen L, Jhund PS, Petrie MC, Anand IS, Carson PE, Desai AS, Granger CB, Køber L, Komajda M, McKelvie RS, O’Meara E, Pfeffer MA, Pitt B, Solomon SD, Swedberg K, Zile MR, McMurray JJV. ");
			sb.Append("Sex-Related Differences in Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("Circ Heart Fail 2019 Dec;12(12):e006539. Epub 2019 Dec 9.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31813280", "dd065552c7c240abb6eb2767f07d3cbe",
			null, "associated"));	
			
			sb = new StringBuilder("Elkholey K, Papadimitriou L, Butler J, Thadani U, Stavrakis S. ");
			sb.Append("Effect of Obesity on Response to Spironolactone in Patients With Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("Am J Cardiol 2021 May 1;146:36-47. Epub 2021 Jan 30.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "33529620", "14fe316ce9f64f558ae65cef1b55f28b",
			null, "associated"));	
						
			sb = new StringBuilder("Ferreira JP, Rossello X, Eschalier R, McMurray JJV, Pocock S, Girerd N, Rossignol P, Pitt B, Zannad F. ");
			sb.Append("MRAs in Elderly HF Patients: Individual Patient-Data Meta-Analysis of RALES, EMPHASIS-HF, and TOPCAT. ");
			sb.Append("JACC Heart Fail 2019 Dec;7(12):1012-1021.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31779922", "0c20257c42e54f7987b0e63e2bba4172",
			null, "associated"));	
			
			sb = new StringBuilder("Grodin JL, Philips S, Mullens W, Nijst P, Martens P, Fang JC, Drazner MH, Tang WHW, Pandey A. ");
			sb.Append("Prognostic implications of plasma volume status estimates in heart failure with preserved ejection fraction: insights from TOPCAT. ");
			sb.Append("Eur J Heart Fail 2019 May;21(5):634-642. Epub 2019 Feb 4.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30714658", "1491696ccfb1453e8f243ca64c3cb822",
			null, "associated"));	

			sb = new StringBuilder("Grodin JL, Testani JM, Pandey A, Sambandam K, Drazner MH, Fang JC, Tang WHW. ");
			sb.Append("Perturbations in serum chloride homeostasis in heart failure with preserved ejection fraction: insights from TOPCAT. ");
			sb.Append("Eur J Heart Fail 2018 Oct;20(10):1436-1443. Epub 2018 Jun 12.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29893446", "433a0e477bd84293a65eee32d49acec2",
			null, "associated"));	
			
			sb = new StringBuilder("Gupta K, Kalra R, Rajapreyar I, Joly JM, Pate M, Cribbs MG, Ather S, Prabhu SD, Bajaj NS. ");
			sb.Append("Anemia, Mortality, and Hospitalizations in Heart Failure With a Preserved Ejection Fraction (from the TOPCAT Trial). ");
			sb.Append(" Am J Cardiol 2020 May 1;125(9):1347-1354. Epub 2020 Feb 8.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "32151432", "eaf032f35e1948c1a5358eba93c51613",
			null, "associated"));	
			
			sb = new StringBuilder("Javaheri A, Allegood JC, Cowart LA, Chirinos JA. ");
			sb.Append("Circulating Ceramide 16:0 in Heart Failure With Preserved Ejection Fraction. ");
			sb.Append(" J Am Coll Cardiol 2020 May 5;75(17):2273-2275.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "32354389", "69c8e1c36d0748a99805c7df049ee724",
			null, "associated"));	
			
			sb = new StringBuilder("Kalogeropoulos AP, Thankachen J, Butler J, Fang JC. ");
			sb.Append("Diuretic and renal effects of spironolactone and heart failure hospitalizations: a TOPCAT Americas analysis. ");
			sb.Append("Eur J Heart Fail 2020 Sep;22(9):1600-1610. Epub 2020 Jun 26.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "32469156", "0bb7f302dca6414a959cce1dc7fa4961",
			null, "associated"));	
			
			sb = new StringBuilder("Kristensen SL, Mogensen UM, Jhund PS, Rørth R, Anand IS, Carson PE, Desai AS, Pitt B, Pfeffer MA, Solomon SD, Zile MR, Køber L, McMurray JJV. ");
			sb.Append("N-Terminal Pro-B-Type Natriuretic Peptide Levels for Risk Prediction in Patients With Heart Failure and Preserved Ejection Fraction According to Atrial Fibrillation Status. ");
			sb.Append("Circ Heart Fail 2019 Mar;12(3):e005766");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30871349", "ddd166d63fe545be9846a095fe6fef40", 
			null, "associated"));	
			
			sb = new StringBuilder("Lolli L, Batterham AM, Atkinson G. ");
			sb.Append("Ejection fraction as a statistical index of left ventricular systolic function: the first full allometric scrutiny of its appropriateness and accuracy. ");
			sb.Append("Clin Physiol Funct Imaging 2018 Feb 20. Epub 2018 Feb 20.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29460366", "081aaa888acc493b9c0bd5965ec3bc5a",
			null, "associated"));	

			sb = new StringBuilder("Merrill M, Sweitzer NK, Lindenfeld J, Kao DP. ");
			sb.Append("Sex Differences in Outcomes and Responses to Spironolactone in Heart Failure With Preserved Ejection Fraction: A Secondary Analysis of TOPCAT Trial. ");
			sb.Append("JACC Heart Fail 2019 Mar;7(3):228-238.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30819379", "b8b553211bd54a9eb7a2339d709fe032",
			null, "associated"));	
				
			sb = new StringBuilder("Neefs J, van den Berg NWE, Krul SPJ, Boekholdt SM, de Groot JR. ");
			sb.Append("Effect of Spironolactone on Atrial Fibrillation in Patients with Heart Failure with Preserved Ejection Fraction: Post-Hoc Analysis of the Randomized, Placebo-Controlled TOPCAT Trial. ");
			sb.Append("Am J Cardiovasc Drugs 2020 Feb;20(1):73-80.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31214914", "e7d88aca32234b13a841d7a09e666957",
			null, "associated"));	
			
			sb = new StringBuilder("O’Neal WT, Sandesara P, Hammadah M, Venkatesh S, Samman-Tahhan A, Kelli HM, Soliman EZ. ");
			sb.Append("Gender Differences in the Risk of Adverse Outcomes in Patients With Atrial Fibrillation and Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("Am J Cardiol 2017 Jun 1;119(11):1785-1790. Epub 2017 Mar 16.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "28395886", "03cfc1fecf7241829ed9fc332fcb0943",
			null, "associated"));	
			
			sb = new StringBuilder("O’Neal WT, Sandesara P, Patel N, Venkatesh S, Samman-Tahhan A, Hammadah M, Kelli HM, Soliman EZ. ");
			sb.Append("Echocardiographic predictors of atrial fibrillation in patients with heart failure with preserved ejection fraction. ");
			sb.Append("Eur Heart J Cardiovasc Imaging 2017 Jul 1;18(7):725-729.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "28379310", "3e8da652f6b24155af89c18c8c2fdf62", 
			null, "associated"));	

			sb = new StringBuilder("O’Neal WT, Sandesara PB, Samman-Tahhan A, Kelli HM, Hammadah M, Soliman EZ. ");
			sb.Append("Heart rate and the risk of adverse outcomes in patients with heart failure with preserved ejection fraction. ");
			sb.Append("Eur J Prev Cardiol 2017 Jul;24(11):1212-1219. Epub 2017 May 9.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "28482692", "3383d5964a854dc8b3efb4b7ed5e0928", 
			null, "associated"));	
			
			sb = new StringBuilder("Pandey A, Berry JD, Drazner MH, Fang JC, Tang WHW, Grodin JL. ");
			sb.Append("Body Mass Index, Natriuretic Peptides, and Risk of Adverse Outcomes in Patients With Heart Failure and Preserved Ejection Fraction: Analysis From the TOPCAT Trial. ");
			sb.Append("J Am Heart Assoc 2018 Nov 6;7(21):e009664.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30376747", "1f8f509087464208bd083f253001b83f",
			null, "associated"));	
			
			sb = new StringBuilder("Pandey A, Kagiyama N, Yanamala N, Segar MW, Cho JS, Tokodi M, Sengupta PP. ");
			sb.Append("Deep-Learning Models for the Echocardiographic Assessment of Diastolic Dysfunction. ");
			sb.Append("JACC Cardiovasc Imaging 2021 May 12. Epub 2021 May 12.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "34023263", "21de9d4399974620ab44ee5f54b01146", 
			null, "associated"));	
		          
			sb = new StringBuilder("Pandey A, Patel KV, Ayers C, Tang WHW, Fang JC, Drazner MH, Berry J, Grodin JL. ");
			sb.Append("Temporal association between hospitalization event and subsequent risk of mortality among patients with stable chronic heart failure with preserved ejection fraction: ");
			sb.Append("insights from the TOPCAT trial. ");
			sb.Append("Eur J Heart Fail 2019 May;21(5):693-695. Epub 2019 Apr 1.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30933394", "08d9a532421a4d08a1066518e43ae33c",
			null, "associated"));	

			sb = new StringBuilder("Patel N, O’Neal WT, Whalen SP, Soliman EZ. ");
			sb.Append("The association of QT interval components with atrial fibrillation. ");
			sb.Append("Ann Noninvasive Electrocardiol 2018 Mar;23(2):e12467. Epub 2017 Jun 29.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "28660734", "6479857210334423ac7e52a96e498129",
			null, "associated"));	
			
			sb = new StringBuilder("Pokharel Y, Khariton Y, Tang Y, Nassif ME, Chan PS, Arnold SV, Jones PG, Spertus JA. ");
			sb.Append(" Association of Serial Kansas City Cardiomyopathy Questionnaire Assessments With Death and Hospitalization in Patients With Heart Failure With Preserved and ");
			sb.Append("Reduced Ejection Fraction: A Secondary Analysis of 2 Randomized Clinical Trials. ");
			sb.Append("JAMA Cardiol 2017 Dec 1;2(12):1315-1321.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29094152", "d43fa1813ffd47059086deabbace95d8", 
			null, "associated"));	

			sb = new StringBuilder("Prenner SB, Kumar A, Zhao L, Cvijic ME, Basso M, Spires T, Li Z, Yarde M, Bhattacharya P, Zamani P, Mazurek J, Wang Z, Seiffert D, Gordon DA, Chirinos JA. ");
			sb.Append("Effect of Serum Albumin Levels in Patients With Heart Failure With Preserved Ejection Fraction (from the TOPCAT Trial). ");
			sb.Append("Am J Cardiol 2020 Feb 15;125(4):575-582. Epub 2019 Nov 19.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31843232", "4c974916eccc4ea18c22f0d6fc8f04b0",
			null, "associated"));	
			
			sb = new StringBuilder("Rahimi G, Tecson KM, Elsaid O, McCullough PA. ");
			sb.Append("Role of Ischemic Heart Disease in Major Adverse Renal and Cardiac Events Among Individuals With Heart Failure With Preserved Ejection Fraction (from the TOPCAT Trial). ");
			sb.Append("Am J Cardiol 2021 Mar 1;142:91-96. Epub 2020 Dec 3.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "33279481", "740ea0d61fb74c8ca3c40a6a5a48f07a",
			null, "associated"));	

			sb = new StringBuilder("Sandesara PB, Hammadah M, Samman-Tahhan A, Kelli HM, O’Neal WT. ");
			sb.Append("Peripheral artery disease and risk of adverse outcomes in heart failure with preserved ejection fraction. ");
			sb.Append("Clin Cardiol 2017 Sep;40(9):692-696. Epub 2017 Apr 26.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "28444995", "a7c6d24f3227464f84d19a80f9cf63b8",
			null, "associated"));	
			
			sb = new StringBuilder("Sandesara PB, O’Neal WT, Kelli HM, Samman-Tahhan A, Hammadah M, Quyyumi AA, Sperling LS. ");
			sb.Append("The Prognostic Significance of Diabetes and Microvascular Complications in Patients With Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("Diabetes Care 2018 Jan;41(1):150-155. Epub 2017 Oct 19.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29051160", "2b971a58aac1438dabfcf2e38ca88c77", 
			null, "associated"));	
			
			sb = new StringBuilder("Sandesara PB, O’Neal WT, Kelli HM, Topel M, Samman-Tahhan A, Sperling LS. ");
			sb.Append("Diastolic Blood Pressure and Adverse Outcomes in the TOPCAT (Treatment of Preserved Cardiac Function Heart Failure With an Aldosterone Antagonist) Trial. ");
			sb.Append("J Am Heart Assoc 2018 Feb 23;7. (5).");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29475874", "0de9e85a892e40b6adbe205ec60f1c6d", 
			null, "associated"));	

			sb = new StringBuilder("Sandesara PB, Samman-Tahhan A, Topel M, Venkatesh S, O’Neal WT. ");
			sb.Append("Effect of Cigarette Smoking on Risk for Adverse Events in Patients With Heart Failure and Preserved Ejection Fraction. ");
			sb.Append("Am J Cardiol 2018 Aug 1;122(3):400-404. Epub 2018 May 1.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "30201107", "034e1627819845feb1c6eb3c20827d63",
			null, "associated"));	

			sb = new StringBuilder("Segar MW, Patel KV, Ayers C, Basit M, Tang WHW, Willett D, Berry J, Grodin JL, Pandey A. ");
			sb.Append("Phenomapping of patients with heart failure with preserved ejection fraction using machine learning-based unsupervised cluster analysis. ");
			sb.Append("Eur J Heart Fail 2020 Jan;22(1):148-158. Epub 2019 Oct 21.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31637815", "3604b26d6eb74359b567dee9ba6b366c",
			null, "associated"));	

			sb = new StringBuilder("Shen L, Rørth R, Cosmi D, Kristensen SL, Petrie MC, Cosmi F, Latini R, Køber L, Anand IS, Carson PE, Granger CB, Komajda M, McKelvie RS, Solomon SD, Staszewsky L, Swedberg K, Huynh T, Zile MR, Jhund PS, McMurray JJV. ");
			sb.Append("Insulin treatment and clinical outcomes in patients with diabetes and heart failure with preserved ejection fraction. ");
			sb.Append("Eur J Heart Fail 2019 Aug;21(8):974-984. Epub 2019 Jul 4.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31271255", "f2136efba20b4d9e83f9b7568ab36f97",
			null, "associated"));	

			sb = new StringBuilder("Silverman DN, Plante TB, Infeld M, Callas PW, Juraschek SP, Dougherty GB, Meyer M. ");
			sb.Append("Association of β-Blocker Use With Heart Failure Hospitalizations and Cardiovascular Disease Mortality Among Patients With Heart Failure With a Preserved Ejection Fraction: A Secondary Analysis of the TOPCAT Trial. ");
			sb.Append("JAMA Netw Open 2019 Dec 2;2(12):e1916598.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31800067", "08986735b8434bd08e06370c3d93f1c0",
			null, "associated"));	
			
			sb = new StringBuilder("Sperry BW, Tang Y, Jones PG, Spertus JA. ");
			sb.Append("Cumulative events in the TOPCAT trial. ");
			sb.Append("Eur J Heart Fail 2021 Mar;23(3):491-492. Epub 2020 Nov 13.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "33111482", "1828f5f23fd04cd19c183c43e27b728e",
			null, "associated"));	

			sb = new StringBuilder("Tromp J, Shen L, Jhund PS, Anand IS, Carson PE, Desai AS, Granger CB, Komajda M, McKelvie RS, Pfeffer MA, Solomon SD, Køber L, Swedberg K, Zile MR, Pitt B, Lam CSP, McMurray JJV. ");
			sb.Append("Age-Related Characteristics and Outcomes of Patients With Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("J Am Coll Cardiol 2019 Aug 6;74(5):601-612.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31370950", "06238be0b368495b9903242fcf1c9179", 
			null, "associated"));	

			sb = new StringBuilder("Tsujimoto T, Kajio H. ");
			sb.Append("Abdominal Obesity Is Associated With an Increased Risk of All-Cause Mortality in Patients With HFpEF. ");
			sb.Append("J Am Coll Cardiol 2017 Dec 5;70(22):2739-2749.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29191321", "ad4e37c47281419d9a7d665e2e8891e7",
			null, "associated"));	
			
			sb = new StringBuilder("Tsujimoto T, Kajio H. ");
			sb.Append("Beta-blocker use and cardiovascular event risk in patients with heart failure with preserved ejection fraction. ");
			sb.Append("Sci Rep 2018 Jun 22;8(1):9556.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29934526", "97126373eb124a7d8ef184cd7eb66be3",
			null, "associated"));	

			sb = new StringBuilder("Tsujimoto T, Kajio H. ");
			sb.Append("Efficacy of renin-angiotensin system inhibitors for patients with heart failure with preserved ejection fraction and mild to moderate chronic kidney disease. ");
			sb.Append("Eur J Prev Cardiol 2018 Aug;25(12):1268-1277. Epub 2018 May 29.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29808753", "3d77789898d04c7d9ef3a81f2328bd71",
			null, "associated"));	

			sb = new StringBuilder("Tsujimoto T, Kajio H. ");
			sb.Append("Favorable effects of statins in the treatment of heart failure with preserved ejection fraction in patients without ischemic heart disease. ");
			sb.Append("Int J Cardiol 2018 Mar 15;255:111-117. Epub 2018 Jan 4.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29307549", "2cad4907ad5d484b9196429acd119c4d",
			null, "associated"));	

			sb = new StringBuilder("Tsujimoto T, Kajio H. ");
			sb.Append("Low diastolic blood pressure and adverse outcomes in heart failure with preserved ejection fraction. ");
			sb.Append("Int J Cardiol 2018 Jul 15;263:69-74. Epub 2018 Apr 9.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29661477", "c0be4e71b51c40558741fc4b8c14d9fc",
			null, "associated"));	

			sb = new StringBuilder("Tsujimoto T, Kajio H. ");
			sb.Append("Spironolactone Use and Improved Outcomes in Patients With Heart Failure With Preserved Ejection Fraction With Resistant Hypertension. ");
			sb.Append("J Am Heart Assoc 2020 Dec;9(23):e018827. Epub 2020 Nov 23.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "33222584", "f5c623bda2f34f8089c85dee29939f28",
			null, "associated"));	

			sb = new StringBuilder("Tsujimoto T, Kajio H. ");
			sb.Append("Use of Nitrates and Risk of Cardiovascular Events in Patients With Heart Failure With Preserved Ejection Fraction. ");
			sb.Append("Mayo Clin Proc 2019 Jul;94(7):1210-1220.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31272569", "53d7f5e803b340e7b866ee2d73e58212",
			null, "associated"));	
	
			sb = new StringBuilder("Upshaw JN, van Klaveren D, Konstam MA, Kent DM. ");
			sb.Append("Digoxin Benefit Varies by Risk of Heart Failure Hospitalization: Applying the Tufts MC HF Risk Model. ");
			sb.Append("Am J Med 2018 Jun;131(6):676-683.e2. Epub 2017 Dec 25.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29284111", "d3131989c27542b69f5677172678ff0b",
			null, "associated"));	
			
			sb = new StringBuilder("Vaduganathan M, Claggett B, Packer M, McMurray JJV, Rouleau JL, Zile MR, Swedberg K, Solomon SD. ");
			sb.Append("Natriuretic Peptides as Biomarkers of Treatment Response in Clinical Trials of Heart Failure. ");
			sb.Append("JACC Heart Fail 2018 Jul;6(7):564-569. Epub 2018 Mar 4.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29501807", "71b226fd4cd84050a2a7a3038f1d0ef8",
			null, "associated"));	

			sb = new StringBuilder("Zhang Q, Zhou B, Ma Y, Hu Y, Li X, Cong H. ");
			sb.Append("Blood pressure visit-to-visit variability and outcomes in patients with heart failure with preserved ejection fraction. ");
			sb.Append("ESC Heart Fail 2021 Aug 18. Epub 2021 Aug 18.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "34405581", "cbbd736ad7264729a0f4ad1156ebc916",
			null, "associated"));	

			sb = new StringBuilder("Chen Z, Lin Q, Li J, Wang X, Ju J, Xu H, Shi D. ");
			sb.Append("Estimated Glomerular Filtration Rate Is Associated With an Increased Risk of Death in Heart Failure Patients With Preserved Ejection Fraction. ");
			sb.Append("Front Cardiovasc Med 2021 Apr 26;8:643358. doi: 10.3389/fcvm.2021.643358. eCollection 2021.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "33981733", "baf8058c0f8e4f308cb339df92eba820", 
			null, "associated"));	
			
			sb = new StringBuilder("Leache L, Gutiérrez-Valencia M, Finizola RM, Infante E, Finizola B, Pardo Pardo J, Flores Y, Granero R, Arai KJ. ");
			sb.Append("Pharmacotherapy for hypertension-induced left ventricular hypertrophy. ");
			sb.Append("Cochrane Database Syst Rev 2021 Oct 10;10:CD012039.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "34628642", "3043299287ab40708aa9a1055f3801db", 
			null, "associated"));	

			sb = new StringBuilder("Wang X, Ju J, Chen Z, Lin Q, Zhang Z, Li Q, Zhang J, Xu H, Chen K.");
			sb.Append("Associations between Calcium Channel Blockers Therapy and Mortality in Heart Failure with Preserved Ejection Fraction. ");
			sb.Append("Eur J Prev Cardiol 2022 Jan 7. Epub 2022 Jan 7.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "35015840", "58253719c16e4620bea2a69d14bb15ae", 
			null, "associated"));	
			
			// Data Objects
	        
			// 1) Trial registry entry

			string sd_oid = sd_sid + " :: 38 :: NHLBI web page";
			string ob_title = display_title + " :: NHLBI web page";
			StudyDataObject sdo = CreateEmptyStudyDataObject();
            
			sdo.data_object = new DataObject(sd_oid, sd_sid, "NHLBI web page", null, ob_title,
				null, 9, null, 23, 38, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 12, null, null, 0, true, true);
	       
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/studies/topcat/", true, 35, null, null, null));
	        
			fs.data_objects!.Add(sdo);
			
			// 2) Datasets
	        
			sd_oid = sd_sid + " :: 80 :: Individual participant data";
			ob_title = display_title + " :: Individual participant data";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Individual participant data", null, ob_title,
				null, 9, 2019, 14, 80, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 17, asb.ToString(), 
				"https://biolincc.nhlbi.nih.gov/media/guidelines/handbook.pdf?link_time=2019-12-13_11:33:44.807479#page=15",
				3, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));

			string res_constraints = "Consent for the use of biospecimens in genetic research is tiered to (1) research related to heart disease, stroke, kidney diseases, ";
			res_constraints += "other cardiovascular diseases, or risk factors associated with these diseases and (2) research related to any disease, health condition or risk factors. ";
			res_constraints += "Use of biospecimens in non-genetic research is unrestricted.";
			
			sdo.dataset_details = new ObjectDataset(sd_oid, null, null, 2, null, null, null, null, null,
				dsb.ToString(), 6, null, null, null, null, null, res_constraints);
	        
			sdo.object_dates!.Add(new ObjectDate(sd_oid, 18, false, "2019 Feb 2", 2019, 2, 20, null, null, null, null));
	        
			fs.data_objects!.Add(sdo);
			
			
			// 3) Data Dictionary
	        
			sd_oid = sd_sid + " :: 31 :: Data Dictionary";
			ob_title = display_title + " :: Data Dictionary";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Data Dictionary", null, ob_title,
				null, 9, null, 23, 31, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/media/studies/topcat/data_dictionary/TOPCAT_v2016b.pdf",
				true, 11, "795.3", "KB", null));
	        
			fs.data_objects!.Add(sdo);

			// 4) Protocols
	        
			sd_oid = sd_sid + " :: 11 :: Protocols";
			ob_title = display_title + " :: Protocols";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Protocols", null, ob_title,
				null, 9, null, 23, 11, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/media/studies/topcat/Protocols.pdf",
				true, 11, "1.8", "MB", null));
	        
			fs.data_objects!.Add(sdo);
			
			// 5) CRF Forms
	        
			sd_oid = sd_sid + " :: 21 :: Forms";
			ob_title = display_title + " :: Forms";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Forms", null, ob_title,
				null, 9, null, 23, 36, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/media/studies/topcat/Forms.pdf",
				true, 11, "5.3", "MB", null));
	        
			fs.data_objects!.Add(sdo);
			
			// 6) Manual of Operations
	        
			sd_oid = sd_sid + " :: 35 :: Manual of Operations";
			ob_title = display_title + " :: Manual of Operations";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Manual of Operations", null, ob_title,
				null, 9, null, 23, 35, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/media/studies/omniheart/MOP.pdf",
				true, 11, "1.8", "MB", null));
	        
			fs.data_objects!.Add(sdo);

			return fs;
        }
        
        
        if (sd_sid == "ACRN-LARGE")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "Asthma Clinical Research Network (ACRN) Trial - Long-Acting Beta Agonist Response by Genotype (LARGE)";
	        StringBuilder sb = new StringBuilder("Objectives: The purpose of this trial was to determine whether regularly scheduled use of an inhaled long-acting ");
	        sb.Append("beta agonist (salmeterol) in the setting of concomitant use of inhaled corticosteroids (beclomethasone hydroflouroalkane (HFA) inhaler) "); 
	        sb.Append("would have a detrimental effect on asthma control in people who bear the B16 Arg/Arg genotype of the beta-2 adrenergic receptor "); 
	        sb.Append("gene, as compared to people with asthma of similar severity who bear the B16 Gly/Gly genotype."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2004, 12, 11, 21, null, 915,
		        null, null, null, null, 0);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT00200967", 11, 100120, 
		        "ClinicalTrials.gov", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "HLB01021313a", 42, 100167, 
		        "National Heart, Lung, and Blood Institute", "https://ror.org/012pb6c26", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, 
		        "Asthma Clinical Research Network Trial (ACRN) - Long-Acting Beta Agonist Response by Genotype (LARGE)", 
		        18, "en", 11, false, "From BioLINCC web page"));
	        fs.titles.Add(new StudyTitle(sd_sid, "ACRN-LARGE", 14, "en", 11, false, "From BioLINCC web page"));

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100375, "Milton S Hershey Medical Center", 
		        "https://ror.org/01h22ap11"));

			fs.references!.Add(new StudyReference(sd_sid, null, "19932356", 
			     "https://www.ncbi.nlm.nih.gov/pubmed/19932356", null, "primary"));	
			
			
			// Data Objects
	        
			// 1) Trial registry entry

			string sd_oid = sd_sid + " :: 38 :: NHLBI web page";
			string ob_title = display_title + " :: NHLBI web page";
			StudyDataObject sdo = CreateEmptyStudyDataObject();
            
			sdo.data_object = new DataObject(sd_oid, sd_sid, "NHLBI web page", null, ob_title,
				null, 9, null, 23, 38, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 12, null, null, 0, true, true);
	       
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/studies/large/", true, 35, null, null, null));
	        
			fs.data_objects!.Add(sdo);

			
			// 2) Datasets
	        
			sd_oid = sd_sid + " :: 80 :: Individual participant data";
			ob_title = display_title + " :: Individual participant data";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Individual participant data", null, ob_title,
				null, 9, 2018, 14, 80, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 17, asb.ToString(), 
				"https://biolincc.nhlbi.nih.gov/media/guidelines/handbook.pdf?link_time=2019-12-13_11:33:44.807479#page=15",
				3, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
			
			sdo.dataset_details = new ObjectDataset(sd_oid, null, null, 2, null, null, null, null, null,
				dsb.ToString(), null, null, null, null, null, null, null);
	        
			sdo.object_dates!.Add(new ObjectDate(sd_oid, 18, false, "2018 Jan 3", 2018, 1, 3, null, null, null, null));
	        
			fs.data_objects!.Add(sdo);
			
			// 3) Data Dictionary
	        
			sd_oid = sd_sid + " :: 31 :: Data Dictionary";
			ob_title = display_title + " :: Data Dictionary";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Data Dictionary", null, ob_title,
				null, 9, null, 23, 31, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/media/studies/large/data_dictionary/ACRN_LARGE_accessible.pdf",
				true, 11, "508.2", "KB", null));
	        
			fs.data_objects!.Add(sdo);
			
			// 4) Protocol
	        
			sd_oid = sd_sid + " :: 11 :: Protocol";
			ob_title = display_title + " :: Protocol";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Protocol", null, ob_title,
				null, 9, null, 23, 11, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/media/studies/large/Protocol.pdf",
				true, 11, "631.0", "KB", null));
	        
			fs.data_objects!.Add(sdo);
			
			// 5) CRF Forms
	        
			sd_oid = sd_sid + " :: 21 :: Forms";
			ob_title = display_title + " :: Forms";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Forms", null, ob_title,
				null, 9, null, 23, 36, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/media/studies/large/Forms.pdf",
				true, 11, "3.3", "MB", null));
	        
			fs.data_objects!.Add(sdo);

			return fs;
        }
        
        
        if (sd_sid == "OMNI Heart")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 
	        
	        string display_title = "OmniHeart Trial: Macronutrients and Cardiovascular Risk";
	        StringBuilder sb = new StringBuilder("Objectives: The objective of this study was to compare the effects of 3 healthy diets, each with ");
	        sb.Append("reduced saturated fat intake, on blood pressure and serum lipids."); 
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2002, null, 11, 21, null, 915,
		        null, null, 35, 17, 0);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT00051350", 11, 100120, 
		        "ClinicalTrials.gov", null, null, null));
	        fs.identifiers.Add(new StudyIdentifier(sd_sid, "HLB00831119a", 42, 100167, 
		        "National Heart, Lung, and Blood Institute", "https://ror.org/012pb6c26", null, null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, 
		        "Optimal Macronutrient Intake Trial to Prevent Heart Disease (OMNI Heart)", 
		        18, "en", 11, false, "From BioLINCC web page"));
	        fs.titles.Add(new StudyTitle(sd_sid, "OMNI Heart", 14, "en", 11, false, "From BioLINCC web page"));

	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 100190, "Johns Hopkins University", 
		        "https://ror.org/00za53h95"));
	        
            sb = new StringBuilder("Belanger MJ, Wee CC, Mukamal KJ, Miller ER, Sacks FM, Appel LJ, Shmerling RH, Choi HK, Juraschek SP. ");
			sb.Append("Effects of dietary macronutrients on serum urate: results from the OmniHeart trial. ");
			sb.Append("Am J Clin Nutr 2021 Jun 1;113(6):1593-1599.");
			fs.references!.Add(new StudyReference(sd_sid, sb.ToString(), "33668058", "7a090a34f4b94456baf6385d5c30a659", 
			null, "associated"));	
				
			sb = new StringBuilder("Joyce R, Kuziene V, Zou X, Wang X, Pullen F, Loo RL. ");
			sb.Append("Development and validation of an ultra-performance liquid chromatography quadrupole time of flight mass spectrometry method for rapid quantification of free amino acids in human urine. ");
			sb.Append("Amino Acids 2016 Jan;48(1):219-34. Epub 2015 Aug 29.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "26319643", "f757a16569e544228dfd47f40b22af56",
			 null, "associated"));	
			
			sb = new StringBuilder("Kovell LC, Yeung EH, Miller ER 3rd, Appel LJ, Christenson RH, Rebuck H, Schulman SP, Juraschek SP. ");
			sb.Append("Healthy diet reduces markers of cardiac injury and inflammation regardless of macronutrients: Results from the OmniHeart trial. ");
			sb.Append("Int J Cardiol 2020 Jan 15;299:282-288. Epub 2019 Aug 2.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "31447226", "2a37ef1e774941389fe206248e3876d4", 
			null, "associated"));	
			
			sb = new StringBuilder("Loo RL, Zou X, Appel LJ, Nicholson JK, Holmes E. ");
			sb.Append("Characterization of metabolic responses to healthy diets and association with blood pressure: application to the Optimal Macronutrient Intake Trial for Heart Health (OmniHeart), a randomized controlled study. ");
			sb.Append("Am J Clin Nutr 2018 Mar 1;107(3):323-334.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29506183", "149fb8f76e544e18a18a2166b27b9383",
			 null, "associated"));	
						 
			sb = new StringBuilder("Pino EC, Zuo Y, Maciel De Olivera C, Mahalingaiah S, Keiser O, Moore LL, Li F, Vasan RS, Corkey BE, Kalesan B. ");
			sb.Append("Cohort profile: The MULTI sTUdy Diabetes rEsearch (MULTITUDE) consortium. ");
			sb.Append("BMJ Open 2018 May 5;8(5):e020640.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29730626", "57c4fb1fade649fe8fd8fb09429c198c", 
			null, "associated"));	
						 
			sb = new StringBuilder("Rebholz CM, Lichtenstein AH, Zheng Z, Appel LJ, Coresh J. ");
			sb.Append("Serum untargeted metabolomic profile of the Dietary Approaches to Stop Hypertension (DASH) dietary pattern. ");
			sb.Append(" Am J Clin Nutr 2018 Aug 1;108(2):243-255.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "29917038", "144d2d4a99644a998205066f7ae04f2e", 
			null, "associated"));	
						 
			sb = new StringBuilder("Root MM, Dawson HR. DA");
			sb.Append("DASH-like diets high in protein or monounsaturated fats improve metabolic syndrome and calculated vascular risk. ");
			sb.Append("Int J Vitam Nutr Res 2013;83(4):224-31.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "25008012", "956221f4f14547a2a002199e602995d8", 
			null, "associated"));	
						 
			sb = new StringBuilder("Zou X, Holmes E, Nicholson JK, Loo RL. ");
			sb.Append("Automatic Spectroscopic Data Categorization by Clustering Analysis (ASCLAN): A Data-Driven Approach for Distinguishing Discriminatory Metabolites for Phenotypic Subclasses. ");
			sb.Append("Anal Chem 2016 Jun 7;88(11):5670-9. Epub 2016 May 13.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "27149575", "94a4db08ad744b69b013926b1bad7b0e", 
			null, "associated"));	
						 
			sb = new StringBuilder("Zou X, Holmes E, Nicholson JK, Loo RL. ");
			sb.Append("Statistical HOmogeneous Cluster SpectroscopY (SHOCSY): an optimized statistical approach for clustering of ¹H NMR spectral data to reduce interference and enhance robust biomarkers selection. ");
			sb.Append("Anal Chem 2014 Jun 3;86(11):5308-15. Epub 2014 May 13.");
			fs.references.Add(new StudyReference(sd_sid, sb.ToString(), "24773160", "41a5c5c2140c40309fc7e00a3f79f201", 
			null, "associated"));	
						 
			// Data Objects
	        
			// 1) Trial registry entry

			string sd_oid = sd_sid + " :: 38 :: NHLBI web page";
			string ob_title = display_title + " :: NHLBI web page";
			StudyDataObject sdo = CreateEmptyStudyDataObject();
            
			sdo.data_object = new DataObject(sd_oid, sd_sid, "NHLBI web page", null, ob_title,
				null, 9, null, 23, 38, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 12, null, null, 0, true, true);
	       
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/studies/omniheart/", true, 35, null, null, null));
	        
			fs.data_objects!.Add(sdo);

			// 2) Datasets
	        
			sd_oid = sd_sid + " :: 80 :: Individual participant data";
			ob_title = display_title + " :: Individual participant data";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Individual participant data", null, ob_title,
				null, 9, 2019, 14, 80, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 17, asb.ToString(), 
				"https://biolincc.nhlbi.nih.gov/media/guidelines/handbook.pdf?link_time=2019-12-13_11:33:44.807479#page=15",
				3, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
			
			sdo.dataset_details = new ObjectDataset(sd_oid, null, null, 2, null, null, null, null, null,
				dsb.ToString(), 6, null, null, null, null, null, 
				"Consent restricts use of biospecimens to non-genetic research related to CVD or nutrition.");
	        
			sdo.object_dates!.Add(new ObjectDate(sd_oid, 18, false, "2019 Jan 24", 2019, 1, 24, null, null, null, null));
	        
			fs.data_objects!.Add(sdo);
			
			
			// 3) Data Dictionary
	        
			sd_oid = sd_sid + " :: 31 :: Data Dictionary";
			ob_title = display_title + " :: Data Dictionary";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Data Dictionary", null, ob_title,
				null, 9, null, 23, 31, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/media/studies/omniheart/data_dictionary/OMNI_Heart_2019a.pdf",
				true, 11, "296.7", "KB", null));
	        
			fs.data_objects!.Add(sdo);
			
			// 4) Protocol
	        
			sd_oid = sd_sid + " :: 11 :: Protocol";
			ob_title = display_title + " :: Protocol";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "Protocol", null, ob_title,
				null, 9, null, 23, 11, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/media/studies/omniheart/Protocol.pdf",
				true, 11, "987.0", "KB", null));
	        
			fs.data_objects!.Add(sdo);
			
			// 5) Manual of Procedures
	        
			sd_oid = sd_sid + " :: 36 :: MOP";
			ob_title = display_title + " :: MOP";
			sdo = CreateEmptyStudyDataObject();
	        
			sdo.data_object = new DataObject(sd_oid, sd_sid, "MOP", null, ob_title,
				null, 9, null, 23, 36, 100167, "National Heart, Lung, and Blood Institute", 
				"https://ror.org/012pb6c26", "en", 11, null, null, 0, true, true);
			sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 21, "en", 11, true, null));
	        
			sdo.object_instances!.Add(new ObjectInstance(sd_oid, 101900, "BioLINCC", 
				"https://biolincc.nhlbi.nih.gov/media/studies/omniheart/MOP.pdf",
				true, 11, "1.1", "MB", null));
	        
			fs.data_objects!.Add(sdo);

			return fs;

        }
        
        return null;
    }
}