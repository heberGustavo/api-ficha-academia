using ApiFichaAcademia.Common.Utils.ResultInfo;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ApiFichaAcademia.Common.Utils
{
	public class ResultInfoItem<T> : ResultInfo<T> where T : class
	{
		public T Data { get; set; }

        public ResultInfoItem() {}

        public ResultInfoItem(bool status, string message)
		{
			Status = status;
			Message = message;
		}
	}
}
