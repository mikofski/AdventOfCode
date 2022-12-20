// See https://aka.ms/new-console-template for more information
/* https://code.visualstudio.com/docs/languages/dotnet
 * to start a consle app, use dotnet new <template>
 * > dotnet new console -o day1part1 */

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number

string home = Environment.ExpandEnvironmentVariables("%HOME%");
string[] lines = System.IO.File.ReadAllLines(@"%HOME%/Projects/AOC/AOC22/input-1.txt".Replace("%HOME%", home));
int nlines = lines.Length;
int elves = 0;
int[] totcals = new int[nlines];  // totcals list must be shorter than nlines
int idx = 0;

foreach (string line in lines)
{
    if (Int32.TryParse(line, out int elf)) {
        elves += elf;
    } else {
        totcals[idx++] = elves;
        elves = 0;
    }
}

Console.WriteLine("max cals = " + totcals.Max());

// Keep the console window open in debug mode.
// Console.WriteLine("Press any key to exit.");
// System.Console.ReadKey();