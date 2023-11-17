
//Console application?
//Ask User for comma-separated list of first names?
//Split string into string array?
// Loop through array and print "Hello <name>" to the console for each person?

string? input = null;

Console.Write("Please enter comma-separated list of first names (no spaces). ");
input = Console.ReadLine();

string[] firstNames = input.Split(",").ToArray();

for (int i = 0; i < firstNames.Length; i++)
{
    Console.WriteLine($"Hello {firstNames[i]}");
}


