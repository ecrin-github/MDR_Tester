namespace MDR_Tester;

public class TestData_100135 : TestData_Base
{
    public override FullDataObject? FetchObjectData(string sd_oid)
    {
        if (sd_oid == "27056882")
        {
            /*
            
-- article title
call expected.insert_object_pubmed_title(sid => _sid, typeid => 19, 
	title => 'Prognostic Relevance of Left Atrial Dysfunction in Heart Failure With Preserved Ejection Fraction.',
	isdefault => true);

-- journal details
call expected.insert_journal_details(sid =>_sid, eissn => '19413297', journal_title => 'Circulation. Heart failure');

-- description (journal string)
call expected.insert_object_description(sid =>_sid, typeid => 18, description_text => 'Circ Heart Fail. 2016 Apr. 9(4):e002763. doi:10.1161/CIRCHEARTFAILURE.115.002763. pii:e002763.'  );

-- contributors
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Santos', given_name => 'Angela B S', full_name => 'Angela B S Santos');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Roca', given_name => 'Gabriela Querejeta', full_name => 'Gabriela Querejeta Roca');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Claggett', given_name => 'Brian', full_name => 'Brian Claggett');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Sweitzer', given_name => 'Nancy K', full_name => 'Nancy K Sweitzer');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Shah', given_name => 'Sanjiv J', full_name => 'Sanjiv J Shah');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Anand', given_name => 'Inder S', full_name => 'Inder S Anand');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Fang', given_name => 'James C', full_name => 'James C Fang');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Zile', given_name => 'Michael R', full_name => 'Michael R Zile');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Pitt', given_name => 'Bertram', full_name => 'Bertram Pitt');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Solomon', given_name => 'Scott D', full_name => 'Scott D Solomon');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Shah', given_name => 'Amil M', full_name => 'Amil M Shah');

-- topics
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D000451', mvalue => 'Mineralocorticoid Receptor Antagonists');

call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D000368', mvalue => 'Aged');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D000369', mvalue => 'Aged, 80 and over');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D016279', mvalue => 'Atrial Function, Left');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D003971', mvalue => 'Diastole');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D015150', mvalue => 'Echocardiography, Doppler');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D006325', mvalue => 'Heart Atria');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D006333', mvalue => 'Heart Failure');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D006760', mvalue => 'Hospitalization');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D008875', mvalue => 'Middle Aged');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D012307', mvalue => 'Risk Factors');

call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D013314', mvalue => 'Stress, Mechanical');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D013318', mvalue => 'Stroke Volume');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D013599', mvalue => 'Systole');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D013997', mvalue => 'Time Factors');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D016896', mvalue => 'Treatment Outcome');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D018487', mvalue => 'Ventricular Dysfunction, Left');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D016277', mvalue => 'Ventricular Function, Left');

call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'atrial strain');
call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'diastolic heart failure');
call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'echocardiography');
call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'prognosis');

-- db links
call expected.insert_object_db_link(sid => _sid, db_sequence => 1, db_name => 'ClinicalTrials.gov', id_in_db => 'NCT00094302');

-- main data object

-- if (PMC_present) access_type_id = 11
-- else  access_type_id = 15, access_details = 'Not in PMC - presumed behind pay wall, but to check';

call expected.insert_pubmed_details(sid => _sid, 
                  title => 'Santos A, Roca G, Claggett B et al. Prognostic Relevance of Left Atrial Dysfunction in Heart Failure With Preserved Ejection Fraction. Circ Heart Fail. 2016 Apr. 9(4):e002763. doi:10.1161/CIRCHEARTFAILURE.115.002763. pii:e002763.', 
				  vers => '1', doid => '10.1161/CIRCHEARTFAILURE.115.002763', doidsid => 1,
				  pubyear => 2016, acctypeid => 11);

-- instances
-- for PMC:  new ObjectInstance(sdoid, 1, "Full resource", 100133, "National Library of Medicine", "https://www.ncbi.nlm.nih.gov/pmc/articles/" + other_id.ToString(), true, 36, "Web text with download"));	

call expected.insert_object_pubmed_instance(sid => _sid, insttypeid => 3, reporgid => 100133, reporgname => 'National Library of Medicine', 
	purl => 'https://www.ncbi.nlm.nih.gov/pubmed/' || _sid, accessible => true, restypeid => 40);
call expected.insert_object_pubmed_instance(sid => _sid, insttypeid => 1, reporgid => 100133, reporgname => 'National Library of Medicine', 
	purl => 'https://www.ncbi.nlm.nih.gov/pmc/articles/PMC4826720', accessible => true, restypeid => 36);
	

	
-- identifiers	
-- pii 34, Publisher article ID
-- 31, PMCID, 100133, "National Library of Medicine"));
-- 32, NIH Manuscript ID, other_id, 100134, "National Institutes of Health"));-- 33, NRCBL, other_id, 100447, "Georgetown University"));
-- 37, PMC Publisher ID-- 38, PM Publisher ID-- 35, Serial Item and Contribution Identifier 
-- 36, Medline UID, other_id, 100133, "National Library of Medicine
  
call expected.insert_object_identifier(sid => _sid, typeid => 16, idvalue => _sid, idorgid => 100133, idorgname => 'National Library of Medicine', iddate => '2016 Apr 9');
call expected.insert_object_identifier(sid => _sid, typeid => 34, idvalue => 'CIRCHEARTFAILURE.115.002763', iddate => '2016 Mar 4');
call expected.insert_object_identifier(sid => _sid, typeid => 31, idvalue => 'PMC4826720', idorgid => 100133, idorgname => 'National Library of Medicine');
call expected.insert_object_identifier(sid => _sid, typeid => 32, idvalue => 'NIHMS768831', idorgid => 100134, idorgname => 'National Institutes of Health');
call expected.insert_object_identifier(sid => _sid, typeid => 34, idvalue => 'e002763', iddate => '2016 Mar 4');

-- dates
--12, pub_date--52, Pubmed citation created--53, Pubmed citation_revised--54, Pubmed citation completed
--55, Epublish--17, received--11, accepted
                               
-- 56, Ppublish-- 57, Revised-- 58, Ahead of print publication
-- 59, Retracted-- 60, Added to eCollection-- 61, Added to PMC
-- 62, Added to Pubmed-- 63, Added to Medline-- 65, Added to entrez
-- 64, PMC embargo release

call expected.insert_object_pubmed_date(sid => _sid, typeid => 12, datestring => '2016 Apr', syear => 2016, smonth => 4 );
call expected.insert_object_pubmed_date(sid => _sid, typeid => 54, datestring => '2016 Aug 1', syear => 2016, smonth => 8, sday => 1);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 53, datestring => '2020 Dec 16', syear => 2020, smonth => 12, sday => 16);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 17, datestring => '2015 Oct 20', syear => 2015, smonth => 10, sday => 20);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 11, datestring => '2016 Mar 4', syear => 2016, smonth => 3, sday => 4);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 65, datestring => '2016 Apr 9', syear => 2016, smonth => 4, sday => 9);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 62, datestring => '2016 Apr 9', syear => 2016, smonth => 4, sday => 9);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 63, datestring => '2016 Aug 2', syear => 2016, smonth => 8, sday => 2);

--pub types	
call expected.insert_object_pub_type(sid => _sid, type_name => 'Journal Article');
call expected.insert_object_pub_type(sid => _sid, type_name => 'Multicenter Study');
call expected.insert_object_pub_type(sid => _sid, type_name => 'Randomized Controlled Trial');

-- comments
--call expected.insert_object_comment(sid => _sid, ref_type => '', ref_source => '', pmid => '', pmid_version => '1');

 
             */
        }
        
        if (sd_oid == "32740235")
        {
            /*
            
            -- article title
call expected.insert_object_pubmed_title(sid => _sid,	typeid => 19, 
	title => 'Surgical Outcome Results From SWOG S1505: A Randomized Clinical Trial of mFOLFIRINOX Versus Gemcitabine/Nab-paclitaxel for Perioperative Treatment of Resectable Pancreatic Ductal Adenocarcinoma.',
	isdefault => true);

-- journal details
call expected.insert_journal_details(sid =>_sid, eissn => '15281140', journal_title => 'Annals of surgery');

-- description (journal string)
call expected.insert_object_description(sid =>_sid, typeid => 18, description_text => 'Ann Surg. 2020 Sep 1. 272(3):481-486. doi:10.1097/SLA.0000000000004155.');

-- contributors
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Ahmad', given_name => 'Syed A', full_name => 'Syed A Ahmad', 
affiliation => 'University of Cincinnati, Cincinnati, Ohio.',
orgname => 'University of Cincinnati');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Duong', given_name => 'Mai', full_name => 'Mai Duong', 
affiliation => 'SWOG Statistical and Data Management Center, Seattle, Washington.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Sohal', given_name => 'Davendra P S', full_name => 'Davendra P S Sohal', 
affiliation => 'University of Cincinnati, Cincinnati, Ohio.',
orgname => 'University of Cincinnati');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Gandhi', given_name => 'Namita S', full_name => 'Namita S Gandhi', 
affiliation => 'Cleveland Clinic, Cleveland, Ohio.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Beg', given_name => 'Muhammad Shaalan', full_name => 'Muhammad Shaalan Beg', 
affiliation => 'UT Southwestern Medical Center, Dallas, Texas.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Wang-Gillam', given_name => 'Andrea', full_name => 'Andrea Wang-Gillam', 
affiliation => 'Washington University Siteman Cancer Center, St. Louis, Missouri.',
orgname => 'Washington University Siteman Cancer Center');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Wade', given_name => 'James L', full_name => 'James L Wade 3rd', 
affiliation => 'Heartland NCORP/Cancer Care Specialists of Illinois, Decatur, Illinois.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Chiorean', given_name => 'Elena Gabriela', full_name => 'Elena Gabriela Chiorean', 
affiliation => 'University of Washington, Fred Hutchinson Cancer Research Center, Seattle, Washington.',
orgname => 'University of Washington');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Guthrie', given_name => 'Katherine A', full_name => 'Katherine A Guthrie', 
affiliation => 'SWOG Statistical and Data Management Center, Seattle, Washington.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Lowy', given_name => 'Andrew M', full_name => 'Andrew M Lowy', 
affiliation => 'University of California, San Diego, La Jolla, California.',
orgname => 'University of California, San Diego');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Philip', given_name => 'Philip A', full_name => 'Philip A Philip', 
affiliation => 'Wayne State University/Karmanos Cancer Institute, Detroit, Michigan.',
orgname => 'Wayne State University/Karmanos Cancer Institute');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Hochster', given_name => 'Howard S', full_name => 'Howard S Hochster', 
affiliation => 'Rutgers Cancer Institute of New Jersey, New Brunswick, New Jersey.', 										  
orgname => 'Rutgers Cancer Institute of New Jersey');

-- topics
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'C520255', mvalue => '130-nm albumin-bound paclitaxel');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D000418', mvalue => 'Albumins');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D000970', mvalue => 'Antineoplastic Agents');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D007166', mvalue => 'Immunosuppressive Agents');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'C000627770', mvalue => 'folfirinox');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D000077150', mvalue => 'Oxaliplatin');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D003841', mvalue => 'Deoxycytidine');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D000077146', mvalue => 'Irinotecan');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'C056507', mvalue => 'gemcitabine');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D017239', mvalue => 'Paclitaxel');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D002955', mvalue => 'Leucovorin');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D005472', mvalue => 'Fluorouracil');

call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D000368', mvalue => 'Aged');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D000971', mvalue => 'Antineoplastic Combined Chemotherapy Protocols');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D021441', mvalue => 'Carcinoma, Pancreatic Ductal');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D003131', mvalue => 'Combined Modality Therapy');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D008875', mvalue => 'Middle Aged');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D005500', mvalue => 'Follow-Up Studies');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D009367', mvalue => 'Neoplasm Staging');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D010180', mvalue => 'Pancreatectomy');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D010190', mvalue => 'Pancreatic Neoplasms');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D019990', mvalue => 'Perioperative Care');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D011446', mvalue => 'Prospective Studies');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D016896', mvalue => 'Treatment Outcome');

-- db links
call expected.insert_object_db_link(sid => _sid, db_sequence => 1, db_name => 'ClinicalTrials.gov', id_in_db => 'NCT02562716');

-- main data object
-- if (PMC_present) access_type_id = 11
-- else  access_type_id = 15, access_details = 'Not in PMC - presumed behind pay wall, but to check';

call expected.insert_pubmed_details(sid => _sid, 
                  title => 'Ahmad S, Duong M, Sohal D et al. Surgical Outcome Results From SWOG S1505: A Randomized Clinical Trial of mFOLFIRINOX Versus Gemcitabine/Nab-paclitaxel for Perioperative Treatment of Resectable Pancreatic Ductal Adenocarcinoma. Ann Surg. 2020 Sep 1. 272(3):481-486. doi:10.1097/SLA.0000000000004155.', 
				  vers => '1', doid => '10.1097/SLA.0000000000004155', doidsid => 1,
				  pubyear => 2020, acctypeid => 11);
 

-- instances
-- for PMC:  new ObjectInstance(sdoid, 1, "Full resource", 100133, "National Library of Medicine", "https://www.ncbi.nlm.nih.gov/pmc/articles/" + other_id.ToString(), true, 36, "Web text with download"));	

call expected.insert_object_pubmed_instance(sid => _sid, insttypeid => 3, reporgid => 100133, reporgname => 'National Library of Medicine', 
	purl => 'https://www.ncbi.nlm.nih.gov/pubmed/' || _sid, accessible => true, restypeid => 40);
call expected.insert_object_pubmed_instance(sid => _sid, insttypeid => 1, reporgid => 100133, reporgname => 'National Library of Medicine', 
	purl => 'https://www.ncbi.nlm.nih.gov/pmc/articles/PMC7856053', accessible => true, restypeid => 36);
	
	
-- identifiers	
-- pii 34, Publisher article ID
-- 31, PMCID, 100133, "National Library of Medicine"));
-- 32, NIH Manuscript ID, other_id, 100134, "National Institutes of Health"));-- 33, NRCBL, other_id, 100447, "Georgetown University"));
-- 37, PMC Publisher ID-- 38, PM Publisher ID-- 35, Serial Item and Contribution Identifier 
-- 36, Medline UID, other_id, 100133, "National Library of Medicine
  
call expected.insert_object_identifier(sid => _sid, typeid => 16, idvalue => _sid, idorgid => 100133, idorgname => 'National Library of Medicine', iddate => '2020 Aug 3');
call expected.insert_object_identifier(sid => _sid, typeid => 34, idvalue => '00000658-202009000-00021');
call expected.insert_object_identifier(sid => _sid, typeid => 31, idvalue => 'PMC7856053', idorgid => 100133, idorgname => 'National Library of Medicine');
call expected.insert_object_identifier(sid => _sid, typeid => 32, idvalue => 'NIHMS1647338', idorgid => 100134, idorgname => 'National Institutes of Health');

-- dates
--12, pub_date--52, Pubmed citation created--53, Pubmed citation_revised--54, Pubmed citation completed
--55, Epublish--17, received--11, accepted
                               
-- 56, Ppublish-- 57, Revised-- 58, Ahead of print publication
-- 59, Retracted-- 60, Added to eCollection-- 61, Added to PMC
-- 62, Added to Pubmed-- 63, Added to Medline-- 65, Added to entrez
-- 64, PMC embargo release

call expected.insert_object_pubmed_date(sid => _sid, typeid => 12, datestring => '2020 Sep 1', syear => 2020, smonth => 9, sday => 1);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 54, datestring => '2021 Feb 15', syear => 2021, smonth => 2, sday => 15);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 53, datestring => '2021 Sep 19', syear => 2021, smonth => 9, sday => 19);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 62, datestring => '2020 Aug 3', syear => 2020, smonth => 8, sday => 3);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 63, datestring => '2021 Feb 16', syear => 2021, smonth => 2, sday => 16);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 65, datestring => '2020 Aug 3', syear => 2020, smonth => 8, sday => 3);

--pub types	
call expected.insert_object_pub_type(sid => _sid, type_name => 'Clinical Trial, Phase II');
call expected.insert_object_pub_type(sid => _sid, type_name => 'Journal Article');
call expected.insert_object_pub_type(sid => _sid, type_name => 'Randomized Controlled Trial');

-- comments
call expected.insert_object_comment(sid => _sid, ref_type => 'CommentIn', ref_source => 'Ann Surg. 2020 Sep 1;272(3):487', pmid => '32657915', pmid_version => '1');

 
            */           
        }

        if (sd_oid == "32739569")
        {
            /*
           
-- article title
call expected.insert_object_pubmed_title(sid => _sid,	typeid => 19, 
	title => 'Randomized Controlled Trial of Advance Notification Phone Calls vs Text Messages Prior to Mailed Fecal Test Outreach.',
	isdefault => true);

-- journal details
call expected.insert_journal_details(sid =>_sid, eissn => '15427714', journal_title => 'Clinical gastroenterology and hepatology : the official clinical practice journal of the American Gastroenterological Association');

-- description (journal string)
call expected.insert_object_description(sid =>_sid, typeid => 18, description_text => 'Clin Gastroenterol Hepatol. 2021 Nov. 19(11):2353-2360.e2. Epub 2020 Jul 30. pii:S1542-3565(20)31063-6. doi:10.1016/j.cgh.2020.07.053.');

-- contributors
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Coronado', given_name => 'Gloria D', full_name => 'Gloria D Coronado', 
affiliation => 'Center for Health Research, Kaiser Permanente Northwest, Portland, Oregon. Electronic address: gloria.d.coronado@kpchr.org.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Nyongesa', given_name => 'Denis B', full_name => 'Denis B Nyongesa', 
affiliation => 'Center for Health Research, Kaiser Permanente Northwest, Portland, Oregon.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Petrik', given_name => 'Amanda F', full_name => 'Amanda F Petrik', 
affiliation => 'Center for Health Research, Kaiser Permanente Northwest, Portland, Oregon.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Thompson', given_name => 'Jamie H', full_name => 'Jamie H Thompson', 
affiliation => 'Center for Health Research, Kaiser Permanente Northwest, Portland, Oregon.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Escaron', given_name => 'Anne L', full_name => 'Anne L Escaron', 
affiliation => 'AltaMed Health Services, Los Angeles, California.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Younger', given_name => 'Brittany', full_name => 'Brittany Younger', 
affiliation => 'AltaMed Health Services, Los Angeles, California.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Harbison', given_name => 'Shelby', full_name => 'Shelby Harbison', 
affiliation => 'AltaMed Health Services, Los Angeles, California.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Leo', given_name => 'Michael C', full_name => 'Michael C Leo', 
affiliation => 'Center for Health Research, Kaiser Permanente Northwest, Portland, Oregon.');

-- topics
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D000368', mvalue => 'Aged');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D055088', mvalue => 'Early Detection of Cancer');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D006801', mvalue => 'Humans');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D008875', mvalue => 'Middle Aged');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D009780', mvalue => 'Occult Blood');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D011177', mvalue => 'Postal Service');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D011446', mvalue => 'Prospective Studies');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D060145', mvalue => 'Text Messaging');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D015179', mvalue => 'Colorectal Neoplasms');

call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'Fecal Testing');
call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'Colon Cancer');
call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'Prevention');
call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'Adherence');

-- db links
call expected.insert_object_db_link(sid => _sid, db_sequence => 1, db_name => 'ClinicalTrials.gov', id_in_db => 'NCT03167125');

-- main data object
-- if (PMC_present) access_type_id = 11
-- else  access_type_id = 15, access_details = 'Not in PMC - presumed behind pay wall, but to check';

call expected.insert_pubmed_details(sid => _sid, 
                  title => 'Coronado G, Nyongesa D, Petrik A et al. Randomized Controlled Trial of Advance Notification Phone Calls vs Text Messages Prior to Mailed Fecal Test Outreach. Clin Gastroenterol Hepatol. 2021 Nov. 19(11):2353-2360.e2. Epub 2020 Jul 30. pii:S1542-3565(20)31063-6. doi:10.1016/j.cgh.2020.07.053.', 
				  vers => '1', doid => '10.1016/j.cgh.2020.07.053', doidsid => 1,
				  pubyear => 2021, acctypeid => 15, accdetails => 'Not in PMC - presumed behind pay wall, but to check');

-- instances
-- for PMC:  new ObjectInstance(sdoid, 1, "Full resource", 100133, "National Library of Medicine", "https://www.ncbi.nlm.nih.gov/pmc/articles/" + other_id.ToString(), true, 36, "Web text with download"));	

call expected.insert_object_pubmed_instance(sid => _sid, insttypeid => 3, reporgid => 100133, reporgname => 'National Library of Medicine', 
	purl => 'https://www.ncbi.nlm.nih.gov/pubmed/' || _sid, accessible => true, restypeid => 40);
	

	
-- identifiers	
-- pii 34, Publisher article ID
-- 31, PMCID, 100133, "National Library of Medicine"));
-- 32, NIH Manuscript ID, other_id, 100134, "National Institutes of Health"));-- 33, NRCBL, other_id, 100447, "Georgetown University"));
-- 37, PMC Publisher ID-- 38, PM Publisher ID-- 35, Serial Item and Contribution Identifier 
-- 36, Medline UID, other_id, 100133, "National Library of Medicine
  
call expected.insert_object_identifier(sid => _sid, typeid => 16, idvalue => _sid, idorgid => 100133, idorgname => 'National Library of Medicine', iddate => '2020 Aug 3');
call expected.insert_object_identifier(sid => _sid, typeid => 34, idvalue => 'S1542-3565(20)31063-6', iddate => '2020 Jul 27');

-- dates
--12, pub_date--52, Pubmed citation created--53, Pubmed citation_revised--54, Pubmed citation completed
--55, Epublish--17, received--11, accepted
                               
-- 56, Ppublish-- 57, Revised-- 58, Ahead of print publication
-- 59, Retracted-- 60, Added to eCollection-- 61, Added to PMC
-- 62, Added to Pubmed-- 63, Added to Medline-- 65, Added to entrez
-- 64, PMC embargo release

call expected.insert_object_pubmed_date(sid => _sid, typeid => 12, datestring => '2021 Nov', syear => 2021, smonth => 11);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 53, datestring => '2021 Nov 10', syear => 2021, smonth => 11, sday => 10);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 54, datestring => '2021 Nov 10', syear => 2021, smonth => 11, sday => 10);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 17, datestring => '2020 Jan 6', syear => 2020, smonth => 1, sday => 6);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 55, datestring => '2020 Jul 30', syear => 2020, smonth => 7, sday => 30);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 57, datestring => '2020 Jul 21', syear => 2020, smonth => 7, sday => 21);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 11, datestring => '2020 Jul 27', syear => 2020, smonth => 7, sday => 27);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 62, datestring => '2020 Aug 3', syear => 2020, smonth => 8, sday => 3);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 63, datestring => '2021 Nov 11', syear => 2021, smonth => 11, sday => 11);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 65, datestring => '2020 Aug 3', syear => 2020, smonth => 8, sday => 3);

--pub types	
call expected.insert_object_pub_type(sid => _sid, type_name => 'Journal Article');
call expected.insert_object_pub_type(sid => _sid, type_name => 'Randomized Controlled Trial');

-- comments
--call expected.insert_object_comment(sid => _sid, ref_type => '', ref_source => '', pmid => '', pmid_version => '1');

            */           
        }
        
        if (sd_oid == "16287956")
        {
            /*
           
-- article title
call expected.insert_object_pubmed_title(sid => _sid,	typeid => 19, 
	title => 'Effects of protein, monounsaturated fat, and carbohydrate intake on blood pressure and serum lipids: results of the OmniHeart randomized trial.',
	isdefault => true);

-- journal details
call expected.insert_journal_details(sid =>_sid, eissn => '15383598', journal_title => 'JAMA');

-- description (journal string)
call expected.insert_object_description(sid =>_sid, typeid => 18, description_text => 'JAMA. 2005 Nov 16. 294(19):2455-64.');

-- contributors
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Appel', given_name => 'Lawrence J', full_name => 'Lawrence J Appel', 
affiliation => 'Welch Center for Prevention, Epidemiology and Clinical Research, Division of General Internal Medicine, Johns Hopkins University School of Medicine, Baltimore, Md 21205-2223, USA. lappel@jhmi.edu',
orgname => 'Johns Hopkins University School of Medicine');

call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Sacks', given_name => 'Frank M', full_name => 'Frank M Sacks');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Carey', given_name => 'Vincent J', full_name => 'Vincent J Carey');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Obarzanek', given_name => 'Eva', full_name => 'Eva Obarzanek');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Swain', given_name => 'Janis F', full_name => 'Janis F Swain');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Miller', given_name => 'Edgar R', full_name => 'Edgar R Miller 3rd');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Conlin', given_name => 'Paul R', full_name => 'Paul R Conlin');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Erlinger', given_name => 'Thomas P', full_name => 'Thomas P Erlinger');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Rosner', given_name => 'Bernard A', full_name => 'Bernard A Rosner');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Laranjo', given_name => 'Nancy M', full_name => 'Nancy M Laranjo');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Charleston', given_name => 'Jeanne', full_name => 'Jeanne Charleston');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'McCarron', given_name => 'Phyllis', full_name => 'Phyllis McCarron');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Bishop', given_name => 'Louise M', full_name => 'Louise M Bishop');
call expected.insert_object_org_contributor(sid =>_sid, typeid => 11, orgname => 'OmniHeart Collaborative Research Group');

--call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => '', given_name => '', full_name => '');

-- topics
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D008078', mvalue => 'Cholesterol, LDL');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D004040', mvalue => 'Dietary Carbohydrates');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D004042', mvalue => 'Dietary Fats, Unsaturated');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D004044', mvalue => 'Dietary Proteins');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D005229', mvalue => 'Fatty Acids, Monounsaturated');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D008055', mvalue => 'Lipids');

call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D000328', mvalue => 'Adult');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D001794', mvalue => 'Blood Pressure');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D002318', mvalue => 'Cardiovascular Diseases');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D018592', mvalue => 'Cross-Over Studies');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D004036', mvalue => 'Diet, Atherogenic');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D006973', mvalue => 'Hypertension');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D008875', mvalue => 'Middle Aged');
--call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => '', mvalue => '');

--call expected.insert_object_nonmesh_topic(sid => _sid, typeid => , orivalue => '');

-- db links
call expected.insert_object_db_link(sid => _sid, db_sequence => 1, db_name => 'ClinicalTrials.gov', id_in_db => 'NCT00051350');

-- main data object
-- if (PMC_present) access_type_id = 11
-- else  access_type_id = 15, access_details = 'Not in PMC - presumed behind pay wall, but to check';

call expected.insert_pubmed_details(sid => _sid, 
                  title => 'Appel L, Sacks F, Carey V et al. Effects of protein, monounsaturated fat, and carbohydrate intake on blood pressure and serum lipids: results of the OmniHeart randomized trial. JAMA. 2005 Nov 16. 294(19):2455-64.', 
				  vers => '1', doid => '10.1001/jama.294.19.2455', doidsid => 1,
				  pubyear => 2005, acctypeid => 15, accdetails => 'Not in PMC - presumed behind pay wall, but to check');

-- instances
	
	
call expected.insert_object_pubmed_instance(sid => _sid, insttypeid => 3, reporgid => 100133, reporgname => 'National Library of Medicine', 
	purl => 'https://www.ncbi.nlm.nih.gov/pubmed/' || _sid, accessible => true, restypeid => 40);
	

	
-- identifiers	
-- pii 34, Publisher article ID
-- 31, PMCID, 100133, "National Library of Medicine"));
-- new ObjectInstance(sdoid, 1, "Full resource", 100133, "National Library of Medicine", "https://www.ncbi.nlm.nih.gov/pmc/articles/" + other_id.ToString(), true, 36, "Web text with download"));
-- 32, NIH Manuscript ID, other_id, 100134, "National Institutes of Health"));
-- 33, NRCBL, other_id, 100447, "Georgetown University"));
-- 37, PMC Publisher ID
-- 38, PM Publisher ID
-- 35, Serial Item and Contribution Identifier 
-- 36, Medline UID, other_id, 100133, "National Library of Medicine
  
call expected.insert_object_identifier(sid => _sid, typeid => 16, idvalue => _sid, idorgid => 100133, idorgname => 'National Library of Medicine', iddate => '2005 Nov 17');
call expected.insert_object_identifier(sid => _sid, typeid => 34, idvalue => '294/19/2455');

-- dates
--12, pub_date
--52, Pubmed citation created
--53, Pubmed citation_revised
--54, Pubmed citation completed
--55, Epublish
--17, received
--11, accepted
                               
-- 56, Ppublish
-- 57, Revised
-- 58, Ahead of print publication
-- 59, Retracted
-- 60, Added to eCollection
-- 61, Added to PMC
-- 62, Added to Pubmed
-- 63, Added to Medline
-- 65, Added to entrez
-- 64, PMC embargo release

call expected.insert_object_pubmed_date(sid => _sid, typeid => 12, datestring => '2005 Nov 16', syear => 2005, smonth => 11, sday => 16);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 54, datestring => '2005 Nov 22', syear => 2005, smonth => 11, sday => 22);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 53, datestring => '2016 Oct 17', syear => 2016, smonth => 10, sday => 17);

call expected.insert_object_pubmed_date(sid => _sid, typeid => 62, datestring => '2005 Nov 17', syear => 2005, smonth => 11, sday => 17);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 63, datestring => '2005 Dec 13', syear => 2005, smonth => 12, sday => 13);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 65, datestring => '2005 Nov 17', syear => 2005, smonth => 11, sday => 17);

--pub types	
call expected.insert_object_pub_type(sid => _sid, type_name => 'Comparative Study');
call expected.insert_object_pub_type(sid => _sid, type_name => 'Journal Article');
call expected.insert_object_pub_type(sid => _sid, type_name => 'Multicenter Study');
call expected.insert_object_pub_type(sid => _sid, type_name => 'Randomized Controlled Trial');

-- comments
call expected.insert_object_comment(sid => _sid, ref_type => 'CommentIn', ref_source => 'JAMA. 2005 Nov 16;294(19):2497-8', pmid => '16287963', pmid_version => '1');

             */           
        }
        
     if (sd_oid == "32739049")
     {
            /*
          
-- article title
call expected.insert_object_pubmed_title(sid => _sid,	typeid => 19, 
	title => 'Safety, Pharmacokinetics, and Pharmacodynamics of the TLR4 Agonist GSK1795091 in Healthy Individuals: Results from a Randomized, Double-blind, Placebo-controlled, Ascending Dose Study.',
	isdefault => true);

-- journal details
call expected.insert_journal_details(sid =>_sid, eissn => '1879114X', journal_title => 'Clinical therapeutics');

-- description (journal string)
call expected.insert_object_description(sid =>_sid, typeid => 18, description_text => 'Clin Ther. 2020 Aug. 42(8):1519-1534.e33. Epub 2020 Jul 30. pii:S0149-2918(20)30286-1. doi:10.1016/j.clinthera.2020.05.022.');

-- contributors
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Hug', given_name => 'Bruce A', full_name => 'Bruce A Hug', 
affiliation => 'R&D Pharmaceuticals, GSK, Upper Providence, PA, USA. Electronic address: bruce.a.hug@gsk.com.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Matheny', given_name => 'Christopher J', full_name => 'Christopher J Matheny', 
affiliation => 'R&D Pharmaceuticals, GSK, Upper Providence, PA, USA.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Burns', given_name => 'Olivia', full_name => 'Olivia Burns', 
affiliation => 'Global Clinical Sciences & Delivery, GSK, Abbotsford, Victoria, Australia.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Struemper', given_name => 'Herbert', full_name => 'Herbert Struemper', 
affiliation => 'Clinical Pharmacology Modeling & Simulation, GSK, Research Triangle Park, NC, USA.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Wang', given_name => 'Xiaowei', full_name => 'Xiaowei Wang', 
affiliation => 'R&D Pharmaceuticals, GSK, Upper Providence, PA, USA.');
call expected.insert_object_indiv_contributor(sid =>_sid, typeid => 11, family_name => 'Washburn', given_name => 'Michael L', full_name => 'Michael L Washburn', 
affiliation => 'R&D Pharmaceuticals, GSK, Upper Providence, PA, USA.');

-- topics
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D000970', mvalue => 'Antineoplastic Agents');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D016207', mvalue => 'Cytokines');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D006017', mvalue => 'Glycolipids');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'C000712933', mvalue => 'TLR4 agonist GSK1795091');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'C495345', mvalue => 'TLR4 protein, human');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D051197', mvalue => 'Toll-Like Receptor 4');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D001219', mvalue => 'Aspartate Aminotransferases');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 12, mcode => 'D000410', mvalue => 'Alanine Transaminase');

call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D000328', mvalue => 'Adult');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D019540', mvalue => 'Area Under Curve');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D001416', mvalue => 'Back Pain');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D001831', mvalue => 'Body Temperature');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D004305', mvalue => 'Dose-Response Relationship, Drug');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D004311', mvalue => 'Double-Blind Method');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D006261', mvalue => 'Headache');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D007167', mvalue => 'Immunotherapy');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D007262', mvalue => 'Infusions, Intravenous');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D007958', mvalue => 'Leukocyte Count');
call expected.insert_object_mesh_topic(sid => _sid, typeid => 0, mcode => 'D008875', mvalue => 'Middle Aged');

call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'GSK1795091');
call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'Toll-like receptor');
call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'cytokine');
call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'dose-escalation');
call expected.insert_object_nonmesh_topic(sid => _sid, typeid => 11, ctid => 11, orivalue => 'pharmacokinetics');

-- db links
call expected.insert_object_db_link(sid => _sid, db_sequence => 1, db_name => 'ClinicalTrials.gov', id_in_db => 'NCT02798978');

-- main data object
-- if (PMC_present) access_type_id = 11
-- else  access_type_id = 15, access_details = 'Not in PMC - presumed behind pay wall, but to check';

call expected.insert_pubmed_details(sid => _sid, 
                  title => 'Hug B, Matheny C, Burns O et al. Safety, Pharmacokinetics, and Pharmacodynamics of the TLR4 Agonist GSK1795091 in Healthy Individuals: Results from a Randomized, Double-blind, Placebo-controlled, Ascending Dose Study. Clin Ther. 2020 Aug. 42(8):1519-1534.e33. Epub 2020 Jul 30. pii:S0149-2918(20)30286-1. doi:10.1016/j.clinthera.2020.05.022.', 
				  vers => '1', doid => '10.1016/j.clinthera.2020.05.022', doidsid => 1,
				  pubyear => 2020, acctypeid => 15, accdetails => 'Not in PMC - presumed behind pay wall, but to check');

-- instances
-- for PMC:  new ObjectInstance(sdoid, 1, "Full resource", 100133, "National Library of Medicine", "https://www.ncbi.nlm.nih.gov/pmc/articles/" + other_id.ToString(), true, 36, "Web text with download"));	

call expected.insert_object_pubmed_instance(sid => _sid, insttypeid => 3, reporgid => 100133, reporgname => 'National Library of Medicine', 
	purl => 'https://www.ncbi.nlm.nih.gov/pubmed/' || _sid, accessible => true, restypeid => 40);

-- identifiers	
-- pii 34, Publisher article ID
-- 31, PMCID, 100133, "National Library of Medicine"));
-- 32, NIH Manuscript ID, other_id, 100134, "National Institutes of Health"));-- 33, NRCBL, other_id, 100447, "Georgetown University"));
-- 37, PMC Publisher ID-- 38, PM Publisher ID-- 35, Serial Item and Contribution Identifier 
-- 36, Medline UID, other_id, 100133, "National Library of Medicine
  
call expected.insert_object_identifier(sid => _sid, typeid => 16, idvalue => _sid, idorgid => 100133, idorgname => 'National Library of Medicine', iddate=> '2020 Aug 3');
call expected.insert_object_identifier(sid => _sid, typeid => 34, idvalue => 'S0149-2918(20)30286-1', iddate=> '2020 May 22');

-- dates
--12, pub_date--52, Pubmed citation created--53, Pubmed citation_revised--54, Pubmed citation completed
--55, Epublish--17, received--11, accepted
                               
-- 56, Ppublish-- 57, Revised-- 58, Ahead of print publication
-- 59, Retracted-- 60, Added to eCollection-- 61, Added to PMC
-- 62, Added to Pubmed-- 63, Added to Medline-- 65, Added to entrez
-- 64, PMC embargo release

call expected.insert_object_pubmed_date(sid => _sid, typeid => 12, datestring => '2020 Aug', syear => 2020, smonth => 8);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 54, datestring => '2021 Jan 27', syear => 2021, smonth => 1, sday => 27);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 53, datestring => '2021 Feb 17', syear => 2021, smonth => 2, sday => 17);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 55, datestring => '2020 Jul 30', syear => 2020, smonth => 7, sday => 30);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 17, datestring => '2019 Nov 15', syear => 2019, smonth => 11, sday => 15);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 57, datestring => '2020 Apr 30', syear => 2020, smonth => 4, sday => 30);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 11, datestring => '2020 May 22', syear => 2020, smonth => 5, sday => 22);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 62, datestring => '2020 Aug 3', syear => 2020, smonth => 8, sday => 3);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 63, datestring => '2021 Jan 28', syear => 2021, smonth => 1, sday => 28);
call expected.insert_object_pubmed_date(sid => _sid, typeid => 65, datestring => '2020 Aug 3', syear => 2020, smonth => 8, sday => 3);

--pub types	
call expected.insert_object_pub_type(sid => _sid, type_name => 'Clinical Trial, Phase I');
call expected.insert_object_pub_type(sid => _sid, type_name => 'Journal Article');
call expected.insert_object_pub_type(sid => _sid, type_name => 'Randomized Controlled Trial');

-- comments
--call expected.insert_object_comment(sid => _sid, ref_type => '', ref_source => '', pmid => '', pmid_version => '1');
           */
        }

        return null;
    }
}