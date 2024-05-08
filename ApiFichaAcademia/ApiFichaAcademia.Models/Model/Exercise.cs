using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.Models.Model
{
	public class Exercise
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Frequency { get; set; }
        public int Repetition { get; set; }
        public int Weight { get; set; }
    }
}
