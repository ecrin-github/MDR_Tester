namespace MDR_Tester;

public class TestData_100135 : TestData_Base
{
    public override FullDataObject? FetchObjectData(string sd_oid)
    {
        if (sd_oid == "")
        {
            //return new FullDataObject();
        }

        return null;
    }
}