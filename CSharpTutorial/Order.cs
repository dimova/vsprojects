using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CSharpTutorial
{
	public class Order
	{
		public Order(string orderNumber)
		{
			OrderNumber = orderNumber;
		}
		public string OrderNumber { get; }
		private DateTime orderDate;
		public DateTime OrderDate
		{
			get { return orderDate; }
			set
			{
				orderDate = value;
			}
		}
		public static string Dump(object obj)
		{
			return JsonConvert.SerializeObject(obj);
		}

	}
}
