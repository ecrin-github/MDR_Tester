using System.Text;

namespace MDR_Tester;

public class TestData_100132 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "NL1376")
        {
	        FullStudy fs = CreateEmptyFullStudy();
             
            // Study 
            
            string display_title = "The effects of orally and intraduodenally administered pea protein on satiety parameters in vivo in lean and obese subjects";
            StringBuilder sb = new StringBuilder("Interventions: This study is a randomized, placebo controlled cross-over study with 2 groups of volunteers. ");
            sb.Append("One group will consist of healthy lean male subjects. The other group will consist of obese male subjects. All subjects will "); 
            sb.Append("receive both the test protein and the placebo, administered either orally or intraduodenally, depending on the test day. "); 
            sb.Append("Delievery of the protein and placebo into the duodenum will be through a feeding tube.\n\n"); 
            sb.Append("- Oral ingestion placebo\n- Duodenal administration placebo\n- Duodenal administration protein\n"); 
            sb.Append("All conditions are randomized over 4 test days\n- Gastroscopy on the 5h test day\n"); 
            sb.Append("Primary outcome(s): The effects of orally- and intraduodenally administered intact protein on systemic satiety hormone levels "); 
            sb.Append("(CCK, GLP-1, and PYY) and feelings of hunger and satiety\n"); 
            sb.Append("Study Design: Randomized: No, \n"); 
            sb.Append("                        Masking: Single, \n                        Control: Placebo,\n  "); 
            sb.Append("                        Group: undefined,\n                        Type: 2 or more arms, randomized"); 
            string brief_desc = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2008, 11, 11, 16, "24", 915,
	            null, null, null, null, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100132, 
                "The Netherlands National Trial Register", null, "2008 Sep 9", null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "NTR1437", 45, 100132, 
	            "The Netherlands National Trial Register", null, null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Netherlands National Trial Register"));

            fs.people!.Add(new StudyPerson(sd_sid, 51, "MCP Geraedts", null, null, null, null));
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Transnational University Limburg", null));
           
	        fs.features!.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 505));   // 

            fs.conditions!.Add(new StudyCondition(sd_sid, 
	            "Obesity, dietary proteins, oral administration, duodenal administration, satiety", null, null, null, null));
            
            // countries
            
            // iec
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: Dutch registry web page";
            string ob_title = display_title + " :: Dutch registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Dutch registry web page", null, ob_title,
	            null, 9, 2008, 23, 13, 100132, "Netherlands National Trial Register", 
	            null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid,  100132, "Netherlands National Trial Register", 
	            "https://www.onderzoekmetmensen.nl/en/trial/28061", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 12, false, "2008 Sep 9", 2008, 9, 9, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Mar 28", 2022, 3, 28, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;

        }
        
        if (sd_sid == "NL8683")
        {
	        FullStudy fs = CreateEmptyFullStudy();
             
            // Study 
            
            string display_title = "EXpansion of stents after Intravascular lithoTripsy versus conventional predilatation in CALCified coronary arteries";
            StringBuilder sb = new StringBuilder("Interventions: Intravascular lithotripsy or balloon dilatation, followed by stenting with DES in all patients\n");
            sb.Append("Primary outcome(s): Stent expansion measured by OCT\n"); 
            sb.Append("Study Design: Randomized: No, \n "); 
            sb.Append("                        Masking: None, \n"); 
            sb.Append("                        Control: Active, \n"); 
            sb.Append("                        Group: undefined, \n"); 
            sb.Append("                        Type: 2 or more arms, randomized"); 
            string brief_desc = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2020, 5, 11, 16, "40", 915,
	            null, null, null, null, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100132, 
                "The Netherlands National Trial Register", null, "2020 May 26", null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Netherlands National Trial Register"));

            fs.people!.Add(new StudyPerson(sd_sid, 51, "Thomas Oomens", null, null, null, null));
            
	        fs.features!.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 

            fs.conditions!.Add(new StudyCondition(sd_sid, "Coronary artery disease", null, null, "B1-BA8", 
	            "Diseases of coronary artery"));
            
            // countries
            
            // iec
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: Dutch registry web page";
            string ob_title = display_title + " :: Dutch registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Dutch registry web page", null, ob_title,
	            null, 9, 2020, 23, 13, 100132, "Netherlands National Trial Register", 
	            null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid,  100132, "Netherlands National Trial Register", 
	            "https://www.onderzoekmetmensen.nl/en/trial/22538", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2020 May 26", 2008, 5, 26, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Mar 28", 2022, 3, 28, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
     
        }
   
        return null;
    }
}