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
/// Defines a serialization provider.
/// </summary>
public interface ISerializationProvider
{
    /// <summary>
    /// Serializes the input object.
    /// </summary>
    /// <typeparam name="T">The type of the input object.</typeparam>
    /// <param name="input">The input object.</param>
    /// <returns>The serialized object.</returns>
    string Serialize<T>(T input);
    /// <summary>
    /// Deserializes the input string.
    /// </summary>
    /// <typeparam name="T">The type of the output object.</typeparam>
    /// <param name="input">The input string.</param>
    /// <returns>The deserialized object.</returns>
    T Deserialize<T>(string input);
}
