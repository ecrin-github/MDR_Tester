namespace MDR_Tester;

public class TestData_100131 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "TCTR20161221005")
        {
            /*
            -- PROCEDURE: expected.study_tctr20161221005()

-- DROP PROCEDURE IF EXISTS expected.study_tctr20161221005();

CREATE OR REPLACE PROCEDURE expected.study_tctr20161221005(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'TCTR20161221005';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'A Clinical Study of Fundus Findings in Toxaemia of Pregnancy(Pregnancy Induced Hypertension)';

call expected.insert_study_names(sid => _sid, 
						title =>_title, 
						brief_desc =>'Interventions: Carvedilol 12.5 mg immediate release tablets,Carvedilol 12.5 mg immediate release tablets;Experimental Drug,Active Comparator Drug;Carvolol (12.5 mg),Dilatrend (12.5 mg)
Primary outcome(s): Correlation of fundus changes with disease entity,age,gravida, blood pressure,duration,imp of fundus Nov. 2003 to June 2006 randomly Clinical ophthalmoscopy(Fundus Examination)'
					   );

call expected.insert_study_details(sid => _sid, syear => 2003, smonth => 11, typeid => 12, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '300', eligid => 905, minage => 18, minageu => 17, maxage => 42, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From the Thai Clinical Trials Register');
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100131, idorgname => 'Thai Clinical Trials Register"', iddate => '2016 Dec 21');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'U1111-1189-6165', idorgid => 100115 , idorgname => 'International Clinical Trials Registry Platform (WHO)');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT03076619', idorgid => 100120 , idorgname => 'Clinicaltrials.gov');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Rahul Bakhda', affiliation => 'Exâ€‘Resident, M and J Western Regional Institute of Ophthalmology, Ahmedabad',
									  orgname => 'M and J Western Regional Institute of Ophthalmology');
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'M and J Western Regional Institute of Ophthalmology' );

call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 599);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Pregnancy Induced Hypertension');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Fundus findings');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'hypertensive disorders of pregnancy');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'ophthalmoscopy');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'perinatal mortality');

-- trial registry entry
_oid = _sid ||' :: 13 :: Thai registry web page';

call expected.insert_data_object(sd_oid => _oid, sid => _sid, 
	title => _title || ' :: Thai registry web page',
	pubyear => 2016, obclassid => 23, obtypeid => 13,
	managingorgid => 100131, managingorgname=> 'Thai Clinical Trials Register"',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: Thai registry web page', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100131, reporgname => 'Thai Clinical Trials Register', 
	purl => 'www.thaiclinicaltrials.org/show/TCTR20161221005',  
	restypeid => 35);
		
call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2016 Dec 21', syear => 2016, smonth => 12, sday => 21);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2022 Mar 8', syear => 2022, smonth => 3, sday => 8);

end;
$BODY$;
ALTER PROCEDURE expected.study_tctr20161221005()
    OWNER TO postgres;

             */            
        }
        return null;
    }
}