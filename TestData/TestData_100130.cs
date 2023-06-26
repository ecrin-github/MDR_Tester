using System.Text;

namespace MDR_Tester;

public class TestData_100130 : TestData_Base
{ 
	public override FullStudy? FetchStudyData(string sd_sid)
	{
		{
			if (sd_sid == "")
			{
				FullStudy fs = CreateEmptyFullStudy();

				// Study 

				return fs;

			}

			if (sd_sid == "")
			{
				FullStudy fs = CreateEmptyFullStudy();

				// Study 

				return fs;
			}

			return null;
		}
	}
}