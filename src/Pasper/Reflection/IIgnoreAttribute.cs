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

using System.Diagnostics.CodeAnalysis;

namespace Pasper;

/// <summary>
/// A simple marker interface for defining proxies of the <see cref="IgnoreAttribute"/> type.
/// </summary>
[SuppressMessage("Design", "CA1040:Avoid empty interfaces", Justification = "This is a marker interface.")]
[SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix",
    Justification = "This is an interface representing an attribute.")]
public interface IIgnoreAttribute;