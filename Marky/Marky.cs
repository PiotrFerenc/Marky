namespace Marky;

public static class Marky
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

    public static class List
    {
        public static MarkdownElement Unordered(params MarkdownElement[] elements) =>
            new(string.Join("\n", elements.Select(e => $"- {e}")));
        
        
    }

    public static MarkdownElement Italic(Text text) => new($"*{text}*");
    public static MarkdownElement Bold(Text text) => new($"**{text}**");
    public static MarkdownElement BoldItalic(Text text) => new($"***{text}***");
}