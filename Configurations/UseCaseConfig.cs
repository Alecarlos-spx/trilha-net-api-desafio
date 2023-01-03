using TrilhaApiDesafio.Interfaces;
using TrilhaApiDesafio.UseCase;

namespace TrilhaApiDesafio.Configurations
{
    public static class UseCaseConfig
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services) => services
            .AddTransient<IUseCaseAddTarefa, UseCaseAddTarefa>()
            .AddTransient<IUseCaseUpdateTarefa, UseCaseUpdateTarefa>()
            .AddTransient<IUseCaseDeleteTarefa, UseCaseDeleteTarefa>()
            .AddTransient<IUseCaseGetAllTarefas, UseCaseGetAllTarefas>()
            .AddTransient<IUseCaseGetFilterDateTarefa, UseCaseGetFilterDateTarefa>()
            .AddTransient<IUseCaseGetFilterStatusTarefa, UseCaseGetFilterStatusTarefa>()
            .AddTransient<IUseCaseGetFilterTitleTarefa, UseCaseGetFilterTitleTarefa>()
            .AddTransient<IUseCaseGetTarefa, UseCaseGetTarefa>();
    }
}
