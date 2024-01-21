using Microsoft.Extensions.DependencyInjection;

namespace FmgLib.LocalizationMaui;

public static class ServiceRegistration
{
    public static IServiceCollection AddFmgLibLocalizationMaui(this IServiceCollection services, params string[] filePathes)
    {
        LocalizationService.ReadLocalizationFile(filePathes);

        return services;
    }

    public static void AddFmgLibLocalizationMaui(params string[] filePathes)
    {
        LocalizationService.ReadLocalizationFile(filePathes);
    }

    public static async Task<IServiceCollection> AddFmgLibLocalizationMauiAsync(this IServiceCollection services, params string[] filePathes)
    {
        await LocalizationService.ReadLocalizationFile(filePathes);

        return services;
    }

    public static async Task AddFmgLibLocalizationMauiAsync(params string[] filePathes)
    {
        await LocalizationService.ReadLocalizationFile(filePathes);
    }
}
