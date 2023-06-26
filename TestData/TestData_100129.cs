namespace MDR_Tester;

public class TestData_100129 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "PER-015-19")
        {
            /*
             -- PROCEDURE: expected.study_per_015_19()

-- DROP PROCEDURE IF EXISTS expected.study_per_015_19();

CREATE OR REPLACE PROCEDURE expected.study_per_015_19(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'PER-015-19';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'STUDY OF EFFICACY AND SAFETY OF PEMBROLIZUMAB PLUS PLATINUM-BASED DOUBLET CHEMOTHERAPY WITH OR WITHOUT CANAKINUMAB IN PREVIOUSLY UNTREATED LOCALLY ADVANCED OR METASTATIC NON-SQUAMOUS AND SQUAMOUS NSCLC SUBJECTS';

call expected.insert_study_names(sid => _sid, 
						title =>_title, 
						brief_desc =>'Interventions: Group name:01 Type of group;1 N° of participants:300 Intervention(s) description:Canakinumab
(ACZ885)
Solution for s.c. injection
in prefilled syringe
Strength:150 mg/1 mL AND
50 mg/0.5 mL
Dose:200 mg
Frequency: Q3W (or Q6W)

Group name:02 Type of group;1 N° of participants:300 Intervention(s) description:Canakinumab
(ACZ885)
Solution for s.c. injection
in prefilled syringe
Strength:0 mg/1 mL AND
0 mg/0.5 mL
Dose: 0 mg
Frequency: Q3W (or Q6W)
Primary outcome(s): Outcome name:Kaplan-Meier method
Measure:Progression Free Survival and Overall Survival
Timepoints:FS is defined as the time from the date of randomization to the date of the first documented disease progression
Study Design: This is a double-blind, randomized, multicenter phase III study evaluating the efficacy and safety of canakinumab vs. canakinumab matching-placebo in combination with pembrolizumab in addition to 4 cycles of platinum-based doublet induction chemotherapy, followed by maintenance therapy in subjects with AJCC v. 8 stage IIIB (not eligible for definite chemoradiation therapy) or stage IV (metastatic) NSCLC regardless of PD-L1 levels and histology (squamous and non-squamous). Subjects who completed 4 cycles of induction treatment and fulfill eligibility criteria as defined in Section 6.1.4.1 will enter the maintenance treatment phase. For dosing regimen, please refer to Section 6.1.3 .
Peru :Participate on part 2 :

Part 2: Double-blind, randomized, placebo-controlled part
Once the RP3R for canakinumab in combination with pembrolizumab and platinum-based
doublet chemotherapy is confirmed in the safety run-in part, the double-blind, randomized,pla'
	   );

call expected.insert_study_details(sid => _sid, syear => 2019, smonth => 9, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => 0, eligid => 915, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From the Registro Peruano de Ensayos Clínicos');
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'A RANDOMIZED, DOUBLE-BLIND, PLACEBO-CONTROLLED, PHASE III STUDY EVALUATING THE EFFICACY AND SAFETY OF PEMBROLIZUMAB PLUS PLATINUM-BASED DOUBLET CHEMOTHERAPY WITH OR WITHOUT CANAKINUMAB AS FIRST LINE THERAPY FOR LOCALLY ADVANCED OR METASTATIC NON-SQUAMOUS AND SQUAMOUS NON-SMALL CELL LUNG CANCER SUBJECTS (CANOPY-1)',
						 isdefault => false, comms => 'From the Registro Peruano de Ensayos Clínicos');

	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100129, idorgname => 'Registro Peruano de Ensayos Clínicos', iddate => '2019 Sep 18');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT03631199', idorgid => 100120, idorgname => 'Clinicaltrials.gov');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => '2018-001547-32', idorgid => 100123, idorgname => 'EU Clinical Trials Register');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Hedwig Schmidt', affiliation => 'NOVARTIS BIOSCIENCES PERU SA', orgname => 'NOVARTIS BIOSCIENCES PERU SA');
call expected.insert_indiv_contributor(sid => _sid, typeid => 56, full_name => 'Jose Ortiz', affiliation => 'NOVARTIS BIOSCIENCES PERU SA', orgname => 'NOVARTIS BIOSCIENCES PERU SA' );
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'NOVARTIS BIOSCIENSES PERU SA');

call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 130);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 510);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, ctid => 12, oricode => 'C10', orivalue => 'Malignant neoplasm of oropharynx');

-- trial registry entry
_oid = _sid ||' :: 13 :: Peruvian registry web page';

call expected.insert_data_object(sd_oid => _oid, sid => _sid,
	title => _title || ' :: Peruvian registry web page',
	pubyear => 2019, obclassid => 23, obtypeid => 13,
	managingorgid => 100129, managingorgname=> 'Registro Peruano de Ensayos Clínicos',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: Peruvian registry web page', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100129, reporgname => 'Registro Peruano de Ensayos Clínicos', 
	purl => 'https://www.ins.gob.pe/ensayosclinicos/rpec/recuperarECPBNuevoEN.asp?numec=015-19',  
	restypeid => 35);
	
	
call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2019 Sep 18', syear => 2019, smonth => 9, sday => 18);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2022 Mar 22', syear => 2022, smonth => 3, sday => 22);

end;
$BODY$;
ALTER PROCEDURE expected.study_per_015_19()
    OWNER TO postgres;
 
             */            
        }
        return null;
    }
}