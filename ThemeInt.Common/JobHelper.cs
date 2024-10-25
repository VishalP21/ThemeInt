using ThemeInt.BussinesEntity;
using ThemeInt.DataBase;

namespace ThemeInt.Common
{
	public static class JobHelper
	{
		public static JobMaster ToDataModel(this JobInformation jobInformation)
		{
			JobMaster master = new JobMaster();			
			master.JobTypeId = jobInformation.JobTypeId;
			master.JobTitle = jobInformation.JobTitle;
			master.JobDiscription= jobInformation.JobDiscription;
			master.JobId = jobInformation.JobId;	
			return master;
		 
		}


        public static JobInformation ToEditModel(this JobMaster jobMaster)
        {
            JobInformation jobInformation = new JobInformation();
            jobInformation.JobId = jobMaster.JobId;
            jobInformation.JobTitle = jobMaster.JobTitle;
            jobInformation.JobDiscription = jobMaster.JobDiscription;
            jobInformation.JobTypeId = jobMaster.JobTypeId;
            return jobInformation;
        }

        public static JobInformation ToViewModel(this JobMaster jobMaster)
		{
			JobInformation jobInformation = new JobInformation();
			jobInformation.JobId = jobMaster.JobId;
			jobInformation.JobTitle = jobMaster.JobTitle;
			jobInformation.JobDiscription = jobMaster.JobDiscription;
			jobInformation.JobTypeId = jobMaster.JobTypeId;
			return jobInformation;
		}

        public static List<JobInformation> ToViewModel(this List<JobMaster> jobMaster)
		{
			return jobMaster.Select(x=> x.ToViewModel()).ToList();	
		}
    }
}
