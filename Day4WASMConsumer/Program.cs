using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Day4WASMConsumer
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            builder.Services.AddScoped<IServices<Department>,DeptService>();

            builder.Services.AddScoped(sp => new HttpClient
            { 
                //get IP from App setting
                BaseAddress = new
                Uri(builder.Configuration.GetValue<string>("Ip"))
            });

            await builder.Build().RunAsync();
        }


    }
}
