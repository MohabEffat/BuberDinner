﻿using BubberDinner.Application.Common.Interfaces.Authentication;
using BubberDinner.Infrastructure.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BubberDinner.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtOptions>(configuration.GetSection(JwtOptions.sectionName));

            services.AddSingleton<ITokenService, TokenService>();

            return services;
        }
    }
}
