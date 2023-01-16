namespace Loader.WinUI;

partial class Form1
{
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
        this.load_pb.Click += new System.EventHandler(this.load_pb_Click);
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

    private ComboBox Cura_v;
    private ComboBox Firm_v;
    private Label label1;
    private Label label2;
    private Button load_pb;
    private Label label3;

    #endregion
}
