using PluginConfig.API;
using PluginConfig.API.Decorators;
using PluginConfig.API.Fields;

namespace MauriceLegger;

public static class LegConfigurator
{
    //leg settings
    

    //variations
    public static BoolField variantJingle;
    public static FloatSliderField variantChance;

    public static PluginConfig.API.Functionals.ButtonField resetVariants;
    public static PluginConfig.API.Functionals.ButtonField maxOutAllVariants;
    public static PluginConfig.API.Functionals.ButtonField disableAllVariants;

    public static FloatSliderField plushieChance;
    public static FloatSliderField tutuChance;
    public static FloatSliderField stiltsChance;
    public static FloatSliderField holdingArmsChance;
    public static FloatSliderField holdingLegsChance;
    public static FloatSliderField twoDChance;
    public static FloatSliderField mettatonChance;
    public static FloatSliderField sentryChance;
    public static FloatSliderField swordsmachineChance;
    public static FloatSliderField vTwoChance;
    public static FloatSliderField grossChance;
    public static FloatSliderField miniMauriceChance;
    public static FloatSliderField thighHighsChance;
    public static FloatSliderField handLegsChance;


    public static PluginConfigurator CreateConfigurator()
    {
        PluginConfigurator config = PluginConfigurator.Create("Maurice Legger", MyPluginInfo.PLUGIN_GUID);

        ConfigSpace gap1 = new(config.rootPanel,15f);
        

        ConfigHeader variantHeader = new(config.rootPanel,"Secret Variations",24,TMPro.TextAlignmentOptions.Left);
        ConfigHeader variantCount = new(config.rootPanel,"Notice : There are 14 variations .",14,TMPro.TextAlignmentOptions.Left);

        variantJingle = new(config.rootPanel,"Jingle","variant_jingle",true);
        variantChance = new(config.rootPanel,"Chance ( % )","variant_chance",new(0,100),1);
        
        ConfigPanel variants = new(config.rootPanel,"Individual Likelihood","variant_likelihood");

        ConfigSpace gapC1 = new(variants,15f);
        resetVariants = new(variants,"Reset","reset_variants");
        maxOutAllVariants = new(variants,"Max Out All","max_out_all_variants");
        disableAllVariants = new(variants,"Disable All","disable_all_variants");
        ConfigSpace gapC2 = new(variants,15f);

        plushieChance = new(variants,"Plushie","plushie",new(0,5),1);
        ConfigHeader variantCredit1 = new(variants,"Credit to _ for the idea",14,TMPro.TextAlignmentOptions.Left);
        tutuChance = new(variants,"Tutu","tutu",new(0,5),1);
        ConfigHeader variantCredit2 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);
        stiltsChance = new(variants,"Stilts","stilts",new(0,5),1);
        ConfigHeader variantCredit3 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);
        holdingArmsChance = new(variants,"Holding Arms","holding_arms",new(0,5),1);
        ConfigHeader variantCredit4 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);
        holdingLegsChance = new(variants,"Holding Legs","holding_legs",new(0,5),1);
        ConfigHeader variantCredit5 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);
        twoDChance = new(variants,"2D","2d",new(0,5),1);
        ConfigHeader variantCredit6 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);
        mettatonChance = new(variants,"Mettaton","mettaton",new(0,5),1);
        ConfigHeader variantCredit7 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);
        sentryChance = new(variants,"Sentry","sentry",new(0,5),1);
        ConfigHeader variantCredit8 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);
        swordsmachineChance = new(variants,"Swordsmachine","swordsmachine",new(0,5),1);
        ConfigHeader variantCredit9 = new(variants,"Credit to _ for the idea",14,TMPro.TextAlignmentOptions.Left);
        vTwoChance = new(variants,"V2","v2",new(0,5),1);
        ConfigHeader variantCredit10 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);
        grossChance = new(variants,"Gross Maurice","gross",new(0,5),1);
        ConfigHeader variantCredit11 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);
        miniMauriceChance = new(variants,"Mini Maurice","mini_maurice",new(0,5),1);
        ConfigHeader variantCredit12 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);
        thighHighsChance = new(variants,"Thigh Highs","thigh_highs",new(0,5),1);
        ConfigHeader variantCredit13 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);
        handLegsChance = new(variants,"Hand Legs","hand_legs",new(0,5),1);
        ConfigHeader variantCredit14 = new(variants,"Credit to _ on Reddit for the idea",14,TMPro.TextAlignmentOptions.Left);

        ConfigSpace gap7 = new(config.rootPanel,15f);

        ConfigHeader cheatsNotice = new(config.rootPanel,"Notice : Cheats can be found in the cheats menu .",20,TMPro.TextAlignmentOptions.Left);
        ConfigSpace gap8 = new(config.rootPanel,15f);

        config.postConfigChange += UpdateGlobalConfig;
        UpdateGlobalConfig();

        maxOutAllVariants.onClick += EnableAllVariants;
        disableAllVariants.onClick += DisableAllVariants;
        resetVariants.onClick += ResetAllVariants;

        return config;
    }

    static void UpdateGlobalConfig()
    {
        //variants
        GlobalConfig.variantJingle = variantJingle.value;
        GlobalConfig.variantChance = variantChance.value;

        GlobalConfig.individualVariantChances[plushieChance.guid] = plushieChance.value;
        GlobalConfig.individualVariantChances[tutuChance.guid] = tutuChance.value;
        GlobalConfig.individualVariantChances[stiltsChance.guid] = stiltsChance.value;
        GlobalConfig.individualVariantChances[holdingArmsChance.guid] = holdingArmsChance.value;
        GlobalConfig.individualVariantChances[holdingLegsChance.guid] = holdingLegsChance.value;
        GlobalConfig.individualVariantChances[twoDChance.guid] = twoDChance.value;
        GlobalConfig.individualVariantChances[mettatonChance.guid] = mettatonChance.value;
        GlobalConfig.individualVariantChances[sentryChance.guid] = sentryChance.value;
        GlobalConfig.individualVariantChances[swordsmachineChance.guid] = swordsmachineChance.value;
        GlobalConfig.individualVariantChances[vTwoChance.guid] = vTwoChance.value;
        GlobalConfig.individualVariantChances[grossChance.guid] = grossChance.value;
        GlobalConfig.individualVariantChances[miniMauriceChance.guid] = miniMauriceChance.value;
        GlobalConfig.individualVariantChances[thighHighsChance.guid] = thighHighsChance.value;
        GlobalConfig.individualVariantChances[handLegsChance.guid] = handLegsChance.value;

        GlobalConfig.totalVariantChances = 0;

        GlobalConfig.totalVariantChances += plushieChance.value;
        GlobalConfig.totalVariantChances += tutuChance.value;
        GlobalConfig.totalVariantChances += stiltsChance.value;
        GlobalConfig.totalVariantChances += holdingArmsChance.value;
        GlobalConfig.totalVariantChances += holdingLegsChance.value;
        GlobalConfig.totalVariantChances += twoDChance.value;
        GlobalConfig.totalVariantChances += mettatonChance.value;
        GlobalConfig.totalVariantChances += sentryChance.value;
        GlobalConfig.totalVariantChances += swordsmachineChance.value;
        GlobalConfig.totalVariantChances += vTwoChance.value;
        GlobalConfig.totalVariantChances += grossChance.value;
        GlobalConfig.totalVariantChances += miniMauriceChance.value;
        GlobalConfig.totalVariantChances += thighHighsChance.value;
        GlobalConfig.totalVariantChances += handLegsChance.value;
    }

    static void EnableAllVariants()
    {
        plushieChance.value = 5;
        plushieChance.TriggerValueChangeEvent();
        tutuChance.value = 5;
        tutuChance.TriggerValueChangeEvent();
        stiltsChance.value = 5;
        stiltsChance.TriggerValueChangeEvent();
        holdingArmsChance.value = 5;
        holdingArmsChance.TriggerValueChangeEvent();
        holdingLegsChance.value = 5;
        holdingLegsChance.TriggerValueChangeEvent();
        twoDChance.value = 5;
        twoDChance.TriggerValueChangeEvent();
        mettatonChance.value = 5;
        mettatonChance.TriggerValueChangeEvent();
        sentryChance.value = 5;
        sentryChance.TriggerValueChangeEvent();
        swordsmachineChance.value = 5;
        swordsmachineChance.TriggerValueChangeEvent();
        vTwoChance.value = 5;
        vTwoChance.TriggerValueChangeEvent();
        grossChance.value = 5;
        grossChance.TriggerValueChangeEvent();
        miniMauriceChance.value = 5;
        miniMauriceChance.TriggerValueChangeEvent();
        thighHighsChance.value = 5;
        thighHighsChance.TriggerValueChangeEvent();
        handLegsChance.value = 5;
        handLegsChance.TriggerValueChangeEvent();
    }

    static void DisableAllVariants()
    {
        plushieChance.value = 0;
        plushieChance.TriggerValueChangeEvent();
        tutuChance.value = 0;
        tutuChance.TriggerValueChangeEvent();
        stiltsChance.value = 0;
        stiltsChance.TriggerValueChangeEvent();
        holdingArmsChance.value = 0;
        holdingArmsChance.TriggerValueChangeEvent();
        holdingLegsChance.value = 0;
        holdingLegsChance.TriggerValueChangeEvent();
        twoDChance.value = 0;
        twoDChance.TriggerValueChangeEvent();
        mettatonChance.value = 0;
        mettatonChance.TriggerValueChangeEvent();
        sentryChance.value = 0;
        sentryChance.TriggerValueChangeEvent();
        swordsmachineChance.value = 0;
        swordsmachineChance.TriggerValueChangeEvent();
        vTwoChance.value = 0;
        vTwoChance.TriggerValueChangeEvent();
        grossChance.value = 0;
        grossChance.TriggerValueChangeEvent();
        miniMauriceChance.value = 0;
        miniMauriceChance.TriggerValueChangeEvent();
        thighHighsChance.value = 0;
        thighHighsChance.TriggerValueChangeEvent();
        handLegsChance.value = 0;
        handLegsChance.TriggerValueChangeEvent();
    }

    static void ResetAllVariants()
    {
        plushieChance.value = plushieChance.defaultValue;
        plushieChance.TriggerValueChangeEvent();
        tutuChance.value = tutuChance.defaultValue;
        tutuChance.TriggerValueChangeEvent();
        stiltsChance.value = stiltsChance.defaultValue;
        stiltsChance.TriggerValueChangeEvent();
        holdingArmsChance.value = holdingArmsChance.defaultValue;
        holdingArmsChance.TriggerValueChangeEvent();
        holdingLegsChance.value = holdingLegsChance.defaultValue;
        holdingLegsChance.TriggerValueChangeEvent();
        twoDChance.value = twoDChance.defaultValue;
        twoDChance.TriggerValueChangeEvent();
        mettatonChance.value = mettatonChance.defaultValue;
        mettatonChance.TriggerValueChangeEvent();
        sentryChance.value = sentryChance.defaultValue;
        sentryChance.TriggerValueChangeEvent();
        swordsmachineChance.value = swordsmachineChance.defaultValue;
        swordsmachineChance.TriggerValueChangeEvent();
        vTwoChance.value = vTwoChance.defaultValue;
        vTwoChance.TriggerValueChangeEvent();
        grossChance.value = grossChance.defaultValue;
        grossChance.TriggerValueChangeEvent();
        miniMauriceChance.value = miniMauriceChance.defaultValue;
        miniMauriceChance.TriggerValueChangeEvent();
        thighHighsChance.value = thighHighsChance.defaultValue;
        thighHighsChance.TriggerValueChangeEvent();
        handLegsChance.value = handLegsChance.defaultValue;
        handLegsChance.TriggerValueChangeEvent();
    } 
}