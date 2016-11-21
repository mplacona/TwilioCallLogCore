using System;
using System.Text;
using System.Threading.Tasks;
using Libs;
using Refit;

class Program
{
	static string accountSid;
	static string authToken;
	static ITwilioApi twilioApi;

	static void Main(string[] args)
	{
		accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
		authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

		twilioApi = RestService.For<ITwilioApi>("http://api.twilio.com/2010-04-01");

		Task.Run(async () =>
		{
			var calls = await twilioApi.ListCalls(accountSid, httpBase64(accountSid, authToken));
			foreach (var call in calls.Calls)
			{
				var detail = string.Format("From: {0}, Day: {1}, Duration: {2}s", call.From, call.DateCreated, call.Duration);
				Console.WriteLine(detail);
			}
		}).Wait();
	}

	private static string httpBase64(string username, string password) { 
		var token = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", username, password)));
		return string.Format("Basic {0}", token);
	}
}
