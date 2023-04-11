namespace Pasper;

/// <summary>
/// Defines a serialization provider.
/// </summary>
public interface ISerializationProvider
{
    /// <summary>
    /// Serializes the input object.
    /// </summary>
    /// <typeparam name="T">The type of the input object.</typeparam>
    /// <param name="input">The input object.</param>
    /// <returns>The serialized object.</returns>
    string Serialize<T>(T input);
    /// <summary>
    /// Deserializes the input string.
    /// </summary>
    /// <typeparam name="T">The type of the output object.</typeparam>
    /// <param name="input">The input string.</param>
    /// <returns>The deserialized object.</returns>
    T Deserialize<T>(string input);
}
