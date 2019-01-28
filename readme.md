``` ini

BenchmarkDotNet=v0.11.3, OS=Windows 10.0.17134.523 (1803/April2018Update/Redstone4)
Intel Core i7-4770 CPU 3.40GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.100
  [Host]   : .NET Core 2.2.0 (CoreCLR 4.6.27110.04, CoreFX 4.6.27110.04), 64bit RyuJIT
  ShortRun : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.8.3694.0

Job=ShortRun  Server=True  IterationCount=3  
LaunchCount=2  WarmupCount=3  

```
|        Method | Runtime |     Mean |     Error |    StdDev |
|-------------- |-------- |---------:|----------:|----------:|
|        UtcNow |     Clr | 11.79 ns | 0.6883 ns | 0.2454 ns |
|           Now |     Clr | 36.76 ns | 2.8186 ns | 1.0051 ns |
|  GetTickCount |     Clr | 23.28 ns | 3.8572 ns | 1.3755 ns |
| GetSystemTime |     Clr | 37.41 ns | 1.0049 ns | 0.3584 ns |
|        UtcNow |    Core | 25.02 ns | 1.1987 ns | 0.4275 ns |
|           Now |    Core | 49.41 ns | 4.6188 ns | 1.6471 ns |
|  GetTickCount |    Core | 21.07 ns | 1.1090 ns | 0.3955 ns |
| GetSystemTime |    Core | 29.78 ns | 1.3270 ns | 0.4732 ns |
