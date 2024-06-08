public interface ILogger
{
    void Log(string message);
    void LogWarning(string message) => Log($"Warning: {message}"); // Default implementation
}
