using EntityFrameworkSQLite.DataAccessLayer;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace EntityFrameworkSQLite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().CreateDatabase<OrderDbContext>().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}