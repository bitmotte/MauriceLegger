using PluginConfig.API;

namespace MauriceLegger;

public static class MauriceConfigurator
{
    public static PluginConfigurator CreateConfigurator()
    {
        PluginConfigurator config = PluginConfigurator.Create("MauriceLegger", MyPluginInfo.PLUGIN_GUID);
        
        return config;
    }
}