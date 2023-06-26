namespace MDR_Tester;

public class TestData_101900 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "BABY HUG")
        {
            /*
            -- PROCEDURE: expected.study_baby_hug()

-- DROP PROCEDURE IF EXISTS expected.study_baby_hug();

CREATE OR REPLACE PROCEDURE expected.study_baby_hug(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE 
_sid VARCHAR := 'BABY HUG';
_access_details VARCHAR := 'Investigators wishing to request materials from studies ... must register (free) on the BioLINCC website. Registered investigators may then request detailed searches and submit an application for data sets and/or biospecimens. (from the BioLINCC website)';
_de_identification VARCHAR := 'All BioLINCC data and biospecimens are de-identified. Obvious subject identifiers and data collected solely for administrative purposes are redacted from datasets, and dates are recoded relative to a specific reference point. In addition recodes of selected low-frequency data values may be carried out to protect subject privacy and minimize re-identification risks (from the BioLINCC documentation).';
_title VARCHAR;
_oid VARCHAR;

begin

-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

--(first title from CTG, used for data objects)
_title = 'Long-Term Effects of Hydroxyurea in Children With Sickle Cell Anemia (The BABY HUG Follow-up Study)';

call expected.insert_study_names(sid => _sid, 
						title => 'Hydroxyurea to Prevent Organ Damage in Children with Sickle Cell Anemia (BABY HUG) Phase III Clinical Trial and Follow-Up Observational Studies I and II', 
						brief_desc => 'Objectives: The purpose of the Randomized Controlled Trial was to determine if hydroxyurea can safely prevent early end organ damage in very young children with sickle cell anemia.
The purpose of the BABY HUG Follow-up Study I was to provide structured follow-up of the children enrolled in the BABY HUG Randomized Controlled Trial, in order to characterize the long-term toxicities and unexpected risks (if any) associated with treatment with hydroxyurea at an early age.
The objective of Follow-Up Study II was to obtain additional data about the long-term safety and efficacy of hydroxyurea use in children with Sickle Cell Anemia through at least the first decade of life.'
					   );

call expected.insert_study_details(sid => _sid, syear => 2000, smonth => 8, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 915, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 18, 
                         title => 'Hydroxyurea to Prevent Organ Damage in Children with Sickle Cell Anemia (BABY HUG) Phase III Clinical Trial and Follow-Up Observational Studies I and II', 
						 isdefault => true, comms => 'From BioLINCC web page');
-- acronym					 
call expected.insert_study_title(sid => _sid, typeid => 14, 
                         title => 'BABY HUG', 
						 isdefault => false, comms => 'From BioLINCC web page');

	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT00006400', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT00890396', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT01783990', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 42, idvalue => 'HLB02352022a', idorgid => 100167, idorgname => 'National Heart, Lung, and Blood Institute (US)');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgid => 100167, orgname => 'National Heart, Lung, and Blood Institute (US)');

call expected.insert_study_reference(sid => _sid, ppmid => '21571150', 
			pdoi => 'https://www.ncbi.nlm.nih.gov/pubmed/21571150', comms => 'primary');

-- trial registry entry
_oid = _sid ||' :: 38 :: NHLBI web page';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
	title => _title,
	title_qualifier => 'NHLBI web page',
	obclassid => 23, obtypeid => 38,
	managingorgid => 100167, managingorgname=> 'National Heart, Lung, and Blood Institute (US)',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 101900, reporgname => 'BioLINCC', 
	purl => 'https://biolincc.nhlbi.nih.gov/studies/baby_hug/', 
	restypeid => 35);

-- datasets
_oid = _sid ||' :: 80 :: Individual participant data';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
	title => _title,
	title_qualifier => 'Individual participant data',
	pubyear => 2022, obclassid => 14, obtypeid => 80,
	managingorgid => 100167, managingorgname=> 'National Heart, Lung, and Blood Institute (US)',
	acctypeid => 17, accdetails => _access_details, 
	accdetsurl => 'https://biolincc.nhlbi.nih.gov/media/guidelines/handbook.pdf?link_time=2019-12-13_11:33:44.807479#page=15',
	urlchecked => '2021-07-23', eosccat => 3, title_typeid => 22);

call expected.insert_object_dataset (sd_oid => _oid, 
     deidenttypeid => 2, deidentdets => _de_identification
     , consenttypeid => 6, consentdets => 'Restrictions reported on the use of data depending on the area of research. Use of data and/or specimens is limited to research on sickle cell anemia and related disorders.');

call expected.insert_object_date(sd_oid => _oid, 
    typeid => 18, datestring => '2022 Feb 7',
	syear => 2022, smonth => 2, sday => 7);

-- other objects
_oid = _sid ||' :: 31 :: Data Dictionary';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'Data Dictionary',	    
	   pubyear => null, obclassid => 23, obtypeid => 31, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/data_dictionary/Baby_HUG_2021a.pdf', 
	   restypeid => 11, ressize => '3.1', ressizeu => 'MB');

_oid = _sid ||' :: 30 :: BABY HUG Follow-up Study II Annotated CRFs';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'BABY HUG Follow-up Study II Annotated CRFs',
	   pubyear => null, obclassid => 23, obtypeid => 30, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);

call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_II_Annotated_CRFs.pdf', 
	   restypeid => 11, ressize => '1.2', ressizeu => 'MB');
       
_oid = _sid ||' :: 35 :: BABY HUG Follow-up Study II Manual of Operations';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'BABY HUG Follow-up Study II Manual of Operations',	   
	   pubyear => null, obclassid => 23, obtypeid => 35, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_II_Manual_of_Operations.pdf', 
	   restypeid => 11, ressize => '2.3', ressizeu => 'MB');

_oid = _sid ||' :: 11 :: BABY HUG Follow-up Study II Protocol';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'BABY HUG Follow-up Study II Protocol',	   
	   pubyear => null, obclassid => 23, obtypeid => 11, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_II_Protocol.pdf', 
	   restypeid => 11, ressize => '568.5', ressizeu => 'KB');

_oid = _sid ||' :: 30 :: BABY HUG Follow-up Study I Annotated CRFs';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'BABY HUG Follow-up Study I Annotated CRFs',	   
	   pubyear => null, obclassid => 23, obtypeid => 30, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_I_Annotated_CRFs.pdf', 
	   restypeid => 11, ressize => '5.8', ressizeu => 'MB');

_oid = _sid ||' :: 35 :: BABY HUG Follow-up Study I Manual of Operations';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'BABY HUG Follow-up Study I Manual of Operations',	   
	   pubyear => null, obclassid => 23, obtypeid => 35, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_I_Manual_of_Operations.pdf', 
	   restypeid => 11, ressize => '2.8', ressizeu => 'MB');

_oid = _sid ||' :: 11 :: BABY HUG Follow-up Study I Protocol';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'BABY HUG Follow-up Study I Protocol',	   
	   pubyear => null, obclassid => 23, obtypeid => 11, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_Follow-up_Study_I_Protocol.pdf', 
	   restypeid => 11, ressize => '659.8', ressizeu => 'KB');

_oid = _sid ||' :: 30 :: BABY HUG RCT Annotated CRFs';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'BABY HUG RCT Annotated CRFs',	   
	   pubyear => null, obclassid => 23, obtypeid => 30, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_RCT_Annotated_CRFs.pdf', 
	   restypeid => 11, ressize => '3.3', ressizeu => 'MB');

_oid = _sid ||' :: 35 :: BABY HUG RCT Manual of Operations';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'BABY HUG RCT Manual of Operations',	   
	   pubyear => null, obclassid => 23, obtypeid => 35, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_RCT_Manual_of_Operations.pdf', 
	   restypeid => 11, ressize => '2.7', ressizeu => 'MB');	   

_oid = _sid ||' :: 11 :: BABY HUG RCT Protocol';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title, 
       title_qualifier => 'BABY HUG RCT Protocol',	   
	   pubyear => null, obclassid => 23, obtypeid => 11, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/baby_hug/BABY_HUG_RCT_Protocol.pdf', 
	   restypeid => 11, ressize => '1.2', ressizeu => 'MB');	
end;
$BODY$;
ALTER PROCEDURE expected.study_baby_hug()
    OWNER TO postgres;

             */
        }
        
        if (sd_sid == "ACRN-BAGS")
        {
            /*
           -- PROCEDURE: expected.study_acrn_bags()

-- DROP PROCEDURE IF EXISTS expected.study_acrn_bags();

CREATE OR REPLACE PROCEDURE expected.study_acrn_bags(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE 
_sid VARCHAR := 'ACRN-BAGS';
_access_details VARCHAR := 'Investigators wishing to request materials from studies ... must register (free) on the BioLINCC website. Registered investigators may then request detailed searches and submit an application for data sets and/or biospecimens. (from the BioLINCC website)';
_de_identification VARCHAR := 'All BioLINCC data and biospecimens are de-identified. Obvious subject identifiers and data collected solely for administrative purposes are redacted from datasets, and dates are recoded relative to a specific reference point. In addition recodes of selected low-frequency data values may be carried out to protect subject privacy and minimize re-identification risks (from the BioLINCC documentation).';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'Asthma Clinical Research Network (ACRN) Beta Agonist in Mild Asthma Study (BAGS)';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc =>'Objectives: An important question in current asthma research is whether regularly scheduled treatment with inhaled Beta-agonists in asthmatics produces adverse effects on asthma control. Because an estimated 60-70% of patients with asthma have mild disease and are treated only with inhaled Beta2-adrenergic agonists of medium duration, a firm basis upon which to make treatment recommendations for this large number of patients was critically needed. Therefore, the ACRN developed a protocol to test the following null hypothesis: In patients with mild asthma, whose only asthma treatment is inhaled Beta-agonists, addition of regular inhaled Beta-agonist treatment to treatment on an "as needed only" basis will result in no effect on asthma control.'
					   );

call expected.insert_study_details(sid => _sid, syear => 1994, smonth => null, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 915, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 18, 
                         title => _title,
						 isdefault => true, comms => 'From BioLINCC web page');
-- acronym					 
call expected.insert_study_title(sid => _sid, typeid => 14, 
                         title => 'ACRN-BAGS', 
						 isdefault => false, comms => 'From BioLINCC web page');
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT00000577', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 42, idvalue => 'HLB00140202a', idorgid => 100167, idorgname => 'National Heart, Lung, and Blood Institute (US)');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgid => 100375, orgname => 'Milton S Hershey Medical Center');

-- trial registry entry
_oid = _sid ||' :: 38 :: NHLBI web page';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
	title => _title,
	title_qualifier => 'NHLBI web page',
	pubyear => null, obclassid => 23, obtypeid => 38,
	managingorgid => 100167, managingorgname=> 'National Heart, Lung, and Blood Institute (US)',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 101900, reporgname => 'BioLINCC', 
	purl => 'https://biolincc.nhlbi.nih.gov/studies/bags/', 
	restypeid => 35);

-- datasets
_oid = _sid ||' :: 80 :: Individual participant data';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
	title => _title,
	title_qualifier => 'Individual participant data',
	pubyear => 2018, obclassid => 14, obtypeid => 80,
	managingorgid => 100167, managingorgname=> 'National Heart, Lung, and Blood Institute (US)',
	acctypeid => 17, accdetails => _access_details, 
	accdetsurl => 'https://biolincc.nhlbi.nih.gov/media/guidelines/handbook.pdf?link_time=2019-12-13_11:33:44.807479#page=15',
	urlchecked => '2021-07-23', eosccat => 3, title_typeid => 22);

call expected.insert_object_dataset (sd_oid => _oid, 
    deidenttypeid => 2, deidentdets => _de_identification);

call expected.insert_object_date(sd_oid => _oid, 
    typeid => 18, datestring => '2018 Jan 3',
	syear => 2018, smonth => 1, sday => 3);
    
-- other objects
_oid = _sid ||' :: 31 :: Data Dictionary';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'Data Dictionary',	   
	   pubyear => null, obclassid => 23, obtypeid => 31, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/bags/data_dictionary/ACRN_BAGS.pdf', 
	   restypeid => 11, ressize => '240.2', ressizeu => 'KB');

_oid = _sid ||' :: 36 :: Manual';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'Manual',
	   pubyear => null, obclassid => 23, obtypeid => 36, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);

call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/bags/Manual.pdf', 
	   restypeid => 11, ressize => '250.3', ressizeu => 'KB');

_oid = _sid ||' :: 86 :: Forms';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Forms',	   
	   pubyear => null, obclassid => 23, obtypeid => 86, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 12, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/studies/bags/Forms/', 
	   restypeid => 35);
end;
$BODY$;
ALTER PROCEDURE expected.study_acrn_bags()
    OWNER TO postgres;

            */           
        }

        if (sd_sid == "TOPCAT")
        {
            /*
            -- PROCEDURE: expected.study_topcat()

-- DROP PROCEDURE IF EXISTS expected.study_topcat();

CREATE OR REPLACE PROCEDURE expected.study_topcat(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE 
_sid VARCHAR := 'TOPCAT';
_access_details VARCHAR := 'Investigators wishing to request materials from studies ... must register (free) on the BioLINCC website. Registered investigators may then request detailed searches and submit an application for data sets and/or biospecimens. (from the BioLINCC website)';
_de_identification VARCHAR := 'All BioLINCC data and biospecimens are de-identified. Obvious subject identifiers and data collected solely for administrative purposes are redacted from datasets, and dates are recoded relative to a specific reference point. In addition recodes of selected low-frequency data values may be carried out to protect subject privacy and minimize re-identification risks (from the BioLINCC documentation).';
_title VARCHAR;
_oid VARCHAR;

begin

-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

--(first title from CTG, used for data objects)
_title := 'Aldosterone Antagonist Therapy for Adults With Heart Failure and Preserved Systolic Function';
call expected.insert_study_names(sid => _sid, 
						title =>'Treatment of Preserved Cardiac Function Heart Failure With an Aldosterone Antagonist (TOPCAT)', 
						brief_desc =>'Objectives: The TOPCAT trial evaluated the effectiveness of aldosterone antagonist therapy in reducing cardiovascular mortality, aborted cardiac arrest, and heart failure hospitalization in patients who have heart failure with preserved systolic function.'
					   );

call expected.insert_study_details(sid => _sid, syear => 2006, smonth => 8, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 915, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 18, 
                         title => 'Treatment of Preserved Cardiac Function Heart Failure With an Aldosterone Antagonist (TOPCAT)', 
						 isdefault => true, comms => 'From BioLINCC web page');
-- acronym					 
call expected.insert_study_title(sid => _sid, typeid => 14, 
                         title => 'TOPCAT', 
						 isdefault => false, comms => 'From BioLINCC web page');

	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT00094302', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 42, idvalue => 'HLB01341616a', idorgid => 100167, idorgname => 'National Heart, Lung, and Blood Institute (US)');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgid => 101993, orgname => 'HealthCore-NERI');

-- trial registry entry
_oid = _sid ||' :: 38 :: NHLBI web page';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,  
	title => _title,
	title_qualifier => 'NHLBI web page',
	pubyear => null, obclassid => 23, obtypeid => 38,
	managingorgid => 100167, managingorgname=> 'National Heart, Lung, and Blood Institute (US)',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 101900, reporgname => 'BioLINCC', 
	purl => 'https://biolincc.nhlbi.nih.gov/studies/topcat/', 
	restypeid => 35);
	

-- datasets
_oid = _sid ||' :: 80 :: Individual participant data';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
	title => _title,
	title_qualifier => 'Individual participant data',
	pubyear => 2019, obclassid => 14, obtypeid => 80,
	managingorgid => 100167, managingorgname=> 'National Heart, Lung, and Blood Institute (US)',
	acctypeid => 17, accdetails => _access_details, 
	accdetsurl => 'https://biolincc.nhlbi.nih.gov/media/guidelines/handbook.pdf?link_time=2019-12-13_11:33:44.807479#page=15',
	urlchecked => '2021-07-23', eosccat => 3, title_typeid => 22);

call expected.insert_object_dataset (sd_oid => _oid, 
     deidenttypeid => 2, deidentdets => _de_identification
   , consenttypeid => 6, consentdets => 'Consent for the use of biospecimens in genetic research is tiered to (1) research related to heart disease, stroke, kidney diseases, other cardiovascular diseases, or risk factors associated with these diseases and (2) research related to any disease, health condition or risk factors. Use of biospecimens in non-genetic research is unrestricted.');

call expected.insert_object_date(sd_oid => _oid, 
    typeid => 18, datestring => '2019 Feb 20',
	syear => 2019, smonth => 2, sday => 20);
    
-- other objects
_oid = _sid ||' :: 31 :: Data Dictionary';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,  
       title => _title,
       title_qualifier => 'Data Dictionary',	   
	   pubyear => null, obclassid => 23, obtypeid => 31, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/topcat/data_dictionary/TOPCAT_v2016b.pdf', 
	   restypeid => 11, ressize => '795.3', ressizeu => 'KB');

_oid = _sid ||' :: 21 :: Forms';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Forms',
	   pubyear => null, obclassid => 23, obtypeid => 21, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);

call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/topcat/Forms.pdf', 
	   restypeid => 11, ressize => '5.3', ressizeu => 'MB');

_oid = _sid ||' :: 35 :: Manual of Operations';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Manual of Operations',	   
	   pubyear => null, obclassid => 23, obtypeid => 35, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/topcat/Manual_of_Operations.pdf', 
	   restypeid => 11, ressize => '1.8', ressizeu => 'MB');

_oid = _sid ||' :: 11 :: Protocols';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Protocols',	   
	   pubyear => null, obclassid => 23, obtypeid => 11, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/topcat/Protocols.pdf', 
	   restypeid => 11, ressize => '1.8', ressizeu => 'MB');
	
	
call expected.insert_study_reference(sid => _sid, ppmid => '24716680', pdoi => 'https://www.ncbi.nlm.nih.gov/pubmed/24716680', comms => 'primary');
call expected.insert_study_reference(sid => _sid, ppmid => '31838199', 
 pcitation => 'Adabag S, Langsetmo L. Sudden cardiac death risk prediction in heart failure with preserved ejection fraction. Heart Rhythm 2020 Mar;17(3):358-364. Epub 2019 Dec 13.',
			pdoi => 'bb7380553e0c4745a062406843f78b22', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31230508', 
 pcitation => 'Beale AL, Nanayakkara S, Kaye DM. Impact of Sex on Ventricular-Vascular Stiffness and Long-Term Outcomes in Heart Failure With Preserved Ejection Fraction: TOPCAT Trial Substudy. J Am Heart Assoc 2019 Jul 2;8(13):e012190. Epub 2019 Jun 22.',
			pdoi => '9705894e33d743ca86693716494142a9', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '30857413', 
 pcitation => 'Berkowitz SA, Rudolph KE, Basu S. Detecting Anomalies Among Practice Sites Within Multicenter Trials. Circ Cardiovasc Qual Outcomes 2019 Mar;12(3):e004907.',
			pdoi => '225391cc827e4601a6b6acc26c484527', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '30189998', 
 pcitation => 'Berkowitz SA, Sussman JB, Jonas DE, Basu S. Generalizing Intensive Blood Pressure Treatment to Adults With Diabetes Mellitus. J Am Coll Cardiol 2018 Sep 11;72(11):1214-1223.',
			pdoi => '93c88c882f264dad96d248d4cabd08b9', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29424469', 
 pcitation => 'Buckley LF, Dixon DL, Wohlford GF 4th, Wijesinghe DS, Baker WL, Van Tassell BW. Effect of intensive blood pressure control in patients with type 2 diabetes mellitus over 9 years of follow-up: A subgroup analysis of high-risk ACCORDION trial participants. Diabetes Obes Metab 2018 Jun;20(6):1499-1502. Epub 2018 Mar 2.',
			pdoi => '9d59f37cd472448e803c63a42bb66af9', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31771438', 
 pcitation => 'Caraballo C, Desai NR, Mulder H, Alhanti B, Wilson FP, Fiuzat M, Felker GM, Piña IL, O’Connor CM, Lindenfeld J, Januzzi JL, Cohen LS, Ahmad T. Clinical Implications of the New York Heart Association Classification. J Am Heart Assoc 2019 Dec 3;8(23):e014240. Epub 2019 Nov 27.',
			pdoi => 'c52f71df349b4d5dbaf3fbed0f9def37', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31926856', 
 pcitation => 'Cohen JB, Schrauben SJ, Zhao L, Basso MD, Cvijic ME, Li Z, Yarde M, Wang Z, Bhattacharya PT, Chirinos DA, Prenner S, Zamani P, Seiffert DA, Car BD, Gordon DA, Margulies K, Cappola T, Chirinos JA. Clinical Phenogroups in Heart Failure With Preserved Ejection Fraction: Detailed Phenotypes, Prognosis, and Response to Spironolactone. JACC Heart Fail 2020 Mar;8(3):172-184. Epub 2020 Jan 8.',
			pdoi => 'e7d11b6b65eb4ba5b5edacad09f32dea', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '14966769', 
 pcitation => 'Curtis JP, Rathore SS, Wang Y, Krumholz HM. The association of 6-minute walk performance and outcomes in stable outpatients with heart failure. J Card Fail 2004 Feb;10(1):9-14.',
			pdoi => '92f20d8af2e84784a84295a589bb81c1', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31813280', 
 pcitation => 'Dewan P, Rørth R, Raparelli V, Campbell RT, Shen L, Jhund PS, Petrie MC, Anand IS, Carson PE, Desai AS, Granger CB, Køber L, Komajda M, McKelvie RS, O’Meara E, Pfeffer MA, Pitt B, Solomon SD, Swedberg K, Zile MR, McMurray JJV. Sex-Related Differences in Heart Failure With Preserved Ejection Fraction. Circ Heart Fail 2019 Dec;12(12):e006539. Epub 2019 Dec 9.',
			pdoi => 'dd065552c7c240abb6eb2767f07d3cbe', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '33529620', 
 pcitation => 'Elkholey K, Papadimitriou L, Butler J, Thadani U, Stavrakis S. Effect of Obesity on Response to Spironolactone in Patients With Heart Failure With Preserved Ejection Fraction. Am J Cardiol 2021 May 1;146:36-47. Epub 2021 Jan 30.',
			pdoi => '14fe316ce9f64f558ae65cef1b55f28b', comms => 'associated');				
call expected.insert_study_reference(sid => _sid, ppmid => '31779922', 
 pcitation => 'Ferreira JP, Rossello X, Eschalier R, McMurray JJV, Pocock S, Girerd N, Rossignol P, Pitt B, Zannad F. MRAs in Elderly HF Patients: Individual Patient-Data Meta-Analysis of RALES, EMPHASIS-HF, and TOPCAT. JACC Heart Fail 2019 Dec;7(12):1012-1021.',
			pdoi => '0c20257c42e54f7987b0e63e2bba4172', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '30714658', 
 pcitation => 'Grodin JL, Philips S, Mullens W, Nijst P, Martens P, Fang JC, Drazner MH, Tang WHW, Pandey A. Prognostic implications of plasma volume status estimates in heart failure with preserved ejection fraction: insights from TOPCAT. Eur J Heart Fail 2019 May;21(5):634-642. Epub 2019 Feb 4.',
			pdoi => '1491696ccfb1453e8f243ca64c3cb822', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29893446', 
 pcitation => 'Grodin JL, Testani JM, Pandey A, Sambandam K, Drazner MH, Fang JC, Tang WHW. Perturbations in serum chloride homeostasis in heart failure with preserved ejection fraction: insights from TOPCAT. Eur J Heart Fail 2018 Oct;20(10):1436-1443. Epub 2018 Jun 12.',
			pdoi => '433a0e477bd84293a65eee32d49acec2', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '32151432', 
 pcitation => 'Gupta K, Kalra R, Rajapreyar I, Joly JM, Pate M, Cribbs MG, Ather S, Prabhu SD, Bajaj NS. Anemia, Mortality, and Hospitalizations in Heart Failure With a Preserved Ejection Fraction (from the TOPCAT Trial). Am J Cardiol 2020 May 1;125(9):1347-1354. Epub 2020 Feb 8.',
			pdoi => 'eaf032f35e1948c1a5358eba93c51613', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '32354389', 
 pcitation => 'Javaheri A, Allegood JC, Cowart LA, Chirinos JA. Circulating Ceramide 16:0 in Heart Failure With Preserved Ejection Fraction. J Am Coll Cardiol 2020 May 5;75(17):2273-2275.',
			pdoi => '69c8e1c36d0748a99805c7df049ee724', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '32469156', 
 pcitation => 'Kalogeropoulos AP, Thankachen J, Butler J, Fang JC. Diuretic and renal effects of spironolactone and heart failure hospitalizations: a TOPCAT Americas analysis. Eur J Heart Fail 2020 Sep;22(9):1600-1610. Epub 2020 Jun 26.',
			pdoi => '0bb7f302dca6414a959cce1dc7fa4961', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '30871349', 
 pcitation => 'Kristensen SL, Mogensen UM, Jhund PS, Rørth R, Anand IS, Carson PE, Desai AS, Pitt B, Pfeffer MA, Solomon SD, Zile MR, Køber L, McMurray JJV. N-Terminal Pro-B-Type Natriuretic Peptide Levels for Risk Prediction in Patients With Heart Failure and Preserved Ejection Fraction According to Atrial Fibrillation Status. Circ Heart Fail 2019 Mar;12(3):e005766.',
			pdoi => 'ddd166d63fe545be9846a095fe6fef40', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29460366', 
 pcitation => 'Lolli L, Batterham AM, Atkinson G. Ejection fraction as a statistical index of left ventricular systolic function: the first full allometric scrutiny of its appropriateness and accuracy. Clin Physiol Funct Imaging 2018 Feb 20. Epub 2018 Feb 20.',
			pdoi => '081aaa888acc493b9c0bd5965ec3bc5a', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '30819379', 
 pcitation => 'Merrill M, Sweitzer NK, Lindenfeld J, Kao DP. Sex Differences in Outcomes and Responses to Spironolactone in Heart Failure With Preserved Ejection Fraction: A Secondary Analysis of TOPCAT Trial. JACC Heart Fail 2019 Mar;7(3):228-238.',
			pdoi => 'b8b553211bd54a9eb7a2339d709fe032', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31214914', 
 pcitation => 'Neefs J, van den Berg NWE, Krul SPJ, Boekholdt SM, de Groot JR. Effect of Spironolactone on Atrial Fibrillation in Patients with Heart Failure with Preserved Ejection Fraction: Post-Hoc Analysis of the Randomized, Placebo-Controlled TOPCAT Trial. Am J Cardiovasc Drugs 2020 Feb;20(1):73-80.',
			pdoi => 'e7d88aca32234b13a841d7a09e666957', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '28395886', 
 pcitation => 'O’Neal WT, Sandesara P, Hammadah M, Venkatesh S, Samman-Tahhan A, Kelli HM, Soliman EZ. Gender Differences in the Risk of Adverse Outcomes in Patients With Atrial Fibrillation and Heart Failure With Preserved Ejection Fraction. Am J Cardiol 2017 Jun 1;119(11):1785-1790. Epub 2017 Mar 16.',
			pdoi => '03cfc1fecf7241829ed9fc332fcb0943', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '28379310', 
 pcitation => 'O’Neal WT, Sandesara P, Patel N, Venkatesh S, Samman-Tahhan A, Hammadah M, Kelli HM, Soliman EZ. Echocardiographic predictors of atrial fibrillation in patients with heart failure with preserved ejection fraction. Eur Heart J Cardiovasc Imaging 2017 Jul 1;18(7):725-729.',
			pdoi => '3e8da652f6b24155af89c18c8c2fdf62', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '28482692', 
 pcitation => 'O’Neal WT, Sandesara PB, Samman-Tahhan A, Kelli HM, Hammadah M, Soliman EZ. Heart rate and the risk of adverse outcomes in patients with heart failure with preserved ejection fraction. Eur J Prev Cardiol 2017 Jul;24(11):1212-1219. Epub 2017 May 9.',
			pdoi => '3383d5964a854dc8b3efb4b7ed5e0928', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '30376747', 
 pcitation => 'Pandey A, Berry JD, Drazner MH, Fang JC, Tang WHW, Grodin JL. Body Mass Index, Natriuretic Peptides, and Risk of Adverse Outcomes in Patients With Heart Failure and Preserved Ejection Fraction: Analysis From the TOPCAT Trial. J Am Heart Assoc 2018 Nov 6;7(21):e009664.',
			pdoi => '1f8f509087464208bd083f253001b83f', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '34023263', 
 pcitation => 'Pandey A, Kagiyama N, Yanamala N, Segar MW, Cho JS, Tokodi M, Sengupta PP. Deep-Learning Models for the Echocardiographic Assessment of Diastolic Dysfunction. JACC Cardiovasc Imaging 2021 May 12. Epub 2021 May 12.',
			pdoi => '21de9d4399974620ab44ee5f54b01146', comms => 'associated');            
call expected.insert_study_reference(sid => _sid, ppmid => '30933394', 
 pcitation => 'Pandey A, Patel KV, Ayers C, Tang WHW, Fang JC, Drazner MH, Berry J, Grodin JL. Temporal association between hospitalization event and subsequent risk of mortality among patients with stable chronic heart failure with preserved ejection fraction: insights from the TOPCAT trial. Eur J Heart Fail 2019 May;21(5):693-695. Epub 2019 Apr 1.',
			pdoi => '08d9a532421a4d08a1066518e43ae33c', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '28660734', 
 pcitation => 'Patel N, O’Neal WT, Whalen SP, Soliman EZ. The association of QT interval components with atrial fibrillation. Ann Noninvasive Electrocardiol 2018 Mar;23(2):e12467. Epub 2017 Jun 29.',
			pdoi => '6479857210334423ac7e52a96e498129', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29094152', 
 pcitation => 'Pokharel Y, Khariton Y, Tang Y, Nassif ME, Chan PS, Arnold SV, Jones PG, Spertus JA. Association of Serial Kansas City Cardiomyopathy Questionnaire Assessments With Death and Hospitalization in Patients With Heart Failure With Preserved and Reduced Ejection Fraction: A Secondary Analysis of 2 Randomized Clinical Trials. JAMA Cardiol 2017 Dec 1;2(12):1315-1321.',
			pdoi => 'd43fa1813ffd47059086deabbace95d8', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31843232', 
 pcitation => 'Prenner SB, Kumar A, Zhao L, Cvijic ME, Basso M, Spires T, Li Z, Yarde M, Bhattacharya P, Zamani P, Mazurek J, Wang Z, Seiffert D, Gordon DA, Chirinos JA. Effect of Serum Albumin Levels in Patients With Heart Failure With Preserved Ejection Fraction (from the TOPCAT Trial). Am J Cardiol 2020 Feb 15;125(4):575-582. Epub 2019 Nov 19.',
			pdoi => '4c974916eccc4ea18c22f0d6fc8f04b0', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '33279481', 
 pcitation => 'Rahimi G, Tecson KM, Elsaid O, McCullough PA. Role of Ischemic Heart Disease in Major Adverse Renal and Cardiac Events Among Individuals With Heart Failure With Preserved Ejection Fraction (from the TOPCAT Trial). Am J Cardiol 2021 Mar 1;142:91-96. Epub 2020 Dec 3.',
			pdoi => '740ea0d61fb74c8ca3c40a6a5a48f07a', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '28444995', 
 pcitation => 'Sandesara PB, Hammadah M, Samman-Tahhan A, Kelli HM, O’Neal WT. Peripheral artery disease and risk of adverse outcomes in heart failure with preserved ejection fraction. Clin Cardiol 2017 Sep;40(9):692-696. Epub 2017 Apr 26.',
			pdoi => 'a7c6d24f3227464f84d19a80f9cf63b8', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29051160', 
 pcitation => 'Sandesara PB, O’Neal WT, Kelli HM, Samman-Tahhan A, Hammadah M, Quyyumi AA, Sperling LS. The Prognostic Significance of Diabetes and Microvascular Complications in Patients With Heart Failure With Preserved Ejection Fraction. Diabetes Care 2018 Jan;41(1):150-155. Epub 2017 Oct 19.',
			pdoi => '2b971a58aac1438dabfcf2e38ca88c77', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29475874', 
 pcitation => 'Sandesara PB, O’Neal WT, Kelli HM, Topel M, Samman-Tahhan A, Sperling LS. Diastolic Blood Pressure and Adverse Outcomes in the TOPCAT (Treatment of Preserved Cardiac Function Heart Failure With an Aldosterone Antagonist) Trial. J Am Heart Assoc 2018 Feb 23;7. (5).',
			pdoi => '0de9e85a892e40b6adbe205ec60f1c6d', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '30201107', 
 pcitation => 'Sandesara PB, Samman-Tahhan A, Topel M, Venkatesh S, O’Neal WT. Effect of Cigarette Smoking on Risk for Adverse Events in Patients With Heart Failure and Preserved Ejection Fraction. Am J Cardiol 2018 Aug 1;122(3):400-404. Epub 2018 May 1.',
			pdoi => '034e1627819845feb1c6eb3c20827d63', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31637815', 
 pcitation => 'Segar MW, Patel KV, Ayers C, Basit M, Tang WHW, Willett D, Berry J, Grodin JL, Pandey A. Phenomapping of patients with heart failure with preserved ejection fraction using machine learning-based unsupervised cluster analysis. Eur J Heart Fail 2020 Jan;22(1):148-158. Epub 2019 Oct 21.',
			pdoi => '3604b26d6eb74359b567dee9ba6b366c', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31271255', 
 pcitation => 'Shen L, Rørth R, Cosmi D, Kristensen SL, Petrie MC, Cosmi F, Latini R, Køber L, Anand IS, Carson PE, Granger CB, Komajda M, McKelvie RS, Solomon SD, Staszewsky L, Swedberg K, Huynh T, Zile MR, Jhund PS, McMurray JJV. Insulin treatment and clinical outcomes in patients with diabetes and heart failure with preserved ejection fraction. Eur J Heart Fail 2019 Aug;21(8):974-984. Epub 2019 Jul 4.',
			pdoi => 'f2136efba20b4d9e83f9b7568ab36f97', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31800067', 
 pcitation => 'Silverman DN, Plante TB, Infeld M, Callas PW, Juraschek SP, Dougherty GB, Meyer M. Association of β-Blocker Use With Heart Failure Hospitalizations and Cardiovascular Disease Mortality Among Patients With Heart Failure With a Preserved Ejection Fraction: A Secondary Analysis of the TOPCAT Trial. JAMA Netw Open 2019 Dec 2;2(12):e1916598.',
			pdoi => '08986735b8434bd08e06370c3d93f1c0', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '33111482', 
 pcitation => 'Sperry BW, Tang Y, Jones PG, Spertus JA. Cumulative events in the TOPCAT trial. Eur J Heart Fail 2021 Mar;23(3):491-492. Epub 2020 Nov 13.',
		  pdoi => '1828f5f23fd04cd19c183c43e27b728e', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31370950', 
 pcitation => 'Tromp J, Shen L, Jhund PS, Anand IS, Carson PE, Desai AS, Granger CB, Komajda M, McKelvie RS, Pfeffer MA, Solomon SD, Køber L, Swedberg K, Zile MR, Pitt B, Lam CSP, McMurray JJV. Age-Related Characteristics and Outcomes of Patients With Heart Failure With Preserved Ejection Fraction. J Am Coll Cardiol 2019 Aug 6;74(5):601-612.',
			pdoi => '06238be0b368495b9903242fcf1c9179', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29191321', 
 pcitation => 'Tsujimoto T, Kajio H. Abdominal Obesity Is Associated With an Increased Risk of All-Cause Mortality in Patients With HFpEF. J Am Coll Cardiol 2017 Dec 5;70(22):2739-2749.',
			pdoi => 'ad4e37c47281419d9a7d665e2e8891e7', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29934526', 
 pcitation => 'Tsujimoto T, Kajio H. Beta-blocker use and cardiovascular event risk in patients with heart failure with preserved ejection fraction. Sci Rep 2018 Jun 22;8(1):9556.',
			pdoi => '97126373eb124a7d8ef184cd7eb66be3', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29808753', 
 pcitation => 'Tsujimoto T, Kajio H. Efficacy of renin-angiotensin system inhibitors for patients with heart failure with preserved ejection fraction and mild to moderate chronic kidney disease. Eur J Prev Cardiol 2018 Aug;25(12):1268-1277. Epub 2018 May 29.',
			pdoi => '3d77789898d04c7d9ef3a81f2328bd71', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29307549', 
 pcitation => 'Tsujimoto T, Kajio H. Favorable effects of statins in the treatment of heart failure with preserved ejection fraction in patients without ischemic heart disease. Int J Cardiol 2018 Mar 15;255:111-117. Epub 2018 Jan 4.',
			pdoi => '2cad4907ad5d484b9196429acd119c4d', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29661477', 
 pcitation => 'Tsujimoto T, Kajio H. Low diastolic blood pressure and adverse outcomes in heart failure with preserved ejection fraction. Int J Cardiol 2018 Jul 15;263:69-74. Epub 2018 Apr 9.',
			pdoi => 'c0be4e71b51c40558741fc4b8c14d9fc', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '33222584', 
 pcitation => 'Tsujimoto T, Kajio H. Spironolactone Use and Improved Outcomes in Patients With Heart Failure With Preserved Ejection Fraction With Resistant Hypertension. J Am Heart Assoc 2020 Dec;9(23):e018827. Epub 2020 Nov 23.',
			pdoi => 'f5c623bda2f34f8089c85dee29939f28', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31272569', 
 pcitation => 'Tsujimoto T, Kajio H. Use of Nitrates and Risk of Cardiovascular Events in Patients With Heart Failure With Preserved Ejection Fraction. Mayo Clin Proc 2019 Jul;94(7):1210-1220.',
			pdoi => '53d7f5e803b340e7b866ee2d73e58212', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29284111', 
 pcitation => 'Upshaw JN, van Klaveren D, Konstam MA, Kent DM. Digoxin Benefit Varies by Risk of Heart Failure Hospitalization: Applying the Tufts MC HF Risk Model. Am J Med 2018 Jun;131(6):676-683.e2. Epub 2017 Dec 25.',
			pdoi => 'd3131989c27542b69f5677172678ff0b', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29501807', 
 pcitation => 'Vaduganathan M, Claggett B, Packer M, McMurray JJV, Rouleau JL, Zile MR, Swedberg K, Solomon SD. Natriuretic Peptides as Biomarkers of Treatment Response in Clinical Trials of Heart Failure. JACC Heart Fail 2018 Jul;6(7):564-569. Epub 2018 Mar 4.',
			pdoi => '71b226fd4cd84050a2a7a3038f1d0ef8', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '34405581', 
 pcitation => 'Zhang Q, Zhou B, Ma Y, Hu Y, Li X, Cong H. Blood pressure visit-to-visit variability and outcomes in patients with heart failure with preserved ejection fraction. ESC Heart Fail 2021 Aug 18. Epub 2021 Aug 18.',
			pdoi => 'cbbd736ad7264729a0f4ad1156ebc916', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '33981733', 
 pcitation => 'Chen Z, Lin Q, Li J, Wang X, Ju J, Xu H, Shi D. Estimated Glomerular Filtration Rate Is Associated With an Increased Risk of Death in Heart Failure Patients With Preserved Ejection Fraction. Front Cardiovasc Med 2021 Apr 26;8:643358. doi: 10.3389/fcvm.2021.643358. eCollection 2021.',
			pdoi => 'baf8058c0f8e4f308cb339df92eba820', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '34628642', 
 pcitation => 'Leache L, Gutiérrez-Valencia M, Finizola RM, Infante E, Finizola B, Pardo Pardo J, Flores Y, Granero R, Arai KJ. Pharmacotherapy for hypertension-induced left ventricular hypertrophy. Cochrane Database Syst Rev 2021 Oct 10;10:CD012039.',
			pdoi => '3043299287ab40708aa9a1055f3801db', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '35015840', 
 pcitation => 'Wang X, Ju J, Chen Z, Lin Q, Zhang Z, Li Q, Zhang J, Xu H, Chen K. Associations between Calcium Channel Blockers Therapy and Mortality in Heart Failure with Preserved Ejection Fraction. Eur J Prev Cardiol 2022 Jan 7. Epub 2022 Jan 7.',
			pdoi => '58253719c16e4620bea2a69d14bb15ae', comms => 'associated');
end;
$BODY$;
ALTER PROCEDURE expected.study_topcat()
    OWNER TO postgres;

            */           
        }
        
        if (sd_sid == "ACRN-LARGE")
        {
            /*
            -- PROCEDURE: expected.study_acrn_large()

-- DROP PROCEDURE IF EXISTS expected.study_acrn_large();

CREATE OR REPLACE PROCEDURE expected.study_acrn_large(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE 
_sid VARCHAR := 'ACRN-LARGE';
_access_details VARCHAR := 'Investigators wishing to request materials from studies ... must register (free) on the BioLINCC website. Registered investigators may then request detailed searches and submit an application for data sets and/or biospecimens. (from the BioLINCC website)';
_de_identification VARCHAR := 'All BioLINCC data and biospecimens are de-identified. Obvious subject identifiers and data collected solely for administrative purposes are redacted from datasets, and dates are recoded relative to a specific reference point. In addition recodes of selected low-frequency data values may be carried out to protect subject privacy and minimize re-identification risks (from the BioLINCC documentation).';
_title VARCHAR;
_oid VARCHAR;

begin

-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'Asthma Clinical Research Network (ACRN) Trial - Long-Acting Beta Agonist Response by Genotype (LARGE)';

call expected.insert_study_names(sid => _sid, 
						title => 'Asthma Clinical Research Network Trial (ACRN) - Long-Acting Beta Agonist Response by Genotype (LARGE)', 
						brief_desc =>'Objectives: The purpose of this trial was to determine whether regularly scheduled use of an inhaled long-acting beta agonist (salmeterol) in the setting of concomitant use of inhaled corticosteroids (beclomethasone hydroflouroalkane (HFA) inhaler) would have a detrimental effect on asthma control in people who bear the B16 Arg/Arg genotype of the beta-2 adrenergic receptor gene, as compared to people with asthma of similar severity who bear the B16 Gly/Gly genotype.'
					   );

call expected.insert_study_details(sid => _sid, syear => 2004, smonth => 12, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 915, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 18, 
                         title => 'Asthma Clinical Research Network Trial (ACRN) - Long-Acting Beta Agonist Response by Genotype (LARGE)',
						 isdefault => true, comms => 'From BioLINCC web page');
-- acronym					 
call expected.insert_study_title(sid => _sid, typeid => 14, 
                         title => 'ACRN-LARGE', 
						 isdefault => false, comms => 'From BioLINCC web page');

	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT00200967', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 42, idvalue => 'HLB01021313a', idorgid => 100167, idorgname => 'National Heart, Lung, and Blood Institute (US)');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgid => 100375, orgname => 'Milton S Hershey Medical Center');

call expected.insert_study_reference(sid => _sid, ppmid => '19932356', 
									 pdoi => 'https://www.ncbi.nlm.nih.gov/pubmed/19932356', comms => 'primary');

-- trial registry entry
_oid = _sid ||' :: 38 :: NHLBI web page';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
	title => _title,
	title_qualifier => 'NHLBI web page',
	pubyear => null, obclassid => 23, obtypeid => 38,
	managingorgid => 100167, managingorgname=> 'National Heart, Lung, and Blood Institute (US)',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 101900, reporgname => 'BioLINCC', 
	purl => 'https://biolincc.nhlbi.nih.gov/studies/large/', 
	restypeid => 35);
	

-- datasets
_oid = _sid ||' :: 80 :: Individual participant data';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
	title => _title,
	title_qualifier => 'Individual participant data',
	pubyear => 2018, obclassid => 14, obtypeid => 80,
	managingorgid => 100167, managingorgname=> 'National Heart, Lung, and Blood Institute (US)',
	acctypeid => 17, accdetails => _access_details, 
	accdetsurl => 'https://biolincc.nhlbi.nih.gov/media/guidelines/handbook.pdf?link_time=2019-12-13_11:33:44.807479#page=15',
	urlchecked => '2021-07-23', eosccat => 3, title_typeid => 22);

call expected.insert_object_dataset (sd_oid => _oid, 
     deidenttypeid => 2, deidentdets => _de_identification
   );
   
call expected.insert_object_date(sd_oid => _oid, 
    typeid => 18, datestring => '2018 Jan 3',
	syear => 2018, smonth => 1, sday => 3);

-- other objects
_oid = _sid ||' :: 31 :: Data Dictionary';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Data Dictionary',	   
	   pubyear => null, obclassid => 23, obtypeid => 31, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/large/data_dictionary/ACRN_LARGE_accessible.pdf', 
	   restypeid => 11, ressize => '508.2', ressizeu => 'KB');

_oid = _sid ||' :: 21 :: Forms';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,  
       title => _title,
       title_qualifier => 'Forms',
	   pubyear => null, obclassid => 23, obtypeid => 21, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);

call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/large/Forms.pdf', 
	   restypeid => 11, ressize => '3.3', ressizeu => 'MB');
	   
_oid = _sid ||' :: 11 :: Protocol';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'Protocol',	   
	   pubyear => null, obclassid => 23, obtypeid => 11, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/large/Protocol.pdf', 
	   restypeid => 11, ressize => '631.0', ressizeu => 'KB');
end;
$BODY$;
ALTER PROCEDURE expected.study_acrn_large()
    OWNER TO postgres;
 
             */           
        }
        
        if (sd_sid == "OMNI Heart")
        {
            /*
             -- PROCEDURE: expected.study_omni_heart()

-- DROP PROCEDURE IF EXISTS expected.study_omni_heart();

CREATE OR REPLACE PROCEDURE expected.study_omni_heart(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'OMNI Heart';
DECLARE _access_details VARCHAR := 'Investigators wishing to request materials from studies ... must register (free) on the BioLINCC website. Registered investigators may then request detailed searches and submit an application for data sets and/or biospecimens. (from the BioLINCC website)';
DECLARE _de_identification VARCHAR := 'All BioLINCC data and biospecimens are de-identified. Obvious subject identifiers and data collected solely for administrative purposes are redacted from datasets, and dates are recoded relative to a specific reference point. In addition recodes of selected low-frequency data values may be carried out to protect subject privacy and minimize re-identification risks (from the BioLINCC documentation).';
DECLARE _title VARCHAR;
_oid VARCHAR;

begin

-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

--(first title from CTG, used for data objects)
_title := 'OmniHeart Trial: Macronutrients and Cardiovascular Risk';

call expected.insert_study_names(sid => _sid, 
						title => 'Optimal Macronutrient Intake Trial to Prevent Heart Disease (OMNI Heart)', 
						brief_desc =>'Objectives: The objective of this study was to compare the effects of 3 healthy diets, each with reduced saturated fat intake, on blood pressure and serum lipids.'
					   );

call expected.insert_study_details(sid => _sid, syear => 2002, smonth => null, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 915, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 18, 
                         title => 'Optimal Macronutrient Intake Trial to Prevent Heart Disease (OMNI Heart)', 
						 isdefault => true, comms => 'From BioLINCC web page');
-- acronym					 
call expected.insert_study_title(sid => _sid, typeid => 14, 
                         title => 'OMNI Heart', 
						 isdefault => false, comms => 'From BioLINCC web page');

	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT00051350', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 42, idvalue => 'HLB00831119a', idorgid => 100167, idorgname => 'National Heart, Lung, and Blood Institute (US)');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgid => 100190, orgname => 'Johns Hopkins University (Baltimore, MD)');

call expected.insert_study_reference(sid => _sid, ppmid => '33668058', 
 pcitation => 'Belanger MJ, Wee CC, Mukamal KJ, Miller ER, Sacks FM, Appel LJ, Shmerling RH, Choi HK, Juraschek SP. Effects of dietary macronutrients on serum urate: results from the OmniHeart trial. Am J Clin Nutr 2021 Jun 1;113(6):1593-1599.',
			 pdoi => '7a090a34f4b94456baf6385d5c30a659', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '26319643', 
 pcitation => 'Joyce R, Kuziene V, Zou X, Wang X, Pullen F, Loo RL. Development and validation of an ultra-performance liquid chromatography quadrupole time of flight mass spectrometry method for rapid quantification of free amino acids in human urine. Amino Acids 2016 Jan;48(1):219-34. Epub 2015 Aug 29.',
			 pdoi => 'f757a16569e544228dfd47f40b22af56', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '31447226', 
 pcitation => 'Kovell LC, Yeung EH, Miller ER 3rd, Appel LJ, Christenson RH, Rebuck H, Schulman SP, Juraschek SP. Healthy diet reduces markers of cardiac injury and inflammation regardless of macronutrients: Results from the OmniHeart trial. Int J Cardiol 2020 Jan 15;299:282-288. Epub 2019 Aug 2.',
			 pdoi => '2a37ef1e774941389fe206248e3876d4', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29506183', 
 pcitation => 'Loo RL, Zou X, Appel LJ, Nicholson JK, Holmes E. Characterization of metabolic responses to healthy diets and association with blood pressure: application to the Optimal Macronutrient Intake Trial for Heart Health (OmniHeart), a randomized controlled study. Am J Clin Nutr 2018 Mar 1;107(3):323-334.',
			 pdoi => '149fb8f76e544e18a18a2166b27b9383', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29730626', 
 pcitation => 'Pino EC, Zuo Y, Maciel De Olivera C, Mahalingaiah S, Keiser O, Moore LL, Li F, Vasan RS, Corkey BE, Kalesan B. Cohort profile: The MULTI sTUdy Diabetes rEsearch (MULTITUDE) consortium. BMJ Open 2018 May 5;8(5):e020640.',
			 pdoi => '57c4fb1fade649fe8fd8fb09429c198c', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '29917038', 
 pcitation => 'Rebholz CM, Lichtenstein AH, Zheng Z, Appel LJ, Coresh J. Serum untargeted metabolomic profile of the Dietary Approaches to Stop Hypertension (DASH) dietary pattern. Am J Clin Nutr 2018 Aug 1;108(2):243-255.',
			 pdoi => '144d2d4a99644a998205066f7ae04f2e', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '25008012', 
 pcitation => 'Root MM, Dawson HR. DASH-like diets high in protein or monounsaturated fats improve metabolic syndrome and calculated vascular risk. Int J Vitam Nutr Res 2013;83(4):224-31.',
			 pdoi => '956221f4f14547a2a002199e602995d8', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '27149575', 
 pcitation => 'Zou X, Holmes E, Nicholson JK, Loo RL. Automatic Spectroscopic Data Categorization by Clustering Analysis (ASCLAN): A Data-Driven Approach for Distinguishing Discriminatory Metabolites for Phenotypic Subclasses. Anal Chem 2016 Jun 7;88(11):5670-9. Epub 2016 May 13.',
			 pdoi => '94a4db08ad744b69b013926b1bad7b0e', comms => 'associated');
call expected.insert_study_reference(sid => _sid, ppmid => '24773160', 
 pcitation => 'Zou X, Holmes E, Nicholson JK, Loo RL. Statistical HOmogeneous Cluster SpectroscopY (SHOCSY): an optimized statistical approach for clustering of ¹H NMR spectral data to reduce interference and enhance robust biomarkers selection. Anal Chem 2014 Jun 3;86(11):5308-15. Epub 2014 May 13.',
			 pdoi => '41a5c5c2140c40309fc7e00a3f79f201', comms => 'associated');

-- trial registry entry
_oid = _sid ||' :: 38 :: NHLBI web page';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
	title => _title,
	title_qualifier => 'NHLBI web page',
	pubyear => null, obclassid => 23, obtypeid => 38,
	managingorgid => 100167, managingorgname=> 'National Heart, Lung, and Blood Institute (US)',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 101900, reporgname => 'BioLINCC', 
	purl => 'https://biolincc.nhlbi.nih.gov/studies/omniheart/', 
	restypeid => 35);
		

-- datasets
_oid = _sid ||' :: 80 :: Individual participant data';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
	title => _title,
	title_qualifier => 'Individual participant data',
	pubyear => 2019, obclassid => 14, obtypeid => 80,
	managingorgid => 100167, managingorgname=> 'National Heart, Lung, and Blood Institute (US)',
	acctypeid => 17, accdetails => _access_details, 
	accdetsurl => 'https://biolincc.nhlbi.nih.gov/media/guidelines/handbook.pdf?link_time=2019-12-13_11:33:44.807479#page=15',
	urlchecked => '2021-07-23', eosccat => 3, title_typeid => 22);

call expected.insert_object_dataset (sd_oid => _oid, 
     deidenttypeid => 2, deidentdets => _de_identification
   , consenttypeid => 6, consentdets => 'Consent restricts use of biospecimens to non-genetic research related to CVD or nutrition.');

call expected.insert_object_date(sd_oid => _oid, 
    typeid => 18, datestring => '2019 Jan 24',
	syear => 2019, smonth => 1, sday => 24);
    
-- other objects
_oid = _sid ||' :: 31 :: Data Dictionary';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title, title_qualifier => 'Data Dictionary',	   
	   pubyear => null, obclassid => 23, obtypeid => 31, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/omniheart/data_dictionary/OMNI_Heart_2019a.pdf', 
	   restypeid => 11, ressize => '296.7', ressizeu => 'KB');

_oid = _sid ||' :: 36 :: MOP';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title, title_qualifier => 'MOP',
	   pubyear => null, obclassid => 23, obtypeid => 36, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);

call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/omniheart/MOP.pdf', 
	   restypeid => 11, ressize => '1.1', ressizeu => 'MB');

_oid = _sid ||' :: 11 :: Protocol';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title, title_qualifier => 'Protocol',	   
	   pubyear => null, obclassid => 23, obtypeid => 11, 
	   managingorgid => 100167, managingorgname => 'National Heart, Lung, and Blood Institute (US)', 
	   acctypeid => 11, eosccat => 0, title_typeid => 21);
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101900, reporgname => 'BioLINCC', 
	   purl => 'https://biolincc.nhlbi.nih.gov/media/studies/omniheart/Protocol.pdf', 
	   restypeid => 11, ressize => '987.0', ressizeu => 'KB');
end;
$BODY$;
ALTER PROCEDURE expected.study_omni_heart()
    OWNER TO postgres;

             */            
        }
        
        return null;
    }
}