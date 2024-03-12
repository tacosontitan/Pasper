using System.Diagnostics.Contracts;
using System.Reflection;

namespace Pasper.Reflection;

/// <summary>
/// Extension methods for <see cref="Type"/> instances.
/// </summary>
public static partial class TypeExtensions
{
    /// <summary>
    ///     Determines whether the specified type is marked with a non-excluded
    ///     instance of the <see cref="ObfuscationAttribute"/>.
    /// </summary>
    /// <param name="source">Specifies the type to check.</param>
    /// <returns><see langword="true"/> if the type is obfuscated; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException">
    ///     The source is null.
    /// </exception>
    [Pure]
    public static bool IsObfuscated(this Type? source)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), "The source type cannot be null.");
        
        var obfuscationAttribute = source.GetCustomAttribute<ObfuscationAttribute>();
        return obfuscationAttribute is { Exclude: false };
    }
}