using System;
using System.IO;
using PluginConfig.API;
using PluginConfig.API.Fields;
using UnityEngine;

namespace MauriceLegger;

public static class MauriceConfigurator
{
    public static PluginConfigurator CreateConfigurator()
    {
        PluginConfigurator config = PluginConfigurator.Create("MauriceLegger", MyPluginInfo.PLUGIN_GUID);
        Texture2D tex = LoadPNG($"{Pathing.GetPluginPath()}/DONTDELETE_icon.png");
        Sprite icon = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
        config.image = icon;

        FloatField legSpeed = new(config.rootPanel, "Leg Speed", "mleg.legspeed", 256f);
        ConfigPanel secretPanel = new(config.rootPanel, "Secret Variations ( 3 )", "mleg.secretvars");
        BoolField armsField = new(secretPanel, "Arm Legs", "mleg.arms", true);
        BoolField mauriceField = new(secretPanel, "Maurice Legs", "mleg.maurice", true);
        BoolField thighsField = new(secretPanel, "Thigh Highs", "mleg.thighs", true);

        legSpeed.postValueChangeEvent += UpdateLegSpeed;
        armsField.postValueChangeEvent += UpdateArms;
        mauriceField.postValueChangeEvent += UpdateMaurice;
        thighsField.postValueChangeEvent += UpdateThighs;

        legSpeed.TriggerPostValueChangeEvent();
        armsField.TriggerPostValueChangeEvent();
        mauriceField.TriggerPostValueChangeEvent();
        thighsField.TriggerPostValueChangeEvent();
        
        return config;
    }

    private static void UpdateLegSpeed(float value)
    {
        Plugin.Logger.LogInfo($"Update leg speed to {value}! ! ! ! ! !");
        AccessibleConfigs.legSpeed = value;
    }

    private static void UpdateArms(bool value)
    {
        Plugin.Logger.LogInfo($"Update arm legs to {value}! ! ! ! ! !");
        AccessibleConfigs.armLegs = value;
    }

    private static void UpdateMaurice(bool value)
    {
        Plugin.Logger.LogInfo($"Update maurice legs to {value}! ! ! ! ! !");
        AccessibleConfigs.mauriceLegs = value;
    }

    private static void UpdateThighs(bool value)
    {
        Plugin.Logger.LogInfo($"Update thigh highs to {value}! ! ! ! ! !");
        AccessibleConfigs.thighs = value;
    }

    public static Texture2D LoadPNG(string filePath) {
	    Texture2D tex = null;
	    byte[] fileData;

	    if (File.Exists(filePath)) 	{
	    	fileData = File.ReadAllBytes(filePath);
	    	tex = new Texture2D(2, 2);
	    	tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
	    }
	    return tex;
    }

}