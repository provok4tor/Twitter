using Microsoft.Extensions.DependencyInjection;
using Twitter.Settings.Source;

namespace Twitter.Settings;

public static class Bootstrapper
{
    public static IServiceCollection AddSettings(this IServiceCollection services)
    {
        services.AddSingleton<ISettingSource, SettingSource>();
        return services;
    }
}