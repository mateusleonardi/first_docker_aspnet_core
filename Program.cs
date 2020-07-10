using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TodoApi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = new WebHostBuilder()
				.UseKestrel()
				// This will allow you to access your API outside Docker container
				.UseUrls("http://*:5000")
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseStartup<Startup>()
				.UseIISIntegration()
				.Build();
			host.Run();
		}
	}
}