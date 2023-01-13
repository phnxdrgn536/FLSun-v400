using System.Text;

namespace Loader;

public class Logger : IDisposable
{
    private readonly string _fileName = $".\\output-{DateTime.Now:yyyyMMdd-hhmmss}.txt";
    private readonly StringBuilder _buffer = new();
    private bool _disposed = false;

    public Logger()
    {
        WriteLine("Start", DateTime.Now.ToString("o"));
    }

    public void WriteLine(string type, string content) =>
        _buffer.AppendLine($"{type.ToUpper()}:\t\t{content}");

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
