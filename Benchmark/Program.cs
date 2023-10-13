using Benchmark;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

// compiler must be on Release mode before execution

/*var config = ManualConfig.CreateEmpty()
    .AddLogger(new ConsoleLogger())
    .AddExporter(new CsvExporter(CsvSeparator.Comma))
    .AddLogicalGroupRules(BenchmarkLogicalGroupRule.ByCategory)
    .WithSummaryStyle(SummaryStyle.Default.WithRatioStyle(RatioStyle.Percentage))
    .AddColumn(new MethodNameColumn())
    .AddColumn(RankColumn.Arabic)
    .AddColumn(StatisticColumn.AllStatistics);*/

var config = ManualConfig.CreateMinimumViable()
    .AddLogicalGroupRules(BenchmarkLogicalGroupRule.ByParams)
    .AddColumn(RankColumn.Arabic)
    .AddColumn(StatisticColumn.AllStatistics);

BenchmarkRunner.Run<StringAppendPerformance>(config);