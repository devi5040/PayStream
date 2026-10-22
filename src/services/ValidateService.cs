using paystream.src.Interfaces;

namespace paystream.src.services;

public class ValidateService : IValidateService
{
    public bool IsEmptyVariable<T>(T value)
    {
        if (value is null)
            return true;

        if (value is string str)
            return string.IsNullOrWhiteSpace(str);
        return false;
    }

    public string NormalizeString(string? str)
    {
        return str is not null ? str.Trim() : string.Empty;
    }
}