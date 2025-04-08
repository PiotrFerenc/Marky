namespace Marky;

public static class Marky
{
    public static class Headings
    {
        public static MarkdownElement Heading1(string text) => new($"# {text}");
        public static MarkdownElement Heading2(string text) => new($"## {text}");
        public static MarkdownElement Heading3(string text) => new($"### {text}");
        public static MarkdownElement Heading4(string text) => new($"#### {text}");
        public static MarkdownElement Heading5(string text) => new($"##### {text}");
        public static MarkdownElement Heading6(string text) => new($"###### {text}");
    }

    public static MarkdownElement Italic(string text) => new($"*{text}*");
    public static MarkdownElement Bold(string text) => new($"**{text}**");
    public static MarkdownElement BoldItalic(string text) => new($"***{text}***");
}