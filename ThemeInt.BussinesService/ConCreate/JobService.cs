using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeInt.BussinesEntity;
using ThemeInt.BussinesService.Interface;
using ThemeInt.Common;
using ThemeInt.Repo.ConCreate;
using ThemeInt.Repo.Interface;

namespace ThemeInt.BussinesService.ConCreate
{
    public class JobService : IJobService
    {
        private readonly IJobRepo jobRepo;

        public JobService(IJobRepo _jobRepo)
        {
            jobRepo = _jobRepo;
        }

		public bool addjob(JobInformation job)
		{
			return jobRepo.addjob(job.ToDataModel());
		}

		public JobInformation GetJob(int jobid)
		{
			return jobRepo.GetJob(jobid).ToEditModel();
		}

		public List<JobInformation> GetJobs()
        {
            return jobRepo.GetJobs().ToViewModel();
        }

		public bool removejob(int jobid)
		{
			return jobRepo.removejob(jobid);
		}

        public bool updatejob(JobInformation jobInformation)
        {
            return jobRepo.updatejob(jobInformation.ToDataModel());
        }
    }
}
