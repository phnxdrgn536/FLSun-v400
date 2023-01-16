using Loader.Library;

var copyService = new CopyService(true);
using var logger = new Logger();

var firmware = ""; //Firm_v.SelectedItem.ToString();
var cura = ""; // Cura_v.SelectedItem.ToString();

var success = await copyService.CopyFilesAsync(logger, firmware, cura);

if (success)
{
    Console.WriteLine("All set.");
}
else
{
    Console.WriteLine("Whoops!");
}
