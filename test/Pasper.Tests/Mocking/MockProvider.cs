using System.Text;
using Pasper.Reflection;

namespace Pasper.Tests.Mocking;

internal sealed class MockProvider : ISerializationProvider
{
    public string Serialize<T>(T input)
    {
        var properties = typeof(T).GetProperties();
        var serializedInput = new StringBuilder();
        foreach (var property in properties)
        {
            if (property.IsIgnored())
                continue;

            if (!property.IsSerialized(out string key))
                continue;

            serializedInput.AppendFormat("{0}: {1}\n", key, property.GetValue(input));
        }

        return serializedInput.ToString();
    }

    public T Deserialize<T>(string input) => default;
}
