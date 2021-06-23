using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace cWashTestApp.Helpers
{
    public class JsonReplaceStringConverter : JsonConverter<string>
    {
        private const string Replacement = @";";

        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) 
            => Regex.Replace(reader.GetString(), Replacement, Environment.NewLine);

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options) 
            => writer.WriteStringValue(Regex.Replace(value, Environment.NewLine, Replacement));
    }
}
