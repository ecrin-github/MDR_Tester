namespace MDR_Tester;

public class TestData_100121 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "CTRI-2017-03-008228")
        {
            /*
             -- PROCEDURE: expected.study_ctri_2017_03_008228()

-- DROP PROCEDURE IF EXISTS expected.study_ctri_2017_03_008228();

CREATE OR REPLACE PROCEDURE expected.study_ctri_2017_03_008228(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'CTRI-2017-03-008228';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'A Clinical Study of Fundus Findings in Toxaemia of Pregnancy';

call expected.insert_study_names(sid => _sid, 
						title =>_title, 
						brief_desc =>'Primary outcome(s): In our study out of 300 cases of PIH, there 

are 182 cases of mild preeclampsia and 76 cases of severe preeclampsia and 42 cases of eclampsia. Among these, 37 cases (20.33%) 

of mild preeclampsia and 75 cases (98.68%) of severe preeclampsia and 41 cases (97.62%) of eclampsia show positive fundus changes. 

Timepoint: November 2003 to June 2006'
 );

call expected.insert_study_details(sid => _sid, syear => 2003, smonth => 11, typeid => 12, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '300', eligid => 915, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From the Clinical Trials Registry - India');
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'A Clinical Study of Fundus Findings in Toxaemia of Pregnancy(Pregnancy Induced Hypertension)', isdefault => false, comms => 'From the Clinical Trials Registry - India');
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100121, idorgname => 'Clinical Trials Registry - India', iddate => '2017 Mar 27');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Rekha Bharwada', affiliation => 'M and J Western Regional Institute of Ophthalmology', 
									   orgname => 'M and J Western Regional Institute of Ophthalmology' );
call expected.insert_indiv_contributor(sid => _sid, typeid => 56, full_name => 'Rahul Navinchandra Bakhda', affiliation => 'M and J Western Regional Institute of Ophthalmology',
									   orgname => 'M and J Western Regional Institute of Ophthalmology' );
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'M and J Western Regional Institute of Ophthalmology');

call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 599);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Health Condition 1: null- Fundus assessment of patients of Pregnancy Induced Hypertension');

-- trial registry entry
_oid = _sid ||' :: 13 :: Indian registry web page';

call expected.insert_data_object(sd_oid => _oid, sid => _sid, 
	title => _title || ' :: Indian registry web page',
	pubyear => 2017, obclassid => 23, obtypeid => 13,
	managingorgid => 100121, managingorgname=> 'Clinical Trials Registry - India',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: Indian registry web page', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100121, reporgname => 'Clinical Trials Registry - India', 
	purl => 'http://www.ctri.nic.in/Clinicaltrials/pmaindet2.php?trialid=16622',  
	restypeid => 35);

call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2017 Mar 27', syear => 2017, smonth => 3, sday => 27);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2021 Nov 24', syear => 2021, smonth => 11, sday => 24);	

end;
$BODY$;
ALTER PROCEDURE expected.study_ctri_2017_03_008228()
    OWNER TO postgres;
 
             */            
        }
        
        if (sd_sid == "CTRI-2019-06-019509")
        {
            /*
            -- PROCEDURE: expected.study_ctri_2019_06_019509()

-- DROP PROCEDURE IF EXISTS expected.study_ctri_2019_06_019509();

CREATE OR REPLACE PROCEDURE expected.study_ctri_2019_06_019509(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'CTRI-2019-06-019509';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'This is a phase III study of pembrolizumab plus platinum-based doublet chemotherapy with or without canakinumab in previously untreated locally advanced or metastatic non-squamous and squamous NSCLC subjects.';

call expected.insert_study_names(sid => _sid, 
						title =>_title, 
						brief_desc =>'Intervention1: Canakinumab (ACZ885)(150 mg/1 mL AND 50 mg/0.5 mL): Dose 200 mg Solution for s.c.
injection in prefilled syringe once every 3 weeks or 6 weeks
Intervention2: Canakinumab matching-placebo
(ACZ885)(0 mg/1 mL AND 0
mg/0.5 mL): Solution for s.c. injection in prefilled syringe once every 3 weeks or 6 weeks
Control Intervention1: Pembrolizumab (50 mg): Dose in Lyophilized 200 mg powder for solution for
infusion in vial given once every 3weeks
Control Intervention2: Pembrolizumab 100 mg/4 mL (25
mg/mL): Dose of 200 mg Concentrate for
solution for i.v. infusion in vial once every 3 weeks
Control Intervention3: Pembrolizumab 100 mg/4 mL
(25 mg/mL): Dose of 200 mg Concentrate for
solution for i.v. infusion in vial given once every 3 weeks.
Control Intervention4: Pembrolizumab 50 mg: Dose 200mg Lyophilized
powder for solution for
infusion in vial given once in every week.
Control Intervention5: Pemetrexed (500 mg/m2): Concentrate for solution for i.v. infusion in vial given once in 3 weeks
Control Intervention6: Carboplatin AUC 6 mg/ml min: Concentrate for solution for i.v. infusion in vial given once every 3 weeks
Control Intervention7: Paclitaxel OR nab-paclitaxel 200 mg/m2(paclitaxel) OR
100 mg/m2(nab-paclitaxel): Concentrate for solution for i.v. infusion in vial given once every 3 weeks
Control Intervention8: Carboplatin OR cisplatin AUC 5mg/ml min(carboplatin)OR
75 mg/m2(cisplatin): Concentrate for solution for i.v. infusion in vial given once every 3 weeks.
Primary outcome(s): 1.Safety run-in part: Incidence of dose limiting toxicities (DLTs. Incidence of DLTs assessed among at least 6 evaluable subjects during the first 42 days of study treatment. 

2. 2.Double-blind, randomized, placebo-controlled part: Progression free survival (PFS) per investigator assessment using RECIST v1.1  

3. 3.Double-blind, randomized, placebo-controlled part: Overall survival (OS) per investigator assessment using RECIST v1.1.Timepoint: 1. Time Frame: 6 months from start of safety run-in part 

2. Time Frame: 18 months from start of randomization part  

3. Time Frame: 38 months from start of randomization part
Study Design: Randomized, Parallel Group, Placebo Controlled Trial
  Method of generating randomization sequence:Computer generated randomization  Method of allocation concealment:Centralized  Blinding and masking:Participant and Investigator Blinded'
   );

call expected.insert_study_details(sid => _sid, syear => 2019, smonth => 6, typeid => 11, statusid => 15);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '627', eligid => 915, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From the Clinical Trials Registry - India');
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'A randomized, double-blind, placebo-controlled, phase IIIstudy evaluating the efficacy and safety of pembrolizumabplus platinum-based doublet chemotherapy with or withoutcanakinumab as first line therapy for locally advanced ormetastatic non-squamous and squamous non-small celllung cancer subjects - CANOPY 1',
						 isdefault => false, comms => 'From the Clinical Trials Registry - India');
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100121, idorgname => 'Clinical Trials Registry - India', iddate => '2019 Jun 3');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT03631199', idorgid => 100120, idorgname => 'ClinicalTrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'CACZ885U2301, Version:00, dated: 02-Aug-2018', idorgname => 'Novartis Healthcare Pvt Ltd');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'CACZ885U2301, Version:1.0, dated: 12-Dec-2018', idorgname => 'Novartis Healthcare Pvt Ltd');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Murugananthan K', affiliation => 'Novartis Healthcare Private LTD', orgname => 'Novartis Healthcare Private LTD' );
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'Novartis Healthcare Pvt Ltd');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'Novartis Pharma AG, CH-4002 Basel, Switzerland');

call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 130);
call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 23, valueid  => 305);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 505);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Health Condition 1: C390- Malignant neoplasm of upper respiratory tract, part unspecified');

-- trial registry entry
_oid = _sid ||' :: 13 :: Indian registry web page';

call expected.insert_data_object(sd_oid => _oid, sid => _sid,
	title => _title || ' :: Indian registry web page',
	pubyear => 2019, obclassid => 23, obtypeid => 13,
	managingorgid => 100121, managingorgname=> 'Clinical Trials Registry - India',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: Indian registry web page', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100121, reporgname => 'Clinical Trials Registry - India', 
	purl => 'http://www.ctri.nic.in/Clinicaltrials/pmaindet2.php?trialid=29960',  
	restypeid => 35);
	
call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2019 Jun 3', syear => 2019, smonth => 6, sday => 3);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2021 Nov 24', syear => 2021, smonth => 11, sday => 24);	

end;
$BODY$;
ALTER PROCEDURE expected.study_ctri_2019_06_019509()
    OWNER TO postgres;
 
            */           
        }

        return null;
    }
}