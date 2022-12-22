/* https://dotnet.microsoft.com/en-us/download/visual-studio-sdks
 * https://dotnet.microsoft.com/en-us/download
 * open c# will prompt .NET SDK installation if not present, min req > v5
 * .NET sdk is free version, compare to VS2022 .NET desktop build tools
 */

/* to start a consle app, use dotnet new <template> -o <projdir>, EG:
 * > dotnet new console -o day1part1
 * See https://aka.ms/new-console-template for more information
 * https://code.visualstudio.com/docs/languages/dotnet
 */

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
string home = Environment.ExpandEnvironmentVariables("%HOME%");
string[] lines = System.IO.File.ReadAllLines(@"%HOME%/Projects/AOC/AOC22/input-1.txt".Replace("%HOME%", home));
aoc.Day1Part1 day1part1 = new aoc.Day1Part1(lines);
Console.WriteLine("max cals = " + day1part1.MaxCals);