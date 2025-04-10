using JetBrains.Annotations;

namespace Marky.Tests;

[TestSubject(typeof(Marky))]
public class MarkyListTest
{
    [Fact]
    public void Italic_ShouldWrapTextWithAsterisks()
    {
        // Arrange
        var inputText = Text.Create("example");

        // Act
        var result = Marky.Italic(inputText);

        // Assert
        Assert.Equal("*example*", result.ToString());
    }

    [Fact]
    public void Bold_ShouldWrapTextWithDoubleAsterisks()
    {
        // Arrange
        var inputText = Text.Create("example");

        // Act
        var result = Marky.Bold(inputText);

        // Assert
        Assert.Equal("**example**", result.ToString());
    }

    [Fact]
    public void BoldItalic_ShouldWrapTextWithTripleAsterisks()
    {
        // Arrange
        var inputText = Text.Create("example");

        // Act
        var result = Marky.BoldItalic(inputText);

        // Assert
        Assert.Equal("***example***", result.ToString());
    }

    [Fact]
    public void List_Unordered_ShouldGenerateBulletList()
    {
        // Arrange
        var elements = new MarkdownElement[]
        {
            new Text("item1"),
            new Text("item2"),
            new Text("item3")
        };

        // Act
        var result = Marky.List.Unordered(elements);

        // Assert
        var expected = "- item1\n- item2\n- item3";
        Assert.Equal(expected, result.ToString());
    }

    [Fact]
    public void List_Ordered_ShouldGenerateNumberedList()
    {
        // Arrange
        var elements = new MarkdownElement[]
        {
            new Text("item1"),
            new Text("item2"),
            new Text("item3")
        };

        // Act
        var result = Marky.List.Ordered(elements);

        // Assert
        var expected = "1. item1\n2. item2\n3. item3";
        Assert.Equal(expected, result.ToString());
    }

    [Fact]
    public void Headings_Heading1_ShouldGenerateHeading1()
    {
        // Arrange
        var inputText = Text.Create("Heading 1");

        // Act
        var result = Marky.Headings.Heading1(inputText);

        // Assert
        Assert.Equal("# Heading 1", result.ToString());
    }

    [Fact]
    public void Headings_Heading2_ShouldGenerateHeading2()
    {
        // Arrange
        var inputText = Text.Create("Heading 2");

        // Act
        var result = Marky.Headings.Heading2(inputText);

        // Assert
        Assert.Equal("## Heading 2", result.ToString());
    }

    [Fact]
    public void Headings_Heading3_ShouldGenerateHeading3()
    {
        // Arrange
        var inputText = Text.Create("Heading 3");

        // Act
        var result = Marky.Headings.Heading3(inputText);

        // Assert
        Assert.Equal("### Heading 3", result.ToString());
    }

    [Fact]
    public void Headings_Heading4_ShouldGenerateHeading4()
    {
        // Arrange
        var inputText = Text.Create("Heading 4");

        // Act
        var result = Marky.Headings.Heading4(inputText);

        // Assert
        Assert.Equal("#### Heading 4", result.ToString());
    }

    [Fact]
    public void Headings_Heading5_ShouldGenerateHeading5()
    {
        // Arrange
        var inputText = Text.Create("Heading 5");

        // Act
        var result = Marky.Headings.Heading5(inputText);

        // Assert
        Assert.Equal("##### Heading 5", result.ToString());
    }

    [Fact]
    public void Headings_Heading6_ShouldGenerateHeading6()
    {
        // Arrange
        var inputText = Text.Create("Heading 6");

        // Act
        var result = Marky.Headings.Heading6(inputText);

        // Assert
        Assert.Equal("###### Heading 6", result.ToString());
    }
}