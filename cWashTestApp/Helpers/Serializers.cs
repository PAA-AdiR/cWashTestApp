using cWashTestApp.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace cWashTestApp.Helpers
{
    public static class Serializers
    {
        public static readonly JsonSerializerOptions SerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new JsonStringEnumConverter(), new JsonReplaceStringConverter() }
        };

        public static byte[] SerializeCommandToBinary(Command command)
        {
            var jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(command, SerializerOptions);
            return jsonUtf8Bytes;
        }

        public static byte[] SerializeProtocolToBinary(Protocol protocol)
        {
            var jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(protocol, SerializerOptions);
            return jsonUtf8Bytes;
        }
    }
}
