using System.Globalization;
using BenchmarkDotNet.Attributes;

namespace Benchmark;

public class CompareDatesBenchmarks
{
    public DateTime dateV1 = DateTime.Now;
    public DateTime dateV2 = DateTime.Now.AddDays(-1);
    
    [Benchmark]
    public bool CompareWithAcessors()
    {
        return dateV1.Date == dateV2.Date && dateV1.Month == dateV2.Month && dateV1.Year == dateV2.Year;
    }
    
    [Benchmark]
    public bool CompareWithOperatorString()
    {
        return dateV1.ToString("yyyy-MM-dd") == dateV2.ToString("yyyy-MM-dd");
    }
    
    [Benchmark]
    public bool CompareWithOperatorStringAndCulture()
    {
        return dateV1.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) == dateV2.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
    }

    [Benchmark]
    public bool CompareWithShortDateString()
    {
        return dateV1.ToShortDateString() == dateV2.ToShortDateString();
    }

    [Benchmark]
    public bool CompareWithShortDateStringAndEqual()
    {
        return dateV1.ToShortDateString().Equals(dateV2.ToShortDateString());
    }
}