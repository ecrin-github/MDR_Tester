namespace MDR_Tester;

public class TestData_100126 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "ISRCTN00075564")
        {
            /*
             -- PROCEDURE: expected.study_isrctn00075564()

-- DROP PROCEDURE IF EXISTS expected.study_isrctn00075564();

CREATE OR REPLACE PROCEDURE expected.study_isrctn00075564(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'ISRCTN00075564';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'A trial of withdrawal of nocturnal non-invasive positive pressure ventilation (NIPPV) in chronic obstructive pulmonary disease (COPD) patients with chronic hypercapnic ventilatory failure previously stable on nocturnal NIPPV';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc => 'Study hypothesis: Currently it is unclear whether patients with severe COPD benefit from noninvasive positive pressure ventilation in the long term. There is divided opinion and evidence on whether this is a beneficial treatment and who might benefit. In performing this clinical trial of withdrawal of a non-proven treatment with close monitoring we plan to address the issue of whether of not the treatment does maintain the patients in a stable clinical state and improve their quality of life.
Primary outcome(s): ‘Withdrawal Failure’ as stipulated by preset criteria. The effect of withdrawal of NIPPV therapy on arterial blood gas analysis.

Criteria for Withdrawal Failure:
1. Daytime PaCO2 >9 kPa
2. Nocturnal PtcCO2 >10 on night study
3. Respiratory acidosis pH <7.35
4. Intolerable symptoms, including morning headache and drowsiness'
			);

call expected.insert_study_details(sid => _sid, syear => 2005, smonth => 5, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '40', eligid => 900, minage => 18, minageu => 17, maxage => 65, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From ISRCTN');
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100126, idorgname => 'ISRCTN', iddate => '2005 Jul 8');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => '04/Q0104/139 - NRR Publication ID: N0542155456', idorgname => 'Papworth Hospital NHS Trust (UK)');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Nick Oscroft' );
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'Papworth Hospital NHS Trust (UK)');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'Respiratory Support and Sleep Centre Trust fund supported by an unrestricted grant from B & D Electromedical (UK)');

call expected.insert_study_feature(sid => _sid, typeid => 21, valueid  => 400);
call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 140);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 525);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Chronic Obstructive Pulmonary Disease (COPD)');

call expected.insert_study_reference(sid => _sid, ppmid => '20397811', 
		pcitation => 'http://www.ncbi.nlm.nih.gov/pubmed/20397811',
	    pdoi => '2010 results in '						 
		);	

		
-- trial registry entry
_oid = _sid ||' :: 13 :: ISRCTN registry entry';

call expected.insert_data_object(sd_oid => _oid, sid => _sid,
	title => _title || ' :: ISRCTN registry entry',
	doid => 'https://doi.org/10.1186/ISRCTN00075564', doidsid => 1,
	pubyear => 2005, obclassid => 23, obtypeid => 13,
	managingorgid => 100126, managingorgname=> 'ISRCTN',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: ISRCTN registry entry', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100126, reporgname => 'ISRCTN', 
	purl => 'https://www.isrctn.com/' || _sid,  
	restypeid => 35);

call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2005 Jul 8', syear => 2005, smonth => 7, sday => 8);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2010 Jul 16', syear => 2010, smonth => 7, sday => 16);

end;
$BODY$;
ALTER PROCEDURE expected.study_isrctn00075564()
    OWNER TO postgres;
 
             */
        }
        
        if (sd_sid == "ISRCTN16535250")
        {
            /*
            -- PROCEDURE: expected.study_isrctn16535250()

-- DROP PROCEDURE IF EXISTS expected.study_isrctn16535250();

CREATE OR REPLACE PROCEDURE expected.study_isrctn16535250(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'ISRCTN16535250';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'Comparison between injection of local analgesia and performing a specific nerve block in the management of vaginal pain after delivery';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc => 'Study hypothesis: In women in labor and undergoing episiotomy pudendal nerve block may be similar to local infiltration by analgesic as regard post episiotomy pain relief.
Primary outcome(s): Pain measured using the Visual Analogue Scale assessed every hour for the first 6 hours postpartum starting from the time of the analgesia injection',
						dss => 'IPD sharing statement: The datasets generated during and/or analysed during the current study are/will be available upon request from Abdelrahman Abouelhassan (Bodym93@yahoo.com).
IPD: Available on request'
					   );

call expected.insert_study_details(sid => _sid, syear => 2018, smonth => 7, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '100', eligid => 905, minage => 18, minageu => 17, maxage => 65, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From ISRCTN');
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'Effect of pudendal nerve block versus perineal local infiltration of analgesia in post episiotomy pain relief', isdefault => false, comms => 'From ISRCTN');
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100126, idorgname => 'ISRCTN', iddate => '2021 Jan 24');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => '20092018', idorgname => 'Ain Shams University');

call expected.insert_indiv_contributor(sid => _sid, typeid => 56, full_name => 'Abdelrahman Abouelhassan');
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'Ain Shams University');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'Ain Shams University Hospital');

call expected.insert_study_feature(sid => _sid, typeid => 21, valueid  => 400);
call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 525);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Post episiotomy pain after delivery');

		
-- trial registry entry
_oid = _sid ||' :: 13 :: ISRCTN registry entry';

call expected.insert_data_object(sd_oid => _oid, sid => _sid,
	title => _title || ' :: ISRCTN registry entry',
	doid => 'https://doi.org/10.1186/ISRCTN16535250', doidsid => 1,
	pubyear => 2021, obclassid => 23, obtypeid => 13,
	managingorgid => 100126, managingorgname=> 'ISRCTN',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: ISRCTN registry entry', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100126, reporgname => 'ISRCTN', 
	purl => 'https://www.isrctn.com/' || _sid,  
	restypeid => 35);

call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2021 Jan 24', syear => 2021, smonth => 1, sday => 24);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2021 Feb 4', syear => 2021, smonth => 2, sday => 4);

_oid = _sid ||' :: 11 :: ISRCTN16535250_PROTOCOL.pdf';

call expected.insert_data_object(sd_oid => _oid, sid => _sid,
title => _title || ' :: ISRCTN16535250_PROTOCOL.pdf', 
obclassid => 23, obtypeid => 11, 
managingorgid => 100126, managingorgname => 'ISRCTN', 
acctypeid => 11, eosccat => 0);

call expected.insert_object_title(sd_oid => _oid, typeid => 20,
title => _title || ' :: ISRCTN16535250_PROTOCOL.pdf', isdefault => true);

call expected.insert_object_instance(sd_oid => _oid, reporgid => 100126, reporgname => 'ISRCTN', 
purl => 'https://www.isrctn.com/editorial/retrieveFile/24eb625c-779e-4308-a397-3b6a588edf4f/38799', 
restypeid => 11);

end;
$BODY$;
ALTER PROCEDURE expected.study_isrctn16535250()
    OWNER TO postgres;
 
            */           
        }

        if (sd_sid == "ISRCTN59589587")
        {
            /*
            -- PROCEDURE: expected.study_isrctn59589587()

-- DROP PROCEDURE IF EXISTS expected.study_isrctn59589587();

CREATE OR REPLACE PROCEDURE expected.study_isrctn59589587(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'ISRCTN59589587';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'A European Intergroup Cooperative Ewing’s Sarcoma Study: A randomised study for the treatment of Ewing’s sarcoma of bone';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc => null,
						dss => null
					   );

call expected.insert_study_details(sid => _sid, syear => 1994, smonth => 1, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 915, minage => 18, minageu => 17, maxage => 65, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From ISRCTN');

	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100126, idorgname => 'ISRCTN', iddate => '2001 Jul 1');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT00002516', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'ET 9302', idorgname => 'Cancer Research UK (CRUK) (UK)');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'Cancer Research UK (CRUK) (UK)');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'Cancer Research UK');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'European Community (BIOMED)');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'German Cancer Aid');

call expected.insert_study_feature(sid => _sid, typeid => 21, valueid  => 445);
call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 140);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 525);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Cancer drugs');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Bone cancer');

call expected.insert_study_reference(sid => _sid, ppmid => '10472562', pcitation => 'http://www.ncbi.nlm.nih.gov/pubmed/10472562', pdoi => '1. 1999 preliminary results in ');
call expected.insert_study_reference(sid => _sid, ppmid => '12504050', pcitation => 'http://www.ncbi.nlm.nih.gov/pubmed/12504050', pdoi => '2. 2003 results in ');
call expected.insert_study_reference(sid => _sid, ppmid => '16137838', pcitation => 'http://www.ncbi.nlm.nih.gov/pubmed/16137838', pdoi => '3. 2005 results in ');
call expected.insert_study_reference(sid => _sid, ppmid => '18398583', pcitation => 'http://www.ncbi.nlm.nih.gov/pubmed/18398583', pdoi => '4. 2008 results in ');
call expected.insert_study_reference(sid => _sid, ppmid => '18802150', pcitation => 'http://www.ncbi.nlm.nih.gov/pubmed/18802150', pdoi => '5. 2008 results in ');

		
-- trial registry entry
_oid = _sid ||' :: 13 :: ISRCTN registry entry';

call expected.insert_data_object(sd_oid => _oid, sid => _sid, 
	title => _title || ' :: ISRCTN registry entry',
	doid => 'https://doi.org/10.1186/ISRCTN59589587', doidsid => 1,
	pubyear => 2001, obclassid => 23, obtypeid => 13,
	managingorgid => 100126, managingorgname=> 'ISRCTN',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid,
	typeid => 22, title => _title || ' :: ISRCTN registry entry', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid,
    reporgid => 100126, reporgname => 'ISRCTN', 
	purl => 'https://www.isrctn.com/' || _sid,  
	restypeid => 35);

call expected.insert_object_date(sd_oid => _oid,typeid => 15, datestring => '2001 Jul 1', syear => 2001, smonth => 7, sday => 1);
call expected.insert_object_date(sd_oid => _oid,typeid => 18, datestring => '2012 Feb 1', syear => 2012, smonth => 2, sday => 1);

end;
$BODY$;
ALTER PROCEDURE expected.study_isrctn59589587()
    OWNER TO postgres;

            */           
        }
        
        if (sd_sid == "ISRCTN88368130")
        {
            /*
           -- PROCEDURE: expected.study_isrctn88368130()

-- DROP PROCEDURE IF EXISTS expected.study_isrctn88368130();

CREATE OR REPLACE PROCEDURE expected.study_isrctn88368130(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'ISRCTN88368130';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'Scaling Colorectal cancer screening through Outreach, Referral, and Engagement (SCORE)';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc => 'Study hypothesis: This pilot study aims to assess the effectiveness, feasibility, acceptability, and cost-effectiveness of mailed fecal immunochemical test (FIT) screening, compared to usual care, among patients of two community health centers who are due for colorectal cancer (CRC) screening
Primary outcome(s): The proportion of individuals who complete colorectal cancer (CRC) screening within 6 months, using any of the screening modalities recommended by the United States Preventive Service Task Force (fecal immunochemical test [FIT], fecal occult blood test [FOBT], FIT-DNA, colonoscopy, flexible sigmoidoscopy, flexible sigmoidoscopy with FIT, CT colonography), assessed through electronic health record review at 6 months.',
						dss => 'General dissemination plan: Planned publication in a high-impact peer-reviewed journal.
IPD: Stored in publicly available repository'
					   );

call expected.insert_study_details(sid => _sid, syear => 2018, smonth => 9, typeid => 11, statusid => 15);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '711', eligid => 900, minage => 18, minageu => 17, maxage => 65, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From ISRCTN');
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'Scaling Colorectal cancer screening through Outreach, Referral, and Engagement (SCORE): a state-level program to reduce colorectal cancer burden in vulnerable populations', isdefault => false, comms => 'From ISRCTN');
call expected.insert_study_title(sid => _sid, typeid => 14, 
                         title => 'SCORE', isdefault => false, comms => 'From ISRCTN');		
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100126, idorgname => 'ISRCTN', iddate => '2020 Jun 9');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT04406714', idorgid => 100120, idorgname => 'Clinicaltrials.gov');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Daniel Reuland', orcid => '0000-0002-7839-6581' );
call expected.insert_indiv_contributor(sid => _sid, typeid => 56, full_name => 'Teri Malo', orcid => '0000-0002-5620-4841' );
call expected.insert_indiv_contributor(sid => _sid, typeid => 56, full_name => 'Alexis Moore');
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'UNC Lineberger Comprehensive Cancer Center');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'National Cancer Institute');

call expected.insert_study_feature(sid => _sid, typeid => 21, valueid  => 420);
call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 525);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Colorectal cancer');

		
-- trial registry entry
_oid = _sid ||' :: 13 :: ISRCTN registry entry';

call expected.insert_data_object(sd_oid => _oid, sid => _sid,
	title => _title || ' :: ISRCTN registry entry',
	doid => 'https://doi.org/10.1186/ISRCTN88368130', doidsid => 1,
	pubyear => 2020, obclassid => 23, obtypeid => 13,
	managingorgid => 100126, managingorgname=> 'ISRCTN',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid,
	typeid => 22, title => _title || ' :: ISRCTN registry entry', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid,
    reporgid => 100126, reporgname => 'ISRCTN', 
	purl => 'https://www.isrctn.com/' || _sid,  
	restypeid => 35);

call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2020 Jun 9', syear => 2020, smonth => 6, sday => 9);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2021 Dec 16', syear => 2021, smonth => 12, sday => 16);

_oid = _sid ||' :: 19 :: ISRCTN88368130_PIS.pdf';

call expected.insert_data_object(sd_oid => _oid, sid => _sid,
title => _title || ' :: ISRCTN88368130_PIS.pdf', 
obclassid => 23, obtypeid => 19, 
managingorgid => 100126, managingorgname => 'ISRCTN', 
acctypeid => 11, eosccat => 0);

call expected.insert_object_title(sd_oid => _oid, typeid => 20, 
title => _title || ' :: ISRCTN88368130_PIS.pdf', isdefault => true);

call expected.insert_object_instance(sd_oid => _oid, reporgid => 100126, reporgname => 'ISRCTN', 
purl => 'https://www.isrctn.com/editorial/retrieveFile/51892cf1-c381-43fc-8930-d146ea1a6d83/38390', 
restypeid => 11);

end;
$BODY$;
ALTER PROCEDURE expected.study_isrctn88368130()
    OWNER TO postgres;

             */           
        }
        
        if (sd_sid == "ISRCTN82138287")
        {
            /*
            -- PROCEDURE: expected.study_isrctn82138287()

-- DROP PROCEDURE IF EXISTS expected.study_isrctn82138287();

CREATE OR REPLACE PROCEDURE expected.study_isrctn82138287(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'ISRCTN82138287';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'A Mechanistic Study Of Mifamurtide (MTPPE) In Patients With Metastatic And/Or Recurrent Osteosarcoma';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc => 'Study hypothesis: This is a Bayesian designed multi-arm, multi-centre open-label phase II study in patients with metastatic and/or recurrent osteosarcoma, which will investigate why some patients with osteosarcoma may respond better than others to mifamurtide given alone or in combination with ifosfamide.
Primary outcome(s): Objective Radiological response; Timepoint(s): Pre-treatment, after 6, 12, 18, 24 & 36 weeks of treatment',
						dss => 'IPD sharing statement: The data sharing plans for the current study are unknown and will be made available at a later date.
IPD: To be made available at a later date'
					   );

call expected.insert_study_details(sid => _sid, syear => 2014, smonth => 9, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => 'Planned Sample Size: 40; UK Sample Size: 10', eligid => 900, minage => 18, minageu => 17, maxage => 65, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From ISRCTN');
call expected.insert_study_title(sid => _sid, typeid => 14, 
                         title => 'MEMOS: a Eurosarc Study of Mifamurtide in advanced osteosarcoma', isdefault => false, comms => 'From ISRCTN');		
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100126, idorgname => 'ISRCTN', iddate => '2014 Sep 18');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => '2012-000615-84', idorgid => 100123, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT02441309', idorgid => 100120, idorgname => 'EU Clinical Trials Register');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => '16801', idorgname => 'University of Oxford (UK)');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Linda Collins');
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'University of Oxford (UK)');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'European Commission');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'Millenium Pharmaceuticals Inc (USA)');

call expected.insert_study_feature(sid => _sid, typeid => 21, valueid  => 400);
call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 120);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 525);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Mifamurtide, Ifosfamide');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Topic: Cancer; Subtopic: Sarcoma; Disease: Bone');

		
-- trial registry entry
_oid = _sid ||' :: 13 :: ISRCTN registry entry';

call expected.insert_data_object(sd_oid => _oid, sid => _sid,  
	title => _title || ' :: ISRCTN registry entry',
	doid => 'https://doi.org/10.1186/ISRCTN82138287', doidsid => 1,
	pubyear => 2014, obclassid => 23, obtypeid => 13,
	managingorgid => 100126, managingorgname=> 'ISRCTN',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: ISRCTN registry entry', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100126, reporgname => 'ISRCTN', 
	purl => 'https://www.isrctn.com/' || _sid,  
	restypeid => 35);

call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2014 Sep 18', syear => 2014, smonth => 9, sday => 18);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2019 Jun 11', syear => 2019, smonth => 6, sday => 11);

end;
$BODY$;
ALTER PROCEDURE expected.study_isrctn82138287()
    OWNER TO postgres;

             */            
        }

        return null;
    }
}