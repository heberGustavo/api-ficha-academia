using ApiFichaAcademia.Common.Utils;
namespace ApiFichaAcademia.Common.Helpers
{
	public static class ValidateHelperResult
	{
		public static ResultInfoItem<T> ValidateResultItem<T>(ResultInfoItem<T> result) where T : class
		{
			if (!result.Status)
			{
				result.Message = MessagesDefault.BAD_REQUEST;
				return result;
			}
			else if (result.Data == null)
			{
				result.Status = true;
				result.Message = MessagesDefault.NOT_FOUND;
				return result;
			}

			return result;
		}
	}
}
