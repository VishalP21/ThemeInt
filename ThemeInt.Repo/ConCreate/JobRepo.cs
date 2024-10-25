using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeInt.DataBase;
using ThemeInt.Repo.Interface;

namespace ThemeInt.Repo.ConCreate
{
	public class JobRepo : IJobRepo
	{
		private readonly JobPortalEfContext jobPortalEfContext;

		public JobRepo(JobPortalEfContext jobPortalEf)
		{
			jobPortalEfContext = jobPortalEf;
		}
		   
		public bool addjob(JobMaster job)
		{
			jobPortalEfContext.JobMasters.Add(job);
			return jobPortalEfContext.SaveChanges()>0?true:false;
		}

		public JobMaster GetJob(int jobid)
		{
			return jobPortalEfContext.JobMasters.Where(x=>x.JobId == jobid).FirstOrDefault();

		}

		public List<JobMaster> GetJobs()
		{
			return jobPortalEfContext.JobMasters.ToList();
		}

		public bool removejob(int jobid)
		{
			var a = jobPortalEfContext.JobMasters.Where(x => x.JobId == jobid).FirstOrDefault();
			jobPortalEfContext.JobMasters.Remove(a);	
			return jobPortalEfContext.SaveChanges() >0?true:false;
		}

        public bool updatejob(JobMaster jobMaster)
        {
            var a = jobPortalEfContext.JobMasters.Where(x => x.JobId == jobMaster.JobId).FirstOrDefault();
			if(a!= null) { 
			a.JobTitle = jobMaster.JobTitle;
			a.JobTypeId = jobMaster.JobTypeId;
			a.JobDiscription = jobMaster.JobDiscription;
			a.JobTypeId = jobMaster.JobTypeId;
			return jobPortalEfContext.SaveChanges() > 0 ? true : false;
            }
			return false;
        }
    }
}
