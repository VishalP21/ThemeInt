using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeInt.BussinesEntity;
using ThemeInt.BussinesService.Interface;
using ThemeInt.Repo.ConCreate;

namespace ThemeInt.BussinesService.ConCreate
{
	public class JobTypeService : IJobTypeservice
	{
		private readonly JobTypeRepo jobTypeRepo;

		public JobTypeService()
		{
			jobTypeRepo = new JobTypeRepo();
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
