using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeInt.DataBase;

namespace ThemeInt.Repo.Interface
{
	public interface IJobRepo
	{
		List<JobMaster> GetJobs();
	}
}
