public string Right(string original, int numberCharacters)
{
    return original.Substring(original.Length - numberCharacters);
}

public string Left(string original, int numberCharacters)
{
    return original.Substring(0, numberCharacters);
}

public string Mid(string original, int index, int numberCharacters)
{
    return original.Substring(index, numberCharacters);
}