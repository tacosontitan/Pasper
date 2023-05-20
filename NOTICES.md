# 📑 Third Party Notices

This project includes many third-party dependencies, each of which with their own licenses. This document is intended to provide a summary of the dependencies utilized and their licenses.

> **Note**  
> In the event that a license is inaccurate, or we have missed a dependency or a license, please [open an issue](https://github.com/tacosontitan/Pasper/issues/new?assignees=&labels=needs+categorization%2Cunder+review&projects=&template=other_request.yml) so that we can correct it.
>
> **Warning**  
> This document is not intended to be a replacement for the licenses themselves, and the licenses themselves should be consulted for the full up-to-date terms and conditions. In the event of a conflict between this document and the licenses themselves, the original licenses shall be considered the source of truth.

## Dependencies

The following dependencies are utilized by this project:

- [NSubstitute](#nsubstitute)
- [XUnit](#xunit)
  - [ConsoleHelper](#consolehelper)
- [coverlet](#coverlet)
  - [ConsoleTables](#consoletables)

### NSubstitute

NSubstitute is licensed under the BSD License:

> Copyright (c) 2009 Anthony Egerton (<nsubstitute@delfish.com>) and David Tchepak (<dave@davesquared.net>)
> All rights reserved.
>
> Redistribution and use in source and binary forms, with or without modification,
> are permitted provided that the following conditions are met:
>  
>     * Redistributions of source code must retain the above copyright notice,
>     this list of conditions and the following disclaimer.
>     * Redistributions in binary form must reproduce the above copyright notice,
>     this list of conditions and the following disclaimer in the documentation
>     and/or other materials provided with the distribution.
>     * Neither the names of the copyright holders nor the names of 
>     contributors may be used to endorse or promote products derived from this
>     software without specific prior written permission.
>
> THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
> ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
> WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
> DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
> FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
> DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
> SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
> CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
> OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
> THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
>
> [ https://www.opensource.org/licenses/bsd-license.php ]

For more information about NSubstitute, please visit the [NSubstitute GitHub repository](https://github.com/nsubstitute/NSubstitute).

### XUnit

XUnit is licensed under the Apache License 2.0:

> Copyright (c) .NET Foundation and Contributors
> All Rights Reserved
>
> Licensed under the Apache License, Version 2.0 (the "License");
> you may not use this file except in compliance with the License.
> You may obtain a copy of the License at
>
>     http://www.apache.org/licenses/LICENSE-2.0
>
> Unless required by applicable law or agreed to in writing, software
> distributed under the License is distributed on an "AS IS" BASIS,
> WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
> See the License for the specific language governing permissions and
> limitations under the License.

For more information about XUnit, please visit the [XUnit GitHub repository](https://github.com/xunit/xunit).

#### ConsoleHelper

The [source for `ConsoleHelper`](https://github.com/xunit/xunit/blob/main/src/xunit.v3.runner.common/Utility/ConsoleHelper.cs) was adapted from code from MSBuild which is covered by an MIT license:

> The MIT License (MIT)
>
> Copyright (c) .NET Foundation and contributors
>
> All rights reserved.
>
> Permission is hereby granted, free of charge, to any person obtaining a copy
> of this software and associated documentation files (the "Software"), to deal
> in the Software without restriction, including without limitation the rights
> to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
> copies of the Software, and to permit persons to whom the Software is
> furnished to do so, subject to the following conditions:
>
> The above copyright notice and this permission notice shall be included in all
> copies or substantial portions of the Software.
>
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
> IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
> FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
> AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
> LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
> OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
> SOFTWARE.

For more information about MSBuild, please visit the [MSBuild GitHub repository](https://github.com/dotnet/msbuild).

### coverlet

coverlet is licensed under the MIT License:

> The MIT License (MIT)
>
> Copyright (c) 2018 Toni Solarin-Sodara
>
> Permission is hereby granted, free of charge, to any person obtaining a copy
> of this software and associated documentation files (the "Software"), to deal
> in the Software without restriction, including without limitation the rights
> to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
> copies of the Software, and to permit persons to whom the Software is
> furnished to do so, subject to the following conditions:
>
> The above copyright notice and this permission notice shall be included in all
> copies or substantial portions of the Software.
>
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
> IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
> FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
> AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
> LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
> OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
> SOFTWARE.

For more information about coverlet, please visit the [coverlet GitHub repository](https://github.com/coverlet-coverage/coverlet).

#### ConsoleTables

`coverlet` utilizes a third-party library called `ConsoleTables` which is licensed under the MIT License:

> The MIT License (MIT)
>
> Copyright (c) 2012 Khalid Abuhakmeh
>
> Permission is hereby granted, free of charge, to any person obtaining a copy
> of this software and associated documentation files (the "Software"), to deal
> in the Software without restriction, including without limitation the rights
> to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
> copies of the Software, and to permit persons to whom the Software is
> furnished to do so, subject to the following conditions:
>
> The above copyright notice and this permission notice shall be included in all
> copies or substantial portions of the Software.
>
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
> IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
> FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
> AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
> LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
> OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
> SOFTWARE.

For more information about ConsoleTables, please visit the [ConsoleTables GitHub repository](https://github.com/khalidabuhakmeh/ConsoleTables).
