namespace MDR_Tester;

public class TestData_100123 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
      
        if (sd_sid == "2009-011622-34")
        {
            /*
             -- PROCEDURE: expected.study_2009_011622_34()

-- DROP PROCEDURE IF EXISTS expected.study_2009_011622_34();

CREATE OR REPLACE PROCEDURE expected.study_2009_011622_34(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := '2009-011622-34';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'An open label non-randomized extension study to evaluate the safety and tolerability of AIN457 (anti interleukin-17 monoclonal antibody) in patientswith psoriatic arthritis';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc =>'Primary objectives: To assess the safety and tolerability of AIN457 administered i.v. initially up to six months (Part 1) with a possible extension of a further 6 months (Part 2) in patients with psoriatic arthritis who participated in the core CAIN457A2206 phase II proof-of-concept study'
					   );

call expected.insert_study_details(sid => _sid, syear => 2010, smonth => 4, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 900, minage => 18, minageu => 17, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'An open label non-randomized extension study to evaluate the safety and tolerability of AIN457 (anti interleukin-17 monoclonal antibody) in patientswith psoriatic arthritis', 
						 isdefault => true, comms => 'From the EU CTR');
-- acronym					 
call expected.insert_study_title(sid => _sid, typeid => 14, 
                         title => 'A2206E1', 
						 isdefault => false, comms => 'From the EU CTR');
	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100123, idorgname => 'EU Clinical Trials Register');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'CAIN457A2206E1', idorgname => 'Novartis Pharma Services AG');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'Novartis Pharma Services AG');

call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 120);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 500);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Psoriatic arthritis (PsA), which belongs to seronegative spondyloarthropathies (SpA).');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'AIN457');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, ctid => 16, oricode => '10037160', orivalue => 'Psoriatic arthritis');

-- trial registry entry
_oid = _sid ||' :: 13 :: EU CTR registry entry';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
	title => _title,
	title_qualifier => 'EU CTR registry entry',
	pubyear => 2010, obclassid => 23, obtypeid => 13,
	managingorgid => 100123, managingorgname=> 'EU Clinical Trials Register',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100123, reporgname => 'EU Clinical Trials Register', 
	purl => 'https://www.clinicaltrialsregister.eu/ctr-search/trial/2009-011622-34/DE', 
	restypeid => 35);

call expected.insert_object_date(sd_oid => _oid, typeid => 12, datestring => '2010 Jan 5', syear => 2010, smonth => 1, sday => 5);

-- trial results entry
_oid = _sid ||' :: 28 :: EU CTR results entry';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
	title => _title,
	title_qualifier => 'EU CTR results entry',
	pubyear => 2016, obclassid => 23, obtypeid => 28,
	managingorgid => 100123, managingorgname=> 'EU Clinical Trials Register',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid,
    reporgid => 100123, reporgname => 'EU Clinical Trials Register', 
	purl => 'https://www.clinicaltrialsregister.eu/ctr-search/trial/2009-011622-34/results', 
	restypeid => 35);
	
call expected.insert_object_date(sd_oid => _oid,typeid => 12, datestring => '2016 Dec 15', syear => 2016, smonth => 12, sday => 15);
call expected.insert_object_date(sd_oid => _oid,typeid => 18, datestring => '2016 Dec 15', syear => 2016, smonth => 12, sday => 15);
	
	
-- results summary
_oid = _sid ||' :: 79 :: CAIN457A2206E1.CTR.08Nov2016';
call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
	title => _title,
	title_qualifier => 'CAIN457A2206E1.CTR.08Nov2016',
	pubyear => 2016, obclassid => 23, obtypeid => 79,
	managingorgid => null, managingorgname=> 'Novartis Pharma Services AG',
	acctypeid => 11, title_typeid => 21);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100123, reporgname => 'EU Clinical Trials Register', 
	purl => 'https://www.clinicaltrialsregister.eu/ctr-search/rest/download/result/attachment/2009-011622-34/1/16214', 
	restypeid => 11);
	
end;
$BODY$;
ALTER PROCEDURE expected.study_2009_011622_34()
    OWNER TO postgres;
 
             */            
        }
        
        if (sd_sid == "2018-001547-32")
        {
            /*
            -- PROCEDURE: expected.study_2018_001547_32()

-- DROP PROCEDURE IF EXISTS expected.study_2018_001547_32();

CREATE OR REPLACE PROCEDURE expected.study_2018_001547_32(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := '2018-001547-32';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'Study of efficacy and safety of pembrolizumab plus platinum-based doublet chemotherapy with or without canakinumab in previously untreated locally advanced or metastatic non-squamous and squamous NSCLC subjects';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc =>'Primary objectives: Safety run-in part: To determine the recommended phase 3 dose regimen (RP3R) of canakinumab in combination with  pembrolizumab plus platinum-based doublet chemotherapy. 
Double-blind, randomized, placebo-controlled part: To compare progression free survival (PFS) by local investigator assessment as per RECIST 1.1 and overall survival (OS) between the two treatment arms.'
	);

call expected.insert_study_details(sid => _sid, syear => 2018, smonth => 12, typeid => 11, statusid => 25);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 900, minage => 18, minageu => 17, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 15, 
                         title => 'Study of efficacy and safety of pembrolizumab plus platinum-based doublet chemotherapy with or without canakinumab in previously untreated locally advanced or metastatic non-squamous and squamous NSCLC subjects', 
						 isdefault => true, comms => 'From the EU CTR');
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'A randomized, double-blind, placebo-controlled, phase III study evaluating the efficacy and safety of pembrolizumab plus platinum-based doublet chemotherapy with or without canakinumab as first line therapy for locally advanced or metastatic non-squamous and squamous non-small cell lung cancer subjects (CANOPY-1)', 
						 isdefault => false, comms => 'From the EU CTR');
-- acronym					 

	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100123, idorgname => 'EU Clinical Trials Register');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'CACZ885U2301', idorgname => 'Novartis Pharma AG');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'Novartis Pharma AG');

call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 130);
call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 23, valueid  => 305);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 510);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'canakinumab');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'pembrolizumab');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'cisplatin');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'carboplatin');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'paclitaxel');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'nab-paclitaxel');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'pemetrexed');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, ctid => 16, oricode => '10061873', orivalue => 'Non-small cell lung cancer');

-- trial registry entry
_oid = _sid ||' :: 13 :: EU CTR registry entry';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
	title => _title,
	title_qualifier => 'EU CTR registry entry',
	pubyear => 2018, obclassid => 23, obtypeid => 13,
	managingorgid => 100123, managingorgname=> 'EU Clinical Trials Register',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100123, reporgname => 'EU Clinical Trials Register', 
	purl => 'https://www.clinicaltrialsregister.eu/ctr-search/trial/2018-001547-32/DE', 
	restypeid => 35);

call expected.insert_object_date(sd_oid => _oid, typeid => 12, datestring => '2018 Oct 1', syear => 2018, smonth => 10, sday => 1);

end;
$BODY$;
ALTER PROCEDURE expected.study_2018_001547_32()
    OWNER TO postgres;
 
            */           
        }

        if (sd_sid == "2004-001569-16")
        {
            /*
            -- PROCEDURE: expected.study_2004_001569_16()

-- DROP PROCEDURE IF EXISTS expected.study_2004_001569_16();

CREATE OR REPLACE PROCEDURE expected.study_2004_001569_16(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE 
_sid VARCHAR := '2004-001569-16';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'EFFICIENCY AND SAFETY OF CLINAVIT PAEDIATRIC AT A WEIGHT DEPENDANT DOSE ADMINISTERED DAILY FOR 5 CONTINUOUS DAYS ON 4 VITAMINS BLOOD LEVEL IN NEONATES AND CHILDREN UP TO 11 YEARS OF AGE RECEIVING PARENTERAL NUTRITION. A PROSPECTIVE, MULTICENTRE, RANDOMISED, COMPARATIVE, DOUBLE BLIND PHASE III STUDY IN THERAPEUTIC USE VERSUS SOLUVIT AND VITALIPID INFANT CARRIED OUT IN PARALLEL GROUPS.   EFICACIA Y ...';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc =>'Primary objectives: Main objective : To confirm that Clinavit Paediatric is an efficient and safe alternative to Soluvit and Vitalipid Infant, the current vitamins cocktail used for parenteral nutrition supplementation in neonates, infants and children up to 11 years of age, through the assessment of:·	The blood levels of the most commonly explored vitamins in literature as surrogate markers of effective intake,·	The vital signs and adverse events occurring within the 5-day treatment period.'
					   );

call expected.insert_study_details(sid => _sid, syear => 2006, smonth => 7, typeid => 11, statusid => 25);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 900, minage => 0, minageu => 14, maxage => 11, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'EFFICIENCY AND SAFETY OF CLINAVIT PAEDIATRIC AT A WEIGHT DEPENDANT DOSE ADMINISTERED DAILY FOR 5 CONTINUOUS DAYS ON 4 VITAMINS BLOOD LEVEL IN NEONATES AND CHILDREN UP TO 11 YEARS OF AGE RECEIVING PARENTERAL NUTRITION. A PROSPECTIVE, MULTICENTRE, RANDOMISED, COMPARATIVE, DOUBLE BLIND PHASE III STUDY IN THERAPEUTIC USE VERSUS SOLUVIT AND VITALIPID INFANT CARRIED OUT IN PARALLEL GROUPS.   EFICACIA Y SEGURIDAD DE CLINAVIT PEDIÁTRICO,  A UNA  DOSIS DEPENDIENTE DEL PESO, ADMINISTRADO A DIARIO DURANTE 5 DÍAS CONSECUTIVOS, MEDIDAS POR LA CONCENTRACIÓN SANGUÍNEA DE 4 VITAMINAS EN NEONATOS Y NIÑOS DE HASTA 11 AÑOS DE EDAD TRATADOS CON NUTRICIÓN PARENTERAL. ESTUDIO EN FASE III PROSPECTIVO, MULTICÉNTRICO, ALEATORIZADO, COMPARATIVO, ABIERTO Y DE GRUPOS PARALELOS EN USO TERAPÉUTICO FRENTE A SOLUVIT Y VITALIPID INFANT.', 
								 isdefault => true, comms => 'From the EU CTR');

call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100123, idorgname => 'EU Clinical Trials Register');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'VITPED/P01/04/MU.UK', idorgname => 'BAXTER SAS R&D Parenteral Nutrition');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'BAXTER SAS R&D Parenteral Nutrition');

call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 130);
call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 23, valueid  => 305);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 510);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Clinavit Pediatric');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Vitalipid infant');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'soluvit');

-- trial registry entry
_oid = _sid ||' :: 13 :: EU CTR registry entry';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
	title => _title,
	title_qualifier => 'EU CTR registry entry',
	pubyear => 2006, obclassid => 23, obtypeid => 13,
	managingorgid => 100123, managingorgname=> 'EU Clinical Trials Register',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100123, reporgname => 'EU Clinical Trials Register', 
	purl => 'https://www.clinicaltrialsregister.eu/ctr-search/trial/2004-001569-16/ES', 
	restypeid => 35);
	
call expected.insert_object_date(sd_oid => _oid, typeid => 12, datestring => '2006 Jun 30', syear => 2006, smonth => 6, sday => 30);
	
end;
$BODY$;
ALTER PROCEDURE expected.study_2004_001569_16()
    OWNER TO postgres;
 
            */           
        }
        
        if (sd_sid == "2012-000615-84")
        {
            /*
            -- PROCEDURE: expected.study_2012_000615_84()

-- DROP PROCEDURE IF EXISTS expected.study_2012_000615_84();

CREATE OR REPLACE PROCEDURE expected.study_2012_000615_84(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := '2012-000615-84';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'The MEMOS study: A Eurosarc Study of Mifamurtide in advanced osteosarcoma';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc =>'Primary objectives: The principal research question is to identify markers of response to mifurmatide by looking at biological markers of immune response activation in tumour biopsies taken before and after 6 weeks of treatment. The pharmacodynamic readouts will be compared with radiological (CT scan) response measured by standard RECIST criteria.'
					   );

call expected.insert_study_details(sid => _sid, syear => 2014, smonth => 11, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 900, minage => 12, minageu => 17, maxage => 64, maxageu => 17);

call expected.insert_study_title(sid => _sid, typeid => 15, 
                         title => 'The MEMOS study: A Eurosarc Study of Mifamurtide in advanced osteosarcoma', 
						 isdefault => true, comms => 'From the EU CTR');
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'A Mechanistic Study Of Mifamurtide (MTP-PE) In Patients With Metastatic And/Or Recurrent Osteosarcoma', 
						 isdefault => false, comms => 'From the EU CTR');

	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100123, idorgname => 'EU Clinical Trials Register');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'OCTO_039', idorgname => 'University of Oxford');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'University of Oxford');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'Millennium Pharmaceuticals, Inc, a wholly-owned subsidiary of Takeda Pharmaceutical Company Limited');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'EU frame grant');

call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 120);
call expected.insert_study_feature(sid => _sid, typeid => 22, valueid  => 205);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 500);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Relapsed or metastatic osteosarcoma');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'mifamurtide');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Ifosfamide');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, ctid => 16, oricode => '10031291', orivalue => 'Osteosarcoma');

-- trial registry entry
_oid = _sid ||' :: 13 :: EU CTR registry entry';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
	title => _title,
	title_qualifier => 'EU CTR registry entry',
	pubyear => 2014, obclassid => 23, obtypeid => 13,
	managingorgid => 100123, managingorgname=> 'EU Clinical Trials Register',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100123, reporgname => 'EU Clinical Trials Register', 
	purl => 'https://www.clinicaltrialsregister.eu/ctr-search/trial/2012-000615-84/IT', 
	restypeid => 35);

call expected.insert_object_date(sd_oid => _oid, typeid => 12, datestring => '2014 Sep 10', syear => 2014, smonth => 9, sday => 10);

-- trial results entry
_oid = _sid ||' :: 28 :: EU CTR results entry';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
	title => _title,
	title_qualifier => 'EU CTR results entry',
	pubyear => 2017, obclassid => 23, obtypeid => 28,
	managingorgid => 100123, managingorgname=> 'EU Clinical Trials Register',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100123, reporgname => 'EU Clinical Trials Register', 
	purl => 'https://www.clinicaltrialsregister.eu/ctr-search/trial/2012-000615-84/results', 
	restypeid => 35);
	
call expected.insert_object_date(sd_oid => _oid, typeid => 12, datestring => '2017 Aug 16', syear => 2017, smonth => 8, sday => 16);
call expected.insert_object_date(sd_oid => _oid, typeid => 18, datestring => '2017 Aug 16', syear => 2017, smonth => 8, sday => 16);
	
	
-- results summary
_oid = _sid ||' :: 79 :: CSR summary - PDF DL';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
	title => _title,
	title_qualifier => 'CSR summary',
	pubyear => 2017, obclassid => 23, obtypeid => 79,
	managingorgid => null, managingorgname=> 'University of Oxford',
	acctypeid => 11, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid, 
    reporgid => 100123, reporgname => 'EU Clinical Trials Register', 
	purl => 'https://www.clinicaltrialsregister.eu/ctr-search/rest/download/result/zip/pdf/2012-000615-84/1', 
	restypeid => 11);
	
end;
$BODY$;
ALTER PROCEDURE expected.study_2012_000615_84()
    OWNER TO postgres;

            */           
        }
        
        if (sd_sid == "2013-001036-22")
        {
            /*
            -- PROCEDURE: expected.study_2013_001036_22()

-- DROP PROCEDURE IF EXISTS expected.study_2013_001036_22();

CREATE OR REPLACE PROCEDURE expected.study_2013_001036_22(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := '2013-001036-22';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'Assesment of response predictor genes in patients with initial breast cancer HER2+ to the lapatinib and trastuzumab treatment combination before surgery.';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc =>'Primary objectives: To evaluate the ability of the PAM50 HER2-enriched (HER2-E) subtype to predict pathological complete response in the breast (pCRB) to dual HER2 blockade with lapatinib and trastuzumab, with or without endocrine therapy, at the time of surgery.
(Evaluar la capacidad del subtipo HER2-E determinado con la plataforma PAM50 para predecir la respuesta patológica completa a nivel de la mama (RpCM) en el momento de la cirugía, tras el bloqueo dual del HER2 con lapatinib y trastuzumab (+/- terapia hormonal).)'
					   );

call expected.insert_study_details(sid => _sid, syear => 2013, smonth => 10, typeid => 11, statusid => 21);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 905, minage => 18, minageu => 17, maxage => null, maxageu => null);  

call expected.insert_study_title(sid => _sid, typeid => 15, 
                         title => 'Assesment of response predictor genes in patients with initial breast cancer HER2+ to the lapatinib and trastuzumab treatment combination before surgery.', 
						 isdefault => true, comms => 'From the EU CTR');
call expected.insert_study_title(sid => _sid, typeid => 15, 
                         title => 'Determinación de genes predictores de respuesta a la combinación del tratamiento con lapatinib y trastuzumab en pacientes con cancer de mama inicial HER2+ previo a la cirugia.', 
						 title_lang => 'es', usage_id => 22,
						 isdefault => false, comms => 'From the EU CTR');					 
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'PAM50 HER2-enriched phenotype as a predictor of early response to neoadjuvant lapatinib plus trastuzumab in Stage I to IIIA HER2-positive breast cancer', 
						 isdefault => false, comms => 'From the EU CTR');
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'Fenotipo HER2-enriquecido determinado por la plataforma PAM50 como predictor de respuesta temprana a la administración neoadyuvante de la combinación de lapatinib y trastuzumab con o sin terapia hormonal en cáncer de mama HER2+ estadios I a IIIA', 
						 title_lang => 'es', usage_id => 22,
						 isdefault => false, comms => 'From the EU CTR');						
-- acronym					 
call expected.insert_study_title(sid => _sid, typeid => 14, 
                         title => 'PAMELA', 
						 isdefault => false, comms => 'From the EU CTR');

	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100123, idorgname => 'EU Clinical Trials Register');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'SOLTI-1114', idorgname => 'SOLTI');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'SOLTI');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'GSK');

call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 120);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 500);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Untreated invasive breast carcinoma eligible for primary definitive surgery (Stage I-IIIA)');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'Carcinoma de mama invasivo, inicial, y apto para la cirugía definitiva (Fase I-IIIA)');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Lapatinib');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Letrozol');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Citrato de Tamoxifeno');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'Trastuzumab');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'PACLITAXEL');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, ctid => 16, oricode => '10065430', orivalue => 'HER-2 positive breast cancer');

-- trial registry entry
_oid = _sid ||' :: 13 :: EU CTR registry entry';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid, 
	title => _title,
	title_qualifier => 'EU CTR registry entry',
	pubyear => 2013, obclassid => 23, obtypeid => 13,
	managingorgid => 100123, managingorgname=> 'EU Clinical Trials Register',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid,
    reporgid => 100123, reporgname => 'EU Clinical Trials Register', 
	purl => 'https://www.clinicaltrialsregister.eu/ctr-search/trial/2013-001036-22/ES', 
	restypeid => 35);

call expected.insert_object_date(sd_oid => _oid, typeid => 12, datestring => '2013 Jul 12', syear => 2013, smonth => 7, sday => 12);
	
end;
$BODY$;
ALTER PROCEDURE expected.study_2013_001036_22()
    OWNER TO postgres;
 
            */           
        }

        if (sd_sid == "2015-000556-14")
        {
            /*
            -- PROCEDURE: expected.study_2015_000556_14()

-- DROP PROCEDURE IF EXISTS expected.study_2015_000556_14();

CREATE OR REPLACE PROCEDURE expected.study_2015_000556_14(
	)
LANGUAGE 'plpgsql'
AS $BODY$
DECLARE _sid VARCHAR := '2015-000556-14';
_title VARCHAR;
_oid VARCHAR;

begin
-- delete any existing values
call expected.clear_study_data(_sid);

-- manual update of values using visual inspection of trial registry

_title = 'Vaccination with dendritic cells pulsed with autologous tumorhomogenate in combination with HD-IL2 and immunomodulating radiotherapy in metastatic RCC: a phase II trial (RENALVax-2)';

call expected.insert_study_names(sid => _sid, 
						title => _title, 
						brief_desc =>'Primary objectives: Overal Response Rate by irRC
(Tasso di risposta globale, secondo irRC)'
					   );

call expected.insert_study_details(sid => _sid, syear => 2016, smonth => 02, typeid => 11, statusid => 22);
call expected.insert_study_eligibility(sid => _sid, enrolnum => null, eligid => 900, minage => 18, minageu => 17, maxage => null, maxageu => null);

call expected.insert_study_title(sid => _sid, typeid => 15, 
                         title => 'Vaccination with dendritic cells pulsed with autologous tumorhomogenate in combination with HD-IL2 and immunomodulating radiotherapy in metastatic RCC: a phase II trial (RENALVax-2)', 
						 isdefault => true, comms => 'From the EU CTR');
call expected.insert_study_title(sid => _sid, typeid => 15, 
                         title => 'Vaccinazione con cellule dendritichepulsate con omogenato tumorale autologo in combinazione con IL2 alte dosi e radioterapia immunomodulante nel carcinoma renalemetastatico: studio clinico di fase II.', 
						 title_lang => 'it', usage_id => 22,
						 isdefault => false, comms => 'From the EU CTR');
call expected.insert_study_title(sid => _sid, typeid => 16, 
                         title => 'Vaccination with dendritic cells pulsed with autologous tumor homogenate in combination with HD-IL2 and immunomodulating radiotherapy in metastatic RCC: a phase II trial (RENALVax-2)', 
						 isdefault => false, comms => 'From the EU CTR');
-- acronym					 
call expected.insert_study_title(sid => _sid, typeid => 14, 
                         title => 'RENALVax-2', 
						 isdefault => false, comms => 'From the EU CTR');

	
call expected.insert_study_identifier(sid => _sid, typeid => 11, idvalue => _sid, idorgid => 100123, idorgname => 'EU Clinical Trials Register');
call expected.insert_study_identifier(sid => _sid, typeid => 14, idvalue => 'IRST189.03', idorgname => 'ISTITUTO SCIENTIFICO ROMAGNOLO PER LO STUDIO E LA CURA DEI TUMORI (IRST) SRL IRCCS');

call expected.insert_org_contributor(sid => _sid, typeid => 54, orgname => 'ISTITUTO SCIENTIFICO ROMAGNOLO PER LO STUDIO E LA CURA DEI TUMORI (IRST) SRL IRCCS');
call expected.insert_org_contributor(sid => _sid, typeid => 58, orgname => 'IRST-IRCCS');

call expected.insert_study_feature(sid => _sid, typeid => 20, valueid  => 120);
call expected.insert_study_feature(sid => _sid, typeid => 24, valueid  => 500);

call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'metastatic renal cancer');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, orivalue => 'carcinoma renale metastatico');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'DC-VACCINE_IRSTIRCCS');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 12, orivalue => 'IL2_IRSTIRCCS');
call expected.insert_nonmesh_study_topic(sid => _sid, typeid => 13, ctid => 16, oricode => '10050513', orivalue => 'Metastatic renal cell carcinoma');

-- trial registry entry
_oid = _sid ||' :: 13 :: EU CTR registry entry';

call expected.insert_simple_object(sd_oid => _oid, sid => _sid,
	title => _title,
	title_qualifier => 'EU CTR registry entry',
	pubyear => 2017, obclassid => 23, obtypeid => 13,
	managingorgid => 100123, managingorgname=> 'EU Clinical Trials Register',
	acctypeid => 12, title_typeid => 22);

call expected.insert_object_instance(sd_oid => _oid,
    reporgid => 100123, reporgname => 'EU Clinical Trials Register', 
	purl => 'https://www.clinicaltrialsregister.eu/ctr-search/trial/2015-000556-14/IT', 
	restypeid => 35);

call expected.insert_object_date(sd_oid => _oid, typeid => 12, datestring => '2017 Dec 15', syear => 2017, smonth => 12, sday => 15);

end;
$BODY$;
ALTER PROCEDURE expected.study_2015_000556_14()
    OWNER TO postgres;

            */           
        }
        
        return null;
    }
}