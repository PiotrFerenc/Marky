using JetBrains.Annotations;
using Marky;
using Xunit;

namespace Marky.Tests;

[TestSubject(typeof(Marky.Checkboxes))]
public class CheckboxesTest
{
    [Fact]
    public void Checkbox_ShouldReturnUncheckedCheckbox_WhenTextIsProvided()
    {
        // Arrange
        var text = new Text("Todo");

        // Act
        var result = Marky.Checkboxes.Checkbox(text);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("- [ ] Todo", result.ToString());
    }

    [Fact]
    public void Checkbox_ShouldReturnUncheckedCheckbox_WhenTextIsEmpty()
    {
        // Arrange
        var text = Text.Create(string.Empty);

        // Act
        var result = Marky.Checkboxes.Checkbox(text);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("- [ ] ", result.ToString());
    }

    [Fact]
    public void Checkbox_ShouldReturnUncheckedCheckbox_WhenTextIsNull()
    {
        // Act
        var result = Marky.Checkboxes.Checkbox(null);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("- [ ] ", result.ToString());
    }

    [Fact]
    public void CheckboxChecked_ShouldReturnCheckedCheckbox_WhenTextIsProvided()
    {
        // Arrange
        var text = new Text("Done");

        // Act
        var result = Marky.Checkboxes.CheckboxChecked(text);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("- [x] Done", result.ToString());
    }

    [Fact]
    public void CheckboxChecked_ShouldReturnCheckedCheckbox_WhenTextIsEmpty()
    {
        // Arrange
        var text = Text.Create(string.Empty);

        // Act
        var result = Marky.Checkboxes.CheckboxChecked(text);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("- [x] ", result.ToString());
    }

    [Fact]
    public void CheckboxChecked_ShouldReturnCheckedCheckbox_WhenTextIsNull()
    {
        // Act
        var result = Marky.Checkboxes.CheckboxChecked(null);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("- [x] ", result.ToString());
    }
}