using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _16._7._1._HW_03_.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectNumber() 
        {
            var calc = new Calculator();
            int numb = calc.Additional(3, 2);
            Assert.AreEqual(numb, 5);
        }
        [Test]
        public void SubtractioтMustReturnCorrectNumber()
        {
            var calc = new Calculator();
            int numb = calc.Subtraction(3, 2);
            Assert.AreEqual(numb, 1);
        }
        [Test]
        public void MultiplicationMustReturnCorrectNumber()
        {
            var calc = new Calculator();
            int numb = calc.Miltiplication(3, 2);
            Assert.AreEqual(numb, 6);
        }
        [Test]
        public void DivisionMustReturnCorrectNumber()
        {
            var calc = new Calculator();
            int numb = calc.Division(30, 2);
            Assert.AreEqual(numb, 15);
        }
        [Test]
        public void MultiplicationMustThrowException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(delegate { calc.Division(3, 0); });
        }
    }
}
