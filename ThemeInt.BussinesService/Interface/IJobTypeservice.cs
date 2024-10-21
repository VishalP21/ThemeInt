using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeInt.BussinesEntity;

namespace ThemeInt.BussinesService.Interface
{
	public interface IJobTypeservice
	{
		List<SelectListItem> jobIType();
	}
}
