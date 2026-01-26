using System;
using PluginConfig.API;
using PluginConfig.API.Fields;

namespace MauriceLegger;

public static class MauriceConfigurator
{
    public static PluginConfigurator CreateConfigurator()
    {
        PluginConfigurator config = PluginConfigurator.Create("MauriceLegger", MyPluginInfo.PLUGIN_GUID);

        FloatField legSpeed = new(config.rootPanel, "Leg Speed", "mleg.legspeed", 256f);

        legSpeed.postValueChangeEvent += UpdateLegSpeed;

        legSpeed.TriggerPostValueChangeEvent();
        
        return config;
    }

    private static void UpdateLegSpeed(float value)
    {
        Plugin.Logger.LogInfo($"Update leg speed to {value}! ! ! ! ! !");
        AccessibleConfigs.legSpeed = value;
    }
}