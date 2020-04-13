using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Writers;

namespace Geone.DataHub.AspNetCore.Swagger
{
    internal class OpenApiRawString : IOpenApiAny, IOpenApiPrimitive
    {
        public OpenApiRawString(string value)
        {
            Value = value;
        }

        public AnyType AnyType => AnyType.Primitive;

        public PrimitiveType PrimitiveType => PrimitiveType.String;

        public string Value { get; }

        public static implicit operator OpenApiRawString(OpenApiString value)
            => ToOpenApiRawString(value);

        public static implicit operator OpenApiString(OpenApiRawString value)
            => ToOpenApiString(value);

        public static OpenApiRawString ToOpenApiRawString(OpenApiString value)
            => new OpenApiRawString(value.Value);

        public static OpenApiString ToOpenApiString(OpenApiRawString value)
            => new OpenApiString(value.Value);

        public void Write(IOpenApiWriter writer, OpenApiSpecVersion specVersion)
        {
            writer.WriteRaw(Value);
        }
    }
}
