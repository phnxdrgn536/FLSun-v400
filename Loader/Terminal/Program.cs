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
var firmware = string.Empty;
var cura = string.Empty;

while (string.IsNullOrEmpty(firmware))
{
    firmware = SelectionHelpers.GetInput("Select Firmware", DownloadList.Firmwares);
}

while (string.IsNullOrEmpty(cura))
{
    cura = SelectionHelpers.GetInput("Select Cura Version", DownloadList.Versions);
}

app.OnExecuteAsync(async (CancellationToken cancellationToken) =>
{
    return await CopyFilesAsync(firmware, cura, whatIf.Values.Count > 0, stdOut.Values.Count > 0);
});

return await app.ExecuteAsync(args);

static async Task<int> CopyFilesAsync(string firmware, string cura, bool whatIf, bool stdOut)
{
    var copyService = new CopyService(whatIf);
    using var logger = new Logger(stdOut);

    var success = await copyService.CopyFilesAsync(logger, firmware, cura);

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
}
