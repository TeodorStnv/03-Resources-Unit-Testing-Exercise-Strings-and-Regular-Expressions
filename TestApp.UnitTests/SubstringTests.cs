using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(result, Is.EqualTo("The quick brown jumps over the lazy dog"));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "fox";
        string input = "Fox jumps over the lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(result, Is.EqualTo("jumps over the lazy dog"));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "fox";
        string input = "Dog jumps over the lazy fox";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(result, Is.EqualTo("Dog jumps over the lazy"));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "fox";
        string input = "Fox jumps over the lazy fox, until the other fox is away";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(result, Is.EqualTo("jumps over the lazy , until the other is away"));
    }
}
