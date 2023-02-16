//using CommunicationModule.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using DBDataContext;
using CrudAPI.Interfaces;
using CrudAPI.Repository;

namespace CommunicationModule
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                     .RequireAuthenticatedUser()
                     .Build();
                //config.Filters.Add(new AuthorizeFilter(policy)); //global authorize filter
            })
              .AddAuthorization();


            //services.AddAuthentication("bearer").AddJwtBearer("bearer", options =>
            //{
            //    options.Audience = "Skanlog.CommunicationModule.Api";
            //    //options.Authority = "http://localhost:8080/";
            //    options.Authority = "https://id.test.skanlog.io/";
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateAudience = false
            //    };
            //    // ignore self-signed ssl
            //    //options.BackchannelHttpHandler = new HttpClientHandler { ServerCertificateCustomValidationCallback = delegate { return true; } };
            //});
            services.AddCors();
            services.AddScoped<IRepository, Repository>(); 
            services.AddDbContextPool<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CommunicationModuleConn")));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Warehouse", Version = "v1" });
            });
            //services.AddControllers().AddNewtonsoftJson();

            //string rabbitmqConnectionString = "host=localhost;username=guest;password=guest;timeout=60";

            //var bus = RabbitHutch.CreateBus(rabbitmqConnectionString);

            //services.AddSingleton(bus);

            //services.AddHostedService<BackgroundServices.UserEventHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CommunicationModel v1"));
            }

            app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed(_ => true)
                .AllowCredentials());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
