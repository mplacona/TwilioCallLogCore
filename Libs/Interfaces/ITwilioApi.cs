using System.Threading.Tasks;
using Refit;

namespace Libs
{
	public interface ITwilioApi
	{
		[Get("/Accounts/{accountSid}/Calls.json?PageSize=10")]
		Task<CallResult> ListCalls(string accountSid, [Header("Authorization")] string authorization);
	}
}
