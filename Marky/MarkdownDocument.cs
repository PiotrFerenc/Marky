using System.Text;

namespace Marky;

public static class MarkdownDocument
{
    public static string Build(params MarkdownElement[] elements)
    {
        var builder = new StringBuilder();
        foreach (var element in elements)
        {
            builder.AppendLine(element.ToString());
        }

        return builder.ToString();
    }
}