using System;

public class Person	
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public Address ShippingAddress { get; set; }
	public DateTime DateOfBirth { get; set; }
	public string TaxPayerId { get; set; }

	public Person()
	{
		FirstName = string.Empty;
		LastName = string.Empty;
		TaxPayerId = string.Empty;
	}

	public Person(DateTime dateOfBirth)
	{
		DateOfBirth = dateOfBirth;
	}

}
