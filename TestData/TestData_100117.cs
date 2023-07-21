using System.Text;

namespace MDR_Tester;

public class TestData_100117 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "RBR-386rm8")
        {
	        FullStudy fs = CreateEmptyFullStudy();
	        
	        // Study 
	        
            string display_title = "Effects of Electro-stimulation combined with Blood Flow Restriction affected by spinal injury muscles.";
	        StringBuilder sb = new StringBuilder("Interventions: The intervention (training) consists of two protocols: blood flow restriction and functional electrostimulation. \n\n");
	        sb.Append("Combined Group: The two techniques were applied to 9 individuals (right thigh + left thigh = N-18), totaling 16 training sessions over 8 weeks.\n\n");
	        sb.Append("Individual Group: Applied only functional electro-stimulation in 7 individuals (right thigh + left thigh - N-14), totaling 16 training sessions over 8 weeks.\n");
	        sb.Append("The intervention (training) consists of two protocols: blood flow restriction and functional electrostimulation.\n\n");
	        sb.Append("INTERVENTION DESCRIPTION:\n\nBlood flow restriction (BFR):\n\n");
	        sb.Append("The BFR was applied using a sphygmomanometer (25 cm wide x 92 cm long) placed around the thigh immediately below the inguinal crease. ");
	        sb.Append("The BFR pressure for the training of each participant in the FES + BFR group was sufficient to interrupt the auscultatory pulse from tibial artery, ");
	        sb.Append("as was measured by a vascular Doppler device (DV-600, Martec, Ribeirão Preto, São Paulo). The training pressure was established to be 50% of the ");
            sb.Append("pressure obtained in the test, which has been shown to be effective in producing increases in thigh muscle mass (LAURENTINO et al., 2012). ");
            sb.Append("The average training pressure was 65.2 ± 7 mmHg. The pressure of the sphygmomanometer was maintained throughout the protocol of each session, ");
            sb.Append("including the intervals between series. The total time under pressure was approximately 15 minutes. No reported adverse reactions (e.g., ");
            sb.Append("dizziness or headache) were reported.<br><br>Functional electrostimulation protocol (FES)<br><br>Functional electro-stimulation (FES) was applied ");
            sb.Append("with the participants sitting in their own wheelchairs, with their hips and knees flexed at approximately 80° and 30°, respectively. Successive ");
            sb.Append("contractions were evoked unilaterally thro;Other;E02.331.800");
            sb.Append("Primary outcome(s): 1- Expected primary outcome:\nChronic increases in muscle mass measurement in the combined training group are expected to be ");
            sb.Append("significantly higher than the measurements in the individual group. It will be verified by the ultrasound technique, during the period of 8 weeks.;");
            sb.Append("1- Primary outcome found:\nChronic increases in muscle mass measurements (11.7% = 2.67cm) in the combined training group significantly higher than ");
            sb.Append("the measurements in the individual group (non-significant values), using the ultrasound technique, during the 8-week period.;2- Expected primary ");
            sb.Append("outcome:\nIt is expected to find sharp increases in the measurement of muscle mass in the combined training group, significantly higher than the ");
            sb.Append(" measurements in the individual group. It will be checked by ultrasound technique, before exercise and 5 minutes after the first training session.;");
            sb.Append("2- Primary outcome found:\nAcute increases in muscle mass measurements (19.7% = 2.79cm) in the combined training group are significantly higher ");
            sb.Append("than the values of the individual group (7.6% = 2.68cm), using the ultrasound technique, assessed before exercise and 5 minutes after the first ");
            sb.Append("raining session.;3- Expected primary outcome:\nIt is expected to find sharp increases in the measure of edema in the combined training group ");
            sb.Append("significantly higher than the measures in the individual group. It will be checked by the echo intensity technique, before exercise and 5 minutes ");
            sb.Append("after the first training session.;3- Primary outcome found:\nAcute increases in edema measurements (34.8% = 15 arbitrary units) in the combined ");
            sb.Append("training group are significantly higher than the values of the individual group (10.5% = 4 arbitrary units), using the echo intensity technique, ");
            sb.Append("assessed before the exercise and 5 minutes after the first training session.;4- Expected primary outcome:\nIt is expected to find chronic increases ");
            sb.Append("in the measure of edema in the combined training group, significantly higher than the measures of the individual group. It will be verified by the ");
            sb.Append("echo intensity technique, during the period of 8 weeks.;4- Primary outcome found:\nChronic increases in edema measurements (5.1% = 2 arbitrary units) ");
            sb.Append("in the combined training group are not significantly higher than the values of the individual group (non-significant values). Checked by the echo ");
            sb.Append("intensity technique, over a period of 8 weeks.");
	        sb.Append("Study Design: Clinical intervention / training trial, controlled/randomized, parallel, open with two arms.");
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2015, 12, 11, 21, null, 910,
		        null, null, null, null, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100117, 
		             "Registro Brasileiro de Ensaios Clínicos", null, "2020 Oct 31", null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
		                             "From the Brazilian Clinical Trials Registry"));
	        fs.titles.Add(new StudyTitle(sd_sid, 
		        "Effect of Neuromuscular Electrostimulation combined with Blood Flow Restriction on muscle thickness and reflex responses in people with spinal cord injury.", 
		        16, "en", 11, false, "From the Brazilian Clinical Trials Registry"));
    
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1001, "none", "All", 0, "n.0A", "Men volunteers with complete spinal cord injury (ASIA A) and eligible for quadriceps responsiveness."));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 2, "cr assumed", "@", 1, "e.01", "Cauda equina injury;"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 2, "cr assumed", "@", 1, "e.02", "spinal shock;"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 2, "cr assumed", "@", 1, "e.03", "venous thrombosis;"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr assumed", "@", 1, "e.04", "autonomic dysreflexia;"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr assumed", "@", 1, "e.05", "vascular complications;"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr assumed", "@", 1, "e.06", "pressure ulcers;"));	 
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.07", "osteoporosis;"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.08", "recent fracture;"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr assumed", "@", 1, "e.09", "implants and femur metal pins and two consecutive absences to the training sessions as well."));	
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Gabriel", "Skiba", "Gabriel Skiba", null,
		        "Universidade Federal do Paraná",  105883, "Federal University of Paraná", "https://ror.org/05syd6y78"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, 105883, "Federal University of Paraná", "https://ror.org/05syd6y78"));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 105883, "Federal University of Paraná", "https://ror.org/05syd6y78"));
            
	        fs.conditions!.Add(new StudyCondition(sd_sid, "Spinal cord injuries", null, null, null, null));
	        fs.conditions.Add(new StudyCondition(sd_sid, "C10.228. 854.763", null, null, null, null));
	        
	        fs.features!.Add(new StudyFeature(sd_sid, 22, 205));  // Randomised
	        fs.features.Add(new StudyFeature(sd_sid, 23, 305));  // 	  
	        
	        fs.countries!.Add(new StudyCountry(sd_sid, 3469034, "Brazil", null));
        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: Brazilian registry web page";
	        string ob_title = display_title + " :: Brazilian registry web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
       
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Brazilian registry web page", null, ob_title,
		        null, 9, 2020, 23, 13, 100117, "Registro Brasileiro de Ensaios Clínicos",
		        null, "en", 12, null, null, 0, true, true);
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100117, "Registro Brasileiro de Ensaios Clínicos", 
		        "http://ensaiosclinicos.gov.br/rg/RBR-386rm8", true, 35, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2020 Oct 31", 2020, 10, 31, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2023 May 29", 2023, 5, 29, null, null, null, null));
	       
	        fs.data_objects!.Add(sdo);

	        return fs;

        }
        
        if (sd_sid == "RBR-5cqndz")
        {
	        FullStudy fs = CreateEmptyFullStudy();

	        // Study 	 
	        
            string display_title = "The effects of Pain Neuroscience Eucation and Pilates on kinesiophobia in older people with chronic low back pain: randomized controlled clinical study";
	        StringBuilder sb = new StringBuilder("Interventions: The older people participants will be divided into two groups being the Control Group (CG), ");
	        sb.Append("who will participate in 16 classes of the Pilates Method solo, 2 times a week, totaling 8 weeks, lasting 1 hour each and ");
	        sb.Append("the Intervention Group (IG) that will first participate in 3 sessions of Pain Neuroscience Education, taught individually ");
	        sb.Append("with intervals of 1 or 2 days between them, lasting 30 minutes each, and soon thereafter, 16 Pilates Method classes in the ");
	        sb.Append("same models of the Control Group, and Pilates classes are taught in groups of 5 people. Both the GC and the GI will ");
	        sb.Append("consist of 40 people each.;Other;E02.779.474;I02.233.332");
	        sb.Append("Primary outcome(s): It’s expected that all variables in both groups will be improved, but it will be more significant in ");  
	        sb.Append("the Intervention Group, after the application of Pain Neuroscience Education.\nPresentation of expected outcome: Kinesiophobia\n");   
	        sb.Append("Presentation of the method used to verify the outcome: Kinesiophobia TAMPA scale\nPresentation of the parameters: it is expected a ");  
	        sb.Append("reduction of the score in the post-intervention evaluation when compared to the pre-intervention. "); 
	        sb.Append("There is no clinically important minimal difference established for this scale.");
	        sb.Append("Study Design: Clinical trial of a randomized, controlled, parallel, double-blind, two-arm treatment trial");
	        string brief_desc = sb.ToString();
	        
	        fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2017, 10, 11,  15, null, 915,
		        60, 17, null, null, 10);

	        fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100117, 
		             "Registro Brasileiro de Ensaios Clínicos", null, "2018 Sep 20", null));
	        
	        fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, 
		                             "From the Brazilian Clinical Trials Registry"));
	        fs.titles.Add(new StudyTitle(sd_sid, 
		        "Pain Neuroscience Eucation for the older people with chronic low back pain: randomized controlled trial.", 
		        16, "en", 11, false, "From the Brazilian Clinical Trials Registry"));
	        
	        fs.people!.Add(new StudyPerson(sd_sid, 51, "Mariane", "Campos", "Mariane Campos", null,
		        "Universidade Federal de São Carlos", 101665,
		        "Universidade Federal de São Carlos", "https://ror.org/00qdc6m37"));
	        
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Centro de Ciências Biológicas e da Saúde da Universidade Federal de São Carlos", null));
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Mariane Marques de Campos", null));
	        fs.organisations!.Add(new StudyOrganisation(sd_sid, 58, null, "Coordenação de Aperfeiçoamento de Pessoal de Nível Superior", null));
	        
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr assumed", "@", 1, "n.01", "Be 60 years old or over;"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr assumed", "@", 1, "n.02", "Be a carrier of nonspecific chronic low back pain;"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 3, 1, "cr assumed", "@", 1, "n.03", "Score at least the cut grade according to their education in the instrument: Mini Mental State Examination (MMSE);"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 1, "cr assumed", "@", 1, "n.04", "Score up to 5 points on the Geriatric Depression Scale instrument (GDS-15)"));
	        
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr assumed", "@", 1, "e.01", "Older people who underwent physiotherapeutic treatment for pain management in the last six months;"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr assumed", "@", 1, "e.02", "Older people who underwent surgical treatment for pain management;"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr assumed", "@", 1, "e.03", "Older people with diagnosis of Fibromyalgia;"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr assumed", "@", 1, "e.04", "Involvement in regular sports activities that have the same benefits as Pilates;"));	  
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr assumed", "@", 1, "e.05", "Active inflammatory diseases;"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr assumed", "@", 1, "e.06", "Pain related to previous fractures of the spine or lower limbs;"));	 
	        fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr assumed", "@", 1, "e.07", "Neoplasms;"));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr assumed", "@", 1, "e.08", "Death."));	
           
            fs.conditions!.Add(new StudyCondition(sd_sid, "older people, chronic pain, chronic low back pain, aging", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "C23.888.592.612.274", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "G07.345.124", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "C23.888.592.612.107.400", null, null, null, null));
            fs.conditions.Add(new StudyCondition(sd_sid, "M01.060.116.100", null, null, null, null));
            
            fs.features!.Add(new StudyFeature(sd_sid, 22, 205));  // Randomised
            fs.features.Add(new StudyFeature(sd_sid, 23, 305));  // Parallel assignment
            fs.features.Add(new StudyFeature(sd_sid, 24, 510));  // Double
            
            fs.countries!.Add(new StudyCountry(sd_sid, 3469034, "Brazil", null));
            
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: Brazilian registry web page";
            string ob_title = display_title + " :: Brazilian registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
       
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Brazilian registry web page", null, ob_title,
	            null, 9, 2018, 23, 13, 100117, "Registro Brasileiro de Ensaios Clínicos",
	            null, "en", 12, null, null, 0, true, true);
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100117, "Registro Brasileiro de Ensaios Clínicos", 
	            "http://ensaiosclinicos.gov.br/rg/RBR-5cqndz", true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2018 Sep 20", 2020, 9, 20, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2023 May 29", 2023, 5, 29, null, null, null, null));

            fs.data_objects!.Add(sdo);

            return fs;
        }

        return null;
    }
}