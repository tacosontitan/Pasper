using System;

namespace Pasper.Extensibility;

/// <summary>
/// Defines extension methods for serializing data using <see cref="ISerializationProvider"/>.
/// </summary>
public static class SerializationExtensions
{
    /// <summary>
    /// Serializes the target object.
    /// </summary>
    /// <typeparam name="TData">The type of the target object.</typeparam>
    /// <typeparam name="TProvider">The type of the serialization provider.</typeparam>
    /// <param name="target">The target object.</param>
    /// <returns>The serialized object.</returns>
    public static string Serialize<TData, TProvider>(this TData target) where
        TProvider : ISerializationProvider, new()
    {
        ISerializationProvider provider = Activator.CreateInstance<TProvider>();
        return provider.Serialize(target);
    }
}
