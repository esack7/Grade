using Grade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypeTests
    {
		[TestMethod]
		public void UsingArrays()
		{
			float[] grades;
			grades = new float[3];

			AddGrades(grades);

			Assert.AreEqual(89.1f, grades[1]);
		}

		private void AddGrades(float[] grades)
		{
			grades[1] = 89.1f;
		}

		[TestMethod]
		public void UpperCaseString()
		{
			string name = "isaac";
			name = name.ToUpper();

			Assert.AreEqual("ISAAC", name);
		}
		
		[TestMethod]
		public void AddDaysToDateTime()
		{
			DateTime date = new DateTime(2018, 1, 1);
			date = date.AddDays(1);

			Assert.AreEqual(2, date.Day);
		}

		[TestMethod]
		public void ValueTypesPassByValue()
		{
			int x = 46;
			IncrementNumber(x);

			Assert.AreEqual(46, x);
			Assert.AreNotEqual(47, x);
		}

		private void IncrementNumber(int number)
		{
			number += 1;
		}

		[TestMethod]
		public void ReferenceTypesPassByValue()
		{
			GradeBook book1 = new GradeBook();
			GradeBook book2 = book1;

			GiveBookAName(book2);
			Assert.AreEqual("A GradeBook", book1.Name);
		}

		private void GiveBookAName(GradeBook book)
		{
			book.Name = "A GradeBook";	
		}

		[TestMethod]
		public void StringComparisons()
		{
			string name1 = "Isaac";
			string name2 = "isaac";

			bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);

			Assert.IsTrue(result);
		}

        [TestMethod]
        public void IntVariabeHoldsValue()
        {
            int x1 = 10;
            int x2 = x1;

            x1 = 25;

            Assert.AreNotEqual(x1, x2);
        }
        [TestMethod]
        public void GradebookVariableHoldsAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Isaac's new Gradebook";

            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
