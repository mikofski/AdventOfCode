namespace aoc {
    public class Day1Part1 {
        public double MaxCals;  // max calories carried by any elf

        /// <summary>
        /// Class to solve Adevent of Code 2022 Day 1 - Part 1: find the max
        /// calories carried by any elf. 
        /// </summary>
        /// <param name="lines">an array of strings containing lines of the
        /// input file <Array of String></param>
        public Day1Part1(string[] lines) {

            int nlines = lines.Length;
            int elves = 0;
            int[] totcals = new int[nlines];  // totcals list must be shorter than nlines
            int idx = 0;

            // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number

            foreach (string line in lines)
            {
                if (Int32.TryParse(line, out int elf)) {
                    elves += elf;
                } else {
                    totcals[idx++] = elves;
                    elves = 0;
                }
            }
            MaxCals = totcals.Max();
        }
    }
}