﻿namespace TrilhaApiDesafio.Configurations
{
    public static class AutomapperExtension
    {


        public static IServiceCollection AddAutoMapperApi(this IServiceCollection services, Type assemblyContainingMappers)
        {
            services.AddAutoMapper(expression =>
            {
                expression.AllowNullCollections = true;
            }, assemblyContainingMappers);

            return services;
        }
    }
}
