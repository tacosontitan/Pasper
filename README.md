# 🎨 Pasper

Pasper is a proxy for serialization services that allows consumers to simplify their attribute requirements by using a single attribute to describe how a type should be serialized, or ignored.

![License](https://img.shields.io/github/license/tacosontitan/Pasper?logo=github&style=for-the-badge)

The name is a combination of the acronym PASP (Provider Agnostic Serialization Proxy) and provider to create a unique name that is easy to remember.

## 💁‍♀️ Getting Started

Get started by reviewing the answers to the following questions:

- [How do I navigate the codebase with confidence?](http://pasper.tacosontitan.com)
- [How can I help?](./CONTRIBUTING.md)
- [How should I behave here?](./CODE_OF_CONDUCT.md)
- [How do I report security concerns?](./SECURITY.md)

### ✅ Small changes, continuously integrated

Pasper employs workflows for continuous integration to ensure the repository is held to industry standards; here's the current state of those workflows:

![.NET Workflow](https://img.shields.io/github/actions/workflow/status/tacosontitan/Pasper/dotnet.yml?label=Build%20and%20Test&logo=dotnet&style=for-the-badge)

### 💎 A few more gems

We believe in keeping the community informed, so here's a few more tidbits of information to satisfy some additional curiosities:

![Contributors](https://img.shields.io/github/contributors/tacosontitan/Pasper?logo=github&style=for-the-badge)
![Issues](https://img.shields.io/github/issues/tacosontitan/Pasper?logo=github&style=for-the-badge)
![Stars](https://img.shields.io/github/stars/tacosontitan/Pasper?logo=github&style=for-the-badge)
![Size](https://img.shields.io/github/languages/code-size/tacosontitan/Pasper?logo=github&style=for-the-badge)
![Line Count](https://img.shields.io/tokei/lines/github/tacosontitan/Pasper?logo=github&style=for-the-badge)

## 🛣️ Roadmap

The following is a list of features that are planned for the future:

- [x] Create a common attribute for ignoring members.
- [ ] Create a common attribute for serializing members.
- [ ] Create a way to transform member names based on the format.
- [ ] Add support for JSON.
- [ ] Add support for YAML.
- [ ] Add support for XML.

Each format Pasper provides support for will be contained in its own assembly to allow consumers to only include the formats they need. The naming convention for these assemblies will be `Pasper.{Format}.{Provider}`, for example:

- `Pasper.Json.Newtonsoft`
- `Pasper.Yaml.YamlDotNet`

The provider name for `System` namespaces is currently up for debate:

- `Pasper.Json.System` or `Pasper.Json.Microsoft`
- `Pasper.Xml.System` or `Pasper.Xml.Microsoft`

This will allow consumers to easily identify not only the format they're after, but the provider they want to use as well.

### 🆘 What problem does Pasper aim to solve

Most serialization providers define their own attributes for defining how members should be serialized or ignored. This can lead to a lot of clutter in your codebase, especially if you're using multiple providers:

```csharp
[XmlElement("Id")]
[JsonProperty("id")]
[YamlMember(Alias = "id")]
public int Id { get; set; }
```

Each provider does it a little bit differently, and each provider has its own set of attributes. This can lead to a lot of code duplication, and a lot of confusion when you're trying to figure out how to serialize a type. The idea behind Pasper is to simplify this:

```csharp
[SerializedMember("id")]
public int Id { get; set; }
```

This is a lot cleaner, and a lot easier to understand. It also allows you to easily switch providers without having to change your codebase. This is especially useful if you're using multiple providers, and you want to switch from one to another.

### 🏆 What is the biggest obstacle currently

XML supports many different attributes such as `XmlElement` and `XmlAttribute`. This will need to be taken into consideration while designing the common interface as most other formats aren't as flexible. This is likely to be the most challenging aspect of this project, and will require a lot of thought and consideration.

### 🤔 Something else to think about

Currently, consumers have complete control over how their types are serialized with each specific provider. This means that Pasper will have to provide a way to support this level of control, while still providing a simplified way to serialize types. One way we might approach this is by preferring the provider defined attribute over the Pasper defined attribute. This would allow consumers to use the provider defined attribute to override the Pasper defined attribute, while still providing a simplified way to serialize types. This is likely the most concise way to provide this level of control, but it's not likely to be the only way, so we're open for ideas.

Imagine the following scenario:

```csharp
[XmlElement("ID")]
[SerializedMember("id")]
public int Id { get; set; }
```

In this use-case, the consumer is using the `XmlElement` attribute to define how the `Id` property should be serialized. Pasper should respect this, and use the `XmlElement` attribute to serialize the property, rather than the `SerializedMember` attribute. However, for all other providers, Pasper should use the `SerializedMember` attribute to serialize the property.

#### 🔤 How should we handle casing

Ideally, we just take the input and use that as the desired output, regardless of format. However, we should consider transformation of the output based on the format. This can easily be achieved by using an interface, `Func<string, string>` or many other methods that provide the consumer with the ability to transform the output.

### ✨ Potential Features

The following is a list of features that are being considered for the future:

- [ ] Add support for TOML.
- [ ] Add support for CBOR.
- [ ] Add support for INI.
- [ ] Add support for HOCON.
