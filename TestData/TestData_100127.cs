using System.Text;

namespace MDR_Tester;

public class TestData_100127 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "JPRN-UMIN000028075")
        {
	        FullStudy fs = CreateEmptyFullStudy();
             
            // Study 
            
            string display_title = "A phase I/II study of crizotinib for recurrent or refractory anaplastic lymphoma kinase (ALK)-positive anaplastic large cell lymphoma (ALCL) and ";
            display_title += "phase I study of this drug for recurrent or refractory neuroblastoma";
            StringBuilder sb = new StringBuilder("Interventions: A multicenter, single group assignment, open label, phase I dose-escalation study followed by a phase II study.\n");
            sb.Append("This drug should be orally administered twice a day. It should be repeatedly administered, regarding 28 days as a cycle.Each cycle will "); 
            sb.Append("be repeated every 28 days.  The data cutoff is carry out at 6 cycles for the phase 1 part and 12 cycles for the phase 2 part.\n"); 
            sb.Append("Primary outcome(s): [Phase 1 part\n"); 
            sb.Append("Dose-limiting toxicity\n"); 
            sb.Append("[Phase 2 part]\n"); 
            sb.Append("Response rate evaluated by the Central Evaluation Committee\n"); 
            sb.Append("Study Design: Single arm Non-randomized"); 
            string brief_desc = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2017, 10, 11, 14, "23", 900,
                1, 17, 22, 17, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100127, 
                "Japan Primary Registries Network", null, "2017 Jul 19", null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Japan Primary Registries Network"));
            string title = "A phase I/II study of crizotinib for recurrent or refractory anaplastic lymphoma kinase (ALK)-positive anaplastic large cell ";
            title +=
	            "lymphoma (ALCL) and phase I study of this drug for recurrent or refractory neuroblastoma - A phase I/II study of crizotinib for recurrent ";
            title +=
	            "or refractory anaplastic lymphoma kinase (ALK)-positive anaplastic large cell lymphoma (ALCL) and phase I study of this drug for recurrent or refractory neuroblastoma";
            fs.titles.Add(new StudyTitle(sd_sid, title, 16, "en", 11, false, 
	            "From the Japan Primary Registries Network"));
            	        	      
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Tetsuya Mori", "St Marianna University School of Medicine Hospital Department of Pediatrics", 
	            null, "St Marianna University School of Medicine Hospital Department of Pediatrics", null));
            fs.people!.Add(new StudyPerson(sd_sid, 56, "Yutaka Ito", "National Hospital Organization Nagoya Medical Center Department of Clinical Research Management, Clinical Research Center", 
	            null, "National Hospital Organization Nagoya Medical Center Department of Clinical Research Management", null));
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "St Marianna University School of Medicine HospitalNational Center for Child Health and DevelopmentNagoya Medical CenterKyushu University Hospital", null));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 103952, "Japan Agency for Medical Research and Development", "https://ror.org/004rtk039"));
            
	        fs.features!.Add(new StudyFeature(sd_sid, 20, 115));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 22, 210));   // 

            fs.conditions!.Add(new StudyCondition(sd_sid, "Recurrent or refractory anaplastic lymphoma kinase (ALK)-positive anaplastic large cell lymphoma.Recurrent or refractory neuroblastoma", 
	            null, null, null, null));      

	        // countries
            
	        // iec
	        
	        // Data Objects
	        
	        // 1) Trial registry entry

	        string sd_oid = sd_sid + " :: 13 :: Japanese registry web page";
	        string ob_title = display_title + " :: Japanese registry web page";
	        StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
	        sdo.data_object = new DataObject(sd_oid, sd_sid, "Japanese registry web page", null, ob_title,
		        null, 9, 2017, 23, 13, 100127, "Japan Primary Registries Network", null, "en", 12, null, null, 0, true, true);
	       
	        sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
	        sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100127, "Japan Primary Registries Network", 
		        "https://upload.umin.ac.jp/cgi-open-bin/ctr_e/ctr_view.cgi?recptno=R000031711", 
		        true, 35, null, null, null));
	        sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2017 Jul 19", 2017, 7, 19, null, null, null, null));
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2019 Apr 23", 2019, 4, 23, null, null, null, null));
	       
	        fs.data_objects!.Add(sdo);

	        return fs;
        }
        
        
        if (sd_sid == "JPRN-jRCTs012180017")
        {
            FullStudy fs = CreateEmptyFullStudy();
             
            // Study 
            
            string display_title = "Usefulness of using C-11 methionine PET in patient which suspected glioma";
            StringBuilder sb = new StringBuilder("Interventions: Usefulness of using C-11 methionine PET\n");
            sb.Append("Primary outcome(s): Positive-predictive value (PPV) in the site of negative contrast-enhanced MRI and positive Met-PET which assume a histopathology diagnosis criteria diagnosis.\n"); 
            sb.Append("Study Design: single arm study, open(masking not used), no treatment control, single assignment, diagnostic purpose"); 
            string brief_desc = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2016, 5, 11, 21, "72", 900,
                null, null, null, null, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100127, 
                "Japan Primary Registries Network", null, "2019 Mar 19", null));
            fs.identifiers!.Add(new StudyIdentifier(sd_sid, "JPRN-UMIN000022067", 11, 100127, 
	            "Japan Primary Registries Network", null, null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Japan Primary Registries Network"));
            fs.titles.Add(new StudyTitle(sd_sid, 
	            "Usefulness of using C-11 methionine PET in patient which suspected glioma - Usefulness of using C-11 methionine PET in patient which suspected glioma", 
	            16, "en", 11, false, "From the Japan Primary Registries Network"));
            	      
            fs.people!.Add(new StudyPerson(sd_sid, 51, "Shigeru Yamaguchi", "Hokkaido University Hospital", 
	            102041, "Hokkaido University Hospital", "https://ror.org/0419drx70"));
            fs.people!.Add(new StudyPerson(sd_sid, 56, "Nozomi Yokota", "Hokkaido University Hospital", 
	            102041, "Johns Hopkins University", "https://ror.org/0419drx70"));
            
            fs.organisations!.Add(new StudyOrganisation(sd_sid, 54, null, "Yamaguchi Shigeru", null));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, null, "Sumitomo Heavy Industries, Ltd", null));
            fs.organisations.Add(new StudyOrganisation(sd_sid, 58, 103952, "Japan Agency for Medical Research and Development", "https://ror.org/004rtk039"));

            fs.features!.Add(new StudyFeature(sd_sid, 20, 130));  // 
	        fs.features.Add(new StudyFeature(sd_sid, 24, 500));   // 
	        
	        fs.conditions!.Add(new StudyCondition(sd_sid, "glioma", null, null, "2A00", "Primary neoplasms of brain"));      

            // countries
            
            // iec
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: Japanese registry web page";
            string ob_title = display_title + " :: Japanese registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Japanese registry web page", null, ob_title,
	            null, 9, 2019, 23, 13, 100127, "Japan Primary Registries Network", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100127, "Japan Primary Registries Network", 
	            "https://jrct.niph.go.jp/latest-detail/jRCTs012180017", 
	            true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2019 Mar 19", 2019, 3, 19, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2021 May 17", 2021, 5, 17, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);
            
            // 1) CSR Summary

            sd_oid = sd_sid + " :: 79 :: CSR summary";
            ob_title = display_title + " :: CSR summary";
            sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "CSR summary", null, ob_title,
	            null, 9, 2019, 23, 79, 100127, "Japan Primary Registries Network", null, "en", 11, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, null, null, 
	            "https://jrct.niph.go.jp/latest-detail/jRCTs012180017", 
	            true, 35, null, null, null));

            fs.data_objects!.Add(sdo);
            
            return fs;
        }

        
        if (sd_sid == "JPRN-UMIN000024722")
        {
            FullStudy fs = CreateEmptyFullStudy();
             
            // Study 
            
            string display_title = "A Clinical Study of Fundus Findings in Toxaemia of Pregnancy(Pregnancy Induced Hypertension";
            StringBuilder sb = new StringBuilder("Primary outcome(s): In our study out of three hundred cases of pregnancy induced hypertension there are one hundred and ");
            sb.Append("eighty two cases of mild preeclampsia and seventy six cases of severe preeclampsia and forty two cases of eclampsia. Among these thirty "); 
            sb.Append("seven cases of mild preeclampsia and seventy five cases  of severe preeclampsia and forty one cases of eclampsia show positive fundus changes."); 
            sb.Append("The incidence of pre term babies intra uterine death still birth and low birth weight infants is high in mothers having positive fundus changes. "); 
            sb.Append("The perinatal mortality is higher in patients having Grade Two Three and Four hypertensive retinopathy"); 
            string brief_desc = sb.ToString();
            
            fs.study = new Study(sd_sid, display_title, "en", brief_desc, null, 2003, 11, 12, 21, "300", 905,
                18, 17, 42, 17, 10);

            fs.identifiers!.Add(new StudyIdentifier(sd_sid, sd_sid, 11, 100127, 
                "Japan Primary Registries Network", null, "2016 Nov 4", null));
            fs.identifiers!.Add(new StudyIdentifier(sd_sid, "NCT03076619", 11, 100120, 
	            "Clinicaltrials.gov", null, null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Japan Primary Registries Network"));
            
            fs.features!.Add(new StudyFeature(sd_sid, 24, 599));
            
            fs.conditions!.Add(new StudyCondition(sd_sid, "Pregnancy Induced Hypertension(PIH)", null, null, null, null));
           
            // countries
            
            // iec
	        
            // Data Objects
	        
            // 1) Trial registry entry

            string sd_oid = sd_sid + " :: 13 :: Japanese registry web page";
            string ob_title = display_title + " :: Japanese registry web page";
            StudyDataObject sdo = CreateEmptyStudyDataObject();
	        
            sdo.data_object = new DataObject(sd_oid, sd_sid, "Japanese registry web page", null, ob_title,
	            null, 9, 2016, 23, 13, 100127, "Japan Primary Registries Network", null, "en", 12, null, null, 0, true, true);
	       
            sdo.object_titles!.Add(new ObjectTitle(sd_oid, ob_title, 22, "en", 11, true, null));
            sdo.object_instances!.Add(new ObjectInstance(sd_oid, 100127, "Japan Primary Registries Network", 
	            "https://upload.umin.ac.jp/cgi-open-bin/ctr_e/ctr_view.cgi?recptno=R000028441", 
	            true, 35, null, null, null));
            sdo.object_dates!.Add(new ObjectDate(sd_oid, 15, false, "2016 Nov 4", 2016, 11, 4, null, null, null, null));
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2019 Apr 2", 2019, 4, 23, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        return null;
    }
}