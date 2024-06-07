using ApiFichaAcademia.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

        public string PeriodDescription {
			get 
			{
				if (Period == (int)EnumPeriod.Morning) _periodDescription = "Morning";
				else if (Period == (int)EnumPeriod.Afternoon) _periodDescription = "Afternoon";
				else if (Period == (int)EnumPeriod.Night) _periodDescription = "Night";

				return _periodDescription;
			}
			set 
			{
				_periodDescription = value;
			} 
		}

		[JsonIgnore]
		public string _periodDescription { get; set; } = string.Empty;
    }
}
