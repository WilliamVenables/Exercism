// Based on daniel-leal's solution

using System.Text;

public static class Identifier
{
    private static bool IsLowercaseGreekLetter(char c) => c is >= 'α' and <= 'ω';
    
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();
        var followsDash = false;

        foreach (var c in identifier)
        {
            sb.Append(c switch
            {
                _ when IsLowercaseGreekLetter(c) => null,
                _ when followsDash => char.ToUpperInvariant(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => null
            });
            
            followsDash = c.Equals('-');
        }

        return sb.ToString();
    }
}