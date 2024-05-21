using System.Text.Json.Serialization;

namespace ApiFichaAcademia.Common.Utils.ResultInfo
{
    public class ResultInfo<T>
    {
		[JsonPropertyOrder(-2)]
		public bool Status { get; set; }

		[JsonPropertyOrder(-1)]
		public int QuantData { get; set; }

        public string Message { get; set; }

        public ResultInfo() 
		{
			Status = true;
			QuantData = 0;
			Message = string.Empty;
		}
	}
}
