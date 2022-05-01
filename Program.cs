using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ExampleProject;


Console.WriteLine("Application OnInit()");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<JavascriptComponent>("#app");
await builder.Build().RunAsync();



