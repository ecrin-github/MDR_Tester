namespace MDR_Tester;

public class TestData_100132 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "NTR1437")
        {
            /*
             -- PROCEDURE: expected.study_ntr1437()

-- DROP PROCEDURE IF EXISTS expected.study_ntr1437();

CREATE OR REPLACE PROCEDURE expected.study_ntr1437(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'NTR1437';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'The effects of orally and intraduodenally administered pea protein on satiety parameters in vivo in lean and obese subjects';

call expected.insert_study_names(sid => _sid, 
						title =>_title, 
						brief_desc =>'Interventions: This study is a randomized, placebo controlled cross-over study with 2 groups of volunteers. One group will consist of healthy lean male subjects. The other group will consist of obese male subjects. All subjects will receive both the test protein and the placebo, administered either orally or intraduodenally, depending on the test day. Delievery of the protein and placebo into the duodenum will be through a feeding tube.

- Oral ingestion placebo
- Oral ingestion protein
- Duodenal administration placebo
- Duodenal administration protein
All conditions are randomized over 4 test days
- Gastroscopy on the 5h test day
Primary outcome(s): The effects of orally- and intraduodenally administered intact protein on systemic satiety hormone levels (CCK, GLP-1, and PYY) and feelings of hunger and satiety
Study Design: Randomized: No, 
                        Masking: Single, 
                        Control: Placebo, 
                        Group: undefined, 
                        Type: 2 or more arms, randomized'
);

call expected.insert_study_details(sid => _sid, syear => 2008, smonth => 11, typeid => 11, statusid => 16);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '24', eligid => 915, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From the Netherlands National Trial Register');
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100132, idorgname => 'The Netherlands National Trial Register', iddate => '2008 Sep 9');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'MCP Geraedts');
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'Transnational University Limburg');

call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
Call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 505);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Obesity, dietary proteins, oral administration, duodenal administration, satiety');

-- trial registry entry
_oid = _sid ||' :: 13 :: Dutch registry web page';

call expected.insert_data_object(sd_oid => _oid, sid => _sid,  
	title => _title || ' :: Dutch registry web page',
	pubyear => 2008, obclassid => 23, obtypeid => 13,
	managingorgid => 100132, managingorgname=> 'Netherlands National Trial Register',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: Dutch registry web page', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100132, reporgname => 'Netherlands National Trial Register', 
	purl => 'https://trialregister.nl/trial/1376',  
	restypeid => 35);
	
	
call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2008 Sep 9', syear => 2008, smonth => 9, sday => 9);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2022 Mar 28', syear => 2022, smonth => 3, sday => 28);

end;
$BODY$;
ALTER PROCEDURE expected.study_ntr1437()
    OWNER TO postgres;
 
             */
        }
        
        if (sd_sid == "NL8683")
        {
            /*
            -- PROCEDURE: expected.study_nl8683()

-- DROP PROCEDURE IF EXISTS expected.study_nl8683();

CREATE OR REPLACE PROCEDURE expected.study_nl8683(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'NL8683';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'EXpansion of stents after Intravascular lithoTripsy versus conventional predilatation in CALCified coronary arteries';

call expected.insert_study_names(sid => _sid, 
						title =>_title, 
						brief_desc =>'Interventions: Intravascular lithotripsy or balloon dilatation, followed by stenting with DES in all patients
Primary outcome(s): Stent expansion measured by OCT
Study Design: Randomized: No, 
                        Masking: None, 
                        Control: Active, 
                        Group: undefined, 
                        Type: 2 or more arms, randomized'
					   );

call expected.insert_study_details(sid => _sid, syear => 2020, smonth => 5, typeid => 11, statusid => 16);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '40', eligid => 915, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From the Netherlands National Trial Register');
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100132, idorgname => 'Netherlands National Trial Register', iddate => '2020 May 26');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Thomas Oomens');

call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 500);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Coronary artery disease');

-- trial registry entry
_oid = _sid ||' :: 13 :: Dutch registry web page';

call expected.insert_data_object(sd_oid => _oid, sid => _sid, 
	title => _title || ' :: Dutch registry web page',
	pubyear => 2020, obclassid => 23, obtypeid => 13,
	managingorgid => 100132, managingorgname=> 'Netherlands National Trial Register',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: Dutch registry web page', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100132, reporgname => 'Netherlands National Trial Register', 
	purl => 'https://trialregister.nl/trial/8683',  
	restypeid => 35);
	
call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2020 May 26', syear => 2020, smonth => 5, sday => 26);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2022 Mar 28', syear => 2022, smonth => 3, sday => 28);

end;
$BODY$;
ALTER PROCEDURE expected.study_nl8683()
    OWNER TO postgres;
 
            */           
        }
   
        return null;
    }
}