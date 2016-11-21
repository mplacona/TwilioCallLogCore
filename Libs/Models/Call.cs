using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Libs
{
	public class Call
	{
		public string Sid { get; set; }
		public string ParentCallSid { get; set; }
		[JsonProperty("date_created")]
		public DateTime DateCreated { get; set; }
		[JsonProperty("date_updated")]
		public DateTime DateUpdated { get; set; }
		public string AccountSid { get; set; }
		public string To { get; set; }
		string from;

		public string From
		{
			get
			{
				from = string.Concat(
					"".PadLeft(6, '*'),
					from.Substring(from.Length - 4));
				return from;
			}

			set
			{
				from = value;
			}
		}

		public string PhoneNumberSid { get; set; }
		public string Status { get; set; }
		public DateTime? StartTime { get; set; }
		public DateTime? EndTime { get; set; }
		public int? Duration { get; set; }
		public decimal? Price { get; set; }
		public string Direction { get; set; }
		public string AnsweredBy { get; set; }
		public string ForwardedFrom { get; set; }
		public string CallerName { get; set; }
	}
}
