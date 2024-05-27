namespace ApiFichaAcademia.Common
{
	public static class MessagesDefault
	{
		#region Private

		private static string TRY_AGAIN = "Please, try again!";
		private static string VERIFY_TRY_AGAIN = "Please, verify and try again!";

		#endregion
				
		public static string BAD_REQUEST = $"Error when executing this endpoint. {TRY_AGAIN}";
		public static string NOT_FOUND = $"I don't found item with this value. {VERIFY_TRY_AGAIN}";
	}
}
