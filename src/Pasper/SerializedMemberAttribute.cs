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

namespace Pasper;

/// <summary>
/// Defines a simplified common attribute for defining how members should be serialized.
/// </summary>
/// <param name="name">The name of the member when serialized.</param>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class SerializedMemberAttribute(string name)
    : Attribute,
      ISerializedMemberAttribute
{
    /// <summary>
    /// Gets or sets the name of the member when serialized.
    /// </summary>
    public string Name { get; } = name;
}
