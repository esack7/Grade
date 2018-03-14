using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average grade: " + stats.AverageGrade);
            Console.WriteLine("Highest grade: " + stats.HighestGrade);
            Console.WriteLine("Lowest grade: " + stats.LowestGrade);
        }
    }
}
