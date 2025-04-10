using JetBrains.Annotations;
using Marky;

namespace Marky.Tests;

[TestSubject(typeof(Marky.Links))]
public class MarkyLinksTest
{
    [Fact]
    public void Link_ValidInputs_ShouldReturnCorrectMarkdown()
    {
        // Arrange
        var text = new Text("example");
        var url = "http://example.com";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("[example](http://example.com)", result.ToString());
    }

    [Fact]
    public void Link_EmptyText_ShouldReturnMarkdownWithUrlTextPlaceholder()
    {
        // Arrange
        var text = new Text("");
        var url = "http://example.com";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("[http://example.com](http://example.com)", result.ToString());
    }

    [Fact]
    public void Link_EmptyUrl_ShouldReturnMarkdownWithEmptyUrlPlaceholder()
    {
        // Arrange
        var text = new Text("example");
        var url = "";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("[example]()", result.ToString());
    }


    [Fact]
    public void Link_SpecialCharactersInText_ShouldReturnValidMarkdown()
    {
        // Arrange
        var text = new Text("exa[m]ple");
        var url = "http://example.com";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(@"[exa[m]ple](http://example.com)", result.ToString());
    }

    [Fact]
    public void Link_SpecialCharactersInUrl_ShouldReturnValidMarkdown()
    {
        // Arrange
        var text = new Text("example");
        var url = "http://exa[m]ple.com";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("[example](http://exa[m]ple.com)", result.ToString());
    }

    [Fact]
    public void Link_LongText_ShouldReturnValidMarkdown()
    {
        // Arrange
        var text = new Text(new string('a', 1000));
        var url = "http://example.com";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.NotNull(result);
        Assert.Equal($"[{new string('a', 1000)}](http://example.com)", result.ToString());
    }

    [Fact]
    public void Link_LongUrl_ShouldReturnValidMarkdown()
    {
        // Arrange
        var text = new Text("example");
        var url = "http://" + new string('b', 1000) + ".com";

        // Act
        var result = Marky.Links.Link(text, url);

        // Assert
        Assert.NotNull(result);
        Assert.Equal($"[example](http://{new string('b', 1000)}.com)", result.ToString());
    }
}