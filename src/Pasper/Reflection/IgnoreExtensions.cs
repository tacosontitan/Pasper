using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Pasper.Reflection;

/// <summary>
/// Defines extension methods for determining if a member should be ignored.
/// </summary>
public static class IgnoreExtensions
{
    /// <summary>
    /// Determines if the specified field should be ignored.
    /// </summary>
    /// <param name="source">The field to check.</param>
    /// <returns><see langword="true"/> if the field should be ignored; otherwise, <see langword="false"/>.</returns>
    public static bool IsIgnored(this FieldInfo source)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), "The field information cannot be null.");

        IEnumerable<object> attributes = source.GetCustomAttributes();
        return attributes?.Any(ImplementsIgnoredInterface) == true;
    }

    /// <summary>
    /// Determines if the specified property should be ignored.
    /// </summary>
    /// <param name="source">The property to check.</param>
    /// <returns><see langword="true"/> if the property should be ignored; otherwise, <see langword="false"/>.</returns>
    public static bool IsIgnored(this PropertyInfo source)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), "The property information cannot be null.");

        IEnumerable<object> attributes = source.GetCustomAttributes();
        return attributes?.Any(ImplementsIgnoredInterface) == true;
    }

    private static bool ImplementsIgnoredInterface(object attribute)
    {
        Type attributeType = attribute.GetType();
        return typeof(IIgnoreAttribute).IsAssignableFrom(attributeType);
    }
}
