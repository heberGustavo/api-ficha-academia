using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.Models.Model
{
	public class Person
	{
        public int Id { get; set; }
		public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int WeeklyFrequency { get; set; }

        //person has a Objective, Teacher and Card
    }
}
