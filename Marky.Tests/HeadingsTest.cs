using JetBrains.Annotations;

namespace Marky.Tests;

[TestSubject(typeof(Marky.Headings))]
public class HeadingsTest
{
    [Theory]
    [InlineData("Heading 1 text", "# Heading 1 text")]
    [InlineData("Another heading text", "# Another heading text")]
    [InlineData("", "# ")]
    [InlineData(null, "# ")] // Null text input
    public void Heading1_ShouldGenerateCorrectMarkdown(string input, string expected)
    {
        // Arrange
        var text = input is null ? null : Text.Create(input);

        // Act
        var result = Marky.Headings.Heading1(text);

        // Assert
        Assert.Equal(expected, result.ToString());
    }

    [Theory]
    [InlineData("Heading 2 text", "## Heading 2 text")]
    [InlineData("Another heading text", "## Another heading text")]
    [InlineData("", "## ")]
    [InlineData(null, "## ")] // Null text input
    public void Heading2_ShouldGenerateCorrectMarkdown(string input, string expected)
    {
        // Arrange
        var text = input is null ? null : Text.Create(input);

        // Act
        var result = Marky.Headings.Heading2(text);

        // Assert
        Assert.Equal(expected, result.ToString());
    }

    [Theory]
    [InlineData("Heading 3 text", "### Heading 3 text")]
    [InlineData("Another heading text", "### Another heading text")]
    [InlineData("", "### ")]
    [InlineData(null, "### ")] // Null text input
    public void Heading3_ShouldGenerateCorrectMarkdown(string input, string expected)
    {
        // Arrange
        var text = input is null ? null : Text.Create(input);

        // Act
        var result = Marky.Headings.Heading3(text);

        // Assert
        Assert.Equal(expected, result.ToString());
    }

    [Theory]
    [InlineData("Heading 4 text", "#### Heading 4 text")]
    [InlineData("Another heading text", "#### Another heading text")]
    [InlineData("", "#### ")]
    [InlineData(null, "#### ")] // Null text input
    public void Heading4_ShouldGenerateCorrectMarkdown(string input, string expected)
    {
        // Arrange
        var text = input is null ? null : Text.Create(input);

        // Act
        var result = Marky.Headings.Heading4(text);

        // Assert
        Assert.Equal(expected, result.ToString());
    }

    [Theory]
    [InlineData("Heading 5 text", "##### Heading 5 text")]
    [InlineData("Another heading text", "##### Another heading text")]
    [InlineData("", "##### ")]
    [InlineData(null, "##### ")] // Null text input
    public void Heading5_ShouldGenerateCorrectMarkdown(string input, string expected)
    {
        // Arrange
        var text = input is null ? null : Text.Create(input);

        // Act
        var result = Marky.Headings.Heading5(text);

        // Assert
        Assert.Equal(expected, result.ToString());
    }

    [Theory]
    [InlineData("Heading 6 text", "###### Heading 6 text")]
    [InlineData("Another heading text", "###### Another heading text")]
    [InlineData("", "###### ")]
    [InlineData(null, "###### ")] // Null text input
    public void Heading6_ShouldGenerateCorrectMarkdown(string input, string expected)
    {
        // Arrange
        var text = input is null ? null : Text.Create(input);

        // Act
        var result = Marky.Headings.Heading6(text);

        // Assert
        Assert.Equal(expected, result.ToString());
    }
}