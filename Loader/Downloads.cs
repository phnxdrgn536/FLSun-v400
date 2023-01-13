namespace Loader;

public class Downloads : Dictionary<string, string>
{
    public Downloads() : base()
    {
        this["/cura/extruders/flsun_v400_extruder_0.def.json"] = Directories.Extruders;
        this["/cura/meshes/flsun_v400.stl"] = Directories.Meshes;
        this["/cura/intent/PLA/flsun_v400_0.4_PLA_Draft_Print_Quick.inst.cfg"] = Directories.FormatIntent(Filaments.PLA);
        this["/cura/intent/PLA/flsun_v400_0.4_PLA_Fast_Print_Accurate.inst.cfg"] = Directories.FormatIntent(Filaments.PLA);
        this["/cura/intent/PLA/flsun_v400_0.4_PLA_Fast_Visual.inst.cfg"] = Directories.FormatIntent(Filaments.PLA);
        this["/cura/intent/PLA/flsun_v400_0.4_PLA_High_Visual.inst.cfg"] = Directories.FormatIntent(Filaments.PLA);
        this["/cura/intent/PLA/flsun_v400_0.4_PLA_Normal_Quality_Accurate.inst.cfg"] = Directories.FormatIntent(Filaments.PLA);
        this["/cura/intent/PLA/flsun_v400_0.4_PLA_Normal_Visual.inst.cfg"] = Directories.FormatIntent(Filaments.PLA);
        this["/cura/intent/PLA/flsun_v400_0.4_PLA_VeryDraft_Print_Quick.inst.cfg"] = Directories.FormatIntent(Filaments.PLA);
        this["/cura/intent/PETG/flsun_v400_0.4_PETG_Draft_Print_Quick.inst.cfg"] = Directories.FormatIntent(Filaments.PETG);
        this["/cura/intent/PETG/flsun_v400_0.4_PETG_Fast_Print_Accurate.inst.cfg"] = Directories.FormatIntent(Filaments.PETG);
        this["/cura/intent/PETG/flsun_v400_0.4_PETG_Fast_Visual.inst.cfg"] = Directories.FormatIntent(Filaments.PETG);
        this["/cura/intent/PETG/flsun_v400_0.4_PETG_High_Visual.inst.cfg"] = Directories.FormatIntent(Filaments.PETG);
        this["/cura/intent/PETG/flsun_v400_0.4_PETG_Normal_Quality_Accurate.inst.cfg"] = Directories.FormatIntent(Filaments.PETG);
        this["/cura/intent/PETG/flsun_v400_0.4_PETG_Normal_Visual.inst.cfg"] = Directories.FormatIntent(Filaments.PETG);
        this["/cura/intent/PETG/flsun_v400_0.4_PETG_VeryDraft_Print_Quick.inst.cfg"] = Directories.FormatIntent(Filaments.PETG);
        this["/cura/variants/flsun_v400_0.25.inst.cfg"] = Directories.Variants;
        this["/cura/variants/flsun_v400_0.4.inst.cfg"] = Directories.Variants;
        this["/cura/variants/flsun_v400_0.6.inst.cfg"] = Directories.Variants;
        this["/cura/variants/flsun_v400_0.8.inst.cfg"] = Directories.Variants;
        this["/cura/quality/flsun_v400_global_Draft_Quality.inst.cfg"] = Directories.Quality;
        this["/cura/quality/flsun_v400_global_Fast_Quality.inst.cfg"] = Directories.Quality;
        this["/cura/quality/flsun_v400_global_High_Quality.inst.cfg"] = Directories.Quality;
        this["/cura/quality/flsun_v400_global_Normal_Quality.inst.cfg"] = Directories.Quality;
        this["/cura/quality/flsun_v400_global_Superdraft_Quality.inst.cfg"] = Directories.Quality;
        this["/cura/quality/flsun_v400_global_Verydraft_Quality.inst.cfg"] = Directories.Quality;
        this["/cura/quality/PLA/0.25/flsun_v400_0.25_PLA_Normal_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .25);
        this["/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_Draft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .4);
        this["/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_Fast_Print.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .4);
        this["/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_High_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .4);
        this["/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_Normal_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .4);
        this["/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_VeryDraft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .4);
        this["/cura/quality/PLA/0.6/flsun_v400_0.6_PLA_Fast_Print.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .6);
        this["/cura/quality/PLA/0.6/flsun_v400_0.6_PLA_High_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .6);
        this["/cura/quality/PLA/0.6/flsun_v400_0.6_PLA_Normal_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .6);
        this["/cura/quality/PLA/0.8/flsun_v400_0.8_PLA_Draft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .8);
        this["/cura/quality/PLA/0.8/flsun_v400_0.8_PLA_Superdraft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .8);
        this["/cura/quality/PLA/0.8/flsun_v400_0.8_PLA_Verydraft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.PLA, .8);
        this["/cura/quality/ABS/0.25/flsun_v400_0.25_ABS_Normal_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .25);
        this["/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_Draft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .4);
        this["/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_Fast_Print.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .4);
        this["/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_High_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .4);
        this["/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_Normal_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .4);
        this["/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_VeryDraft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .4);
        this["/cura/quality/ABS/0.6/flsun_v400_0.6_ABS_Fast_Print.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .6);
        this["/cura/quality/ABS/0.6/flsun_v400_0.6_ABS_High_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .6);
        this["/cura/quality/ABS/0.6/flsun_v400_0.6_ABS_Normal_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .6);
        this["/cura/quality/ABS/0.8/flsun_v400_0.8_ABS_Draft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .8);
        this["/cura/quality/ABS/0.8/flsun_v400_0.8_ABS_Superdraft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .8);
        this["/cura/quality/ABS/0.8/flsun_v400_0.8_ABS_Verydraft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.ABS, .8);
        this["/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_Draft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.PETG, .4);
        this["/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_Fast_Print.inst.cfg"] = Directories.FormatQuality(Filaments.PETG, .4);
        this["/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_High_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.PETG, .4);
        this["/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_Normal_Quality.inst.cfg"] = Directories.FormatQuality(Filaments.PETG, .4);
        this["/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_VeryDraft_Print.inst.cfg"] = Directories.FormatQuality(Filaments.PETG, .4);
    }
}