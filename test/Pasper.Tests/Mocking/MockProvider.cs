using System.Text;

namespace Pasper.Tests.Mocking;

internal sealed class MockProvider : ISerializationProvider
{
    public string Serialize<T>(T input)
    {
        var properties = typeof(T).GetProperties();
        var sb = new StringBuilder();
        foreach (var property in properties)
        {
            var attributes = property.GetCustomAttributes(false);
            if (attributes.Any(a => typeof(IIgnoreAttribute).IsAssignableFrom(a.GetType())))
                continue;

            string key = attributes
                .SingleOrDefault(a => typeof(ISerializedAttribute).IsAssignableFrom(a.GetType()))
                ?.ToString()
                ?? property.Name;

            sb.AppendFormat("{0}: {1}\n", key, property.GetValue(input));
        }

        return sb.ToString();
    }

    public T Deserialize<T>(string input) => default;
}