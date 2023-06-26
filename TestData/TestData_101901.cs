namespace MDR_Tester;

public class TestData_101901 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "Y-NCT01727258")
        {
            /*
             -- PROCEDURE: expected.study_y_nct01727258()

-- DROP PROCEDURE IF EXISTS expected.study_y_nct01727258();

CREATE OR REPLACE PROCEDURE expected.study_y_nct01727258(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'Y-NCT01727258';
DECLARE _access_details VARCHAR := 'The YODA Project will require that requestors provide basic information about the Principal Investigator, Key Personnel, and the project Research Proposal, including a scientific abstract and research methods.The YODA Project will review proposals to ensure that: 1) the scientific purpose is clearly described; 2) the data requested will be used to enhance scientific and/or medical knowledge; and 3) the proposed research can be reasonably addressed using the requested data.';
DECLARE _title VARCHAR;
_oid VARCHAR;

begin

_title = 'A Test on a New Experimental Mouth Rinse for Relieving Tooth Sensitivity';

-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

call expected.insert_study_names(sid => _sid, 
						title =>'Evaluation of an experimental mouth rinse device for relieving dentinal hypersenstivity', 
						brief_desc =>'This study is for people with sensitive teeth and involves going to the dentist for 4 visits over 6 weeks. At each visit the dentist will look at the mouth, teeth, tongue and gums of subjects, and check for sensitive teeth.

During the first 2 weeks, participants will brush their teeth two times a day with the fluoride toothpaste provided.

Then, if they qualify to continue in the study, participants will be assigned to a treatment group. All the groups will get toothpaste currently sold on the market, and one group will get a mouthwash with an experimental ingredient to use as well. Subjects will have an equal chance of being assigned to any one of the three groups.

For the next 4 weeks, subjects will use their assigned products according to the directions provided. At Visit 1 subjects will be supervised while they brush their teeth to ensure they understand the directions. They will also have supervised use of the product at Visit 2.

We will see if the mouthwash helps to reduce tooth sensitivity during the study.'
					   );

call expected.insert_study_details(sid => _sid, syear => null, smonth => null, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '153', eligid => 900, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 18, 
                         title => 'Evaluation of an experimental mouth rinse device for relieving dentinal hypersenstivity', 
						 isdefault => true, comms => 'From YODA web page');
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT01727258', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'KOXDHY0008', idorgid => 100290, idorgname => 'Johnson & Johnson');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'Johnson & Johnson');

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Dentinal Hypersensitivity');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Mouth Rinse, potassium oxalate 1.4%');

-- trial registry entry
_oid = _sid ||' :: 38 :: Yoda web page';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
		title => _title, 
		title_qualifier => 'Yoda web page', 
		obclassid => 23, obtypeid => 38, 
		managingorgid => 101901, managingorgname => 'Yoda', 
	    acctypeid => 12, title_typeid => 22);
	 
call expected.insert_object_instance(sd_oid => _oid, 
        reporgid => 101901, reporgname => 'Yoda', 
		purl => 'https://yoda.yale.edu/node/2171', restypeid => 35);

-- other objects
_oid = _sid ||' :: 26 :: Clinical Study Report';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Clinical study report',	   
	   pubyear => null, obclassid => 23, obtypeid => 26, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);

_oid = _sid ||' :: 80 :: Collected Datasets';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Individual participant data',	   
	   pubyear => null, obclassid => 14, obtypeid => 80, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 3, title_typeid => 22);
	   
call expected.insert_object_dataset(sd_oid => _oid, 
		deidenttypeid => 2
		, deidentdets => 'Yoda states that “...researchers will be granted access to participant-level study data that are devoid of personally identifiable information; current best guidelines for de-identification of data will be used.”' );

_oid = _sid ||' :: 31 :: Data Definition Specification';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'Data dictionary',	   
	   pubyear => null, obclassid => 23, obtypeid => 31, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);  

_oid = _sid ||' :: 30 :: Annotated Case Report Form';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Annotated data collection forms',	   
	   pubyear => null, obclassid => 23, obtypeid => 30, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);   

_oid = _sid ||' :: 11 :: Protocol with Amendments';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Study protocol',
	   pubyear => null, obclassid => 23, obtypeid => 11, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);

_oid = _sid ||' :: 22 :: Statistical Analysis Plan';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Statistical analysis plan',	   
	   pubyear => null, obclassid => 23, obtypeid => 22, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);
end;
$BODY$;
ALTER PROCEDURE expected.study_y_nct01727258()
    OWNER TO postgres;

             */            
        }
        
        if (sd_sid == "Y-30-49")
        {
            /*
           -- PROCEDURE: expected.study_y_30_49()

-- DROP PROCEDURE IF EXISTS expected.study_y_30_49();

CREATE OR REPLACE PROCEDURE expected.study_y_30_49(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'Y-30-49';
DECLARE _access_details VARCHAR := 'The YODA Project will require that requestors provide basic information about the Principal Investigator, Key Personnel, and the project Research Proposal, including a scientific abstract and research methods.The YODA Project will review proposals to ensure that: 1) the scientific purpose is clearly described; 2) the data requested will be used to enhance scientific and/or medical knowledge; and 3) the proposed research can be reasonably addressed using the requested data.';
DECLARE _title VARCHAR;
_oid VARCHAR;

begin

_title = 'A Phase 3, Randomized, Open-Label, Comparative Study of DOXIL/CAELYX® versus Topotecan HCl in Patients with Epithelial Ovarian Carcinoma Following Failure of First-Line, Platinum-Based Chemotherapy';
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc =>'The primary objective of this study was to compare the efficacy and safety of DOXIL to those of topotecan in subjects with epithelial ovarian carcinoma following failure of first-line, platinum-based chemotherapy.'
					   );

call expected.insert_study_details(sid => _sid, syear => null, smonth => null, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '481', eligid => 905, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 18, 
                         title => _title, 
						 isdefault => true, comms => 'From YODA web page');
	
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => '30-49', idorgname => 'Johnson & Johnson');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgid => 100290, orgname => 'Johnson & Johnson');

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Doxorubicin hydrochloride');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Doxil');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Neoplasms, Ovarian');

call expected.insert_study_reference(sid => _sid, ppmid => '15385103');

-- trial registry entry
_oid = _sid ||' :: 38 :: Yoda web page';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
		title => _title, 
		title_qualifier => 'Yoda web page', 
		obclassid => 23, obtypeid => 38, 
		managingorgid => 101901, managingorgname => 'Yoda', 
	    acctypeid => 12, title_typeid => 22);
	 
call expected.insert_object_instance(sd_oid => _oid, 
        reporgid => 101901, reporgname => 'Yoda', 
		purl => 'https://yoda.yale.edu/node/647', restypeid => 35);

-- other objects
_oid = _sid ||' :: 26 :: Clinical Study Report';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Clinical study report',	   
	   pubyear => null, obclassid => 23, obtypeid => 26, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);

_oid = _sid ||' :: 80 :: Collected Datasets';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Individual participant data',	   
	   pubyear => null, obclassid => 14, obtypeid => 80, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 3, title_typeid => 22);
	   
call expected.insert_object_dataset(sd_oid => _oid, 
		deidenttypeid => 2
		, deidentdets => 'Yoda states that “...researchers will be granted access to participant-level study data that are devoid of personally identifiable information; current best guidelines for de-identification of data will be used.”' );

_oid = _sid ||' :: 31 :: Data Definition Specification';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Data dictionary',	   
	   pubyear => null, obclassid => 23, obtypeid => 31, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 11, eosccat => 0, title_typeid => 22);  
	   
call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101901, reporgname => 'Yoda', 
	   purl => 'https://yoda.yale.edu/sites/default/files/30-49_data_dictionary.pdf', 
	   restypeid => 11);

_oid = _sid ||' :: 30 :: Annotated Case Report Form';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Annotated data collection forms',	   
	   pubyear => null, obclassid => 23, obtypeid => 30, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);  

_oid = _sid ||' :: 11 :: Protocol with Amendments';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Study protocol',
	   pubyear => null, obclassid => 23, obtypeid => 11, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	  urlchecked => '2021-07-23',  eosccat => 0, title_typeid => 22);

_oid = _sid ||' :: 22 :: Statistical Analysis Plan';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Statistical analysis plan',	   
	   pubyear => null, obclassid => 23, obtypeid => 22, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data',
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);

_oid = _sid ||' :: 79 :: CSR Summary';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'CSR summary',	   
	   pubyear => null, obclassid => 23, obtypeid => 79, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 11, eosccat => 0, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101901, reporgname => 'Yoda', 
	   purl => 'https://yoda.yale.edu/sites/default/files/30-49_csr_synopsis.pdf', 
	   restypeid => 11);
  
end;
$BODY$;
ALTER PROCEDURE expected.study_y_30_49()
    OWNER TO postgres;
 
            */           
        }

        if (sd_sid == "Y-NCT02243202")
        {
            /*
            -- PROCEDURE: expected.study_y_nct02243202()

-- DROP PROCEDURE IF EXISTS expected.study_y_nct02243202();

CREATE OR REPLACE PROCEDURE expected.study_y_nct02243202(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'Y-NCT02243202';
DECLARE _access_details VARCHAR := 'The YODA Project will require that requestors provide basic information about the Principal Investigator, Key Personnel, and the project Research Proposal, including a scientific abstract and research methods.The YODA Project will review proposals to ensure that: 1) the scientific purpose is clearly described; 2) the data requested will be used to enhance scientific and/or medical knowledge; and 3) the proposed research can be reasonably addressed using the requested data.';
DECLARE _title VARCHAR;
_oid VARCHAR;

begin

_title = 'Effects of Co-administration of Canagliflozin 300 mg and Phentermine 15 mg With Placebo in the Treatment of Non-Diabetic Overweight and Obese Participants';
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

call expected.insert_study_names(sid => _sid, 
						title =>'A Randomized, Double-Blind, Placebo-Controlled, Parallel-Group Study to Investigate the Safety and Efficacy of the Co-administration of Canagliflozin 300 mg and Phentermine 15 mg Compared With Placebo for the Treatment of Non-diabetic Overweight and Obese Subjects', 
						brief_desc =>'The purpose of this study is to compare the effects of canagliflozin and phentermine to those of placebo to promote on a change in body weight over a 26 week period.'
					   );

call expected.insert_study_details(sid => _sid, syear => null, smonth => null, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '335', eligid => 900, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 18, 
                         title => 'A Randomized, Double-Blind, Placebo-Controlled, Parallel-Group Study to Investigate the Safety and Efficacy of the Co-administration of Canagliflozin 300 mg and Phentermine 15 mg Compared With Placebo for the Treatment of Non-diabetic Overweight and Obese Subjects', 
								 isdefault => true, comms => 'From YODA web page');

	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT02243202', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => '28431754OBE2002', idorgid => 100773, idorgname => 'Janssen (part of J&J)');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgid => 100773, orgname => 'Janssen (part of J&J)');

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Canagliflozin');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Obesity');

call expected.insert_study_reference(sid => _sid, ppmid => '28289041');

-- trial registry entry
_oid = _sid ||' :: 38 :: Yoda web page';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
		title => _title, 
		title_qualifier => 'Yoda web page', 
		obclassid => 23, obtypeid => 38, 
		managingorgid => 101901, managingorgname => 'Yoda', 
	    acctypeid => 12, title_typeid => 22);
	 
call expected.insert_object_instance(sd_oid => _oid, 
        reporgid => 101901, reporgname => 'Yoda', 
		purl => 'https://yoda.yale.edu/node/4117', restypeid => 35);

-- other objects
_oid = _sid ||' :: 26 :: Clinical Study Report';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title, title_qualifier => 'Clinical study report',	   
	   pubyear => null, obclassid => 23, obtypeid => 26, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);

_oid = _sid ||' :: 80 :: Collected Datasets';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title, title_qualifier => 'Individual participant data',	   
	   pubyear => null, obclassid => 14, obtypeid => 80, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 3, title_typeid => 22);
	   
call expected.insert_object_dataset(sd_oid => _oid, 
		deidenttypeid => 2
		, deidentdets => 'Yoda states that “...researchers will be granted access to participant-level study data that are devoid of personally identifiable information; current best guidelines for de-identification of data will be used.”' );

_oid = _sid ||' :: 11 :: Protocol with Amendments';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title, title_qualifier => 'Study protocol',
	   pubyear => null, obclassid => 23, obtypeid => 11, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);

_oid = _sid ||' :: 22 :: Statistical Analysis Plan';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title, title_qualifier => 'Statistical analysis plan',	   
	   pubyear => null, obclassid => 23, obtypeid => 22, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);
	   
end;
$BODY$;
ALTER PROCEDURE expected.study_y_nct02243202()
    OWNER TO postgres;
 
            */           
        }
        
        if (sd_sid == "Y-GAL-MVD-301")
        {
            /*
            -- PROCEDURE: expected.study_y_gal_mvd_301()

-- DROP PROCEDURE IF EXISTS expected.study_y_gal_mvd_301();

CREATE OR REPLACE PROCEDURE expected.study_y_gal_mvd_301(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'Y-GAL-MVD-301';
DECLARE _access_details VARCHAR := 'The YODA Project will require that requestors provide basic information about the Principal Investigator, Key Personnel, and the project Research Proposal, including a scientific abstract and research methods.The YODA Project will review proposals to ensure that: 1) the scientific purpose is clearly described; 2) the data requested will be used to enhance scientific and/or medical knowledge; and 3) the proposed research can be reasonably addressed using the requested data.';
DECLARE _title VARCHAR;
_oid VARCHAR;

begin

_title = 'A long-term comparison of galantamine and donepezil in the treatment of Alzheimer’s disease';
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc =>'The primary objective of this trial was to document the long-term response and safety of galantamine in subjects with Alzheimer’s Disease or vascular dementia or AD with cerebrovascular disease.'
					   );

call expected.insert_study_details(sid => _sid, syear => null, smonth => null, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 900, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 18, 
                         title => _title, 
						 isdefault => true, comms => 'From YODA web page');
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'GAL-MVD-301', idorgname => 'Janssen');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgid => 100773, orgname => 'Janssen');

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Galantamine');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Alzheimer Disease');

call expected.insert_study_reference(sid => _sid, ppmid => '12875613');

-- trial registry entry
_oid = _sid ||' :: 38 :: Yoda web page';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
		title => _title, 
		title_qualifier => 'Yoda web page', 
		obclassid => 23, obtypeid => 38, 
		managingorgid => 101901, managingorgname => 'Yoda', 
	    acctypeid => 12, title_typeid => 22);
	 
call expected.insert_object_instance(sd_oid => _oid, 
        reporgid => 101901, reporgname => 'Yoda', 
		purl => 'https://yoda.yale.edu/node/975', restypeid => 35);

-- other objects
_oid = _sid ||' :: 26 :: Clinical Study Report';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Clinical study report',	   
	   pubyear => null, obclassid => 23, obtypeid => 26, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);

_oid = _sid ||' :: 11 :: Protocol with Amendments';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'Study protocol',
	   pubyear => null, obclassid => 23, obtypeid => 11, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);

_oid = _sid ||' :: 79 :: CSR Summary';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'CSR summary',	   
	   pubyear => null, obclassid => 23, obtypeid => 79, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 11, eosccat => 0, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
       reporgid => 101901, reporgname => 'Yoda', 
	   purl => 'https://yoda.yale.edu/sites/default/files/gal-mvd-301_csr_synopsis.pdf', 
	   restypeid => 11);

end;
$BODY$;
ALTER PROCEDURE expected.study_y_gal_mvd_301()
    OWNER TO postgres;
 
            */           
        }
        
        if (sd_sid == "Y-NCT00433329")
        {
            /*
           -- PROCEDURE: expected.study_y_nct00433329()

-- DROP PROCEDURE IF EXISTS expected.study_y_nct00433329();

CREATE OR REPLACE PROCEDURE expected.study_y_nct00433329(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'Y-NCT00433329';
DECLARE _access_details VARCHAR := 'The YODA Project will require that requestors provide basic information about the Principal Investigator, Key Personnel, and the project Research Proposal, including a scientific abstract and research methods.The YODA Project will review proposals to ensure that: 1) the scientific purpose is clearly described; 2) the data requested will be used to enhance scientific and/or medical knowledge; and 3) the proposed research can be reasonably addressed using the requested data.';
DECLARE _title VARCHAR;
_oid VARCHAR;

begin

_title = 'Combination Therapy in Pulmonary Arterial Hypertension';

-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

call expected.insert_study_names(sid => _sid, 
						title =>'COMPASS 3: An Open-label, Multi-Center Study Employing a Targeted 6-Minute Walk Test (6-MWT) Distance Threshold Approach to Guide Bosentan-Based Therapy and to Assess the Utility of Magnetic Resonance Imaging (MRI) on Cardiac Remodeling', 
						brief_desc =>'An open label, non-comparative study design is appropriate for this Phase 4 study designed to assess whether a core therapy of bosentan, either as monotherapy or with the addition of sildenafil, enables patients with pulmonary arterial hypertension (PAH) to achieve a 6-minute walk distance (6 MWD) of ≥380 meters after 28 weeks of therapy This design is also appropriate to pioneer the utility of cardiac MRI in assessing improved functional capacity in PAH and exploring its correlation with other parameters.'
					   );

call expected.insert_study_details(sid => _sid, syear => null, smonth => null, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '100', eligid => 900, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 18, 
                         title => 'COMPASS 3: An Open-label, Multi-Center Study Employing a Targeted 6-Minute Walk Test (6-MWT) Distance Threshold Approach to Guide Bosentan-Based Therapy and to Assess the Utility of Magnetic Resonance Imaging (MRI) on Cardiac Remodeling', 
						 isdefault => true, comms => 'From YODA web page');
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT00433329', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'AC-052-419', idorgid => 100585, idorgname => 'Actelion');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'Actelion');

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Bosentan');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Hypertension, Pulmonary, Arterial');

call expected.insert_study_reference(sid => _sid, ppmid => '29064349');

-- trial registry entry
_oid = _sid ||' :: 38 :: Yoda web page';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
		title => _title, 
		title_qualifier => 'Yoda web page', 
		obclassid => 23, obtypeid => 38, 
		managingorgid => 101901, managingorgname => 'Yoda', 
	    acctypeid => 12, title_typeid => 22);
	 
call expected.insert_object_instance(sd_oid => _oid, 
        reporgid => 101901, reporgname => 'Yoda', 
		purl => 'https://yoda.yale.edu/node/3911', restypeid => 35);

_oid = _sid ||' :: 26 :: Clinical Study Report';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Clinical study report',	   
	   pubyear => null, obclassid => 23, obtypeid => 26, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);

_oid = _sid ||' :: 11 :: Protocol with Amendments';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
       title => _title,
       title_qualifier => 'Study protocol',
	   pubyear => null, obclassid => 23, obtypeid => 11, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);

_oid = _sid ||' :: 22 :: Statistical Analysis Plan';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
       title => _title,
       title_qualifier => 'Statistical analysis plan',	   
	   pubyear => null, obclassid => 23, obtypeid => 22, 
	   managingorgid => 101901, managingorgname => 'Yoda', 
	   acctypeid => 17, accdetails => _access_details, accdetsurl => 'https://yoda.yale.edu/how-request-data', 
	   urlchecked => '2021-07-23', eosccat => 0, title_typeid => 22);
end;
$BODY$;
ALTER PROCEDURE expected.study_y_nct00433329()
    OWNER TO postgres;

            */           
        }

        return null;
    }
}