using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanConverter;
using System;

namespace ConverterTests
{
    [TestClass]
    public class RomanNumeralConverterTests
    {
        [TestMethod]
        public void Given_I_Have_1_Return_I()
        {
            // Given I have the value 1
            int number = 1;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "I"
            Assert.AreEqual("I", roman);
        }

        [TestMethod]
        public void Given_I_Have_2_Return_II()
        {
            // Given I have the value 2
            int number = 2;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "II"
            Assert.AreEqual("II", roman);
        }

        [TestMethod]
        public void Given_I_Have_4_Return_IV()
        {
            // Given I have the value 4
            int number = 4;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "IV"
            Assert.AreEqual("IV", roman);
        }

        [TestMethod]
        public void Given_I_Have_5_Return_V()
        {
            // Given I have the value 5
            int number = 5;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "V"
            Assert.AreEqual("V", roman);
        }

        [TestMethod]
        public void Given_I_Have_6_Return_VI()
        {
            // Given I have the value 6
            int number = 6;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "VI"
            Assert.AreEqual("VI", roman);
        }

        [TestMethod]
        public void Given_I_Have_9_Return_IX()
        {
            // Given I have the value 9
            int number = 9;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "IX"
            Assert.AreEqual("IX", roman);
        }

        [TestMethod]
        public void Given_I_Have_10_Return_X()
        {
            // Given I have the value 10
            int number = 10;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "X"
            Assert.AreEqual("X", roman);
        }
    }
}
