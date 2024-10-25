using Microsoft.AspNetCore.Mvc;
using ThemeInt.BussinesEntity;
using ThemeInt.BussinesService.ConCreate;
using ThemeInt.BussinesService.Interface;

namespace ThemeInt.Controllers
{
    public class JobController : Controller
    {
        private readonly IJobService jobService;
        private readonly IJobTypeservice jobTypeService;

        public JobController(IJobService _jobService, IJobTypeservice _jobTypeService)
        {
            jobService = _jobService;
            jobTypeService = _jobTypeService;  
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
            if (jobInformation.JobId > 0)
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
            data.Jobtype = jobTypeService.jobIType();
            return View( "Index", data);
        }


        // Display with jQuery

        public IActionResult Abc()
        {
            var data = jobService.GetJobs();  
            return Json(new {data = data});
        }
        
        public IActionResult Print()
        {
            return View();
        }


        // Add With jQuery
        [HttpGet]

        public IActionResult adduserjq()
        {
            JobInformation jobInformation = new JobInformation();
            jobInformation.Jobtype = jobTypeService.jobIType();
            return View(jobInformation);
        }

        [HttpPost]

        public IActionResult adduserjq(JobInformation jobInformation)
        {
            var aa = jobService.addjob(jobInformation);
            return Json(new
            {
                data = aa
            });
        }

    }
}
