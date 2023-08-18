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
            sb.Append("One group will consist of healthy lean male subjects. The other group will consist of obese male subjects. \nAll subjects will "); 
            sb.Append("receive both the test protein and the placebo, administered either orally or intraduodenally, depending on the test day. "); 
            sb.Append("Delievery of the protein and placebo into the duodenum will be through a feeding tube."); 
            sb.Append("\n- Oral ingestion placebo\n- Oral ingestion protein\n- Duodenal administration placebo\n- Duodenal administration protein\n"); 
            sb.Append("All conditions are randomized over 4 test days\n- Gastroscopy on the 5h test day\n"); 
            sb.Append("Primary outcome(s): The effects of orally- and intraduodenally administered intact protein on systemic satiety hormone levels "); 
            sb.Append("(CCK, GLP-1, and PYY) and feelings of hunger and satiety\n"); 
            sb.Append("Study Design: Randomized controlled trial, Single blinded (masking used), Placebo, Crossover"); 
            string brief_desc = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2008, 11, 11, 16, "24", 915,
	            null, null, null, null, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100132, 
                "Netherlands National Trial Register", null, "9 Sep 2008", null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "NTR1437", 45, 100132, 
	            "Netherlands National Trial Register", null, null, null));
            fs.identifiers.Add(new StudyIdentifier(sd_sid, "MEC08-3-058", 14, 
	            109762, "transnationale Universiteit Limburg", "https://ror.org/05f0rzm15", null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Netherlands National Trial Register"));

            fs.people!.Add(new StudyPerson(sd_sid, 51, "MCP Geraedts", "University of Maastricht, PO Box 616", 101223, "Universiteit Maastricht", "https://ror.org/02jz4aj89"));

            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 109762, "transnationale Universiteit Limburg", "https://ror.org/05f0rzm15"));

	        fs.features!.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features!.Add(new StudyFeature(sd_sid, 23, 310));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 505));   // 

            fs.conditions!.Add(new StudyCondition(sd_sid, 
	            "Obesity, dietary proteins, oral administration, duodenal administration, satiety", null, null, null, null));
           
           
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "1.", 1, "n.01", "Male, non smoking"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "2.", 1, "n.02", "Age between 18 and 65 years"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "3.", 1, "n.03", "Body Mass Index for lean subjects between 20 and 26 kg/m2"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr", "4.", 1, "n.04", "Body Mass Index for obese subjects between 30 and 37 kg/m2"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr", "5.", 1, "n.05", "No medication"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 6, 1, "cr", "6.", 1, "n.06", "No history of intestinal illness"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 7, 1, "cr", "7.", 1, "n.07", "Stable body weight over the last three months"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 1, "cr", "8.", 1, "n.08", "No blood donation 2 months prior to the study and during the study"));	    
            
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "1.", 1, "e.01", "Age under 18 and over 65 years"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "2.", 1, "e.02", "BMI under 20 and over 37 kg/m2"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "3.", 1, "e.03", "Medication or disease that could interfere with the results of the study, to be judged by the responsible medical doctor"));
            fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr", "4.", 1, "e.04", "Recent blood donation within 2 months prior to the start of the study"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr", "5.", 1, "e.05", "Intestinal illness at any time in the past"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr", "6.", 1, "e.06", "Female"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr", "7.", 1, "e.07", "Smokers"));	 
          
            fs.countries!.Add(new StudyCountry(sd_sid, 2750405, "Netherlands", null));
            
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
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "9 Sep 2008", 2008, 9, 9, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "3 Apr 2023", 2023, 4, 3, null, null, null, null));
	       
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
            sb.Append("Study Design: Randomized controlled trial, Open (masking not used), Active, Parallel"); 
            string brief_desc = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2020, 5, 11, 16, "40", 915,
	            null, null, null, null, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100132, 
                "Netherlands National Trial Register", null, "26 May 2020", null));
            fs.identifiers!.Add(new StudyIdentifier(sd_sid, "METC 2020-014", 12, 109116, 
	            "METC Amsterdam UMC", null, null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Netherlands National Trial Register"));

            fs.people!.Add(new StudyPerson(sd_sid, 51, "Thomas Oomens", "OLVG", 103380, "OLVG", "https://ror.org/01d02sf11"));

	        fs.features!.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 

            fs.conditions!.Add(new StudyCondition(sd_sid, "Coronary artery disease", null, null, "B1-BA8", 
	            "Diseases of coronary artery"));
           
           
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "•", 1, "n.01", "Age = 18 years"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "•", 1, "n.02", "An indication for PCI of a calcified lesion in a native coronary artery"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr", "•", 1, "n.03", "Main OCT criterium is a calcification score of 4 defined as maximum calcium angle of >180 degrees, maximum calcium thickness >0.5mm, and a minimal calcium length of 5mm, as measured at the target lesion"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr", "•", 1, "n.04", "Written informed consent with agreement of follow-up visits."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 5, 1, "cr", "•", 1, "n.05", "Eligible for PCI with a target vessel reference diameter between 2.5 and 4.0 mm (by visual estimation)."));	    
           
            fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr", "•", 1, "e.01", "Severe congestive heart failure, severe heart failure NYHA IV"));	       
            fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr", "•", 1, "e.02", "ST-elevation myocardial infarction as indication for PCI"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr", "•", 1, "e.03", "Severe renal impairment with a glomerular filtration rate of <30ml/min/1.73m2"));
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "•", 1, "e.04", "Lesion related exclusion criteria"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "•", 1, "e.05", "Stent occlusion / restenosis"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "•", 1, "e.06", "OCT images not fulfilling inclusion criteria"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr", "•", 1, "e.07", "Inability to cross the lesion with an OCT catheter"));	   
            fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr", "•", 1, "e.08", "Large side branch (>2.0mm) originating from the target lesion"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr", "•", 1, "e.09", "Contraindication for dual antiplatelet therapy."));	  
            fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr", "•", 1, "e.10", "Recent history of major bleeding, hematologic disease and/or platelet count < 100.000 per 1 mm3"));	   
            fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr", "•", 1, "e.11", "Planned major surgery within 3 months after the procedure."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr", "•", 1, "e.12", "Participation in another clinical study, interfering with this protocol."));	 
            fs.iec.Add(new StudyIEC(sd_sid, 18, 2, "cr", "•", 1, "e.13", "The inability to provide written informed consent."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 19, 2, "cr", "•", 1, "e.14", "Expected life expectancy of less than two years."));	 

            fs.countries!.Add(new StudyCountry(sd_sid, 2750405, "Netherlands", null));
	        
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
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "26 May 2020", 2020, 5, 26, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "3 Apr 2023", 2023, 4, 3, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
     
        }
   
        return null;
    }
}