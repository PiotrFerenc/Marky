namespace Marky;

public static partial class Marky
{
    public static class Links
    {
        public static MarkdownElement Link(Text text, string url) => new($"[{(text.IsEmpty ? url : text)}]({(string.IsNullOrWhiteSpace(url) ? string.Empty : url)})");
    }
}

public static partial class Marky
{
    public static MarkdownElement Italic(Text text) => new($"*{text}*");
    public static MarkdownElement Bold(Text text) => new($"**{text}**");
    public static MarkdownElement BoldItalic(Text text) => new($"***{text}***");
    public static MarkdownElement Image(Text text, string url) => new($"![{text}]({url})");
    public static MarkdownElement Blockquotes(Text text) => new($"> {text}");
}

public static partial class Marky
{
    public static class List
    {
        public static MarkdownElement Unordered(params MarkdownElement[] elements) => MarkdownElement.Create(string.Join("\n", elements.Select(e => $"- {e}")));
        public static MarkdownElement Ordered(params MarkdownElement[] elements) => MarkdownElement.Create(string.Join("\n", elements.Select((e, i) => $"{i + 1}. {e}")));
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