using System.IO;
using System.Reflection;

namespace MauriceLegger;

public static class EmbeddedAccess
{
    public static byte[] AccessFile(string fileName)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        byte[] bytes;
        using (Stream resFilestream = assembly.GetManifestResourceStream($"MauriceLegger.resources.{fileName}"))
        {
            if (resFilestream == null)
            {
                return null;
            }

            bytes = new byte[resFilestream.Length];
            resFilestream.Read(bytes, 0, bytes.Length);
        }
        return bytes;
    }
}