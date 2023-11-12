using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] toBlur = new string[] {"donkey"};
        string text = "Fox jumps over the lazy fox, until the other fox is away";
        // Act
        string result = TextFilter.Filter(toBlur, text);
        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {

        string[] toBlur = new string[] {"fox"};
        string text = "Fox jumps over the lazy fox, until the other fox is away";
        // Act
        string result = TextFilter.Filter(toBlur, text);
        // Assert
        Assert.That(result, Is.EqualTo("Fox jumps over the lazy ***, until the other *** is away"));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] toBlur = new string[] { };
        string text = "Fox jumps over the lazy fox, until the other fox is away";
        // Act
        string result = TextFilter.Filter(toBlur, text);
        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        string[] toBlur = new string[] { "lazy fox", "away" };
        string text = "Fox jumps over the lazy fox, until the other fox is away";
        // Act
        string result = TextFilter.Filter(toBlur, text);
        // Assert
        Assert.That(result, Is.EqualTo("Fox jumps over the ********, until the other fox is ****"));
    }
}
