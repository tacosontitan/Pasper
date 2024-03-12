/*
 * Copyright 2023 tacosontitan and contributors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Reflection;

namespace Pasper.Reflection;

/// <summary>
/// Represents an attribute that identifies a type at runtime.
/// </summary>
/// <remarks>
///     This attribute is preferred when <see cref="ObfuscationAttribute"/> is detected and the
///     type is not excluded from obfuscation using <see cref="ObfuscationAttribute.Exclude"/>.
/// </remarks>
[AttributeUsage(
    validOn: AttributeTargets.Class
    | AttributeTargets.Struct
    | AttributeTargets.Interface
    | AttributeTargets.Enum
    | AttributeTargets.Property
    | AttributeTargets.Field,
    Inherited = false)]
public sealed class RuntimeIdentifierAttribute(string name)
    : Attribute
{
    /// <summary>
    /// Gets the name used to identify the type at runtime.
    /// </summary>
    public string Name { get; } = name;
}