using System;
using System.Collections.Generic;
using System.Linq;
using CSharpTutorial;
using Newtonsoft.Json;

public class Person	
{
	public string FirstName { get; set; }
	public string MiddleName { get; set; }
	public string LastName { get; set; }
	public string Suffix { get; set; }
	public string Occupation { get; set; }
	public int Age { get; set; }
	public Address ShippingAddress { get; set; }
	private DateTime DateOfBirth { get; set; }
	public string TaxPayerId { get; set; }
	public string FullName => $"{this.FirstName} {this.LastName}";
	
	private static IEnumerable<object> people;

	public Person()
	{
		FirstName = string.Empty;
		LastName = string.Empty;
		TaxPayerId = string.Empty;
	}
	public bool IsAnAdult()
	{
		var eighteenYearsAgo = DateTime.Today.AddYears(-18);
		return this.DateOfBirth < eighteenYearsAgo;
	}
	public Person(string firstName, string lastName, DateTime dateOfBirth)
	{
		this.FirstName = firstName;
		this.LastName = lastName;
		this.DateOfBirth = dateOfBirth;
	}

	public Person(DateTime dateOfBirth)
	{
		DateOfBirth = dateOfBirth;
	}
	public static string Dump(object obj)
	{
		return JsonConvert.SerializeObject(obj);
	}

}
