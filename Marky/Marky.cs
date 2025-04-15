namespace Marky;

public static class MarkyConstants
{
    public const char Star = '*';
    public const char Dash = '-';
    public const char Underscore = '_';
    public const char NewLine = '\n';
    public const string Space = " ";
}

public static partial class Marky
{
    public static class Links
    {
        public static MarkdownElement Link(Text text, string url) =>
            new($"[{(text.IsEmpty ? url : text)}]({(string.IsNullOrWhiteSpace(url) ? string.Empty : url)})");
    }
}

public static partial class Marky
{
    public static MarkdownElement Italic(Text text) => new($"{MarkyConstants.Star}{text}{MarkyConstants.Star}");
    public static MarkdownElement Bold(Text text) => new($"{new string(MarkyConstants.Star, 2)}{text}{new string(MarkyConstants.Star, 2)}");
    public static MarkdownElement BoldItalic(Text text) => new($"{new string(MarkyConstants.Star, 3)}{text}{new string(MarkyConstants.Star, 3)}");
    public static MarkdownElement Image(Text text, string url) => new($"![{text}]({url})");
    public static MarkdownElement Blockquotes(Text text) => new($"> {text}");
}

public static partial class Marky
{
    public static class List
    {
        public static MarkdownElement Unordered(params MarkdownElement[] elements) =>
            MarkdownElement.Create(string.Join("\n", elements.Select(e => $"- {e}")));

        public static MarkdownElement Ordered(params MarkdownElement[] elements) =>
            MarkdownElement.Create(string.Join("\n", elements.Select((e, i) => $"{i + 1}. {e}")));
    }
}

public static partial class Marky
{
    public static class Headings
    {
        public static MarkdownElement Heading1(Text text) => new($"# {text}");
        public static MarkdownElement Heading2(Text text) => new($"## {text}");
        public static MarkdownElement Heading3(Text text) => new($"### {text}");
        public static MarkdownElement Heading4(Text text) => new($"#### {text}");
        public static MarkdownElement Heading5(Text text) => new($"##### {text}");
        public static MarkdownElement Heading6(Text text) => new($"###### {text}");
    }
}

public static partial class Marky
{
    public static class Code
    {
        public static MarkdownElement CodeBlock(Text text) => new($"```\n{text}\n```");
        public static MarkdownElement InlineCode(Text text) => new($"`{text}`");
    }
}

public static partial class Marky
{
    public static class HorizontalRule
    {
        public static MarkdownElement Star() => new("***");
        public static MarkdownElement Dash() => new("---");
        public static MarkdownElement Underscore() => new("___");
    }
}

public static partial class Marky
{
    public static class Tables
    {
        public static MarkdownElement Table(params MarkdownElement[] elements) =>
            MarkdownElement.Create(string.Join("\n", elements.Select(e => $"| {e} ")));

        public static MarkdownElement TableRow(params MarkdownElement[] elements) => elements.Length != 0
            ? MarkdownElement.Create($"|{string.Join(string.Empty, elements.Select(e => $" {e} |"))}")
            : new Text("");

        public static MarkdownElement TableHeader(params MarkdownElement[] elements) => elements.Length != 0
            ? MarkdownElement.Create($"|{string.Join(string.Empty, elements.Select(e => $" {e} |"))}")
            : new Text("");

        public static MarkdownElement TableHeaderDivider() => MarkdownElement.Create("| --- |");
        public static MarkdownElement TableDivider() => MarkdownElement.Create("| --- |");
        public static MarkdownElement TableCell(Text text) => new($"| {text} |");
    }
}

public static partial class Marky
{
    public static class Checkboxes
    {
        public static MarkdownElement Checkbox(Text text) => new($"- [ ] {text}");
        public static MarkdownElement CheckboxChecked(Text text) => new($"- [x] {text}");
    }
}