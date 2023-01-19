using Loader.Library;
using Loader.Terminal;
using McMaster.Extensions.CommandLineUtils;

#if DEBUG
    args = new[] { "--whatIf", "--log" };
#endif

var app = new CommandLineApplication();

app.HelpOption();

var whatIf = app.Option("--whatIf", "Test run the app, does not modify anything.", CommandOptionType.NoValue);
var stdOut = app.Option("--log", "Log the output to the terminal.", CommandOptionType.NoValue);
var firmwareOpts = DownloadList.Firmwares.Select(_ => _.Label).ToArray();
string? firmware = null;
string? cura = null;

while (string.IsNullOrEmpty(firmware))
{
    var selection = SelectionHelpers.GetInput("Select Klipper", firmwareOpts);

    firmware = DownloadList.Firmwares.FirstOrDefault(_ => _.Label == selection)?.Value;
}

while (string.IsNullOrEmpty(cura))
{
    cura = SelectionHelpers.GetInput("Select Cura Version", DownloadList.Versions);
}

app.OnExecuteAsync(async (CancellationToken cancellationToken) =>
{
    var success = await CopyFilesAsync(firmware, cura, whatIf.Values.Count > 0, stdOut.Values.Count > 0);

    if (success)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("All set.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Whoops, something went wrong! Check the output log for details.");
    }

    Console.ResetColor();
    Console.WriteLine(string.Empty);
    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();

    return success ? 0 : 1;
});

return await app.ExecuteAsync(args);

static async Task<bool> CopyFilesAsync(string firmware, string cura, bool whatIf, bool stdOut)
{
    using var logger = new Logger(stdOut);
    var copyService = new CopyService(whatIf);

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Please wait ...");
    Console.WriteLine(string.Empty);
    Console.ResetColor();

    return await copyService.CopyFilesAsync(logger, firmware, cura);
}
