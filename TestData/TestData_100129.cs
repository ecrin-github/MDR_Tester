using System.Text;

namespace MDR_Tester;

public class TestData_100129 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "PER-015-19")
        {
	        FullStudy fs = CreateEmptyFullStudy();
             
            // Study 
            string display_title = "STUDY OF EFFICACY AND SAFETY OF PEMBROLIZUMAB PLUS PLATINUM-BASED DOUBLET CHEMOTHERAPY WITH OR WITHOUT CANAKINUMAB IN PREVIOUSLY ";
            display_title += "UNTREATED LOCALLY ADVANCED OR METASTATIC NON-SQUAMOUS AND SQUAMOUS NSCLC SUBJECTS";
            StringBuilder sb = new StringBuilder("Interventions: Group name:01 Type of group;1 N° of participants:300 Intervention(s) description:Canakinumab\n");
            sb.Append("(ACZ885)\nSolution for s.c. injection\nin prefilled syringe\nStrength:150 mg/1 mL AND\n50 mg/0.5 mL\nDose:200 mg\nFrequency: Q3W (or Q6W)\n\n"); 
            sb.Append("Group name:02 Type of group;1 N° of participants:300 Intervention(s) description:Canakinumab\n"); 
            sb.Append("(ACZ885)\nSolution for s.c. injection\nin prefilled syringe\nStrength:0 mg/1 mL AND\n0 mg/0.5 mL\nDose: 0 mg\nFrequency: Q3W (or Q6W)\n"); 
            sb.Append("Primary outcome(s): Outcome name:Kaplan-Meier method\nMeasure:Progression Free Survival and Overall Survival\n"); 
            sb.Append("Timepoints:FS is defined as the time from the date of randomization to the date of the first documented disease progression\n"); 
            sb.Append("Study Design: This is a double-blind, randomized, multicenter phase III study evaluating the efficacy and safety of canakinumab vs. "); 
            sb.Append("canakinumab vs. canakinumab matching-placebo in combination with pembrolizumab in addition to 4 cycles of platinum-based doublet "); 
            sb.Append("induction chemotherapy, followed by maintenance therapy in subjects with AJCC v. 8 stage IIIB (not eligible for definite "); 
            sb.Append("chemoradiation therapy) or stage IV (metastatic) NSCLC regardless of PD-L1 levels and histology (squamous and non-squamous). "); 
            sb.Append("Subjects who completed 4 cycles of induction treatment and fulfill eligibility criteria as defined in Section 6.1.4.1 will enter "); 
            sb.Append("the maintenance treatment phase. For dosing regimen, please refer to Section 6.1.3 .\n"); 
            sb.Append("Peru :Participate on part 2 :\n\n"); 
            sb.Append("Part 2: Double-blind, randomized, placebo-controlled part\n"); 
            sb.Append("Once the RP3R for canakinumab in combination with pembrolizumab and platinum-based\n"); 
            sb.Append("doublet chemotherapy is confirmed in the safety run-in part, the double-blind, randomized,pla"); 
            string brief_desc = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2019, 9, 11, 21, null, 915,
	            null, null, null, null, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100129, 
                "Registro Peruano de Ensayos Clínicos", null, "2019 Sep 18", null));
            fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT03631199", 11, 100120, 
	            "Clinicaltrials.gov", null, null, null));
            fs.identifiers!.Add(new StudyIdentifier(sd_sid, "2018-001547-32", 11, 100123, 
	            "EU Clinical Trials Register", null, null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Registro Peruano de Ensayos Clínicos"));
            string title = "A RANDOMIZED, DOUBLE-BLIND, PLACEBO-CONTROLLED, PHASE III STUDY EVALUATING THE EFFICACY AND SAFETY OF PEMBROLIZUMAB PLUS ";
            title +=
	            "PLATINUM-BASED DOUBLET CHEMOTHERAPY WITH OR WITHOUT CANAKINUMAB AS FIRST LINE THERAPY FOR LOCALLY ADVANCED OR METASTATIC NON-SQUAMOUS ";
            title +=
	            "AND SQUAMOUS NON-SMALL CELL LUNG CANCER SUBJECTS (CANOPY-1)";
            fs.titles.Add(new StudyTitle(sd_sid, title, 16, "en", 11, false, "From the Registro Peruano de Ensayos Clínicos"));
	        
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Hedwig Schmidt", "NOVARTIS BIOSCIENCES PERU SA", 
	            null, "NOVARTIS BIOSCIENCES PERU SA", null));
            fs.people!.Add(new StudyPerson(sd_sid, 56, "Jose Ortiz", "NOVARTIS BIOSCIENCES PERU SA", 
	            null, "NOVARTIS BIOSCIENCES PERU SA", null));
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "NOVARTIS BIOSCIENSES PERU SA", null));
            
            fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 205));   // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 510));   // 
	        
            fs.conditions!.Add(new StudyCondition(sd_sid, "Malignant neoplasm of oropharynx", 
	            12, "C10", "2B6A", "Malignant neoplasm of oropharynx"));      

            // countries
            
            // iec
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: Peruvian registry web page";
            string ob_title = display_title + " :: Peruvian registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Peruvian registry web page", null, ob_title,
	            null, 9, 2019, 23, 13, 100129, "Registro Peruano de Ensayos Clínicos", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100129, "Registro Peruano de Ensayos Clínicos", 
	            "https://www.ins.gob.pe/ensayosclinicos/rpec/recuperarECPBNuevoEN.asp?numec=015-19", 
	            true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2019 Sep 18", 2019, 9, 18, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Mar 22", 2022, 3, 22, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        return null;
    }
}