using JetBrains.Annotations;
using Marky;
using Xunit;

namespace Marky.Tests
{
    [TestSubject(typeof(Marky.HorizontalRule))]
    public class HorizontalRuleTest
    {
        [Fact]
        public void Star_ShouldReturnCorrectMarkdown()
        {
            // Act
            var result = Marky.HorizontalRule.Star();

            // Assert
            Assert.NotNull(result);
            Assert.Equal("***", result.ToString());
        }

        [Fact]
        public void Dash_ShouldReturnCorrectMarkdown()
        {
            // Act
            var result = Marky.HorizontalRule.Dash();

            // Assert
            Assert.NotNull(result);
            Assert.Equal("---", result.ToString());
        }

        [Fact]
        public void Underscore_ShouldReturnCorrectMarkdown()
        {
            // Act
            var result = Marky.HorizontalRule.Underscore();

            // Assert
            Assert.NotNull(result);
            Assert.Equal("___", result.ToString());
        }

        [Fact]
        public void Star_ShouldReturnNonEmptyMarkdown()
        {
            // Act
            var result = Marky.HorizontalRule.Star();

            // Assert
            Assert.False(string.IsNullOrWhiteSpace(result.ToString()));
        }

        [Fact]
        public void Dash_ShouldReturnNonEmptyMarkdown()
        {
            // Act
            var result = Marky.HorizontalRule.Dash();

            // Assert
            Assert.False(string.IsNullOrWhiteSpace(result.ToString()));
        }

        [Fact]
        public void Underscore_ShouldReturnNonEmptyMarkdown()
        {
            // Act
            var result = Marky.HorizontalRule.Underscore();

            // Assert
            Assert.False(string.IsNullOrWhiteSpace(result.ToString()));
        }

        [Fact]
        public void Star_ShouldInstanceMarkdownElement()
        {
            // Act
            var result = Marky.HorizontalRule.Star();

            // Assert
            Assert.IsType<MarkdownElement>(result);
        }

        [Fact]
        public void Dash_ShouldInstanceMarkdownElement()
        {
            // Act
            var result = Marky.HorizontalRule.Dash();

            // Assert
            Assert.IsType<MarkdownElement>(result);
        }

        [Fact]
        public void Underscore_ShouldInstanceMarkdownElement()
        {
            // Act
            var result = Marky.HorizontalRule.Underscore();

            // Assert
            Assert.IsType<MarkdownElement>(result);
        }
    }
}