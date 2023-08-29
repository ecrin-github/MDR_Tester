namespace MDR_Tester;

public class TestData_Base 
{
    public virtual FullStudy? FetchStudyData(string sd_sid)
    {
        return new FullStudy();
    }
    
    public virtual FullAggStudy? FetchAggStudyData(int sid)
    {
        return new FullAggStudy();
    }
    
    public virtual FullDataObject? FetchObjectData(string sd_oid)
    {
        return new FullDataObject();
    }
    
    public virtual FullAggDataObject? FetchAggObjectData(int oid)
    {
        return new FullAggDataObject();
    }
    
    protected FullStudy CreateEmptyFullStudy()
    {
        // instantiate the object and set the 
        // multiple attributes to empty lists
        
        FullStudy fs = new()
        {
            identifiers = new List<StudyIdentifier>(),
            titles = new List<StudyTitle>(), 
            people = new List<StudyPerson>(),
            organisations = new List<StudyOrganisation>(),
            references = new List<StudyReference>(),
            topics = new List<StudyTopic>(),
            features = new List<StudyFeature>(),
            conditions = new List<StudyCondition>(),
            iec = new List<StudyIEC>(),
            relationships = new List<StudyRelationship>(),
            sites = new List<StudyLocation>(),
            countries = new List<StudyCountry>(),
            studylinks = new List<StudyLink>(),
            ipd_info = new List<AvailableIPD>(),
            data_objects = new List<StudyDataObject>()
        };
        return fs;
    }
    
    
    protected FullAggStudy CreateEmptyFullAggStudy()
    {
        // instantiate the object and set the 
        // multiple attributes to empty lists
        
        FullAggStudy fs = new()
        {
            identifiers = new List<AggStudyIdentifier>(),
            titles = new List<AggStudyTitle>(), 
            people = new List<AggStudyPerson>(),
            organisations = new List<AggStudyOrganisation>(),
            topics = new List<AggStudyTopic>(),
            features = new List<AggStudyFeature>(),
            conditions = new List<AggStudyCondition>(),
            iec = new List<AggStudyIEC>(),
            relationships = new List<AggStudyRelationship>(),
            sites = new List<AggStudyLocation>(),
            countries = new List<AggStudyCountry>(),
            data_objects = new List<AggStudyDataObject>()
        };
        return fs;
    }
    
    protected StudyDataObject CreateEmptyStudyDataObject()
    {
        // instantiate the object and set the 
        // multiple attributes to empty lists 

        StudyDataObject sdo = new()
        {
            object_instances = new List<ObjectInstance>(),
            object_titles = new List<ObjectTitle>(),
            object_dates = new List<ObjectDate>()
        };
        return sdo;
    }
    
    
    protected AggStudyDataObject CreateEmptyAggStudyDataObject()
    {
        // instantiate the object and set the 
        // multiple attributes to empty lists 

        AggStudyDataObject sdo = new()
        {
            object_instances = new List<AggObjectInstance>(),
            object_titles = new List<AggObjectTitle>(),
            object_dates = new List<AggObjectDate>()
        };
        return sdo;
    }
    
    
    protected FullDataObject CreateEmptyFullDataObject()
    {
        // instantiate the object and set the 
        // multiple attributes to empty lists 

        FullDataObject fdo = new()
        {
            object_instances = new List<ObjectInstance>(),
            object_titles = new List<ObjectTitle>(),
            object_dates = new List<ObjectDate>(),
            object_identifiers = new List<ObjectIdentifier>(),
            object_topics = new List<ObjectTopic>(),
            object_pubtypes = new List<ObjectPublicationType>(),
            object_descriptions = new List<ObjectDescription>(),
            object_organisations = new List<ObjectOrganisation>(),
            object_people = new List<ObjectPerson>(),
            object_comments = new List<ObjectComment>(),
            object_db_ids = new List<ObjectDBLink>()
        };
        return fdo;
    }
    
    
    protected FullAggDataObject CreateEmptyFullAggDataObject()
    {
        // instantiate the object and set the 
        // multiple attributes to empty lists 

        FullAggDataObject fdo = new()
        {
            object_instances = new List<AggObjectInstance>(),
            object_titles = new List<AggObjectTitle>(),
            object_dates = new List<AggObjectDate>(),
            object_identifiers = new List<AggObjectIdentifier>(),
            object_topics = new List<AggObjectTopic>(),
            object_descriptions = new List<AggObjectDescription>(),
            object_organisations = new List<AggObjectOrganisation>(),
            object_people = new List<AggObjectPerson>(),
        };
        return fdo;
    }

}