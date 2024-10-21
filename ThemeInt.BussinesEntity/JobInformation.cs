using Microsoft.AspNetCore.Mvc.Rendering;

namespace ThemeInt.BussinesEntity
{
	public class JobInformation
	{
        public int JobId { get; set; }

        public string? JobTitle { get; set; }

        public string? JobDiscription { get; set; }

        public int JobTypeId { get; set; }

        public List<SelectListItem>? Jobtype { get; set; }
    }
}
