public static class ModuleInitializer
{
    #region Initialize

    [ModuleInitializer]
    public static void Init() =>
        VerifyUlid.Initialize();

    #endregion

    [ModuleInitializer]
    public static void InitOther()
    {
        VerifyDiffPlex.Initialize(OutputType.Compact);
        VerifierSettings.InitializePlugins();
    }
}