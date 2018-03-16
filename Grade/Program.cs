using System;
using System.Collections.Generic;
using System.IO;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
		{
			GradeBook book = new GradeBook();

			GetBookName(book);
			AddGrades(book);
			SaveGrades(book);
			WriteResults(book);
		}

		private static void WriteResults(GradeBook book)
		{
			GradeStatistics stats = book.ComputeStatistics();
			WriteResult("Average grade: ", stats.AverageGrade);
			WriteResult("Highest grade: ", (int)stats.HighestGrade);
			WriteResult("Lowest grade: ", stats.LowestGrade);
			WriteResult(stats.Description, stats.LetterGrade);

			Console.ReadLine();
		}

		private static void SaveGrades(GradeBook book)
		{
			using (StreamWriter outputFile = File.CreateText("grades.txt"))
			{
				book.WriteGrades(outputFile);
			}
		}

		private static void GetBookName(GradeBook book)
		{
			try
			{
				Console.WriteLine("Enter a name: ");
				book.Name = Console.ReadLine();
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private static void AddGrades(GradeBook book)
		{
			book.AddGrade(91);
			book.AddGrade(89.5f);
			book.AddGrade(75);
		}

		static void WriteResult(string description, string result)
		{
			Console.WriteLine($"{description}: {result}");
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
