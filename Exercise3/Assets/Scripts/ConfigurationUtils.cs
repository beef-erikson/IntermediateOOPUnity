/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    #region Fields

    static ConfigurationData configurationData;
    
    #endregion
    
    #region Properties
    
    /// <summary>
    /// Gets the teddy bear move units per second
    /// </summary>
    /// <value>teddy bear move units per second</value>
    public static float TeddyBearMoveUnitsPerSecond
    {
        get { return configurationData.TeddyBearMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the cooldown seconds for shooting
    /// </summary>
    /// <value>cooldown seconds</value>
    public static float CooldownSeconds
    {
        get { return configurationData.CooldownSeconds; }    
    }

    #endregion
    
    #region Public Methods
    
    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
    
    #endregion
}
