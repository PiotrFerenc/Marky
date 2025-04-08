using System.Dynamic;

namespace Marky;

public class MarkdownElement(string markdown)
{
    public override string ToString() => markdown;
};

public class Text(string text) : MarkdownElement(text)
{
    public static Text Create(string text) => new(text);
}