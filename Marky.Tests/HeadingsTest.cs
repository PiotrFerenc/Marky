using JetBrains.Annotations;
using Marky;
using Xunit;

namespace Marky.Tests;

[TestSubject(typeof(Marky.Headings))]
public class HeadingsTest
{
    [Fact]
    public void Heading1_GeneratesCorrectMarkdown()
    {
        // Arrange
        var text = Text.Create("Heading1");

        // Act
        var result = Marky.Headings.Heading1(text);

        // Assert
        Assert.Equal("# Heading1", result.ToString());
    }

    [Fact]
    public void Heading2_GeneratesCorrectMarkdown()
    {
        // Arrange
        var text = Text.Create("Heading2");

        // Act
        var result = Marky.Headings.Heading2(text);

        // Assert
        Assert.Equal("## Heading2", result.ToString());
    }

    [Fact]
    public void Heading3_GeneratesCorrectMarkdown()
    {
        // Arrange
        var text = Text.Create("Heading3");

        // Act
        var result = Marky.Headings.Heading3(text);

        // Assert
        Assert.Equal("### Heading3", result.ToString());
    }

    [Fact]
    public void Heading4_GeneratesCorrectMarkdown()
    {
        // Arrange
        var text = Text.Create("Heading4");

        // Act
        var result = Marky.Headings.Heading4(text);

        // Assert
        Assert.Equal("#### Heading4", result.ToString());
    }

    [Fact]
    public void Heading5_GeneratesCorrectMarkdown()
    {
        // Arrange
        var text = Text.Create("Heading5");

        // Act
        var result = Marky.Headings.Heading5(text);

        // Assert
        Assert.Equal("##### Heading5", result.ToString());
    }

    [Fact]
    public void Heading6_GeneratesCorrectMarkdown()
    {
        // Arrange
        var text = Text.Create("Heading6");

        // Act
        var result = Marky.Headings.Heading6(text);

        // Assert
        Assert.Equal("###### Heading6", result.ToString());
    }

    [Fact]
    public void Headings_HandleEmptyText()
    {
        // Arrange
        var emptyText = Text.Create("");

        // Act
        var h1 = Marky.Headings.Heading1(emptyText).ToString();
        var h2 = Marky.Headings.Heading2(emptyText).ToString();
        var h3 = Marky.Headings.Heading3(emptyText).ToString();
        var h4 = Marky.Headings.Heading4(emptyText).ToString();
        var h5 = Marky.Headings.Heading5(emptyText).ToString();
        var h6 = Marky.Headings.Heading6(emptyText).ToString();

        // Assert
        Assert.Equal("# ", h1);
        Assert.Equal("## ", h2);
        Assert.Equal("### ", h3);
        Assert.Equal("#### ", h4);
        Assert.Equal("##### ", h5);
        Assert.Equal("###### ", h6);
    }

    [Fact]
    public void Headings_HandleNullText()
    {
        // Arrange & Act
        var h1 = Marky.Headings.Heading1(null).ToString();
        var h2 = Marky.Headings.Heading2(null).ToString();
        var h3 = Marky.Headings.Heading3(null).ToString();
        var h4 = Marky.Headings.Heading4(null).ToString();
        var h5 = Marky.Headings.Heading5(null).ToString();
        var h6 = Marky.Headings.Heading6(null).ToString();

        // Assert
        Assert.Equal("# ", h1);
        Assert.Equal("## ", h2);
        Assert.Equal("### ", h3);
        Assert.Equal("#### ", h4);
        Assert.Equal("##### ", h5);
        Assert.Equal("###### ", h6);
    }

    [Fact]
    public void Headings_HandleWhitespaceText()
    {
        // Arrange
        var whitespaceText = Text.Create("   ");

        // Act
        var h1 = Marky.Headings.Heading1(whitespaceText).ToString();
        var h2 = Marky.Headings.Heading2(whitespaceText).ToString();
        var h3 = Marky.Headings.Heading3(whitespaceText).ToString();
        var h4 = Marky.Headings.Heading4(whitespaceText).ToString();
        var h5 = Marky.Headings.Heading5(whitespaceText).ToString();
        var h6 = Marky.Headings.Heading6(whitespaceText).ToString();

        // Assert
        Assert.Equal("#    ", h1);
        Assert.Equal("##    ", h2);
        Assert.Equal("###    ", h3);
        Assert.Equal("####    ", h4);
        Assert.Equal("#####    ", h5);
        Assert.Equal("######    ", h6);
    }

    [Theory]
    [InlineData("Short")]
    [InlineData("This is a longer heading")]
    [InlineData("1234567890")]
    [InlineData("!@#$%^&*()-=_+[]{}|;':\",.<>?/`~")]
    public void Headings_HandleVariousTexts(string textContent)
    {
        // Arrange
        var text = Text.Create(textContent);

        // Act
        var h1 = Marky.Headings.Heading1(text).ToString();
        var h2 = Marky.Headings.Heading2(text).ToString();
        var h3 = Marky.Headings.Heading3(text).ToString();
        var h4 = Marky.Headings.Heading4(text).ToString();
        var h5 = Marky.Headings.Heading5(text).ToString();
        var h6 = Marky.Headings.Heading6(text).ToString();

        // Assert
        Assert.Equal($"# {textContent}", h1);
        Assert.Equal($"## {textContent}", h2);
        Assert.Equal($"### {textContent}", h3);
        Assert.Equal($"#### {textContent}", h4);
        Assert.Equal($"##### {textContent}", h5);
        Assert.Equal($"###### {textContent}", h6);
    }
}