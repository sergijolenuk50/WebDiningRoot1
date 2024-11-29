using Core.Interfaces;
using Core.MapperProfiles;
using Core.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IBreadServices, BreadServices>();
            services.AddScoped<IDrinkcServices, DrinkcServices>();
            services.AddScoped<IFirstDishesServices, FirstDishesServices>();
            services.AddScoped<IGarnishServices, GarnishServices>();
            services.AddScoped<IMeatDishesServices, MeatDishesServices>();
            services.AddScoped<IMenuServices, MenuServices>();
            services.AddScoped<ISaladServices, SaladServices>();

        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AppProfile));
        }

        public static void AddFluentValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();
            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
