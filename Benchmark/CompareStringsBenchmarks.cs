using BenchmarkDotNet.Attributes;

namespace Benchmark;

public class CompareStringsBenchmarks
{
    public string nomeV1 = "PauloDev";
    public string nomeV2 = "pAULOdEV";

    [Benchmark]
    public bool EqualWithToLower()
    {
        return nomeV1.ToLower() == nomeV2.ToLower();
    }

    [Benchmark]
    public bool EqualWithToUpper()
    {
        return nomeV1.ToUpper() == nomeV2.ToUpper();
    }

    [Benchmark]
    public bool CompareWithIgnoreCase()
    {
        return string.Compare(nomeV1, nomeV2, StringComparison.OrdinalIgnoreCase) == 0;
    }

    [Benchmark]
    public bool EqualIgnoreCase()
    {
        return nomeV1.Equals(nomeV2, StringComparison.OrdinalIgnoreCase);
    }
}