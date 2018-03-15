using System;
using System.Collections.Generic;


namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

			book.NameChanged += OnNameChanged;

			book.Name = "Isaac's GradeBook";
			book.Name = "GradeBook";
			book.Name = "Homer's GradeBook";
			book.Name = "Isaac's GradeBook";

			book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
			Console.WriteLine(book.Name);
            WriteResult("Average grade: ", stats.AverageGrade);
            WriteResult("Highest grade: ", (int)stats.HighestGrade);
            WriteResult("Lowest grade: ", stats.LowestGrade);
			Console.ReadLine();
        }

		static void OnNameChanged(object sender, NameChangedEventArgs args)
		{
			Console.WriteLine($"GradeBook changing name from {args.ExistingName} to {args.NewName}");
		}

		static void WriteResult(string description, float result) 
		{
			Console.WriteLine($"{description}: {result:F2}");
		}

		static void WriteResult(string description, int result) 
		{
			Console.WriteLine($"{description}: {result:F2}");
		}
    }
}
