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
        public void Given_I_Have_8_Return_IX()
        {
            // Given I have the value 8
            int number = 8;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "VIII"
            Assert.AreEqual("VIII", roman);
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

        [TestMethod]
        public void Given_I_Have_11_Return_XI()
        {
            // Given I have the value 11
            int number = 11;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XI"
            Assert.AreEqual("XI", roman);
        }

        [TestMethod]
        public void Given_I_Have_13_Return_XIII()
        {
            // Given I have the value 13
            int number = 13;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XIII"
            Assert.AreEqual("XIII", roman);
        }

        [TestMethod]
        public void Given_I_Have_14_Return_XIV()
        {
            // Given I have the value 14
            int number = 14;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XIV"
            Assert.AreEqual("XIV", roman);
        }

        [TestMethod]
        public void Given_I_Have_15_Return_XV()
        {
            // Given I have the value 15
            int number = 15;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XV"
            Assert.AreEqual("XV", roman);
        }

        [TestMethod]
        public void Given_I_Have_16_Return_XVI()
        {
            // Given I have the value 16
            int number = 16;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XVI"
            Assert.AreEqual("XVI", roman);
        }

        [TestMethod]
        public void Given_I_Have_19_Return_XIX()
        {
            // Given I have the value 19
            int number = 19;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XIX"
            Assert.AreEqual("XIX", roman);
        }

        [TestMethod]
        public void Given_I_Have_20_Return_XX()
        {
            // Given I have the value 20
            int number = 20;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XX"
            Assert.AreEqual("XX", roman);
        }

        [TestMethod]
        public void Given_I_Have_40_Return_XL()
        {
            // Given I have the value 40
            int number = 40;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XL"
            Assert.AreEqual("XL", roman);
        }

        [TestMethod]
        public void Given_I_Have_41_Return_XLI()
        {
            // Given I have the value 41
            int number = 41;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XLI"
            Assert.AreEqual("XLI", roman);
        }

        [TestMethod]
        public void Given_I_Have_44_Return_XLIV()
        {
            // Given I have the value 44
            int number = 44;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XLIV"
            Assert.AreEqual("XLIV", roman);
        }

        [TestMethod]
        public void Given_I_Have_45_Return_XLV()
        {
            // Given I have the value 45
            int number = 45;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XLV"
            Assert.AreEqual("XLV", roman);
        }

        [TestMethod]
        public void Given_I_Have_50_Return_L()
        {
            // Given I have the value 50
            int number = 50;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "L"
            Assert.AreEqual("L", roman);
        }

        [TestMethod]
        public void Given_I_Have_51_Return_LI()
        {
            // Given I have the value 51
            int number = 51;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "LI"
            Assert.AreEqual("LI", roman);
        }

        [TestMethod]
        public void Given_I_Have_54_Return_LIV()
        {
            // Given I have the value 54
            int number = 54;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "LIV"
            Assert.AreEqual("LIV", roman);
        }

        [TestMethod]
        public void Given_I_Have_55_Return_LV()
        {
            // Given I have the value 55
            int number = 55;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "LV"
            Assert.AreEqual("LV", roman);
        }

        [TestMethod]
        public void Given_I_Have_60_Return_LX()
        {
            // Given I have the value 60
            int number = 60;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "LX"
            Assert.AreEqual("LX", roman);
        }

        [TestMethod]
        public void Given_I_Have_65_Return_LXV()
        {
            // Given I have the value 65
            int number = 65;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "LXV"
            Assert.AreEqual("LXV", roman);
        }

        [TestMethod]
        public void Given_I_Have_70_Return_LXX()
        {
            // Given I have the value 70
            int number = 70;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "LXX"
            Assert.AreEqual("LXX", roman);
        }

        [TestMethod]
        public void Given_I_Have_90_Return_XC()
        {
            // Given I have the value 90
            int number = 90;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XC"
            Assert.AreEqual("XC", roman);
        }

        [TestMethod]
        public void Given_I_Have_91_Return_XCI()
        {
            // Given I have the value 91
            int number = 91;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XCI"
            Assert.AreEqual("XCI", roman);
        }

        [TestMethod]
        public void Given_I_Have_95_Return_XCV()
        {
            // Given I have the value 95
            int number = 95;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "XCV"
            Assert.AreEqual("XCV", roman);
        }

        [TestMethod]
        public void Given_I_Have_100_Return_C()
        {
            // Given I have the value 100
            int number = 100;
            // When I pass the value in to the roman numeral converter
            IRomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            string roman = romanNumeralConverter.Convert(number);
            // I get back "C"
            Assert.AreEqual("C", roman);
        }
    }
}
