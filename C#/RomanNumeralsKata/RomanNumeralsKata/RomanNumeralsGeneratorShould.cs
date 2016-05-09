using NUnit.Framework;

namespace RomanNumeralsKata
{
    [TestFixture]
    class RomanNumeralsGeneratorShould
    {
        [Test]
        public void Generate_roman_numeral_for_a_decimal()
        {
            Assert.AreEqual("I", RomanNumeralsGenerator.ToNumeral(1));
            Assert.AreEqual("II", RomanNumeralsGenerator.ToNumeral(2));
            Assert.AreEqual("III", RomanNumeralsGenerator.ToNumeral(3));
            Assert.AreEqual("IV", RomanNumeralsGenerator.ToNumeral(4));
            Assert.AreEqual("V", RomanNumeralsGenerator.ToNumeral(5));
            Assert.AreEqual("VII", RomanNumeralsGenerator.ToNumeral(7));
            Assert.AreEqual("IX", RomanNumeralsGenerator.ToNumeral(9));
            Assert.AreEqual("X", RomanNumeralsGenerator.ToNumeral(10));
            Assert.AreEqual("XX", RomanNumeralsGenerator.ToNumeral(20));
            Assert.AreEqual("XLIX", RomanNumeralsGenerator.ToNumeral(49));
            Assert.AreEqual("LXVI", RomanNumeralsGenerator.ToNumeral(66));
            Assert.AreEqual("MDXII", RomanNumeralsGenerator.ToNumeral(1512));
            Assert.AreEqual("MCMXXXIV", RomanNumeralsGenerator.ToNumeral(1934));
        }
    }
}
