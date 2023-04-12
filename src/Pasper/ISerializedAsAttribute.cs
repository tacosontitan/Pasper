namespace Pasper;

/// <summary>
/// Defines how members are serialized.
/// </summary>
public interface ISerializedAsAttribute
{
    /// <summary>
    /// The name of the member when serialized.
    /// </summary>
    string Name { get; set; }
}
