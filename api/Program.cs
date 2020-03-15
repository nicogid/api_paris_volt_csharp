using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using MySql.Data.MySqlClient;

namespace api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string cs = @"server=localhost;userid=root;password=toor;database=api";

            //using var con = new MySqlConnection(cs);
            //con.Open();

            CreateHostBuilder(args).Build().Run();

            //con.Close();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
