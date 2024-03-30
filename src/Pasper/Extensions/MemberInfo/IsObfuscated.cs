using System.Diagnostics.Contracts;
using System.Reflection;

namespace Pasper.Extensions;

/// <summary>
/// Extension methods for <see cref="MemberInfo"/> instances.
/// </summary>
public static partial class MemberInfoExtensions
{
    /// <summary>
    ///     Determines whether the specified <see cref="MemberInfo"/> is marked with a non-excluded
    ///     instance of the <see cref="ObfuscationAttribute"/>.
    /// </summary>
    /// <param name="source">Specifies the type to check.</param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="MemberInfo"/> is obfuscated;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    ///     The source is null.
    /// </exception>
    [Pure]
    public static bool IsObfuscated(this MemberInfo? source)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source), "The source type cannot be null.");
        
        var obfuscationAttribute = source.GetCustomAttribute<ObfuscationAttribute>();
        return obfuscationAttribute is { Exclude: false };
    }
}