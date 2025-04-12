using JetBrains.Annotations;
using Marky;
using Xunit;

namespace Marky.Tests;

[TestSubject(typeof(Marky.Links))]
public class LinksTest
{
    [Fact]
    public void Link_WithNonEmptyTextAndValidUrl_ShouldReturnProperMarkdown()
    {
        // Arrange
        var text = new Text("Click here");
        var url = "https://example.com";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.Equal("[Click here](https://example.com)", result.ToString());
    }

    [Fact]
    public void Link_WithEmptyTextAndValidUrl_ShouldUseUrlAsText()
    {
        // Arrange
        var text = Text.Create(string.Empty);
        var url = "https://example.com";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.Equal("[https://example.com](https://example.com)", result.ToString());
    }

    [Fact]
    public void Link_WithNonEmptyTextAndEmptyUrl_ShouldReturnEmptyUrlMarkdown()
    {
        // Arrange
        var text = new Text("Click here");
        var url = string.Empty;

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.Equal("[Click here]()", result.ToString());
    }

    [Fact]
    public void Link_WithEmptyTextAndEmptyUrl_ShouldReturnEmptyTextAndUrlMarkdown()
    {
        // Arrange
        var text = Text.Create(string.Empty);
        var url = string.Empty;

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.Equal("[]()", result.ToString());
    }

    [Fact]
    public void Link_WithWhitespaceTextAndValidUrl_ShouldUseUrlAsText()
    {
        // Arrange
        var text = Text.Create("   ");
        var url = "https://example.com";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.Equal("[https://example.com](https://example.com)", result.ToString());
    }

    [Fact]
    public void Link_WithNullUrl_ShouldTreatUrlAsEmpty()
    {
        // Arrange
        var text = new Text("Click here");
        string? url = null;

        // Act
        var result = Marky.Links.Link(text, url!);

        // Assert
        Assert.Equal("[Click here]()", result.ToString());
    }

    [Fact]
    public void Link_WithWhitespaceUrl_ShouldReturnEmptyUrlMarkdown()
    {
        // Arrange
        var text = new Text("Click here");
        var url = "   ";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.Equal("[Click here]()", result.ToString());
    }

    [Fact]
    public void Link_WithNonEmptyTextAndUrlContainingSpaces_ShouldPreserveUrlSpaces()
    {
        // Arrange
        var text = new Text("Click here");
        var url = "https://example.com/test path";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.Equal("[Click here](https://example.com/test path)", result.ToString());
    }
}