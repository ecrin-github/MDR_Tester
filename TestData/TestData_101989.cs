using System.Text;

namespace MDR_Tester;

public class TestData_101989 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "LBCTR2019070214")
        {
	        FullStudy fs = CreateEmptyFullStudy();
 
	        // Study 

	        string display_title = "Study of Efficacy and Safety of Pembrolizumab Plus Platinum-based Doublet Chemotherapy With or Without Canakinumab in Previously Untreated ";
	        display_title += "Locally Advanced or Metastatic Non-squamous and Squamous NSCLC Subjects  ( CANOPY 1 )"; 
	        StringBuilder sb = new StringBuilder();
	        
	        /*

call expected.insert_study_names(sid => _sid, 
						title =>_title, 
						brief_desc =>'Interventions: •Drug: canakinumab 
canakinumab every 3 weeks (squamous and non-squamous)

Other Name: ACZ885

•Drug: canakinumab matching placebo 
canakinumab placebo every 3 weeks (squamous and non-squamous)

•Drug: pembrolizumab 
200 mg every 3 weeks (squamous and non-squamous)

•Drug: carboplatin 
AUC 5 mg/mL*min every 3 weeks (non-squamous) or AUC 6 mg/mL*min (squamous)

•Drug: cisplatin 
75 mg/m2 every 3 weeks (non-squamous)

•Drug: paclitaxel 
200 mg/m2 every 3 weeks (squamous)

•Drug: nab-paclitaxel 
100 mg/m2 every 3 weeks (squamous)

•Drug: pemetrexed 
500 mg/m2 every 3 weeks (non-squamous)
;Blood test (Hematology, Chemistry, Coagulation, PK, ct DNA, Biomarkers...), CT Scan, MRI, Whole body bone scan, Skin photography, Vital signs, Physical exam, Urinalysis, X-Ray;ICF, IMP, Lab tests
Primary outcome(s): Name: *To compare PFS by local investigator assessment as per RECIST1.1 ;Timepoints: 6 months;Measure: 6 months;Name: Progression free survival;Timepoints: Duing the study ;Measure: during the study
Study Design: Allocation: Randomized controlled trial;Masking: Blinded (masking used);Control: Placebo;Assignment: Parallel;Purpose: Treatment',
		      dss => 'Novartis is committed to sharing with qualified external researchers, access to patient-level data and supporting clinical documents from eligible studies. These requests are reviewed and approved by an independent expert panel on the basis of scientific merit. All data provided is anonymized to respect the privacy of patients who have participated in the trial in line with applicable laws and regulations.  This trial data is currently available according to the process described on www.clinicalstudydatarequest.com.'
					   );

call expected.insert_study_details(sid => _sid, syear => 2019, smonth => 11, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '8', eligid => 900, minage => 18, minageu => 17, maxage => 90, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From the Lebanon Clinical Trials Registry');
call expected.insert_study_title(sid => _sid, typeid => 16, 
	                     title => 'A Randomized, Double-blind, Placebo-controlled, Phase III Study Evaluating the Efficacy and Safety of Pembrolizumab Plus Platinum-based Doublet Chemotherapy With or Without Canakinumab as First Line Therapy for Locally Advanced or Metastatic Non-squamous and Squamous Non-small Cell Lung Cancer Subjects (CANOPY-1)',
						 isdefault => false, comms => 'From the Lebanon Clinical Trials Registry');

	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 101989, idorgname => 'Lebanon Clinical Trials Registry', iddate => '2022 Jan 4');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT03631199', idorgid => 100120, idorgname => 'Clincaltrials.gov');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Hind Khairallah', affiliation => 'Khalil Fattal et Fils sal', orgname => 'Khalil Fattal et Fils sal' );
call expected.insert_indiv_contributor(sid => _sid, typeid => 56, full_name => 'Fadi Farhat', affiliation => 'Hammoud Hospital', orgname => 'Hammoud Hospital' );
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'Novartis Pharma Services Inc');

call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 130);
call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 23, valueid  => 305);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 502);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Patients with Non-Small Cell Lung Cancer');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'NSCLC');
 */
	        
// Data Objects
	        
// 1) Trial registry entry

string sd_oid = "LBCTR2019070214 :: 13 :: Lebanese registry web page";
string ob_title = display_title + " :: Lebanese registry web page";
StudyDataObject sdo = CreateEmptyStudyDataObject();

/*
call expected.insert_data_object(sd_oid => _oid, sid => _sid,
	title => _title || ' :: Lebanese registry web page',
	pubyear => 2022, obclassid => 23, obtypeid => 13,
	managingorgid => 101989, managingorgname=> 'Lebanon Clinical Trials Registry',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: Lebanese registry web page', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
	reporgid => 101989, reporgname => 'Lebanon Clinical Trials Registry', 
	purl => 'https://lbctr.moph.gov.lb/Trials/Details/4971',  
	restypeid => 35);
	
call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2022 Jan 4', syear => 2022, smonth => 1, sday => 4);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2022 Mar 8', syear => 2022, smonth => 3, sday => 8);

 */
	        
        }
        return null;
    }
}