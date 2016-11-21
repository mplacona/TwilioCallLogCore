using System;
using System.Collections.Generic;

namespace Libs
{
	/// <summary>
	/// Twilio API call result with paging information
	/// </summary>
	public class CallResult
	{
		/// <summary>
		/// List of Calls returned from API request
		/// </summary>
		public List<Call> Calls { get; set; }
	}
}
