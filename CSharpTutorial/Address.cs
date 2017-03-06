using Newtonsoft.Json;

namespace CSharpTutorial
{
	public class Address
	{
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public static string Dump(object obj)
		{
			return JsonConvert.SerializeObject(obj);
		}
	}
	
}
