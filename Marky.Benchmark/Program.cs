using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Marky;

BenchmarkRunner.Run<BoldItalicBenchmark>();

public class BoldItalicBenchmark
{
    private Text _sampleText;

    [GlobalSetup]
    public void Setup()
    {
        _sampleText = new Text("Sample text for bold italic!");
    }

    [Benchmark]
    public MarkdownElement BenchmarkBoldItalic()
    {
        return Marky.Marky.BoldItalic(_sampleText);
    }
}
