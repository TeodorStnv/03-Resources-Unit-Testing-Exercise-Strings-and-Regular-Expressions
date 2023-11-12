using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));

        
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        string[] input = new string[] { "baba" };
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        // Assert
        Assert.That(result, Is.EqualTo("baba"));

       
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        string[] input = new string[] { "abc", "kaka" };
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        // Assert
        Assert.That(result, Is.EqualTo("kakaabc"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        string[] input = null;
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {

        string[] input = new string[] { "abc", " ", "kaka" };
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        // Assert
        Assert.That(result, Is.EqualTo("kaka abc"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        string[] input = new string[] { "abc", "kaka", "mama", "one", "two", "three"};
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        // Assert
        Assert.That(result, Is.EqualTo("threetwoonemamakakaabc"));
    }
}
