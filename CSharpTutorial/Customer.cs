using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	public class Customer:Person
	{
		public List<Order> orders = new List<Order>();
		public Customer(string name)
		{
			Name = name;
		}
		public void AddOrder(Order order)
		{
			orders.Add(order);
		}
		public string Name { get; }
		public string Title { get; internal set; }
		public List<Order> HistoricOrders
		{
			get => HistoricOrders;
			set => HistoricOrders = value;
		}
		

		public string ConstructCustomerName(Customer customer)
		{
			string name = "";
			if (!String.IsNullOrEmpty(customer.Title))
			{
				name += customer.Title + " ";
			}
			if (!String.IsNullOrEmpty(customer.FirstName))	
			{
				name += customer.FirstName + " ";
			}
			if (!String.IsNullOrEmpty(customer.MiddleName))
			{
				name += customer.MiddleName + " ";
			}
			if (!String.IsNullOrEmpty(customer.LastName))
			{
				name += customer.LastName + " ";
			}
			if (!String.IsNullOrEmpty(customer.Suffix))
			{
				name += customer.Suffix;
			}
			return name.Trim();
		}
	}
}
