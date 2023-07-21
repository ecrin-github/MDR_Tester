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
            
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 302, "cr", "none", 1, "e.00", "[Phase 1/2 parts]"));	  
            fs.iec!.Add(new StudyIEC(sd_sid, 2, 2, "cr", "1)", 1, "e.01", "Patients with CNS (central nervous system)disease."));	       
            fs.iec.Add(new StudyIEC(sd_sid, 3, 2, "cr", "2)", 1, "e.02", "Primary cutaneous ALCL."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 4, 2, "cr", "3)", 1, "e.03", "Pregnant or brest-feeding women."));
            fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr", "4)", 1, "e.04", "Patients of reproductive potential who have not agreed to use an effective contraception method."));	
            fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr", "5)", 1, "e.04", "Patients receiving the following concomitant medications"));	
            fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr", "5-1)", 2, "e.05.01", "Therapeutic corticosteroids for lymphoma"));	    
            fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr", "5-2)", 2, "e.05.02", "investigational instruments and clinical trial products."));	    
            fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "5-3)", 2, "e.05.03", "Anticancer agents"));	
            fs.iec.Add(new StudyIEC(sd_sid, 10, 2, "cr", "5-4)", 2, "e.05.04", "narrow therapeutic indice CYP3A4 substrates"));	
            fs.iec.Add(new StudyIEC(sd_sid, 11, 2, "cr", "5-5)", 2, "e.05.05", "Strong CYP3A4 inhibitors"));	
            fs.iec.Add(new StudyIEC(sd_sid, 12, 2, "cr", "5-6)", 2, "e.05.06", "Strong CYP3A4 inducers"));	
            fs.iec.Add(new StudyIEC(sd_sid, 13, 2, "cr", "6)", 1, "e.06", "Patients with interstitial fibrosis or interstitial lung disease or with a known history of those."));	
            fs.iec.Add(new StudyIEC(sd_sid, 14, 2, "cr", "7)", 1, "e.07", "Patients with myocardial infarction or cerebrovascular disorder or with a known history of those."));	
            fs.iec.Add(new StudyIEC(sd_sid, 15, 2, "cr", "8)", 1, "e.08", "Patients having an uncontrolled infectious disease."));	
            fs.iec.Add(new StudyIEC(sd_sid, 16, 2, "cr", "9)", 1, "e.09", "Those who in the opinion of the investigator may not be able to comply with the safety monitoring requirements of the study."));	
            fs.iec.Add(new StudyIEC(sd_sid, 17, 2, "cr", "10)", 1, "e.10", "Patient who can not take capsule formulation or liquid formulation. However, administration of the liquid preparation via the feeding tube is permitted."));	
	        
	        fs.countries!.Add(new StudyCountry(sd_sid, 1861060, "Japan", null));
	        
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
	        sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Oct 10", 2022, 10, 10, null, null, null, null));
	       
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
            
	        fs.iec!.Add(new StudyIEC(sd_sid, 1, 1, "cr", "(1)", 1, "n.01", "The patients whose doctor plans a biopsy or tumor resection and whose tumor is suspected as primary glioma by board-certified diagnostic radiologists and board-certified neurosurgeons based on clinical manifestations, clinical course and MRI findings."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 2, 1, "cr", "(2)", 1, "n.02", "The patients who or whose legal representative gave a written informed consent to this study."));	    

	        fs.iec.Add(new StudyIEC(sd_sid, 3, 2, "cr", "(1)", 1, "e.01", "The patients with a history of serious allergic reaction to C-11 methionine or F-18 FDG."));	       
	        fs.iec.Add(new StudyIEC(sd_sid, 4, 2, "cr", "(2)", 1, "e.02", "Pregnant women, breast-feeding women, or women who may be pregnant "));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 5, 2, "cr", "(3)", 1, "e.03", "The patients who is participating in other trials"));
	        fs.iec.Add(new StudyIEC(sd_sid, 6, 2, "cr", "(4)", 1, "e.04", "The patients who underwent C-11 methionine PET within 90 days"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 7, 2, "cr", "(5)", 1, "e.05", "The patients whose overall status is not satisfactory for surgical treatment"));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 8, 2, "cr", "(6)", 1, "e.06", "The patients who cannot undergo contrast-enhanced MRI "));	    
	        fs.iec.Add(new StudyIEC(sd_sid, 9, 2, "cr", "(7)", 1, "e.07", "The patients whom investigators judged to be inadequate as candidate"));	   

	        fs.countries!.Add(new StudyCountry(sd_sid, 1861060, "Japan", null));
	        
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
	            "ClinicalTrials.gov", null, null, null));
            
            fs.titles!.Add(new StudyTitle(sd_sid, display_title, 15, "en", 11, true, "From the Japan Primary Registries Network"));
            
            fs.features!.Add(new StudyFeature(sd_sid, 24, 599));
            
            fs.conditions!.Add(new StudyCondition(sd_sid, "Pregnancy Induced Hypertension(PIH)", null, null, null, null));
           
            fs.iec!.Add(new StudyIEC(sd_sid, 1, 302, "none", "none", 0, "e.0A", "Cases complicated by malignancy,renal,liver or any other secondary manifestations."));	       

            fs.countries!.Add(new StudyCountry(sd_sid, null, "Asia(except Japan)", null));
	        
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
            sdo.object_dates.Add(new ObjectDate(sd_oid, 18, false, "2022 Apr 06", 2022, 4, 6, null, null, null, null));
	       
            fs.data_objects!.Add(sdo);

            return fs;
        }
        
        return null;
    }
}