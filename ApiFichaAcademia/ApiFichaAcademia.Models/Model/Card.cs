using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.Models.Model
{
	public class Card
	{
        public int Id { get; set; }
		public string Name { get; set; }
        public DateTime DateStart { get; set; }
		public DateTime DateEnd { get; set; }

		//A card it's relational with a Person and a list of Exercises 
	}
}
