using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace ConsoleApp53
{
    public class NowBenchmarks
    {
        [Benchmark]
        public void UtcNow()
        {
            var v = DateTime.UtcNow;
        }

        [Benchmark]
        public void Now()
        {
            var v = DateTime.Now;
        }

        [Benchmark]
        public void GetTickCount()
        {
            var v = Stopwatch.GetTimestamp();
        }

        [Benchmark]
        public void GetSystemTime()
        {
            GetSystemTimePreciseAsFileTime(out var currentSystemTime);
            var v = DateTime.FromFileTimeUtc(currentSystemTime);
        }

        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        private static extern void GetSystemTimePreciseAsFileTime(out long filetime);
    }
}
