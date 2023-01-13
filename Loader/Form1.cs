namespace Loader;

public partial class Form1 : Form
{
    private readonly CopyService _copyService = new(true);

    public Form1()
    {
        InitializeComponent();
    }

    private async void load_pb_Click(object sender, EventArgs e)
    {
        await HandleButtonClickAsync();
    }

    private async Task HandleButtonClickAsync()
    {
        var firmware = Firm_v.SelectedItem.ToString();
        var cura = Cura_v.SelectedItem.ToString();
        using var logger = new Logger();

        var success = await _copyService.CopyFilesAsync(logger, firmware, cura);

        if (success)
        {
            MessageBox.Show(
                "Profile loading complete.",
                "Download Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void cura_v_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void firm_v_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
}
