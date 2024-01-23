using Microsoft.Extensions.DependencyInjection;

namespace FmgLib.LocalizationMaui;

public static class ServiceRegistration
{
    public static IServiceCollection AddFmgLibLocalizationMaui(this IServiceCollection services, string defaultLang = "", params string[] filePathes)
    {
        LocalizationService.Language = defaultLang;
        LocalizationService.ReadLocalizationFile(filePathes);

        return services;
    }

    public static void AddFmgLibLocalizationMaui(string defaultLang = "", params string[] filePathes)
    {
        LocalizationService.Language = defaultLang;
        LocalizationService.ReadLocalizationFile(filePathes);
    }

    public static async Task<IServiceCollection> AddFmgLibLocalizationMauiAsync(this IServiceCollection services, string defaultLang = "", params string[] filePathes)
    {
        LocalizationService.Language = defaultLang;
        await LocalizationService.ReadLocalizationFile(filePathes);

        return services;
    }

    public static async Task AddFmgLibLocalizationMauiAsync(string defaultLang = "", params string[] filePathes)
    {
        LocalizationService.Language = defaultLang;
        await LocalizationService.ReadLocalizationFile(filePathes);
    }
}
