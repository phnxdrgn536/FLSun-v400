namespace Loader.Terminal;


public static class SelectionHelpers
{
    public static string GetInput(string message, string[] options)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"{message}: (Use arrow keys to select, Enter to submit.)");

        var selection = SelectionHelpers.MakeSelection(options);

        Console.ResetColor();
        Console.WriteLine(string.Empty);

        return options[selection];
    }

    public static int MakeSelection(IEnumerable<string> options)
    {
        var selected = 0;
        var numOptions = options.Count();
        var restoreCursor = !OperatingSystem.IsWindows() || Console.CursorVisible;
        ConsoleKeyInfo input;

        Console.CursorVisible = false;

        do
        {
            for (var i = 0; i < numOptions; i++)
            {
                var isSelected = i == selected;

                Console.ForegroundColor = isSelected ? ConsoleColor.Green : ConsoleColor.DarkGray;
                Console.WriteLine($"    [{(isSelected ? "x" : " ")}] {options.ElementAt(i)}");
            }

            Console.ResetColor();

            do
            {
                input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.UpArrow && selected > 0)
                {
                    selected--;
                    WipeSelectionMenu(numOptions);

                    break;
                }
                else if (input.Key == ConsoleKey.DownArrow && selected < numOptions - 1)
                {
                    selected++;
                    WipeSelectionMenu(numOptions);

                    break;
                }
                else if (input.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
            while (true);
        }
        while (input.Key != ConsoleKey.Enter);

        Console.CursorVisible = restoreCursor;

        return selected;
    }

    private static void WipeSelectionMenu(int rows)
    {
        var bottom = Console.CursorTop;

        for (var i = 0; i < rows; i++)
        {
            Console.SetCursorPosition(0, --bottom);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, bottom);
        }
    }
}