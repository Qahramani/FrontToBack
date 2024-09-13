using FrontToBackTask1.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace FrontToBackTask1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMvc();

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
           
            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>  endpoints.MapControllerRoute("default", "{controller=Home}/{action=index}/{id?}"));


            app.Run();
        }
    }
}
