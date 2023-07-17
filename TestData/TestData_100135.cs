namespace MDR_Tester;

public class TestData_100135 : TestData_Base
{
    public override FullDataObject? FetchObjectData(string sd_oid)
    {
        if (sd_oid == "27056882")
        {
	        FullDataObject fdb = CreateEmptyFullDataObject();

	        const string art_title =
		        "Prognostic Relevance of Left Atrial Dysfunction in Heart Failure With Preserved Ejection Fraction.";
	        const string desc = "Circ Heart Fail. 2016 Apr. 9(4):e002763. doi:10.1161/CIRCHEARTFAILURE.115.002763. pii:e002763.";
	        const string citation = "Santos A, Roca G, Claggett B et al. Prognostic Relevance of Left Atrial Dysfunction in Heart Failure With Preserved Ejection Fraction. Circ Heart Fail. 2016 Apr. 9(4):e002763. doi:10.1161/CIRCHEARTFAILURE.115.002763. pii:e002763.";

	        fdb.journal_details = new JournalDetails(sd_oid, "Circulation. Heart failure", null, "19413297", 
		        "101479941", "Circ Heart Fail", 101427, "Wolters Kluwer Health");

	        fdb.data_object = new DataObject(sd_oid, null, art_title, "", citation,
		        "10.1161/CIRCHEARTFAILURE.115.002763", 1, 2016, 23, 12, 101427, "Wolters Kluwer Health", "https://ror.org/04phyf746",
		        "en", 11, null, null, 0, false, false);
	        
	        fdb.object_descriptions!.Add(new ObjectDescription(sd_oid, 18, null, desc, "en"));
	        
	        fdb.object_titles!.Add(new ObjectTitle(sd_oid, art_title, 19, "en", 11, true, null));
	        
	        fdb.object_instances!.Add(new ObjectInstance(sd_oid, 100133, "National Library of Medicine", 
		        "https://www.ncbi.nlm.nih.gov/pubmed/" + sd_oid, true, 40, null, null, null));
	        fdb.object_instances!.Add(new ObjectInstance(sd_oid, 100133, "National Library of Medicine", 
		        "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC4826720", true, 36, null, null, null));
	        
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, sd_oid, 16, 100133, "National Library of Medicine", "https://ror.org/0060t0j89", "2016 Apr 9"));
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, "CIRCHEARTFAILURE.115.002763", 34, 101427, "Wolters Kluwer Health", "https://ror.org/04phyf746", "2016 Mar 4"));
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, "e002763", 34, 101427, "Wolters Kluwer Health", "https://ror.org/04phyf746", "2016 Mar 4"));
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, "PMC4826720", 31, 100133, "National Library of Medicine", "https://ror.org/0060t0j89", null));
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, "NIHMS768831", 32, 100134, "National Institutes of Health", "https://ror.org/01cwqze88", null));
	        
	        fdb.object_people!.Add(new ObjectPerson(sd_oid, 11, "Angela B S", "Santos", "Angela B S Santos", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Gabriela Querejeta", "Roca", "Gabriela Querejeta Roca", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Brian", "Claggett", "Brian Claggett", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Nancy K", "Sweitzer", "Nancy K Sweitzer", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Sanjiv J", "Shah", "Sanjiv J Shah", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Inder S", "Anand", "Inder S Anand", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "James C", "Fang", "James C Fang", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Michael R", "Zile", "Michael R Zile", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Bertram", "Pitt", "Bertram Pitt", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Scott D", "Solomon", "Scott D Solomon", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Amil M", "Shah", "Amil M Shah", null, null, null, null, null));
	        
	        fdb.object_topics!.Add(new ObjectTopic(sd_oid, 11, "atrial strain", null, null, null, null));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 11, "diastolic heart failure", null, null, null, null));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 11, "echocardiography", null, null, null, null));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 11, "prognosis", null, null, null, null));
	        
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Mineralocorticoid Receptor Antagonists", 14, 
		        "D000451", "D000451", "Mineralocorticoid Receptor Antagonists"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Aged", 14, "D000368", "D000368", "Aged"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Aged, 80 and over", 14, "D000369", "D000369", "Aged, 80 and over"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Atrial Function, Left", 14, "D016279", "D016279", "Atrial Function, Left"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Diastole", 14, "D003971", "D003971", "Diastole"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Echocardiography, Doppler", 14, "D015150", "D015150", "Echocardiography, Doppler"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Heart Atria", 14, "D006325", "D006325", "Heart Atria"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Heart Failure", 14, "D006333", "D006333", "Heart Failure"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Hospitalization", 14, "D006760", "D006760", "Hospitalization"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Middle Aged", 14, "D008875", "D008875", "Middle Aged"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Risk Factors", 14, "D012307", "D012307", "Risk Factors"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Stress, Mechanical", 14, "D013314", "D013314", "Stress, Mechanical"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Stroke Volume", 14, "D013318", "D013318", "Stroke Volume"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Systole", 14, "D013599", "D013599", "Systole"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Time Factors", 14, "D013997", "D013997", "Time Factors"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Treatment Outcome", 14, "D016896", "D016896", "Treatment Outcome"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Ventricular Dysfunction, Left", 14, "D018487", "D018487", "Ventricular Dysfunction, Left"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Ventricular Function, Left", 14, "D016277", "D016277", "Ventricular Function, Left"));
   
	        fdb.object_db_ids!.Add(new ObjectDBLink(sd_oid, 1, "ClinicalTrials.gov", "NCT00094302"));

            fdb.object_dates!.Add(new ObjectDate(sd_oid, 12, "2016 Apr", 2016, 4, null));
            fdb.object_dates.Add(new ObjectDate(sd_oid, 54, "2016 Aug 1", 2016, 8, 1));
            fdb.object_dates.Add(new ObjectDate(sd_oid, 53, "2020 Dec 16", 2020, 12, 16));
            fdb.object_dates.Add(new ObjectDate(sd_oid, 17, "2015 Oct 20", 2015, 10, 20));
            fdb.object_dates.Add(new ObjectDate(sd_oid, 11, "2016 Mar 4", 2016, 3, 4));
            fdb.object_dates.Add(new ObjectDate(sd_oid, 65, "2016 Apr 9", 2016, 4, 9));
            fdb.object_dates.Add(new ObjectDate(sd_oid, 62, "2016 Apr 9", 2016, 4, 9));
            fdb.object_dates.Add(new ObjectDate(sd_oid, 63, "2016 Aug 2", 2016, 8, 2));

            fdb.object_pubtypes!.Add(new ObjectPublicationType(sd_oid, "Journal Article"));
            fdb.object_pubtypes.Add(new ObjectPublicationType(sd_oid, "Multicenter Study"));
            fdb.object_pubtypes.Add(new ObjectPublicationType(sd_oid, "Randomized Controlled Trial"));
            
            fdb.object_comments!.Add(new ObjectComment(sd_oid, null, "", "", "1", null));

            return fdb;
        }
        
        if (sd_oid == "32740235")
        {
	        FullDataObject fdb = CreateEmptyFullDataObject();
	        
	        const string art_title =
		        "Surgical Outcome Results From SWOG S1505: A Randomized Clinical Trial of mFOLFIRINOX Versus Gemcitabine/Nab-paclitaxel for Perioperative Treatment of Resectable Pancreatic Ductal Adenocarcinoma.";
	        const string desc = "Ann Surg. 2020 Sep 1. 272(3):481-486. doi:10.1097/SLA.0000000000004155.";
	        const string citation = "Ahmad S, Duong M, Sohal D et al. Surgical Outcome Results From SWOG S1505: A Randomized Clinical Trial of mFOLFIRINOX Versus Gemcitabine/Nab-paclitaxel for Perioperative Treatment of Resectable Pancreatic Ductal Adenocarcinoma. Ann Surg. 2020 Sep 1. 272(3):481-486. doi:10.1097/SLA.0000000000004155.";

	        fdb.journal_details = new JournalDetails(sd_oid, "Annals of surgery", null, "15281140",
		         "0372354", "Ann Surg", 101427, "Wolters Kluwer Health");

	        fdb.data_object = new DataObject(sd_oid, null, art_title, "1", citation,
		        "10.1097/SLA.0000000000004155", 1, 2020, 23, 12, 101427, "Wolters Kluwer Health", "https://ror.org/04phyf746",
		        "en", 11, null, null, 0, false, false);

	        fdb.object_descriptions!.Add(new ObjectDescription(sd_oid, 18, null, desc, "en"));
	        
	        fdb.object_titles!.Add(new ObjectTitle(sd_oid, art_title, 19, "en", 11, true, null));
	        
	        fdb.object_instances!.Add(new ObjectInstance(sd_oid, 100133, "National Library of Medicine", 
		        "https://www.ncbi.nlm.nih.gov/pubmed/" + sd_oid, true, 40, null, null, null));
	        fdb.object_instances.Add(new ObjectInstance(sd_oid, 100133, "National Library of Medicine", 
		        "https://www.ncbi.nlm.nih.gov/pmc/articles/PMC7856053", true, 36, null, null, null));
	        
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, sd_oid, 16, 100133, "National Library of Medicine", "https://ror.org/0060t0j89", "2020 Aug 3"));
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, "00000658-202009000-00021", 34, 101427, "Wolters Kluwer Health", "https://ror.org/04phyf746", null));
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, "PMC7856053", 31, 100133, "National Library of Medicine", "https://ror.org/0060t0j89", null));
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, "NIHMS1647338", 32, 100134, "National Institutes of Health", "https://ror.org/01cwqze88", null));
	        
	        fdb.object_people!.Add(new ObjectPerson(sd_oid, 11, "Syed A", "Ahmad", "Syed A Ahmad", null, "University of Cincinnati, Cincinnati, Ohio.", 100384, "University of Cincinnati", "https://ror.org/01e3m7079"));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Mai", "Duong", "Mai Duong", null, "SWOG Statistical and Data Management Center, Seattle, Washington.", null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Davendra P S", "Sohal", "Davendra P S Sohal", null, "University of Cincinnati, Cincinnati, Ohio.", 100384, "University of Cincinnati", "https://ror.org/01e3m7079"));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Namita S", "Gandhi", "Namita S Gandhi", null, "Cleveland Clinic, Cleveland, Ohio.", null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Muhammad Shaalan", "Beg", "Muhammad Shaalan Beg", null, "UT Southwestern Medical Center, Dallas, Texas.", null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Andrea", "Wang-Gillam", "Andrea Wang-Gillam", null, "Washington University Siteman Cancer Center, St. Louis, Missouri.", null, "Washington University Siteman Cancer Center", null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "James L", "Wade", "James L Wade 3rd", null, "Heartland NCORP/Cancer Care Specialists of Illinois, Decatur, Illinois.", null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Elena Gabriela", "Chiorean", "Elena Gabriela Chiorean", null, 
		        "University of Washington, Fred Hutchinson Cancer Research Center, Seattle, Washington.", 
		        100199, "University of Washington", "https://ror.org/00cvxb145"));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Katherine A", "Guthrie", "Katherine A Guthrie", null, "SWOG Statistical and Data Management Center, Seattle, Washington.", null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Andrew M", "Lowy", "Andrew M Lowy", null, 
		        "University of California, San Diego, La Jolla, California.", 
		        100238, "University of California, San Diego", "https://ror.org/0168r3w48"));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Philip A", "Philip", "Philip A Philip", null, 
		        "Wayne State University/Karmanos Cancer Institute, Detroit, Michigan.", 
		        null, "Wayne State University/Karmanos Cancer Institute", null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Howard S", "Hochster", "Howard S Hochster", null, 
		        "Rutgers Cancer Institute of New Jersey, New Brunswick, New Jersey.", 
		        null, "Rutgers Cancer Institute of New Jersey", null));
	        
	        
	        fdb.object_topics!.Add(new ObjectTopic(sd_oid, 0, "Aged", 14, "D000368", "D000368", "Aged"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Antineoplastic Combined Chemotherapy Protocols", 14, "D000971", "D000971", "Antineoplastic Combined Chemotherapy Protocols"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Carcinoma, Pancreatic Ductal", 14, "D021441", "D021441", "Carcinoma, Pancreatic Ductal"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Combined Modality Therapy", 14, "D003131", "D003131", "Combined Modality Therapy"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Middle Aged", 14, "D008875", "D008875", "Middle Aged"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Follow-Up Studies", 14, "D005500", "D005500", "Follow-Up Studies"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Neoplasm Staging", 14, "D009367", "D009367", "Neoplasm Staging"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Pancreatectomy", 14, "D010180", "D010180", "Pancreatectomy"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Pancreatic Neoplasms", 14, "D010190", "D010190", "Pancreatic Neoplasms"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Perioperative Care", 14, "D019990", "D019990", "Perioperative Care"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Prospective Studies", 14, "D011446", "D011446", "Prospective Studies"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Treatment Outcome", 14, "D016896", "D016896", "Treatment Outcome"));
	        
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "130-nm albumin-bound paclitaxel", 14, "C520255", "C520255", "130-nm albumin-bound paclitaxel"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Albumins", 14, "D000418", "D000418", "Albumins"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Antineoplastic Agents'", 14, "D000970", "D000970", "Antineoplastic Agents'"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Immunosuppressive Agents", 14, "D007166", "D007166", "Immunosuppressive Agents"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "folfirinox", 14, "C000627770", "C000627770", "folfirinox"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Oxaliplatin", 14, "D000077150", "D000077150", "Oxaliplatin"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Deoxycytidine", 14, "D003841", "D003841", "Deoxycytidine"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Irinotecan", 14, "D000077146", "D000077146", "Irinotecan"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "gemcitabine", 14, "C056507", "C056507", "gemcitabine"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Paclitaxel", 14, "D017239", "D017239", "Paclitaxel"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Leucovorin", 14, "D002955", "D002955", "Leucovorin"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Fluorouracil", 14, "D005472", "D005472", "Fluorouracil"));
	        
            fdb.object_db_ids!.Add(new ObjectDBLink(sd_oid, 1, "ClinicalTrials.gov", "NCT02562716"));

			fdb.object_dates!.Add(new ObjectDate(sd_oid, 12, "2020 Sep 1", 2020, 9, 1));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 54, "2021 Feb 15", 2021, 2, 15));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 53, "2021 Sep 19", 2021, 9, 19));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 62, "2020 Aug 3", 2020, 8, 3));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 63, "2021 Feb 16", 2021, 2, 16));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 65, "2020 Aug 3", 2020, 8, 3));

			fdb.object_pubtypes!.Add(new ObjectPublicationType(sd_oid, "Journal Article"));
			fdb.object_pubtypes.Add(new ObjectPublicationType(sd_oid, "Clinical Trial, Phase II"));
			fdb.object_pubtypes.Add(new ObjectPublicationType(sd_oid, "Randomized Controlled Trial"));
			            
			fdb.object_comments!.Add(new ObjectComment(sd_oid, "CommentIn", "Ann Surg. 2020 Sep 1;272(3):487", "32657915", "1", null));
			
            return fdb;
        }

        if (sd_oid == "32739569")
        {
	        FullDataObject fdb = CreateEmptyFullDataObject();
	        
	        const string art_title =
		        "Randomized Controlled Trial of Advance Notification Phone Calls vs Text Messages Prior to Mailed Fecal Test Outreach.";
	        const string desc = "Clin Gastroenterol Hepatol. 2021 Nov. 19(11):2353-2360.e2. Epub 2020 Jul 30. pii:S1542-3565(20)31063-6. doi:10.1016/j.cgh.2020.07.053.";
	        const string citation = "Coronado G, Nyongesa D, Petrik A et al. Randomized Controlled Trial of Advance Notification Phone Calls vs Text Messages Prior to Mailed Fecal Test Outreach. Clin Gastroenterol Hepatol. 2021 Nov. 19(11):2353-2360.e2. Epub 2020 Jul 30. pii:S1542-3565(20)31063-6. doi:10.1016/j.cgh.2020.07.053.";

	        fdb.journal_details = new JournalDetails(sd_oid, "Clinical gastroenterology and hepatology : the official clinical practice journal of the American Gastroenterological Association", null, "15427714", 
		         "101160775", "Clin Gastroenterol Hepatol", 101422, "Elsevier");

	        fdb.data_object = new DataObject(sd_oid, null, art_title, "1", citation,
		        "10.1016/j.cgh.2020.07.053", 1, 2021, 23, 12, 101422, "Elsevier", "https://ror.org/055j8ya05",
		        "en", 15, "Not in PMC - presumed behind pay wall, but to check", null, 0, false, false);
	        
	        fdb.object_descriptions!.Add(new ObjectDescription(sd_oid, 18, null, desc, "en"));
	        
	        fdb.object_titles!.Add(new ObjectTitle(sd_oid, art_title, 19, "en", 11, true, null));
	        
	        fdb.object_instances!.Add(new ObjectInstance(sd_oid, 100133, "National Library of Medicine", 
		        "https://www.ncbi.nlm.nih.gov/pubmed/" + sd_oid, true, 40, null, null, null));

	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, sd_oid, 16, 100133, "National Library of Medicine", "https://ror.org/0060t0j89", "2020 Aug 3"));
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, "S1542-3565(20)31063-6", 34, 101422, "Elsevier", "https://ror.org/055j8ya05", "2020 Jul 27"));

	        fdb.object_people!.Add(new ObjectPerson(sd_oid, 11, "Gloria D", "Coronado", "Gloria D Coronado", null, 
		        "Center for Health Research, Kaiser Permanente Northwest, Portland, Oregon. Electronic address: gloria.d.coronado@kpchr.org.", 
		        null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Denis B", "Nyongesa", "Denis B Nyongesa", null,
		        "Center for Health Research, Kaiser Permanente Northwest, Portland, Oregon.", null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Amanda F", "Petrik", "Amanda F Petrik", null,
		        "Center for Health Research, Kaiser Permanente Northwest, Portland, Oregon.", null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Jamie H", "Thompson", "Jamie H Thompson", null,
		        "Center for Health Research, Kaiser Permanente Northwest, Portland, Oregon.", null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Anne L", "Escaron", "Anne L Escaron", null,
		        "AltaMed Health Services, Los Angeles, California.", null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Brittany", "Younger", "Brittany Younger", null,
		        "AltaMed Health Services, Los Angeles, California.", null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Shelby", "Harbison", "Shelby Harbison", null,
		        "AltaMed Health Services, Los Angeles, California.", null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Michael C", "Leo", "Michael C Leo", null,
		        "Center for Health Research, Kaiser Permanente Northwest, Portland, Oregon.", null, null, null));
	        
	        fdb.object_topics!.Add(new ObjectTopic(sd_oid, 11, "Fecal Testing", null, null, null, null));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 11, "Colon Cancer", null, null, null, null));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 11, "Prevention", null, null, null, null));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 11, "Adherence", null, null, null, null));
	        
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Aged", 14, "D000368", "D000368", "Aged"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Early Detection of Cancer", 14, "D055088", "D055088", "Early Detection of Cancer"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Humans", 14, "D006801", "D006801", "Humans"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Middle Aged", 14, "D008875", "D008875", "Middle Aged"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Occult Blood", 14, "D009780", "D009780", "Occult Blood"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Postal Service", 14, "D011177", "D011177", "Postal Service"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Prospective Studies", 14, "D011446", "D011446", "Prospective Studies"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Text Messaging", 14, "D060145", "D060145", "Text Messaging"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Colorectal Neoplasms", 14, "D015179", "D015179", "Colorectal Neoplasms"));
	             
	        fdb.object_db_ids!.Add(new ObjectDBLink(sd_oid, 1, "ClinicalTrials.gov", "NCT03167125"));

			fdb.object_db_ids!.Add(new ObjectDBLink(sd_oid, 1, "ClinicalTrials.gov", "NCT00094302"));

			fdb.object_dates!.Add(new ObjectDate(sd_oid, 12, "2021 Nov", 2021, 11, null));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 53, "2021 Nov 10", 2021, 11, 10));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 54, "2021 Nov 10", 2021, 11, 10));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 17, "2020 Jan 6", 2020, 1, 6));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 55, "2020 Jul 30", 2020, 7, 30));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 57, "2020 Jul 21", 2020, 7, 21));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 11, "2020 Jul 27", 2020, 7, 27));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 62, "2020 Aug 3", 2020, 8, 3));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 63, "2021 Nov 11", 2021, 11, 11));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 65, "2020 Aug 3", 2020, 8, 3));

			fdb.object_pubtypes!.Add(new ObjectPublicationType(sd_oid, "Journal Article"));
			fdb.object_pubtypes.Add(new ObjectPublicationType(sd_oid, "Randomized Controlled Trial"));
			            
			fdb.object_comments!.Add(new ObjectComment(sd_oid, null, "", "", "1", null));

			return fdb;
                 
        }
        
        if (sd_oid == "16287956")
        {
	        FullDataObject fdb = CreateEmptyFullDataObject();
	        
	        const string art_title =
		        "Effects of protein, monounsaturated fat, and carbohydrate intake on blood pressure and serum lipids: results of the OmniHeart randomized trial.";
	        const string desc = "JAMA. 2005 Nov 16. 294(19):2455-64.";
	        const string citation = "Appel L, Sacks F, Carey V et al. Effects of protein, monounsaturated fat, and carbohydrate intake on blood pressure and serum lipids: results of the OmniHeart randomized trial. JAMA. 2005 Nov 16. 294(19):2455-64.";

	        fdb.journal_details = new JournalDetails(sd_oid, "JAMA", null, "15383598",
		         "7501160", "JAMA", 101431, "American Medical Association");

	        fdb.data_object = new DataObject(sd_oid, null, art_title, "1", citation,
		        "10.1001/jama.294.19.2455", 1, 2005, 23, 12, 101431, "American Medical Association", "https://ror.org/03p6gt485",
		        "en", 15, "Not in PMC - presumed behind pay wall, but to check", null, 0, false, false);
	        
	        fdb.object_descriptions!.Add(new ObjectDescription(sd_oid, 18, null, desc, "en"));
	        
	        fdb.object_titles!.Add(new ObjectTitle(sd_oid, art_title, 19, "en", 11, true, null));
	        
	        fdb.object_instances!.Add(new ObjectInstance(sd_oid, 100133, "National Library of Medicine", 
		        "https://www.ncbi.nlm.nih.gov/pubmed/" + sd_oid, true, 40, null, null, null));
	        
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, sd_oid, 16, 100133, "National Library of Medicine", "https://ror.org/0060t0j89", "2005 Nov 17"));
	        fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, "294/19/2455", 34,  101431, "American Medical Association", "https://ror.org/03p6gt485", null));
	        
	        fdb.object_people!.Add(new ObjectPerson(sd_oid, 11, "Lawrence J", "Appel", "Lawrence J Appel", null, 
		        "Welch Center for Prevention, Epidemiology and Clinical Research, Division of General Internal Medicine, Johns Hopkins University School of Medicine, Baltimore, Md 21205-2223, USA. lappel@jhmi.edu", 
		        null, "Johns Hopkins University School of Medicine", null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Frank M", "Sacks", "Frank M Sacks", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Vincent J", "Carey", "Vincent J Carey", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Eva", "Obarzanek", "Eva Obarzanek", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Janis F", "Swain", "Janis F Swain", null, null, null, null, null));
	        
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Edgar R", "Miller", "Edgar R Miller", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Paul R", "Conlin", "Paul R Conlin", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Thomas P", "Erlinger", "Thomas P Erlinger", null, null, null, null, null));
	        
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Bernard A", "Rosner", "Bernard A Rosner", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Nancy M", "Laranjo", "Nancy M Laranjo", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Jeanne", "Charleston", "Jeanne Charleston", null, null, null, null, null));
	        
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Phyllis", "McCarron", "Phyllis McCarron", null, null, null, null, null));
	        fdb.object_people.Add(new ObjectPerson(sd_oid, 11, "Louise M", "Bishop", "Louise M Bishop", null, null, null, null, null));
	        
	        fdb.object_organisations!.Add(new ObjectOrganisation(sd_oid, 11, null, "OmniHeart Collaborative Research Group", null));
	       
	        fdb.object_topics!.Add(new ObjectTopic(sd_oid, 0, "Adult", 14, "D000328", "D000328", "Adult"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Blood Pressure", 14, "D001794", "D001794", "Blood Pressure"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Cardiovascular Diseases", 14, "D002318", "D002318", "Cardiovascular Diseases"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Cross-Over Studies", 14, "D018592", "D018592", "Cross-Over Studies"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Diet, Atherogenic", 14, "D004036", "D004036", "Diet, Atherogenic"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Hypertension", 14, "D006973", "D006973", "Hypertension"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Middle Aged", 14, "D008875", "D008875", "Middle Aged"));
	        
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Cholesterol, LDL", 14, "D008078", "D008078", "Cholesterol, LDL"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Dietary Carbohydrates", 14, "D004040", "D004040", "Dietary Carbohydrates"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Dietary Fats, Unsaturated", 14, "D004042", "D004042", "Dietary Fats, Unsaturated"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Dietary Proteins", 14, "D004044", "D004044", "Dietary Proteins"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Fatty Acids, Monounsaturated", 14, "D005229", "D005229", "Fatty Acids, Monounsaturated"));
	        fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Lipids", 14, "D008055", "D008055", "Lipids"));

	        fdb.object_db_ids!.Add(new ObjectDBLink(sd_oid, 1, "ClinicalTrials.gov", "NCT00051350"));

			fdb.object_dates!.Add(new ObjectDate(sd_oid, 12, "2005 Nov 16", 2005, 11, 16));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 54, "2005 Nov 22", 2005, 11, 22));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 53, "2016 Oct 17", 2016, 10, 17));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 62, "2005 Nov 17", 2005, 11, 17));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 63, "2005 Dec 13", 2005, 12, 13));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 65, "2005 Nov 17", 2005, 11, 17));

			fdb.object_pubtypes!.Add(new ObjectPublicationType(sd_oid, "Journal Article"));
			fdb.object_pubtypes!.Add(new ObjectPublicationType(sd_oid, "Comparative Study"));
			fdb.object_pubtypes.Add(new ObjectPublicationType(sd_oid, "Multicenter Study"));
			fdb.object_pubtypes.Add(new ObjectPublicationType(sd_oid, "Randomized Controlled Trial"));
			            
			fdb.object_comments!.Add(new ObjectComment(sd_oid, "CommentIn", "JAMA. 2005 Nov 16;294(19):2497-8", "16287963", "1", null));

			return fdb;
	                
	    }
	        
	    if (sd_oid == "32739049")
	    {
		    FullDataObject fdb = CreateEmptyFullDataObject();
		        
		    const string art_title =
			     "Safety, Pharmacokinetics, and Pharmacodynamics of the TLR4 Agonist GSK1795091 in Healthy Individuals: Results from a Randomized, Double-blind, Placebo-controlled, Ascending Dose Study.";
		    const string desc = "Clin Ther. 2020 Aug. 42(8):1519-1534.e33. Epub 2020 Jul 30. pii:S0149-2918(20)30286-1. doi:10.1016/j.clinthera.2020.05.022.";
		    const string citation = "Hug B, Matheny C, Burns O et al. Safety, Pharmacokinetics, and Pharmacodynamics of the TLR4 Agonist GSK1795091 in Healthy Individuals: Results from a Randomized, Double-blind, Placebo-controlled, Ascending Dose Study. Clin Ther. 2020 Aug. 42(8):1519-1534.e33. Epub 2020 Jul 30. pii:S0149-2918(20)30286-1. doi:10.1016/j.clinthera.2020.05.022.";

		    fdb.journal_details = new JournalDetails(sd_oid, "Clinical therapeutics", null, "1879114X", 
			     "7706726", "Clin Ther", 101422, "Elsevier");

		    fdb.data_object = new DataObject(sd_oid, null, art_title, "1", citation,
			     "10.1016/j.clinthera.2020.05.022", 1, 2016, 23, 12, 101422, "Elsevier", "https://ror.org/055j8ya05",
			     "en", 15, "Not in PMC - presumed behind pay wall, but to check", null, 0, false, false);
		     
		    fdb.object_descriptions!.Add(new ObjectDescription(sd_oid, 18, null, desc, "en"));
		        
		    fdb.object_titles!.Add(new ObjectTitle(sd_oid, art_title, 19, "en", 11, true, null));
		     
		    fdb.object_instances!.Add(new ObjectInstance(sd_oid, 100133, "National Library of Medicine", 
			     "https://www.ncbi.nlm.nih.gov/pubmed/" + sd_oid, true, 40, null, null, null));

		    fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, sd_oid, 16, 100133, "National Library of Medicine", "https://ror.org/0060t0j89", "2020 Aug 3"));
		    fdb.object_identifiers!.Add(new ObjectIdentifier(sd_oid, "S0149-2918(20)30286-1", 34, 101422, "Elsevier", "https://ror.org/055j8ya05", "2020 May 22"));
		     
		    fdb.object_people!.Add(new ObjectPerson(sd_oid, 11, "Bruce A", "Hug", "Bruce A Hug", null, 
			    "R&D Pharmaceuticals, GSK, Upper Providence, PA, USA. Electronic address: bruce.a.hug@gsk.com.", null, null, null));
		    fdb.object_people!.Add(new ObjectPerson(sd_oid, 11, "Christopher J", "Matheny", "Christopher J Matheny", null, 
			    "R&D Pharmaceuticals, GSK, Upper Providence, PA, USA.", null, null, null));
		    fdb.object_people!.Add(new ObjectPerson(sd_oid, 11, "Olivia", "Burns", "Olivia Burns", null, 
			    "Global Clinical Sciences & Delivery, GSK, Abbotsford, Victoria, Australia.", null, null, null));
		    fdb.object_people!.Add(new ObjectPerson(sd_oid, 11, "Herbert", "Struemper", "Herbert Struemper", null, 
			    "Clinical Pharmacology Modeling & Simulation, GSK, Research Triangle Park, NC, USA..", null, null, null));
		    fdb.object_people!.Add(new ObjectPerson(sd_oid, 11, "Xiaowei", "Wang", "Xiaowei Wang", null, 
			    "R&D Pharmaceuticals, GSK, Upper Providence, PA, USA.", null, null, null));
		    fdb.object_people!.Add(new ObjectPerson(sd_oid, 11, "Michael L", "Washburn", "Michael L Washburn", null, 
			    "R&D Pharmaceuticals, GSK, Upper Providence, PA, USA.", null, null, null));
		    
		    fdb.object_topics!.Add(new ObjectTopic(sd_oid, 11, "GSK1795091", null, null, null, null));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 11, "Toll-like receptor", null, null, null, null));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 11, "cytokine", null, null, null, null));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 11, "dose-escalation", null, null, null, null));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 11, "pharmacokinetics", null, null, null, null));
		    
		    fdb.object_topics!.Add(new ObjectTopic(sd_oid, 0, "Adult", 14, "D000328", "D000328", "Adult"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Area Under Curve", 14, "D019540", "D019540", "Area Under Curve"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Back Pain", 14, "D001416", "D001416", "Back Pain"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Body Temperature", 14, "D001831", "D001831", "Body Temperature"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Dose-Response Relationship, Drug", 14, "D004305", "D004305", "Dose-Response Relationship, Drug"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Double-Blind Method", 14, "D004311", "D004311", "Double-Blind Method"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Headache", 14, "D006261", "D006261", "Headache"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Immunotherapy", 14, "D007167", "D007167", "Immunotherapy"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Infusions, Intravenous", 14, "D007262", "D007262", "Infusions, Intravenous"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Leukocyte Count", 14, "D007958", "D007958", "Leukocyte Count"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 0, "Middle Aged", 14, "D008875", "D008875", "Middle Aged"));
		    
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Antineoplastic Agents", 14, "D000970", "D000970", "Antineoplastic Agents"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Cytokines", 14, "D016207", "D016207", "Cytokines"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Glycolipids", 14, "D006017", "D006017", "Glycolipids"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "TLR4 agonist GSK1795091", 14, "C000712933", "C000712933", "TLR4 agonist GSK1795091"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "TLR4 protein, human", 14, "C495345", "C495345", "TLR4 protein, human"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Toll-Like Receptor 4", 14, "D051197", "D051197", "Toll-Like Receptor 4"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Aspartate Aminotransferases", 14, "D001219", "D001219", "Aspartate Aminotransferases"));
		    fdb.object_topics.Add(new ObjectTopic(sd_oid, 12, "Alanine Transaminase", 14, "D000410", "D000410", "Alanine Transaminase"));
		    
            fdb.object_db_ids!.Add(new ObjectDBLink(sd_oid, 1, "ClinicalTrials.gov", "NCT02798978"));
 
			fdb.object_dates!.Add(new ObjectDate(sd_oid, 12, "2020 Aug", 2020, 8, null));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 54, "2021 Jan 27", 2021, 1, 27));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 53, "2021 Feb 17", 2021, 2, 17));

			fdb.object_dates.Add(new ObjectDate(sd_oid, 55, "2020 Jul 30", 2020, 7, 30));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 17, "2019 Nov 15", 2019, 11, 15));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 57, "2020 Apr 30", 2020, 4, 30));

			fdb.object_dates.Add(new ObjectDate(sd_oid, 11, "2020 May 22", 2020, 5, 22));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 62, "2020 May 22", 2020, 5, 22));
			fdb.object_dates.Add(new ObjectDate(sd_oid, 63, "2021 Jan 28", 2021, 1, 28));

			fdb.object_dates.Add(new ObjectDate(sd_oid, 65, "2020 Aug 3", 2020, 8, 3));

			fdb.object_pubtypes!.Add(new ObjectPublicationType(sd_oid, "Journal Article"));
			fdb.object_pubtypes.Add(new ObjectPublicationType(sd_oid, "Clinical Trial, Phase I"));
			fdb.object_pubtypes.Add(new ObjectPublicationType(sd_oid, "Randomized Controlled Trial"));
			            
			fdb.object_comments!.Add(new ObjectComment(sd_oid, null, "", "", "1", null));

			return fdb;
        }

        return null;
    }
}