using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.Models.DTO
{
	public class TeacherDTO
	{
		public int Id { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

		[StringLength(50)]
		public string? Phone { get; set; }

		[Required, Range(1, 3, ErrorMessage = "It's necessary send the Period. Morning, Afternoon or Night")]
		public int Period { get; set; }
	}
}
