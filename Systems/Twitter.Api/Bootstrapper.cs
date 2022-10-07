using Twitter.Settings;

namespace Twitter.Api;

public static class Bootstrapper
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddSettings();
        return services;
    }
}