using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeInt.DataBase;
using ThemeInt.Repo.Interface;

namespace ThemeInt.Repo.ConCreate
{
	public class JobTypeRepo : IJobTypeRepo
	{
		private readonly JobPortalEfContext jobPortalEfContext;

		public JobTypeRepo(JobPortalEfContext jobPortalEf)
		{
			jobPortalEfContext = jobPortalEf;
		}
		public List<JobType> GetJobsType()
		{
			return jobPortalEfContext.JobTypes.ToList();
		}
	}
}
