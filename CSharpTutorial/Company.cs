using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CSharpTutorial
{
	class Company
	{
		public string Name { get; set; }
		public Address ShippingAddress { get; set; }

		public static string Dump(object obj)
		{
			return JsonConvert.SerializeObject(obj);
		}
	}
}
