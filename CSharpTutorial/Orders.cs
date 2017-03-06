using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace CSharpTutorial
{
	class OrdersCl
	{
		private List<Order> _orders = new List<Order>();
		private ReadOnlyCollection<Order> _ordersView;
		public ReadOnlyCollection<Order> Orders
		{
			get
			{
				if (_ordersView == null)
				{
					_ordersView = new ReadOnlyCollection<Order>(_orders);
				}
				return _ordersView;
			}

		}
		public IEnumerable<Order> OrdersEnum
		{
			get
			{
				return _orders.AsEnumerable();//in System.Lynq namespace
			}
		}
		public void AddOrder(Order order)
		{
			_orders.Add(order);
		}
		public static string Dump(object obj)
		{
			return JsonConvert.SerializeObject(obj);
		}
	}
}
