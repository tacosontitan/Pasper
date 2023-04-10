using System;

namespace Pasper;

/// <summary>
/// Indicates that the marked member should be ignored during serialization.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class IgnoreAttribute : Attribute, IIgnored
{

}
