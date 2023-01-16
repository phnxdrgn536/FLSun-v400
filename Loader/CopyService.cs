namespace Loader;

public class CopyService
{
    private const string BASE_ADDRESS = "https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/";

    private readonly bool _whatIf;
    private readonly DownloadList _downloads = new();
    private readonly HttpClient _client = new();

    public CopyService(bool whatIf = false)
    {
        _whatIf = whatIf;

        _client.BaseAddress = new Uri(BASE_ADDRESS);
    }

    public async Task<bool> CopyFilesAsync(Logger logger, string? firmware, string? curaVersion)
    {
        var curaDirectory = GetCuraLocation(curaVersion);

        foreach (var directory in _downloads)
        {
            await IterateDirectory(logger, directory, curaDirectory);
        }

        await DownloadFile(logger, $"/cura/flsun_v400_{firmware}.def.json", Path.Combine(curaDirectory, Directories.Definitions));

        var originalFilepath = Path.Combine(curaDirectory, Directories.Definitions, $"flsun_v400_{firmware}.def.json");
        var newFilepath = Path.Combine(curaDirectory, Directories.Definitions, "flsun_v400.def.json");

        logger.WriteLine("Replace", $"{originalFilepath} => {newFilepath}");

        if (!_whatIf)
        {
            File.Move(originalFilepath, newFilepath, true);
        }

        return true;
    }

    private async Task IterateDirectory(Logger logger, DownloadDirectory directory, string curaDirectory)
    {
        var path = Path.Combine(curaDirectory, directory.Name);

        foreach (var url in directory.Files)
        {
            await DownloadFile(logger, url, path);
        }
    }

    private string GetCuraLocation(string? version) =>
        $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\cura\\{version}";

    private async Task DownloadFile(Logger logger, string url, string dir)
    {
        string? download = null;

        logger.WriteLine("Download", $"{BASE_ADDRESS.TrimEnd('/')}{url}");

        if (!_whatIf)
        {
            try
            {
                download = await _client.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                logger.WriteLine("Error", ex.ToString());
            }
        }

        WriteFile(logger, dir, Path.GetFileName(url), download);
    }

    private void WriteFile(Logger logger, string directory, string fileName, string? content)
    {
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        var path = Path.Combine(directory, fileName);

        logger.WriteLine("Write", path);

        if (!_whatIf)
        {
            File.WriteAllText(path, content);
        }
    }
}
