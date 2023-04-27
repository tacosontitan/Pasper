using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Pasper.Reflection;

/// <summary>
/// Defines extension methods for determining if a member should be serialized.
/// </summary>
public static class SerializedExtensions
{
    /// <summary>
    /// Determines if the specified field should be serialized.
    /// </summary>
    /// <param name="source">The field to check.</param>
    /// <param name="name">The name of the field to use when serializing.</param>
    /// <returns><see langword="true"/> if the field should be serialized; otherwise, <see langword="false"/>.</returns>
    public static bool IsSerialized(this FieldInfo source, out string name)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), "The field information cannot be null.");

        name = string.Empty;
        IEnumerable<object> attributes = source.GetCustomAttributes();
        object boxedSerializedAttribute = attributes?.SingleOrDefault(ImplementsSerializedInterface);
        if (boxedSerializedAttribute is null)
            return false;

        ISerializedAttribute serializedAttribute = (ISerializedAttribute)boxedSerializedAttribute;
        name = string.IsNullOrWhiteSpace(serializedAttribute.Name)
            ? source.Name
            : serializedAttribute.Name;

        return true;
    }

    /// <summary>
    /// Determines if the specified property should be serialized.
    /// </summary>
    /// <param name="source">The property to check.</param>
    /// <param name="name">The name of the property to use when serializing.</param>
    /// <returns><see langword="true"/> if the property should be serialized; otherwise, <see langword="false"/>.</returns>
    public static bool IsSerialized(this PropertyInfo source, out string name)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), "The property information cannot be null.");

        name = string.Empty;
        IEnumerable<object> attributes = source.GetCustomAttributes();
        object boxedSerializedAttribute = attributes?.SingleOrDefault(ImplementsSerializedInterface);
        if (boxedSerializedAttribute is null)
            return false;

        ISerializedAttribute serializedAttribute = (ISerializedAttribute)boxedSerializedAttribute;
        name = string.IsNullOrWhiteSpace(serializedAttribute.Name)
            ? source.Name
            : serializedAttribute.Name;

        return true;
    }

    private static bool ImplementsSerializedInterface(object attribute)
    {
        Type attributeType = attribute.GetType();
        return typeof(ISerializedAttribute).IsAssignableFrom(attributeType);
    }
}
