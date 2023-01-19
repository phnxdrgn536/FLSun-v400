namespace Loader.Library;

public record FirmwareOption(string Value, string Label);
public record DownloadDirectory(string Name, string[] Files);

public class DownloadList : List<DownloadDirectory>
{
    public readonly static FirmwareOption[] Firmwares = new[]
    {
        new FirmwareOption("stock", "FLSUN"),
        new FirmwareOption("Reflashed", "Official"),
    };

    public readonly static string[] Versions = new[]
    {
        "5.0",
        "5.1",
        "5.2",
        "5.3",
    };

    public DownloadList() : base()
    {
        Add(new(Directories.Extruders, new[] { "extruders/flsun_v400_extruder_0.def.json" }));
        Add(new(Directories.Meshes, new[] { "meshes/flsun_v400.stl" }));
        Add(new(Directories.Variants, new[]
        {
            "variants/flsun_v400_0.25.inst.cfg",
            "variants/flsun_v400_0.4.inst.cfg",
            "variants/flsun_v400_0.6.inst.cfg",
            "variants/flsun_v400_0.8.inst.cfg",
        }));
        Add(new(Directories.Quality, new[]
        {
            "quality/flsun_v400_global_Draft_Quality.inst.cfg",
            "quality/flsun_v400_global_Fast_Quality.inst.cfg",
            "quality/flsun_v400_global_High_Quality.inst.cfg",
            "quality/flsun_v400_global_Normal_Quality.inst.cfg",
            "quality/flsun_v400_global_Superdraft_Quality.inst.cfg",
            "quality/flsun_v400_global_Verydraft_Quality.inst.cfg",
        }));

        Add(new(Directories.FormatIntent(Filaments.PLA), new[]
        {
            "intent/PLA/flsun_v400_0.4_PLA_Draft_Print_Quick.inst.cfg",
            "intent/PLA/flsun_v400_0.4_PLA_Draft_Print_Quick.inst.cfg",
            "intent/PLA/flsun_v400_0.4_PLA_Fast_Print_Accurate.inst.cfg",
            "intent/PLA/flsun_v400_0.4_PLA_Fast_Visual.inst.cfg",
            "intent/PLA/flsun_v400_0.4_PLA_High_Visual.inst.cfg",
            "intent/PLA/flsun_v400_0.4_PLA_Normal_Quality_Accurate.inst.cfg",
            "intent/PLA/flsun_v400_0.4_PLA_Normal_Visual.inst.cfg",
            "intent/PLA/flsun_v400_0.4_PLA_VeryDraft_Print_Quick.inst.cfg",
        }));

        Add(new(Directories.FormatIntent(Filaments.PETG), new[]
        {
            "intent/PETG/flsun_v400_0.4_PETG_Draft_Print_Quick.inst.cfg",
            "intent/PETG/flsun_v400_0.4_PETG_Fast_Print_Accurate.inst.cfg",
            "intent/PETG/flsun_v400_0.4_PETG_Fast_Visual.inst.cfg",
            "intent/PETG/flsun_v400_0.4_PETG_High_Visual.inst.cfg",
            "intent/PETG/flsun_v400_0.4_PETG_Normal_Quality_Accurate.inst.cfg",
            "intent/PETG/flsun_v400_0.4_PETG_Normal_Visual.inst.cfg",
            "intent/PETG/flsun_v400_0.4_PETG_VeryDraft_Print_Quick.inst.cfg",
        }));

        Add(new(Directories.FormatQuality(Filaments.PLA, .25), new[] { "quality/PLA/0.25/flsun_v400_0.25_PLA_Normal_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PLA, .4), new[] { "quality/PLA/0.4/flsun_v400_0.4_PLA_Draft_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PLA, .4), new[] { "quality/PLA/0.4/flsun_v400_0.4_PLA_Fast_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PLA, .4), new[] { "quality/PLA/0.4/flsun_v400_0.4_PLA_High_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PLA, .4), new[] { "quality/PLA/0.4/flsun_v400_0.4_PLA_Normal_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PLA, .4), new[] { "quality/PLA/0.4/flsun_v400_0.4_PLA_VeryDraft_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PLA, .6), new[] { "quality/PLA/0.6/flsun_v400_0.6_PLA_Fast_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PLA, .6), new[] { "quality/PLA/0.6/flsun_v400_0.6_PLA_High_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PLA, .6), new[] { "quality/PLA/0.6/flsun_v400_0.6_PLA_Normal_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PLA, .8), new[] { "quality/PLA/0.8/flsun_v400_0.8_PLA_Draft_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PLA, .8), new[] { "quality/PLA/0.8/flsun_v400_0.8_PLA_Superdraft_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PLA, .8), new[] { "quality/PLA/0.8/flsun_v400_0.8_PLA_Verydraft_Print.inst.cfg" }));

        Add(new(Directories.FormatQuality(Filaments.ABS, .25), new[] { "quality/ABS/0.25/flsun_v400_0.25_ABS_Normal_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.ABS, .4), new[] { "quality/ABS/0.4/flsun_v400_0.4_ABS_Draft_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.ABS, .4), new[] { "quality/ABS/0.4/flsun_v400_0.4_ABS_Fast_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.ABS, .4), new[] { "quality/ABS/0.4/flsun_v400_0.4_ABS_High_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.ABS, .4), new[] { "quality/ABS/0.4/flsun_v400_0.4_ABS_Normal_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.ABS, .4), new[] { "quality/ABS/0.4/flsun_v400_0.4_ABS_VeryDraft_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.ABS, .6), new[] { "quality/ABS/0.6/flsun_v400_0.6_ABS_Fast_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.ABS, .6), new[] { "quality/ABS/0.6/flsun_v400_0.6_ABS_High_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.ABS, .6), new[] { "quality/ABS/0.6/flsun_v400_0.6_ABS_Normal_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.ABS, .8), new[] { "quality/ABS/0.8/flsun_v400_0.8_ABS_Draft_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.ABS, .8), new[] { "quality/ABS/0.8/flsun_v400_0.8_ABS_Superdraft_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.ABS, .8), new[] { "quality/ABS/0.8/flsun_v400_0.8_ABS_Verydraft_Print.inst.cfg" }));

        Add(new(Directories.FormatQuality(Filaments.PETG, .4), new[] { "quality/PETG/0.4/flsun_v400_0.4_PETG_Draft_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PETG, .4), new[] { "quality/PETG/0.4/flsun_v400_0.4_PETG_Fast_Print.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PETG, .4), new[] { "quality/PETG/0.4/flsun_v400_0.4_PETG_High_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PETG, .4), new[] { "quality/PETG/0.4/flsun_v400_0.4_PETG_Normal_Quality.inst.cfg" }));
        Add(new(Directories.FormatQuality(Filaments.PETG, .4), new[] { "quality/PETG/0.4/flsun_v400_0.4_PETG_VeryDraft_Print.inst.cfg" }));
    }
}