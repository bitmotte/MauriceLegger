using PluginConfig.API;
using PluginConfig.API.Decorators;
using PluginConfig.API.Fields;

namespace MauriceLegger;

public static class LegConfigurator
{
    public static PluginConfigurator CreateConfigurator()
    {
        PluginConfigurator config = PluginConfigurator.Create("Maurice legger", MyPluginInfo.PLUGIN_GUID);

        
        
        return config;
    }
}