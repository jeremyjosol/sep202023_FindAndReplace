using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;


namespace FindAndReplace.Tests
{
  [TestClass]
  public class FindAndReplaceTests
  {
    [TestMethod]
    public void WordReplacer_SplitsUserInputIntoArray_String()
    {
      string userInput = "Hello sir"; // example input, imitates UI logic
      string result = FindAndReplaceWord.WordReplacer(userInput);
      Assert.AreEqual("Hello sir", result);
    }
    [TestMethod]
    public void WordReplacer_FindCorrectWord_String()
    {
      string userInput = "Hello sir";
      string findWord = "sir";
      string result = FindAndReplaceWord.WordReplacer(userInput, findWord);
      Assert.AreEqual("true", result);
    }

    [TestMethod]
    public void WordReplacer_FindWordAndReplaceWith_String()
    {
      string userInput = "Hello sir";
      string findWord = "sir";
      string replacedWith = "maam";
      string result = FindAndReplaceWord.WordReplacer(userInput, findWord, replacedWith);
      Assert.AreEqual("Hello maam", result);
    }

    [TestMethod]
    public void WordReplacer_FindAllWordOccurencesAndReplaceWith_String()
    {
      string userInput = "Hello sir how are yousir";
      string findWord = "sir";
      string replacedWith = "maam";
      string result = FindAndReplaceWord.WordReplacer(userInput, findWord, replacedWith);
      Assert.AreEqual("Hello maam", result);
    }
  }
}