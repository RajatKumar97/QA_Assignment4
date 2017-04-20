using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assignment4QA;

namespace Assignment4.TestQA
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
     
     
        public void inavlidgreaterthen_A()
        {
            NUnit.Framework.Assert.AreEqual("Invalid", TriangleSolver.Analyze(52, 3, 7), "a greater than b + c");
        }

        [Test]
        public void invalidCisGreater()
        {
            NUnit.Framework.Assert.AreEqual("Invalid",TriangleSolver.Analyze(3, 7, 52), "c greater than a + b");
        }

        [Test]
        public void invalidAisZero()
        {
            NUnit.Framework.Assert.AreEqual("Invalid", TriangleSolver.Analyze(0, 12, 40), "a is zero");
        }

        [Test]
        public void invalidLessThenZero() // lt = lesss than
        {
            NUnit.Framework.Assert.AreEqual("Invalid", TriangleSolver.Analyze(11, 32, -30), "c is less than zero");
        }


        // Checking for Equalateral
        [Test]
        public void equilateralAllSidesEqual1()
        {
            NUnit.Framework.Assert.AreEqual("Equilateral", TriangleSolver.Analyze(4, 4, 4), "a = b = c = 4");
        }

        [Test]
        public void equilateralAllSidesEqual2()
        {
            NUnit.Framework.Assert.AreEqual("Equilateral", TriangleSolver.Analyze(121, 121, 121), "a = b = c = 121");
        }

        // Checking for Isosceles
        [Test]
        public void IsoscelesABSameCNotEqual()
        {
            NUnit.Framework.Assert.AreEqual("Isosceles", TriangleSolver.Analyze(4, 4, 1), "a = b = 5 != c = 1");
        }

        [Test]
        public void checkScalene1()
        {
            NUnit.Framework.Assert.AreEqual("Scalene", TriangleSolver.Analyze(9, 6, 5), "a = 9, b = 6, c = 5 Scalene Traingle1");
        }

        [Test]
        public void checkScalene2()
        {
            NUnit.Framework.Assert.AreEqual("Scalene", TriangleSolver.Analyze(356, 332, 397), "a = 246, b = 222, c = 287  Second Scalene Traingle");
        }

    }
}


