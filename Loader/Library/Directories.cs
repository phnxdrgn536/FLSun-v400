namespace Loader.Library;

public static class Directories
{
    public readonly static string Extruders = "extruders";
    public readonly static string Definitions = "definitions";
    public readonly static string Meshes = "meshes";
    public readonly static string Variants = "variants";
    public readonly static string Quality = "quality";
    public readonly static string Intent = "intent";

    public static string FormatIntent(Filaments material) => Path.Join(Intent, material.ToString());
    public static string FormatQuality(Filaments material, double size) => Path.Join(Quality, material.ToString(), size.ToString());
}
