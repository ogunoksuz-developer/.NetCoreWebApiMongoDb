using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDb;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebApi
{
    public  class Startup
    {
        public  Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public  void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddMongoDbSettings(Configuration);

            services.AddSingleton<IYemekService, YemekManager>();
            services.AddSingleton<IYemekDal, MdYemekDal>();

            services.AddSingleton<IYemekTurService, YemekTurManager>();
            services.AddSingleton<IYemekTurDal, MdYemekTurDal>();

            services.AddSingleton<IEtiketlerService, EtiketlerManager>();
            services.AddSingleton<IEtiketlerDal, MdEtiketlerDal>();

            services.AddSingleton<IResimService, ResimManager>();
            services.AddSingleton<IResimDal, MdResimDal>();

            services.AddSingleton<IMalzemeService, MalzameManager>();
            services.AddSingleton<IMalzemeDal, MdMalzemeDal>();

            services.AddSingleton<IYemekResimService, YemekResimManager>();
            services.AddSingleton<IYemekResimDal, MdYemekResimDal>();

            services.AddSingleton<IYemekMalzemeService, YemekMalzemeManager>();
            services.AddSingleton<IYemekMalzemeDal, MdYemekMalzemeDal>();

            services.AddSwaggerDocument();

        }

      
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseOpenApi();

            app.UseSwaggerUi3();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public static  class deneme {

        public static IServiceCollection AddMongoDbSettings(this IServiceCollection services,
             IConfiguration configuration)
        {
            return services.Configure<MongoDbSettings>(options =>
            {
                options.ConnectionString = configuration
                    .GetSection(nameof(MongoDbSettings) + ":" + MongoDbSettings.ConnectionStringValue).Value;
                options.Database = configuration
                    .GetSection(nameof(MongoDbSettings) + ":" + MongoDbSettings.DatabaseValue).Value;
            });
        }
    }
}
