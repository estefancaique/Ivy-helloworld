using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");
var server = new Server();
server.UseHotReload();
server.AddAppsFromAssembly();
server.UseChrome();
await server.RunAsync();