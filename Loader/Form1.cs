namespace Loader;

public partial class Form1 : Form
{
    private const string BASE_ADDRESS = "https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/";
    private readonly HttpClient client = new();
    private readonly Downloads _downloads = new();

    private readonly List<string> lines = new();

    public Form1()
    {
        InitializeComponent();

        client.BaseAddress = new Uri(BASE_ADDRESS);
    }

    private void load_pb_Click(object sender, EventArgs e)
    {
        DownloadFiles();
    }

    private void DownloadFiles()
    {
        var firm = Firm_v.SelectedItem.ToString();
        var curaDirectory = GetCuraLocation(Cura_v.SelectedItem.ToString());

        foreach (var url in _downloads.Keys)
        {
            DownloadFile(url, Path.Combine(curaDirectory, _downloads[url]));
        }

        DownloadFile($"/cura/flsun_v400_{firm}.def.json", Path.Combine(curaDirectory, Directories.Definitions));

        var originalFilepath = Path.Combine(curaDirectory, Directories.Definitions, $"flsun_v400_{firm}.def.json");
        var newFilepath = Path.Combine(curaDirectory, Directories.Definitions, "flsun_v400.def.json");

        lines.Add($"Replacing: {originalFilepath}, {newFilepath}.");
        // File.Move(originalFilepath, newFilepath, true);

        File.WriteAllLines(".\\output.txt", lines);

        MessageBox.Show(
            "Profile loading complete.",
            "Download Complete",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information); ;
    }

    private string GetCuraLocation(string? version) =>
        $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\cura\\{version}";

    private void DownloadFile(string url, string dir)
    {
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        var fileName = Path.GetFileName(url);
        var filePath = Path.Combine(dir, fileName);

        lines.Add($"Downloading: {url}, {filePath}.");

        // TODO:
        // var download = client.GetString(url);

        // File.WriteAllLines(filePath, download);
    }

    #region Nonsense

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

    #endregion
}
