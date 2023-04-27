namespace Pasper;

/// <summary>
/// Defines how members are serialized.
/// </summary>
public interface ISerializedAttribute
{
    /// <summary>
    /// The name of the member when serialized.
    /// </summary>
    string Name { get; set; }
}
