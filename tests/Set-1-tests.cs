using NUnit.Framework;
using ReverseWords;
using Palindrome;

namespace SetOneTests
{
    [TestFixture, Description("Reverse Words")]
    public class ReverseWordsTests
    {
        [Test, Description("Returns a string")]
        public void Returns_a_string()
        {
            Assert.That(ReverseWordsKata.Reverse("Hello"), Is.InstanceOf(typeof(string)));
        }
        [Test, Description("When passed one word, returns the word")]
        public void Returns_OneWord_Given_One_Word()
        {
            Assert.That(ReverseWordsKata.Reverse("Hello"), Is.EqualTo("Hello"));
        }
        [Test, Description("When passed two words, returns them reversed")]
        public void Reverses_Two_Words()
        {
            Assert.That(ReverseWordsKata.Reverse("Hello World"), Is.EqualTo("World Hello"));
        }
        [Test, Description("When passed more than two words, returns the reverse")]
        public void Reverses_Word_Order()
        {
            Assert.That(ReverseWordsKata.Reverse("Hello toby cat"), Is.EqualTo("cat toby Hello"));
        }
    }


    //Assumptions
    //never empty

    [TestFixture, Description("Palindrome")]
    public class PalindromeTests
    {
        [Test, Description("returns a boolean")]
        public void Returns_a_string()
        {
            Assert.That(PalindromeKata.IsPalindrome("hello"), Is.InstanceOf(typeof(bool)));
        }
        [Test, Description("returns false passed a non-palindrome")]
        public void False_When_Not_Palindrome()
        {
            Assert.That(PalindromeKata.IsPalindrome("hello"), Is.EqualTo(false));
        }
        [Test, Description("returns true passed a palindrome")]
        public void True_When_Palindrome()
        {
            Assert.That(PalindromeKata.IsPalindrome("racecar"), Is.EqualTo(true));
        }
        [Test, Description("Ignores case")]
        public void Ignores_Case()
        {
            Assert.That(PalindromeKata.IsPalindrome("RaceCar"), Is.EqualTo(true));
        }
        [Test, Description("Works for numbers and symbols")]
        public void Works_With_Nums_And_Symbols()
        {
            Assert.That(PalindromeKata.IsPalindrome("22/22/22"), Is.EqualTo(true));
        }
    }
}