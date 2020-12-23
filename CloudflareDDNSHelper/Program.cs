using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Text;
using System.Threading.Tasks;

namespace CloudflareDDNSHelper
{
    class Program
    {
        static Task<int> Main(string[] args)
        {
            var loadConfigTask = Config.LoadConfigAsync();
            
            var rootCommand = new RootCommand("A simple dual-stack DDNS helper that interacts with Cloudflare API.")
            {
                new Option<bool>("--one-shot", "Execute the task and exit."),
                new Option<bool>("--as-service", "Run as a service."),
            };

            rootCommand.Handler = CommandHandler.Create(
                async (bool oneShot, bool asService) =>
                {
                    var config = await loadConfigTask;
                });

            Console.OutputEncoding = Encoding.UTF8;
            return rootCommand.InvokeAsync(args);
        }
    }
}
