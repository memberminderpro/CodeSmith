public static string SplitCamelCase(string input)
    {
		if (input.Substring( input.Length-2) == "ID" )
			return input;
		if (input  == "dFlag" )
			return "Deleted";
		return System.Text.RegularExpressions.Regex.Replace(input, "([A-Z])", " $1", System.Text.RegularExpressions.RegexOptions.Compiled).Trim();
    }