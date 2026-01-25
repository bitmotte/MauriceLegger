using System;
using System.IO;
using System.Reflection;

namespace MauriceLegger;

public static class Pathing
{
    public static string GetPluginPath()
    {
        string codeBase = Assembly.GetExecutingAssembly().CodeBase;
        UriBuilder uri = new UriBuilder(codeBase);
        string path = Uri.UnescapeDataString(uri.Path);
        return Path.GetDirectoryName(path);
    }
}