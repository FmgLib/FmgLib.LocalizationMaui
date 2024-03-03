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

    public static MauiAppBuilder UseFmgLibLocalizationMaui(this MauiAppBuilder builder, string defaultLang = "", params string[] filePathes)
    {
        LocalizationService.Language = defaultLang;
        LocalizationService.ReadLocalizationFile(filePathes);

        return builder;
    }

    public static void UseFmgLibLocalizationMaui(string defaultLang = "", params string[] filePathes)
    {
        LocalizationService.Language = defaultLang;
        LocalizationService.ReadLocalizationFile(filePathes);
    }

    public static async Task<MauiAppBuilder> UseFmgLibLocalizationMauiAsync(this MauiAppBuilder builder, string defaultLang = "", params string[] filePathes)
    {
        LocalizationService.Language = defaultLang;
        await LocalizationService.ReadLocalizationFile(filePathes);

        return builder;
    }

    public static async Task UseFmgLibLocalizationMauiAsync(string defaultLang = "", params string[] filePathes)
    {
        LocalizationService.Language = defaultLang;
        await LocalizationService.ReadLocalizationFile(filePathes);
    }
}
