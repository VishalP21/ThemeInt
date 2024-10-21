using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeInt.BussinesEntity;
using ThemeInt.DataBase;

namespace ThemeInt.BussinesService.Interface
{
    public interface IJobService
    {
        List<JobInformation> GetJobs();

		bool addjob(JobInformation job);

		bool removejob(int jobid);

		JobInformation GetJob(int jobid);

        bool updatejob(JobInformation jobInformation);
    }
}
