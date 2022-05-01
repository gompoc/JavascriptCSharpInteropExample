using Microsoft.JSInterop;

namespace ExampleProject;

public static class Example
{
    [JSInvokable]
    public static async Task<int> Sum(int x, int y)
    {
        return await JavascriptComponent.JSRuntime.InvokeAsync<int>("jsSum", new object?[] {x, y});
    }
}