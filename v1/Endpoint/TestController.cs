using System;
using System.Web.Http;

namespace API
{
	public class TestController: Gale.REST.RestController
	{
		[HttpGet]
		public String Get ()
		{
			return "DDDDD";
		}
	}
}

