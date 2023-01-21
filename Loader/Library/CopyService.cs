namespace Loader.Library;

public class CopyService
{
    private const string BASE_ADDRESS = "https://raw.githubusercontent.com/phnxdrgn536/FLSun-v400/main/cura/";

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

        await DownloadFile(logger, $"flsun_v400_{firmware}.def.json", Path.Combine(curaDirectory, Directories.Definitions));

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

    private static string GetCuraLocation(string? version) =>
        Path.Join(GetAppDataDirectory(), "cura", version);

    private static bool IsUnixLike()
    {
        // Should return true if the system behaves like a
        // "traditional" Unix system.
        return (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD());
    }

    private static string GetAppDataDirectory()
    {
        if (OperatingSystem.IsWindows())
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        if (OperatingSystem.IsMacOS())
        {
            return Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Library", "Application Support");
        }

        if (IsUnixLike())
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        }

        throw new InvalidOperationException($"Unknown operating system.");
    }

    private async Task DownloadFile(Logger logger, string url, string dir)
    {
        var download = Array.Empty<byte>();

        logger.WriteLine("Download", $"{BASE_ADDRESS}{url}");

        if (!_whatIf)
        {
            try
            {
                var response = await _client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                download = await response.Content.ReadAsByteArrayAsync();
            }
            catch (Exception ex)
            {
                logger.WriteLine("Error", ex.ToString());

                throw;
            }
        }

        await WriteFile(logger, dir, Path.GetFileName(url), download);
    }

    private async Task WriteFile(Logger logger, string directory, string fileName, byte[] content)
    {
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        var path = Path.Combine(directory, fileName);

        logger.WriteLine("Write", path);

        if (!_whatIf)
        {
            await File.WriteAllBytesAsync(path, content);
        }
    }
}
