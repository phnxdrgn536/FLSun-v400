cd %appdata%\cura\5.2 && md meshes

cd %appdata%\cura\5.2\meshes && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/meshes/flsun_v400.stl)

cd %appdata%\cura\5.2\definitions && (curl -o flsun_v400.def.json https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/flsun_v400_STOCK.def.json)

cd %appdata%\cura\5.2\extruders && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/extruders/flsun_v400_extruder_0.def.json)

cd %appdata%\cura\5.2\intent && md PETG PLA

cd %appdata%\cura\5.2\intent\PETG && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_Draft_Print_Quick.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_Fast_Print_Accurate.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_Fast_Visual.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_High_Visual.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_Normal_Quality_Accurate.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_Normal_Visual.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_VeryDraft_Print_Quick.inst.cfg)

cd %appdata%\cura\5.2\intent\PLA && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_Draft_Print_Quick.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_Fast_Print_Accurate.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_Fast_Visual.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_High_Visual.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_Normal_Quality_Accurate.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_Normal_Visual.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_VeryDraft_Print_Quick.inst.cfg)

cd %appdata%\cura\5.2\quality && md ABS PETG PLA

curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_Draft_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_Fast_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_High_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_Normal_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_Superdraft_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_Verydraft_Quality.inst.cfg

cd %appdata%\cura\5.2\quality\ABS && md 0.25 0.4 0.6 0.8

cd %appdata%\cura\5.2\quality\ABS\0.25 && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.25/flsun_v400_0.25_ABS_Normal_Quality.inst.cfg)

cd %appdata%\cura\5.2\quality\ABS\0.4 && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_Draft_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_Fast_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_High_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_Normal_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_VeryDraft_Print.inst.cfg)

cd %appdata%\cura\5.2\quality\ABS\0.6 && (curl -O  https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.6/flsun_v400_0.6_ABS_Fast_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.6/flsun_v400_0.6_ABS_High_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.6/flsun_v400_0.6_ABS_Normal_Quality.inst.cfg)

cd %appdata%\cura\5.2\quality\ABS\0.8 && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.8/flsun_v400_0.8_ABS_Draft_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.8/flsun_v400_0.8_ABS_Verydraft_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.8/flsun_v400_0.8_ABS_Superdraft_Print.inst.cfg)

cd %appdata%\cura\5.2\quality\PETG && md 0.25 0.4 0.6 0.8

cd %appdata%\cura\5.2\quality\PETG\0.4 && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_Draft_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_Fast_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_High_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_Normal_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_VeryDraft_Print.inst.cfg)

cd %appdata%\cura\5.2\quality\PLA && md 0.25 0.4 0.6 0.8

cd %appdata%\cura\5.2\quality\PLA\0.25 && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.25/flsun_v400_0.25_PLA_Normal_Quality.inst.cfg)

cd %appdata%\cura\5.2\quality\PLA\0.4 && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_Draft_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_Fast_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_High_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_Normal_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_VeryDraft_Print.inst.cfg)

cd %appdata%\cura\5.2\quality\PLA\0.6 && (curl -O  https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.6/flsun_v400_0.6_PLA_Fast_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.6/flsun_v400_0.6_PLA_High_Quality.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.6/flsun_v400_0.6_PLA_Normal_Quality.inst.cfg)

cd %appdata%\cura\5.2\quality\PLA\0.8 && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.8/flsun_v400_0.8_PLA_Draft_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.8/flsun_v400_0.8_PLA_Verydraft_Print.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.8/flsun_v400_0.8_PLA_Superdraft_Print.inst.cfg)

cd %appdata%\cura\5.2\variants && (curl -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/variants/flsun_v400_0.25.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/variants/flsun_v400_0.4.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/variants/flsun_v400_0.6.inst.cfg -O https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/variants/flsun_v400_0.8.inst.cfg)

start "" "C:\Program Files\Ultimaker Cura 5.2.1\ultimaker-cura.exe"
