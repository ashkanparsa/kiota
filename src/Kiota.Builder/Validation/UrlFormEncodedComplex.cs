﻿
using System.Linq;
using Kiota.Builder.Configuration;
using Kiota.Builder.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Validations;

namespace Kiota.Builder.Validation;
public class UrlFormEncodedComplex : ValidationRule<OpenApiOperation>
{
    private static readonly StructuredMimeTypesCollection validContentTypes = new() {
        "application/x-www-form-urlencoded",
    };
    public UrlFormEncodedComplex() : base(nameof(UrlFormEncodedComplex), static (context, operation) =>
    {
        if (operation.GetRequestSchema(validContentTypes) is OpenApiSchema requestSchema)
            ValidateSchema(requestSchema, context, "request body");
        if (operation.GetResponseSchema(validContentTypes) is OpenApiSchema responseSchema)
            ValidateSchema(responseSchema, context, "response body");
    })
    {
    }
    private static void ValidateSchema(OpenApiSchema schema, IValidationContext context, string schemaName)
    {
        if (schema == null) return;
        if (!schema.IsObjectType())
            context.CreateWarning(nameof(UrlFormEncodedComplex), $"The operation {context.PathString} has a {schemaName} which is not an object type. This is not supported by Kiota and serialization will fail.");
        if (schema.Properties.Any(static x => x.Value.IsObjectType()))
            context.CreateWarning(nameof(UrlFormEncodedComplex), $"The operation {context.PathString} has a {schemaName} with a complex properties and the url form encoded content type. This is not supported by Kiota and serialization of complex properties will fail.");
    }
}
