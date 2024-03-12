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
    /// Serializes a specified object using the specified format provider.
    /// </summary>
    /// <typeparam name="T">Specifies the type of the input object.</typeparam>
    /// <param name="input">Specifies the object to serialize.</param>
    /// <param name="formatProvider">Specifies the format provider to use.</param>
    /// <returns>The result of serializing the specified input.</returns>
    string? Serialize<T>(T input, IFormatProvider? formatProvider = null);
    
    /// <summary>
    /// Deserializes a specified input into an object of the specified type using the specified format provider.
    /// </summary>
    /// <typeparam name="T">Specifies the type of the output object.</typeparam>
    /// <param name="input">Specifies the input to deserialize.</param>
    /// <param name="formatProvider">Specifies the format provider to use.</param>
    /// <returns>The result of deserializing the specified input.</returns>
    T? Deserialize<T>(string? input, IFormatProvider? formatProvider = null);
}
