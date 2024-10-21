using Microsoft.AspNetCore.Mvc;
using ThemeInt.BussinesEntity;
using ThemeInt.BussinesService.ConCreate;

namespace ThemeInt.Controllers
{
    public class JobController : Controller
    {
        private readonly JobService jobService;
        private readonly JobTypeService jobTypeService;

        public JobController()
        {
            jobService = new JobService();
            jobTypeService = new JobTypeService();  
        }



        [HttpGet]
        public IActionResult Index()
        {
            JobInformation jobInformation = new JobInformation();
            jobInformation.Jobtype = jobTypeService.jobIType();
            return View(jobInformation);
        }


        [HttpPost]

		public IActionResult Index(JobInformation jobInformation)
		{
            if(!ModelState.IsValid)
            {
                return View(jobInformation);
            }
            if (jobInformation.JobId != null)
            {
                jobService.updatejob(jobInformation);
            }
            else
            {
                jobService.addjob(jobInformation);
            }
			return RedirectToAction("display");
		}

		public IActionResult display()
        {
            var data = jobService.GetJobs();
            return View(data);
        }

        public IActionResult delete(int jobID)
        {
                jobService.removejob(jobID);
            return RedirectToAction("display");
        }

        public IActionResult edit(int jobID)
        {
           var data = jobService.GetJob(jobID);
            return RedirectToAction("data", "Index");
        }
    }
}
