using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<NowBenchmarks>(ManualConfig.Create(DefaultConfig.Instance)
                    .With(Job.ShortRun.WithLaunchCount(2).WithGcServer(true).With(Runtime.Clr))
                    .With(Job.ShortRun.WithLaunchCount(2).WithGcServer(true).With(Runtime.Core)));
        }
    }
}
