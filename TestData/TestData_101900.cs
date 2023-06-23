namespace MDR_Tester;

public class TestData_101900 : TestData_Base
{
    public override FullStudy? FetchStudyData(string sd_sid)
    {
        if (sd_sid == "")
        {
            //return new FullStudy();
        }

        return null;
    }
}