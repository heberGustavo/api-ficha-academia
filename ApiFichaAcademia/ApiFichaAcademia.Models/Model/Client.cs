using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.Models.Model
{
	public class Client
	{
        public int Id { get; set; }

		[Required, StringLength(50)]
		public string Name { get; set; }

        [Required, Range(1, 200)]
        public int Age { get; set; }

        [Required, Range(1, 999)]
        public double Weight { get; set; }

        [Required, Range(1, 7)]
        public int WeeklyFrequency { get; set; }

        //person has a Objective, Teacher and Card
    }
}
