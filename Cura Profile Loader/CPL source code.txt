using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;

namespace Cura_Profile_Loader
{
    partial class Form1
    {
        private List<Tuple<string, string>> filesToDownload = new List<Tuple<string, string>>();

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cura_v = new System.Windows.Forms.ComboBox();
            this.Firm_v = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.load_pb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cura_v
            // 
            this.Cura_v.FormattingEnabled = true;
            this.Cura_v.Items.AddRange(new object[] {
            "5.0",
            "5.1",
            "5.2",
            "5.3",
            "5.4"});
            this.Cura_v.Location = new System.Drawing.Point(139, 12);
            this.Cura_v.Name = "Cura_v";
            this.Cura_v.Size = new System.Drawing.Size(50, 28);
            this.Cura_v.TabIndex = 0;
            this.Cura_v.SelectedIndexChanged += new System.EventHandler(this.cura_v_SelectedIndexChanged);
            this.Cura_v.SelectedIndex= 0;
            // 
            // Firm_v
            // 
            this.Firm_v.FormattingEnabled = true;
            this.Firm_v.Items.AddRange(new object[] {
            "stock",
            "Reflashed"});
            this.Firm_v.Location = new System.Drawing.Point(139, 45);
            this.Firm_v.Name = "Firm_v";
            this.Firm_v.Size = new System.Drawing.Size(100, 28);
            this.Firm_v.TabIndex = 1;
            this.Firm_v.SelectedIndexChanged += new System.EventHandler(this.firm_v_SelectedIndexChanged);
            this.Firm_v.SelectedIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cura version";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firmware version";
            // 
            // load_pb
            // 
            this.load_pb.Location = new System.Drawing.Point(43, 100);
            this.load_pb.Name = "load_pb";
            this.load_pb.Size = new System.Drawing.Size(366, 75);
            this.load_pb.TabIndex = 4;
            this.load_pb.Text = "Load Cura Profiles";
            this.load_pb.UseVisualStyleBackColor = true;
            this.load_pb.Click += new System.EventHandler(this.DownloadFile);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "NOTE: If you are unsure of your firmware version choose \"stock\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 180);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.load_pb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Firm_v);
            this.Controls.Add(this.Cura_v);
            this.Name = "Form1";
            this.Text = "Cura Profile Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        int completedDownloads = 0;

