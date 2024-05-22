using ApiFichaAcademia.Common.Utils.ResultInfo;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ApiFichaAcademia.Common.Utils
{
	public class ResultInfoList<T> : ResultInfo<T> where T : class
	{
		[JsonPropertyOrder(-1)]
		public int QuantData { get; set; }

		public List<T> Data { get; set; }

		public ResultInfoList()
		{
			Data = new List<T>();
			QuantData = 0;
		}

		public ResultInfoList(bool status, int quantData, string message) 
		{
			Status = status;
			QuantData = quantData;
			Message = message;
		}
	}
}
