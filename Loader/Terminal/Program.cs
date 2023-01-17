using Loader.Library;
using Loader.Terminal;

var copyService = new CopyService(true);
using var logger = new Logger();

var firmware = string.Empty;
var cura = string.Empty;

while (string.IsNullOrEmpty(firmware))
{
    firmware = GetInput("Select Firmware", DownloadList.Firmwares);
}

while (string.IsNullOrEmpty(cura))
{
    cura = GetInput("Select Cura Version", DownloadList.Versions);
}

var success = await copyService.CopyFilesAsync(logger, firmware, cura);

if (success)
{
    Console.WriteLine("All set.");
}
else
{
    Console.WriteLine("Whoops!");
}

static string GetInput(string message, string[] options)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"{message}: (Use arrow keys to select, Enter to submit.)");

    var selection = SelectionHelpers.MakeSelection(options);

    Console.ResetColor();
    Console.WriteLine(string.Empty);

    return options[selection];
}