using System.Text;

namespace Loader.Library;

public class Logger : IDisposable
{
    private readonly string _fileName;
    private readonly bool _standardOut;
    private readonly StringBuilder _buffer = new();
    private bool _disposed = false;

    public Logger(bool standardOut = false)
    {
        var now = DateTime.Now;

        _fileName = Path.Join(Directory.GetCurrentDirectory(), $"output-{now:yyyyMMdd-hhmmss}.txt");
        _standardOut = standardOut;

        WriteLine("Start", now.ToString("o"));
    }

    public void WriteLine(string type, string content)
    {
        var line = $"{type.ToUpper()}:\t\t{content}";

        _buffer.AppendLine(line);

        if (_standardOut)
        {
            Console.WriteLine(line);
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            WriteLine("Complete", DateTime.Now.ToString("o"));

            File.WriteAllText(_fileName, _buffer.ToString());
        }

        _disposed = true;
    }

    public void Dispose()
    {
        // Dispose of unmanaged resources.
        Dispose(true);
        // Suppress finalization.
        GC.SuppressFinalize(this);
    }
}
