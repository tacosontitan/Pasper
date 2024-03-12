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
    public static string? Serialize<TData, TProvider>(this TData target) where
        TProvider : ISerializationProvider, new()
    {
        ISerializationProvider provider = Activator.CreateInstance<TProvider>();
        return provider.Serialize(target);
    }
}
