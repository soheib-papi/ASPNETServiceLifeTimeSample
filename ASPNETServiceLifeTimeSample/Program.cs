using ASPNETServiceLifeTimeSample.Services;

namespace ASPNETServiceLifeTimeSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            //builder.Services.AddSingleton<IGuidProvider, GuidProvider>();

            builder.Services.AddSingleton(typeof(ISingleton), typeof(Singleton));
            builder.Services.AddScoped(typeof(IScoped), typeof(Scoped));
            builder.Services.AddTransient(typeof(ITransient), typeof(Transient));

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}