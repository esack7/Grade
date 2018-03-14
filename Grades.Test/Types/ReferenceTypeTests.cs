using Grade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
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
