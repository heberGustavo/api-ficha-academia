using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.Models.Model
{
	public class Teacher
	{
        public int Id { get; set; }
		public string Name { get; set; }
        public string Phone { get; set; }
        public int Period { get; set; } //period enum
    }
}
