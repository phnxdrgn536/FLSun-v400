namespace Loader;

public static class Directories
{
    public readonly static string Extruders = "extruders";
    public readonly static string Definitions = "definitions";
    public readonly static string Meshes = "meshes";
    public readonly static string Variants = "variants";
    public readonly static string Quality = "quality";
    public readonly static string Intent = "intent";

    public static string FormatIntent(Filaments material) => $"{Intent}\\{material}";
    public static string FormatQuality(Filaments material, double size) => $"{Quality}\\{material}\\{size}";
}