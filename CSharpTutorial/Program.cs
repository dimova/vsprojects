using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	public static class Program
	{
		static int versionNumber = 123;//defines a field
		private static List<Order> orders;

		//public override string ToString()
		//{
		//	return $"MyProgramName-Version{versionNumber}";
		//}
		public static object FirstName { get; private set; }
		public static object LastName { get; private set; }

		static string CreateGreeting(string name)
		{
			return $"Hi {name}!";
		}

		static string CreateGreeting1(string name = "You")
		{
			return $"Hi {name}!";
		}

		static void DisplayGreeting()
		{
			Console.WriteLine(CreateGreeting("Steve"));
		}

		static int SecondsRemaining(DateTime endTime)
		{
			return SecondsRemaining(endTime - DateTime.Now);
		}

		static int SecondsRemaining(string endTime)
		{
			return SecondsRemaining(DateTime.Parse(endTime));
		}

		static int SecondsRemaining(TimeSpan duration)
		{
			return (int)duration.TotalSeconds;
		}

		static int AddIntegers(int operand1, int operand2)
		{
			//only works with its own parameters;
			//works well as static methods
			return operand1 + operand2;
		}

		static string FullName()
		{
			//FirstName and LastName are Properties of this class - shouldn't be static
			return $"{FirstName} {LastName}";
		}

		static void Greet(string name)
		{
			if (String.IsNullOrEmpty(name)) return;
			Console.WriteLine($"Hello, {name}!");
		}

		public static int PlusFive(this int input)
		{
			return input + 5;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var name2 = "Desi"; //use your name here
			Console.WriteLine($"Hello {name2}!");
			string string1;//current value is null
			string1 = "Hello";
			string string2 = "Hello";
			//string emtpy1 = "";
			string empty2 = String.Empty;
			string emptyString = String.Empty;
			string nullString = null;
			Console.WriteLine(string1);
			Console.WriteLine(string2);
			Console.WriteLine(emptyString);//prints nothing
			Console.WriteLine(nullString);//prints nothing
										  //this line will print 0
			Console.WriteLine($"1st string is {emptyString.Length} characters long.");
			//this line will throw an exception(uncomment it to confirm)
			//Console.WriteLine($"2nd string is {nullString.Length} characters long.");
			string one = "abc";
			string two = "123";
			string combined = one + two; //"abc123"
			string original = "Test string";
			string capital = original.ToUpper();//TEST String
			string lower = original.ToLower();//test string
			string lower2 = "Another Test".ToLower();//another test
			string input = "Steve";//has a space at the start and end.
			string clean1 = input.TrimStart();//"Steve"
			string clean2 = input.TrimEnd();//"Steve"
			string clean3 = input.Trim();//"Steve"
			string shortversion = input.Trim().Substring(0, 3);//"Ste"
			string name1 = "Steve";
			string greet1 = $"Hello {name1}!";//Hello Steve!
			string greet2 = "Hello " + name1 + "!";//Hello Steve!
			string greet3 = String.Format("Hello {0}!", name1);//Hello Steve!
			string greetTemplate = "Hello **NAME**!";
			string greet4 = greetTemplate.Replace("**NAME**", name1);//Hello Steve!
			var currentTime = DateTime.Now;//current time
			var today = DateTime.Today;//current date - time is midnight
			var someDate = new DateTime(2016, 7, 1);//1 July 2016, midnight
			var someMoment = new DateTime(2016, 7, 1, 8, 0, 0);//1 July 2016, 08:00.00
			var tomorrow = DateTime.Today.AddDays(1);
			var yesterday = DateTime.Today.AddDays(-1);
			var someDay = DateTime.Parse("7/1/2016");
			var someTime = new DateTime(2016, 7, 1, 11, 10, 9); // 1 July 2016 11:10:09 AM
			int year = someTime.Year;//2016
			int month = someTime.Month;//7
			int day = someTime.Hour;//11
			int minute = someTime.Minute;//10
			int second = someTime.Second;//9
			DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
			TimeSpan duration = nextYear - DateTime.Today;
			Console.WriteLine($"There are {duration.TotalDays} days left in the year.");
			var birthDate = new DateTime(1980, 10, 12);
			var days = DateTime.Today - birthDate;
			var nowTime = DateTime.Now;//current time
			TimeSpan howOld = nowTime - birthDate;
			Console.WriteLine($"I am {howOld.TotalDays} old.");

			int daysToNextAnniversary = 10000 - (days.Days % 10000);
			Console.WriteLine(daysToNextAnniversary);

			Console.ReadLine();
			Console.WriteLine("What is the capital of Ohio?");
			var answer = Console.ReadLine();
			if (answer.ToLower() == "columbus")
			{
				Console.WriteLine("Correct!");
			}
			else
			{
				Console.WriteLine("Sorry, that's not the right answer.");
			}
			//two values, x and y, are being compared
			int x30, y;
			x30 = 5; y = 2;
			if (x30 < y) { Console.WriteLine(-1); }
			else
			{
				if (x30 == y) { Console.WriteLine(0); }
				else //x must be greater than y
				{ Console.WriteLine(1); }
			}
			Console.ReadLine();

			Console.WriteLine("Guess a number?");
			int guessedNumber1 = int.Parse(Console.ReadLine());
			int guessedNumber = 4;
			switch (guessedNumber)
			{
				case 0:
					Console.WriteLine("Sorry, 0 is not a valid guess.");
					break;
				case 1:
					Console.WriteLine("You guessed the right number!");
					break;
				case 2:
					Console.WriteLine("You guessed the right number + 1");
					break;
				default:
					Console.WriteLine("You guessed high.");
					break;
			}
			//int correctNumber = new Random().Next(4);
			//Console.WriteLine(guessedNumber);
			//Console.WriteLine(guessedNumber1);
			//Console.ReadLine();
			//int numberToGuess = new Random().Next(1, 101);//a number from 1 to 100
			//int currentGuess = 0;//start with an incorrect guess
			//while (currentGuess != numberToGuess)
			//{
			//	Console.WriteLine("Guess the number(1 to 100): ");
			//	1currentGuess = int.Parse(Console.ReadLine());
			//	if (currentGuess < numberToGuess)
			//	{
			//		Console.WriteLine("You guessed too low! Try again!");
			//	}
			//	if (currentGuess > numberToGuess)
			//	{
			//		Console.WriteLine("You guessed too high! Try again!");
			//	}
			//}
			//Console.WriteLine("You got it! Good job!");
			//int numberToGuess1 = new Random().Next(1, 101);// a number from 1 to 100
			//while (true)//this sets up an infinite loop, since true will always evaluate to true
			//{
			//	Console.WriteLine("Guess the number(1 to 100):");
			//	int currentGuess1 = int.Parse(Console.ReadLine());
			//	if (currentGuess == numberToGuess) break;
			//	if (currentGuess < numberToGuess)
			//	{
			//		Console.WriteLine("You guessed too low! Try again!");
			//	}
			//	if (currentGuess > numberToGuess)
			//	{
			//		Console.WriteLine("You guessed too high! Try again!");
			//	}
			//}
			//Console.WriteLine("You got it! Good job!");
			Console.WriteLine("Enter a number:");
			int number = int.Parse(Console.ReadLine());
			Console.Write("Factors: ");
			if (number > 1)//convert this to while
			{
				int candidateFactor = 2;
				if (candidateFactor <= number)//convert this to while
				{
					if (number % candidateFactor == 0)//found a factor
					{
						Console.Write(candidateFactor);
						//divide number by the factor you found and assign this back to number
						//print a comma if number is still greater than 1
					}
					//don't forget to increment factor!
				}
			}
			Console.WriteLine();
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
			}
			int startingNumber = 5;//change to whatever value you want to start from
			int endingNumber = 10;//change to whatever number you want to be the last displayed
			for (int i = startingNumber; i <= endingNumber; i++)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Odd numbers from 1-49:");
			for (int i = 1; i < 50; i += 2)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Countdown started...");
			for (int i = 10; i > 0; i--)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("LIFTOFF!");
			Console.WriteLine("Multiplication Table:");
			Console.WriteLine("1 2 3 4 5 6 7 8 9");
			for (int i = 1; i < 10; i++)
			{
				Console.Write($" {i} ");
				for (int j = 1; j < 10; j++)
				{
					string product = (i * j).ToString();
					Console.Write(product.PadLeft(3));
				}
				Console.WriteLine();

			}

			int[] someIntegers;
			someIntegers = new int[3];//holds 3 elements, with indexes of 0, 1, and 2.
									  //uninitialized elements of a declared array hold the default value for the type (int this case 0).

			int[] moreIntegers = new int[] { 1, 2, 3, 4, 5 };//initializes tha values of the array
			int[] otherIntegers = new[] { 1, 3, 5, 7, 9 };//you can omit, type is inferred
			int[,] eggCarton = new int[2, 6];//a typical egg carton can be thought of as a 2x6 array
			int[,] someTable = { { 1, 2, 3 }, { 4, 5, 6 } }; //you can fill a multi-dimensional array on assignment as well

			int[][] jaggedArray = new int[4][]; // define first dimension
			jaggedArray[0] = new int[2] { 1, 2 }; // set values of first array
			Console.WriteLine(jaggedArray[0][0]); // first element in first row
			Console.WriteLine(jaggedArray[0][1]); // second element in first row

			// additional rows haven't yet been created/assigned
			Console.WriteLine(jaggedArray[1]); // value is null
			int[] someIntegers3 = { 1, 2, 3 };
			int x1 = 1 + someIntegers[0];//x=2
			int y1 = 2 * someIntegers[2];//someIntegers now contains{1,2,6}
										 //someIntegers[3] = 3;//exception
			Console.ReadLine();
			//string input1 = "red,blue,yellow,green";
			string[] colors1 = input.Split(',');//note single quotes
			string output = String.Join("|", colors1);
			Console.WriteLine(output);
			List<int> someInts1 = new List<int>
			{
				2//the list now has one item in it:{2}
			};//declares an empty list
			List<int> moreInts1 = new List<int>() { 2, 3, 4 };//you can initialize a list when you create it
			string[] colors2 = "red,blue,yellow,green".Split(',');//an array of 4 strings
			List<string> colorList = new List<string>(colors2);//initialize the list from an array
			List<int> someInts = new List<int>
			{
				2//the list now has one item in it:{2}
			};//declares an empty list
			List<int> moreInts = new List<int>() { 2, 3, 4 };//you can initialize a list when you create it

			List<string> colors4 = new List<string>() { "black", "white", "gray" };
			colors4.Remove("black");
			colors4.Insert(0, "orange"); // orange is the new black
			colors4.RemoveAll(c4 => c4.Contains("t")); // removes all elements matching condition (containing a "t")
													   // colors currently: orange, gray
			colors4.RemoveAt(0); // removes the first element (orange)
			int numColors = colors4.Count; // Count currently is 1
			colors4.Clear(); // colors is now an empty list	

			var colors5 = new List<string>() { "blue", "green", "yellow" };
			colors5.ForEach(Console.WriteLine);
			Console.ReadLine();
			var myList = new List<string>() { "one", "two", "three" };
			foreach (var item in myList)
			{
				Console.WriteLine(item);
			}
			foreach (var arg in args)
			{
				Console.WriteLine(arg);
			}
			//List<T>
			var myList6 = new List<int>() { 43, 55, 100 };
			for (int i = 0; i < myList6.Count; i++)
			{
				//access current element of the list with index of i
				Console.WriteLine(myList[i]);
			}
			//array
			int[] numbers = new[] { 2, 3, 5, 7 };
			for (int i = 0; i < numbers.Length; i++)
			{
				//access current element of the array with index of i
				Console.WriteLine(numbers[i]);
			}
			var myList5 = new List<int>() { 10, 20, 30 };
			int index = 0;
			while (index < myList5.Count)
			{
				Console.WriteLine(myList[index]);
				index++;
			}
			List<int> nums = new List<int>() { 2, 4, 6 };
			int sumNums = 0;
			for (int n = 0; n < nums.Count; n++)
			{
				sumNums += nums[n];
				Console.WriteLine(sumNums);
			};
			string greeting = CreateGreeting("Desi");
			Console.WriteLine($"Default Greeting: {greeting}");

			string customGreeting = CreateGreeting("Steve");
			Console.WriteLine($"Custom Greeting: {customGreeting}");

			string greeting1 = CreateGreeting1();
			Console.WriteLine($"Default Greeting: {greeting1}");

			Func<int, int> addOne = x4 => x4 + 1;//this is the lambda expression
			Console.WriteLine(addOne(4));

			const int four = 4;
			Func<int, int> addingOne = x5 => x5 + 1;
			Func<int, int, int> calcArea = (x5, y5) => x5 * y5;//two parameters
			Func<int> twentyFive = () => calcArea(addingOne(four), addingOne(four));//no parameters
			Console.WriteLine(twentyFive());
			int luckyNumber = 10;
			Console.WriteLine(luckyNumber);//will output 10

			//you must create an instance of Program
			//var myProgram = new Program();
			//Console.WriteLine($"Current version: {myProgram.versionNumber}");
			//var myProgram = new Program();
			//Console.WriteLine(myProgram.ToString());//or
			//Console.WriteLine(myProgram);//WriteLine will automatically call ToString for you internally
			Console.ReadLine();
			Rectangle r = new Rectangle()
			{
				Height = 5,
				Width = 6
			};
			r.DisplayShape(r);
			Triangle tri = new Triangle()
			{
				Side1 = 3,
				Side2 = 4,
				Side3 = 5
			};
			tri.DisplayShape(tri);
			Console.ReadLine();
			Address ap = new Address()
			{
				StreetAddress = "123 Main Street",
				City = "Sometown",
				State = "OH",
				PostalCode = "12345",
				Country = "United States"
			};
			Address ap2 = new Address()
			{
				StreetAddress = "124 Main Street",
				City = "Sometown",
				State = "OH",
				PostalCode = "12345",
				Country = "United States"
			};
			Address ac = new Address()
			{
				StreetAddress = "125 Main Street",
				City = "Sometown",
				State = "OH",
				PostalCode = "12345",
				Country = "United States"
			};
			Person p = new Person()
			{
				FirstName = "Joe",
				LastName = "Doe",
				ShippingAddress = ap
			};
			Person p2 = new Person()
			{
				FirstName = "Jane",
				LastName = "Doe",
				ShippingAddress = ap2
			};
			Company c = new Company()
			{
				Name = "Company, Inc.",
				ShippingAddress = ac
			};
			ArrayList al = new ArrayList
			{
				p,
				p2,
				c
			};
			foreach (object item in al)
			{
				Console.WriteLine("The object is:" + item.ToString());
				if (item.Equals(p) || item.Equals(p2))
				{
					Console.WriteLine(Person.Dump(item));
				}
				else if (item.Equals(c))
				{
					Console.WriteLine(Company.Dump(item));
				}

			}
			Customer cust = new Customer("Dan");
			Order order = new Order("123")
			{
				OrderDate = DateTime.Now
			};
			Order order2 = null;
			Order order3 = new Order("123");
			cust.AddOrder(order2);
			cust.AddOrder(order);
			cust.AddOrder(order3);
			orders = (List<Order>)cust.orders; // cast from IEnumerable to List
			orders = GetOrders(cust).ToList(); // ToList creates a new list and populates it
			foreach (Order or in orders)
			{
				Console.WriteLine(Order.Dump(or));
			}
			var people = GenerateListOfPeople();
			Console.WriteLine(people);
			//There will be two Persons in this variable: the "Steve" Person and the "Jane" Person
			//var peopleOverTheAgeOf30 = people.Where(x3 => x3.Age > 30);
			//foreach (var person in peopleOverTheAgeOf30)
			//{
			//	Console.WriteLine(person.FirstName);
			//}
			IEnumerable<string> allFirstNames = people.Select(xf => xf.FirstName);
			Person firstOrDefault = people.FirstOrDefault();

			Person lastOrDefault = people.LastOrDefault();
			Console.WriteLine(lastOrDefault.FirstName);
			Person single = people.SingleOrDefault(x => x.FirstName == "Eric");
			Console.WriteLine(single.FirstName);
			int numberOfPeopleInList = people.Count();
			//Console.WriteLine(numberOfPeopleInList);
			//int peopleOverTwentyFive = people.Count(xy => xy.Age > 25); //Will return 3
			//var firstThirtyYearOld1 = people.FirstOrDefault(xz => xz.Age == 30);
			//var firstThirtyYearOld2 = people.Where(xyo => xyo.Age == 30).FirstOrDefault();
			//Console.WriteLine(firstThirtyYearOld1.FirstName); //Will output "Brendan"
			//Console.WriteLine(firstThirtyYearOld2.FirstName); //Will also output "Brendan"
			if (people.Count() > 0) //This works
			{
				//perform some action(s)
			}
			if (people.Any()) //This is better
			{
				//perform some action(s)
			}
			bool allDevs = people.All(x => x.Occupation == "Dev"); //Will return false
			//bool everyoneAtLeastTwentyFour = people.All(x => x.Age >= 24); //Will return true
			List<Person> listOfDevs = people.Where(x => x.Occupation == "Dev").ToList(); //This will return a List<Person>
			Person[] arrayOfDevs = people.Where(x => x.Occupation == "Dev").ToArray(); //This will return a Person[] array
			Console.WriteLine(firstOrDefault.FirstName);
			try
			{
				int sum = SumNumberStrings(new List<string> { "5", "4" });
				Console.WriteLine(sum);
			}
			catch (System.FormatException)
			{
				Console.WriteLine("List of numbers contained an invalid entry.");
			}
			Console.ReadLine();
		}
		public static List<Person> GenerateListOfPeople()
		{
			var people = new List<Person>
			{
				new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 },
				new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 },
				new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 },
				new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 },
				new Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 }
			};
			return people;
		}


		public static int SumNumberStrings(List<string> numbers)
		{
			int total = 0;
			foreach (string numberString in numbers)
			{
				total += int.Parse(numberString);
			}
			return total;
		}

		private static List<Order> GetOrders(Customer cust)
		{
			return cust.orders;
		}
		public static List<string> GetAccessPermissions(string token)
		{
			// check token validity here and throw exceptions as needed.

			return new List<string> { "ReadLessons", "ReviewLessons" };
		}
	}
}
