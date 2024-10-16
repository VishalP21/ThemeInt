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
		public JobRepo()
		{
			jobPortalEfContext = new JobPortalEfContext();
		}
		public List<JobMaster> GetJobs()
		{
			return jobPortalEfContext.JobMasters.ToList();
		}
	}
}
