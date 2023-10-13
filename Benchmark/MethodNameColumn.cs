using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    public class MethodNameColumn : IColumn
    {
        public string Id => nameof(MethodNameColumn);

        public string ColumnName => "Method";

        public bool AlwaysShow => true;

        public ColumnCategory Category => ColumnCategory.Job;

        public int PriorityInCategory => 0;

        public bool IsNumeric => false;

        public UnitType UnitType => UnitType.Time;

        public string Legend => "Method";

        public string GetValue(Summary summary, BenchmarkCase benchmarkCase) => benchmarkCase.Descriptor.WorkloadMethod.Name;

        public string GetValue(Summary summary, BenchmarkCase benchmarkCase, SummaryStyle style) => benchmarkCase.Descriptor.WorkloadMethod.Name;

        public bool IsAvailable(Summary summary) => true;

        public bool IsDefault(Summary summary, BenchmarkCase benchmarkCase) => true;
    }
}
