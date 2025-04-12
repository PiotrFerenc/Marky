using JetBrains.Annotations;
using Marky;
using Xunit;

namespace Marky.Tests;

[TestSubject(typeof(Marky.Tables))]
public class TablesTest
{
    [Fact]
    public void Table_WithValidElements_ReturnsCorrectMarkdown()
    {
        // Arrange
        var element1 = new MarkdownElement("Column1");
        var element2 = new MarkdownElement("Column2");
        var element3 = new MarkdownElement("Column3");

        // Act
        var result = Marky.Tables.Table(element1, element2, element3);

        // Assert
        Assert.Equal("| Column1 \n| Column2 \n| Column3 ", result.ToString());
    }

    [Fact]
    public void TableRow_WithValidElements_ReturnsCorrectMarkdown()
    {
        // Arrange
        var element1 = new MarkdownElement("Row1");
        var element2 = new MarkdownElement("Row2");

        // Act
        var result = Marky.Tables.TableRow(element1, element2);

        // Assert
        Assert.Equal("| Row1 | Row2 ", result.ToString());
    }

    [Fact]
    public void TableHeader_WithValidElements_ReturnsCorrectMarkdown()
    {
        // Arrange
        var column1 = new MarkdownElement("Header1");
        var column2 = new MarkdownElement("Header2");

        // Act
        var result = Marky.Tables.TableHeader(column1, column2);

        // Assert
        Assert.Equal("| Header1 | Header2 |", result.ToString());
    }

    [Fact]
    public void TableHeaderDivider_ReturnsCorrectMarkdown()
    {
        // Act
        var result = Marky.Tables.TableHeaderDivider();

        // Assert
        Assert.Equal("| --- |", result.ToString());
    }

    [Fact]
    public void TableDivider_ReturnsCorrectMarkdown()
    {
        // Act
        var result = Marky.Tables.TableDivider();

        // Assert
        Assert.Equal("| --- |", result.ToString());
    }

    [Fact]
    public void TableCell_WithText_ReturnsCorrectMarkdown()
    {
        // Arrange
        var text = new Text("Cell Content");

        // Act
        var result = Marky.Tables.TableCell(text);

        // Assert
        Assert.Equal("| Cell Content |", result.ToString());
    }

    [Fact]
    public void Table_WithNoElements_ReturnsEmptyString()
    {
        // Act
        var result = Marky.Tables.Table();

        // Assert
        Assert.Equal(string.Empty, result.ToString());
    }

    [Fact]
    public void TableRow_WithNoElements_ReturnsEmptyString()
    {
        // Act
        var result = Marky.Tables.TableRow();

        // Assert
        Assert.Equal(string.Empty, result.ToString());
    }

    [Fact]
    public void TableHeader_WithNoElements_ReturnsEmptyString()
    {
        // Act
        var result = Marky.Tables.TableHeader();

        // Assert
        Assert.Equal(string.Empty, result.ToString());
    }
}