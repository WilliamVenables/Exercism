using System.Text.RegularExpressions;
using static System.Char;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (string.IsNullOrEmpty(identifier)) return "";

        var cleanedString = identifier;

        // Remove Greek letters
        cleanedString = Regex.Replace(cleanedString, "[α-ω]", "");

        // Convert kebab-case to camelCase
        cleanedString = Regex.Replace(cleanedString, @"-([\w])",
            match => match.Groups[1].Value.ToUpper());

        // Replace control characters with 'CTRL'
        cleanedString = cleanedString.Replace("\0", "CTRL");

        // Remove characters that aren't letters or whitespace
        cleanedString = new string(cleanedString.Where(c => IsLetter(c) || IsWhiteSpace(c)).ToArray());

        // Replace spaces with underscores
        cleanedString = cleanedString.Replace(' ', '_');

        return cleanedString;
    }
}