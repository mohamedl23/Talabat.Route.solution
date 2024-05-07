namespace Talabat.APIs.Errors
{
	public class ApiResponse
	{
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public ApiResponse(int statusCode , string? message = null) 
        {
            StatusCode = statusCode;
            Message = message ?? getDefaultMessageForStatusCode(statusCode);
        }

		private string? getDefaultMessageForStatusCode(int statusCode)
		{
			return statusCode switch
			{
				400 => "A Bad Request , You Have made",
				401 => "Authorized , You are not",
				404 => "Resource Was Not found",
				405 => "Errors Are The Path To the Dark Site . Errors lead to anger . Anger leads to hate leads to career thange ;(",
				_	=>  null
			};
		}
	}
}
