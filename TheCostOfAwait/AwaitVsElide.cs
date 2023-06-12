using BenchmarkDotNet.Attributes;

namespace TheCostOfAwait;

[MemoryDiagnoser]
public class AwaitVsElide
{
    private static readonly Task<string> ExampleTask = Task.FromResult("Hello World!");

    [Benchmark]
    public async Task<string> GetStringWithoutAsync() => await GetStringWithoutAsyncCore();

    [Benchmark]
    public async Task<string> GetStringWithAsync() => await GetStringWithAsyncCore();

    private static Task<string> GetStringWithoutAsyncCore() => ExampleTask;
    private static async Task<string> GetStringWithAsyncCore() => await ExampleTask;

}
