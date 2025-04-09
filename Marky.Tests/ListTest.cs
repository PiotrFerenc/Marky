using JetBrains.Annotations;
using Marky;
using Xunit;

namespace Marky.Tests;

[TestSubject(typeof(Marky.List))]
public class ListTest
{
    [Fact]
    public void Unordered_WithNoElements_ReturnsEmptyString()
    {
        // Arrange
        var elements = Array.Empty<MarkdownElement>();

        // Act
        var result = Marky.List.Unordered(elements);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(string.Empty, result.ToString());
    }

    [Fact]
    public void Unordered_WithSingleElement_ReturnsFormattedElement()
    {
        // Arrange
        var element = new MarkdownElement("Item1");

        // Act
        var result = Marky.List.Unordered(element);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("- Item1", result.ToString());
    }

    [Fact]
    public void Unordered_WithMultipleElements_ReturnsFormattedList()
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
        Assert.NotNull(result);
        Assert.Equal("- Item1\n- Item2\n- Item3", result.ToString());
    }

    [Fact]
    public void Unordered_WithNullElement_ThrowsArgumentNullException()
    {
        // Arrange
        MarkdownElement[] elements = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Marky.List.Unordered(elements));
    }

    [Fact]
    public void Unordered_WithEmptyElementContent_HandlesCorrectly()
    {
        // Arrange
        var elements = new[]
        {
            new MarkdownElement("Item1"),
            new MarkdownElement(string.Empty),
            new MarkdownElement("Item3")
        };

        // Act
        var result = Marky.List.Unordered(elements);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("- Item1\n- \n- Item3", result.ToString());
    }
}