        private void DownloadFile(object sender, EventArgs e)
        {
            string firm = Firm_v.SelectedItem.ToString();
            string firmwareurl = "https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/flsun_v400_" + firm + ".def.json";

            // Add items to the list of files to download
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/extruders/flsun_v400_extruder_0.def.json", "extruders"));
            filesToDownload.Add(new Tuple<string, string>(firmwareurl, "definitions"));
            filesToDownload.Add(new Tuple<string, string>("https://github.com/phnxdrgn536/FLSun-v400/raw/main/cura/meshes/flsun_v400.stl", "Meshes"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_Draft_Print_Quick.inst.cfg", "intent\\PLA"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_Fast_Print_Accurate.inst.cfg", "intent\\PLA"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_Fast_Visual.inst.cfg", "intent\\PLA"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_High_Visual.inst.cfg", "intent\\PLA"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_Normal_Quality_Accurate.inst.cfg", "intent\\PLA"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_Normal_Visual.inst.cfg", "intent\\PLA"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PLA/flsun_v400_0.4_PLA_VeryDraft_Print_Quick.inst.cfg", "intent\\PLA"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_Draft_Print_Quick.inst.cfg", "intent\\PETG"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_Fast_Print_Accurate.inst.cfg", "intent\\PETG"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_Fast_Visual.inst.cfg", "intent\\PETG"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_High_Visual.inst.cfg", "intent\\PETG"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_Normal_Quality_Accurate.inst.cfg", "intent\\PETG"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_Normal_Visual.inst.cfg", "intent\\PETG"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/intent/PETG/flsun_v400_0.4_PETG_VeryDraft_Print_Quick.inst.cfg", "intent\\PETG"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/variants/flsun_v400_0.25.inst.cfg", "variants"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/variants/flsun_v400_0.4.inst.cfg", "variants"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/variants/flsun_v400_0.6.inst.cfg", "variants"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/variants/flsun_v400_0.8.inst.cfg", "variants"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_Draft_Quality.inst.cfg", "quality"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_Fast_Quality.inst.cfg", "quality"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_High_Quality.inst.cfg", "quality"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_Normal_Quality.inst.cfg", "quality"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_Superdraft_Quality.inst.cfg", "quality"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/flsun_v400_global_Verydraft_Quality.inst.cfg", "quality"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.25/flsun_v400_0.25_PLA_Normal_Quality.inst.cfg", "quality\\PLA\\0.25"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_Draft_Print.inst.cfg", "quality\\PLA\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_Fast_Print.inst.cfg", "quality\\PLA\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_High_Quality.inst.cfg", "quality\\PLA\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_Normal_Quality.inst.cfg", "quality\\PLA\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.4/flsun_v400_0.4_PLA_VeryDraft_Print.inst.cfg", "quality\\PLA\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.6/flsun_v400_0.6_PLA_Fast_Print.inst.cfg", "quality\\PLA\\0.6"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.6/flsun_v400_0.6_PLA_High_Quality.inst.cfg", "quality\\PLA\\0.6"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.6/flsun_v400_0.6_PLA_Normal_Quality.inst.cfg", "quality\\PLA\\0.6"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.8/flsun_v400_0.8_PLA_Draft_Print.inst.cfg", "quality\\PLA\\0.8"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.8/flsun_v400_0.8_PLA_Superdraft_Print.inst.cfg", "quality\\PLA\\0.8"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PLA/0.8/flsun_v400_0.8_PLA_Verydraft_Print.inst.cfg", "quality\\PLA\\0.8"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.25/flsun_v400_0.25_ABS_Normal_Quality.inst.cfg", "quality\\ABS\\0.25"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_Draft_Print.inst.cfg", "quality\\ABS\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_Fast_Print.inst.cfg", "quality\\ABS\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_High_Quality.inst.cfg", "quality\\ABS\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_Normal_Quality.inst.cfg", "quality\\ABS\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.4/flsun_v400_0.4_ABS_VeryDraft_Print.inst.cfg", "quality\\ABS\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.6/flsun_v400_0.6_ABS_Fast_Print.inst.cfg", "quality\\ABS\\0.6"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.6/flsun_v400_0.6_ABS_High_Quality.inst.cfg", "quality\\ABS\\0.6"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.6/flsun_v400_0.6_ABS_Normal_Quality.inst.cfg", "quality\\ABS\\0.6"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.8/flsun_v400_0.8_ABS_Draft_Print.inst.cfg", "quality\\ABS\\0.8"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.8/flsun_v400_0.8_ABS_Superdraft_Print.inst.cfg", "quality\\ABS\\0.8"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/ABS/0.8/flsun_v400_0.8_ABS_Verydraft_Print.inst.cfg", "quality\\ABS\\0.8"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_Draft_Print.inst.cfg", "quality\\PETG\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_Fast_Print.inst.cfg", "quality\\PETG\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_High_Quality.inst.cfg", "quality\\PETG\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_Normal_Quality.inst.cfg", "quality\\PETG\\0.4"));
            filesToDownload.Add(new Tuple<string, string>("https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/quality/PETG/0.4/flsun_v400_0.4_PETG_VeryDraft_Print.inst.cfg", "quality\\PETG\\0.4"));

            // Get the selected file location from the combobox
            string version = Cura_v.SelectedItem.ToString();
            string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\cura\\" + version;
            

            using (WebClient client = new WebClient())
            {

                foreach (var file in filesToDownload)
                {
                    string subfolder = file.Item2;
                    string url = file.Item1;
                    string subfolderPath = Path.Combine(fileLocation, subfolder);

                    if (!Directory.Exists(subfolderPath))
                        Directory.CreateDirectory(subfolderPath);

                    string filename = Path.GetFileName(url);
                    string filepath = Path.Combine(subfolderPath, filename);

                    client.DownloadFile(url, filepath);
                }
            }
            string originalFilepath = Path.Combine(fileLocation, "definitions", "flsun_v400_" + firm + ".def.json");
            string newFilepath = Path.Combine(fileLocation, "definitions", "flsun_v400.def.json");


            if (File.Exists(newFilepath))
            {
                File.Delete(newFilepath);
                File.Move(originalFilepath, newFilepath);
            }
            else
            {
                File.Move(originalFilepath, newFilepath);
            }

            MessageBox.Show("Profile loading complete.", "Download Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private ComboBox Cura_v;
        private ComboBox Firm_v;
        private Label label1;
        private Label label2;
        private Button load_pb;
        private Label label3;
    }
}