using System.Reflection;
using Pasper.Extensions;

namespace Pasper.Tests.Reflection;

/// <summary>
/// Tests for the <see cref="Pasper.Extensions.MemberInfoExtensions.IsObfuscated"/> method.
/// </summary>
public sealed class IsObfuscatedTests
{
    [Fact]
    public void IsObfuscated_WhenSourceIsNull_ThrowsArgumentNullException()
    {
        Type? source = null;
        Assert.Throws<ArgumentNullException>(() => source.IsObfuscated());
    }
    
    [Fact]
    public void IsObfuscated_WhenSourceIsMarkedWithObfuscationAttributeAndExcludeIsFalse_ReturnsTrue()
    {
        var source = typeof(ObfuscatedSample);
        var result = source.IsObfuscated();
        Assert.True(result);
    }
    
    [Fact]
    public void IsObfuscated_WhenSourceIsMarkedWithObfuscationAttributeAndExcludeIsTrue_ReturnsFalse()
    {
        var source = typeof(ExcludedObfuscatedSample);
        var result = source.IsObfuscated();
        Assert.False(result);
    }
    
    [Fact]
    public void IsObfuscated_WhenSourceIsNotMarkedWithObfuscationAttribute_ReturnsFalse()
    {
        var source = typeof(NonObfuscatedSample);
        var result = source.IsObfuscated();
        Assert.False(result);
    }

    [Obfuscation(Exclude = false)]
    private static class ObfuscatedSample;
    
    [Obfuscation(Exclude = true)]
    private static class ExcludedObfuscatedSample;
    
    private static class NonObfuscatedSample;
}