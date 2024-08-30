using NUnit.Framework;
using ReverseWords;

namespace Tests
{
    [TestFixture, Description("Reverse Words")]
    public class ReverseWordsTests
    {
        [Test, Description("Returns a string")]
        public void Returns_a_string()
        {
            Assert.That(Text.Reverse("Hello"), Is.InstanceOf(typeof(string)));   
        }
        [Test, Description("When passed one word, returns the word")]
        public void Returns_OneWord_Given_One_Word()
        {
            Assert.That(Text.Reverse("Hello"), Is.EqualTo("Hello"));
        }
        [Test, Description("When passed two words, returns them reversed")]
        public void Reverses_Two_Words()
        {
            Assert.That(Text.Reverse("Hello World"), Is.EqualTo("World Hello"));
        }
        [Test, Description("When passed more than two words, returns the reverse")]
        public void Reverses_word_order()
        {
            Assert.That(Text.Reverse("Hello toby cat"), Is.EqualTo("cat toby Hello"));
        }
    }
}