namespace VerifyTests;

public static class VerifyUlid
{
    public static bool Initialized { get; private set; }

    public static void Initialize()
    {
        if (Initialized)
        {
            throw new("Already Initialized");
        }

        Initialized = true;

        InnerVerifier.ThrowIfVerifyHasBeenRun();

        CounterContext.Init();
        VerifierSettings
            .AddExtraSettings(_ =>
                _.Converters.Add(new UlidConverter()));
    }

    public static void DontScrubUlids(this VerifySettings settings) =>
        settings.Context["ScrubUlids"] = false;

    public static SettingsTask DontScrubUlids(this SettingsTask settings)
    {
        settings.CurrentSettings.DontScrubUlids();
        return settings;
    }

    internal static bool ScrubUlids(this IReadOnlyDictionary<string, object> context)
    {
        if (context.TryGetValue("ScrubUlids", out var value))
        {
            return (bool) value;
        }

        return true;
    }
}