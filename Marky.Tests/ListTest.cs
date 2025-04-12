using System.Linq;
using JetBrains.Annotations;
using Xunit;
using Marky;

namespace Marky.Tests;

[TestSubject(typeof(Marky.List))]
public class ListTest
{
    [Fact]
    public void Unordered_ShouldReturnCorrectMarkdown_ForSingleElement()
    {
        // Arrange
        var element = new MarkdownElement("Item1");

        // Act
        var result = Marky.List.Unordered(element);

        // Assert
        Assert.Equal("- Item1", result.ToString());
    }

    [Fact]
    public void Unordered_ShouldReturnCorrectMarkdown_ForMultipleElements()
    {
        // Arrange
        var elements = new[]
        {
            new MarkdownElement("Item1"),
            new MarkdownElement("Item2"),
            new MarkdownElement("Item3")
        };

        // Act
        var result = Marky.List.Unordered(elements);

        // Assert
        var expected = "- Item1\n- Item2\n- Item3";
        Assert.Equal(expected, result.ToString());
    }

    [Fact]
    public void Unordered_ShouldHandleEmptyElementsArray()
    {
        // Arrange
        var elements = Array.Empty<MarkdownElement>();

        // Act
        var result = Marky.List.Unordered(elements);

        // Assert
        Assert.Equal(string.Empty, result.ToString());
    }

    [Fact]
    public void Ordered_ShouldReturnCorrectMarkdown_ForSingleElement()
    {
        // Arrange
        var element = new MarkdownElement("Item1");

        // Act
        var result = Marky.List.Ordered(element);

        // Assert
        Assert.Equal("1. Item1", result.ToString());
    }

    [Fact]
    public void Ordered_ShouldReturnCorrectMarkdown_ForMultipleElements()
    {
        // Arrange
        var elements = new[]
        {
            new MarkdownElement("Item1"),
            new MarkdownElement("Item2"),
            new MarkdownElement("Item3")
        };

        // Act
        var result = Marky.List.Ordered(elements);

        // Assert
        var expected = "1. Item1\n2. Item2\n3. Item3";
        Assert.Equal(expected, result.ToString());
    }

    [Fact]
    public void Ordered_ShouldHandleEmptyElementsArray()
    {
        // Arrange
        var elements = Array.Empty<MarkdownElement>();

        // Act
        var result = Marky.List.Ordered(elements);

        // Assert
        Assert.Equal(string.Empty, result.ToString());
    }

    [Fact]
    public void Unordered_ShouldHandleNullElement()
    {
        // Arrange
        MarkdownElement[] elements = { null };

        // Act
        var result = Marky.List.Unordered(elements);

        // Assert
        Assert.Equal("- ", result.ToString());
    }

    [Fact]
    public void Ordered_ShouldHandleNullElement()
    {
        // Arrange
        MarkdownElement[] elements = { null };

        // Act
        var result = Marky.List.Ordered(elements);

        // Assert
        Assert.Equal("1. ", result.ToString());
    }
}