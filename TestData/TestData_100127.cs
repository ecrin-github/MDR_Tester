namespace MDR_Tester;

public class TestData_100127 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "JPRN-UMIN000028075")
        {
            /*
             -- PROCEDURE: expected.study_jprn_umin000028075()

-- DROP PROCEDURE IF EXISTS expected.study_jprn_umin000028075();

CREATE OR REPLACE PROCEDURE expected.study_jprn_umin000028075(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'JPRN-UMIN000028075';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'A phase I/II study of crizotinib for recurrent or refractory anaplastic lymphoma kinase (ALK)-positive anaplastic large cell lymphoma (ALCL) and phase I study of this drug for recurrent or refractory neuroblastoma';

call expected.insert_study_names(sid => _sid, 
						title =>_title, 
						brief_desc =>'Interventions: A multicenter, single group assignment, open label, phase I dose-escalation study followed by a phase II study.
This drug should be orally administered twice a day. It should be repeatedly administered, regarding 28 days as a cycle.Each cycle will be repeated every 28 days.  The data cutoff is carry out at 6 cycles for the phase 1 part and 12 cycles for the phase 2 part.
Primary outcome(s): [Phase 1 part]
Dose-limiting toxicity
[Phase 2 part]
Response rate evaluated by the Central Evaluation Committee
Study Design: Single arm Non-randomized'
					   );

call expected.insert_study_details(sid => _sid, syear => 2017, smonth => 10, typeid => 11, statusid => 14);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '23', eligid => 900, minage => 1, minageu => 17, maxage => 22, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From the Japan Primary Registries Network');
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'A phase I/II study of crizotinib for recurrent or refractory anaplastic lymphoma kinase (ALK)-positive anaplastic large cell lymphoma (ALCL) and phase I study of this drug for recurrent or refractory neuroblastoma - A phase I/II study of crizotinib for recurrent or refractory anaplastic lymphoma kinase (ALK)-positive anaplastic large cell lymphoma (ALCL) and phase I study of this drug for recurrent or refractory neuroblastoma', 
						 isdefault => false, comms => 'From the Japan Primary Registries Network');
	
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100127, idorgname => 'Japan Primary Registries Network', iddate => '2017 Jul 19');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Tetsuya Mori', affiliation => 'St Marianna University School of Medicine Hospital Department of Pediatrics',
									   orgname => 'St Marianna University School of Medicine Hospital Department of Pediatrics' );
call expected.insert_indiv_contributor(sid => _sid, typeid => 56, full_name => 'Yutaka Ito', affiliation => 'National Hospital Organization Nagoya Medical Center Department of Clinical Research Management, Clinical Research Center',
									   orgname => 'National Hospital Organization Nagoya Medical Center Department of Clinical Research Management' );
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'St Marianna University School of Medicine HospitalNational Center for Child Health and DevelopmentNagoya Medical CenterKyushu University Hospital');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'AMED');

call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 210);
call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 115);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Recurrent or refractory anaplastic lymphoma kinase (ALK)-positive anaplastic large cell lymphoma.Recurrent or refractory neuroblastoma');

-- trial registry entry
_oid = _sid ||' :: 13 :: Japanese registry web page';

call expected.insert_data_object(sd_oid => _oid, sid => _sid, 
	title => _title || ' :: Japanese registry web page',
	pubyear => 2017, obclassid => 23, obtypeid => 13,
	managingorgid => 100127, managingorgname=> 'Japan Primary Registries Network',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: Japanese registry web page', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100127, reporgname => 'Japan Primary Registries Network', 
	purl => 'https://upload.umin.ac.jp/cgi-open-bin/ctr_e/ctr_view.cgi?recptno=R000031711',  
	restypeid => 35);
	
call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2017 Jul 19', syear => 2017, smonth => 7, sday => 19);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2019 Apr 23', syear => 2019, smonth => 4, sday => 23);

end;
$BODY$;
ALTER PROCEDURE expected.study_jprn_umin000028075()
    OWNER TO postgres;
 
             */
        }
        
        if (sd_sid == "JPRN-jRCTs012180017")
        {
            /*
            -- PROCEDURE: expected.study_jprn_jrcts012180017()

-- DROP PROCEDURE IF EXISTS expected.study_jprn_jrcts012180017();

CREATE OR REPLACE PROCEDURE expected.study_jprn_jrcts012180017(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'JPRN-jRCTs012180017';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'Usefulness of using C-11 methionine PET in patient which suspected glioma';

call expected.insert_study_names(sid => _sid, 
						title =>_title, 
						brief_desc =>'Interventions: Usefulness of using C-11 methionine PET
Primary outcome(s): Positive-predictive value (PPV) in the site of negative contrast-enhanced MRI and positive Met-PET which assume a histopathology diagnosis criteria diagnosis.
Study Design: single arm study, open(masking not used), no treatment control, single assignment, diagnostic purpose'
					   );

call expected.insert_study_details(sid => _sid, syear => 2016, smonth => 5, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '72', eligid => 900, minage => null, minageu => null, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From the Japan Primary Registries Network');
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'Usefulness of using C-11 methionine PET in patient which suspected glioma - Usefulness of using C-11 methionine PET in patient which suspected glioma',
					     isdefault => false, comms => 'From the Japan Primary Registries Network');
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100127, idorgname => 'Japan Primary Registries Network', iddate => '2019 Mar 19');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'JPRN-UMIN000022067', idorgid => 100127, idorgname => 'Japan Primary Registries Network');

call expected.insert_indiv_contributor(sid => _sid, typeid => 51, full_name => 'Shigeru Yamaguchi', affiliation => 'Hokkaido University Hospital',
									   orgname => 'Hokkaido University Hospital' );
call expected.insert_indiv_contributor(sid => _sid, typeid => 56, full_name => 'Nozomi Yokota', affiliation => 'Hokkaido University Hospital' ,
									   orgname => 'Hokkaido University Hospital' );
call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'Yamaguchi Shigeru');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'Sumitomo Heavy Industries, Ltd');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'Japan Agency for Medical Research and Development');

call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 130);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 500);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'glioma');

-- trial registry entry
_oid = _sid ||' :: 13 :: Japanese registry web page';

call expected.insert_data_object(sd_oid => _oid, sid => _sid, 
	title => _title || ' :: Japanese registry web page',
	pubyear => 2019, obclassid => 23, obtypeid => 13,
	managingorgid => 100127, managingorgname=> 'Japan Primary Registries Network',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid,  
	typeid => 22, title => _title || ' :: Japanese registry web page', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid,
    reporgid => 100127, reporgname => 'Japan Primary Registries Network', 
	purl => 'https://jrct.niph.go.jp/latest-detail/jRCTs012180017',  
	restypeid => 35);
	
call expected.insert_object_date(sd_oid => _oid,  typeid => 15, datestring => '2019 Mar 19', syear => 2019, smonth => 3, sday => 19);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2021 May 17', syear => 2021, smonth => 5, sday => 17);

-- results
_oid = _sid ||' :: 79 :: CSR summary';

call expected.insert_data_object(sd_oid => _oid, sid => _sid, 
	title => _title || ' :: CSR summary',
	pubyear => 2019, obclassid => 23, obtypeid => 79,
	managingorgid => null, managingorgname=> null,
	acctypeid => 11);

call expected.insert_object_title(sd_oid => _oid, 
	typeid => 22, title => _title || ' :: CSR summary', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => null, reporgname => null, 
	purl => 'https://jrct.niph.go.jp/latest-detail/jRCTs012180017',  
	restypeid => 35);
end;
$BODY$;
ALTER PROCEDURE expected.study_jprn_jrcts012180017()
    OWNER TO postgres;
 
            */           
        }

        if (sd_sid == "JPRN-UMIN000024722")
        {
            /*
            -- PROCEDURE: expected.study_jprn_umin000024722()

-- DROP PROCEDURE IF EXISTS expected.study_jprn_umin000024722();

CREATE OR REPLACE PROCEDURE expected.study_jprn_umin000024722(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := 'JPRN-UMIN000024722';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'A Clinical Study of Fundus Findings in Toxaemia of Pregnancy(Pregnancy Induced Hypertension)';

call expected.insert_study_names(sid => _sid, 
						title =>_title, 
						brief_desc =>'Primary outcome(s): In our study out of three hundred cases of pregnancy induced hypertension there are one hundred and eighty two cases of mild preeclampsia and seventy six cases of severe preeclampsia and forty two cases of eclampsia. Among these thirty seven cases of mild preeclampsia and seventy five cases  of severe preeclampsia and forty one cases of eclampsia show positive fundus changes.The incidence of pre term babies intra uterine death still birth and low birth weight infants is high in mothers having positive fundus changes. The perinatal mortality is higher in patients having Grade Two Three and Four hypertensive retinopathy'
					   );

call expected.insert_study_details(sid => _sid, syear => 2003, smonth => 11, typeid => 12, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => '300', eligid => 905, minage => 18, minageu => 17, maxage => 42, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 15, title => _title, isdefault => true, comms => 'From the Japan Primary Registries Network');
	
	
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100127, idorgname => 'Japan Primary Registries Network', iddate => '2016 Nov 4');
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => 'NCT03076619', idorgid => 100120, idorgname => 'Clinicaltrials.gov');

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Pregnancy Induced Hypertension(PIH)');

call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 599);

-- trial registry entry
_oid = _sid ||' :: 13 :: Japanese registry web page';

call expected.insert_data_object(sd_oid => _oid, sid => _sid,
	title => _title || ' :: Japanese registry web page',
	pubyear => 2016, obclassid => 23, obtypeid => 13,
	managingorgid => 100127, managingorgname=> 'Japan Primary Registries Network',
	acctypeid => 12);

call expected.insert_object_title(sd_oid => _oid,  
	typeid => 22, title => _title || ' :: Japanese registry web page', isdefault => true);
	
call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100127, reporgname => 'Japan Primary Registries Network', 
	purl => 'https://upload.umin.ac.jp/cgi-open-bin/ctr_e/ctr_view.cgi?recptno=R000028441',  
	restypeid => 35);
	
call expected.insert_object_date(sd_oid => _oid, typeid => 15, datestring => '2016 Nov 4', syear => 2016, smonth => 11, sday => 4);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2019 Apr 2', syear => 2019, smonth => 4, sday => 2);

end;
$BODY$;
ALTER PROCEDURE expected.study_jprn_umin000024722()
    OWNER TO postgres;
 
            */           
        }
        
        return null;
    }
}