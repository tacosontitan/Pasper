using System;

namespace Pasper;

/// <summary>
/// Defines a simplified common attribute for defining how members should be serialized.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class SerializedAttribute : Attribute, ISerializedAttribute
{
    /// <summary>
    /// Creates a new <see cref="SerializedAttribute"/> instance.
    /// </summary>
    /// <param name="name">The name of the member when serialized.</param>
    public SerializedAttribute(string name) =>
        Name = name;

    /// <summary>
    /// Gets or sets the name of the member when serialized.
    /// </summary>
    public string Name { get; set; }
}
