namespace paystream.src.Interfaces;

public interface IValidateService
{
    bool IsEmptyVariable<T>(T value);
    string NormalizeString(string? str);
}