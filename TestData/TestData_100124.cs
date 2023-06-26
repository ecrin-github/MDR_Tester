namespace MDR_Tester;

public class TestData_100124 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "DRKS00011324")
        {
            /*
             -- PROCEDURE: expected.study_drks00011324()

-- DROP PROCEDURE IF EXISTS expected.study_drks00011324();

CREATE OR REPLACE PROCEDURE expected.study_drks00011324(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'DRKS00011324';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'A Clinical Study of Fundus Findings in Toxaemia of Pregnancy(Pregnancy Induced Hypertension)';

call expected.insert_study_names(sid => _sid, 
						title =>_title, 
						brief_desc =>'Intervention 1: An observational study in which the patients for the study are selected from antenatal clinic, antenatal ward and preeclampsia and eclampsia
room” in Department of Obstetrics and Gynecology and general ophthalmic OPD in case of ambulatory patients during the period of November 2003 to June 2006 randomly.In every case detail obstetric history, general examination and relevant pathological investigations were carried out. In every case, pupil was dilated with
homatropine (2%) eye drops and detailed ophthalmic examination was carried out.Assessment of prognosis as regards to vision and life (mortality) was made.
Primary outcome(s): An observational study in which the patients for the study are selected from antenatal clinic, antenatal ward and preeclampsia and eclampsia room” in Department of Obstetrics and Gynecology and general ophthalmic OPD in case of ambulatory patients during the period of November 2003 to June 2006 randomly.
In every case detail obstetric history, general examination and relevant pathological investigations were carried out. In every case, pupil was dilated with homatropine (2%) eye drops and detailed ophthalmic examination was carried out.
Fundus findings were noted in detail, changes in the color of the disc, disc margin, physiological cup, changes in retinal blood vessels especially caliber of vessels, arterio-venous (AV) ratio,changes in vessel wall, blood column, appearance of vascular
light reflex, changes at AV crossings, changes in macular area and changes in background, overall appearance, presence of hemorrhages, exudates or any pathology were recorded.Correlation of fundus changes with disease entity,age,gravida,systolic and diastolic blood pressure,duration of pregnancy and significance of individual fundus changes were noted.
Study Design: Allocation: Single arm study;. Masking: Open (masking not used). Control: Uncontrolled/Single arm. Assignment: Single (group). Study design purpose: Diagnostic'
					   );

call expected.insert_study_details(sid => _sid, syear => 2003, smonth => 11, typeid => 12, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '300', eligid => 905, minage => 18, minageu => 17, maxage => 42, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From the Deutschen Register Klinischer Studien');

	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100124, idorgname => 'Deutschen Register Klinischer Studien', iddate => '2016 Dec 5');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'U1111-1189-6165', idorgid => 100115, idorgname => 'International Clinical Trials Registry Platform');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'JPRN-UMIN000024722', idorgid => 100127, idorgname => 'Japan Primary Registries Network"');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT03076619', idorgid => 100120, idorgname => 'ClinicalTrials.gov');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Rahul Bakhda', affiliation => 'Ex-Resident, M and J Western Regional Institute of Ophthalmology, Ahmedabad',
									  orgname => 'M and J Western Regional Institute of Ophthalmology');
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'M and J Western Regional Institute of Ophthalmology, Ahmedabad');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'M and J Western Regional Institute of Ophthalmology');

call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 599);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Pregnancy Induced Hypertension');

-- trial registry entry
_oid = _sid ||' :: 13 :: German registry web page';

call expected.insert_data_object(sd_oid => _oid, sid => _sid,
	title => _title || ' :: German registry web page',
	pubyear => 2016, obclassid => 23, obtypeid => 13,
	managingorgid => 100124, managingorgname=> 'Deutschen Register Klinischer Studien',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: German registry web page', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100124, reporgname => 'Deutschen Register Klinischer Studien', 
	purl => 'http://www.drks.de/DRKS00011324',  
	restypeid => 35);
	
call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2016 Dec 5', syear => 2016, smonth => 12, sday => 5);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2022 Mar 7', syear => 2022, smonth => 3, sday => 7);	

end;
$BODY$;
ALTER PROCEDURE expected.study_drks00011324()
    OWNER TO postgres;
 
             */            
        }

        return null;
    }
}