using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1_Anagram.Tests;

[TestClass]
[TestSubject(typeof(Program))]
public class AnagramTest
{
    [TestMethod]
    public void ReversWord_ValidWord_ReturnsReversWord()
    {
        string reversedWord = Anagram.ReversedWord("Hello");
        Assert.AreEqual("olleH", reversedWord);
    }

    [TestMethod]
        
    public void Revers_ValidWord_ReturnsRevers()
    {
        string reversedSentence = Anagram.ReversedWord("Hello World!");
        Assert.AreEqual("!dlroW olleH", reversedSentence);
    }

    [TestMethod]
    public void TestReverseWord_WithNonAlnon_alphabetic_characters()
    {
        string reversedWord = Anagram.ReversedWord("123abc!412");
        Assert.AreEqual("214!cba321", reversedWord);
    }
    
    
    [TestMethod]
    public void ReverseWord_NullWord_ReturnsNull()
    {
        string reversedWord = Anagram.ReversedWord(null);
        Assert.IsNull(reversedWord);
    }

    [TestMethod]
    public void Reverse_NullWord_ReturnsNull()
    {
        string reversedSetence = Anagram.Reverse(null);
        Assert.IsNull(reversedSetence);
    }
    
    [TestMethod]
    public void ReverseWord_WordWithNoAlphabets_ReturnsWord()
    {
        string reversedWord = Anagram.ReversedWord("1234");
        Assert.AreEqual("4321", reversedWord);
    }
}