using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeInt.BussinesEntity;
using ThemeInt.BussinesService.Interface;
using ThemeInt.Repo.ConCreate;
using ThemeInt.Repo.Interface;

namespace ThemeInt.BussinesService.ConCreate
{
	public class JobTypeService : IJobTypeservice
	{
		private readonly IJobTypeRepo jobTypeRepo;

		public JobTypeService(IJobTypeRepo _jobTypeRepo)
		{
			jobTypeRepo = _jobTypeRepo;
		}

		public List<SelectListItem> jobIType()
		
		{

			// This Mathod use as helper of common
			var data = jobTypeRepo.GetJobsType();

			return data.Select(x => new SelectListItem
			{
				Value = x.JobtypeId.ToString(),
				Text = x.JobTypeName,
			}).ToList();
		}
	}
}
