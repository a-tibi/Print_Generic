using System;

namespace Print_Generic
{
	class Program
	{
		static void Main(string[] args)
		{
			Print<int>(10);
			Print<string>("Ahmad");
			Print<char>('T');
			Print(new { Id = 1, Name ="Ahmad Tibi" });
			Print<Person>(new Person("Ahmad","Tibi"));	
			Console.ReadKey();
		}

		static void Print<T>(T value)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine($"Data Type: {typeof(T)}");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"Data Value: {value}");
			Console.WriteLine("--------------------------------------------");

		}
	}

	class Person
	{
		private string _fName;
		private string _lLame;

		public Person(string fName, string lName)
		{
			_fName = fName;
			_lLame = lName;
		}

		public override string ToString()
		{
			return $"Person Name: {_fName} {_lLame}";
		}
	}
}
